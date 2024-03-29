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
    /// Use this factor to scale the Reynolds number of your simulation. For example, to change the Reynolds number from 10&lt;sup&gt;8&lt;/sup&gt; to 10&lt;sup&gt;6&lt;/sup&gt;, set this factor to 0.01. &lt;a href&#x3D; https://www.simscale.com/docs/incompressible-lbm-lattice-boltzmann-advanced/#reynolds-scaling-factor&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(AutomaticReynoldsScaling), "AUTOMATIC_REYNOLDS_SCALING")]
    [JsonSubtypes.KnownSubType(typeof(ManualReynoldsScaling), "MANUAL_REYNOLDS_SCALING")]
    public interface OneOfWindComfortMeshReynoldsScalingType
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
