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
    /// RelativeDistance
    /// </summary>
    [DataContract]
    public partial class RelativeDistance : OneOfSimmetrixThinSectionMeshRefinementDistanceType, IEquatable<RelativeDistance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelativeDistance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RelativeDistance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RelativeDistance" /> class.
        /// </summary>
        /// <param name="type">Schema name: RelativeDistance (required) (default to &quot;RELATIVE&quot;).</param>
        /// <param name="relativeDistance">relativeDistance (default to 0.1M).</param>
        public RelativeDistance(string type = "RELATIVE", decimal? relativeDistance = default(decimal?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for RelativeDistance and cannot be null");
            this._RelativeDistance = relativeDistance;
        }
        
        /// <summary>
        /// Schema name: RelativeDistance
        /// </summary>
        /// <value>Schema name: RelativeDistance</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets _RelativeDistance
        /// </summary>
        [DataMember(Name="relativeDistance", EmitDefaultValue=false)]
        public decimal? _RelativeDistance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelativeDistance {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  _RelativeDistance: ").Append(_RelativeDistance).Append("\n");
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
            return this.Equals(input as RelativeDistance);
        }

        /// <summary>
        /// Returns true if RelativeDistance instances are equal
        /// </summary>
        /// <param name="input">Instance of RelativeDistance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelativeDistance input)
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
                    this._RelativeDistance == input._RelativeDistance ||
                    (this._RelativeDistance != null &&
                    this._RelativeDistance.Equals(input._RelativeDistance))
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
                if (this._RelativeDistance != null)
                    hashCode = hashCode * 59 + this._RelativeDistance.GetHashCode();
                return hashCode;
            }
        }

    }

}
