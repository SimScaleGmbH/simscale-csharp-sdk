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
    /// TemporalResponseResultControlItem
    /// </summary>
    [DataContract]
    public partial class TemporalResponseResultControlItem : OneOfSolidResultControlPointData, IEquatable<TemporalResponseResultControlItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemporalResponseResultControlItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TemporalResponseResultControlItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemporalResponseResultControlItem" /> class.
        /// </summary>
        /// <param name="type">Schema name: TemporalResponseResultControlItem (required) (default to &quot;TEMPORAL_RESPONSE&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="fieldSelection">fieldSelection.</param>
        /// <param name="geometryPrimitiveUuids">geometryPrimitiveUuids.</param>
        public TemporalResponseResultControlItem(string type = "TEMPORAL_RESPONSE", string name = default(string), OneOfTemporalResponseResultControlItemFieldSelection fieldSelection = default(OneOfTemporalResponseResultControlItemFieldSelection), List<Guid?> geometryPrimitiveUuids = default(List<Guid?>))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for TemporalResponseResultControlItem and cannot be null");
            this.Name = name;
            this.FieldSelection = fieldSelection;
            this.GeometryPrimitiveUuids = geometryPrimitiveUuids;
        }
        
        /// <summary>
        /// Schema name: TemporalResponseResultControlItem
        /// </summary>
        /// <value>Schema name: TemporalResponseResultControlItem</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets FieldSelection
        /// </summary>
        [DataMember(Name="fieldSelection", EmitDefaultValue=false)]
        public OneOfTemporalResponseResultControlItemFieldSelection FieldSelection { get; set; }

        /// <summary>
        /// Gets or Sets GeometryPrimitiveUuids
        /// </summary>
        [DataMember(Name="geometryPrimitiveUuids", EmitDefaultValue=false)]
        public List<Guid?> GeometryPrimitiveUuids { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemporalResponseResultControlItem {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FieldSelection: ").Append(FieldSelection).Append("\n");
            sb.Append("  GeometryPrimitiveUuids: ").Append(GeometryPrimitiveUuids).Append("\n");
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
            return this.Equals(input as TemporalResponseResultControlItem);
        }

        /// <summary>
        /// Returns true if TemporalResponseResultControlItem instances are equal
        /// </summary>
        /// <param name="input">Instance of TemporalResponseResultControlItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemporalResponseResultControlItem input)
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
                    this.FieldSelection == input.FieldSelection ||
                    (this.FieldSelection != null &&
                    this.FieldSelection.Equals(input.FieldSelection))
                ) && 
                (
                    this.GeometryPrimitiveUuids == input.GeometryPrimitiveUuids ||
                    this.GeometryPrimitiveUuids != null &&
                    input.GeometryPrimitiveUuids != null &&
                    this.GeometryPrimitiveUuids.SequenceEqual(input.GeometryPrimitiveUuids)
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
                if (this.FieldSelection != null)
                    hashCode = hashCode * 59 + this.FieldSelection.GetHashCode();
                if (this.GeometryPrimitiveUuids != null)
                    hashCode = hashCode * 59 + this.GeometryPrimitiveUuids.GetHashCode();
                return hashCode;
            }
        }

    }

}
