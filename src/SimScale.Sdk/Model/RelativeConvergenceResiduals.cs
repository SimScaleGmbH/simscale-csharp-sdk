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
    /// RelativeConvergenceResiduals
    /// </summary>
    [DataContract]
    public partial class RelativeConvergenceResiduals : OneOfResidualsConvergenceMethodConvergenceCriteria, IEquatable<RelativeConvergenceResiduals>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelativeConvergenceResiduals" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RelativeConvergenceResiduals() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RelativeConvergenceResiduals" /> class.
        /// </summary>
        /// <param name="type">Schema name: RelativeConvergenceResiduals (required) (default to &quot;RELATIVE&quot;).</param>
        /// <param name="relativeForceTolerance">relativeForceTolerance (default to 0.05M).</param>
        /// <param name="relativeMomentTolerance">relativeMomentTolerance (default to 0M).</param>
        public RelativeConvergenceResiduals(string type = "RELATIVE", decimal? relativeForceTolerance = default(decimal?), decimal? relativeMomentTolerance = default(decimal?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for RelativeConvergenceResiduals and cannot be null");
            this.RelativeForceTolerance = relativeForceTolerance;
            this.RelativeMomentTolerance = relativeMomentTolerance;
        }
        
        /// <summary>
        /// Schema name: RelativeConvergenceResiduals
        /// </summary>
        /// <value>Schema name: RelativeConvergenceResiduals</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets RelativeForceTolerance
        /// </summary>
        [DataMember(Name="relativeForceTolerance", EmitDefaultValue=false)]
        public decimal? RelativeForceTolerance { get; set; }

        /// <summary>
        /// Gets or Sets RelativeMomentTolerance
        /// </summary>
        [DataMember(Name="relativeMomentTolerance", EmitDefaultValue=false)]
        public decimal? RelativeMomentTolerance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelativeConvergenceResiduals {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  RelativeForceTolerance: ").Append(RelativeForceTolerance).Append("\n");
            sb.Append("  RelativeMomentTolerance: ").Append(RelativeMomentTolerance).Append("\n");
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
            return this.Equals(input as RelativeConvergenceResiduals);
        }

        /// <summary>
        /// Returns true if RelativeConvergenceResiduals instances are equal
        /// </summary>
        /// <param name="input">Instance of RelativeConvergenceResiduals to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelativeConvergenceResiduals input)
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
                    this.RelativeMomentTolerance == input.RelativeMomentTolerance ||
                    (this.RelativeMomentTolerance != null &&
                    this.RelativeMomentTolerance.Equals(input.RelativeMomentTolerance))
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
                if (this.RelativeMomentTolerance != null)
                    hashCode = hashCode * 59 + this.RelativeMomentTolerance.GetHashCode();
                return hashCode;
            }
        }

    }

}
