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
    /// HarmonicResponseResultControlItem
    /// </summary>
    [DataContract]
    public partial class HarmonicResponseResultControlItem : OneOfSolidResultControlPointData, IEquatable<HarmonicResponseResultControlItem>
    {
        /// <summary>
        /// Defines ComplexNumber
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ComplexNumberEnum
        {
            /// <summary>
            /// Enum REALANDIMAGINARY for value: REAL_AND_IMAGINARY
            /// </summary>
            [EnumMember(Value = "REAL_AND_IMAGINARY")]
            REALANDIMAGINARY = 1,

            /// <summary>
            /// Enum MAGNITUDEANDPHASE for value: MAGNITUDE_AND_PHASE
            /// </summary>
            [EnumMember(Value = "MAGNITUDE_AND_PHASE")]
            MAGNITUDEANDPHASE = 2

        }

        /// <summary>
        /// Gets or Sets ComplexNumber
        /// </summary>
        [DataMember(Name="complexNumber", EmitDefaultValue=false)]
        public ComplexNumberEnum? ComplexNumber { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HarmonicResponseResultControlItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HarmonicResponseResultControlItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HarmonicResponseResultControlItem" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;HARMONIC_RESPONSE&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="fieldSelection">fieldSelection.</param>
        /// <param name="complexNumber">complexNumber (default to ComplexNumberEnum.REALANDIMAGINARY).</param>
        /// <param name="geometryPrimitiveUuids">geometryPrimitiveUuids.</param>
        public HarmonicResponseResultControlItem(string type = "HARMONIC_RESPONSE", string name = default(string), OneOfHarmonicResponseResultControlItemFieldSelection fieldSelection = default(OneOfHarmonicResponseResultControlItemFieldSelection), ComplexNumberEnum? complexNumber = default(ComplexNumberEnum?), List<Guid?> geometryPrimitiveUuids = default(List<Guid?>))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for HarmonicResponseResultControlItem and cannot be null");
            this.Name = name;
            this.FieldSelection = fieldSelection;
            this.ComplexNumber = complexNumber;
            this.GeometryPrimitiveUuids = geometryPrimitiveUuids;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets FieldSelection
        /// </summary>
        [DataMember(Name="fieldSelection", EmitDefaultValue=false)]
        public OneOfHarmonicResponseResultControlItemFieldSelection FieldSelection { get; set; }

        /// <summary>
        /// Gets or Sets GeometryPrimitiveUuids
        /// </summary>
        [DataMember(Name="geometryPrimitiveUuids", EmitDefaultValue=false)]
        public List<Guid?> GeometryPrimitiveUuids { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HarmonicResponseResultControlItem {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FieldSelection: ").Append(FieldSelection).Append("\n");
            sb.Append("  ComplexNumber: ").Append(ComplexNumber).Append("\n");
            sb.Append("  GeometryPrimitiveUuids: ").Append(GeometryPrimitiveUuids).Append("\n");
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
            return this.Equals(input as HarmonicResponseResultControlItem);
        }

        /// <summary>
        /// Returns true if HarmonicResponseResultControlItem instances are equal
        /// </summary>
        /// <param name="input">Instance of HarmonicResponseResultControlItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HarmonicResponseResultControlItem input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.FieldSelection == input.FieldSelection ||
                    (this.FieldSelection != null &&
                    this.FieldSelection.Equals(input.FieldSelection))
                ) && 
                (
                    this.ComplexNumber == input.ComplexNumber ||
                    this.ComplexNumber.Equals(input.ComplexNumber)
                ) && 
                (
                    this.GeometryPrimitiveUuids == input.GeometryPrimitiveUuids ||
                    this.GeometryPrimitiveUuids != null &&
                    input.GeometryPrimitiveUuids != null &&
                    this.GeometryPrimitiveUuids.SequenceEqual(input.GeometryPrimitiveUuids)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.FieldSelection != null)
                    hashCode = hashCode * 59 + this.FieldSelection.GetHashCode();
                hashCode = hashCode * 59 + this.ComplexNumber.GetHashCode();
                if (this.GeometryPrimitiveUuids != null)
                    hashCode = hashCode * 59 + this.GeometryPrimitiveUuids.GetHashCode();
                return hashCode;
            }
        }

    }

}