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
    /// DimensionalFunctionPressure
    /// </summary>
    [DataContract]
    public partial class DimensionalFunctionPressure : IEquatable<DimensionalFunctionPressure>
    {
        /// <summary>
        /// Defines Unit
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitEnum
        {
            /// <summary>
            /// Enum Pa for value: Pa
            /// </summary>
            [EnumMember(Value = "Pa")]
            Pa = 1,

            /// <summary>
            /// Enum LbfIn for value: lbf/in²
            /// </summary>
            [EnumMember(Value = "lbf/in²")]
            LbfIn = 2,

            /// <summary>
            /// Enum KPa for value: kPa
            /// </summary>
            [EnumMember(Value = "kPa")]
            KPa = 3,

            /// <summary>
            /// Enum MPa for value: MPa
            /// </summary>
            [EnumMember(Value = "MPa")]
            MPa = 4,

            /// <summary>
            /// Enum Bar for value: bar
            /// </summary>
            [EnumMember(Value = "bar")]
            Bar = 5,

            /// <summary>
            /// Enum Mbar for value: mbar
            /// </summary>
            [EnumMember(Value = "mbar")]
            Mbar = 6,

            /// <summary>
            /// Enum MH2O for value: mH2O
            /// </summary>
            [EnumMember(Value = "mH2O")]
            MH2O = 7

        }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name="unit", EmitDefaultValue=false)]
        public UnitEnum Unit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DimensionalFunctionPressure" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DimensionalFunctionPressure() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DimensionalFunctionPressure" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="unit">unit (required).</param>
        public DimensionalFunctionPressure(OneOfDimensionalFunctionPressureValue value = default(OneOfDimensionalFunctionPressureValue), UnitEnum unit = default(UnitEnum))
        {
            this.Unit = unit;
            this.Value = value;
        }
        
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public OneOfDimensionalFunctionPressureValue Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DimensionalFunctionPressure {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as DimensionalFunctionPressure);
        }

        /// <summary>
        /// Returns true if DimensionalFunctionPressure instances are equal
        /// </summary>
        /// <param name="input">Instance of DimensionalFunctionPressure to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DimensionalFunctionPressure input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Unit == input.Unit ||
                    this.Unit.Equals(input.Unit)
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.Unit.GetHashCode();
                return hashCode;
            }
        }

    }

}