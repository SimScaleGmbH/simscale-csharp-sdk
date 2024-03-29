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
    /// &lt;p&gt;Define the plastic hardening type of the material.&lt;/p&gt;
    /// </summary>
    [DataContract]
    public partial class IsotropicPlasticHardening : IEquatable<IsotropicPlasticHardening>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsotropicPlasticHardening" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IsotropicPlasticHardening() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IsotropicPlasticHardening" /> class.
        /// </summary>
        /// <param name="type">&lt;p&gt;Define the plastic hardening type of the material.&lt;/p&gt;  Schema name: IsotropicPlasticHardening (required) (default to &quot;ISOTROPIC&quot;).</param>
        /// <param name="youngsModulus">youngsModulus.</param>
        /// <param name="poissonsRatio">poissonsRatio.</param>
        /// <param name="vonMisesStress">vonMisesStress.</param>
        public IsotropicPlasticHardening(string type = "ISOTROPIC", DimensionalFunctionPressure youngsModulus = default(DimensionalFunctionPressure), OneOfIsotropicPlasticHardeningPoissonsRatio poissonsRatio = default(OneOfIsotropicPlasticHardeningPoissonsRatio), DimensionalFunctionPressure vonMisesStress = default(DimensionalFunctionPressure))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for IsotropicPlasticHardening and cannot be null");
            this.YoungsModulus = youngsModulus;
            this.PoissonsRatio = poissonsRatio;
            this.VonMisesStress = vonMisesStress;
        }
        
        /// <summary>
        /// &lt;p&gt;Define the plastic hardening type of the material.&lt;/p&gt;  Schema name: IsotropicPlasticHardening
        /// </summary>
        /// <value>&lt;p&gt;Define the plastic hardening type of the material.&lt;/p&gt;  Schema name: IsotropicPlasticHardening</value>
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
        public OneOfIsotropicPlasticHardeningPoissonsRatio PoissonsRatio { get; set; }

        /// <summary>
        /// Gets or Sets VonMisesStress
        /// </summary>
        [DataMember(Name="vonMisesStress", EmitDefaultValue=false)]
        public DimensionalFunctionPressure VonMisesStress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IsotropicPlasticHardening {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  YoungsModulus: ").Append(YoungsModulus).Append("\n");
            sb.Append("  PoissonsRatio: ").Append(PoissonsRatio).Append("\n");
            sb.Append("  VonMisesStress: ").Append(VonMisesStress).Append("\n");
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
            return this.Equals(input as IsotropicPlasticHardening);
        }

        /// <summary>
        /// Returns true if IsotropicPlasticHardening instances are equal
        /// </summary>
        /// <param name="input">Instance of IsotropicPlasticHardening to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IsotropicPlasticHardening input)
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
                ) && 
                (
                    this.VonMisesStress == input.VonMisesStress ||
                    (this.VonMisesStress != null &&
                    this.VonMisesStress.Equals(input.VonMisesStress))
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
                if (this.VonMisesStress != null)
                    hashCode = hashCode * 59 + this.VonMisesStress.GetHashCode();
                return hashCode;
            }
        }

    }

}
