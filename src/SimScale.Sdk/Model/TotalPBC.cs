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
    /// TotalPBC
    /// </summary>
    [DataContract]
    public partial class TotalPBC : OneOfCustomFluidBCGaugePressure, OneOfCustomFluidBCGaugePressureRgh, OneOfCustomFluidBCPressure, OneOfCustomFluidBCPressureRgh, OneOfPressureInletBCGaugePressure, OneOfPressureInletBCPressure, OneOfPressureInletBCPressureRgh, IEquatable<TotalPBC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TotalPBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TotalPBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TotalPBC" /> class.
        /// </summary>
        /// <param name="type">Schema name: TotalPBC (required) (default to &quot;TOTAL_PRESSURE&quot;).</param>
        /// <param name="totalPressure">totalPressure.</param>
        public TotalPBC(string type = "TOTAL_PRESSURE", DimensionalFunctionPressure totalPressure = default(DimensionalFunctionPressure))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for TotalPBC and cannot be null");
            this.TotalPressure = totalPressure;
        }
        
        /// <summary>
        /// Schema name: TotalPBC
        /// </summary>
        /// <value>Schema name: TotalPBC</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets TotalPressure
        /// </summary>
        [DataMember(Name="totalPressure", EmitDefaultValue=false)]
        public DimensionalFunctionPressure TotalPressure { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TotalPBC {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TotalPressure: ").Append(TotalPressure).Append("\n");
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
            return this.Equals(input as TotalPBC);
        }

        /// <summary>
        /// Returns true if TotalPBC instances are equal
        /// </summary>
        /// <param name="input">Instance of TotalPBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TotalPBC input)
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
                    this.TotalPressure == input.TotalPressure ||
                    (this.TotalPressure != null &&
                    this.TotalPressure.Equals(input.TotalPressure))
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
                if (this.TotalPressure != null)
                    hashCode = hashCode * 59 + this.TotalPressure.GetHashCode();
                return hashCode;
            }
        }

    }

}
