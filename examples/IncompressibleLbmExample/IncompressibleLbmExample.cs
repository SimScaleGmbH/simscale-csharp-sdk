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

class IncompressibleLbmExample
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
        var simulationApi = new SimulationsApi(config);
        var simulationRunApi = new SimulationRunsApi(config);
        var tableImportApi = new TableImportsApi(config);
        var reportsApi = new ReportsApi(config);

        HashSet<Status> terminalStatuses = new HashSet<Status> {Status.FINISHED, Status.CANCELED, Status.FAILED};
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Restart();
        var failedTries = 0;

        // Create project
        var project = new Project(
            name: "Incompressible LBM via CSharp SDK",
            description: "Incompressible LBM via CSharp SDK",
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
        uploadRequest.AddParameter("application/octet-stream", File.ReadAllBytes(@"../fixtures/Shapes.stl"), ParameterType.RequestBody);
        restClient.Execute(uploadRequest);
        Console.WriteLine("storageId: " + storageId);

        // Import CAD
        var geometryImportRequest = new GeometryImportRequest(
            name: "Shapes",
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

        // Get geometry mappings
        var geometry_mappings = geometryApi.GetGeometryMappings(projectId, geometryId, _class: "face", entities: new List<string>{"Cylinder", "Cube 2", "Sphere"});
        var entities = geometry_mappings.Embedded.Select(mapping => mapping.Name).ToList();;
        Console.WriteLine("entities: " + String.Join(",", entities));

        // Upload table containing Probe Points information
        var probePointsCsvStorage = storageApi.CreateStorage();
        var probePointsCsvStorageId = probePointsCsvStorage.StorageId;
        var probePointsCsvUploadRequest = new RestRequest(probePointsCsvStorage.Url, Method.PUT);
        probePointsCsvUploadRequest.AddParameter("application/octet-stream", File.ReadAllBytes(@"../fixtures/ProbePoints.csv"), ParameterType.RequestBody);
        restClient.Execute(probePointsCsvUploadRequest);
        Console.WriteLine("Probe Points table storageId: " + probePointsCsvStorageId);

        // Import table containing Probe Points information
        var probePointsTableImportRequest = new TableImportRequest(new TableImportRequestLocation(probePointsCsvStorageId));
        var probePointsTableImport = tableImportApi.ImportTable(projectId, probePointsTableImportRequest);
        var probePointsTableId = probePointsTableImport.TableId;

        // Upload table containing Inlet Profile information
        var inletProfileCsvStorage = storageApi.CreateStorage();
        var inletProfileCsvStorageId = inletProfileCsvStorage.StorageId;
        var inletProfileCsvUploadRequest = new RestRequest(inletProfileCsvStorage.Url, Method.PUT);
        inletProfileCsvUploadRequest.AddParameter("application/octet-stream", File.ReadAllBytes(@"../fixtures/InletProfile.csv"), ParameterType.RequestBody);
        restClient.Execute(inletProfileCsvUploadRequest);
        Console.WriteLine("Inlet Profile table storageId: " + inletProfileCsvStorageId);

        // Import table containing Inlet Profile information
        var inletProfileTableImportRequest = new TableImportRequest(new TableImportRequestLocation(inletProfileCsvStorageId));
        var inletProfileTableImport = tableImportApi.ImportTable(projectId, inletProfileTableImportRequest);
        var inletProfileTableId = inletProfileTableImport.TableId;

        // Create geometry primitives
        var localSlice1 = new LocalHalfSpace(
            name: "Local slice 1",
            orientationReference: LocalHalfSpace.OrientationReferenceEnum.GEOMETRY,
            referencePoint: new DimensionalVectorLength(value: new DecimalVector(x: 0m, y: 0m, z: 0m), unit: DimensionalVectorLength.UnitEnum.M),
            normal: new DimensionalVectorLength(value: new DecimalVector(x: 1m, y: 0m, z: 0m), unit: DimensionalVectorLength.UnitEnum.M)
        );
        var localSlice1Uuid = simulationApi.CreateGeometryPrimitive(projectId, localSlice1).GeometryPrimitiveId;
        var localSlice2 = new LocalHalfSpace(
            name: "Local slice 2",
            orientationReference: LocalHalfSpace.OrientationReferenceEnum.GEOMETRY,
            referencePoint: new DimensionalVectorLength(value: new DecimalVector(x: 0m, y: 0m, z: 0m), unit: DimensionalVectorLength.UnitEnum.M),
            normal: new DimensionalVectorLength(value: new DecimalVector(x: 0m, y: 1m, z: 0m), unit: DimensionalVectorLength.UnitEnum.M)
        );
        var localSlice2Uuid = simulationApi.CreateGeometryPrimitive(projectId, localSlice2).GeometryPrimitiveId;
        var externalFlowDomain = new RotatableCartesianBox(
            name: "External Flow Domain",
            min: new DimensionalVectorLength(value: new DecimalVector(x: -350m, y: -100m, z: 0m), unit: DimensionalVectorLength.UnitEnum.M),
            max: new DimensionalVectorLength(value: new DecimalVector(x: 650m, y: 100m, z: 300m), unit: DimensionalVectorLength.UnitEnum.M),
            rotationPoint: new DimensionalVectorLength(value: new DecimalVector(x: 0m, y: 0m, z: 0m), unit: DimensionalVectorLength.UnitEnum.M),
            rotationAngles: new DimensionalVectorAngle(value: new DecimalVector(x: 0m, y: 0m, z: 0m), unit: DimensionalVectorAngle.UnitEnum.Deg)
        );
        var externalFlowDomainUuid = simulationApi.CreateGeometryPrimitive(projectId, externalFlowDomain).GeometryPrimitiveId;
        var meshRegion = new LocalCartesianBox(
            name: "Mesh Region",
            orientationReference: LocalCartesianBox.OrientationReferenceEnum.GEOMETRY,
            min: new DimensionalVectorLength(value: new DecimalVector(x: -30m, y: -30m, z: 0m), unit: DimensionalVectorLength.UnitEnum.M),
            max: new DimensionalVectorLength(value: new DecimalVector(x: 30m, y: 30m, z: 120m), unit: DimensionalVectorLength.UnitEnum.M)
        );
        var meshRegionUuid = simulationApi.CreateGeometryPrimitive(projectId, meshRegion).GeometryPrimitiveId;

        // Define simulation spec
        var model = new IncompressiblePacefish(
            boundingBoxUuid: externalFlowDomainUuid,
            flowDomainBoundaries: new FlowDomainBoundaries(
                xMIN: new VelocityInletBC(
                    name: "Velocity inlet (A)",
                    velocity: new FixedMagnitudeVBC(
                        value: new DimensionalFunctionSpeed(
                            value: new TableDefinedFunction(
                                tableId: inletProfileTableId,
                                resultIndex: new List<int?> {2},
                                independentVariables: new List<TableFunctionParameter> {
                                    new TableFunctionParameter(reference: 1, _parameter: "HEIGHT", unit: "m")
                                }
                            ),
                            unit: DimensionalFunctionSpeed.UnitEnum.MS
                        )
                    ),
                    turbulenceIntensity: new TurbulenceIntensityTIBC(
                        value: new DimensionalFunctionDimensionless(
                            value: new ConstantFunction(value: 0.015m),
                            unit: DimensionalFunctionDimensionless.UnitEnum.Empty
                        )
                    ),
                    dissipationType: new CustomOmegaDissipation(
                        value: new DimensionalFunctionSpecificTurbulenceDissipationRate(
                            value: new TableDefinedFunction(
                                tableId: inletProfileTableId,
                                resultIndex: new List<int?> {3},
                                independentVariables: new List<TableFunctionParameter> {
                                    new TableFunctionParameter(reference: 1, _parameter: "HEIGHT", unit: "m")
                                }
                            ),
                            unit: DimensionalFunctionSpecificTurbulenceDissipationRate.UnitEnum._1S
                        )
                    )
                ),
                xMAX: new PressureOutletBC(name: "Pressure outlet (B)"),
                yMIN: new WallBC(name: "Side (C)", velocity: new SlipVBC()),
                yMAX: new WallBC(name: "Side (D)", velocity: new SlipVBC()),
                zMIN: new WallBC(name: "Ground (E)", velocity: new NoSlipVBC(
                    surfaceRoughness: new DimensionalLength(value: 0m, unit: DimensionalLength.UnitEnum.M)
                )),
                zMAX: new WallBC(name: "Top (F)", velocity: new SlipVBC())
            ),
            simulationControl: new FluidSimulationControl(
                endTime: new DimensionalTime(value: 5, unit: DimensionalTime.UnitEnum.S)
            ),
            advancedModelling: new AdvancedModelling(),
            resultControl: new FluidResultControls(
                transientResultControl: new TransientResultControl(
                    writeControl: new CoarseResolution(),
                    exportFluid: true,
                    geometryPrimitiveUuids: new List<Guid?> {localSlice1Uuid, localSlice2Uuid}
                ),
                statisticalAveragingResultControl: new StatisticalAveragingResultControlV2(
                    samplingInterval: new CoarseResolution(),
                    exportFluid: true,
                    geometryPrimitiveUuids: new List<Guid?> {localSlice1Uuid, localSlice2Uuid},
                    exportSurface: true,
                    topologicalReference: new TopologicalReference(
                        entities: entities
                    )
                ),
                snapshotResultControl: new SnapshotResultControl(
                    exportFluid: true,
                    geometryPrimitiveUuids: new List<Guid?> {localSlice1Uuid, localSlice2Uuid}
                ),
                probePoints: new List<ProbePointsResultControl> {
                    new ProbePointsResultControl(
                        name: "Probe point 1",
                        writeControl: new ModerateResolution(),
                        probeLocations: new TableDefinedProbeLocations(tableId: probePointsTableId)
                        )
                },
                forcesMoments: new List<OneOfFluidResultControlsForcesMoments> {
                    new ForcesMomentsResultControl(
                        name: "Forces and moments 1",
                        centerOfRotation: new DimensionalVectorLength(value: new DecimalVector(x:0m, y:0m, z:0m), unit:DimensionalVectorLength.UnitEnum.M),
                        writeControl: new HighResolution(),
                        exportStatistics: false,
                        groupAssignments: false,
                        topologicalReference: new TopologicalReference(
                            entities: entities
                        )
                    ),
                    new ForcesMomentsResultControl(
                        name: "Forces and moments 2",
                        centerOfRotation: new DimensionalVectorLength(value: new DecimalVector(x:0m, y:0m, z:0m), unit:DimensionalVectorLength.UnitEnum.M),
                        writeControl: new HighResolution(),
                        fractionFromEnd: 0.3m,
                        topologicalReference: new TopologicalReference(
                            entities: entities
                        )
                    )
                }
            ),
            meshSettingsNew: new PacefishAutomesh(
                newFineness: new PacefishFinenessCoarse(),
                referenceLengthComputation: new AutomaticReferenceLength(),
                primaryTopology: new Region(geometryPrimitiveUuids: new List<Guid?> {meshRegionUuid})
            )
        );
        var simulationSpec = new SimulationSpec(name: "Incompressible LBM via CSharp SDK", geometryId: geometryId, model: model);

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
        SimulationRunResults results = simulationRunApi.GetSimulationRunResults(projectId, simulationId, runId);

        // Download probe point statistical data
        var probePointPlotStatisticalDataInfo = results.Embedded.Where(r => r.Type == "TABLE").Select(r => (SimulationRunResultTable)r).Where(r => r.Category == "PROBE_POINT_PLOT_STATISTICAL_DATA").ToList()[0];
        var probePointPlotStatisticalDataRequest = new RestRequest(probePointPlotStatisticalDataInfo.Download.Url, Method.GET);
        probePointPlotStatisticalDataRequest.AddHeader(API_KEY_HEADER, API_KEY);
        var probePointPlotStatisticalDataAsCsv = System.Text.Encoding.UTF8.GetString(restClient.DownloadData(probePointPlotStatisticalDataRequest));
        Console.WriteLine("Probe point plot statistical data as CSV: " + probePointPlotStatisticalDataAsCsv);
        // Write probe points to CSV file
        File.WriteAllText(@"probe_points.csv", probePointPlotStatisticalDataAsCsv);

        // Download averaged solution
        var averagedSolutionInfo = results.Embedded.Where(r => r.Type == "SOLUTION_FIELD").Select(r => (SimulationRunResultSolution)r).Where(r => r.Category == "AVERAGED_SOLUTION").ToList()[0];
        var averagedSolutionRequest = new RestRequest(averagedSolutionInfo.Download.Url, Method.GET);
        averagedSolutionRequest.AddHeader(API_KEY_HEADER, API_KEY);
        using (var writer = File.OpenWrite(@"averaged_solution.zip"))
        {
            averagedSolutionRequest.ResponseWriter = responseStream =>
            {
                using (responseStream)
                {
                    responseStream.CopyTo(writer);
                }
            };
            restClient.DownloadData(averagedSolutionRequest);
        }
        using (var zip = System.IO.Compression.ZipFile.OpenRead(@"averaged_solution.zip"))
        {
            Console.WriteLine("Averaged solution ZIP file content:");
            foreach (var entry in zip.Entries)
            {
                Console.WriteLine(entry);
            }
        }

        var reportRequest = new ReportRequest(
            name: "Report 1",
            description: "Simulation report",
            resultIds: new List < Guid ? > {
                averagedSolutionInfo.ResultId
            },
            reportProperties : new ScreenshotReportProperties(
                modelSettings: new ModelSettings(
                    parts: new List < Part > {
                        new Part(
                            partIdentifier: "data - surface-export-1",
                            solidColor: new Color(r: 0.8f, g: 0.2f, b: 0.4f)
                        ),
                        new Part(
                            partIdentifier: "data - surface-export-2",
                            solidColor: new Color(r: 0.2f, g: 0.4f, b: 0.8f)
                        ),
                        new Part(
                            partIdentifier: "data - surface-export-3",
                            solidColor: new Color(r: 0.4f, g: 0.8f, b: 0.2f)
                        )
                    },
                    scalarField: new ScalarField(
                        fieldName: "Velocity",
                        component: "X",
                        dataType: DataType.CELL
                    )
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
    }
}
