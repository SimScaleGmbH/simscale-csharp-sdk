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
    /// AdvectiveVBC
    /// </summary>
    [DataContract]
    public partial class AdvectiveVBC : OneOfCustomFluidBCVelocity, IEquatable<AdvectiveVBC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvectiveVBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdvectiveVBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvectiveVBC" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;ADVECTIVE&quot;).</param>
        /// <param name="relaxBoundary">relaxBoundary (default to false).</param>
        /// <param name="farFieldValue">farFieldValue.</param>
        /// <param name="relaxationLengthScale">relaxationLengthScale.</param>
        public AdvectiveVBC(string type = "ADVECTIVE", bool? relaxBoundary = default(bool?), DimensionalVectorSpeed farFieldValue = default(DimensionalVectorSpeed), DimensionalLength relaxationLengthScale = default(DimensionalLength))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for AdvectiveVBC and cannot be null");
            this.RelaxBoundary = relaxBoundary;
            this.FarFieldValue = farFieldValue;
            this.RelaxationLengthScale = relaxationLengthScale;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets RelaxBoundary
        /// </summary>
        [DataMember(Name="relaxBoundary", EmitDefaultValue=false)]
        public bool? RelaxBoundary { get; set; }

        /// <summary>
        /// Gets or Sets FarFieldValue
        /// </summary>
        [DataMember(Name="farFieldValue", EmitDefaultValue=false)]
        public DimensionalVectorSpeed FarFieldValue { get; set; }

        /// <summary>
        /// Gets or Sets RelaxationLengthScale
        /// </summary>
        [DataMember(Name="relaxationLengthScale", EmitDefaultValue=false)]
        public DimensionalLength RelaxationLengthScale { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdvectiveVBC {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  RelaxBoundary: ").Append(RelaxBoundary).Append("\n");
            sb.Append("  FarFieldValue: ").Append(FarFieldValue).Append("\n");
            sb.Append("  RelaxationLengthScale: ").Append(RelaxationLengthScale).Append("\n");
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
            return this.Equals(input as AdvectiveVBC);
        }

        /// <summary>
        /// Returns true if AdvectiveVBC instances are equal
        /// </summary>
        /// <param name="input">Instance of AdvectiveVBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdvectiveVBC input)
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
                    this.RelaxBoundary == input.RelaxBoundary ||
                    (this.RelaxBoundary != null &&
                    this.RelaxBoundary.Equals(input.RelaxBoundary))
                ) && 
                (
                    this.FarFieldValue == input.FarFieldValue ||
                    (this.FarFieldValue != null &&
                    this.FarFieldValue.Equals(input.FarFieldValue))
                ) && 
                (
                    this.RelaxationLengthScale == input.RelaxationLengthScale ||
                    (this.RelaxationLengthScale != null &&
                    this.RelaxationLengthScale.Equals(input.RelaxationLengthScale))
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
                if (this.RelaxBoundary != null)
                    hashCode = hashCode * 59 + this.RelaxBoundary.GetHashCode();
                if (this.FarFieldValue != null)
                    hashCode = hashCode * 59 + this.FarFieldValue.GetHashCode();
                if (this.RelaxationLengthScale != null)
                    hashCode = hashCode * 59 + this.RelaxationLengthScale.GetHashCode();
                return hashCode;
            }
        }

    }

}