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
    /// OneOfAutoTimestepDefinitionRetimingEvent
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(ErrorRetimingEvent), "ERROR")]
    [JsonSubtypes.KnownSubType(typeof(CollisionRetimingEvent), "COLLISION")]
    [JsonSubtypes.KnownSubType(typeof(FieldChangeRetimingEvent), "FIELD_CHANGE")]
    [JsonSubtypes.KnownSubType(typeof(NonMonotomousResidualRetimingEvent), "NON_MONOTOMOUS_RESIDUAL")]
    public interface OneOfAutoTimestepDefinitionRetimingEvent
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}