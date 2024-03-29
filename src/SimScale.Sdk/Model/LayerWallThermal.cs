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
    /// LayerWallThermal
    /// </summary>
    [DataContract]
    public partial class LayerWallThermal : OneOfDerivedHeatFluxWallThermal, IEquatable<LayerWallThermal>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LayerWallThermal" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LayerWallThermal() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LayerWallThermal" /> class.
        /// </summary>
        /// <param name="type">Schema name: LayerWallThermal (required) (default to &quot;CONTACT_INTERFACE_MATERIAL&quot;).</param>
        /// <param name="conductivityThicknessPairs">conductivityThicknessPairs.</param>
        public LayerWallThermal(string type = "CONTACT_INTERFACE_MATERIAL", List<ConductivityThicknessPair> conductivityThicknessPairs = default(List<ConductivityThicknessPair>))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for LayerWallThermal and cannot be null");
            this.ConductivityThicknessPairs = conductivityThicknessPairs;
        }
        
        /// <summary>
        /// Schema name: LayerWallThermal
        /// </summary>
        /// <value>Schema name: LayerWallThermal</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets ConductivityThicknessPairs
        /// </summary>
        [DataMember(Name="conductivityThicknessPairs", EmitDefaultValue=false)]
        public List<ConductivityThicknessPair> ConductivityThicknessPairs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LayerWallThermal {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ConductivityThicknessPairs: ").Append(ConductivityThicknessPairs).Append("\n");
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
            return this.Equals(input as LayerWallThermal);
        }

        /// <summary>
        /// Returns true if LayerWallThermal instances are equal
        /// </summary>
        /// <param name="input">Instance of LayerWallThermal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LayerWallThermal input)
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
                    this.ConductivityThicknessPairs == input.ConductivityThicknessPairs ||
                    this.ConductivityThicknessPairs != null &&
                    input.ConductivityThicknessPairs != null &&
                    this.ConductivityThicknessPairs.SequenceEqual(input.ConductivityThicknessPairs)
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
                if (this.ConductivityThicknessPairs != null)
                    hashCode = hashCode * 59 + this.ConductivityThicknessPairs.GetHashCode();
                return hashCode;
            }
        }

    }

}
