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
    /// FixedValueDVBC
    /// </summary>
    [DataContract]
    public partial class FixedValueDVBC : OneOfCustomFluidBCTurbulentDynamicViscosity, IEquatable<FixedValueDVBC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedValueDVBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FixedValueDVBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedValueDVBC" /> class.
        /// </summary>
        /// <param name="type">Schema name: FixedValueDVBC (required) (default to &quot;FIXED_VALUE&quot;).</param>
        /// <param name="value">value.</param>
        public FixedValueDVBC(string type = "FIXED_VALUE", DimensionalDynamicViscosity value = default(DimensionalDynamicViscosity))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for FixedValueDVBC and cannot be null");
            this.Value = value;
        }
        
        /// <summary>
        /// Schema name: FixedValueDVBC
        /// </summary>
        /// <value>Schema name: FixedValueDVBC</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public DimensionalDynamicViscosity Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FixedValueDVBC {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as FixedValueDVBC);
        }

        /// <summary>
        /// Returns true if FixedValueDVBC instances are equal
        /// </summary>
        /// <param name="input">Instance of FixedValueDVBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FixedValueDVBC input)
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }

}
