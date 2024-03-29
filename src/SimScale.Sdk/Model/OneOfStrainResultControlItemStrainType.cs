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
    /// OneOfStrainResultControlItemStrainType
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(GlobalTotalNonlinearStrainType), "TOTAL_NONLINEAR")]
    [JsonSubtypes.KnownSubType(typeof(GlobalTotalEquivalentPlasticStrainType), "TOTAL_EQUI_PLASTIC")]
    [JsonSubtypes.KnownSubType(typeof(GlobalUnelasticStrainType), "UNELASTIC")]
    [JsonSubtypes.KnownSubType(typeof(GlobalTotalStrainType), "TOTAL")]
    [JsonSubtypes.KnownSubType(typeof(GlobalPrincipalStrainType), "PRINCIPAL")]
    [JsonSubtypes.KnownSubType(typeof(GlobalPrincipalGreenLagrangeStrainType), "PRINCIPAL_GREEN_LAGRANGE")]
    public interface OneOfStrainResultControlItemStrainType
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
