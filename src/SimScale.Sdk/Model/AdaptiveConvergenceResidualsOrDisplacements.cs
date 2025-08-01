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
    /// AdaptiveConvergenceResidualsOrDisplacements
    /// </summary>
    [DataContract]
    public partial class AdaptiveConvergenceResidualsOrDisplacements : OneOfResidualsOrDisplacementsConvergenceMethodConvergenceCriteria, IEquatable<AdaptiveConvergenceResidualsOrDisplacements>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdaptiveConvergenceResidualsOrDisplacements" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdaptiveConvergenceResidualsOrDisplacements() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdaptiveConvergenceResidualsOrDisplacements" /> class.
        /// </summary>
        /// <param name="type">Schema name: AdaptiveConvergenceResidualsOrDisplacements (required) (default to &quot;ADAPTIVE&quot;).</param>
        /// <param name="relativeForceTolerance">relativeForceTolerance (default to 0.05M).</param>
        /// <param name="maxResidualForce">maxResidualForce.</param>
        /// <param name="relativeMomentTolerance">relativeMomentTolerance (default to 0M).</param>
        /// <param name="maxResidualMoment">maxResidualMoment.</param>
        /// <param name="relativeDisplacementTolerance">relativeDisplacementTolerance (default to 0.1M).</param>
        /// <param name="maxDisplacementIncrement">maxDisplacementIncrement.</param>
        /// <param name="relativeRotationTolerance">relativeRotationTolerance (default to 0M).</param>
        /// <param name="maxRotationIncrement">maxRotationIncrement.</param>
        public AdaptiveConvergenceResidualsOrDisplacements(string type = "ADAPTIVE", decimal? relativeForceTolerance = default(decimal?), DimensionalForce maxResidualForce = default(DimensionalForce), decimal? relativeMomentTolerance = default(decimal?), DimensionalTorque maxResidualMoment = default(DimensionalTorque), decimal? relativeDisplacementTolerance = default(decimal?), DimensionalLength maxDisplacementIncrement = default(DimensionalLength), decimal? relativeRotationTolerance = default(decimal?), DimensionalAngle maxRotationIncrement = default(DimensionalAngle))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for AdaptiveConvergenceResidualsOrDisplacements and cannot be null");
            this.RelativeForceTolerance = relativeForceTolerance;
            this.MaxResidualForce = maxResidualForce;
            this.RelativeMomentTolerance = relativeMomentTolerance;
            this.MaxResidualMoment = maxResidualMoment;
            this.RelativeDisplacementTolerance = relativeDisplacementTolerance;
            this.MaxDisplacementIncrement = maxDisplacementIncrement;
            this.RelativeRotationTolerance = relativeRotationTolerance;
            this.MaxRotationIncrement = maxRotationIncrement;
        }
        
        /// <summary>
        /// Schema name: AdaptiveConvergenceResidualsOrDisplacements
        /// </summary>
        /// <value>Schema name: AdaptiveConvergenceResidualsOrDisplacements</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets RelativeForceTolerance
        /// </summary>
        [DataMember(Name="relativeForceTolerance", EmitDefaultValue=false)]
        public decimal? RelativeForceTolerance { get; set; }

        /// <summary>
        /// Gets or Sets MaxResidualForce
        /// </summary>
        [DataMember(Name="maxResidualForce", EmitDefaultValue=false)]
        public DimensionalForce MaxResidualForce { get; set; }

        /// <summary>
        /// Gets or Sets RelativeMomentTolerance
        /// </summary>
        [DataMember(Name="relativeMomentTolerance", EmitDefaultValue=false)]
        public decimal? RelativeMomentTolerance { get; set; }

        /// <summary>
        /// Gets or Sets MaxResidualMoment
        /// </summary>
        [DataMember(Name="maxResidualMoment", EmitDefaultValue=false)]
        public DimensionalTorque MaxResidualMoment { get; set; }

        /// <summary>
        /// Gets or Sets RelativeDisplacementTolerance
        /// </summary>
        [DataMember(Name="relativeDisplacementTolerance", EmitDefaultValue=false)]
        public decimal? RelativeDisplacementTolerance { get; set; }

        /// <summary>
        /// Gets or Sets MaxDisplacementIncrement
        /// </summary>
        [DataMember(Name="maxDisplacementIncrement", EmitDefaultValue=false)]
        public DimensionalLength MaxDisplacementIncrement { get; set; }

        /// <summary>
        /// Gets or Sets RelativeRotationTolerance
        /// </summary>
        [DataMember(Name="relativeRotationTolerance", EmitDefaultValue=false)]
        public decimal? RelativeRotationTolerance { get; set; }

        /// <summary>
        /// Gets or Sets MaxRotationIncrement
        /// </summary>
        [DataMember(Name="maxRotationIncrement", EmitDefaultValue=false)]
        public DimensionalAngle MaxRotationIncrement { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdaptiveConvergenceResidualsOrDisplacements {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  RelativeForceTolerance: ").Append(RelativeForceTolerance).Append("\n");
            sb.Append("  MaxResidualForce: ").Append(MaxResidualForce).Append("\n");
            sb.Append("  RelativeMomentTolerance: ").Append(RelativeMomentTolerance).Append("\n");
            sb.Append("  MaxResidualMoment: ").Append(MaxResidualMoment).Append("\n");
            sb.Append("  RelativeDisplacementTolerance: ").Append(RelativeDisplacementTolerance).Append("\n");
            sb.Append("  MaxDisplacementIncrement: ").Append(MaxDisplacementIncrement).Append("\n");
            sb.Append("  RelativeRotationTolerance: ").Append(RelativeRotationTolerance).Append("\n");
            sb.Append("  MaxRotationIncrement: ").Append(MaxRotationIncrement).Append("\n");
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
            return this.Equals(input as AdaptiveConvergenceResidualsOrDisplacements);
        }

        /// <summary>
        /// Returns true if AdaptiveConvergenceResidualsOrDisplacements instances are equal
        /// </summary>
        /// <param name="input">Instance of AdaptiveConvergenceResidualsOrDisplacements to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdaptiveConvergenceResidualsOrDisplacements input)
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
                    this.RelativeForceTolerance == input.RelativeForceTolerance ||
                    (this.RelativeForceTolerance != null &&
                    this.RelativeForceTolerance.Equals(input.RelativeForceTolerance))
                ) && 
                (
                    this.MaxResidualForce == input.MaxResidualForce ||
                    (this.MaxResidualForce != null &&
                    this.MaxResidualForce.Equals(input.MaxResidualForce))
                ) && 
                (
                    this.RelativeMomentTolerance == input.RelativeMomentTolerance ||
                    (this.RelativeMomentTolerance != null &&
                    this.RelativeMomentTolerance.Equals(input.RelativeMomentTolerance))
                ) && 
                (
                    this.MaxResidualMoment == input.MaxResidualMoment ||
                    (this.MaxResidualMoment != null &&
                    this.MaxResidualMoment.Equals(input.MaxResidualMoment))
                ) && 
                (
                    this.RelativeDisplacementTolerance == input.RelativeDisplacementTolerance ||
                    (this.RelativeDisplacementTolerance != null &&
                    this.RelativeDisplacementTolerance.Equals(input.RelativeDisplacementTolerance))
                ) && 
                (
                    this.MaxDisplacementIncrement == input.MaxDisplacementIncrement ||
                    (this.MaxDisplacementIncrement != null &&
                    this.MaxDisplacementIncrement.Equals(input.MaxDisplacementIncrement))
                ) && 
                (
                    this.RelativeRotationTolerance == input.RelativeRotationTolerance ||
                    (this.RelativeRotationTolerance != null &&
                    this.RelativeRotationTolerance.Equals(input.RelativeRotationTolerance))
                ) && 
                (
                    this.MaxRotationIncrement == input.MaxRotationIncrement ||
                    (this.MaxRotationIncrement != null &&
                    this.MaxRotationIncrement.Equals(input.MaxRotationIncrement))
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
                if (this.RelativeForceTolerance != null)
                    hashCode = hashCode * 59 + this.RelativeForceTolerance.GetHashCode();
                if (this.MaxResidualForce != null)
                    hashCode = hashCode * 59 + this.MaxResidualForce.GetHashCode();
                if (this.RelativeMomentTolerance != null)
                    hashCode = hashCode * 59 + this.RelativeMomentTolerance.GetHashCode();
                if (this.MaxResidualMoment != null)
                    hashCode = hashCode * 59 + this.MaxResidualMoment.GetHashCode();
                if (this.RelativeDisplacementTolerance != null)
                    hashCode = hashCode * 59 + this.RelativeDisplacementTolerance.GetHashCode();
                if (this.MaxDisplacementIncrement != null)
                    hashCode = hashCode * 59 + this.MaxDisplacementIncrement.GetHashCode();
                if (this.RelativeRotationTolerance != null)
                    hashCode = hashCode * 59 + this.RelativeRotationTolerance.GetHashCode();
                if (this.MaxRotationIncrement != null)
                    hashCode = hashCode * 59 + this.MaxRotationIncrement.GetHashCode();
                return hashCode;
            }
        }

    }

}
