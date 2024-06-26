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
    /// MovingWallVBC
    /// </summary>
    [DataContract]
    public partial class MovingWallVBC : OneOfCustomFluidBCVelocity, OneOfWallBCVelocity, IEquatable<MovingWallVBC>
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
        /// Defines OrientationReference
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrientationReferenceEnum
        {
            /// <summary>
            /// Enum GEOMETRY for value: GEOMETRY
            /// </summary>
            [EnumMember(Value = "GEOMETRY")]
            GEOMETRY = 1,

            /// <summary>
            /// Enum FLOWDOMAIN for value: FLOW_DOMAIN
            /// </summary>
            [EnumMember(Value = "FLOW_DOMAIN")]
            FLOWDOMAIN = 2

        }

        /// <summary>
        /// Gets or Sets OrientationReference
        /// </summary>
        [DataMember(Name="orientationReference", EmitDefaultValue=false)]
        public OrientationReferenceEnum? OrientationReference { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MovingWallVBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MovingWallVBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MovingWallVBC" /> class.
        /// </summary>
        /// <param name="type">Schema name: MovingWallVBC (required) (default to &quot;MOVING_WALL_VELOCITY&quot;).</param>
        /// <param name="value">value.</param>
        /// <param name="turbulenceWall">turbulenceWall (default to TurbulenceWallEnum.WALLFUNCTION).</param>
        /// <param name="orientationReference">orientationReference (default to OrientationReferenceEnum.FLOWDOMAIN).</param>
        /// <param name="wallContactModel">wallContactModel.</param>
        public MovingWallVBC(string type = "MOVING_WALL_VELOCITY", DimensionalVectorSpeed value = default(DimensionalVectorSpeed), TurbulenceWallEnum? turbulenceWall = default(TurbulenceWallEnum?), OrientationReferenceEnum? orientationReference = default(OrientationReferenceEnum?), List<WallContactAngle> wallContactModel = default(List<WallContactAngle>))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for MovingWallVBC and cannot be null");
            this.Value = value;
            this.TurbulenceWall = turbulenceWall;
            this.OrientationReference = orientationReference;
            this.WallContactModel = wallContactModel;
        }
        
        /// <summary>
        /// Schema name: MovingWallVBC
        /// </summary>
        /// <value>Schema name: MovingWallVBC</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public DimensionalVectorSpeed Value { get; set; }

        /// <summary>
        /// Gets or Sets WallContactModel
        /// </summary>
        [DataMember(Name="wallContactModel", EmitDefaultValue=false)]
        public List<WallContactAngle> WallContactModel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MovingWallVBC {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  TurbulenceWall: ").Append(TurbulenceWall).Append("\n");
            sb.Append("  OrientationReference: ").Append(OrientationReference).Append("\n");
            sb.Append("  WallContactModel: ").Append(WallContactModel).Append("\n");
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
            return this.Equals(input as MovingWallVBC);
        }

        /// <summary>
        /// Returns true if MovingWallVBC instances are equal
        /// </summary>
        /// <param name="input">Instance of MovingWallVBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MovingWallVBC input)
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
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.TurbulenceWall == input.TurbulenceWall ||
                    this.TurbulenceWall.Equals(input.TurbulenceWall)
                ) && 
                (
                    this.OrientationReference == input.OrientationReference ||
                    this.OrientationReference.Equals(input.OrientationReference)
                ) && 
                (
                    this.WallContactModel == input.WallContactModel ||
                    this.WallContactModel != null &&
                    input.WallContactModel != null &&
                    this.WallContactModel.SequenceEqual(input.WallContactModel)
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.TurbulenceWall.GetHashCode();
                hashCode = hashCode * 59 + this.OrientationReference.GetHashCode();
                if (this.WallContactModel != null)
                    hashCode = hashCode * 59 + this.WallContactModel.GetHashCode();
                return hashCode;
            }
        }

    }

}
