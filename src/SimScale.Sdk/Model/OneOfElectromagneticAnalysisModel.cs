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
    /// &lt;ul&gt;&lt;li&gt;&lt;strong&gt;Electrostatics&lt;/strong&gt;&lt;br&gt;Use for problems where &lt;em&gt;electric fields&lt;/em&gt; and charges are stationary, and no time-varying electromagnetic fields are present. Applications include: Capacitors, Electrostatic Shielding, High-Voltage Dielectric breakdown analysis.&lt;/li&gt;&lt;li&gt;&lt;strong&gt;Magnetostatics&lt;/strong&gt;&lt;br&gt;Use for problems where &lt;em&gt;magnetic fields&lt;/em&gt; are constant over time and thus no eddy currents are present. Applications include: Permanent Magnets, Magnetic Shielding, Magnetic Forces.&lt;/li&gt; &lt;li&gt;&lt;strong&gt;Time-Harmonic Magnetics&lt;/strong&gt;&lt;br&gt;Use for problems where &lt;em&gt;magnetic fields and electric currents&lt;/em&gt; are sinusoidally varying. Applications include: Transformers, Induction Heating, Wireless Charging.&lt;/li&gt; &lt;li&gt;&lt;strong&gt;Time-Transient Magnetics&lt;/strong&gt;&lt;br&gt;Use for problems where &lt;em&gt;magnetic fields and electric currents&lt;/em&gt; are time-dependent. Applications include: Transformers and Motors.&lt;/li&gt;&lt;/ul&gt;
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(Electrostatics), "ELECTROSTATICS")]
    [JsonSubtypes.KnownSubType(typeof(Magnetostatics), "MAGNETOSTATICS")]
    [JsonSubtypes.KnownSubType(typeof(TimeHarmonicMagnetics), "TIME_HARMONIC_MAGNETICS")]
    [JsonSubtypes.KnownSubType(typeof(TimeTransientMagnetics), "TIME_TRANSIENT_MAGNETICS")]
    public interface OneOfElectromagneticAnalysisModel
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}