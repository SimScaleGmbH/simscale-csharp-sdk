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
    /// This is a boundary condition for the &lt;b&gt;displacement vector&lt;/b&gt; variable. You can define prescribed values for the displacement of the assigned groups in every coordinate direction (x,y,z) or leave it unconstrained in order to let the entity move freely. &lt;br /&gt;&lt;br /&gt;Important remarks: &lt;br /&gt;&lt;ul&gt;&lt;li&gt;Choose 0 as value in order to fix your selection.&lt;/li&gt;&lt;li&gt;Do not constrain entities in directions where a load boundary condition is applied.&lt;/li&gt;&lt;li&gt;Do not constrain entities with multiple Dirichlet boundary conditions in one direction (overconstrained).&lt;/li&gt;&lt;li&gt;Do not constrain slave entities of &lt;b&gt;Contact Constraints&lt;/b&gt; as they are constrained by the master in that direction (overconstrained).&lt;/li&gt;&lt;/ul&gt;&lt;a href&#x3D; https://www.simscale.com/docs/simulation-setup/boundary-conditions/fixed-value-boundary-condition-type/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class FixedValueBC : OneOfDynamicAnalysisBoundaryConditions, OneOfFrequencyAnalysisBoundaryConditions, OneOfHarmonicAnalysisBoundaryConditions, OneOfStaticAnalysisBoundaryConditions, OneOfThermalMechanicalBoundaryConditions, IEquatable<FixedValueBC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedValueBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FixedValueBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedValueBC" /> class.
        /// </summary>
        /// <param name="type">This is a boundary condition for the &lt;b&gt;displacement vector&lt;/b&gt; variable. You can define prescribed values for the displacement of the assigned groups in every coordinate direction (x,y,z) or leave it unconstrained in order to let the entity move freely. &lt;br /&gt;&lt;br /&gt;Important remarks: &lt;br /&gt;&lt;ul&gt;&lt;li&gt;Choose 0 as value in order to fix your selection.&lt;/li&gt;&lt;li&gt;Do not constrain entities in directions where a load boundary condition is applied.&lt;/li&gt;&lt;li&gt;Do not constrain entities with multiple Dirichlet boundary conditions in one direction (overconstrained).&lt;/li&gt;&lt;li&gt;Do not constrain slave entities of &lt;b&gt;Contact Constraints&lt;/b&gt; as they are constrained by the master in that direction (overconstrained).&lt;/li&gt;&lt;/ul&gt;&lt;a href&#x3D; https://www.simscale.com/docs/simulation-setup/boundary-conditions/fixed-value-boundary-condition-type/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.  Schema name: FixedValueBC (required) (default to &quot;FIXED_VALUE&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="displacement">displacement.</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        public FixedValueBC(string type = "FIXED_VALUE", string name = default(string), DimensionalPartialVectorFunctionLength displacement = default(DimensionalPartialVectorFunctionLength), TopologicalReference topologicalReference = default(TopologicalReference))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for FixedValueBC and cannot be null");
            this.Name = name;
            this.Displacement = displacement;
            this.TopologicalReference = topologicalReference;
        }
        
        /// <summary>
        /// This is a boundary condition for the &lt;b&gt;displacement vector&lt;/b&gt; variable. You can define prescribed values for the displacement of the assigned groups in every coordinate direction (x,y,z) or leave it unconstrained in order to let the entity move freely. &lt;br /&gt;&lt;br /&gt;Important remarks: &lt;br /&gt;&lt;ul&gt;&lt;li&gt;Choose 0 as value in order to fix your selection.&lt;/li&gt;&lt;li&gt;Do not constrain entities in directions where a load boundary condition is applied.&lt;/li&gt;&lt;li&gt;Do not constrain entities with multiple Dirichlet boundary conditions in one direction (overconstrained).&lt;/li&gt;&lt;li&gt;Do not constrain slave entities of &lt;b&gt;Contact Constraints&lt;/b&gt; as they are constrained by the master in that direction (overconstrained).&lt;/li&gt;&lt;/ul&gt;&lt;a href&#x3D; https://www.simscale.com/docs/simulation-setup/boundary-conditions/fixed-value-boundary-condition-type/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.  Schema name: FixedValueBC
        /// </summary>
        /// <value>This is a boundary condition for the &lt;b&gt;displacement vector&lt;/b&gt; variable. You can define prescribed values for the displacement of the assigned groups in every coordinate direction (x,y,z) or leave it unconstrained in order to let the entity move freely. &lt;br /&gt;&lt;br /&gt;Important remarks: &lt;br /&gt;&lt;ul&gt;&lt;li&gt;Choose 0 as value in order to fix your selection.&lt;/li&gt;&lt;li&gt;Do not constrain entities in directions where a load boundary condition is applied.&lt;/li&gt;&lt;li&gt;Do not constrain entities with multiple Dirichlet boundary conditions in one direction (overconstrained).&lt;/li&gt;&lt;li&gt;Do not constrain slave entities of &lt;b&gt;Contact Constraints&lt;/b&gt; as they are constrained by the master in that direction (overconstrained).&lt;/li&gt;&lt;/ul&gt;&lt;a href&#x3D; https://www.simscale.com/docs/simulation-setup/boundary-conditions/fixed-value-boundary-condition-type/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.  Schema name: FixedValueBC</value>
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
            sb.Append("class FixedValueBC {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Displacement: ").Append(Displacement).Append("\n");
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
            return this.Equals(input as FixedValueBC);
        }

        /// <summary>
        /// Returns true if FixedValueBC instances are equal
        /// </summary>
        /// <param name="input">Instance of FixedValueBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FixedValueBC input)
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
                if (this.TopologicalReference != null)
                    hashCode = hashCode * 59 + this.TopologicalReference.GetHashCode();
                return hashCode;
            }
        }

    }

}
