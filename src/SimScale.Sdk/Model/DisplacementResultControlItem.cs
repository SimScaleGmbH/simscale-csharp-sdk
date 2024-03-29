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
    /// DisplacementResultControlItem
    /// </summary>
    [DataContract]
    public partial class DisplacementResultControlItem : OneOfSolidResultControlSolutionFields, IEquatable<DisplacementResultControlItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplacementResultControlItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DisplacementResultControlItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DisplacementResultControlItem" /> class.
        /// </summary>
        /// <param name="type">Schema name: DisplacementResultControlItem (required) (default to &quot;DISPLACEMENT&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="displacementType">displacementType.</param>
        public DisplacementResultControlItem(string type = "DISPLACEMENT", string name = default(string), GlobalDisplacementType displacementType = default(GlobalDisplacementType))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for DisplacementResultControlItem and cannot be null");
            this.Name = name;
            this.DisplacementType = displacementType;
        }
        
        /// <summary>
        /// Schema name: DisplacementResultControlItem
        /// </summary>
        /// <value>Schema name: DisplacementResultControlItem</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DisplacementType
        /// </summary>
        [DataMember(Name="displacementType", EmitDefaultValue=false)]
        public GlobalDisplacementType DisplacementType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisplacementResultControlItem {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplacementType: ").Append(DisplacementType).Append("\n");
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
            return this.Equals(input as DisplacementResultControlItem);
        }

        /// <summary>
        /// Returns true if DisplacementResultControlItem instances are equal
        /// </summary>
        /// <param name="input">Instance of DisplacementResultControlItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisplacementResultControlItem input)
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
                    this.DisplacementType == input.DisplacementType ||
                    (this.DisplacementType != null &&
                    this.DisplacementType.Equals(input.DisplacementType))
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
                if (this.DisplacementType != null)
                    hashCode = hashCode * 59 + this.DisplacementType.GetHashCode();
                return hashCode;
            }
        }

    }

}
