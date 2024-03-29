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
    /// &lt;p&gt;Choose the hyperelastic material model that should be used. All models derive the stress-strain relation from a strain energy function defined by the material model parameters.&lt;/p&gt;
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(MooneyRivlinHyperElasticModel), "MOONEY_RIVLIN")]
    [JsonSubtypes.KnownSubType(typeof(NeoHookeHyperElasticModel), "NEO_HOOKE")]
    [JsonSubtypes.KnownSubType(typeof(SignoriniHyperElasticModel), "SIGNORINI")]
    [JsonSubtypes.KnownSubType(typeof(YeohHyperElasticModel), "YEOH")]
    [JsonSubtypes.KnownSubType(typeof(OgdenHyperElasticModel), "OGDEN")]
    public interface OneOfHyperElasticMaterialBehaviorHyperElasticModel
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
