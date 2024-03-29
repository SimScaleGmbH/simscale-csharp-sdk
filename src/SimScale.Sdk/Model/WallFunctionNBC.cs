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
    /// WallFunctionNBC
    /// </summary>
    [DataContract]
    public partial class WallFunctionNBC : OneOfCustomFluidBCNuTilda, IEquatable<WallFunctionNBC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WallFunctionNBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WallFunctionNBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WallFunctionNBC" /> class.
        /// </summary>
        /// <param name="type">Schema name: WallFunctionNBC (required) (default to &quot;WALL_FUNCTION&quot;).</param>
        public WallFunctionNBC(string type = "WALL_FUNCTION")
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for WallFunctionNBC and cannot be null");
        }
        
        /// <summary>
        /// Schema name: WallFunctionNBC
        /// </summary>
        /// <value>Schema name: WallFunctionNBC</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WallFunctionNBC {\n");
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
            return this.Equals(input as WallFunctionNBC);
        }

        /// <summary>
        /// Returns true if WallFunctionNBC instances are equal
        /// </summary>
        /// <param name="input">Instance of WallFunctionNBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WallFunctionNBC input)
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
