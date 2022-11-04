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

public class FoldersAndSpacesExample {

    public static void Main(string[] args) {

        // API client configuration
        var API_KEY_HEADER = "X-API-KEY";
        var API_KEY = Environment.GetEnvironmentVariable("SIMSCALE_API_KEY");
        var API_URL = Environment.GetEnvironmentVariable("SIMSCALE_API_URL");

        Configuration config = new Configuration();
        config.BasePath = API_URL + "/v0";
        config.ApiKey.Add(API_KEY_HEADER, API_KEY);

        // API clients
        var restClient = new RestClient();
        var projectsApi = new ProjectsApi(config);
        var spacesApi = new SpacesApi(config);
        var foldersApi = new FoldersApi(config);

        // Get info about the user Personal Space
        var userSpaces = spacesApi.GetUserSpaces();
        var personalSpaceId = userSpaces.PersonalSpaces.First().SpaceId;
        var personalSpaceInfo = spacesApi.GetSpaceInfo(spaceId: personalSpaceId);
        Console.WriteLine("Personal Space ID: {0} - Space info: {1}", personalSpaceId, personalSpaceInfo);

        // Create Folders in the Space root
        var folderA = new Folder(name: "Folder A");
        folderA = foldersApi.CreateFolder(spaceId: personalSpaceId, folder: folderA);
        Console.WriteLine("Created a folder with ID {0} and name {1} in the Space root", folderA.FolderId, folderA.Name);

        var folderB = new Folder(name: "Folder B");
        folderB = foldersApi.CreateFolder(spaceId: personalSpaceId, folder: folderB);
        Console.WriteLine("Created a folder with ID {0} and name {1} in the Space root", folderB.FolderId, folderB.Name);

        // Create a Project in the Space root
        var projectA = new Project(
            name: "Project A",
            description: "Project in Space root",
            measurementSystem: Project.MeasurementSystemEnum.SI,
            spaceId: personalSpaceId
        );
        projectA = projectsApi.CreateProject(projectA);
        Console.WriteLine("Created a project with ID {0} and name {1} in the Space root", projectA.ProjectId, projectA.Name);

        // Create a Project inside Folder A
        var projectB = new Project(
            name: "Project B",
            description: "Project in Folder A",
            measurementSystem: Project.MeasurementSystemEnum.SI,
            spaceId: personalSpaceId,
            parentFolderId: folderA.FolderId
        );
        projectB = projectsApi.CreateProject(projectB);
        Console.WriteLine("Created a project with ID {0} and name {1} inside Folder A", projectB.ProjectId, projectB.Name);

        // Create a Folder inside Folder A
        var folderC = new Folder(name: "Folder C", parentFolderId: folderA.FolderId);
        folderC = foldersApi.CreateFolder(spaceId: personalSpaceId, folder: folderC);
        Console.WriteLine("Created a folder with ID {0} and name {1} inside Folder A", folderC.FolderId, folderC.Name);

        // Rename Folder C
        folderC = foldersApi.UpdateFolder(spaceId: personalSpaceId, folderId: folderC.FolderId, folder: new Folder(name: "New name for Folder C"));
        Console.WriteLine("Updated folder with ID {0}. New name: {1}", folderC.FolderId, folderC.Name);

        // List the contents of the Space root
        var foldersInSpaceRoot = foldersApi.ListFoldersInSpaceRoot(spaceId: personalSpaceId);
        Console.WriteLine("Number of folders in Space root: {0} - Sample Folder info: {1}", foldersInSpaceRoot.Meta.Total, foldersInSpaceRoot.Embedded.First());

        var projectsInSpaceRoot = foldersApi.ListProjectsInSpaceRoot(spaceId: personalSpaceId);
        Console.WriteLine("Number of projects in Space root: {0} - Sample Project info: {1}", projectsInSpaceRoot.Meta.Total, projectsInSpaceRoot.Embedded.First());

        // List the contents of a Folder
        var foldersInFolder = foldersApi.ListFoldersInFolder(spaceId: personalSpaceId, folderId: folderA.FolderId);
        Console.WriteLine("Number of folders in Folder A: {0} - Folders: {1}", foldersInFolder.Meta.Total, foldersInFolder.Embedded);

        var projectsInFolder = foldersApi.ListProjectsInFolder(spaceId: personalSpaceId, folderId: folderA.FolderId);
        Console.WriteLine("Number of projects in Folder A: {0} - Projects: {1}", projectsInFolder.Meta.Total, projectsInFolder.Embedded);

        // Move content from the Space root to Folder B
        var moveContentRequest = new MoveContentRequest(
            entries: new List <ResourceToMove> {
                new ResourceToMove(projectId: projectA.ProjectId),  // move Project A
                new ResourceToMove(folderId: folderA.FolderId)  // move Folder A
            },
            to: new ResourceLocation(spaceId: personalSpaceId, parentFolderId: folderB.FolderId)
        );
        foldersApi.MoveContentFromSpaceRoot(spaceId: personalSpaceId, moveContentRequest: moveContentRequest);

        // Move content from Folder A to the Space root
        moveContentRequest = new MoveContentRequest(
            entries: new List <ResourceToMove> {
                new ResourceToMove(projectId: projectB.ProjectId),  // move Project B
                new ResourceToMove(folderId: folderC.FolderId)  // move Folder C
            },
            to: new ResourceLocation(spaceId: personalSpaceId)
        );
        foldersApi.MoveContentFromFolder(spaceId: personalSpaceId, folderId: folderA.FolderId, moveContentRequest: moveContentRequest);

        // Delete Folder C
        foldersApi.DeleteFolder(spaceId: personalSpaceId, folderId: folderC.FolderId);
    }

}