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
    /// ElectromagneticCurrentTypeSinusoidal
    /// </summary>
    [DataContract]
    public partial class ElectromagneticCurrentTypeSinusoidal : OneOfCurrentExcitationCurrentType, IEquatable<ElectromagneticCurrentTypeSinusoidal>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectromagneticCurrentTypeSinusoidal" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ElectromagneticCurrentTypeSinusoidal() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectromagneticCurrentTypeSinusoidal" /> class.
        /// </summary>
        /// <param name="type">Schema name: ElectromagneticCurrentTypeSinusoidal (required) (default to &quot;CURRENT_TYPE_SINUSOIDAL&quot;).</param>
        /// <param name="frequency">frequency.</param>
        /// <param name="amplitude">amplitude.</param>
        /// <param name="offset">offset.</param>
        /// <param name="timeOffset">timeOffset.</param>
        public ElectromagneticCurrentTypeSinusoidal(string type = "CURRENT_TYPE_SINUSOIDAL", DimensionalFrequency frequency = default(DimensionalFrequency), DimensionalElectricCurrent amplitude = default(DimensionalElectricCurrent), DimensionalElectricCurrent offset = default(DimensionalElectricCurrent), DimensionalTime timeOffset = default(DimensionalTime))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for ElectromagneticCurrentTypeSinusoidal and cannot be null");
            this.Frequency = frequency;
            this.Amplitude = amplitude;
            this.Offset = offset;
            this.TimeOffset = timeOffset;
        }
        
        /// <summary>
        /// Schema name: ElectromagneticCurrentTypeSinusoidal
        /// </summary>
        /// <value>Schema name: ElectromagneticCurrentTypeSinusoidal</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Frequency
        /// </summary>
        [DataMember(Name="frequency", EmitDefaultValue=false)]
        public DimensionalFrequency Frequency { get; set; }

        /// <summary>
        /// Gets or Sets Amplitude
        /// </summary>
        [DataMember(Name="amplitude", EmitDefaultValue=false)]
        public DimensionalElectricCurrent Amplitude { get; set; }

        /// <summary>
        /// Gets or Sets Offset
        /// </summary>
        [DataMember(Name="offset", EmitDefaultValue=false)]
        public DimensionalElectricCurrent Offset { get; set; }

        /// <summary>
        /// Gets or Sets TimeOffset
        /// </summary>
        [DataMember(Name="timeOffset", EmitDefaultValue=false)]
        public DimensionalTime TimeOffset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ElectromagneticCurrentTypeSinusoidal {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  Amplitude: ").Append(Amplitude).Append("\n");
            sb.Append("  Offset: ").Append(Offset).Append("\n");
            sb.Append("  TimeOffset: ").Append(TimeOffset).Append("\n");
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
            return this.Equals(input as ElectromagneticCurrentTypeSinusoidal);
        }

        /// <summary>
        /// Returns true if ElectromagneticCurrentTypeSinusoidal instances are equal
        /// </summary>
        /// <param name="input">Instance of ElectromagneticCurrentTypeSinusoidal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ElectromagneticCurrentTypeSinusoidal input)
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
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
                ) && 
                (
                    this.Amplitude == input.Amplitude ||
                    (this.Amplitude != null &&
                    this.Amplitude.Equals(input.Amplitude))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.TimeOffset == input.TimeOffset ||
                    (this.TimeOffset != null &&
                    this.TimeOffset.Equals(input.TimeOffset))
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
                if (this.Frequency != null)
                    hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.Amplitude != null)
                    hashCode = hashCode * 59 + this.Amplitude.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.TimeOffset != null)
                    hashCode = hashCode * 59 + this.TimeOffset.GetHashCode();
                return hashCode;
            }
        }

    }

}