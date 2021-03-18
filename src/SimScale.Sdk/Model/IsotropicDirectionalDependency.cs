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
    /// &lt;p&gt;Choose the directional dependency for this property. &lt;b&gt;Anisotropic and orthotropic materials will be available soon.&lt;/b&gt;&lt;/p&gt;
    /// </summary>
    [DataContract]
    public partial class IsotropicDirectionalDependency : IEquatable<IsotropicDirectionalDependency>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsotropicDirectionalDependency" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IsotropicDirectionalDependency() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IsotropicDirectionalDependency" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;ISOTROPIC&quot;).</param>
        /// <param name="youngsModulus">youngsModulus.</param>
        /// <param name="poissonsRatio">poissonsRatio.</param>
        public IsotropicDirectionalDependency(string type = "ISOTROPIC", DimensionalFunctionPressure youngsModulus = default(DimensionalFunctionPressure), OneOfIsotropicDirectionalDependencyPoissonsRatio poissonsRatio = default(OneOfIsotropicDirectionalDependencyPoissonsRatio))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for IsotropicDirectionalDependency and cannot be null");
            this.YoungsModulus = youngsModulus;
            this.PoissonsRatio = poissonsRatio;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets YoungsModulus
        /// </summary>
        [DataMember(Name="youngsModulus", EmitDefaultValue=false)]
        public DimensionalFunctionPressure YoungsModulus { get; set; }

        /// <summary>
        /// Gets or Sets PoissonsRatio
        /// </summary>
        [DataMember(Name="poissonsRatio", EmitDefaultValue=false)]
        public OneOfIsotropicDirectionalDependencyPoissonsRatio PoissonsRatio { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IsotropicDirectionalDependency {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  YoungsModulus: ").Append(YoungsModulus).Append("\n");
            sb.Append("  PoissonsRatio: ").Append(PoissonsRatio).Append("\n");
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
            return this.Equals(input as IsotropicDirectionalDependency);
        }

        /// <summary>
        /// Returns true if IsotropicDirectionalDependency instances are equal
        /// </summary>
        /// <param name="input">Instance of IsotropicDirectionalDependency to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IsotropicDirectionalDependency input)
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
                    this.YoungsModulus == input.YoungsModulus ||
                    (this.YoungsModulus != null &&
                    this.YoungsModulus.Equals(input.YoungsModulus))
                ) && 
                (
                    this.PoissonsRatio == input.PoissonsRatio ||
                    (this.PoissonsRatio != null &&
                    this.PoissonsRatio.Equals(input.PoissonsRatio))
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
                if (this.YoungsModulus != null)
                    hashCode = hashCode * 59 + this.YoungsModulus.GetHashCode();
                if (this.PoissonsRatio != null)
                    hashCode = hashCode * 59 + this.PoissonsRatio.GetHashCode();
                return hashCode;
            }
        }

    }

}