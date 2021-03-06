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
    /// GradientSchemes
    /// </summary>
    [DataContract]
    public partial class GradientSchemes : IEquatable<GradientSchemes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GradientSchemes" /> class.
        /// </summary>
        /// <param name="forDefault">forDefault.</param>
        /// <param name="gradPressure">gradPressure.</param>
        /// <param name="gradVelocity">gradVelocity.</param>
        /// <param name="gradPressureRgh">gradPressureRgh.</param>
        /// <param name="gradDensity">gradDensity.</param>
        /// <param name="gradEnthalpy">gradEnthalpy.</param>
        /// <param name="gradInternalEnergy">gradInternalEnergy.</param>
        /// <param name="gradTurbulentKineticEnergy">gradTurbulentKineticEnergy.</param>
        /// <param name="gradEpsilonDissipationRate">gradEpsilonDissipationRate.</param>
        /// <param name="gradOmegaDissipationRate">gradOmegaDissipationRate.</param>
        /// <param name="gradNuTilda">gradNuTilda.</param>
        /// <param name="gradTemperature">gradTemperature.</param>
        /// <param name="gradRhok">gradRhok.</param>
        public GradientSchemes(OneOfGradientSchemesForDefault forDefault = default(OneOfGradientSchemesForDefault), OneOfGradientSchemesGradPressure gradPressure = default(OneOfGradientSchemesGradPressure), OneOfGradientSchemesGradVelocity gradVelocity = default(OneOfGradientSchemesGradVelocity), OneOfGradientSchemesGradPressureRgh gradPressureRgh = default(OneOfGradientSchemesGradPressureRgh), OneOfGradientSchemesGradDensity gradDensity = default(OneOfGradientSchemesGradDensity), OneOfGradientSchemesGradEnthalpy gradEnthalpy = default(OneOfGradientSchemesGradEnthalpy), OneOfGradientSchemesGradInternalEnergy gradInternalEnergy = default(OneOfGradientSchemesGradInternalEnergy), OneOfGradientSchemesGradTurbulentKineticEnergy gradTurbulentKineticEnergy = default(OneOfGradientSchemesGradTurbulentKineticEnergy), OneOfGradientSchemesGradEpsilonDissipationRate gradEpsilonDissipationRate = default(OneOfGradientSchemesGradEpsilonDissipationRate), OneOfGradientSchemesGradOmegaDissipationRate gradOmegaDissipationRate = default(OneOfGradientSchemesGradOmegaDissipationRate), OneOfGradientSchemesGradNuTilda gradNuTilda = default(OneOfGradientSchemesGradNuTilda), OneOfGradientSchemesGradTemperature gradTemperature = default(OneOfGradientSchemesGradTemperature), OneOfGradientSchemesGradRhok gradRhok = default(OneOfGradientSchemesGradRhok))
        {
            this.ForDefault = forDefault;
            this.GradPressure = gradPressure;
            this.GradVelocity = gradVelocity;
            this.GradPressureRgh = gradPressureRgh;
            this.GradDensity = gradDensity;
            this.GradEnthalpy = gradEnthalpy;
            this.GradInternalEnergy = gradInternalEnergy;
            this.GradTurbulentKineticEnergy = gradTurbulentKineticEnergy;
            this.GradEpsilonDissipationRate = gradEpsilonDissipationRate;
            this.GradOmegaDissipationRate = gradOmegaDissipationRate;
            this.GradNuTilda = gradNuTilda;
            this.GradTemperature = gradTemperature;
            this.GradRhok = gradRhok;
        }
        
        /// <summary>
        /// Gets or Sets ForDefault
        /// </summary>
        [DataMember(Name="forDefault", EmitDefaultValue=false)]
        public OneOfGradientSchemesForDefault ForDefault { get; set; }

        /// <summary>
        /// Gets or Sets GradPressure
        /// </summary>
        [DataMember(Name="grad_pressure", EmitDefaultValue=false)]
        public OneOfGradientSchemesGradPressure GradPressure { get; set; }

        /// <summary>
        /// Gets or Sets GradVelocity
        /// </summary>
        [DataMember(Name="grad_velocity", EmitDefaultValue=false)]
        public OneOfGradientSchemesGradVelocity GradVelocity { get; set; }

        /// <summary>
        /// Gets or Sets GradPressureRgh
        /// </summary>
        [DataMember(Name="grad_pressureRgh", EmitDefaultValue=false)]
        public OneOfGradientSchemesGradPressureRgh GradPressureRgh { get; set; }

        /// <summary>
        /// Gets or Sets GradDensity
        /// </summary>
        [DataMember(Name="grad_density", EmitDefaultValue=false)]
        public OneOfGradientSchemesGradDensity GradDensity { get; set; }

        /// <summary>
        /// Gets or Sets GradEnthalpy
        /// </summary>
        [DataMember(Name="grad_enthalpy", EmitDefaultValue=false)]
        public OneOfGradientSchemesGradEnthalpy GradEnthalpy { get; set; }

        /// <summary>
        /// Gets or Sets GradInternalEnergy
        /// </summary>
        [DataMember(Name="grad_internalEnergy", EmitDefaultValue=false)]
        public OneOfGradientSchemesGradInternalEnergy GradInternalEnergy { get; set; }

        /// <summary>
        /// Gets or Sets GradTurbulentKineticEnergy
        /// </summary>
        [DataMember(Name="grad_turbulentKineticEnergy", EmitDefaultValue=false)]
        public OneOfGradientSchemesGradTurbulentKineticEnergy GradTurbulentKineticEnergy { get; set; }

        /// <summary>
        /// Gets or Sets GradEpsilonDissipationRate
        /// </summary>
        [DataMember(Name="grad_epsilonDissipationRate", EmitDefaultValue=false)]
        public OneOfGradientSchemesGradEpsilonDissipationRate GradEpsilonDissipationRate { get; set; }

        /// <summary>
        /// Gets or Sets GradOmegaDissipationRate
        /// </summary>
        [DataMember(Name="grad_omegaDissipationRate", EmitDefaultValue=false)]
        public OneOfGradientSchemesGradOmegaDissipationRate GradOmegaDissipationRate { get; set; }

        /// <summary>
        /// Gets or Sets GradNuTilda
        /// </summary>
        [DataMember(Name="grad_nuTilda", EmitDefaultValue=false)]
        public OneOfGradientSchemesGradNuTilda GradNuTilda { get; set; }

        /// <summary>
        /// Gets or Sets GradTemperature
        /// </summary>
        [DataMember(Name="grad_temperature", EmitDefaultValue=false)]
        public OneOfGradientSchemesGradTemperature GradTemperature { get; set; }

        /// <summary>
        /// Gets or Sets GradRhok
        /// </summary>
        [DataMember(Name="grad_rhok", EmitDefaultValue=false)]
        public OneOfGradientSchemesGradRhok GradRhok { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GradientSchemes {\n");
            sb.Append("  ForDefault: ").Append(ForDefault).Append("\n");
            sb.Append("  GradPressure: ").Append(GradPressure).Append("\n");
            sb.Append("  GradVelocity: ").Append(GradVelocity).Append("\n");
            sb.Append("  GradPressureRgh: ").Append(GradPressureRgh).Append("\n");
            sb.Append("  GradDensity: ").Append(GradDensity).Append("\n");
            sb.Append("  GradEnthalpy: ").Append(GradEnthalpy).Append("\n");
            sb.Append("  GradInternalEnergy: ").Append(GradInternalEnergy).Append("\n");
            sb.Append("  GradTurbulentKineticEnergy: ").Append(GradTurbulentKineticEnergy).Append("\n");
            sb.Append("  GradEpsilonDissipationRate: ").Append(GradEpsilonDissipationRate).Append("\n");
            sb.Append("  GradOmegaDissipationRate: ").Append(GradOmegaDissipationRate).Append("\n");
            sb.Append("  GradNuTilda: ").Append(GradNuTilda).Append("\n");
            sb.Append("  GradTemperature: ").Append(GradTemperature).Append("\n");
            sb.Append("  GradRhok: ").Append(GradRhok).Append("\n");
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
            return this.Equals(input as GradientSchemes);
        }

        /// <summary>
        /// Returns true if GradientSchemes instances are equal
        /// </summary>
        /// <param name="input">Instance of GradientSchemes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GradientSchemes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ForDefault == input.ForDefault ||
                    (this.ForDefault != null &&
                    this.ForDefault.Equals(input.ForDefault))
                ) && 
                (
                    this.GradPressure == input.GradPressure ||
                    (this.GradPressure != null &&
                    this.GradPressure.Equals(input.GradPressure))
                ) && 
                (
                    this.GradVelocity == input.GradVelocity ||
                    (this.GradVelocity != null &&
                    this.GradVelocity.Equals(input.GradVelocity))
                ) && 
                (
                    this.GradPressureRgh == input.GradPressureRgh ||
                    (this.GradPressureRgh != null &&
                    this.GradPressureRgh.Equals(input.GradPressureRgh))
                ) && 
                (
                    this.GradDensity == input.GradDensity ||
                    (this.GradDensity != null &&
                    this.GradDensity.Equals(input.GradDensity))
                ) && 
                (
                    this.GradEnthalpy == input.GradEnthalpy ||
                    (this.GradEnthalpy != null &&
                    this.GradEnthalpy.Equals(input.GradEnthalpy))
                ) && 
                (
                    this.GradInternalEnergy == input.GradInternalEnergy ||
                    (this.GradInternalEnergy != null &&
                    this.GradInternalEnergy.Equals(input.GradInternalEnergy))
                ) && 
                (
                    this.GradTurbulentKineticEnergy == input.GradTurbulentKineticEnergy ||
                    (this.GradTurbulentKineticEnergy != null &&
                    this.GradTurbulentKineticEnergy.Equals(input.GradTurbulentKineticEnergy))
                ) && 
                (
                    this.GradEpsilonDissipationRate == input.GradEpsilonDissipationRate ||
                    (this.GradEpsilonDissipationRate != null &&
                    this.GradEpsilonDissipationRate.Equals(input.GradEpsilonDissipationRate))
                ) && 
                (
                    this.GradOmegaDissipationRate == input.GradOmegaDissipationRate ||
                    (this.GradOmegaDissipationRate != null &&
                    this.GradOmegaDissipationRate.Equals(input.GradOmegaDissipationRate))
                ) && 
                (
                    this.GradNuTilda == input.GradNuTilda ||
                    (this.GradNuTilda != null &&
                    this.GradNuTilda.Equals(input.GradNuTilda))
                ) && 
                (
                    this.GradTemperature == input.GradTemperature ||
                    (this.GradTemperature != null &&
                    this.GradTemperature.Equals(input.GradTemperature))
                ) && 
                (
                    this.GradRhok == input.GradRhok ||
                    (this.GradRhok != null &&
                    this.GradRhok.Equals(input.GradRhok))
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
                if (this.ForDefault != null)
                    hashCode = hashCode * 59 + this.ForDefault.GetHashCode();
                if (this.GradPressure != null)
                    hashCode = hashCode * 59 + this.GradPressure.GetHashCode();
                if (this.GradVelocity != null)
                    hashCode = hashCode * 59 + this.GradVelocity.GetHashCode();
                if (this.GradPressureRgh != null)
                    hashCode = hashCode * 59 + this.GradPressureRgh.GetHashCode();
                if (this.GradDensity != null)
                    hashCode = hashCode * 59 + this.GradDensity.GetHashCode();
                if (this.GradEnthalpy != null)
                    hashCode = hashCode * 59 + this.GradEnthalpy.GetHashCode();
                if (this.GradInternalEnergy != null)
                    hashCode = hashCode * 59 + this.GradInternalEnergy.GetHashCode();
                if (this.GradTurbulentKineticEnergy != null)
                    hashCode = hashCode * 59 + this.GradTurbulentKineticEnergy.GetHashCode();
                if (this.GradEpsilonDissipationRate != null)
                    hashCode = hashCode * 59 + this.GradEpsilonDissipationRate.GetHashCode();
                if (this.GradOmegaDissipationRate != null)
                    hashCode = hashCode * 59 + this.GradOmegaDissipationRate.GetHashCode();
                if (this.GradNuTilda != null)
                    hashCode = hashCode * 59 + this.GradNuTilda.GetHashCode();
                if (this.GradTemperature != null)
                    hashCode = hashCode * 59 + this.GradTemperature.GetHashCode();
                if (this.GradRhok != null)
                    hashCode = hashCode * 59 + this.GradRhok.GetHashCode();
                return hashCode;
            }
        }

    }

}
