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
    /// MomentFieldSelection
    /// </summary>
    [DataContract]
    public partial class MomentFieldSelection : OneOfSumFieldsCalculationResultControlItemFieldSelection, OneOfTemporalResponseResultControlItemFieldSelection, IEquatable<MomentFieldSelection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MomentFieldSelection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MomentFieldSelection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MomentFieldSelection" /> class.
        /// </summary>
        /// <param name="type">Schema name: MomentFieldSelection (required) (default to &quot;MOMENT&quot;).</param>
        /// <param name="momentType">momentType.</param>
        /// <param name="referencePoint">referencePoint.</param>
        public MomentFieldSelection(string type = "MOMENT", OneOfMomentFieldSelectionMomentType momentType = default(OneOfMomentFieldSelectionMomentType), DimensionalVectorLength referencePoint = default(DimensionalVectorLength))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for MomentFieldSelection and cannot be null");
            this.MomentType = momentType;
            this.ReferencePoint = referencePoint;
        }
        
        /// <summary>
        /// Schema name: MomentFieldSelection
        /// </summary>
        /// <value>Schema name: MomentFieldSelection</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets MomentType
        /// </summary>
        [DataMember(Name="momentType", EmitDefaultValue=false)]
        public OneOfMomentFieldSelectionMomentType MomentType { get; set; }

        /// <summary>
        /// Gets or Sets ReferencePoint
        /// </summary>
        [DataMember(Name="referencePoint", EmitDefaultValue=false)]
        public DimensionalVectorLength ReferencePoint { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MomentFieldSelection {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MomentType: ").Append(MomentType).Append("\n");
            sb.Append("  ReferencePoint: ").Append(ReferencePoint).Append("\n");
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
            return this.Equals(input as MomentFieldSelection);
        }

        /// <summary>
        /// Returns true if MomentFieldSelection instances are equal
        /// </summary>
        /// <param name="input">Instance of MomentFieldSelection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MomentFieldSelection input)
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
                    this.MomentType == input.MomentType ||
                    (this.MomentType != null &&
                    this.MomentType.Equals(input.MomentType))
                ) && 
                (
                    this.ReferencePoint == input.ReferencePoint ||
                    (this.ReferencePoint != null &&
                    this.ReferencePoint.Equals(input.ReferencePoint))
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
                if (this.MomentType != null)
                    hashCode = hashCode * 59 + this.MomentType.GetHashCode();
                if (this.ReferencePoint != null)
                    hashCode = hashCode * 59 + this.ReferencePoint.GetHashCode();
                return hashCode;
            }
        }

    }

}