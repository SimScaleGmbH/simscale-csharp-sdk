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
    /// Cavitation
    /// </summary>
    [DataContract]
    public partial class Cavitation : IEquatable<Cavitation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cavitation" /> class.
        /// </summary>
        /// <param name="vaporMolecularWeight">vaporMolecularWeight.</param>
        /// <param name="liquidBulkModulus">liquidBulkModulus.</param>
        /// <param name="liquidBulkModulusCoefficient">The &lt;b&gt;liquid bulk modulus coefficient&lt;/b&gt; &lt;i&gt;B&lt;sub&gt;1&lt;/sub&gt;&lt;/i&gt; accounts for a linear rate of change in the liquid bulk modulus with respect to pressure such that &lt;i&gt;B &#x3D; B&lt;sub&gt;0&lt;/sub&gt; + B&lt;sub&gt;1&lt;/sub&gt; (P - P&lt;sub&gt;ref&lt;/sub&gt;)&lt;/i&gt;, where &lt;i&gt;B&lt;sub&gt;0&lt;/sub&gt;&lt;/i&gt; is the constant liquid bulk modulus. Typically only applicable in cases where pressure differences exceed 100 bar, otherwise a zero value should be specified. (default to 0M).</param>
        /// <param name="liquidReferencePressure">liquidReferencePressure.</param>
        /// <param name="saturationPressure">saturationPressure.</param>
        /// <param name="liquidTemperature">liquidTemperature.</param>
        public Cavitation(DimensionalMolarMass vaporMolecularWeight = default(DimensionalMolarMass), DimensionalPressure liquidBulkModulus = default(DimensionalPressure), decimal? liquidBulkModulusCoefficient = default(decimal?), DimensionalPressure liquidReferencePressure = default(DimensionalPressure), DimensionalPressure saturationPressure = default(DimensionalPressure), DimensionalTemperature liquidTemperature = default(DimensionalTemperature))
        {
            this.VaporMolecularWeight = vaporMolecularWeight;
            this.LiquidBulkModulus = liquidBulkModulus;
            this.LiquidBulkModulusCoefficient = liquidBulkModulusCoefficient;
            this.LiquidReferencePressure = liquidReferencePressure;
            this.SaturationPressure = saturationPressure;
            this.LiquidTemperature = liquidTemperature;
        }
        
        /// <summary>
        /// Gets or Sets VaporMolecularWeight
        /// </summary>
        [DataMember(Name="vaporMolecularWeight", EmitDefaultValue=false)]
        public DimensionalMolarMass VaporMolecularWeight { get; set; }

        /// <summary>
        /// Gets or Sets LiquidBulkModulus
        /// </summary>
        [DataMember(Name="liquidBulkModulus", EmitDefaultValue=false)]
        public DimensionalPressure LiquidBulkModulus { get; set; }

        /// <summary>
        /// The &lt;b&gt;liquid bulk modulus coefficient&lt;/b&gt; &lt;i&gt;B&lt;sub&gt;1&lt;/sub&gt;&lt;/i&gt; accounts for a linear rate of change in the liquid bulk modulus with respect to pressure such that &lt;i&gt;B &#x3D; B&lt;sub&gt;0&lt;/sub&gt; + B&lt;sub&gt;1&lt;/sub&gt; (P - P&lt;sub&gt;ref&lt;/sub&gt;)&lt;/i&gt;, where &lt;i&gt;B&lt;sub&gt;0&lt;/sub&gt;&lt;/i&gt; is the constant liquid bulk modulus. Typically only applicable in cases where pressure differences exceed 100 bar, otherwise a zero value should be specified.
        /// </summary>
        /// <value>The &lt;b&gt;liquid bulk modulus coefficient&lt;/b&gt; &lt;i&gt;B&lt;sub&gt;1&lt;/sub&gt;&lt;/i&gt; accounts for a linear rate of change in the liquid bulk modulus with respect to pressure such that &lt;i&gt;B &#x3D; B&lt;sub&gt;0&lt;/sub&gt; + B&lt;sub&gt;1&lt;/sub&gt; (P - P&lt;sub&gt;ref&lt;/sub&gt;)&lt;/i&gt;, where &lt;i&gt;B&lt;sub&gt;0&lt;/sub&gt;&lt;/i&gt; is the constant liquid bulk modulus. Typically only applicable in cases where pressure differences exceed 100 bar, otherwise a zero value should be specified.</value>
        [DataMember(Name="liquidBulkModulusCoefficient", EmitDefaultValue=false)]
        public decimal? LiquidBulkModulusCoefficient { get; set; }

        /// <summary>
        /// Gets or Sets LiquidReferencePressure
        /// </summary>
        [DataMember(Name="liquidReferencePressure", EmitDefaultValue=false)]
        public DimensionalPressure LiquidReferencePressure { get; set; }

        /// <summary>
        /// Gets or Sets SaturationPressure
        /// </summary>
        [DataMember(Name="saturationPressure", EmitDefaultValue=false)]
        public DimensionalPressure SaturationPressure { get; set; }

        /// <summary>
        /// Gets or Sets LiquidTemperature
        /// </summary>
        [DataMember(Name="liquidTemperature", EmitDefaultValue=false)]
        public DimensionalTemperature LiquidTemperature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cavitation {\n");
            sb.Append("  VaporMolecularWeight: ").Append(VaporMolecularWeight).Append("\n");
            sb.Append("  LiquidBulkModulus: ").Append(LiquidBulkModulus).Append("\n");
            sb.Append("  LiquidBulkModulusCoefficient: ").Append(LiquidBulkModulusCoefficient).Append("\n");
            sb.Append("  LiquidReferencePressure: ").Append(LiquidReferencePressure).Append("\n");
            sb.Append("  SaturationPressure: ").Append(SaturationPressure).Append("\n");
            sb.Append("  LiquidTemperature: ").Append(LiquidTemperature).Append("\n");
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
            return this.Equals(input as Cavitation);
        }

        /// <summary>
        /// Returns true if Cavitation instances are equal
        /// </summary>
        /// <param name="input">Instance of Cavitation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Cavitation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VaporMolecularWeight == input.VaporMolecularWeight ||
                    (this.VaporMolecularWeight != null &&
                    this.VaporMolecularWeight.Equals(input.VaporMolecularWeight))
                ) && 
                (
                    this.LiquidBulkModulus == input.LiquidBulkModulus ||
                    (this.LiquidBulkModulus != null &&
                    this.LiquidBulkModulus.Equals(input.LiquidBulkModulus))
                ) && 
                (
                    this.LiquidBulkModulusCoefficient == input.LiquidBulkModulusCoefficient ||
                    (this.LiquidBulkModulusCoefficient != null &&
                    this.LiquidBulkModulusCoefficient.Equals(input.LiquidBulkModulusCoefficient))
                ) && 
                (
                    this.LiquidReferencePressure == input.LiquidReferencePressure ||
                    (this.LiquidReferencePressure != null &&
                    this.LiquidReferencePressure.Equals(input.LiquidReferencePressure))
                ) && 
                (
                    this.SaturationPressure == input.SaturationPressure ||
                    (this.SaturationPressure != null &&
                    this.SaturationPressure.Equals(input.SaturationPressure))
                ) && 
                (
                    this.LiquidTemperature == input.LiquidTemperature ||
                    (this.LiquidTemperature != null &&
                    this.LiquidTemperature.Equals(input.LiquidTemperature))
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
                if (this.VaporMolecularWeight != null)
                    hashCode = hashCode * 59 + this.VaporMolecularWeight.GetHashCode();
                if (this.LiquidBulkModulus != null)
                    hashCode = hashCode * 59 + this.LiquidBulkModulus.GetHashCode();
                if (this.LiquidBulkModulusCoefficient != null)
                    hashCode = hashCode * 59 + this.LiquidBulkModulusCoefficient.GetHashCode();
                if (this.LiquidReferencePressure != null)
                    hashCode = hashCode * 59 + this.LiquidReferencePressure.GetHashCode();
                if (this.SaturationPressure != null)
                    hashCode = hashCode * 59 + this.SaturationPressure.GetHashCode();
                if (this.LiquidTemperature != null)
                    hashCode = hashCode * 59 + this.LiquidTemperature.GetHashCode();
                return hashCode;
            }
        }

    }

}