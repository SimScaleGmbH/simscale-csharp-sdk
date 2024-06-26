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
    /// HeatExchangerPerformance
    /// </summary>
    [DataContract]
    public partial class HeatExchangerPerformance : OneOfHeatExchangerSourceHeatExchangerMode, IEquatable<HeatExchangerPerformance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HeatExchangerPerformance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HeatExchangerPerformance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HeatExchangerPerformance" /> class.
        /// </summary>
        /// <param name="type">Schema name: HeatExchangerPerformance (required) (default to &quot;HEAT_EXCHANGER_PERFORMANCE&quot;).</param>
        /// <param name="refTemperature">refTemperature.</param>
        /// <param name="performance">performance.</param>
        public HeatExchangerPerformance(string type = "HEAT_EXCHANGER_PERFORMANCE", DimensionalFunctionTemperature refTemperature = default(DimensionalFunctionTemperature), DimensionalFunctionTotalThermalTransmittance performance = default(DimensionalFunctionTotalThermalTransmittance))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for HeatExchangerPerformance and cannot be null");
            this.RefTemperature = refTemperature;
            this.Performance = performance;
        }
        
        /// <summary>
        /// Schema name: HeatExchangerPerformance
        /// </summary>
        /// <value>Schema name: HeatExchangerPerformance</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets RefTemperature
        /// </summary>
        [DataMember(Name="refTemperature", EmitDefaultValue=false)]
        public DimensionalFunctionTemperature RefTemperature { get; set; }

        /// <summary>
        /// Gets or Sets Performance
        /// </summary>
        [DataMember(Name="performance", EmitDefaultValue=false)]
        public DimensionalFunctionTotalThermalTransmittance Performance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HeatExchangerPerformance {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  RefTemperature: ").Append(RefTemperature).Append("\n");
            sb.Append("  Performance: ").Append(Performance).Append("\n");
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
            return this.Equals(input as HeatExchangerPerformance);
        }

        /// <summary>
        /// Returns true if HeatExchangerPerformance instances are equal
        /// </summary>
        /// <param name="input">Instance of HeatExchangerPerformance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HeatExchangerPerformance input)
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
                    this.RefTemperature == input.RefTemperature ||
                    (this.RefTemperature != null &&
                    this.RefTemperature.Equals(input.RefTemperature))
                ) && 
                (
                    this.Performance == input.Performance ||
                    (this.Performance != null &&
                    this.Performance.Equals(input.Performance))
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
                if (this.RefTemperature != null)
                    hashCode = hashCode * 59 + this.RefTemperature.GetHashCode();
                if (this.Performance != null)
                    hashCode = hashCode * 59 + this.Performance.GetHashCode();
                return hashCode;
            }
        }

    }

}
