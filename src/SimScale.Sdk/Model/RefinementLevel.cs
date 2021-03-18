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
    /// RefinementLevel
    /// </summary>
    [DataContract]
    public partial class RefinementLevel : IEquatable<RefinementLevel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefinementLevel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RefinementLevel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RefinementLevel" /> class.
        /// </summary>
        /// <param name="distance">distance.</param>
        /// <param name="level">level (required).</param>
        public RefinementLevel(DimensionalLength distance = default(DimensionalLength), int? level = default(int?))
        {
            // to ensure "level" is required (not null)
            this.Level = level ?? throw new ArgumentNullException("level is a required property for RefinementLevel and cannot be null");
            this.Distance = distance;
        }
        
        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public DimensionalLength Distance { get; set; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public int? Level { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefinementLevel {\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
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
            return this.Equals(input as RefinementLevel);
        }

        /// <summary>
        /// Returns true if RefinementLevel instances are equal
        /// </summary>
        /// <param name="input">Instance of RefinementLevel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefinementLevel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Distance == input.Distance ||
                    (this.Distance != null &&
                    this.Distance.Equals(input.Distance))
                ) && 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
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
                if (this.Distance != null)
                    hashCode = hashCode * 59 + this.Distance.GetHashCode();
                if (this.Level != null)
                    hashCode = hashCode * 59 + this.Level.GetHashCode();
                return hashCode;
            }
        }

    }

}