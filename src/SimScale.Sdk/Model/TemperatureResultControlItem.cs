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
    /// TemperatureResultControlItem
    /// </summary>
    [DataContract]
    public partial class TemperatureResultControlItem : OneOfSolidResultControlSolutionFields, IEquatable<TemperatureResultControlItem>
    {
        /// <summary>
        /// Defines TemperatureType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TemperatureTypeEnum
        {
            /// <summary>
            /// Enum FIELD for value: FIELD
            /// </summary>
            [EnumMember(Value = "FIELD")]
            FIELD = 1

        }

        /// <summary>
        /// Gets or Sets TemperatureType
        /// </summary>
        [DataMember(Name="temperatureType", EmitDefaultValue=false)]
        public TemperatureTypeEnum? TemperatureType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemperatureResultControlItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TemperatureResultControlItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemperatureResultControlItem" /> class.
        /// </summary>
        /// <param name="type">Schema name: TemperatureResultControlItem (required) (default to &quot;TEMPERATURE&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="temperatureType">temperatureType (default to TemperatureTypeEnum.FIELD).</param>
        public TemperatureResultControlItem(string type = "TEMPERATURE", string name = default(string), TemperatureTypeEnum? temperatureType = default(TemperatureTypeEnum?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for TemperatureResultControlItem and cannot be null");
            this.Name = name;
            this.TemperatureType = temperatureType;
        }
        
        /// <summary>
        /// Schema name: TemperatureResultControlItem
        /// </summary>
        /// <value>Schema name: TemperatureResultControlItem</value>
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
            sb.Append("class TemperatureResultControlItem {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TemperatureType: ").Append(TemperatureType).Append("\n");
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
            return this.Equals(input as TemperatureResultControlItem);
        }

        /// <summary>
        /// Returns true if TemperatureResultControlItem instances are equal
        /// </summary>
        /// <param name="input">Instance of TemperatureResultControlItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemperatureResultControlItem input)
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
                    this.TemperatureType == input.TemperatureType ||
                    this.TemperatureType.Equals(input.TemperatureType)
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
                hashCode = hashCode * 59 + this.TemperatureType.GetHashCode();
                return hashCode;
            }
        }

    }

}
