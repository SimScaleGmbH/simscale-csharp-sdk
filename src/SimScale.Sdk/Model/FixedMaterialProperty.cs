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
    /// A material property that has a fixed (constant) value.
    /// </summary>
    [DataContract]
    public partial class FixedMaterialProperty : OneOfMaterialProperty, IEquatable<FixedMaterialProperty>
    {
        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [DataMember(Name="dataType", EmitDefaultValue=false)]
        public PropertyDataType? DataType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedMaterialProperty" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FixedMaterialProperty() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedMaterialProperty" /> class.
        /// </summary>
        /// <param name="name">The material property name.</param>
        /// <param name="label">The material property label to support internationalization. The content of this field is a i18n key. If this field is not present, the name field can be used as a fallback for English language..</param>
        /// <param name="unit">The material property unit.</param>
        /// <param name="valueType">valueType (required) (default to &quot;fixed&quot;).</param>
        /// <param name="dataType">dataType.</param>
        /// <param name="value">The property value (required).</param>
        public FixedMaterialProperty(string name = default(string), string label = default(string), string unit = default(string), string valueType = "fixed", PropertyDataType? dataType = default(PropertyDataType?), Object value = default(Object))
        {
            // to ensure "valueType" is required (not null)
            this.ValueType = valueType ?? throw new ArgumentNullException("valueType is a required property for FixedMaterialProperty and cannot be null");
            // to ensure "value" is required (not null)
            this.Value = value ?? throw new ArgumentNullException("value is a required property for FixedMaterialProperty and cannot be null");
            this.Name = name;
            this.Label = label;
            this.Unit = unit;
            this.DataType = dataType;
        }
        
        /// <summary>
        /// The material property name
        /// </summary>
        /// <value>The material property name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The material property label to support internationalization. The content of this field is a i18n key. If this field is not present, the name field can be used as a fallback for English language.
        /// </summary>
        /// <value>The material property label to support internationalization. The content of this field is a i18n key. If this field is not present, the name field can be used as a fallback for English language.</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// The material property unit
        /// </summary>
        /// <value>The material property unit</value>
        [DataMember(Name="unit", EmitDefaultValue=false)]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [DataMember(Name="valueType", EmitDefaultValue=false)]
        public string ValueType { get; set; }

        /// <summary>
        /// The property value
        /// </summary>
        /// <value>The property value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public Object Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FixedMaterialProperty {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as FixedMaterialProperty);
        }

        /// <summary>
        /// Returns true if FixedMaterialProperty instances are equal
        /// </summary>
        /// <param name="input">Instance of FixedMaterialProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FixedMaterialProperty input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.ValueType == input.ValueType ||
                    (this.ValueType != null &&
                    this.ValueType.Equals(input.ValueType))
                ) && 
                (
                    this.DataType == input.DataType ||
                    this.DataType.Equals(input.DataType)
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.ValueType != null)
                    hashCode = hashCode * 59 + this.ValueType.GetHashCode();
                hashCode = hashCode * 59 + this.DataType.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }

}
