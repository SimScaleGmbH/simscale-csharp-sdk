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
    /// ChronosPreconditioner
    /// </summary>
    [DataContract]
    public partial class ChronosPreconditioner : OneOfPETSCSolverPreconditioner, IEquatable<ChronosPreconditioner>
    {
        /// <summary>
        /// Defines Smoother
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SmootherEnum
        {
            /// <summary>
            /// Enum JACOBI for value: JACOBI
            /// </summary>
            [EnumMember(Value = "JACOBI")]
            JACOBI = 1,

            /// <summary>
            /// Enum FSAILIGHT for value: FSAI_LIGHT
            /// </summary>
            [EnumMember(Value = "FSAI_LIGHT")]
            FSAILIGHT = 2,

            /// <summary>
            /// Enum FSAIMEDIUM for value: FSAI_MEDIUM
            /// </summary>
            [EnumMember(Value = "FSAI_MEDIUM")]
            FSAIMEDIUM = 3,

            /// <summary>
            /// Enum FSAIHEAVY for value: FSAI_HEAVY
            /// </summary>
            [EnumMember(Value = "FSAI_HEAVY")]
            FSAIHEAVY = 4

        }

        /// <summary>
        /// Gets or Sets Smoother
        /// </summary>
        [DataMember(Name="smoother", EmitDefaultValue=false)]
        public SmootherEnum? Smoother { get; set; }
        /// <summary>
        /// Defines Prolongation
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProlongationEnum
        {
            /// <summary>
            /// Enum UNSMOOTHED for value: UNSMOOTHED
            /// </summary>
            [EnumMember(Value = "UNSMOOTHED")]
            UNSMOOTHED = 1,

            /// <summary>
            /// Enum SMOOTHED for value: SMOOTHED
            /// </summary>
            [EnumMember(Value = "SMOOTHED")]
            SMOOTHED = 2,

            /// <summary>
            /// Enum ENERGYMINIMIZATION for value: ENERGY_MINIMIZATION
            /// </summary>
            [EnumMember(Value = "ENERGY_MINIMIZATION")]
            ENERGYMINIMIZATION = 3

        }

        /// <summary>
        /// Gets or Sets Prolongation
        /// </summary>
        [DataMember(Name="prolongation", EmitDefaultValue=false)]
        public ProlongationEnum? Prolongation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChronosPreconditioner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChronosPreconditioner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChronosPreconditioner" /> class.
        /// </summary>
        /// <param name="type">Schema name: ChronosPreconditioner (required) (default to &quot;CHRONOS&quot;).</param>
        /// <param name="iterationsSRQCG">iterationsSRQCG (default to 0).</param>
        /// <param name="smoother">smoother (default to SmootherEnum.FSAIMEDIUM).</param>
        /// <param name="prolongation">prolongation (default to ProlongationEnum.ENERGYMINIMIZATION).</param>
        /// <param name="recycling">recycling (default to 0M).</param>
        /// <param name="improveTestSpace">improveTestSpace (default to false).</param>
        /// <param name="testSpaceIterations">testSpaceIterations (default to 20).</param>
        public ChronosPreconditioner(string type = "CHRONOS", int? iterationsSRQCG = default(int?), SmootherEnum? smoother = default(SmootherEnum?), ProlongationEnum? prolongation = default(ProlongationEnum?), decimal? recycling = default(decimal?), bool? improveTestSpace = default(bool?), int? testSpaceIterations = default(int?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for ChronosPreconditioner and cannot be null");
            this.IterationsSRQCG = iterationsSRQCG;
            this.Smoother = smoother;
            this.Prolongation = prolongation;
            this.Recycling = recycling;
            this.ImproveTestSpace = improveTestSpace;
            this.TestSpaceIterations = testSpaceIterations;
        }
        
        /// <summary>
        /// Schema name: ChronosPreconditioner
        /// </summary>
        /// <value>Schema name: ChronosPreconditioner</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets IterationsSRQCG
        /// </summary>
        [DataMember(Name="iterationsSRQCG", EmitDefaultValue=false)]
        public int? IterationsSRQCG { get; set; }

        /// <summary>
        /// Gets or Sets Recycling
        /// </summary>
        [DataMember(Name="recycling", EmitDefaultValue=false)]
        public decimal? Recycling { get; set; }

        /// <summary>
        /// Gets or Sets ImproveTestSpace
        /// </summary>
        [DataMember(Name="improveTestSpace", EmitDefaultValue=false)]
        public bool? ImproveTestSpace { get; set; }

        /// <summary>
        /// Gets or Sets TestSpaceIterations
        /// </summary>
        [DataMember(Name="testSpaceIterations", EmitDefaultValue=false)]
        public int? TestSpaceIterations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChronosPreconditioner {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IterationsSRQCG: ").Append(IterationsSRQCG).Append("\n");
            sb.Append("  Smoother: ").Append(Smoother).Append("\n");
            sb.Append("  Prolongation: ").Append(Prolongation).Append("\n");
            sb.Append("  Recycling: ").Append(Recycling).Append("\n");
            sb.Append("  ImproveTestSpace: ").Append(ImproveTestSpace).Append("\n");
            sb.Append("  TestSpaceIterations: ").Append(TestSpaceIterations).Append("\n");
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
            return this.Equals(input as ChronosPreconditioner);
        }

        /// <summary>
        /// Returns true if ChronosPreconditioner instances are equal
        /// </summary>
        /// <param name="input">Instance of ChronosPreconditioner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChronosPreconditioner input)
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
                    this.IterationsSRQCG == input.IterationsSRQCG ||
                    (this.IterationsSRQCG != null &&
                    this.IterationsSRQCG.Equals(input.IterationsSRQCG))
                ) && 
                (
                    this.Smoother == input.Smoother ||
                    this.Smoother.Equals(input.Smoother)
                ) && 
                (
                    this.Prolongation == input.Prolongation ||
                    this.Prolongation.Equals(input.Prolongation)
                ) && 
                (
                    this.Recycling == input.Recycling ||
                    (this.Recycling != null &&
                    this.Recycling.Equals(input.Recycling))
                ) && 
                (
                    this.ImproveTestSpace == input.ImproveTestSpace ||
                    (this.ImproveTestSpace != null &&
                    this.ImproveTestSpace.Equals(input.ImproveTestSpace))
                ) && 
                (
                    this.TestSpaceIterations == input.TestSpaceIterations ||
                    (this.TestSpaceIterations != null &&
                    this.TestSpaceIterations.Equals(input.TestSpaceIterations))
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
                if (this.IterationsSRQCG != null)
                    hashCode = hashCode * 59 + this.IterationsSRQCG.GetHashCode();
                hashCode = hashCode * 59 + this.Smoother.GetHashCode();
                hashCode = hashCode * 59 + this.Prolongation.GetHashCode();
                if (this.Recycling != null)
                    hashCode = hashCode * 59 + this.Recycling.GetHashCode();
                if (this.ImproveTestSpace != null)
                    hashCode = hashCode * 59 + this.ImproveTestSpace.GetHashCode();
                if (this.TestSpaceIterations != null)
                    hashCode = hashCode * 59 + this.TestSpaceIterations.GetHashCode();
                return hashCode;
            }
        }

    }

}
