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
    /// CustomSolarLoad
    /// </summary>
    [DataContract]
    public partial class CustomSolarLoad : OneOfSolarCalculatorSolarLoad, IEquatable<CustomSolarLoad>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomSolarLoad" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomSolarLoad() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomSolarLoad" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;CUSTOM_SOLAR_LOAD&quot;).</param>
        /// <param name="directedSolarLoad">directedSolarLoad.</param>
        /// <param name="diffusiveSolarLoad">diffusiveSolarLoad.</param>
        public CustomSolarLoad(string type = "CUSTOM_SOLAR_LOAD", DimensionalHeatFlux directedSolarLoad = default(DimensionalHeatFlux), DimensionalHeatFlux diffusiveSolarLoad = default(DimensionalHeatFlux))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for CustomSolarLoad and cannot be null");
            this.DirectedSolarLoad = directedSolarLoad;
            this.DiffusiveSolarLoad = diffusiveSolarLoad;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets DirectedSolarLoad
        /// </summary>
        [DataMember(Name="directedSolarLoad", EmitDefaultValue=false)]
        public DimensionalHeatFlux DirectedSolarLoad { get; set; }

        /// <summary>
        /// Gets or Sets DiffusiveSolarLoad
        /// </summary>
        [DataMember(Name="diffusiveSolarLoad", EmitDefaultValue=false)]
        public DimensionalHeatFlux DiffusiveSolarLoad { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomSolarLoad {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DirectedSolarLoad: ").Append(DirectedSolarLoad).Append("\n");
            sb.Append("  DiffusiveSolarLoad: ").Append(DiffusiveSolarLoad).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomSolarLoad);
        }

        /// <summary>
        /// Returns true if CustomSolarLoad instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomSolarLoad to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomSolarLoad input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.DirectedSolarLoad == input.DirectedSolarLoad ||
                    (this.DirectedSolarLoad != null &&
                    this.DirectedSolarLoad.Equals(input.DirectedSolarLoad))
                ) && 
                (
                    this.DiffusiveSolarLoad == input.DiffusiveSolarLoad ||
                    (this.DiffusiveSolarLoad != null &&
                    this.DiffusiveSolarLoad.Equals(input.DiffusiveSolarLoad))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DirectedSolarLoad != null)
                    hashCode = hashCode * 59 + this.DirectedSolarLoad.GetHashCode();
                if (this.DiffusiveSolarLoad != null)
                    hashCode = hashCode * 59 + this.DiffusiveSolarLoad.GetHashCode();
                return hashCode;
            }
        }

    }

}