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
    /// SmoothLesDelta
    /// </summary>
    [DataContract]
    public partial class SmoothLesDelta : OneOfFluidModelDeltaCoefficient, OneOfPrandtlLesDeltaDeltaCoefficient, IEquatable<SmoothLesDelta>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmoothLesDelta" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SmoothLesDelta() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SmoothLesDelta" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;SMOOTH&quot;).</param>
        /// <param name="deltaCoefficient">deltaCoefficient.</param>
        /// <param name="maxDeltaRatio">maxDeltaRatio (default to 1.1M).</param>
        public SmoothLesDelta(string type = "SMOOTH", CubeRootVolLesDelta deltaCoefficient = default(CubeRootVolLesDelta), decimal? maxDeltaRatio = default(decimal?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for SmoothLesDelta and cannot be null");
            this.DeltaCoefficient = deltaCoefficient;
            this.MaxDeltaRatio = maxDeltaRatio;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets DeltaCoefficient
        /// </summary>
        [DataMember(Name="deltaCoefficient", EmitDefaultValue=false)]
        public CubeRootVolLesDelta DeltaCoefficient { get; set; }

        /// <summary>
        /// Gets or Sets MaxDeltaRatio
        /// </summary>
        [DataMember(Name="maxDeltaRatio", EmitDefaultValue=false)]
        public decimal? MaxDeltaRatio { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmoothLesDelta {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DeltaCoefficient: ").Append(DeltaCoefficient).Append("\n");
            sb.Append("  MaxDeltaRatio: ").Append(MaxDeltaRatio).Append("\n");
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
            return this.Equals(input as SmoothLesDelta);
        }

        /// <summary>
        /// Returns true if SmoothLesDelta instances are equal
        /// </summary>
        /// <param name="input">Instance of SmoothLesDelta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmoothLesDelta input)
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
                    this.DeltaCoefficient == input.DeltaCoefficient ||
                    (this.DeltaCoefficient != null &&
                    this.DeltaCoefficient.Equals(input.DeltaCoefficient))
                ) && 
                (
                    this.MaxDeltaRatio == input.MaxDeltaRatio ||
                    (this.MaxDeltaRatio != null &&
                    this.MaxDeltaRatio.Equals(input.MaxDeltaRatio))
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
                if (this.DeltaCoefficient != null)
                    hashCode = hashCode * 59 + this.DeltaCoefficient.GetHashCode();
                if (this.MaxDeltaRatio != null)
                    hashCode = hashCode * 59 + this.MaxDeltaRatio.GetHashCode();
                return hashCode;
            }
        }

    }

}