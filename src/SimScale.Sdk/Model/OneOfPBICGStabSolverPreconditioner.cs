/* 
 * SimScale API
 *
 * The version of the OpenAPI document: 0.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using JsonSubTypes;
using OpenAPIDateConverter = SimScale.Sdk.Client.OpenAPIDateConverter;

namespace SimScale.Sdk.Model
{
    /// <summary>
    /// &lt;p&gt;Choose a preconditioner for your solver. A preconditioner improves the convergence speed of your system. Therefore, it is generally recommended. DILU is a very common diagonal incomplete lower-upper decomposition preconditioner.&lt;/p&gt;
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(DILUPreconditioner), "DILU")]
    [JsonSubtypes.KnownSubType(typeof(DICPreconditioner), "DIC")]
    [JsonSubtypes.KnownSubType(typeof(ILUCpPreconditioner), "ILUCP")]
    public interface OneOfPBICGStabSolverPreconditioner
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
