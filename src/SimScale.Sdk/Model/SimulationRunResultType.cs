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
using OpenAPIDateConverter = SimScale.Sdk.Client.OpenAPIDateConverter;

namespace SimScale.Sdk.Model
{
    /// <summary>
    /// The result type
    /// </summary>
    /// <value>The result type</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum SimulationRunResultType
    {
        /// <summary>
        /// Enum SOLUTIONFIELD for value: SOLUTION_FIELD
        /// </summary>
        [EnumMember(Value = "SOLUTION_FIELD")]
        SOLUTIONFIELD = 1,

        /// <summary>
        /// Enum CONVERGENCEPLOT for value: CONVERGENCE_PLOT
        /// </summary>
        [EnumMember(Value = "CONVERGENCE_PLOT")]
        CONVERGENCEPLOT = 2,

        /// <summary>
        /// Enum PLOT for value: PLOT
        /// </summary>
        [EnumMember(Value = "PLOT")]
        PLOT = 3,

        /// <summary>
        /// Enum TABLE for value: TABLE
        /// </summary>
        [EnumMember(Value = "TABLE")]
        TABLE = 4

    }

}