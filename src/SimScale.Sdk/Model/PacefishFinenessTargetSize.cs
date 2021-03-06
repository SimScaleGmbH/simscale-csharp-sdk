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
    /// PacefishFinenessTargetSize
    /// </summary>
    [DataContract]
    public partial class PacefishFinenessTargetSize : OneOfPacefishAutomeshNewFineness, OneOfRegionRefinementWindComfortNewFineness, OneOfSurfaceRefinementWindComfortNewFineness, OneOfWindComfortMeshWindComfortFineness, IEquatable<PacefishFinenessTargetSize>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacefishFinenessTargetSize" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PacefishFinenessTargetSize() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PacefishFinenessTargetSize" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;TARGET_SIZE&quot;).</param>
        /// <param name="minimumCellSize">minimumCellSize.</param>
        public PacefishFinenessTargetSize(string type = "TARGET_SIZE", DimensionalLength minimumCellSize = default(DimensionalLength))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for PacefishFinenessTargetSize and cannot be null");
            this.MinimumCellSize = minimumCellSize;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets MinimumCellSize
        /// </summary>
        [DataMember(Name="minimumCellSize", EmitDefaultValue=false)]
        public DimensionalLength MinimumCellSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PacefishFinenessTargetSize {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MinimumCellSize: ").Append(MinimumCellSize).Append("\n");
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
            return this.Equals(input as PacefishFinenessTargetSize);
        }

        /// <summary>
        /// Returns true if PacefishFinenessTargetSize instances are equal
        /// </summary>
        /// <param name="input">Instance of PacefishFinenessTargetSize to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PacefishFinenessTargetSize input)
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
                    this.MinimumCellSize == input.MinimumCellSize ||
                    (this.MinimumCellSize != null &&
                    this.MinimumCellSize.Equals(input.MinimumCellSize))
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
                if (this.MinimumCellSize != null)
                    hashCode = hashCode * 59 + this.MinimumCellSize.GetHashCode();
                return hashCode;
            }
        }

    }

}
