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
    /// FluidInterface
    /// </summary>
    [DataContract]
    public partial class FluidInterface : IEquatable<FluidInterface>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FluidInterface" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FluidInterface() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FluidInterface" /> class.
        /// </summary>
        /// <param name="type">Schema name: FluidInterface (required) (default to &quot;FLUID_INTERFACE&quot;).</param>
        /// <param name="connections">connections.</param>
        public FluidInterface(string type = "FLUID_INTERFACE", List<RegionInterface> connections = default(List<RegionInterface>))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for FluidInterface and cannot be null");
            this.Connections = connections;
        }
        
        /// <summary>
        /// Schema name: FluidInterface
        /// </summary>
        /// <value>Schema name: FluidInterface</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Connections
        /// </summary>
        [DataMember(Name="connections", EmitDefaultValue=false)]
        public List<RegionInterface> Connections { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FluidInterface {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Connections: ").Append(Connections).Append("\n");
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
            return this.Equals(input as FluidInterface);
        }

        /// <summary>
        /// Returns true if FluidInterface instances are equal
        /// </summary>
        /// <param name="input">Instance of FluidInterface to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FluidInterface input)
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
                    this.Connections == input.Connections ||
                    this.Connections != null &&
                    input.Connections != null &&
                    this.Connections.SequenceEqual(input.Connections)
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
                if (this.Connections != null)
                    hashCode = hashCode * 59 + this.Connections.GetHashCode();
                return hashCode;
            }
        }

    }

}
