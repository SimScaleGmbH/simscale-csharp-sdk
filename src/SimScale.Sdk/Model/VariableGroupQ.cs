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
    /// VariableGroupQ
    /// </summary>
    [DataContract]
    public partial class VariableGroupQ : IEquatable<VariableGroupQ>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableGroupQ" /> class.
        /// </summary>
        /// <param name="q">q.</param>
        public VariableGroupQ(UnitMassFlowRate q = default(UnitMassFlowRate))
        {
            this.Q = q;
        }
        
        /// <summary>
        /// Gets or Sets Q
        /// </summary>
        [DataMember(Name="Q", EmitDefaultValue=false)]
        public UnitMassFlowRate Q { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariableGroupQ {\n");
            sb.Append("  Q: ").Append(Q).Append("\n");
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
            return this.Equals(input as VariableGroupQ);
        }

        /// <summary>
        /// Returns true if VariableGroupQ instances are equal
        /// </summary>
        /// <param name="input">Instance of VariableGroupQ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariableGroupQ input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Q == input.Q ||
                    (this.Q != null &&
                    this.Q.Equals(input.Q))
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
                if (this.Q != null)
                    hashCode = hashCode * 59 + this.Q.GetHashCode();
                return hashCode;
            }
        }

    }

}