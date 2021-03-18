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
    /// RegionInterface
    /// </summary>
    [DataContract]
    public partial class RegionInterface : IEquatable<RegionInterface>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegionInterface" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RegionInterface() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegionInterface" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;REGION_INTERFACE&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="interfaceThermal">interfaceThermal.</param>
        /// <param name="masterTopologicalReference">masterTopologicalReference.</param>
        /// <param name="slaveTopologicalReference">slaveTopologicalReference.</param>
        /// <param name="isPartial">isPartial (default to false).</param>
        /// <param name="customModified">customModified (default to false).</param>
        public RegionInterface(string type = "REGION_INTERFACE", string name = default(string), OneOfRegionInterfaceInterfaceThermal interfaceThermal = default(OneOfRegionInterfaceInterfaceThermal), TopologicalReference masterTopologicalReference = default(TopologicalReference), TopologicalReference slaveTopologicalReference = default(TopologicalReference), bool? isPartial = default(bool?), bool? customModified = default(bool?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for RegionInterface and cannot be null");
            this.Name = name;
            this.InterfaceThermal = interfaceThermal;
            this.MasterTopologicalReference = masterTopologicalReference;
            this.SlaveTopologicalReference = slaveTopologicalReference;
            this.IsPartial = isPartial;
            this.CustomModified = customModified;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets InterfaceThermal
        /// </summary>
        [DataMember(Name="interfaceThermal", EmitDefaultValue=false)]
        public OneOfRegionInterfaceInterfaceThermal InterfaceThermal { get; set; }

        /// <summary>
        /// Gets or Sets MasterTopologicalReference
        /// </summary>
        [DataMember(Name="masterTopologicalReference", EmitDefaultValue=false)]
        public TopologicalReference MasterTopologicalReference { get; set; }

        /// <summary>
        /// Gets or Sets SlaveTopologicalReference
        /// </summary>
        [DataMember(Name="slaveTopologicalReference", EmitDefaultValue=false)]
        public TopologicalReference SlaveTopologicalReference { get; set; }

        /// <summary>
        /// Gets or Sets IsPartial
        /// </summary>
        [DataMember(Name="isPartial", EmitDefaultValue=false)]
        public bool? IsPartial { get; set; }

        /// <summary>
        /// Gets or Sets CustomModified
        /// </summary>
        [DataMember(Name="customModified", EmitDefaultValue=false)]
        public bool? CustomModified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegionInterface {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  InterfaceThermal: ").Append(InterfaceThermal).Append("\n");
            sb.Append("  MasterTopologicalReference: ").Append(MasterTopologicalReference).Append("\n");
            sb.Append("  SlaveTopologicalReference: ").Append(SlaveTopologicalReference).Append("\n");
            sb.Append("  IsPartial: ").Append(IsPartial).Append("\n");
            sb.Append("  CustomModified: ").Append(CustomModified).Append("\n");
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
            return this.Equals(input as RegionInterface);
        }

        /// <summary>
        /// Returns true if RegionInterface instances are equal
        /// </summary>
        /// <param name="input">Instance of RegionInterface to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegionInterface input)
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
                    this.InterfaceThermal == input.InterfaceThermal ||
                    (this.InterfaceThermal != null &&
                    this.InterfaceThermal.Equals(input.InterfaceThermal))
                ) && 
                (
                    this.MasterTopologicalReference == input.MasterTopologicalReference ||
                    (this.MasterTopologicalReference != null &&
                    this.MasterTopologicalReference.Equals(input.MasterTopologicalReference))
                ) && 
                (
                    this.SlaveTopologicalReference == input.SlaveTopologicalReference ||
                    (this.SlaveTopologicalReference != null &&
                    this.SlaveTopologicalReference.Equals(input.SlaveTopologicalReference))
                ) && 
                (
                    this.IsPartial == input.IsPartial ||
                    (this.IsPartial != null &&
                    this.IsPartial.Equals(input.IsPartial))
                ) && 
                (
                    this.CustomModified == input.CustomModified ||
                    (this.CustomModified != null &&
                    this.CustomModified.Equals(input.CustomModified))
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
                if (this.InterfaceThermal != null)
                    hashCode = hashCode * 59 + this.InterfaceThermal.GetHashCode();
                if (this.MasterTopologicalReference != null)
                    hashCode = hashCode * 59 + this.MasterTopologicalReference.GetHashCode();
                if (this.SlaveTopologicalReference != null)
                    hashCode = hashCode * 59 + this.SlaveTopologicalReference.GetHashCode();
                if (this.IsPartial != null)
                    hashCode = hashCode * 59 + this.IsPartial.GetHashCode();
                if (this.CustomModified != null)
                    hashCode = hashCode * 59 + this.CustomModified.GetHashCode();
                return hashCode;
            }
        }

    }

}