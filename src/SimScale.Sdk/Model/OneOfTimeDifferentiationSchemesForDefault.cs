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
    /// &lt;p&gt;With this option, you can choose your desired time-differentiation scheme:&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;For steady-state simulations, choose &lt;b&gt;steadyState&lt;/b&gt;.&lt;/p&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Euler&lt;/b&gt; is a first-order implicit and bounded scheme. If unsure, try this scheme first.&lt;/p&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;localEuler&lt;/b&gt; is a local time-step scheme, which is first-order implicit and bounded.&lt;/p&gt;&lt;/ul&gt;
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(EulerTimeDifferentiationScheme), "EULER")]
    [JsonSubtypes.KnownSubType(typeof(LocalEulerTimeDifferentiationScheme), "LOCAL_EULER")]
    [JsonSubtypes.KnownSubType(typeof(SteadystateTimeDifferentiationScheme), "STEADYSTATE")]
    public interface OneOfTimeDifferentiationSchemesForDefault
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
