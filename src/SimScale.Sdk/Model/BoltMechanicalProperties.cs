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
    /// BoltMechanicalProperties
    /// </summary>
    [DataContract]
    public partial class BoltMechanicalProperties : IEquatable<BoltMechanicalProperties>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoltMechanicalProperties" /> class.
        /// </summary>
        /// <param name="youngsModulus">youngsModulus.</param>
        /// <param name="poissonsRatio">Provide the Poisson&#39;s ratio value which describes the compression or elongation of the bolt material transverse to axial strain. Poisson&#39;s ratio can have a value within range from -1 to 0.5. (default to 0.28M).</param>
        /// <param name="density">density.</param>
        public BoltMechanicalProperties(DimensionalPressure youngsModulus = default(DimensionalPressure), decimal? poissonsRatio = default(decimal?), DimensionalDensity density = default(DimensionalDensity))
        {
            this.YoungsModulus = youngsModulus;
            this.PoissonsRatio = poissonsRatio;
            this.Density = density;
        }
        
        /// <summary>
        /// Gets or Sets YoungsModulus
        /// </summary>
        [DataMember(Name="youngsModulus", EmitDefaultValue=false)]
        public DimensionalPressure YoungsModulus { get; set; }

        /// <summary>
        /// Provide the Poisson&#39;s ratio value which describes the compression or elongation of the bolt material transverse to axial strain. Poisson&#39;s ratio can have a value within range from -1 to 0.5.
        /// </summary>
        /// <value>Provide the Poisson&#39;s ratio value which describes the compression or elongation of the bolt material transverse to axial strain. Poisson&#39;s ratio can have a value within range from -1 to 0.5.</value>
        [DataMember(Name="poissonsRatio", EmitDefaultValue=false)]
        public decimal? PoissonsRatio { get; set; }

        /// <summary>
        /// Gets or Sets Density
        /// </summary>
        [DataMember(Name="density", EmitDefaultValue=false)]
        public DimensionalDensity Density { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoltMechanicalProperties {\n");
            sb.Append("  YoungsModulus: ").Append(YoungsModulus).Append("\n");
            sb.Append("  PoissonsRatio: ").Append(PoissonsRatio).Append("\n");
            sb.Append("  Density: ").Append(Density).Append("\n");
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
            return this.Equals(input as BoltMechanicalProperties);
        }

        /// <summary>
        /// Returns true if BoltMechanicalProperties instances are equal
        /// </summary>
        /// <param name="input">Instance of BoltMechanicalProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoltMechanicalProperties input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.YoungsModulus == input.YoungsModulus ||
                    (this.YoungsModulus != null &&
                    this.YoungsModulus.Equals(input.YoungsModulus))
                ) && 
                (
                    this.PoissonsRatio == input.PoissonsRatio ||
                    (this.PoissonsRatio != null &&
                    this.PoissonsRatio.Equals(input.PoissonsRatio))
                ) && 
                (
                    this.Density == input.Density ||
                    (this.Density != null &&
                    this.Density.Equals(input.Density))
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
                if (this.YoungsModulus != null)
                    hashCode = hashCode * 59 + this.YoungsModulus.GetHashCode();
                if (this.PoissonsRatio != null)
                    hashCode = hashCode * 59 + this.PoissonsRatio.GetHashCode();
                if (this.Density != null)
                    hashCode = hashCode * 59 + this.Density.GetHashCode();
                return hashCode;
            }
        }

    }

}