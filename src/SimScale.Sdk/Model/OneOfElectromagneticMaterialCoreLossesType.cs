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
    /// Core losses calculate the losses in magnetic materials, including hysteresis and eddy current losses. &lt;p&gt;Note: Once a core loss model is enabled, eddy currents are suppressed within that body.&lt;/p&gt;  For more information on each model, please refer to our &lt;a href&#x3D;&#39;https://www.simscale.com/docs/analysis-types/electromagnetics/#core-losses&#39; target&#x3D;&#39;_blank&#39;&gt;documentation&lt;/a&gt;.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(NoCoreLoss), "NONE")]
    [JsonSubtypes.KnownSubType(typeof(ElectricalSteelCoreLoss), "ELECTRICAL_STEEL")]
    [JsonSubtypes.KnownSubType(typeof(PowerFerriteCoreLoss), "POWER_FERRITE")]
    public interface OneOfElectromagneticMaterialCoreLossesType
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}