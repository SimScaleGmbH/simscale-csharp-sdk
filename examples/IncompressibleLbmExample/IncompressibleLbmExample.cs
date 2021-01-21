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

class IncompressibleLbmExample
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
        var tableImportApi = new TableImportsApi(config);

        HashSet<Status> terminalStatuses = new HashSet<Status> {Status.FINISHED, Status.CANCELED, Status.FAILED};
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Restart();

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

        // Get geometry mappings
        var geometry_mappings = geometryApi.GetGeometryMappings(projectId, geometryId, _class: "face", entities: new List<string>{"Cylinder", "Cube 2", "Sphere"});
        var entities = geometry_mappings.Embedded.Select(mapping => mapping.Name).ToList();;
        Console.WriteLine("entities: " + String.Join(",", entities));

        // upload probe points
        var csvStorage = storageApi.CreateStorage();
        var csvStorageId = csvStorage.StorageId;
        var csvUploadRequest = new RestRequest(csvStorage.Url, Method.PUT);
        csvUploadRequest.AddParameter("application/octet-stream", File.ReadAllBytes(@"../fixtures/ProbePoint.csv"), ParameterType.RequestBody);
        restClient.Execute(csvUploadRequest);
        Console.WriteLine("Probepoint storageId: " + csvStorageId);
        
        // import probe points
        var tableImportRequest = new TableImportRequest(new TableImportRequestLocation(csvStorageId));
        var tableImport = tableImportApi.ImportTable(projectId, tableImportRequest);
        var tableId = tableImport.TableId;

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
            turbulenceModel: IncompressiblePacefish.TurbulenceModelEnum.KOMEGASSTDDES,
            material: new IncompressibleMaterial(
                        name: "Air",
                        viscosityModel: new NewtonianViscosityModel(
                            kinematicViscosity: new DimensionalKinematicViscosity(value: 0.00001529m, unit: DimensionalKinematicViscosity.UnitEnum.MS)
                        ),
                        density: new DimensionalDensity(value: 1.1965m, unit: DimensionalDensity.UnitEnum.KgM),
                        referenceTemperature: new DimensionalTemperature(value: 293.15m, unit: DimensionalTemperature.UnitEnum.K),
                        molarWeight: new DimensionalMolarMass(value: 28.97m, unit: DimensionalMolarMass.UnitEnum.KgKmol)
            ),
            flowDomainBoundaries: new FlowDomainBoundaries(
                xMIN: new VelocityInletBC(
                    name: "Velocity inlet (A)",
                    velocity: new FixedMagnitudeVBC(value: new DimensionalFunctionSpeed(value: new ConstantFunction(value: 10), unit: DimensionalFunctionSpeed.UnitEnum.MS)),
                    turbulenceIntensity: new TurbulenceIntensityTIBC(value: new DimensionalFunctionDimensionless(
                        value: new ConstantFunction(value: 0.01m), unit: DimensionalFunctionDimensionless.UnitEnum.Empty)),
                    dissipationType: new AutomaticOmegaDissipation()
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
                endTime: new DimensionalTime(value: 5, unit: DimensionalTime.UnitEnum.S),
                maxRunTime: new DimensionalTime(value: 10000, unit: DimensionalTime.UnitEnum.S)
            ),
            advancedModelling: new AdvancedModelling(
                surfaceRoughness: new List<SurfaceRoughness>(),
                porousObjects: new List<OneOfAdvancedModellingPorousObjects>(),
                rotatingWalls: new List<RotatingWall>()
            ),
            resultControl: new FluidResultControls(
                transientResultControl: new TransientResultControl(
                    writeControl: new CoarseResolution(),
                    fractionFromEnd: 0.2m,
                    exportFluid: true,
                    exportSurface: true,
                    geometryPrimitiveUuids: new List<Guid?> {localSlice1Uuid, localSlice2Uuid}
                ),
                statisticalAveragingResultControl: new StatisticalAveragingResultControlV2(
                    samplingInterval: new CoarseResolution(),
                    fractionFromEnd: 0.2m,
                    exportFluid: true,
                    exportSurface: true,
                    geometryPrimitiveUuids: new List<Guid?> {localSlice1Uuid, localSlice2Uuid}
                ),
                snapshotResultControl: new SnapshotResultControl(
                    exportFluid: true,
                    exportSurface: true,
                    geometryPrimitiveUuids: new List<Guid?> {localSlice1Uuid, localSlice2Uuid}
                ),
                probePoints: new List<ProbePointsResultControl> {
                    new ProbePointsResultControl(
                        type: "PROBE_POINTS",
                        name: "Probe point 1",
                        writeControl: new ModerateResolution(),
                        fractionFromEnd: 0.2m,
                        exportStatistics: true,
                        probeLocations: new TableDefinedProbeLocations(type:"TABULAR", objectId: tableId.ToString())
                        )
                },
                fieldCalculations: new List<OneOfFluidResultControlsFieldCalculations>(),
                forcesMoments: new List<OneOfFluidResultControlsForcesMoments> {
                    new ForcesMomentsResultControl(
                        name: "Forces and moments 1",
                        centerOfRotation: new DimensionalVectorLength(value: new DecimalVector(x:0m, y:0m, z:0m), unit:DimensionalVectorLength.UnitEnum.M),
                        writeControl: new HighResolution(),
                        fractionFromEnd: 0.2m,
                        exportStatistics: false,
                        groupAssignments: false,
                        topologicalReference: new TopologicalReference(
                            entities: entities, 
                            sets: new List<Guid?>() // TODO: default value null fails to load workbench
                        )
                    ),
                    new ForcesMomentsResultControl(
                        name: "Forces and moments 2",
                        centerOfRotation: new DimensionalVectorLength(value: new DecimalVector(x:0m, y:0m, z:0m), unit:DimensionalVectorLength.UnitEnum.M),
                        writeControl: new HighResolution(),
                        fractionFromEnd: 0.2m,
                        exportStatistics: true,
                        groupAssignments: true,
                        topologicalReference: new TopologicalReference(
                            entities: entities,
                            sets: new List<Guid?>() // TODO: default value null fails to load workbench
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
        var simulationSpec = new SimulationSpec(name: "Incompressible LBM", geometryId: geometryId, model: model);

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
    }
}
