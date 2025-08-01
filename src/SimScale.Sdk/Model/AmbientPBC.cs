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
    /// AmbientPBC
    /// </summary>
    [DataContract]
    public partial class AmbientPBC : OneOfNaturalConvectionInletOutletBCPressureRgh, IEquatable<AmbientPBC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AmbientPBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AmbientPBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AmbientPBC" /> class.
        /// </summary>
        /// <param name="type">Schema name: AmbientPBC (required) (default to &quot;AMBIENT_PRESSURE&quot;).</param>
        /// <param name="ambientPressure">ambientPressure.</param>
        public AmbientPBC(string type = "AMBIENT_PRESSURE", DimensionalPressure ambientPressure = default(DimensionalPressure))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for AmbientPBC and cannot be null");
            this.AmbientPressure = ambientPressure;
        }
        
        /// <summary>
        /// Schema name: AmbientPBC
        /// </summary>
        /// <value>Schema name: AmbientPBC</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets AmbientPressure
        /// </summary>
        [DataMember(Name="ambientPressure", EmitDefaultValue=false)]
        public DimensionalPressure AmbientPressure { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AmbientPBC {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AmbientPressure: ").Append(AmbientPressure).Append("\n");
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
            return this.Equals(input as AmbientPBC);
        }

        /// <summary>
        /// Returns true if AmbientPBC instances are equal
        /// </summary>
        /// <param name="input">Instance of AmbientPBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AmbientPBC input)
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
                    this.AmbientPressure == input.AmbientPressure ||
                    (this.AmbientPressure != null &&
                    this.AmbientPressure.Equals(input.AmbientPressure))
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
                if (this.AmbientPressure != null)
                    hashCode = hashCode * 59 + this.AmbientPressure.GetHashCode();
                return hashCode;
            }
        }

    }

}
