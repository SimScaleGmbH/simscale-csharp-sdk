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
    /// Specify a constant electric potential (voltage) on a boundary or a body.
    /// </summary>
    [DataContract]
    public partial class FixedPotential : OneOfElectromagneticAnalysisBoundaryConditions, IEquatable<FixedPotential>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedPotential" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FixedPotential() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedPotential" /> class.
        /// </summary>
        /// <param name="type">Specify a constant electric potential (voltage) on a boundary or a body.  Schema name: FixedPotential (required) (default to &quot;FIXED_POTENTIAL&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="potential">potential.</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        public FixedPotential(string type = "FIXED_POTENTIAL", string name = default(string), DimensionalElectricPotential potential = default(DimensionalElectricPotential), TopologicalReference topologicalReference = default(TopologicalReference))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for FixedPotential and cannot be null");
            this.Name = name;
            this.Potential = potential;
            this.TopologicalReference = topologicalReference;
        }
        
        /// <summary>
        /// Specify a constant electric potential (voltage) on a boundary or a body.  Schema name: FixedPotential
        /// </summary>
        /// <value>Specify a constant electric potential (voltage) on a boundary or a body.  Schema name: FixedPotential</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Potential
        /// </summary>
        [DataMember(Name="potential", EmitDefaultValue=false)]
        public DimensionalElectricPotential Potential { get; set; }

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
            sb.Append("class FixedPotential {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Potential: ").Append(Potential).Append("\n");
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
            return this.Equals(input as FixedPotential);
        }

        /// <summary>
        /// Returns true if FixedPotential instances are equal
        /// </summary>
        /// <param name="input">Instance of FixedPotential to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FixedPotential input)
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
                    this.Potential == input.Potential ||
                    (this.Potential != null &&
                    this.Potential.Equals(input.Potential))
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
                if (this.Potential != null)
                    hashCode = hashCode * 59 + this.Potential.GetHashCode();
                if (this.TopologicalReference != null)
                    hashCode = hashCode * 59 + this.TopologicalReference.GetHashCode();
                return hashCode;
            }
        }

    }

}
