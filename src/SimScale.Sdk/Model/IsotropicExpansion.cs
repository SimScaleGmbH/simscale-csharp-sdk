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
    /// &lt;p&gt;Define the directional dependency of this property. Isotropic means directionally independent.&lt;/p&gt;
    /// </summary>
    [DataContract]
    public partial class IsotropicExpansion : IEquatable<IsotropicExpansion>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsotropicExpansion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IsotropicExpansion() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IsotropicExpansion" /> class.
        /// </summary>
        /// <param name="type">&lt;p&gt;Define the directional dependency of this property. Isotropic means directionally independent.&lt;/p&gt;  Schema name: IsotropicExpansion (required) (default to &quot;ISOTROPIC&quot;).</param>
        /// <param name="expansionCoefficient">expansionCoefficient.</param>
        /// <param name="referenceTemperature">referenceTemperature.</param>
        public IsotropicExpansion(string type = "ISOTROPIC", DimensionalFunctionThermalExpansionRate expansionCoefficient = default(DimensionalFunctionThermalExpansionRate), DimensionalTemperature referenceTemperature = default(DimensionalTemperature))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for IsotropicExpansion and cannot be null");
            this.ExpansionCoefficient = expansionCoefficient;
            this.ReferenceTemperature = referenceTemperature;
        }
        
        /// <summary>
        /// &lt;p&gt;Define the directional dependency of this property. Isotropic means directionally independent.&lt;/p&gt;  Schema name: IsotropicExpansion
        /// </summary>
        /// <value>&lt;p&gt;Define the directional dependency of this property. Isotropic means directionally independent.&lt;/p&gt;  Schema name: IsotropicExpansion</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets ExpansionCoefficient
        /// </summary>
        [DataMember(Name="expansionCoefficient", EmitDefaultValue=false)]
        public DimensionalFunctionThermalExpansionRate ExpansionCoefficient { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceTemperature
        /// </summary>
        [DataMember(Name="referenceTemperature", EmitDefaultValue=false)]
        public DimensionalTemperature ReferenceTemperature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IsotropicExpansion {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ExpansionCoefficient: ").Append(ExpansionCoefficient).Append("\n");
            sb.Append("  ReferenceTemperature: ").Append(ReferenceTemperature).Append("\n");
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
            return this.Equals(input as IsotropicExpansion);
        }

        /// <summary>
        /// Returns true if IsotropicExpansion instances are equal
        /// </summary>
        /// <param name="input">Instance of IsotropicExpansion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IsotropicExpansion input)
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
                    this.ExpansionCoefficient == input.ExpansionCoefficient ||
                    (this.ExpansionCoefficient != null &&
                    this.ExpansionCoefficient.Equals(input.ExpansionCoefficient))
                ) && 
                (
                    this.ReferenceTemperature == input.ReferenceTemperature ||
                    (this.ReferenceTemperature != null &&
                    this.ReferenceTemperature.Equals(input.ReferenceTemperature))
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
                if (this.ExpansionCoefficient != null)
                    hashCode = hashCode * 59 + this.ExpansionCoefficient.GetHashCode();
                if (this.ReferenceTemperature != null)
                    hashCode = hashCode * 59 + this.ReferenceTemperature.GetHashCode();
                return hashCode;
            }
        }

    }

}
