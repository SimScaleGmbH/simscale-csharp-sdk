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
    /// Dynamic eddy viscosity (muSgs) is a sub-grid scale viscosity used to model the unresolved turbulent eddies in Large Eddy Simulations. Choose a boundary type.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(CalculatedEVBC), "CALCULATED")]
    [JsonSubtypes.KnownSubType(typeof(SymmetryEVBC), "SYMMETRY")]
    [JsonSubtypes.KnownSubType(typeof(FixedGradientEVBC), "FIXED_GRADIENT")]
    [JsonSubtypes.KnownSubType(typeof(FixedValueEVBC), "FIXED_VALUE")]
    [JsonSubtypes.KnownSubType(typeof(InletOutletEVBC), "INLET_OUTLET")]
    [JsonSubtypes.KnownSubType(typeof(ZeroGradientEVBC), "ZERO_GRADIENT")]
    [JsonSubtypes.KnownSubType(typeof(WallFunctionEVBC), "WALL_FUNCTION")]
    [JsonSubtypes.KnownSubType(typeof(FullResolutionEVBC), "FULL_RESOLUTION")]
    public interface OneOfCustomFluidBCEddyViscosity
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}