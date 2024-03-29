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
    /// ContactResultControlItem
    /// </summary>
    [DataContract]
    public partial class ContactResultControlItem : OneOfSolidResultControlSolutionFields, IEquatable<ContactResultControlItem>
    {
        /// <summary>
        /// Defines ContactType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContactTypeEnum
        {
            /// <summary>
            /// Enum PRESSURE for value: PRESSURE
            /// </summary>
            [EnumMember(Value = "PRESSURE")]
            PRESSURE = 1,

            /// <summary>
            /// Enum STATE for value: STATE
            /// </summary>
            [EnumMember(Value = "STATE")]
            STATE = 2

        }

        /// <summary>
        /// Gets or Sets ContactType
        /// </summary>
        [DataMember(Name="contactType", EmitDefaultValue=false)]
        public ContactTypeEnum? ContactType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactResultControlItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactResultControlItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactResultControlItem" /> class.
        /// </summary>
        /// <param name="type">Schema name: ContactResultControlItem (required) (default to &quot;CONTACT&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="contactType">contactType (default to ContactTypeEnum.PRESSURE).</param>
        public ContactResultControlItem(string type = "CONTACT", string name = default(string), ContactTypeEnum? contactType = default(ContactTypeEnum?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for ContactResultControlItem and cannot be null");
            this.Name = name;
            this.ContactType = contactType;
        }
        
        /// <summary>
        /// Schema name: ContactResultControlItem
        /// </summary>
        /// <value>Schema name: ContactResultControlItem</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactResultControlItem {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ContactType: ").Append(ContactType).Append("\n");
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
            return this.Equals(input as ContactResultControlItem);
        }

        /// <summary>
        /// Returns true if ContactResultControlItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactResultControlItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactResultControlItem input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ContactType == input.ContactType ||
                    this.ContactType.Equals(input.ContactType)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.ContactType.GetHashCode();
                return hashCode;
            }
        }

    }

}
