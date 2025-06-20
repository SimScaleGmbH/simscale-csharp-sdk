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
    /// This boundary condition should be used on two faces of a system as if they are physically connected. It is required that the two faces are of same size and shape and the face elements of the mesh are congruent on both sides. Works for uploaded meshes only. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/boundary-conditions/periodic-boundary-condition/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class PeriodicBC : OneOfCompressibleBoundaryConditions, OneOfConvectiveHeatTransferBoundaryConditions, OneOfFlowDomainBoundariesXMAX, OneOfFlowDomainBoundariesXMIN, OneOfFlowDomainBoundariesYMAX, OneOfFlowDomainBoundariesYMIN, OneOfFlowDomainBoundariesZMAX, OneOfFlowDomainBoundariesZMIN, OneOfIncompressibleBoundaryConditions, OneOfMultiphaseBoundaryConditions, IEquatable<PeriodicBC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PeriodicBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PeriodicBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PeriodicBC" /> class.
        /// </summary>
        /// <param name="type">This boundary condition should be used on two faces of a system as if they are physically connected. It is required that the two faces are of same size and shape and the face elements of the mesh are congruent on both sides. Works for uploaded meshes only. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/boundary-conditions/periodic-boundary-condition/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.  Schema name: PeriodicBC (required) (default to &quot;PERIODIC&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        public PeriodicBC(string type = "PERIODIC", string name = default(string), TopologicalReference topologicalReference = default(TopologicalReference))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for PeriodicBC and cannot be null");
            this.Name = name;
            this.TopologicalReference = topologicalReference;
        }
        
        /// <summary>
        /// This boundary condition should be used on two faces of a system as if they are physically connected. It is required that the two faces are of same size and shape and the face elements of the mesh are congruent on both sides. Works for uploaded meshes only. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/boundary-conditions/periodic-boundary-condition/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.  Schema name: PeriodicBC
        /// </summary>
        /// <value>This boundary condition should be used on two faces of a system as if they are physically connected. It is required that the two faces are of same size and shape and the face elements of the mesh are congruent on both sides. Works for uploaded meshes only. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/boundary-conditions/periodic-boundary-condition/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.  Schema name: PeriodicBC</value>
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
            sb.Append("class PeriodicBC {\n");
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
            return this.Equals(input as PeriodicBC);
        }

        /// <summary>
        /// Returns true if PeriodicBC instances are equal
        /// </summary>
        /// <param name="input">Instance of PeriodicBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PeriodicBC input)
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
