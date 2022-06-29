using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System;
using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using RestSharp;
using SimScale.Sdk.Api;
using SimScale.Sdk.Client;
using SimScale.Sdk.Model;

class PedestrianWindComfortExample
{
    static void Main(string[] args)
    {
        // API client configuration
        var API_KEY_HEADER = "X-API-KEY";
        var API_KEY = Environment.GetEnvironmentVariable("SIMSCALE_API_KEY");
        var API_URL = Environment.GetEnvironmentVariable("SIMSCALE_API_URL");

        Configuration config = new Configuration();
        config.BasePath = API_URL + "/v0";
        config.ApiKey.Add(API_KEY_HEADER, API_KEY);

        // API clients
        var restClient = new RestClient();
        var projectApi = new ProjectsApi(config);
        var storageApi = new StorageApi(config);
        var geometryImportApi = new GeometryImportsApi(config);
        var geometryApi = new GeometriesApi(config);
        var windApi = new WindApi(config);
        var simulationApi = new SimulationsApi(config);
        var simulationRunApi = new SimulationRunsApi(config);
        var reportsApi = new ReportsApi(config);

        HashSet<Status> terminalStatuses = new HashSet<Status> {Status.FINISHED, Status.CANCELED, Status.FAILED};
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Restart();
        var failedTries = 0;

        // Create project
        var project = new Project(
            name: "Pedestrian Wind Comfort via CSharp SDK",
            description: "Pedestrian Wind Comfort via CSharp SDK",
            measurementSystem:Project.MeasurementSystemEnum.SI
        );
        project = projectApi.CreateProject(project);
        var projectId = project.ProjectId;
        Console.WriteLine("projectId: " + projectId);

        // Read project information and update with the deserialized model
        project = projectApi.GetProject(projectId);
        projectApi.UpdateProject(projectId, project);

        // Upload CAD
        var storage = storageApi.CreateStorage();
        var storageId = storage.StorageId;
        var uploadRequest = new RestRequest(storage.Url, Method.PUT);
        uploadRequest.AddParameter("application/octet-stream", File.ReadAllBytes(@"../fixtures/Cylinder.stl"), ParameterType.RequestBody);
        restClient.Execute(uploadRequest);
        Console.WriteLine("storageId: " + storageId);

        // Import CAD
        var geometryImportRequest = new GeometryImportRequest(
            name: "Cylinder",
            location: new GeometryImportRequestLocation(storageId),
            format: GeometryImportRequest.FormatEnum.STL,
            inputUnit: GeometryUnit.M,
            options: new GeometryImportRequestOptions(facetSplit: false, sewing: false, improve: true, optimizeForLBMSolver: true)
        );
        var geometryImport = geometryImportApi.ImportGeometry(projectId, geometryImportRequest);
        var geometryImportId = geometryImport.GeometryImportId;
        stopWatch.Restart();
        failedTries = 0;
        while(!terminalStatuses.Contains(geometryImport.Status))
        {
            // adjust timeout for larger geometries
            if(stopWatch.Elapsed.TotalSeconds > 900)
            {
                throw new TimeoutException();
            }
            Thread.Sleep(10000);
            geometryImport = geometryImportApi.GetGeometryImport(projectId, geometryImportId) ??
                (++failedTries > 5 ? throw new Exception("HTTP request failed too many times.") : geometryImport);
            Console.WriteLine("Geometry import status: " + geometryImport?.Status);
        }
        var geometryId = geometryImport.GeometryId;
        Console.WriteLine("geometryId: " + geometryId);

        // Read geometry information and update with the deserialized model
        var geometry = geometryApi.GetGeometry(projectId, geometryId);
        geometryApi.UpdateGeometry(projectId, geometryId, geometry);

        // The wind data can be user-defined or obtained from the WindApi, as shown in the following two examples:

        // 1. User-defined wind data for simulation spec
        var windRose = new WindRose(
            numDirections: 4,
            velocityBuckets: new List<WindRoseVelocityBucket> {
                new WindRoseVelocityBucket(from: null, to: 1.234m, fractions: new List<decimal?>{0.1m, 0.1m, 0.1m, 0.1m}),
                new WindRoseVelocityBucket(from: null, to: 1.234m, fractions: new List<decimal?>{0.0m, 0.1m, 0.1m, 0.1m}),
                new WindRoseVelocityBucket(from: null, to: 1.234m, fractions: new List<decimal?>{0.0m, 0.0m, 0.1m, 0.1m}),
                new WindRoseVelocityBucket(from: null, to: 1.234m, fractions: new List<decimal?>{0.0m, 0.0m, 0.0m, 0.1m})
            },
            velocityUnit: "m/s",
            exposureCategories: new List<WindRose.ExposureCategoriesEnum> {
                WindRose.ExposureCategoriesEnum.EC4,
                WindRose.ExposureCategoriesEnum.EC4,
                WindRose.ExposureCategoriesEnum.EC4,
                WindRose.ExposureCategoriesEnum.EC4
            },
            windEngineeringStandard: WindRose.WindEngineeringStandardEnum.EU,
            windDataSource: WindRose.WindDataSourceEnum.USERUPLOAD,
            addSurfaceRoughness: false
        );

        // 2. Get wind data from the WindApi for simulation spec
        var windApiResponse = windApi.GetWindDataWithHttpInfo("48.135125", "11.581981");
        if (windApiResponse.StatusCode == HttpStatusCode.TooManyRequests
            && windApiResponse.Headers.TryGetValue("X-Rate-Limit-Retry-After-Minutes", out var retryAfterMinutes))
        {
            throw new Exception($"Exceeded max amount requests, please retry in {retryAfterMinutes} minutes");
        }
        windRose = windApiResponse.Data.WindRose;
        windRose.NumDirections = 4;
        windRose.ExposureCategories = new List<WindRose.ExposureCategoriesEnum>(
            Enumerable.Repeat(WindRose.ExposureCategoriesEnum.EC4, windRose.NumDirections.Value)
        );
        windRose.AddSurfaceRoughness = false;

        // Define simulation spec
        var model = new WindComfort(
            regionOfInterest: new RegionOfInterest(
                discRadius: new DimensionalLength(value: 100m, unit: DimensionalLength.UnitEnum.M),
                centerPoint: new DimensionalVector2dLength(new DecimalVector2d(0, 0), unit: DimensionalVector2dLength.UnitEnum.M),
                groundHeight: new DimensionalLength(value: 0m, unit: DimensionalLength.UnitEnum.M),
                northAngle: new DimensionalAngle(value: 0m, unit: DimensionalAngle.UnitEnum.Deg),
                advancedSettings: new  AdvancedROISettings(
                    windTunnelSize: new WindTunnelSizeModerate()
                )
            ),
            windConditions: new WindConditions(
                geographicalLocation: new GeographicalLocation(
                    latitude: new DimensionalAngle(value: 48.13512m, unit: DimensionalAngle.UnitEnum.Deg),
                    longitude: new DimensionalAngle(value: 11.581981m, unit: DimensionalAngle.UnitEnum.Deg)
                ),
                windRose: windRose
            ),
            pedestrianComfortMap: new List<PedestrianComfortSurface> {
                new PedestrianComfortSurface(
                    name: "Pedestrian level 1",
                    heightAboveGround: new DimensionalLength(value: 1.5m, unit: DimensionalLength.UnitEnum.M),
                    ground: new GroundAbsolute()
                )
            },
            simulationControl: new WindComfortSimulationControl(
                maxDirectionRunTime: new DimensionalTime(value: 10000, unit: DimensionalTime.UnitEnum.S),
                numberOfFluidPasses: 0.2m
            ),
            advancedModelling: new AdvancedModelling(),
            additionalResultExport: new FluidResultControls(
                transientResultControl: new TransientResultControl(
                    writeControl: new CoarseResolution(),
                    fractionFromEnd: 0.1m
                ),
                statisticalAveragingResultControl: new StatisticalAveragingResultControlV2(
                    samplingInterval: new CoarseResolution(),
                    fractionFromEnd: 0.1m
                )
            ),
            meshSettings: new WindComfortMesh(
                windComfortFineness: new PacefishFinenessVeryCoarse()
            )
        );
        var simulationSpec = new SimulationSpec(name: "Pedestrian Wind Comfort via CSharp SDK", geometryId: geometryId, model: model);

        // Create simulation
        var simulationId = simulationApi.CreateSimulation(projectId, simulationSpec).SimulationId;
        Console.WriteLine("simulationId: " + simulationId);

        // Read simulation and update with the deserialized model
        simulationSpec = simulationApi.GetSimulation(projectId, simulationId);
        simulationApi.UpdateSimulation(projectId, simulationId, simulationSpec);

        // Check simulation
        var checkResult = simulationApi.CheckSimulationSetup(projectId, simulationId);
        var warnings = checkResult.Entries.Where(e => e.Severity == LogSeverity.WARNING).ToList();
        Console.WriteLine("Simulation check warnings:");
        warnings.ForEach(i => Console.WriteLine("{0}", i));
        var errors = checkResult.Entries.Where(e => e.Severity == LogSeverity.ERROR).ToList();
        if(errors.Any())
        {
            Console.WriteLine("Simulation check errors:");
            errors.ForEach(i => Console.WriteLine("{0}", i));
            throw new Exception("Simulation check failed");
        }

        // Estimate simulation
        var maxRuntime = 0.0;
        try
        {
            var estimationResult = simulationApi.EstimateSimulationSetup(projectId, simulationId);
            Console.WriteLine("Simulation estimation: " + estimationResult);

            if (estimationResult.Duration != null) {
                maxRuntime = System.Xml.XmlConvert.ToTimeSpan(estimationResult.Duration.IntervalMax).TotalSeconds;
                maxRuntime = Math.Max(3600, maxRuntime * 2);
            } else {
                maxRuntime = 36000;
                Console.WriteLine("Simulation estimated duration not available, assuming max runtime of {0} seconds", maxRuntime);
            }
        }
        catch (ApiException ae)
        {
            if(ae.ErrorCode == 422)
            {
                maxRuntime = 36000;
                Console.WriteLine("Simulation estimation not available, assuming max runtime of {0} seconds", maxRuntime);
            }
            else
            {
                throw ae;
            }
        }

        // Create simulation run
        var run = new SimulationRun(name: "Run 1");
        run = simulationRunApi.CreateSimulationRun(projectId, simulationId, run);
        var runId = run.RunId;
        Console.WriteLine("runId: " + runId);

        // Read simulation run and update with the deserialized model
        run = simulationRunApi.GetSimulationRun(projectId, simulationId, runId);
        simulationRunApi.UpdateSimulationRun(projectId, simulationId, runId, run);

        // Start simulation run and wait until it's finished
        simulationRunApi.StartSimulationRun(projectId, simulationId, runId);
        run = simulationRunApi.GetSimulationRun(projectId, simulationId, runId);
        stopWatch.Restart();
        failedTries = 0;
        while(!terminalStatuses.Contains(run.Status??Status.READY))
        {
            if(stopWatch.Elapsed.TotalSeconds > maxRuntime)
            {
                throw new TimeoutException();
            }
            Thread.Sleep(30000);
            run = simulationRunApi.GetSimulationRun(projectId, simulationId, runId) ??
                (++failedTries > 5 ? throw new Exception("HTTP request failed too many times.") : run);
            Console.WriteLine("Simulation run status: " + run?.Status + " - " + run?.Progress);
        }

        // Get result metadata and download results
        SimulationRunResults results = simulationRunApi.GetSimulationRunResults(projectId, simulationId, runId, null, null, "SOLUTION_FIELD", "STATISTICAL_SURFACE_SOLUTION", null, null, null);
        // Download averaged solution
        var statisticalSurfaceSolutionInfo = (SimulationRunResultSolution) results.Embedded[0];
        var statisticalSurfaceSolutionRequest = new RestRequest(statisticalSurfaceSolutionInfo.Download.Url, Method.GET);
        statisticalSurfaceSolutionRequest.AddHeader(API_KEY_HEADER, API_KEY);
        using (var writer = File.OpenWrite(@"statistical_surface_solution.zip"))
        {
            statisticalSurfaceSolutionRequest.ResponseWriter = responseStream =>
            {
                using (responseStream)
                {
                    responseStream.CopyTo(writer);
                }
            };
            restClient.DownloadData(statisticalSurfaceSolutionRequest);
        }
        using (var zip = System.IO.Compression.ZipFile.OpenRead(@"statistical_surface_solution.zip"))
        {
            Console.WriteLine("Statistical surface solution ZIP file content:");
            foreach (var entry in zip.Entries)
            {
                Console.WriteLine(entry);
            }
        }

        var reportRequest = new ReportRequest(
            name: "Report 1",
            description: "Simulation report",
            resultIds: new List < Guid ? > {
                statisticalSurfaceSolutionInfo.ResultId
            },
            reportProperties : new ScreenshotReportProperties(
                modelSettings: new ModelSettings(
                    parts: new List < Part > {
                        new Part(
                            partIdentifier: "Pedestrian level 1",
                            solidColor: new Color(r: 0.8f, g: 0.2f, b: 0.4f))
                    }
                ),
                filters: null,
                cameraSettings: new UserInputCameraSettings(
                    projectionType: ProjectionType.ORTHOGONAL,
                    up: new Vector3D(
                        x: (decimal) 0.5,
                        y: (decimal) 0.3,
                        z: (decimal) 0.2
                    ),
                    eye: new Vector3D(
                        x: (decimal) 0.0,
                        y: (decimal) 5.0,
                        z: (decimal) 10.0
                    ),
                    center: new Vector3D(
                        x: (decimal) 10.0,
                        y: (decimal) 12.0,
                        z: (decimal) 1.0
                    ),
                    frontPlaneFrustumHeight: (decimal) 0.5
                ),
                outputSettings: new ScreenshotOutputSettings(
                    name: "Output 1",
                    format: ScreenshotOutputSettings.FormatEnum.PNG,
                    resolution: new ResolutionInfo(x: 800, y: 800),
                    frameIndex: 0
                )
            )
        );

        // Creating report
        Console.WriteLine("Creating report...");
        var createReportResponse = reportsApi.CreateReport(projectId, reportRequest);
        var reportId = createReportResponse.ReportId;

        // Start report job
        Console.WriteLine("Starting report with ID: " + reportId);
        reportsApi.StartReportJob(projectId, reportId);

        HashSet < ReportResponse.StatusEnum > terminalReportStatuses = new HashSet < ReportResponse.StatusEnum > {
            ReportResponse.StatusEnum.FINISHED,
            ReportResponse.StatusEnum.CANCELED,
            ReportResponse.StatusEnum.FAILED
        };
        var report = reportsApi.GetReport(projectId, reportId);

        while (!terminalReportStatuses.Contains(report.Status)) {
            Thread.Sleep(30000);
            report = reportsApi.GetReport(projectId, reportId);
            Console.WriteLine("Report generation status: " + report.Status);
        }

        using(var client = new WebClient()) {
            Console.WriteLine("Downloading file from: " + report.Download.Url);
            client.Headers.Add(API_KEY_HEADER, API_KEY);
            client.DownloadFile(report.Download.Url, "report." + report.Download.Format);
        }

        // The following sections show a use case of the "additional wind data" functionality. This part is optional
        // when running a simple PWC simulation, but it can be helpful when running the same simulation multiple times
        // with different wind data. In this case, the directional results will be reused from the original simulation
        // run, only the statistical surface solution will be re-calculated.

        // Update the simulation spec
        model = (WindComfort) simulationApi.GetSimulation(projectId, simulationId).Model;
        model.PedestrianComfortMap[0].HeightAboveGround = new DimensionalLength(value: 1.8m, unit: DimensionalLength.UnitEnum.M);

        var updatedSimulationSpec = new SimulationSpec(name: "Pedestrian Wind Comfort with additional data", geometryId: geometryId, model: model);
        simulationApi.UpdateSimulation(projectId, simulationId, updatedSimulationSpec);

        // Create a simulation run based on the updated spec and the previous run
        var windData = new WindData(name: "Additional wind rose run");
        var additionalRun = simulationRunApi.AddWindDataToSimulationRun(projectId, simulationId, run.RunId, windData);
        var additionalRunId = additionalRun.RunId;

        // Start simulation run and wait until it's finished
        additionalRun = simulationRunApi.GetSimulationRun(projectId, simulationId, additionalRunId);
        stopWatch.Restart();
        failedTries = 0;
        while(!terminalStatuses.Contains(additionalRun.Status??Status.READY))
        {
            if(stopWatch.Elapsed.TotalSeconds > maxRuntime)
            {
                throw new TimeoutException();
            }
            Thread.Sleep(30000);
            additionalRun = simulationRunApi.GetSimulationRun(projectId, simulationId, additionalRunId) ??
                (++failedTries > 5 ? throw new Exception("HTTP request failed too many times.") : additionalRun);
            Console.WriteLine("Simulation run status: " + additionalRun?.Status + " - " + additionalRun?.Progress);
        }

        // Get result metadata and download results
        results = simulationRunApi.GetSimulationRunResults(projectId, simulationId, additionalRunId, null, null, "SOLUTION_FIELD", "STATISTICAL_SURFACE_SOLUTION", null, null, null);
        // Download averaged solution
        statisticalSurfaceSolutionInfo = (SimulationRunResultSolution) results.Embedded[0];
        statisticalSurfaceSolutionRequest = new RestRequest(statisticalSurfaceSolutionInfo.Download.Url, Method.GET);
        statisticalSurfaceSolutionRequest.AddHeader(API_KEY_HEADER, API_KEY);
        using (var writer = File.OpenWrite(@"statistical_surface_solution_updated.zip"))
        {
            statisticalSurfaceSolutionRequest.ResponseWriter = responseStream =>
            {
                using (responseStream)
                {
                    responseStream.CopyTo(writer);
                }
            };
            restClient.DownloadData(statisticalSurfaceSolutionRequest);
        }
        using (var zip = System.IO.Compression.ZipFile.OpenRead(@"statistical_surface_solution_updated.zip"))
        {
            Console.WriteLine("Statistical surface solution ZIP file content:");
            foreach (var entry in zip.Entries)
            {
                Console.WriteLine(entry);
            }
        }

    }
}
