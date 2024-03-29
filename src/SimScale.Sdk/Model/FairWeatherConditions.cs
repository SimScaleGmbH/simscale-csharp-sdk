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
    /// FairWeatherConditions
    /// </summary>
    [DataContract]
    public partial class FairWeatherConditions : OneOfSolarCalculatorSolarLoad, IEquatable<FairWeatherConditions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FairWeatherConditions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FairWeatherConditions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FairWeatherConditions" /> class.
        /// </summary>
        /// <param name="type">Schema name: FairWeatherConditions (required) (default to &quot;FAIR_WEATHER_CONDITIONS&quot;).</param>
        /// <param name="skyCloudCoverFraction">skyCloudCoverFraction (default to 0M).</param>
        /// <param name="groundReflectivity">groundReflectivity (default to 0.2M).</param>
        /// <param name="apparentSolarIrradiation">apparentSolarIrradiation.</param>
        /// <param name="atmosphericExtinctionCoefficient">Atmospheric extinction coefficient (B) (default to 0.142M).</param>
        /// <param name="diffuseRadiationFactor">Diffuse radiation factor (C) (default to 0.058M).</param>
        public FairWeatherConditions(string type = "FAIR_WEATHER_CONDITIONS", decimal? skyCloudCoverFraction = default(decimal?), decimal? groundReflectivity = default(decimal?), DimensionalHeatFlux apparentSolarIrradiation = default(DimensionalHeatFlux), decimal? atmosphericExtinctionCoefficient = default(decimal?), decimal? diffuseRadiationFactor = default(decimal?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for FairWeatherConditions and cannot be null");
            this.SkyCloudCoverFraction = skyCloudCoverFraction;
            this.GroundReflectivity = groundReflectivity;
            this.ApparentSolarIrradiation = apparentSolarIrradiation;
            this.AtmosphericExtinctionCoefficient = atmosphericExtinctionCoefficient;
            this.DiffuseRadiationFactor = diffuseRadiationFactor;
        }
        
        /// <summary>
        /// Schema name: FairWeatherConditions
        /// </summary>
        /// <value>Schema name: FairWeatherConditions</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets SkyCloudCoverFraction
        /// </summary>
        [DataMember(Name="skyCloudCoverFraction", EmitDefaultValue=false)]
        public decimal? SkyCloudCoverFraction { get; set; }

        /// <summary>
        /// Gets or Sets GroundReflectivity
        /// </summary>
        [DataMember(Name="groundReflectivity", EmitDefaultValue=false)]
        public decimal? GroundReflectivity { get; set; }

        /// <summary>
        /// Gets or Sets ApparentSolarIrradiation
        /// </summary>
        [DataMember(Name="apparentSolarIrradiation", EmitDefaultValue=false)]
        public DimensionalHeatFlux ApparentSolarIrradiation { get; set; }

        /// <summary>
        /// Atmospheric extinction coefficient (B)
        /// </summary>
        /// <value>Atmospheric extinction coefficient (B)</value>
        [DataMember(Name="atmosphericExtinctionCoefficient", EmitDefaultValue=false)]
        public decimal? AtmosphericExtinctionCoefficient { get; set; }

        /// <summary>
        /// Diffuse radiation factor (C)
        /// </summary>
        /// <value>Diffuse radiation factor (C)</value>
        [DataMember(Name="diffuseRadiationFactor", EmitDefaultValue=false)]
        public decimal? DiffuseRadiationFactor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FairWeatherConditions {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SkyCloudCoverFraction: ").Append(SkyCloudCoverFraction).Append("\n");
            sb.Append("  GroundReflectivity: ").Append(GroundReflectivity).Append("\n");
            sb.Append("  ApparentSolarIrradiation: ").Append(ApparentSolarIrradiation).Append("\n");
            sb.Append("  AtmosphericExtinctionCoefficient: ").Append(AtmosphericExtinctionCoefficient).Append("\n");
            sb.Append("  DiffuseRadiationFactor: ").Append(DiffuseRadiationFactor).Append("\n");
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
            return this.Equals(input as FairWeatherConditions);
        }

        /// <summary>
        /// Returns true if FairWeatherConditions instances are equal
        /// </summary>
        /// <param name="input">Instance of FairWeatherConditions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FairWeatherConditions input)
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
                    this.SkyCloudCoverFraction == input.SkyCloudCoverFraction ||
                    (this.SkyCloudCoverFraction != null &&
                    this.SkyCloudCoverFraction.Equals(input.SkyCloudCoverFraction))
                ) && 
                (
                    this.GroundReflectivity == input.GroundReflectivity ||
                    (this.GroundReflectivity != null &&
                    this.GroundReflectivity.Equals(input.GroundReflectivity))
                ) && 
                (
                    this.ApparentSolarIrradiation == input.ApparentSolarIrradiation ||
                    (this.ApparentSolarIrradiation != null &&
                    this.ApparentSolarIrradiation.Equals(input.ApparentSolarIrradiation))
                ) && 
                (
                    this.AtmosphericExtinctionCoefficient == input.AtmosphericExtinctionCoefficient ||
                    (this.AtmosphericExtinctionCoefficient != null &&
                    this.AtmosphericExtinctionCoefficient.Equals(input.AtmosphericExtinctionCoefficient))
                ) && 
                (
                    this.DiffuseRadiationFactor == input.DiffuseRadiationFactor ||
                    (this.DiffuseRadiationFactor != null &&
                    this.DiffuseRadiationFactor.Equals(input.DiffuseRadiationFactor))
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
                if (this.SkyCloudCoverFraction != null)
                    hashCode = hashCode * 59 + this.SkyCloudCoverFraction.GetHashCode();
                if (this.GroundReflectivity != null)
                    hashCode = hashCode * 59 + this.GroundReflectivity.GetHashCode();
                if (this.ApparentSolarIrradiation != null)
                    hashCode = hashCode * 59 + this.ApparentSolarIrradiation.GetHashCode();
                if (this.AtmosphericExtinctionCoefficient != null)
                    hashCode = hashCode * 59 + this.AtmosphericExtinctionCoefficient.GetHashCode();
                if (this.DiffuseRadiationFactor != null)
                    hashCode = hashCode * 59 + this.DiffuseRadiationFactor.GetHashCode();
                return hashCode;
            }
        }

    }

}
