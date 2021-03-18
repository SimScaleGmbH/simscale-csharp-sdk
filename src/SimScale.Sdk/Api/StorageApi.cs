/* 
 * SimScale API
 *
 * The version of the OpenAPI document: 0.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using SimScale.Sdk.Client;
using SimScale.Sdk.Model;

namespace SimScale.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStorageApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a temporary storage location
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SimScale.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Storage</returns>
        Storage CreateStorage ();

        /// <summary>
        /// Create a temporary storage location
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SimScale.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Storage</returns>
        ApiResponse<Storage> CreateStorageWithHttpInfo ();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStorageApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create a temporary storage location
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SimScale.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Storage</returns>
        System.Threading.Tasks.Task<Storage> CreateStorageAsync ();

        /// <summary>
        /// Create a temporary storage location
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="SimScale.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Storage)</returns>
        System.Threading.Tasks.Task<ApiResponse<Storage>> CreateStorageAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStorageApi : IStorageApiSync, IStorageApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class StorageApi : IStorageApi
    {
        private SimScale.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StorageApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StorageApi(String basePath)
        {
            this.Configuration = SimScale.Sdk.Client.Configuration.MergeConfigurations(
                SimScale.Sdk.Client.GlobalConfiguration.Instance,
                new SimScale.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new SimScale.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new SimScale.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = SimScale.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StorageApi(SimScale.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = SimScale.Sdk.Client.Configuration.MergeConfigurations(
                SimScale.Sdk.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new SimScale.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new SimScale.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = SimScale.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public StorageApi(SimScale.Sdk.Client.ISynchronousClient client,SimScale.Sdk.Client.IAsynchronousClient asyncClient, SimScale.Sdk.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = SimScale.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public SimScale.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public SimScale.Sdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public SimScale.Sdk.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public SimScale.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Create a temporary storage location 
        /// </summary>
        /// <exception cref="SimScale.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Storage</returns>
        public Storage CreateStorage ()
        {
             SimScale.Sdk.Client.ApiResponse<Storage> localVarResponse = CreateStorageWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a temporary storage location 
        /// </summary>
        /// <exception cref="SimScale.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Storage</returns>
        public SimScale.Sdk.Client.ApiResponse< Storage > CreateStorageWithHttpInfo ()
        {
            SimScale.Sdk.Client.RequestOptions localVarRequestOptions = new SimScale.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = SimScale.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = SimScale.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-KEY")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-KEY", this.Configuration.GetApiKeyWithPrefix("X-API-KEY"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post< Storage >("/storage", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateStorage", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a temporary storage location 
        /// </summary>
        /// <exception cref="SimScale.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of Storage</returns>
        public async System.Threading.Tasks.Task<Storage> CreateStorageAsync ()
        {
             SimScale.Sdk.Client.ApiResponse<Storage> localVarResponse = await CreateStorageAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a temporary storage location 
        /// </summary>
        /// <exception cref="SimScale.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (Storage)</returns>
        public async System.Threading.Tasks.Task<SimScale.Sdk.Client.ApiResponse<Storage>> CreateStorageAsyncWithHttpInfo ()
        {

            SimScale.Sdk.Client.RequestOptions localVarRequestOptions = new SimScale.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-KEY")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-KEY", this.Configuration.GetApiKeyWithPrefix("X-API-KEY"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Storage>("/storage", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateStorage", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}