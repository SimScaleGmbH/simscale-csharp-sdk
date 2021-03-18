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
    /// OscillatingRotatingMotionType
    /// </summary>
    [DataContract]
    public partial class OscillatingRotatingMotionType : OneOfAMIRotatingZoneMotionType, IEquatable<OscillatingRotatingMotionType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OscillatingRotatingMotionType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OscillatingRotatingMotionType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OscillatingRotatingMotionType" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;OSCILLATING_ROTATING_MOTION&quot;).</param>
        /// <param name="rotationCenter">rotationCenter.</param>
        /// <param name="amplitude">amplitude.</param>
        /// <param name="angularVelocity">angularVelocity.</param>
        public OscillatingRotatingMotionType(string type = "OSCILLATING_ROTATING_MOTION", DimensionalVectorLength rotationCenter = default(DimensionalVectorLength), DimensionalVectorAngle amplitude = default(DimensionalVectorAngle), DimensionalFunctionRotationSpeed angularVelocity = default(DimensionalFunctionRotationSpeed))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for OscillatingRotatingMotionType and cannot be null");
            this.RotationCenter = rotationCenter;
            this.Amplitude = amplitude;
            this.AngularVelocity = angularVelocity;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets RotationCenter
        /// </summary>
        [DataMember(Name="rotationCenter", EmitDefaultValue=false)]
        public DimensionalVectorLength RotationCenter { get; set; }

        /// <summary>
        /// Gets or Sets Amplitude
        /// </summary>
        [DataMember(Name="amplitude", EmitDefaultValue=false)]
        public DimensionalVectorAngle Amplitude { get; set; }

        /// <summary>
        /// Gets or Sets AngularVelocity
        /// </summary>
        [DataMember(Name="angularVelocity", EmitDefaultValue=false)]
        public DimensionalFunctionRotationSpeed AngularVelocity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OscillatingRotatingMotionType {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  RotationCenter: ").Append(RotationCenter).Append("\n");
            sb.Append("  Amplitude: ").Append(Amplitude).Append("\n");
            sb.Append("  AngularVelocity: ").Append(AngularVelocity).Append("\n");
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
            return this.Equals(input as OscillatingRotatingMotionType);
        }

        /// <summary>
        /// Returns true if OscillatingRotatingMotionType instances are equal
        /// </summary>
        /// <param name="input">Instance of OscillatingRotatingMotionType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OscillatingRotatingMotionType input)
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
                    this.RotationCenter == input.RotationCenter ||
                    (this.RotationCenter != null &&
                    this.RotationCenter.Equals(input.RotationCenter))
                ) && 
                (
                    this.Amplitude == input.Amplitude ||
                    (this.Amplitude != null &&
                    this.Amplitude.Equals(input.Amplitude))
                ) && 
                (
                    this.AngularVelocity == input.AngularVelocity ||
                    (this.AngularVelocity != null &&
                    this.AngularVelocity.Equals(input.AngularVelocity))
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
                if (this.RotationCenter != null)
                    hashCode = hashCode * 59 + this.RotationCenter.GetHashCode();
                if (this.Amplitude != null)
                    hashCode = hashCode * 59 + this.Amplitude.GetHashCode();
                if (this.AngularVelocity != null)
                    hashCode = hashCode * 59 + this.AngularVelocity.GetHashCode();
                return hashCode;
            }
        }

    }

}