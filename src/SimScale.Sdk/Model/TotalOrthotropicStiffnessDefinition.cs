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
    /// TotalOrthotropicStiffnessDefinition
    /// </summary>
    [DataContract]
    public partial class TotalOrthotropicStiffnessDefinition : OneOfOrthotropicSpringStiffnessStiffnessDefinition, IEquatable<TotalOrthotropicStiffnessDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TotalOrthotropicStiffnessDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TotalOrthotropicStiffnessDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TotalOrthotropicStiffnessDefinition" /> class.
        /// </summary>
        /// <param name="type">Schema name: TotalOrthotropicStiffnessDefinition (required) (default to &quot;TOTAL_ORTHOTROPIC&quot;).</param>
        /// <param name="total">total.</param>
        public TotalOrthotropicStiffnessDefinition(string type = "TOTAL_ORTHOTROPIC", DimensionalVectorSurfaceTension total = default(DimensionalVectorSurfaceTension))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for TotalOrthotropicStiffnessDefinition and cannot be null");
            this.Total = total;
        }
        
        /// <summary>
        /// Schema name: TotalOrthotropicStiffnessDefinition
        /// </summary>
        /// <value>Schema name: TotalOrthotropicStiffnessDefinition</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public DimensionalVectorSurfaceTension Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TotalOrthotropicStiffnessDefinition {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as TotalOrthotropicStiffnessDefinition);
        }

        /// <summary>
        /// Returns true if TotalOrthotropicStiffnessDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of TotalOrthotropicStiffnessDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TotalOrthotropicStiffnessDefinition input)
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
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }

    }

}
