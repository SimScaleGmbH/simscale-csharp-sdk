# SimScale C# SDK

API access is currently part of our paid Enterprise plan. However, if you have an idea for an integration or app and would like to become a development partner, please contact us at api@simscale.com!

<a name="supported-frameworks"></a>
## Supported frameworks
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.10.1
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.1
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.5.2

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using SimScale.Sdk.Api;
using SimScale.Sdk.Client;
using SimScale.Sdk.Model;
```
<a name="usage"></a>
## Usage
### API client configuration

Authentication with the SimScale API is done using the `X-API-KEY` request header. You must initialize and configure a
`Configuration` object with the correct host, headers and API key information.

As reference, the following snippet shows how to configure the API client using environment variables to store the API
key and the target URL.

```csharp
using System;
using SimScale.Sdk.Api;
using SimScale.Sdk.Client;
using SimScale.Sdk.Model;

// API client configuration
var API_KEY_HEADER = "X-API-KEY";
var API_KEY = Environment.GetEnvironmentVariable("SIMSCALE_API_KEY");
var API_URL = Environment.GetEnvironmentVariable("SIMSCALE_API_URL");

Configuration config = new Configuration();
config.BasePath = API_URL + "/v0";
config.ApiKey.Add(API_KEY_HEADER, API_KEY);
```

You must then pass this configuration object to initialize the domain-specific clients that will perform the API operations. For example:

```csharp
// API clients
var projectApi = new ProjectsApi(config);
var geometryApi = new GeometriesApi(config);
var meshOperationApi = new MeshOperationsApi(config);
var simulationApi = new SimulationsApi(config);
```

### HTTP Proxy

To use the API client with an HTTP proxy, set up a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

## Examples

The `examples` folder contains executable code examples to demonstrate how the SDK can be used.

In order to run them, the following environment variables need to be set:

| Name               | Value                      |
|--------------------|----------------------------|
| `SIMSCALE_API_URL` | `https://api.simscale.com` |
| `SIMSCALE_API_KEY` | `your-api-key`             |

### Set environment variables

This section explains how to set environment variables for the current terminal session only. This means that the
variables will not be accessible if you use a different terminal to run the examples.

#### Linux/macOS
Run:
```sh
export SIMSCALE_API_URL="https://api.simscale.com"
export SIMSCALE_API_KEY="your-api-key"
```

#### Windows CMD
Run:
```console
set SIMSCALE_API_URL="https://api.simscale.com"
set SIMSCALE_API_KEY="your-api-key"
```

#### Windows PowerShell
Run:
```powershell
$env:SIMSCALE_API_URL="https://api.simscale.com"
$env:SIMSCALE_API_KEY="your-api-key"
```