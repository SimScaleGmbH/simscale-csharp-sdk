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
    /// &lt;p&gt;Select how the time increments should be computed in case of an adaptation event. Currently four types are available (which may not all be available for every event):&lt;/p&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Manual&lt;/b&gt;: Here the user defines fixed time step subdivision and augmentation settings.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Newton Iterations Target&lt;/b&gt;: With this setting the user defines a target value for the Newton Iterations and the time increments are calculated automatically to having this value as objective.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Field Change Target&lt;/b&gt;: With this setting the user defines a target value for change of a specific field component within a time increment and the time increments are calculated automatically to having this value as objective.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;Mixed&lt;/b&gt;: The mixed type uses a fixed subdivision and an automatic adaptation of the time step with a target value for the change of the selected field component.&lt;/p&gt;&lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class ManualTimestepCalculationType : OneOfCollisionRetimingEventTimestepCalculationType, OneOfErrorRetimingEventTimestepCalculationType, OneOfNonMonotomousResidualRetimingEventTimestepCalculationType, IEquatable<ManualTimestepCalculationType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManualTimestepCalculationType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ManualTimestepCalculationType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ManualTimestepCalculationType" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;MANUAL&quot;).</param>
        /// <param name="additionalNewtonIterations">&lt;p&gt;Define the percentage of additional Newton Iterations that should be allowed to be used if convergence is not reached after the maximum number of Newton Iterations is reached.&lt;/p&gt; (default to 20M).</param>
        /// <param name="fixedSubdivision">fixedSubdivision.</param>
        /// <param name="fixedAugmentation">fixedAugmentation.</param>
        public ManualTimestepCalculationType(string type = "MANUAL", decimal? additionalNewtonIterations = default(decimal?), FixedSubdivision fixedSubdivision = default(FixedSubdivision), FixedAugmentation fixedAugmentation = default(FixedAugmentation))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for ManualTimestepCalculationType and cannot be null");
            this.AdditionalNewtonIterations = additionalNewtonIterations;
            this.FixedSubdivision = fixedSubdivision;
            this.FixedAugmentation = fixedAugmentation;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// &lt;p&gt;Define the percentage of additional Newton Iterations that should be allowed to be used if convergence is not reached after the maximum number of Newton Iterations is reached.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Define the percentage of additional Newton Iterations that should be allowed to be used if convergence is not reached after the maximum number of Newton Iterations is reached.&lt;/p&gt;</value>
        [DataMember(Name="additionalNewtonIterations", EmitDefaultValue=false)]
        public decimal? AdditionalNewtonIterations { get; set; }

        /// <summary>
        /// Gets or Sets FixedSubdivision
        /// </summary>
        [DataMember(Name="fixedSubdivision", EmitDefaultValue=false)]
        public FixedSubdivision FixedSubdivision { get; set; }

        /// <summary>
        /// Gets or Sets FixedAugmentation
        /// </summary>
        [DataMember(Name="fixedAugmentation", EmitDefaultValue=false)]
        public FixedAugmentation FixedAugmentation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManualTimestepCalculationType {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AdditionalNewtonIterations: ").Append(AdditionalNewtonIterations).Append("\n");
            sb.Append("  FixedSubdivision: ").Append(FixedSubdivision).Append("\n");
            sb.Append("  FixedAugmentation: ").Append(FixedAugmentation).Append("\n");
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
            return this.Equals(input as ManualTimestepCalculationType);
        }

        /// <summary>
        /// Returns true if ManualTimestepCalculationType instances are equal
        /// </summary>
        /// <param name="input">Instance of ManualTimestepCalculationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManualTimestepCalculationType input)
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
                    this.AdditionalNewtonIterations == input.AdditionalNewtonIterations ||
                    (this.AdditionalNewtonIterations != null &&
                    this.AdditionalNewtonIterations.Equals(input.AdditionalNewtonIterations))
                ) && 
                (
                    this.FixedSubdivision == input.FixedSubdivision ||
                    (this.FixedSubdivision != null &&
                    this.FixedSubdivision.Equals(input.FixedSubdivision))
                ) && 
                (
                    this.FixedAugmentation == input.FixedAugmentation ||
                    (this.FixedAugmentation != null &&
                    this.FixedAugmentation.Equals(input.FixedAugmentation))
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
                if (this.AdditionalNewtonIterations != null)
                    hashCode = hashCode * 59 + this.AdditionalNewtonIterations.GetHashCode();
                if (this.FixedSubdivision != null)
                    hashCode = hashCode * 59 + this.FixedSubdivision.GetHashCode();
                if (this.FixedAugmentation != null)
                    hashCode = hashCode * 59 + this.FixedAugmentation.GetHashCode();
                return hashCode;
            }
        }

    }

}