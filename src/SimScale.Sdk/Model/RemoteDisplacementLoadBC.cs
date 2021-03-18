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
    /// This boundary condition restrains the displacement of a face or edge relative to a specified remote point. Therefore the assignment is connected to the remote point with RBE3 (deformable) or MPC (undeformable) conditions and the defined constraints are applied to the remote point.&lt;br /&gt;&lt;br /&gt;Important remarks: &lt;br /&gt;&lt;ul&gt;&lt;li&gt;As the assignments are connected to the remote point, additional constraints on these nodes may lead to overconstrained systems.&lt;/li&gt;&lt;li&gt;If the number of nodes of the assigment is large (&gt;1000&gt; it is recommended to use the &lt;b&gt;MUMPS&lt;/b&gt; or &lt;b&gt;PETSC&lt;/b&gt; solver.&lt;/li&gt;&lt;i&gt;This boundary condition is only valid for small rotations. For large rotations, please use &lt;b&gt;Rotating motion&lt;/b&gt; boundary conditions.&lt;/i&gt;&lt;/ul&gt; 
    /// </summary>
    [DataContract]
    public partial class RemoteDisplacementLoadBC : OneOfDynamicAnalysisBoundaryConditions, OneOfFrequencyAnalysisBoundaryConditions, OneOfHarmonicAnalysisBoundaryConditions, OneOfStaticAnalysisBoundaryConditions, OneOfThermalMechanicalBoundaryConditions, IEquatable<RemoteDisplacementLoadBC>
    {
        /// <summary>
        /// &lt;p&gt;Choose the deformation behavior of the assigned entity. If &lt;b&gt;deformable&lt;/b&gt; is selected, the entitiy is allowed to deform, selecting &lt;b&gt;undeformable&lt;/b&gt; leads to a rigid entity.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Choose the deformation behavior of the assigned entity. If &lt;b&gt;deformable&lt;/b&gt; is selected, the entitiy is allowed to deform, selecting &lt;b&gt;undeformable&lt;/b&gt; leads to a rigid entity.&lt;/p&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeformationBehaviorEnum
        {
            /// <summary>
            /// Enum DEFORMABLE for value: DEFORMABLE
            /// </summary>
            [EnumMember(Value = "DEFORMABLE")]
            DEFORMABLE = 1,

            /// <summary>
            /// Enum UNDEFORMABLE for value: UNDEFORMABLE
            /// </summary>
            [EnumMember(Value = "UNDEFORMABLE")]
            UNDEFORMABLE = 2

        }

        /// <summary>
        /// &lt;p&gt;Choose the deformation behavior of the assigned entity. If &lt;b&gt;deformable&lt;/b&gt; is selected, the entitiy is allowed to deform, selecting &lt;b&gt;undeformable&lt;/b&gt; leads to a rigid entity.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Choose the deformation behavior of the assigned entity. If &lt;b&gt;deformable&lt;/b&gt; is selected, the entitiy is allowed to deform, selecting &lt;b&gt;undeformable&lt;/b&gt; leads to a rigid entity.&lt;/p&gt;</value>
        [DataMember(Name="deformationBehavior", EmitDefaultValue=false)]
        public DeformationBehaviorEnum? DeformationBehavior { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteDisplacementLoadBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RemoteDisplacementLoadBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteDisplacementLoadBC" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;REMOTE_DISPLACEMENT_LOAD&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="displacement">displacement.</param>
        /// <param name="rotation">rotation.</param>
        /// <param name="externalPoint">externalPoint.</param>
        /// <param name="deformationBehavior">&lt;p&gt;Choose the deformation behavior of the assigned entity. If &lt;b&gt;deformable&lt;/b&gt; is selected, the entitiy is allowed to deform, selecting &lt;b&gt;undeformable&lt;/b&gt; leads to a rigid entity.&lt;/p&gt; (default to DeformationBehaviorEnum.DEFORMABLE).</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        public RemoteDisplacementLoadBC(string type = "REMOTE_DISPLACEMENT_LOAD", string name = default(string), DimensionalPartialVectorFunctionLength displacement = default(DimensionalPartialVectorFunctionLength), DimensionalPartialVectorFunctionAngle rotation = default(DimensionalPartialVectorFunctionAngle), DimensionalVectorLength externalPoint = default(DimensionalVectorLength), DeformationBehaviorEnum? deformationBehavior = default(DeformationBehaviorEnum?), TopologicalReference topologicalReference = default(TopologicalReference))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for RemoteDisplacementLoadBC and cannot be null");
            this.Name = name;
            this.Displacement = displacement;
            this.Rotation = rotation;
            this.ExternalPoint = externalPoint;
            this.DeformationBehavior = deformationBehavior;
            this.TopologicalReference = topologicalReference;
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
        /// Gets or Sets Displacement
        /// </summary>
        [DataMember(Name="displacement", EmitDefaultValue=false)]
        public DimensionalPartialVectorFunctionLength Displacement { get; set; }

        /// <summary>
        /// Gets or Sets Rotation
        /// </summary>
        [DataMember(Name="rotation", EmitDefaultValue=false)]
        public DimensionalPartialVectorFunctionAngle Rotation { get; set; }

        /// <summary>
        /// Gets or Sets ExternalPoint
        /// </summary>
        [DataMember(Name="externalPoint", EmitDefaultValue=false)]
        public DimensionalVectorLength ExternalPoint { get; set; }

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
            sb.Append("class RemoteDisplacementLoadBC {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Displacement: ").Append(Displacement).Append("\n");
            sb.Append("  Rotation: ").Append(Rotation).Append("\n");
            sb.Append("  ExternalPoint: ").Append(ExternalPoint).Append("\n");
            sb.Append("  DeformationBehavior: ").Append(DeformationBehavior).Append("\n");
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
            return this.Equals(input as RemoteDisplacementLoadBC);
        }

        /// <summary>
        /// Returns true if RemoteDisplacementLoadBC instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoteDisplacementLoadBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoteDisplacementLoadBC input)
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
                    this.Displacement == input.Displacement ||
                    (this.Displacement != null &&
                    this.Displacement.Equals(input.Displacement))
                ) && 
                (
                    this.Rotation == input.Rotation ||
                    (this.Rotation != null &&
                    this.Rotation.Equals(input.Rotation))
                ) && 
                (
                    this.ExternalPoint == input.ExternalPoint ||
                    (this.ExternalPoint != null &&
                    this.ExternalPoint.Equals(input.ExternalPoint))
                ) && 
                (
                    this.DeformationBehavior == input.DeformationBehavior ||
                    this.DeformationBehavior.Equals(input.DeformationBehavior)
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
                if (this.Displacement != null)
                    hashCode = hashCode * 59 + this.Displacement.GetHashCode();
                if (this.Rotation != null)
                    hashCode = hashCode * 59 + this.Rotation.GetHashCode();
                if (this.ExternalPoint != null)
                    hashCode = hashCode * 59 + this.ExternalPoint.GetHashCode();
                hashCode = hashCode * 59 + this.DeformationBehavior.GetHashCode();
                if (this.TopologicalReference != null)
                    hashCode = hashCode * 59 + this.TopologicalReference.GetHashCode();
                return hashCode;
            }
        }

    }

}