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
    /// FixedValueMassFractionBC
    /// </summary>
    [DataContract]
    public partial class FixedValueMassFractionBC : IEquatable<FixedValueMassFractionBC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedValueMassFractionBC" /> class.
        /// </summary>
        /// <param name="fractionValue">fractionValue (default to 0M).</param>
        public FixedValueMassFractionBC(decimal? fractionValue = default(decimal?))
        {
            this.FractionValue = fractionValue;
        }
        
        /// <summary>
        /// Gets or Sets FractionValue
        /// </summary>
        [DataMember(Name="fractionValue", EmitDefaultValue=false)]
        public decimal? FractionValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FixedValueMassFractionBC {\n");
            sb.Append("  FractionValue: ").Append(FractionValue).Append("\n");
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
            return this.Equals(input as FixedValueMassFractionBC);
        }

        /// <summary>
        /// Returns true if FixedValueMassFractionBC instances are equal
        /// </summary>
        /// <param name="input">Instance of FixedValueMassFractionBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FixedValueMassFractionBC input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FractionValue == input.FractionValue ||
                    (this.FractionValue != null &&
                    this.FractionValue.Equals(input.FractionValue))
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
                if (this.FractionValue != null)
                    hashCode = hashCode * 59 + this.FractionValue.GetHashCode();
                return hashCode;
            }
        }

    }

}
