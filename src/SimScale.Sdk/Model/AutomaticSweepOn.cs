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
    /// AutomaticSweepOn
    /// </summary>
    [DataContract]
    public partial class AutomaticSweepOn : OneOfSimmetrixMeshingSolidAutomaticSweepParameters, IEquatable<AutomaticSweepOn>
    {
        /// <summary>
        /// Defines SurfaceElementType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SurfaceElementTypeEnum
        {
            /// <summary>
            /// Enum TRIANGULAR for value: TRIANGULAR
            /// </summary>
            [EnumMember(Value = "TRIANGULAR")]
            TRIANGULAR = 1,

            /// <summary>
            /// Enum QUADDOMINANT for value: QUADDOMINANT
            /// </summary>
            [EnumMember(Value = "QUADDOMINANT")]
            QUADDOMINANT = 2

        }

        /// <summary>
        /// Gets or Sets SurfaceElementType
        /// </summary>
        [DataMember(Name="surfaceElementType", EmitDefaultValue=false)]
        public SurfaceElementTypeEnum? SurfaceElementType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomaticSweepOn" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutomaticSweepOn() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomaticSweepOn" /> class.
        /// </summary>
        /// <param name="type">Schema name: AutomaticSweepOn (required) (default to &quot;AUTOMATIC_SWEEP_MESHING_ON&quot;).</param>
        /// <param name="maximumNumberOfLayers">maximumNumberOfLayers (default to 500).</param>
        /// <param name="minimumNumberOfLayers">minimumNumberOfLayers (default to 2).</param>
        /// <param name="surfaceElementType">surfaceElementType (default to SurfaceElementTypeEnum.QUADDOMINANT).</param>
        public AutomaticSweepOn(string type = "AUTOMATIC_SWEEP_MESHING_ON", int? maximumNumberOfLayers = default(int?), int? minimumNumberOfLayers = default(int?), SurfaceElementTypeEnum? surfaceElementType = default(SurfaceElementTypeEnum?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for AutomaticSweepOn and cannot be null");
            this.MaximumNumberOfLayers = maximumNumberOfLayers;
            this.MinimumNumberOfLayers = minimumNumberOfLayers;
            this.SurfaceElementType = surfaceElementType;
        }
        
        /// <summary>
        /// Schema name: AutomaticSweepOn
        /// </summary>
        /// <value>Schema name: AutomaticSweepOn</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets MaximumNumberOfLayers
        /// </summary>
        [DataMember(Name="maximumNumberOfLayers", EmitDefaultValue=false)]
        public int? MaximumNumberOfLayers { get; set; }

        /// <summary>
        /// Gets or Sets MinimumNumberOfLayers
        /// </summary>
        [DataMember(Name="minimumNumberOfLayers", EmitDefaultValue=false)]
        public int? MinimumNumberOfLayers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutomaticSweepOn {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MaximumNumberOfLayers: ").Append(MaximumNumberOfLayers).Append("\n");
            sb.Append("  MinimumNumberOfLayers: ").Append(MinimumNumberOfLayers).Append("\n");
            sb.Append("  SurfaceElementType: ").Append(SurfaceElementType).Append("\n");
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
            return this.Equals(input as AutomaticSweepOn);
        }

        /// <summary>
        /// Returns true if AutomaticSweepOn instances are equal
        /// </summary>
        /// <param name="input">Instance of AutomaticSweepOn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutomaticSweepOn input)
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
                    this.MaximumNumberOfLayers == input.MaximumNumberOfLayers ||
                    (this.MaximumNumberOfLayers != null &&
                    this.MaximumNumberOfLayers.Equals(input.MaximumNumberOfLayers))
                ) && 
                (
                    this.MinimumNumberOfLayers == input.MinimumNumberOfLayers ||
                    (this.MinimumNumberOfLayers != null &&
                    this.MinimumNumberOfLayers.Equals(input.MinimumNumberOfLayers))
                ) && 
                (
                    this.SurfaceElementType == input.SurfaceElementType ||
                    this.SurfaceElementType.Equals(input.SurfaceElementType)
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
                if (this.MaximumNumberOfLayers != null)
                    hashCode = hashCode * 59 + this.MaximumNumberOfLayers.GetHashCode();
                if (this.MinimumNumberOfLayers != null)
                    hashCode = hashCode * 59 + this.MinimumNumberOfLayers.GetHashCode();
                hashCode = hashCode * 59 + this.SurfaceElementType.GetHashCode();
                return hashCode;
            }
        }

    }

}