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
    /// This is a &lt;b&gt;force&lt;/b&gt; boundary condition representing an equal point force on &lt;b&gt;each node of the assignment&lt;/b&gt;. The total force applied on the assignment is calculated as the user defined forces times the number of nodes in the assignment.&lt;br /&gt;&lt;br /&gt;Important remarks: &lt;br /&gt;&lt;ul&gt;&lt;li&gt;Currently, it only works on &lt;a href&#x3D; https://www.simscale.com/docs/simulation-setup/meshing/mesh-upload/&#39; target&#x3D;&#39;_blank&#39;&gt;uploaded meshes&lt;/a&gt;&lt;/li&gt;&lt;li&gt;As the total load is depending on the number of nodes, and thus the mesh fineness, it is recommended only for loads on single nodes.&lt;/li&gt;&lt;li&gt;In most cases point loads are unphysical and distributed loads should be used instead.&lt;/li&gt;&lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class NodalLoadBC : OneOfDynamicAnalysisBoundaryConditions, OneOfHarmonicAnalysisBoundaryConditions, OneOfStaticAnalysisBoundaryConditions, OneOfThermalMechanicalBoundaryConditions, IEquatable<NodalLoadBC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodalLoadBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NodalLoadBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NodalLoadBC" /> class.
        /// </summary>
        /// <param name="type">This is a &lt;b&gt;force&lt;/b&gt; boundary condition representing an equal point force on &lt;b&gt;each node of the assignment&lt;/b&gt;. The total force applied on the assignment is calculated as the user defined forces times the number of nodes in the assignment.&lt;br /&gt;&lt;br /&gt;Important remarks: &lt;br /&gt;&lt;ul&gt;&lt;li&gt;Currently, it only works on &lt;a href&#x3D; https://www.simscale.com/docs/simulation-setup/meshing/mesh-upload/&#39; target&#x3D;&#39;_blank&#39;&gt;uploaded meshes&lt;/a&gt;&lt;/li&gt;&lt;li&gt;As the total load is depending on the number of nodes, and thus the mesh fineness, it is recommended only for loads on single nodes.&lt;/li&gt;&lt;li&gt;In most cases point loads are unphysical and distributed loads should be used instead.&lt;/li&gt;&lt;/ul&gt;  Schema name: NodalLoadBC (required) (default to &quot;NODAL_LOAD&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="force">force.</param>
        /// <param name="scaling">scaling.</param>
        /// <param name="phaseAngle">phaseAngle.</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        public NodalLoadBC(string type = "NODAL_LOAD", string name = default(string), DimensionalVectorFunctionForce force = default(DimensionalVectorFunctionForce), DimensionalFunctionDimensionless scaling = default(DimensionalFunctionDimensionless), DimensionalAngle phaseAngle = default(DimensionalAngle), TopologicalReference topologicalReference = default(TopologicalReference))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for NodalLoadBC and cannot be null");
            this.Name = name;
            this.Force = force;
            this.Scaling = scaling;
            this.PhaseAngle = phaseAngle;
            this.TopologicalReference = topologicalReference;
        }
        
        /// <summary>
        /// This is a &lt;b&gt;force&lt;/b&gt; boundary condition representing an equal point force on &lt;b&gt;each node of the assignment&lt;/b&gt;. The total force applied on the assignment is calculated as the user defined forces times the number of nodes in the assignment.&lt;br /&gt;&lt;br /&gt;Important remarks: &lt;br /&gt;&lt;ul&gt;&lt;li&gt;Currently, it only works on &lt;a href&#x3D; https://www.simscale.com/docs/simulation-setup/meshing/mesh-upload/&#39; target&#x3D;&#39;_blank&#39;&gt;uploaded meshes&lt;/a&gt;&lt;/li&gt;&lt;li&gt;As the total load is depending on the number of nodes, and thus the mesh fineness, it is recommended only for loads on single nodes.&lt;/li&gt;&lt;li&gt;In most cases point loads are unphysical and distributed loads should be used instead.&lt;/li&gt;&lt;/ul&gt;  Schema name: NodalLoadBC
        /// </summary>
        /// <value>This is a &lt;b&gt;force&lt;/b&gt; boundary condition representing an equal point force on &lt;b&gt;each node of the assignment&lt;/b&gt;. The total force applied on the assignment is calculated as the user defined forces times the number of nodes in the assignment.&lt;br /&gt;&lt;br /&gt;Important remarks: &lt;br /&gt;&lt;ul&gt;&lt;li&gt;Currently, it only works on &lt;a href&#x3D; https://www.simscale.com/docs/simulation-setup/meshing/mesh-upload/&#39; target&#x3D;&#39;_blank&#39;&gt;uploaded meshes&lt;/a&gt;&lt;/li&gt;&lt;li&gt;As the total load is depending on the number of nodes, and thus the mesh fineness, it is recommended only for loads on single nodes.&lt;/li&gt;&lt;li&gt;In most cases point loads are unphysical and distributed loads should be used instead.&lt;/li&gt;&lt;/ul&gt;  Schema name: NodalLoadBC</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Force
        /// </summary>
        [DataMember(Name="force", EmitDefaultValue=false)]
        public DimensionalVectorFunctionForce Force { get; set; }

        /// <summary>
        /// Gets or Sets Scaling
        /// </summary>
        [DataMember(Name="scaling", EmitDefaultValue=false)]
        public DimensionalFunctionDimensionless Scaling { get; set; }

        /// <summary>
        /// Gets or Sets PhaseAngle
        /// </summary>
        [DataMember(Name="phaseAngle", EmitDefaultValue=false)]
        public DimensionalAngle PhaseAngle { get; set; }

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
            sb.Append("class NodalLoadBC {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Force: ").Append(Force).Append("\n");
            sb.Append("  Scaling: ").Append(Scaling).Append("\n");
            sb.Append("  PhaseAngle: ").Append(PhaseAngle).Append("\n");
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
            return this.Equals(input as NodalLoadBC);
        }

        /// <summary>
        /// Returns true if NodalLoadBC instances are equal
        /// </summary>
        /// <param name="input">Instance of NodalLoadBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NodalLoadBC input)
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
                    this.Force == input.Force ||
                    (this.Force != null &&
                    this.Force.Equals(input.Force))
                ) && 
                (
                    this.Scaling == input.Scaling ||
                    (this.Scaling != null &&
                    this.Scaling.Equals(input.Scaling))
                ) && 
                (
                    this.PhaseAngle == input.PhaseAngle ||
                    (this.PhaseAngle != null &&
                    this.PhaseAngle.Equals(input.PhaseAngle))
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
                if (this.Force != null)
                    hashCode = hashCode * 59 + this.Force.GetHashCode();
                if (this.Scaling != null)
                    hashCode = hashCode * 59 + this.Scaling.GetHashCode();
                if (this.PhaseAngle != null)
                    hashCode = hashCode * 59 + this.PhaseAngle.GetHashCode();
                if (this.TopologicalReference != null)
                    hashCode = hashCode * 59 + this.TopologicalReference.GetHashCode();
                return hashCode;
            }
        }

    }

}
