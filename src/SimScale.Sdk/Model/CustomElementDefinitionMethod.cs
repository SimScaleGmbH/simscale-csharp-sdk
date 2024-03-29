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
    /// CustomElementDefinitionMethod
    /// </summary>
    [DataContract]
    public partial class CustomElementDefinitionMethod : OneOfElementTechnologyDefinitionMethod, IEquatable<CustomElementDefinitionMethod>
    {
        /// <summary>
        /// Defines MechanicalMeshElementOrder
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MechanicalMeshElementOrderEnum
        {
            /// <summary>
            /// Enum FIRST for value: FIRST
            /// </summary>
            [EnumMember(Value = "FIRST")]
            FIRST = 1,

            /// <summary>
            /// Enum SECOND for value: SECOND
            /// </summary>
            [EnumMember(Value = "SECOND")]
            SECOND = 2

        }

        /// <summary>
        /// Gets or Sets MechanicalMeshElementOrder
        /// </summary>
        [DataMember(Name="mechanicalMeshElementOrder", EmitDefaultValue=false)]
        public MechanicalMeshElementOrderEnum? MechanicalMeshElementOrder { get; set; }
        /// <summary>
        /// Defines ThermalMeshElementOrder
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ThermalMeshElementOrderEnum
        {
            /// <summary>
            /// Enum FIRST for value: FIRST
            /// </summary>
            [EnumMember(Value = "FIRST")]
            FIRST = 1,

            /// <summary>
            /// Enum SECOND for value: SECOND
            /// </summary>
            [EnumMember(Value = "SECOND")]
            SECOND = 2

        }

        /// <summary>
        /// Gets or Sets ThermalMeshElementOrder
        /// </summary>
        [DataMember(Name="thermalMeshElementOrder", EmitDefaultValue=false)]
        public ThermalMeshElementOrderEnum? ThermalMeshElementOrder { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomElementDefinitionMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomElementDefinitionMethod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomElementDefinitionMethod" /> class.
        /// </summary>
        /// <param name="type">Schema name: CustomElementDefinitionMethod (required) (default to &quot;CUSTOM&quot;).</param>
        /// <param name="mechanicalMeshElementOrder">mechanicalMeshElementOrder.</param>
        /// <param name="thermalMeshElementOrder">thermalMeshElementOrder (default to ThermalMeshElementOrderEnum.FIRST).</param>
        /// <param name="reducedIntegration">reducedIntegration (default to false).</param>
        /// <param name="lumpedMass">lumpedMass (default to false).</param>
        /// <param name="definitions">definitions.</param>
        public CustomElementDefinitionMethod(string type = "CUSTOM", MechanicalMeshElementOrderEnum? mechanicalMeshElementOrder = default(MechanicalMeshElementOrderEnum?), ThermalMeshElementOrderEnum? thermalMeshElementOrder = default(ThermalMeshElementOrderEnum?), bool? reducedIntegration = default(bool?), bool? lumpedMass = default(bool?), List<ElementTechnologyDefinition> definitions = default(List<ElementTechnologyDefinition>))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for CustomElementDefinitionMethod and cannot be null");
            this.MechanicalMeshElementOrder = mechanicalMeshElementOrder;
            this.ThermalMeshElementOrder = thermalMeshElementOrder;
            this.ReducedIntegration = reducedIntegration;
            this.LumpedMass = lumpedMass;
            this.Definitions = definitions;
        }
        
        /// <summary>
        /// Schema name: CustomElementDefinitionMethod
        /// </summary>
        /// <value>Schema name: CustomElementDefinitionMethod</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets ReducedIntegration
        /// </summary>
        [DataMember(Name="reducedIntegration", EmitDefaultValue=false)]
        public bool? ReducedIntegration { get; set; }

        /// <summary>
        /// Gets or Sets LumpedMass
        /// </summary>
        [DataMember(Name="lumpedMass", EmitDefaultValue=false)]
        public bool? LumpedMass { get; set; }

        /// <summary>
        /// Gets or Sets Definitions
        /// </summary>
        [DataMember(Name="definitions", EmitDefaultValue=false)]
        public List<ElementTechnologyDefinition> Definitions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomElementDefinitionMethod {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MechanicalMeshElementOrder: ").Append(MechanicalMeshElementOrder).Append("\n");
            sb.Append("  ThermalMeshElementOrder: ").Append(ThermalMeshElementOrder).Append("\n");
            sb.Append("  ReducedIntegration: ").Append(ReducedIntegration).Append("\n");
            sb.Append("  LumpedMass: ").Append(LumpedMass).Append("\n");
            sb.Append("  Definitions: ").Append(Definitions).Append("\n");
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
            return this.Equals(input as CustomElementDefinitionMethod);
        }

        /// <summary>
        /// Returns true if CustomElementDefinitionMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomElementDefinitionMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomElementDefinitionMethod input)
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
                    this.MechanicalMeshElementOrder == input.MechanicalMeshElementOrder ||
                    this.MechanicalMeshElementOrder.Equals(input.MechanicalMeshElementOrder)
                ) && 
                (
                    this.ThermalMeshElementOrder == input.ThermalMeshElementOrder ||
                    this.ThermalMeshElementOrder.Equals(input.ThermalMeshElementOrder)
                ) && 
                (
                    this.ReducedIntegration == input.ReducedIntegration ||
                    (this.ReducedIntegration != null &&
                    this.ReducedIntegration.Equals(input.ReducedIntegration))
                ) && 
                (
                    this.LumpedMass == input.LumpedMass ||
                    (this.LumpedMass != null &&
                    this.LumpedMass.Equals(input.LumpedMass))
                ) && 
                (
                    this.Definitions == input.Definitions ||
                    this.Definitions != null &&
                    input.Definitions != null &&
                    this.Definitions.SequenceEqual(input.Definitions)
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
                hashCode = hashCode * 59 + this.MechanicalMeshElementOrder.GetHashCode();
                hashCode = hashCode * 59 + this.ThermalMeshElementOrder.GetHashCode();
                if (this.ReducedIntegration != null)
                    hashCode = hashCode * 59 + this.ReducedIntegration.GetHashCode();
                if (this.LumpedMass != null)
                    hashCode = hashCode * 59 + this.LumpedMass.GetHashCode();
                if (this.Definitions != null)
                    hashCode = hashCode * 59 + this.Definitions.GetHashCode();
                return hashCode;
            }
        }

    }

}
