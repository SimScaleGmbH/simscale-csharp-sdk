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
    /// HighResolutionSpatialScheme
    /// </summary>
    [DataContract]
    public partial class HighResolutionSpatialScheme : OneOfSpatialDiscretizationSchemesVolumeOfFluid, IEquatable<HighResolutionSpatialScheme>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HighResolutionSpatialScheme" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HighResolutionSpatialScheme() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HighResolutionSpatialScheme" /> class.
        /// </summary>
        /// <param name="type">Schema name: HighResolutionSpatialScheme (required) (default to &quot;HIGH_RESOLUTION&quot;).</param>
        public HighResolutionSpatialScheme(string type = "HIGH_RESOLUTION")
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for HighResolutionSpatialScheme and cannot be null");
        }
        
        /// <summary>
        /// Schema name: HighResolutionSpatialScheme
        /// </summary>
        /// <value>Schema name: HighResolutionSpatialScheme</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HighResolutionSpatialScheme {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as HighResolutionSpatialScheme);
        }

        /// <summary>
        /// Returns true if HighResolutionSpatialScheme instances are equal
        /// </summary>
        /// <param name="input">Instance of HighResolutionSpatialScheme to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HighResolutionSpatialScheme input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                return hashCode;
            }
        }

    }

}
