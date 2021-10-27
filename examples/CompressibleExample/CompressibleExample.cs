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

public class CompressibleExample {

    public static List < string > getEntityNames(GeometriesApi geometryApi, string projectId, Guid geometryId,
        int num, List < string > values = null) {
        var entities = geometryApi.GetGeometryMappings(
            projectId: projectId,
            geometryId: geometryId,
            attributes: new List < string > {
                "SDL/TYSA_NAME"
            },
            values: values
        ).Embedded;
        if (entities.Count == num) {
            return entities.ConvertAll < string > (e => e.Name);
        } else {
            throw new Exception("Unexpected number of entities returned");
        }
    }

    public static void Main(string[] args) {

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
        var meshOperationApi = new MeshOperationsApi(config);
        var simulationApi = new SimulationsApi(config);
        var simulationRunApi = new SimulationRunsApi(config);
        var tableImportApi = new TableImportsApi(config);
        var reportsApi = new ReportsApi(config);

        HashSet < Status > terminalStatuses = new HashSet < Status > {
            Status.FINISHED,
            Status.CANCELED,
            Status.FAILED
        };
        Stopwatch stopWatch = new Stopwatch();
        var failedTries = 0;
        stopWatch.Restart();

        // Create project
        var project = new Project(
            name: "Compressible via CSharp SDK",
            description: "Compressible via CSharp SDK",
            measurementSystem: Project.MeasurementSystemEnum.SI
        );
        project = projectApi.CreateProject(project);
        var projectId = project.ProjectId;
        Console.WriteLine("projectId: " + projectId);

        // Upload CAD
        var storage = storageApi.CreateStorage();
        var storageId = storage.StorageId;
        var uploadRequest = new RestRequest(storage.Url, Method.PUT);
        uploadRequest.AddParameter("application/octet-stream", File.ReadAllBytes(@"../fixtures/flow-around-sphere-v3.x_t"), ParameterType.RequestBody);
        restClient.Execute(uploadRequest);
        Console.WriteLine("storageId: " + storageId);

        // Import CAD
        var geometryImportRequest = new GeometryImportRequest(
            name: "CAD-sphere_coarse",
            location: new GeometryImportRequestLocation(storageId),
            format: GeometryImportRequest.FormatEnum.PARASOLID,
            inputUnit: GeometryUnit.M,
            options: new GeometryImportRequestOptions(facetSplit: false, sewing: false, improve: true, optimizeForLBMSolver: false)
        );
        var geometryImport = geometryImportApi.ImportGeometry(projectId, geometryImportRequest);
        var geometryImportId = geometryImport.GeometryImportId.Value;
        stopWatch.Restart();
        failedTries = 0;
        while (!terminalStatuses.Contains(geometryImport.Status)) {
            // adjust timeout for larger geometries
            if (stopWatch.Elapsed.TotalSeconds > 900) {
                throw new TimeoutException();
            }
            Thread.Sleep(10000);
            geometryImport = geometryImportApi.GetGeometryImport(projectId, geometryImportId) ??
                (++failedTries > 5 ?
                    throw new Exception("HTTP request failed too many times."): geometryImport);
            Console.WriteLine("Geometry import status: " + geometryImport?.Status);
        }
        var geometryId = geometryImport.GeometryId.Value;
        Console.WriteLine("geometryId: " + geometryId);

        // Read geometry information and update with the deserialized model
        var geometry = geometryApi.GetGeometry(projectId, geometryId);
        geometryApi.UpdateGeometry(projectId, geometryId, geometry);

        // Get geometry mappings
        var materialEntities = getEntityNames(
            geometryApi,
            projectId,
            geometryId,
            1,
            values: new List < string > {
                "box"
            }
        );
        var bc1Entities = getEntityNames(
            geometryApi,
            projectId,
            geometryId,
            1,
            values: new List < string > {
                "Box ZMAX"
            }
        );
        var bc2Entities = getEntityNames(
            geometryApi,
            projectId,
            geometryId,
            1,
            values: new List < string > {
                "Box ZMIN"
            }
        );
        var bc3Entities = getEntityNames(
            geometryApi,
            projectId,
            geometryId,
            4,
            values: new List < string > {
                "Box XMIN",
                "Box XMAX",
                "Box YMIN",
                "Box YMAX"
            }
        );
        var bc4Entities = getEntityNames(
            geometryApi,
            projectId,
            geometryId,
            2,
            values: new List < string > {
                "Sphere"
            }
        );

        // Create simulation model
        var simulationModel = new Compressible(
            turbulenceModel: Compressible.TurbulenceModelEnum.KOMEGASST,
            model: new FluidModel(),
            initialConditions: new FluidInitialConditions(),
            advancedConcepts: new AdvancedConcepts(),
            materials: new CompressibleFluidMaterials(
                fluids: new List < FluidCompressibleMaterial > {
                    new FluidCompressibleMaterial(
                        name: "Air",
                        topologicalReference: new TopologicalReference(
                            entities: materialEntities
                        ),
                        specie: new SpecieDefault(
                            molarWeight: new DimensionalMolarMass(
                                value: (decimal) 28.97,
                                unit: DimensionalMolarMass.UnitEnum.KgKmol
                            )
                        ),
                        transport: new ConstTransport(
                            dynamicViscosity: new DimensionalDynamicViscosity(
                                value: (decimal) 0.0000183,
                                unit: DimensionalDynamicViscosity.UnitEnum.Kgsm
                            ),
                            prandtlNumber: (decimal) 0.713,
                            thermo: new HConstThermo(
                                equationOfState: new PerfectGasEquationOfState())
                        )
                    )
                }
            ),
            numerics: new FluidNumerics(
                relaxationFactor: new RelaxationFactor(),
                pressureReferenceValue: new DimensionalPressure(
                    value: 0,
                    unit: DimensionalPressure.UnitEnum.Pa
                ),
                residualControls: new ResidualControls(
                    velocity: new Tolerance(),
                    pressure: new Tolerance(),
                    turbulentKineticEnergy: new Tolerance(),
                    omegaDissipationRate: new Tolerance()
                ),
                solvers: new FluidSolvers(),
                schemes: new Schemes(
                    timeDifferentiation: new TimeDifferentiationSchemes(),
                    gradient: new GradientSchemes(),
                    divergence: new DivergenceSchemes(),
                    laplacian: new LaplacianSchemes(),
                    interpolation: new InterpolationSchemes(),
                    surfaceNormalGradient: new SurfaceNormalGradientSchemes()
                )
            ),
            boundaryConditions: new List < OneOfCompressibleBoundaryConditions > () {
                new VelocityInletBC(
                        name: "Velocity inlet 1",
                        velocity: new FixedValueVBC(
                            value: new DimensionalVectorFunctionSpeed(
                                value: new ComponentVectorFunction(
                                    x: new ConstantFunction(value: 0),
                                    y: new ConstantFunction(value: 0),
                                    z: new ConstantFunction(value: -1)
                                )
                            )
                        ),
                        temperature: new FixedValueTBC(
                            value: new DimensionalFunctionTemperature(
                                value: new ConstantFunction(value: (decimal) 19.85),
                                unit: DimensionalFunctionTemperature.UnitEnum.C
                            )
                        ),
                        topologicalReference: new TopologicalReference(
                            entities: bc1Entities
                        )
                    ),
                    new PressureOutletBC(
                        name: "Pressure outlet 2",
                        pressure: new FixedValuePBC(
                            value: new DimensionalFunctionPressure(
                                value: new ConstantFunction(value: 101325)
                            )
                        ),
                        topologicalReference: new TopologicalReference(
                            entities: bc2Entities
                        )
                    ),
                    new WallBC(
                        name: "Wall 3",
                        velocity: new SlipVBC(),
                        temperature: new FixedValueTBC(
                            value: new DimensionalFunctionTemperature(
                                value: new ConstantFunction(value: (decimal) 19.85),
                                unit: DimensionalFunctionTemperature.UnitEnum.C
                            )
                        ),
                        topologicalReference: new TopologicalReference(
                            entities: bc3Entities
                        )
                    ),
                    new WallBC(
                        name: "Wall 4",
                        velocity: new NoSlipVBC(
                            turbulenceWall: NoSlipVBC.TurbulenceWallEnum.WALLFUNCTION
                        ),
                        temperature: new AdiabaticTBC(),
                        topologicalReference: new TopologicalReference(
                            entities: bc4Entities
                        )
                    )
            },
            simulationControl: new FluidSimulationControl(
                endTime: new DimensionalTime(
                    value: 100,
                    unit: DimensionalTime.UnitEnum.S
                ),
                deltaT: new DimensionalTime(
                    value: 1,
                    unit: DimensionalTime.UnitEnum.S
                ),
                maxRunTime: new DimensionalTime(
                    value: 1000,
                    unit: DimensionalTime.UnitEnum.S
                ),
                writeControl: new TimeStepWriteControl(
                    writeInterval: 100
                ),
                decomposeAlgorithm: new ScotchDecomposeAlgorithm()
            ),
            resultControl: new FluidResultControls(
                forcesMoments: new List < OneOfFluidResultControlsForcesMoments > () {
                    new ForcesMomentsResultControl(
                        name: "Forces and moments 1",
                        writeControl: new TimeStepWriteControl(writeInterval: 1),
                        topologicalReference: new TopologicalReference(
                            entities: bc4Entities
                        )
                    )
                },
                surfaceData: new List < OneOfFluidResultControlsSurfaceData > () {
                    new AreaAverageResultControl(
                        name: "Area average 1",
                        writeControl: new TimeStepWriteControl(writeInterval: 1),
                        topologicalReference: new TopologicalReference(
                            entities: bc3Entities
                        )
                    )
                }
            )
        );
        var simulationSpec = new SimulationSpec(name: "Compressible via CSharp SDK", geometryId: geometryId, model: simulationModel);

        // Create simulation first to use for physics based meshing
        var simulationId = simulationApi.CreateSimulation(projectId, simulationSpec).SimulationId;
        Console.WriteLine("simulationId: " + simulationId);

        // Create mesh operation
        var meshOperation = meshOperationApi.CreateMeshOperation(projectId, new MeshOperation(
            name: "Sphere mesh",
            geometryId: geometryId,
            model: new SimmetrixMeshingFluid(
                physicsBasedMeshing: true,
                automaticLayerSettings: new AutomaticLayerOn()
            ),
            version: "0.3"
        ));
        var meshOperationId = meshOperation.MeshOperationId;
        Console.WriteLine("meshOperationId: " + meshOperationId);

        // Check mesh operation setup
        var meshCheck = meshOperationApi.CheckMeshOperationSetup(projectId, meshOperationId, simulationId);
        var warnings = meshCheck.Entries.Where(e => e.Severity == LogSeverity.WARNING).ToList();
        Console.WriteLine("Mesh operation setup check warnings:");
        warnings.ForEach(i => Console.WriteLine("{0}", i));
        var errors = meshCheck.Entries.Where(e => e.Severity == LogSeverity.ERROR).ToList();
        if (errors.Any()) {
            Console.WriteLine("Mesh operation setup check errors:");
            errors.ForEach(i => Console.WriteLine("{0}", i));
            throw new Exception("Simulation check failed");
        }

        // Estimate mesh operation
        var maxRuntime = 0.0;
        try {
            var estimationResult = meshOperationApi.EstimateMeshOperation(projectId, meshOperationId);
            Console.WriteLine("Mesh operation estimation: " + estimationResult);

            if (estimationResult.Duration != null) {
                maxRuntime = System.Xml.XmlConvert.ToTimeSpan(estimationResult.Duration.IntervalMax).TotalSeconds;
                maxRuntime = Math.Max(3600, maxRuntime * 2);
            } else {
                maxRuntime = 36000;
                Console.WriteLine("Mesh operation estimated duration not available, assuming max runtime of {0} seconds", maxRuntime);
            }
        } catch (ApiException ae) {
            if (ae.ErrorCode == 422) {
                maxRuntime = 36000;
                Console.WriteLine("Mesh operation estimation not available, assuming max runtime of {0} seconds", maxRuntime);
            } else {
                throw ae;
            }
        }

        // Start mesh operation and wait until it's finished
        meshOperationApi.StartMeshOperation(projectId, meshOperationId, simulationId);
        meshOperation = meshOperationApi.GetMeshOperation(projectId, meshOperationId);
        stopWatch.Restart();
        failedTries = 0;
        while (!terminalStatuses.Contains(meshOperation.Status ?? Status.READY)) {
            if (stopWatch.Elapsed.TotalSeconds > maxRuntime) {
                throw new TimeoutException();
            }
            Thread.Sleep(30000);
            meshOperation = meshOperationApi.GetMeshOperation(projectId, meshOperationId) ??
                (++failedTries > 5 ?
                    throw new Exception("HTTP request failed too many times."): meshOperation);
            Console.WriteLine("Mesh operation status: " + meshOperation?.Status + " - " + meshOperation?.Progress);
        }

        Console.WriteLine("final mesh operation: " + meshOperation);

        // Read simulation and update with the finished mesh
        simulationSpec = simulationApi.GetSimulation(projectId, simulationId);
        simulationSpec.MeshId = meshOperation.MeshId;
        simulationApi.UpdateSimulation(projectId, simulationId, simulationSpec);

        // Check simulation
        var checkResult = simulationApi.CheckSimulationSetup(projectId, simulationId);
        warnings = checkResult.Entries.Where(e => e.Severity == LogSeverity.WARNING).ToList();
        Console.WriteLine("Simulation check warnings:");
        warnings.ForEach(i => Console.WriteLine("{0}", i));
        errors = checkResult.Entries.Where(e => e.Severity == LogSeverity.ERROR).ToList();
        if (errors.Any()) {
            Console.WriteLine("Simulation check errors:");
            errors.ForEach(i => Console.WriteLine("{0}", i));
            throw new Exception("Simulation check failed");
        }

        // Estimate simulation
        maxRuntime = 0.0;
        try {
            var estimationResult = simulationApi.EstimateSimulationSetup(projectId, simulationId);
            Console.WriteLine("Simulation estimation: " + estimationResult);

            if (estimationResult.Duration != null) {
                maxRuntime = System.Xml.XmlConvert.ToTimeSpan(estimationResult.Duration.IntervalMax).TotalSeconds;
                maxRuntime = Math.Max(3600, maxRuntime * 2);
            } else {
                maxRuntime = 36000;
                Console.WriteLine("Simulation estimated duration not available, assuming max runtime of {0} seconds", maxRuntime);
            }
        } catch (ApiException ae) {
            if (ae.ErrorCode == 422) {
                maxRuntime = 36000;
                Console.WriteLine("Simulation estimation not available, assuming max runtime of {0} seconds", maxRuntime);
            } else {
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
        while (!terminalStatuses.Contains(run.Status ?? Status.READY)) {
            if (stopWatch.Elapsed.TotalSeconds > maxRuntime) {
                throw new TimeoutException();
            }
            Thread.Sleep(30000);
            run = simulationRunApi.GetSimulationRun(projectId, simulationId, runId) ??
                (++failedTries > 5 ?
                    throw new Exception("HTTP request failed too many times."): run);
            Console.WriteLine("Simulation run status: " + run?.Status + " - " + run?.Progress);
        }

        // Get result metadata and download results
        SimulationRunResults results = simulationRunApi.GetSimulationRunResults(projectId, simulationId, runId);
        SimulationRunResultSolution solutionInfo = (SimulationRunResultSolution) results.Embedded.FindAll(r => r.Type == "SOLUTION_FIELD")[0];

        var reportRequest = new ReportRequest(
            name: "Report 1",
            description: "Simulation report",
            resultIds: new List < Guid ? > {
                solutionInfo.ResultId
            },
            reportProperties : new ScreenshotReportProperties(
                modelSettings: new ModelSettings(
                    parts: new List < Part > {
                        new Part(
                            partIdentifier: "default_region",
                            solidColor: new Color(r: 0.8f, g: 0.2f, b: 0.4f))
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
                    direction: new Vector3D(
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