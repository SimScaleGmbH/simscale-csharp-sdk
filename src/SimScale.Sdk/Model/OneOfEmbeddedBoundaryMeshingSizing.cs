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
    /// &lt;p&gt;Define how to control the global mesh sizing:&lt;/p&gt;&lt;ul&gt; &lt;li&gt;&lt;p&gt;&lt;b&gt;Automatic:&lt;/b&gt; Element sizing is controlled by &lt;b&gt;automatic fineness levels&lt;/b&gt; that take the geometrical properties into account.&lt;/p&gt;&lt;/li&gt; &lt;li&gt;&lt;p&gt;&lt;b&gt;Manual:&lt;/b&gt; Element sizing is controlled by &lt;b&gt;maximum and minimum edge length&lt;/b&gt;.&lt;/p&gt;&lt;/li&gt;  &lt;li&gt;&lt;p&gt;&lt;b&gt;Custom:&lt;/b&gt; Element sizing is controlled by the specified &lt;b&gt;number of cells in the three spatial directions&lt;/b&gt; and the &lt;b&gt;number refinement levels&lt;/b&gt; applied on the surfaces.&lt;/p&gt;&lt;/li&gt;&lt;/ul&gt;
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(AutomaticEmbeddedBoundaryMeshSizing), "AUTOMATIC_EBM_MESH_SIZING")]
    [JsonSubtypes.KnownSubType(typeof(ManualEmbeddedBoundaryMeshSizing), "MANUAL_EBM_MESH_SIZING")]
    [JsonSubtypes.KnownSubType(typeof(CustomEmbeddedBoundaryMeshSizing), "CUSTOM_EBM_MESH_SIZING")]
    public interface OneOfEmbeddedBoundaryMeshingSizing
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}