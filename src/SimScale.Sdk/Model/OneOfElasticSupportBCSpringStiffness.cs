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
    /// &lt;p&gt;The stiffness can either be assumed equal in all directions by selecting &lt;b&gt;isotropic&lt;/b&gt; or it can depend on the force direction by selecting &lt;b&gt;orthotropic&lt;/b&gt;. For an orthotropic stiffness the stiffness value along each global coordinate direction can be given independently.&lt;/p&gt;
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(IsotropicSpringStiffness), "ISOTROPIC")]
    [JsonSubtypes.KnownSubType(typeof(OrthotropicSpringStiffness), "ORTHOTROPIC")]
    public interface OneOfElasticSupportBCSpringStiffness
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
