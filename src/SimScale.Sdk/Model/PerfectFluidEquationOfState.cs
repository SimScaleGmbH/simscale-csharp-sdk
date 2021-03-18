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
    /// &lt;br&gt;&lt;p&gt;The &lt;b&gt;Equation of state&lt;/b&gt; describes the relation between density of a fluid and the fluid pressure and temperature. The available options are:&lt;/p&gt;&lt;p&gt;&lt;b&gt;Rho const:&lt;/b&gt; Fluid density is assumed constant.&lt;/p&gt;&lt;p&gt;&lt;b&gt;Incompressibel perfect gas:&lt;/b&gt; The fluid is assumed to be an &#39;Ideal Gas&#39; that is incompressible by pressure. But, fluid density can change due to temperature.&lt;/p&gt;&lt;p&gt;&lt;b&gt;Perfect gas:&lt;/b&gt; Fluid is assumed to be an &#39;Ideal Gas&#39; and obeys the &#39;Ideal Gas Law&#39;.&lt;/p&gt;&lt;p&gt;&lt;b&gt;Perfect fluid:&lt;/b&gt; Fluid density can change due to pressure and temperature with respect to a base value.&lt;/p&gt;&lt;p&gt;&lt;b&gt;Adiabatic perfect fluid:&lt;/b&gt; The fluid is a perfect fluid which is adiabatic in nature.&lt;/p&gt; &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/materials/thermophysical-fluid-models/#equation-of-state&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class PerfectFluidEquationOfState : OneOfHConstThermoEquationOfState, IEquatable<PerfectFluidEquationOfState>
    {
        /// <summary>
        /// &lt;p&gt;&lt;b&gt;Energy&lt;/b&gt; provides the methods for the form of energy to be used. The options are:&lt;/p&gt;&lt;p&gt;&lt;b&gt;Sensible enthalpy:&lt;/b&gt; The enthalpy form of equation is used without the heat of formation. In most cases this is the recommended choice.&lt;/p&gt;&lt;p&gt;&lt;b&gt;Sensible internal Energy:&lt;/b&gt; The internal energy form of equation is used without the heat of formation but also incorporates energy change due to reactions.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;&lt;b&gt;Energy&lt;/b&gt; provides the methods for the form of energy to be used. The options are:&lt;/p&gt;&lt;p&gt;&lt;b&gt;Sensible enthalpy:&lt;/b&gt; The enthalpy form of equation is used without the heat of formation. In most cases this is the recommended choice.&lt;/p&gt;&lt;p&gt;&lt;b&gt;Sensible internal Energy:&lt;/b&gt; The internal energy form of equation is used without the heat of formation but also incorporates energy change due to reactions.&lt;/p&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EnergyEnum
        {
            /// <summary>
            /// Enum ENTHALPY for value: SENSIBLE_ENTHALPY
            /// </summary>
            [EnumMember(Value = "SENSIBLE_ENTHALPY")]
            ENTHALPY = 1,

            /// <summary>
            /// Enum INTERNALENERGY for value: SENSIBLE_INTERNAL_ENERGY
            /// </summary>
            [EnumMember(Value = "SENSIBLE_INTERNAL_ENERGY")]
            INTERNALENERGY = 2

        }

        /// <summary>
        /// &lt;p&gt;&lt;b&gt;Energy&lt;/b&gt; provides the methods for the form of energy to be used. The options are:&lt;/p&gt;&lt;p&gt;&lt;b&gt;Sensible enthalpy:&lt;/b&gt; The enthalpy form of equation is used without the heat of formation. In most cases this is the recommended choice.&lt;/p&gt;&lt;p&gt;&lt;b&gt;Sensible internal Energy:&lt;/b&gt; The internal energy form of equation is used without the heat of formation but also incorporates energy change due to reactions.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;&lt;b&gt;Energy&lt;/b&gt; provides the methods for the form of energy to be used. The options are:&lt;/p&gt;&lt;p&gt;&lt;b&gt;Sensible enthalpy:&lt;/b&gt; The enthalpy form of equation is used without the heat of formation. In most cases this is the recommended choice.&lt;/p&gt;&lt;p&gt;&lt;b&gt;Sensible internal Energy:&lt;/b&gt; The internal energy form of equation is used without the heat of formation but also incorporates energy change due to reactions.&lt;/p&gt;</value>
        [DataMember(Name="energy", EmitDefaultValue=false)]
        public EnergyEnum? Energy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PerfectFluidEquationOfState" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PerfectFluidEquationOfState() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PerfectFluidEquationOfState" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;PERFECT_FLUID&quot;).</param>
        /// <param name="fluidConstant">fluidConstant.</param>
        /// <param name="referenceDensity">referenceDensity.</param>
        /// <param name="energy">&lt;p&gt;&lt;b&gt;Energy&lt;/b&gt; provides the methods for the form of energy to be used. The options are:&lt;/p&gt;&lt;p&gt;&lt;b&gt;Sensible enthalpy:&lt;/b&gt; The enthalpy form of equation is used without the heat of formation. In most cases this is the recommended choice.&lt;/p&gt;&lt;p&gt;&lt;b&gt;Sensible internal Energy:&lt;/b&gt; The internal energy form of equation is used without the heat of formation but also incorporates energy change due to reactions.&lt;/p&gt; (default to EnergyEnum.ENTHALPY).</param>
        public PerfectFluidEquationOfState(string type = "PERFECT_FLUID", DimensionalSpecificHeat fluidConstant = default(DimensionalSpecificHeat), DimensionalDensity referenceDensity = default(DimensionalDensity), EnergyEnum? energy = default(EnergyEnum?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for PerfectFluidEquationOfState and cannot be null");
            this.FluidConstant = fluidConstant;
            this.ReferenceDensity = referenceDensity;
            this.Energy = energy;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets FluidConstant
        /// </summary>
        [DataMember(Name="fluidConstant", EmitDefaultValue=false)]
        public DimensionalSpecificHeat FluidConstant { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceDensity
        /// </summary>
        [DataMember(Name="referenceDensity", EmitDefaultValue=false)]
        public DimensionalDensity ReferenceDensity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PerfectFluidEquationOfState {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FluidConstant: ").Append(FluidConstant).Append("\n");
            sb.Append("  ReferenceDensity: ").Append(ReferenceDensity).Append("\n");
            sb.Append("  Energy: ").Append(Energy).Append("\n");
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
            return this.Equals(input as PerfectFluidEquationOfState);
        }

        /// <summary>
        /// Returns true if PerfectFluidEquationOfState instances are equal
        /// </summary>
        /// <param name="input">Instance of PerfectFluidEquationOfState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PerfectFluidEquationOfState input)
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
                    this.FluidConstant == input.FluidConstant ||
                    (this.FluidConstant != null &&
                    this.FluidConstant.Equals(input.FluidConstant))
                ) && 
                (
                    this.ReferenceDensity == input.ReferenceDensity ||
                    (this.ReferenceDensity != null &&
                    this.ReferenceDensity.Equals(input.ReferenceDensity))
                ) && 
                (
                    this.Energy == input.Energy ||
                    this.Energy.Equals(input.Energy)
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
                if (this.FluidConstant != null)
                    hashCode = hashCode * 59 + this.FluidConstant.GetHashCode();
                if (this.ReferenceDensity != null)
                    hashCode = hashCode * 59 + this.ReferenceDensity.GetHashCode();
                hashCode = hashCode * 59 + this.Energy.GetHashCode();
                return hashCode;
            }
        }

    }

}