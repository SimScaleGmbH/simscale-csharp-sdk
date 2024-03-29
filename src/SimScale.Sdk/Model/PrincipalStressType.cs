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
    /// PrincipalStressType
    /// </summary>
    [DataContract]
    public partial class PrincipalStressType : OneOfStressFieldSelectionStressType, IEquatable<PrincipalStressType>
    {
        /// <summary>
        /// Defines ComponentSelection
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ComponentSelectionEnum
        {
            /// <summary>
            /// Enum FIRSTCOMPONENT for value: FIRST_COMPONENT
            /// </summary>
            [EnumMember(Value = "FIRST_COMPONENT")]
            FIRSTCOMPONENT = 1,

            /// <summary>
            /// Enum SECONDCOMPONENT for value: SECOND_COMPONENT
            /// </summary>
            [EnumMember(Value = "SECOND_COMPONENT")]
            SECONDCOMPONENT = 2,

            /// <summary>
            /// Enum THIRDCOMPONENT for value: THIRD_COMPONENT
            /// </summary>
            [EnumMember(Value = "THIRD_COMPONENT")]
            THIRDCOMPONENT = 3,

            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            [EnumMember(Value = "ALL")]
            ALL = 4

        }

        /// <summary>
        /// Gets or Sets ComponentSelection
        /// </summary>
        [DataMember(Name="componentSelection", EmitDefaultValue=false)]
        public ComponentSelectionEnum? ComponentSelection { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrincipalStressType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PrincipalStressType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrincipalStressType" /> class.
        /// </summary>
        /// <param name="type">Schema name: PrincipalStressType (required) (default to &quot;PRINCIPAL&quot;).</param>
        /// <param name="componentSelection">componentSelection (default to ComponentSelectionEnum.ALL).</param>
        public PrincipalStressType(string type = "PRINCIPAL", ComponentSelectionEnum? componentSelection = default(ComponentSelectionEnum?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for PrincipalStressType and cannot be null");
            this.ComponentSelection = componentSelection;
        }
        
        /// <summary>
        /// Schema name: PrincipalStressType
        /// </summary>
        /// <value>Schema name: PrincipalStressType</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrincipalStressType {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ComponentSelection: ").Append(ComponentSelection).Append("\n");
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
            return this.Equals(input as PrincipalStressType);
        }

        /// <summary>
        /// Returns true if PrincipalStressType instances are equal
        /// </summary>
        /// <param name="input">Instance of PrincipalStressType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrincipalStressType input)
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
                    this.ComponentSelection == input.ComponentSelection ||
                    this.ComponentSelection.Equals(input.ComponentSelection)
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
                hashCode = hashCode * 59 + this.ComponentSelection.GetHashCode();
                return hashCode;
            }
        }

    }

}
