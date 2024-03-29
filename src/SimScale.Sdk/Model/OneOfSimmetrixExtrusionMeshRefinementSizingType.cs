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
    /// &lt;b&gt;Sweep sizing type&lt;/b&gt; allows you to specify either the number of elements or the element thickness along the direction of the sweep. The actual absolute thickness will match the desired value as close as possible, given the length of the sweep region as a constraint.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(SweepMeshingAbsoluteSize), "SWEEP_MESHING_ABSOLUTE_SIZE")]
    [JsonSubtypes.KnownSubType(typeof(SweepMeshingNumberOfElements), "SWEEP_MESHING_NUMBER_OF_ELEMENTS")]
    public interface OneOfSimmetrixExtrusionMeshRefinementSizingType
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
