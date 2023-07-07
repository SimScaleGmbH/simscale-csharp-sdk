using System.Collections.Generic;
using System.Diagnostics;
using System;
using System.IO;
using Newtonsoft.Json;
using RestSharp;
using SimScale.Sdk.Api;
using SimScale.Sdk.Client;
using SimScale.Sdk.Model;

class SandboxExample
{
    static void Main(string[] args)
    {
        var PROJECT_ID = "1234123412341234";
        var SIMULATION_ID = Guid.Parse("260d260d-260d-260d-260d-260d260d260d");
        var RUN_ID = Guid.Parse("37ae37ae-37ae-37ae-37ae-37ae37ae37ae");

        Configuration config = new Configuration();
        config.BasePath = Environment.GetEnvironmentVariable("SIMSCALE_API_URL") + "/sandbox/v0";
        config.ApiKey.Add("X-API-KEY", "sandbox-example-api-key");

        var projectApi = new ProjectsApi(config);
        var storageApi = new StorageApi(config);
        var geometryImportApi = new GeometryImportsApi(config);
        var geometryApi = new GeometriesApi(config);
        var simulationApi = new SimulationsApi(config);
        var simulationRunApi = new SimulationRunsApi(config);

        // Get simulation: GET /projects/{projectId}/simulations/{simulationId}
        // Verify deserialization of oneOf schema (limited support in C#)
        SimulationSpec simulationSpec = simulationApi.GetSimulation(PROJECT_ID, SIMULATION_ID);
        if (simulationSpec.Model.Type != "WIND_COMFORT") {
            throw new Exception("Retrieved simulation spec has wrong type: " + simulationSpec);
        }

        // Get result metadata: GET /projects/{projectId}/simulations/{simulationId}/runs/{runId}/results
        // Verify deserialization of oneOf schema (limited support in C#)
        SimulationRunResults results = simulationRunApi.GetSimulationRunResults(
            projectId: PROJECT_ID,
            simulationId: SIMULATION_ID,
            runId: RUN_ID,
            page: 1,
            limit: 100,
            type: "SOLUTION_FIELD"
        );
        if (results.Embedded[0].Type != "SOLUTION_FIELD") {
            throw new Exception("Retrieved result[0] has wrong type: " + results);
        }
    }
}
