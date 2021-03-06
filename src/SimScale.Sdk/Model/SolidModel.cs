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
    /// SolidModel
    /// </summary>
    [DataContract]
    public partial class SolidModel : IEquatable<SolidModel>
    {
        /// <summary>
        /// Defines GeometricBehavior
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GeometricBehaviorEnum
        {
            /// <summary>
            /// Enum LINEAR for value: LINEAR
            /// </summary>
            [EnumMember(Value = "LINEAR")]
            LINEAR = 1,

            /// <summary>
            /// Enum NONLINEAR for value: NONLINEAR
            /// </summary>
            [EnumMember(Value = "NONLINEAR")]
            NONLINEAR = 2

        }

        /// <summary>
        /// Gets or Sets GeometricBehavior
        /// </summary>
        [DataMember(Name="geometricBehavior", EmitDefaultValue=false)]
        public GeometricBehaviorEnum? GeometricBehavior { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SolidModel" /> class.
        /// </summary>
        /// <param name="geometricBehavior">geometricBehavior (default to GeometricBehaviorEnum.NONLINEAR).</param>
        /// <param name="magnitude">magnitude.</param>
        /// <param name="e">e.</param>
        public SolidModel(GeometricBehaviorEnum? geometricBehavior = default(GeometricBehaviorEnum?), DimensionalFunctionAcceleration magnitude = default(DimensionalFunctionAcceleration), DimensionalVectorLength e = default(DimensionalVectorLength))
        {
            this.GeometricBehavior = geometricBehavior;
            this.Magnitude = magnitude;
            this.E = e;
        }
        
        /// <summary>
        /// Gets or Sets Magnitude
        /// </summary>
        [DataMember(Name="magnitude", EmitDefaultValue=false)]
        public DimensionalFunctionAcceleration Magnitude { get; set; }

        /// <summary>
        /// Gets or Sets E
        /// </summary>
        [DataMember(Name="e", EmitDefaultValue=false)]
        public DimensionalVectorLength E { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SolidModel {\n");
            sb.Append("  GeometricBehavior: ").Append(GeometricBehavior).Append("\n");
            sb.Append("  Magnitude: ").Append(Magnitude).Append("\n");
            sb.Append("  E: ").Append(E).Append("\n");
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
            return this.Equals(input as SolidModel);
        }

        /// <summary>
        /// Returns true if SolidModel instances are equal
        /// </summary>
        /// <param name="input">Instance of SolidModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SolidModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GeometricBehavior == input.GeometricBehavior ||
                    this.GeometricBehavior.Equals(input.GeometricBehavior)
                ) && 
                (
                    this.Magnitude == input.Magnitude ||
                    (this.Magnitude != null &&
                    this.Magnitude.Equals(input.Magnitude))
                ) && 
                (
                    this.E == input.E ||
                    (this.E != null &&
                    this.E.Equals(input.E))
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
                hashCode = hashCode * 59 + this.GeometricBehavior.GetHashCode();
                if (this.Magnitude != null)
                    hashCode = hashCode * 59 + this.Magnitude.GetHashCode();
                if (this.E != null)
                    hashCode = hashCode * 59 + this.E.GetHashCode();
                return hashCode;
            }
        }

    }

}
