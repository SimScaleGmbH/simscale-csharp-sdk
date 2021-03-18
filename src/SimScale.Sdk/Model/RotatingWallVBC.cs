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
    /// RotatingWallVBC
    /// </summary>
    [DataContract]
    public partial class RotatingWallVBC : OneOfCustomFluidBCVelocity, OneOfWallBCVelocity, IEquatable<RotatingWallVBC>
    {
        /// <summary>
        /// Defines TurbulenceWall
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TurbulenceWallEnum
        {
            /// <summary>
            /// Enum WALLFUNCTION for value: WALL_FUNCTION
            /// </summary>
            [EnumMember(Value = "WALL_FUNCTION")]
            WALLFUNCTION = 1,

            /// <summary>
            /// Enum FULLRESOLUTION for value: FULL_RESOLUTION
            /// </summary>
            [EnumMember(Value = "FULL_RESOLUTION")]
            FULLRESOLUTION = 2

        }

        /// <summary>
        /// Gets or Sets TurbulenceWall
        /// </summary>
        [DataMember(Name="turbulenceWall", EmitDefaultValue=false)]
        public TurbulenceWallEnum? TurbulenceWall { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RotatingWallVBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RotatingWallVBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RotatingWallVBC" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;ROTATING_WALL_VELOCITY&quot;).</param>
        /// <param name="rotation">rotation.</param>
        /// <param name="turbulenceWall">turbulenceWall (default to TurbulenceWallEnum.WALLFUNCTION).</param>
        public RotatingWallVBC(string type = "ROTATING_WALL_VELOCITY", AngularRotation rotation = default(AngularRotation), TurbulenceWallEnum? turbulenceWall = default(TurbulenceWallEnum?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for RotatingWallVBC and cannot be null");
            this.Rotation = rotation;
            this.TurbulenceWall = turbulenceWall;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Rotation
        /// </summary>
        [DataMember(Name="rotation", EmitDefaultValue=false)]
        public AngularRotation Rotation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RotatingWallVBC {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Rotation: ").Append(Rotation).Append("\n");
            sb.Append("  TurbulenceWall: ").Append(TurbulenceWall).Append("\n");
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
            return this.Equals(input as RotatingWallVBC);
        }

        /// <summary>
        /// Returns true if RotatingWallVBC instances are equal
        /// </summary>
        /// <param name="input">Instance of RotatingWallVBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RotatingWallVBC input)
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
                    this.Rotation == input.Rotation ||
                    (this.Rotation != null &&
                    this.Rotation.Equals(input.Rotation))
                ) && 
                (
                    this.TurbulenceWall == input.TurbulenceWall ||
                    this.TurbulenceWall.Equals(input.TurbulenceWall)
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
                if (this.Rotation != null)
                    hashCode = hashCode * 59 + this.Rotation.GetHashCode();
                hashCode = hashCode * 59 + this.TurbulenceWall.GetHashCode();
                return hashCode;
            }
        }

    }

}