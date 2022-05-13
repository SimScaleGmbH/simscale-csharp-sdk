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

public class MaterialLibraryExample {

  public static void Main(string[] args) {

    // API client configuration
    var API_KEY_HEADER = "X-API-KEY";
    var API_KEY = Environment.GetEnvironmentVariable("SIMSCALE_API_KEY");
    var API_URL = Environment.GetEnvironmentVariable("SIMSCALE_API_URL");

    Configuration config = new Configuration();
    config.BasePath = API_URL + "/v0";
    config.ApiKey.Add(API_KEY_HEADER, API_KEY);

    // API client
    var materialsApi = new MaterialsApi(config);

    // Create Material Group
    var createMaterialGroupRequest = new CreateMaterialGroupRequest("My custom materials");
    var createMaterialGroupResponse = materialsApi.CreateMaterialGroup(createMaterialGroupRequest);
    var materialGroupId = createMaterialGroupResponse.MaterialGroupId;

    // Create Nested Material Group
    var createNestedMaterialGroupRequest = new CreateNestedMaterialGroupRequest("My custom solids");
    var createNestedMaterialGroupResponse = materialsApi.CreateNestedMaterialGroup(materialGroupId, createNestedMaterialGroupRequest);
    var nestedMaterialGroupId = createNestedMaterialGroupResponse.MaterialGroupId;

    // Create Material
    var createMaterialRequest = new CreateMaterialRequest(
      name: "My custom Aluminium",
      metadata: new Dictionary < string, Object > () {
        { "description", "Post-transition metal in the boron group" },
        { "tags", new List < string > { "solid", "thermal", "acoustic", "thermomechanical" } }
      },
      properties: new Dictionary < string, OneOfMaterialProperty > () {
        { "density", new FixedMaterialProperty(
            name: "Density",
            unit: "kg/m³",
            dataType: PropertyDataType.Numeric,
            value: 2730.0
          )
        },
        { "conductivity", new ParametricMaterialProperty(
            name: "Conductivity",
            unit: "W/(m·K)",
            dataType: PropertyDataType.Numeric,
            parameters: new List < MaterialPropertyParameter > {
              new MaterialPropertyParameter(
                key: "temperature",
                name: "Temperature",
                unit: "C"
              )
            },
            parametricValues: new List < Dictionary < string,  object > > {
              new Dictionary < string, object > () {
                { "value", 31.4 },
                { "temperature", 100 }
              },
              new Dictionary < string, object > () {
                { "value", 30.8 },
                { "temperature", 500 }
              }
            }
          )
        }
      }
    );
    materialsApi.CreateMaterial(nestedMaterialGroupId, createMaterialRequest);

    // List Material Groups
    var materialGroupsResponse = materialsApi.GetMaterialGroups();
    foreach(MaterialGroupResponse group in materialGroupsResponse.Embedded) {
      Console.WriteLine($"Material Group with id {group.MaterialGroupId}: {group}");
    }

    // List Materials in Material Group
    var sampleMaterialGroupId = materialGroupsResponse.Embedded.First().MaterialGroupId;
    var materialsListReponse = materialsApi.GetMaterials(sampleMaterialGroupId);
    foreach(MaterialResponse material in materialsListReponse.Embedded) {
      Console.WriteLine($"Material Group with id {sampleMaterialGroupId} contains Material with id {material.Id}");
    }

    // List Material properties
    var sampleMaterialId = materialsListReponse.Embedded.First().Id;
    var materialResponse = materialsApi.GetMaterialData(sampleMaterialGroupId, sampleMaterialId);
    foreach(KeyValuePair < string, OneOfMaterialProperty > property in materialResponse.Properties) {
      Console.WriteLine($"Material with id {sampleMaterialId} has property {property.Key}: {property.Value}");
    }
  }
}