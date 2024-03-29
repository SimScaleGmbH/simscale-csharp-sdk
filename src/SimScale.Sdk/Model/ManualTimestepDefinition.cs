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
    /// ManualTimestepDefinition
    /// </summary>
    [DataContract]
    public partial class ManualTimestepDefinition : OneOfSolidSimulationControlTimestepDefinition, IEquatable<ManualTimestepDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManualTimestepDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ManualTimestepDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ManualTimestepDefinition" /> class.
        /// </summary>
        /// <param name="type">Schema name: ManualTimestepDefinition (required) (default to &quot;MANUAL_V19&quot;).</param>
        /// <param name="simulationInterval">simulationInterval.</param>
        /// <param name="timestepLength">timestepLength.</param>
        public ManualTimestepDefinition(string type = "MANUAL_V19", DimensionalTime simulationInterval = default(DimensionalTime), RestrictedDimensionalFunctionTime timestepLength = default(RestrictedDimensionalFunctionTime))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for ManualTimestepDefinition and cannot be null");
            this.SimulationInterval = simulationInterval;
            this.TimestepLength = timestepLength;
        }
        
        /// <summary>
        /// Schema name: ManualTimestepDefinition
        /// </summary>
        /// <value>Schema name: ManualTimestepDefinition</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets SimulationInterval
        /// </summary>
        [DataMember(Name="simulationInterval", EmitDefaultValue=false)]
        public DimensionalTime SimulationInterval { get; set; }

        /// <summary>
        /// Gets or Sets TimestepLength
        /// </summary>
        [DataMember(Name="timestepLength", EmitDefaultValue=false)]
        public RestrictedDimensionalFunctionTime TimestepLength { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManualTimestepDefinition {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SimulationInterval: ").Append(SimulationInterval).Append("\n");
            sb.Append("  TimestepLength: ").Append(TimestepLength).Append("\n");
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
            return this.Equals(input as ManualTimestepDefinition);
        }

        /// <summary>
        /// Returns true if ManualTimestepDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of ManualTimestepDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManualTimestepDefinition input)
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
                    this.SimulationInterval == input.SimulationInterval ||
                    (this.SimulationInterval != null &&
                    this.SimulationInterval.Equals(input.SimulationInterval))
                ) && 
                (
                    this.TimestepLength == input.TimestepLength ||
                    (this.TimestepLength != null &&
                    this.TimestepLength.Equals(input.TimestepLength))
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
                if (this.SimulationInterval != null)
                    hashCode = hashCode * 59 + this.SimulationInterval.GetHashCode();
                if (this.TimestepLength != null)
                    hashCode = hashCode * 59 + this.TimestepLength.GetHashCode();
                return hashCode;
            }
        }

    }

}
