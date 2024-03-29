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
    /// FluxHeatSource
    /// </summary>
    [DataContract]
    public partial class FluxHeatSource : OneOfTurbulentHeatFluxTBCHeatSource, IEquatable<FluxHeatSource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FluxHeatSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FluxHeatSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FluxHeatSource" /> class.
        /// </summary>
        /// <param name="type">Schema name: FluxHeatSource (required) (default to &quot;FLUX&quot;).</param>
        /// <param name="heatFlux">heatFlux.</param>
        public FluxHeatSource(string type = "FLUX", DimensionalHeatFlux heatFlux = default(DimensionalHeatFlux))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for FluxHeatSource and cannot be null");
            this.HeatFlux = heatFlux;
        }
        
        /// <summary>
        /// Schema name: FluxHeatSource
        /// </summary>
        /// <value>Schema name: FluxHeatSource</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets HeatFlux
        /// </summary>
        [DataMember(Name="heatFlux", EmitDefaultValue=false)]
        public DimensionalHeatFlux HeatFlux { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FluxHeatSource {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  HeatFlux: ").Append(HeatFlux).Append("\n");
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
            return this.Equals(input as FluxHeatSource);
        }

        /// <summary>
        /// Returns true if FluxHeatSource instances are equal
        /// </summary>
        /// <param name="input">Instance of FluxHeatSource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FluxHeatSource input)
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
                    this.HeatFlux == input.HeatFlux ||
                    (this.HeatFlux != null &&
                    this.HeatFlux.Equals(input.HeatFlux))
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
                if (this.HeatFlux != null)
                    hashCode = hashCode * 59 + this.HeatFlux.GetHashCode();
                return hashCode;
            }
        }

    }

}
