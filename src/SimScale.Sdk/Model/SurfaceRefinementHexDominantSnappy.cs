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
    /// A &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/meshing/hex-dominant/#surface-refinement&#39; target&#x3D;&#39;_blank&#39;&gt;&lt;b&gt;surface refinement&lt;/b&gt;&lt;/a&gt; can be used to refine the mesh near the surfaces of assigned faces and/or solids. A surface refinement can also be used to create a &lt;u&gt;cell zone&lt;/u&gt;.
    /// </summary>
    [DataContract]
    public partial class SurfaceRefinementHexDominantSnappy : OneOfHexDominantSnappyRefinements, IEquatable<SurfaceRefinementHexDominantSnappy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceRefinementHexDominantSnappy" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SurfaceRefinementHexDominantSnappy() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SurfaceRefinementHexDominantSnappy" /> class.
        /// </summary>
        /// <param name="type">A &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/meshing/hex-dominant/#surface-refinement&#39; target&#x3D;&#39;_blank&#39;&gt;&lt;b&gt;surface refinement&lt;/b&gt;&lt;/a&gt; can be used to refine the mesh near the surfaces of assigned faces and/or solids. A surface refinement can also be used to create a &lt;u&gt;cell zone&lt;/u&gt;.  Schema name: SurfaceRefinementHexDominantSnappy (required) (default to &quot;SURFACE_HEX_DOMINANT_SNAPPY_V3&quot;).</param>
        /// <param name="name">name (default to &quot;Surface refinement&quot;).</param>
        /// <param name="minLength">minLength.</param>
        /// <param name="maxLength">maxLength.</param>
        /// <param name="cellZone">cellZone.</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        public SurfaceRefinementHexDominantSnappy(string type = "SURFACE_HEX_DOMINANT_SNAPPY_V3", string name = default(string), DimensionalLength minLength = default(DimensionalLength), DimensionalLength maxLength = default(DimensionalLength), OneOfSurfaceRefinementHexDominantSnappyCellZone cellZone = default(OneOfSurfaceRefinementHexDominantSnappyCellZone), TopologicalReference topologicalReference = default(TopologicalReference))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for SurfaceRefinementHexDominantSnappy and cannot be null");
            this.Name = name;
            this.MinLength = minLength;
            this.MaxLength = maxLength;
            this.CellZone = cellZone;
            this.TopologicalReference = topologicalReference;
        }
        
        /// <summary>
        /// A &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/meshing/hex-dominant/#surface-refinement&#39; target&#x3D;&#39;_blank&#39;&gt;&lt;b&gt;surface refinement&lt;/b&gt;&lt;/a&gt; can be used to refine the mesh near the surfaces of assigned faces and/or solids. A surface refinement can also be used to create a &lt;u&gt;cell zone&lt;/u&gt;.  Schema name: SurfaceRefinementHexDominantSnappy
        /// </summary>
        /// <value>A &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/meshing/hex-dominant/#surface-refinement&#39; target&#x3D;&#39;_blank&#39;&gt;&lt;b&gt;surface refinement&lt;/b&gt;&lt;/a&gt; can be used to refine the mesh near the surfaces of assigned faces and/or solids. A surface refinement can also be used to create a &lt;u&gt;cell zone&lt;/u&gt;.  Schema name: SurfaceRefinementHexDominantSnappy</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets MinLength
        /// </summary>
        [DataMember(Name="minLength", EmitDefaultValue=false)]
        public DimensionalLength MinLength { get; set; }

        /// <summary>
        /// Gets or Sets MaxLength
        /// </summary>
        [DataMember(Name="maxLength", EmitDefaultValue=false)]
        public DimensionalLength MaxLength { get; set; }

        /// <summary>
        /// Gets or Sets CellZone
        /// </summary>
        [DataMember(Name="cellZone", EmitDefaultValue=false)]
        public OneOfSurfaceRefinementHexDominantSnappyCellZone CellZone { get; set; }

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
            sb.Append("class SurfaceRefinementHexDominantSnappy {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MinLength: ").Append(MinLength).Append("\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  CellZone: ").Append(CellZone).Append("\n");
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
            return this.Equals(input as SurfaceRefinementHexDominantSnappy);
        }

        /// <summary>
        /// Returns true if SurfaceRefinementHexDominantSnappy instances are equal
        /// </summary>
        /// <param name="input">Instance of SurfaceRefinementHexDominantSnappy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SurfaceRefinementHexDominantSnappy input)
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
                    this.MinLength == input.MinLength ||
                    (this.MinLength != null &&
                    this.MinLength.Equals(input.MinLength))
                ) && 
                (
                    this.MaxLength == input.MaxLength ||
                    (this.MaxLength != null &&
                    this.MaxLength.Equals(input.MaxLength))
                ) && 
                (
                    this.CellZone == input.CellZone ||
                    (this.CellZone != null &&
                    this.CellZone.Equals(input.CellZone))
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
                if (this.MinLength != null)
                    hashCode = hashCode * 59 + this.MinLength.GetHashCode();
                if (this.MaxLength != null)
                    hashCode = hashCode * 59 + this.MaxLength.GetHashCode();
                if (this.CellZone != null)
                    hashCode = hashCode * 59 + this.CellZone.GetHashCode();
                if (this.TopologicalReference != null)
                    hashCode = hashCode * 59 + this.TopologicalReference.GetHashCode();
                return hashCode;
            }
        }

    }

}
