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
    /// DimensionalFunctionElectricPotential
    /// </summary>
    [DataContract]
    public partial class DimensionalFunctionElectricPotential : IEquatable<DimensionalFunctionElectricPotential>
    {
        /// <summary>
        /// Defines Unit
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitEnum
        {
            /// <summary>
            /// Enum V for value: V
            /// </summary>
            [EnumMember(Value = "V")]
            V = 1

        }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name="unit", EmitDefaultValue=false)]
        public UnitEnum Unit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DimensionalFunctionElectricPotential" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DimensionalFunctionElectricPotential() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DimensionalFunctionElectricPotential" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="unit">unit (required).</param>
        public DimensionalFunctionElectricPotential(OneOfDimensionalFunctionElectricPotentialValue value = default(OneOfDimensionalFunctionElectricPotentialValue), UnitEnum unit = default(UnitEnum))
        {
            this.Unit = unit;
            this.Value = value;
        }
        
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public OneOfDimensionalFunctionElectricPotentialValue Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DimensionalFunctionElectricPotential {\n");
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
            return this.Equals(input as DimensionalFunctionElectricPotential);
        }

        /// <summary>
        /// Returns true if DimensionalFunctionElectricPotential instances are equal
        /// </summary>
        /// <param name="input">Instance of DimensionalFunctionElectricPotential to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DimensionalFunctionElectricPotential input)
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
