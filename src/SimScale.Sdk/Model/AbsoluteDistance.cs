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
    /// AbsoluteDistance
    /// </summary>
    [DataContract]
    public partial class AbsoluteDistance : OneOfSimmetrixThinSectionMeshRefinementDistanceType, IEquatable<AbsoluteDistance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbsoluteDistance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AbsoluteDistance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbsoluteDistance" /> class.
        /// </summary>
        /// <param name="type">Schema name: AbsoluteDistance (required) (default to &quot;ABSOLUTE&quot;).</param>
        /// <param name="absoluteDistance">absoluteDistance.</param>
        public AbsoluteDistance(string type = "ABSOLUTE", DimensionalLength absoluteDistance = default(DimensionalLength))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for AbsoluteDistance and cannot be null");
            this._AbsoluteDistance = absoluteDistance;
        }
        
        /// <summary>
        /// Schema name: AbsoluteDistance
        /// </summary>
        /// <value>Schema name: AbsoluteDistance</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets _AbsoluteDistance
        /// </summary>
        [DataMember(Name="absoluteDistance", EmitDefaultValue=false)]
        public DimensionalLength _AbsoluteDistance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbsoluteDistance {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  _AbsoluteDistance: ").Append(_AbsoluteDistance).Append("\n");
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
            return this.Equals(input as AbsoluteDistance);
        }

        /// <summary>
        /// Returns true if AbsoluteDistance instances are equal
        /// </summary>
        /// <param name="input">Instance of AbsoluteDistance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbsoluteDistance input)
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
                    this._AbsoluteDistance == input._AbsoluteDistance ||
                    (this._AbsoluteDistance != null &&
                    this._AbsoluteDistance.Equals(input._AbsoluteDistance))
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
                if (this._AbsoluteDistance != null)
                    hashCode = hashCode * 59 + this._AbsoluteDistance.GetHashCode();
                return hashCode;
            }
        }

    }

}
