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
    /// &lt;p&gt;&lt;b&gt;Solar load&lt;/b&gt; in solar radiation model. &lt;b&gt;Diffuse solar load&lt;/b&gt; affects all walls with a derived heat flux boundary condition externally if the outer surface absorptivity is greater than  zero. &lt;b&gt;Direct solar load&lt;/b&gt; affects all walls either externally or internally if these are not shadowed by other walls, are non-transparent and have an absorptivity greater than zero. &lt;/p&gt; &lt;ul&gt;&lt;li&gt;&lt;b&gt;Custom:&lt;/b&gt; Define diffusive and directed solar load directly.&lt;/li&gt;&lt;li&gt;&lt;b&gt;Fair weather conditions:&lt;/b&gt; Define the external and internal solar load by a number of coefficients in the Fair weather condtions model.This assumes the Z-vector to point upwards into the sky.&lt;/li&gt;&lt;/ul&gt;
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(CustomSolarLoad), "CUSTOM_SOLAR_LOAD")]
    [JsonSubtypes.KnownSubType(typeof(FairWeatherConditions), "FAIR_WEATHER_CONDITIONS")]
    public interface OneOfSolarCalculatorSolarLoad
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
