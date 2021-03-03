using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System;
using System.IO;
using System.Linq;
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
        Configuration config = new Configuration();
        config.BasePath = Environment.GetEnvironmentVariable("SIMSCALE_API_URL") + "/v0";
        config.ApiKey.Add(API_KEY_HEADER, API_KEY);

        // API clients
        var restClient = new RestClient();
        var projectApi = new ProjectsApi(config);
        var storageApi = new StorageApi(config);
        var geometryImportApi = new GeometryImportsApi(config);
        var geometryApi = new GeometriesApi(config);
        var simulationApi = new SimulationsApi(config);
        var simulationRunApi = new SimulationRunsApi(config);

        HashSet<Status> terminalStatuses = new HashSet<Status> {Status.FINISHED, Status.CANCELED, Status.FAILED};
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Restart();

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
            options: new GeometryImportRequestOptions(facetSplit: false, sewing: true, improve: true, optimizeForLBMSolver: true)
        );
        var geometryImport = geometryImportApi.ImportGeometry(projectId, geometryImportRequest);
        var geometryImportId = geometryImport.GeometryImportId;
        stopWatch.Restart();
        while(!terminalStatuses.Contains(geometryImport.Status))
        {
            // adjust timeout for larger geometries
            if(stopWatch.Elapsed.TotalSeconds > 900)
            {
                throw new TimeoutException();
            }
            Thread.Sleep(10000);
            geometryImport = geometryImportApi.GetGeometryImport(projectId, geometryImportId);
            Console.WriteLine("Geometry import status: " + geometryImport.Status);
        }
        var geometryId = geometryImport.GeometryId;
        Console.WriteLine("geometryId: " + geometryId);

        // Read geometry information and update with the deserialized model
        var geometry = geometryApi.GetGeometry(projectId, geometryId);
        geometryApi.UpdateGeometry(projectId, geometryId, geometry);

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
                windRose: new WindRose(
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
                )
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
        var simulationSpec = new SimulationSpec(name: "Pedestrian Wind Comfort", geometryId: geometryId, model: model);

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
            maxRuntime = System.Xml.XmlConvert.ToTimeSpan(estimationResult.Duration.IntervalMax).TotalSeconds;
            maxRuntime = maxRuntime + 600; // 10 min buffer
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
        while(!terminalStatuses.Contains(run.Status??Status.READY))
        {
            if(stopWatch.Elapsed.TotalSeconds > maxRuntime)
            {
                throw new TimeoutException();
            }
            Thread.Sleep(30000);
            run = simulationRunApi.GetSimulationRun(projectId, simulationId, runId);
            Console.WriteLine("Simulation run status: " + run.Status + " - " + run.Progress);
        }

        // Get result metadata and download results
        SimulationRunResults results = simulationRunApi.GetSimulationRunResults(projectId, simulationId, runId);
        // Download averaged solution
        var statisticalSurfaceSolutionInfo = results.Embedded.Where(r => r.Type == "SOLUTION_FIELD").Select(r => (SimulationRunResultSolution)r).Where(r => r.Category == "STATISTICAL_SURFACE_SOLUTION").ToList()[0];
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
    }
}
