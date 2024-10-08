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
    /// RadiationTBC
    /// </summary>
    [DataContract]
    public partial class RadiationTBC : OneOfWallBCTemperature, IEquatable<RadiationTBC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RadiationTBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RadiationTBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RadiationTBC" /> class.
        /// </summary>
        /// <param name="type">Schema name: RadiationTBC (required) (default to &quot;RADIATIVE_HEAT_TRANSFER&quot;).</param>
        /// <param name="radiation">radiation.</param>
        public RadiationTBC(string type = "RADIATIVE_HEAT_TRANSFER", WallRadiationModel radiation = default(WallRadiationModel))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for RadiationTBC and cannot be null");
            this.Radiation = radiation;
        }
        
        /// <summary>
        /// Schema name: RadiationTBC
        /// </summary>
        /// <value>Schema name: RadiationTBC</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Radiation
        /// </summary>
        [DataMember(Name="radiation", EmitDefaultValue=false)]
        public WallRadiationModel Radiation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RadiationTBC {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Radiation: ").Append(Radiation).Append("\n");
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
            return this.Equals(input as RadiationTBC);
        }

        /// <summary>
        /// Returns true if RadiationTBC instances are equal
        /// </summary>
        /// <param name="input">Instance of RadiationTBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RadiationTBC input)
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
                    this.Radiation == input.Radiation ||
                    (this.Radiation != null &&
                    this.Radiation.Equals(input.Radiation))
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
                if (this.Radiation != null)
                    hashCode = hashCode * 59 + this.Radiation.GetHashCode();
                return hashCode;
            }
        }

    }

}
