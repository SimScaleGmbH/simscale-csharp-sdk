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
using OpenAPIDateConverter = SimScale.Sdk.Client.OpenAPIDateConverter;

namespace SimScale.Sdk.Model
{
    /// <summary>
    /// Defines GeometryUnit
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum GeometryUnit
    {
        /// <summary>
        /// Enum M for value: m
        /// </summary>
        [EnumMember(Value = "m")]
        M = 1,

        /// <summary>
        /// Enum Cm for value: cm
        /// </summary>
        [EnumMember(Value = "cm")]
        Cm = 2,

        /// <summary>
        /// Enum Mm for value: mm
        /// </summary>
        [EnumMember(Value = "mm")]
        Mm = 3,

        /// <summary>
        /// Enum Ft for value: ft
        /// </summary>
        [EnumMember(Value = "ft")]
        Ft = 4,

        /// <summary>
        /// Enum In for value: in
        /// </summary>
        [EnumMember(Value = "in")]
        In = 5,

        /// <summary>
        /// Enum Yd for value: yd
        /// </summary>
        [EnumMember(Value = "yd")]
        Yd = 6

    }

}
