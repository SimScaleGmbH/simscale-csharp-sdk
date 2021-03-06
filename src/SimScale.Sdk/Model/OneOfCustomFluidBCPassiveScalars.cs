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
    /// OneOfCustomFluidBCPassiveScalars
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(FixedGradientPSBC), "FIXED_GRADIENT")]
    [JsonSubtypes.KnownSubType(typeof(FixedValuePSBC), "FIXED_VALUE")]
    [JsonSubtypes.KnownSubType(typeof(InletOutletPSBC), "INLET_OUTLET")]
    [JsonSubtypes.KnownSubType(typeof(ZeroGradientPSBC), "ZERO_GRADIENT")]
    [JsonSubtypes.KnownSubType(typeof(SymmetryPSBC), "SYMMETRY")]
    public interface OneOfCustomFluidBCPassiveScalars
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
