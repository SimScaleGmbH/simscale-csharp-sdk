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
    /// HeatFlowCalculationResultControlItem
    /// </summary>
    [DataContract]
    public partial class HeatFlowCalculationResultControlItem : OneOfSolidResultControlAreaCalculation, IEquatable<HeatFlowCalculationResultControlItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HeatFlowCalculationResultControlItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HeatFlowCalculationResultControlItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HeatFlowCalculationResultControlItem" /> class.
        /// </summary>
        /// <param name="type">Schema name: HeatFlowCalculationResultControlItem (required) (default to &quot;HEAT_FLOW_CALCULATION&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        public HeatFlowCalculationResultControlItem(string type = "HEAT_FLOW_CALCULATION", string name = default(string), TopologicalReference topologicalReference = default(TopologicalReference))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for HeatFlowCalculationResultControlItem and cannot be null");
            this.Name = name;
            this.TopologicalReference = topologicalReference;
        }
        
        /// <summary>
        /// Schema name: HeatFlowCalculationResultControlItem
        /// </summary>
        /// <value>Schema name: HeatFlowCalculationResultControlItem</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets TopologicalReference
        /// </summary>
        [DataMember(Name="topologicalReference", EmitDefaultValue=false)]
        public TopologicalReference TopologicalReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HeatFlowCalculationResultControlItem {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TopologicalReference: ").Append(TopologicalReference).Append("\n");
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
            return this.Equals(input as HeatFlowCalculationResultControlItem);
        }

        /// <summary>
        /// Returns true if HeatFlowCalculationResultControlItem instances are equal
        /// </summary>
        /// <param name="input">Instance of HeatFlowCalculationResultControlItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HeatFlowCalculationResultControlItem input)
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
                    this.TopologicalReference == input.TopologicalReference ||
                    (this.TopologicalReference != null &&
                    this.TopologicalReference.Equals(input.TopologicalReference))
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
                if (this.TopologicalReference != null)
                    hashCode = hashCode * 59 + this.TopologicalReference.GetHashCode();
                return hashCode;
            }
        }

    }

}