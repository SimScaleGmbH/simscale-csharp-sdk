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
    /// &lt;p&gt;Defines the direction on which the thermal conductivity will act:&lt;br&gt; &lt;ul&gt;&lt;li&gt;&lt;strong&gt;x-, y-, z-Axis&lt;/strong&gt;: the cross-plane conductivity acts along the selected coordinate axis and the in-plane conductivity acts on the plane orthogonal to that axis.&lt;/li&gt;&lt;li&gt;&lt;strong&gt;Custom&lt;/strong&gt;: the cross-plane conductivity is aligned with the cross-plane orientation defined by the X, Y, Z components, and the in-plane conductivity acts on the plane orthogonal to the cross-plane orientation.&lt;/li&gt;&lt;/ul&gt;&lt;/p&gt;
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(XAxis), "XAXIS")]
    [JsonSubtypes.KnownSubType(typeof(YAxis), "YAXIS")]
    [JsonSubtypes.KnownSubType(typeof(ZAxis), "ZAXIS")]
    [JsonSubtypes.KnownSubType(typeof(CrossPlaneCustomOrientation), "CROSS_PLANE")]
    public interface OneOfConstCrossPlaneOrthotropicTransportOrientation
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
