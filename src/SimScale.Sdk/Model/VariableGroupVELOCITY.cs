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
    /// VariableGroupVELOCITY
    /// </summary>
    [DataContract]
    public partial class VariableGroupVELOCITY : IEquatable<VariableGroupVELOCITY>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableGroupVELOCITY" /> class.
        /// </summary>
        /// <param name="vELOCITY">vELOCITY.</param>
        public VariableGroupVELOCITY(UnitSpeed vELOCITY = default(UnitSpeed))
        {
            this.VELOCITY = vELOCITY;
        }
        
        /// <summary>
        /// Gets or Sets VELOCITY
        /// </summary>
        [DataMember(Name="VELOCITY", EmitDefaultValue=false)]
        public UnitSpeed VELOCITY { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariableGroupVELOCITY {\n");
            sb.Append("  VELOCITY: ").Append(VELOCITY).Append("\n");
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
            return this.Equals(input as VariableGroupVELOCITY);
        }

        /// <summary>
        /// Returns true if VariableGroupVELOCITY instances are equal
        /// </summary>
        /// <param name="input">Instance of VariableGroupVELOCITY to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariableGroupVELOCITY input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VELOCITY == input.VELOCITY ||
                    (this.VELOCITY != null &&
                    this.VELOCITY.Equals(input.VELOCITY))
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
                if (this.VELOCITY != null)
                    hashCode = hashCode * 59 + this.VELOCITY.GetHashCode();
                return hashCode;
            }
        }

    }

}