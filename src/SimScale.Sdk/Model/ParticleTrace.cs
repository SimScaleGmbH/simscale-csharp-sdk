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
    /// ParticleTrace
    /// </summary>
    [DataContract]
    public partial class ParticleTrace : IEquatable<ParticleTrace>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParticleTrace" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ParticleTrace() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ParticleTrace" /> class.
        /// </summary>
        /// <param name="seedSettings">seedSettings (required).</param>
        /// <param name="visualizationStyle">visualizationStyle (required).</param>
        /// <param name="traceBothDirections">If set to true, the trace will be computed both forwards and backwards from the seed points. (required) (default to true).</param>
        /// <param name="scalarField">scalarField.</param>
        /// <param name="solidColor">solidColor.</param>
        public ParticleTrace(SeedSettings seedSettings = default(SeedSettings), OneOfVisualizationStyle visualizationStyle = default(OneOfVisualizationStyle), bool? traceBothDirections = true, ScalarField scalarField = default(ScalarField), Color solidColor = default(Color))
        {
            // to ensure "seedSettings" is required (not null)
            this.SeedSettings = seedSettings ?? throw new ArgumentNullException("seedSettings is a required property for ParticleTrace and cannot be null");
            // to ensure "visualizationStyle" is required (not null)
            this.VisualizationStyle = visualizationStyle ?? throw new ArgumentNullException("visualizationStyle is a required property for ParticleTrace and cannot be null");
            // to ensure "traceBothDirections" is required (not null)
            this.TraceBothDirections = traceBothDirections ?? throw new ArgumentNullException("traceBothDirections is a required property for ParticleTrace and cannot be null");
            this.ScalarField = scalarField;
            this.SolidColor = solidColor;
        }
        
        /// <summary>
        /// Gets or Sets SeedSettings
        /// </summary>
        [DataMember(Name="seedSettings", EmitDefaultValue=false)]
        public SeedSettings SeedSettings { get; set; }

        /// <summary>
        /// Gets or Sets VisualizationStyle
        /// </summary>
        [DataMember(Name="visualizationStyle", EmitDefaultValue=false)]
        public OneOfVisualizationStyle VisualizationStyle { get; set; }

        /// <summary>
        /// If set to true, the trace will be computed both forwards and backwards from the seed points.
        /// </summary>
        /// <value>If set to true, the trace will be computed both forwards and backwards from the seed points.</value>
        [DataMember(Name="traceBothDirections", EmitDefaultValue=false)]
        public bool? TraceBothDirections { get; set; }

        /// <summary>
        /// Gets or Sets ScalarField
        /// </summary>
        [DataMember(Name="scalarField", EmitDefaultValue=false)]
        public ScalarField ScalarField { get; set; }

        /// <summary>
        /// Gets or Sets SolidColor
        /// </summary>
        [DataMember(Name="solidColor", EmitDefaultValue=false)]
        public Color SolidColor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParticleTrace {\n");
            sb.Append("  SeedSettings: ").Append(SeedSettings).Append("\n");
            sb.Append("  VisualizationStyle: ").Append(VisualizationStyle).Append("\n");
            sb.Append("  TraceBothDirections: ").Append(TraceBothDirections).Append("\n");
            sb.Append("  ScalarField: ").Append(ScalarField).Append("\n");
            sb.Append("  SolidColor: ").Append(SolidColor).Append("\n");
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
            return this.Equals(input as ParticleTrace);
        }

        /// <summary>
        /// Returns true if ParticleTrace instances are equal
        /// </summary>
        /// <param name="input">Instance of ParticleTrace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParticleTrace input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SeedSettings == input.SeedSettings ||
                    (this.SeedSettings != null &&
                    this.SeedSettings.Equals(input.SeedSettings))
                ) && 
                (
                    this.VisualizationStyle == input.VisualizationStyle ||
                    (this.VisualizationStyle != null &&
                    this.VisualizationStyle.Equals(input.VisualizationStyle))
                ) && 
                (
                    this.TraceBothDirections == input.TraceBothDirections ||
                    (this.TraceBothDirections != null &&
                    this.TraceBothDirections.Equals(input.TraceBothDirections))
                ) && 
                (
                    this.ScalarField == input.ScalarField ||
                    (this.ScalarField != null &&
                    this.ScalarField.Equals(input.ScalarField))
                ) && 
                (
                    this.SolidColor == input.SolidColor ||
                    (this.SolidColor != null &&
                    this.SolidColor.Equals(input.SolidColor))
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
                if (this.SeedSettings != null)
                    hashCode = hashCode * 59 + this.SeedSettings.GetHashCode();
                if (this.VisualizationStyle != null)
                    hashCode = hashCode * 59 + this.VisualizationStyle.GetHashCode();
                if (this.TraceBothDirections != null)
                    hashCode = hashCode * 59 + this.TraceBothDirections.GetHashCode();
                if (this.ScalarField != null)
                    hashCode = hashCode * 59 + this.ScalarField.GetHashCode();
                if (this.SolidColor != null)
                    hashCode = hashCode * 59 + this.SolidColor.GetHashCode();
                return hashCode;
            }
        }

    }

}
