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
    /// FortyFiveViewPredefinedCameraSettings
    /// </summary>
    [DataContract]
    public partial class FortyFiveViewPredefinedCameraSettings : OneOfCameraSettings, IEquatable<FortyFiveViewPredefinedCameraSettings>
    {
        /// <summary>
        /// Gets or Sets ProjectionType
        /// </summary>
        [DataMember(Name="projectionType", EmitDefaultValue=false)]
        public ProjectionType ProjectionType { get; set; }
        /// <summary>
        /// Defines DirectionSpecifier
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionSpecifierEnum
        {
            /// <summary>
            /// Enum NEGATIVEYNEGATIVEZNEGATIVE for value: X_NEGATIVE_Y_NEGATIVE_Z_NEGATIVE
            /// </summary>
            [EnumMember(Value = "X_NEGATIVE_Y_NEGATIVE_Z_NEGATIVE")]
            NEGATIVEYNEGATIVEZNEGATIVE = 1,

            /// <summary>
            /// Enum NEGATIVEYNEGATIVEZPOSITIVE for value: X_NEGATIVE_Y_NEGATIVE_Z_POSITIVE
            /// </summary>
            [EnumMember(Value = "X_NEGATIVE_Y_NEGATIVE_Z_POSITIVE")]
            NEGATIVEYNEGATIVEZPOSITIVE = 2,

            /// <summary>
            /// Enum NEGATIVEYPOSITIVEZNEGATIVE for value: X_NEGATIVE_Y_POSITIVE_Z_NEGATIVE
            /// </summary>
            [EnumMember(Value = "X_NEGATIVE_Y_POSITIVE_Z_NEGATIVE")]
            NEGATIVEYPOSITIVEZNEGATIVE = 3,

            /// <summary>
            /// Enum NEGATIVEYPOSITIVEZPOSITIVE for value: X_NEGATIVE_Y_POSITIVE_Z_POSITIVE
            /// </summary>
            [EnumMember(Value = "X_NEGATIVE_Y_POSITIVE_Z_POSITIVE")]
            NEGATIVEYPOSITIVEZPOSITIVE = 4,

            /// <summary>
            /// Enum POSITIVEYNEGATIVEZNEGATIVE for value: X_POSITIVE_Y_NEGATIVE_Z_NEGATIVE
            /// </summary>
            [EnumMember(Value = "X_POSITIVE_Y_NEGATIVE_Z_NEGATIVE")]
            POSITIVEYNEGATIVEZNEGATIVE = 5,

            /// <summary>
            /// Enum POSITIVEYNEGATIVEZPOSITIVE for value: X_POSITIVE_Y_NEGATIVE_Z_POSITIVE
            /// </summary>
            [EnumMember(Value = "X_POSITIVE_Y_NEGATIVE_Z_POSITIVE")]
            POSITIVEYNEGATIVEZPOSITIVE = 6,

            /// <summary>
            /// Enum POSITIVEYPOSITIVEZNEGATIVE for value: X_POSITIVE_Y_POSITIVE_Z_NEGATIVE
            /// </summary>
            [EnumMember(Value = "X_POSITIVE_Y_POSITIVE_Z_NEGATIVE")]
            POSITIVEYPOSITIVEZNEGATIVE = 7,

            /// <summary>
            /// Enum POSITIVEYPOSITIVEZPOSITIVE for value: X_POSITIVE_Y_POSITIVE_Z_POSITIVE
            /// </summary>
            [EnumMember(Value = "X_POSITIVE_Y_POSITIVE_Z_POSITIVE")]
            POSITIVEYPOSITIVEZPOSITIVE = 8

        }

        /// <summary>
        /// Gets or Sets DirectionSpecifier
        /// </summary>
        [DataMember(Name="directionSpecifier", EmitDefaultValue=false)]
        public DirectionSpecifierEnum DirectionSpecifier { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FortyFiveViewPredefinedCameraSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FortyFiveViewPredefinedCameraSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FortyFiveViewPredefinedCameraSettings" /> class.
        /// </summary>
        /// <param name="settingType">settingType (required) (default to &quot;FORTY_FIVE_FORTY_FIVE_VIEW&quot;).</param>
        /// <param name="projectionType">projectionType (required).</param>
        /// <param name="directionSpecifier">directionSpecifier (required).</param>
        public FortyFiveViewPredefinedCameraSettings(string settingType = "FORTY_FIVE_FORTY_FIVE_VIEW", ProjectionType projectionType = default(ProjectionType), DirectionSpecifierEnum directionSpecifier = default(DirectionSpecifierEnum))
        {
            // to ensure "settingType" is required (not null)
            this.SettingType = settingType ?? throw new ArgumentNullException("settingType is a required property for FortyFiveViewPredefinedCameraSettings and cannot be null");
            this.ProjectionType = projectionType;
            this.DirectionSpecifier = directionSpecifier;
        }
        
        /// <summary>
        /// Gets or Sets SettingType
        /// </summary>
        [DataMember(Name="settingType", EmitDefaultValue=false)]
        public string SettingType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FortyFiveViewPredefinedCameraSettings {\n");
            sb.Append("  SettingType: ").Append(SettingType).Append("\n");
            sb.Append("  ProjectionType: ").Append(ProjectionType).Append("\n");
            sb.Append("  DirectionSpecifier: ").Append(DirectionSpecifier).Append("\n");
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
            return this.Equals(input as FortyFiveViewPredefinedCameraSettings);
        }

        /// <summary>
        /// Returns true if FortyFiveViewPredefinedCameraSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of FortyFiveViewPredefinedCameraSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FortyFiveViewPredefinedCameraSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SettingType == input.SettingType ||
                    (this.SettingType != null &&
                    this.SettingType.Equals(input.SettingType))
                ) && 
                (
                    this.ProjectionType == input.ProjectionType ||
                    this.ProjectionType.Equals(input.ProjectionType)
                ) && 
                (
                    this.DirectionSpecifier == input.DirectionSpecifier ||
                    this.DirectionSpecifier.Equals(input.DirectionSpecifier)
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
                if (this.SettingType != null)
                    hashCode = hashCode * 59 + this.SettingType.GetHashCode();
                hashCode = hashCode * 59 + this.ProjectionType.GetHashCode();
                hashCode = hashCode * 59 + this.DirectionSpecifier.GetHashCode();
                return hashCode;
            }
        }

    }

}