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
    /// MarcForceFieldSelection
    /// </summary>
    [DataContract]
    public partial class MarcForceFieldSelection : IEquatable<MarcForceFieldSelection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarcForceFieldSelection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MarcForceFieldSelection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MarcForceFieldSelection" /> class.
        /// </summary>
        /// <param name="type">Schema name: MarcForceFieldSelection (required) (default to &quot;FORCE&quot;).</param>
        /// <param name="forceType">forceType.</param>
        public MarcForceFieldSelection(string type = "FORCE", OneOfMarcForceFieldSelectionForceType forceType = default(OneOfMarcForceFieldSelectionForceType))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for MarcForceFieldSelection and cannot be null");
            this.ForceType = forceType;
        }
        
        /// <summary>
        /// Schema name: MarcForceFieldSelection
        /// </summary>
        /// <value>Schema name: MarcForceFieldSelection</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets ForceType
        /// </summary>
        [DataMember(Name="forceType", EmitDefaultValue=false)]
        public OneOfMarcForceFieldSelectionForceType ForceType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarcForceFieldSelection {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ForceType: ").Append(ForceType).Append("\n");
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
            return this.Equals(input as MarcForceFieldSelection);
        }

        /// <summary>
        /// Returns true if MarcForceFieldSelection instances are equal
        /// </summary>
        /// <param name="input">Instance of MarcForceFieldSelection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarcForceFieldSelection input)
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
                    this.ForceType == input.ForceType ||
                    (this.ForceType != null &&
                    this.ForceType.Equals(input.ForceType))
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
                if (this.ForceType != null)
                    hashCode = hashCode * 59 + this.ForceType.GetHashCode();
                return hashCode;
            }
        }

    }

}
