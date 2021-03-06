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
    /// Dissipation rate (epsilon) represents the rate of dissipation of turbulent kinetic energy (k). &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/global-settings/k-epsilon/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(CalculatedEVCBC), "CALCULATED")]
    [JsonSubtypes.KnownSubType(typeof(SymmetryEVCBC), "SYMMETRY")]
    [JsonSubtypes.KnownSubType(typeof(FixedGradientEVCBC), "FIXED_GRADIENT")]
    [JsonSubtypes.KnownSubType(typeof(FixedValueEVCBC), "FIXED_VALUE")]
    [JsonSubtypes.KnownSubType(typeof(InletOutletEVCBC), "INLET_OUTLET")]
    [JsonSubtypes.KnownSubType(typeof(ZeroGradientEVCBC), "ZERO_GRADIENT")]
    [JsonSubtypes.KnownSubType(typeof(WallFunctionEVCBC), "WALL_FUNCTION")]
    [JsonSubtypes.KnownSubType(typeof(FullResolutionEVCBC), "FULL_RESOLUTION")]
    public interface OneOfCustomFluidBCEddyViscosityCompressible
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
