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
    /// FullResolutionNBC
    /// </summary>
    [DataContract]
    public partial class FullResolutionNBC : OneOfCustomFluidBCNuTilda, IEquatable<FullResolutionNBC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FullResolutionNBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FullResolutionNBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FullResolutionNBC" /> class.
        /// </summary>
        /// <param name="type">Schema name: FullResolutionNBC (required) (default to &quot;FULL_RESOLUTION&quot;).</param>
        public FullResolutionNBC(string type = "FULL_RESOLUTION")
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for FullResolutionNBC and cannot be null");
        }
        
        /// <summary>
        /// Schema name: FullResolutionNBC
        /// </summary>
        /// <value>Schema name: FullResolutionNBC</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FullResolutionNBC {\n");
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
            return this.Equals(input as FullResolutionNBC);
        }

        /// <summary>
        /// Returns true if FullResolutionNBC instances are equal
        /// </summary>
        /// <param name="input">Instance of FullResolutionNBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FullResolutionNBC input)
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
