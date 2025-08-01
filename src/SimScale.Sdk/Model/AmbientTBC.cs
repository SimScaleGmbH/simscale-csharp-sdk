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
    /// AmbientTBC
    /// </summary>
    [DataContract]
    public partial class AmbientTBC : OneOfFanBCTemperature, IEquatable<AmbientTBC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AmbientTBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AmbientTBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AmbientTBC" /> class.
        /// </summary>
        /// <param name="type">Schema name: AmbientTBC (required) (default to &quot;AMBIENT_TEMPERATURE&quot;).</param>
        /// <param name="ambientTemperature">ambientTemperature.</param>
        public AmbientTBC(string type = "AMBIENT_TEMPERATURE", DimensionalTemperature ambientTemperature = default(DimensionalTemperature))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for AmbientTBC and cannot be null");
            this.AmbientTemperature = ambientTemperature;
        }
        
        /// <summary>
        /// Schema name: AmbientTBC
        /// </summary>
        /// <value>Schema name: AmbientTBC</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets AmbientTemperature
        /// </summary>
        [DataMember(Name="ambientTemperature", EmitDefaultValue=false)]
        public DimensionalTemperature AmbientTemperature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AmbientTBC {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AmbientTemperature: ").Append(AmbientTemperature).Append("\n");
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
            return this.Equals(input as AmbientTBC);
        }

        /// <summary>
        /// Returns true if AmbientTBC instances are equal
        /// </summary>
        /// <param name="input">Instance of AmbientTBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AmbientTBC input)
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
                    this.AmbientTemperature == input.AmbientTemperature ||
                    (this.AmbientTemperature != null &&
                    this.AmbientTemperature.Equals(input.AmbientTemperature))
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
                if (this.AmbientTemperature != null)
                    hashCode = hashCode * 59 + this.AmbientTemperature.GetHashCode();
                return hashCode;
            }
        }

    }

}
