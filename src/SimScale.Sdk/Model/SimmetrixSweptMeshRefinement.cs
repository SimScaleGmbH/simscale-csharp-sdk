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
    /// SimmetrixSweptMeshRefinement
    /// </summary>
    [DataContract]
    public partial class SimmetrixSweptMeshRefinement : OneOfSimmetrixMeshingFluidRefinements, OneOfSimmetrixMeshingSolidRefinements, IEquatable<SimmetrixSweptMeshRefinement>
    {
        /// <summary>
        /// Defines SurfaceElementType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SurfaceElementTypeEnum
        {
            /// <summary>
            /// Enum TRIANGULAR for value: TRIANGULAR
            /// </summary>
            [EnumMember(Value = "TRIANGULAR")]
            TRIANGULAR = 1,

            /// <summary>
            /// Enum QUADDOMINANT for value: QUADDOMINANT
            /// </summary>
            [EnumMember(Value = "QUADDOMINANT")]
            QUADDOMINANT = 2

        }

        /// <summary>
        /// Gets or Sets SurfaceElementType
        /// </summary>
        [DataMember(Name="surfaceElementType", EmitDefaultValue=false)]
        public SurfaceElementTypeEnum? SurfaceElementType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimmetrixSweptMeshRefinement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SimmetrixSweptMeshRefinement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimmetrixSweptMeshRefinement" /> class.
        /// </summary>
        /// <param name="type">Schema name: SimmetrixSweptMeshRefinement (required) (default to &quot;SIMMETRIX_SWEPT_MESH_REFINEMENT&quot;).</param>
        /// <param name="name">name (default to &quot;Sweep meshing refinement&quot;).</param>
        /// <param name="sizingType">sizingType.</param>
        /// <param name="surfaceElementType">surfaceElementType (default to SurfaceElementTypeEnum.TRIANGULAR).</param>
        /// <param name="specifyLocalSize">specifyLocalSize (default to false).</param>
        /// <param name="maxElementSize">maxElementSize.</param>
        /// <param name="sourceTopologicalReference">sourceTopologicalReference.</param>
        /// <param name="destinationTopologicalReference">destinationTopologicalReference.</param>
        public SimmetrixSweptMeshRefinement(string type = "SIMMETRIX_SWEPT_MESH_REFINEMENT", string name = default(string), OneOfSimmetrixSweptMeshRefinementSizingType sizingType = default(OneOfSimmetrixSweptMeshRefinementSizingType), SurfaceElementTypeEnum? surfaceElementType = default(SurfaceElementTypeEnum?), bool? specifyLocalSize = default(bool?), DimensionalLength maxElementSize = default(DimensionalLength), TopologicalReference sourceTopologicalReference = default(TopologicalReference), TopologicalReference destinationTopologicalReference = default(TopologicalReference))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for SimmetrixSweptMeshRefinement and cannot be null");
            this.Name = name;
            this.SizingType = sizingType;
            this.SurfaceElementType = surfaceElementType;
            this.SpecifyLocalSize = specifyLocalSize;
            this.MaxElementSize = maxElementSize;
            this.SourceTopologicalReference = sourceTopologicalReference;
            this.DestinationTopologicalReference = destinationTopologicalReference;
        }
        
        /// <summary>
        /// Schema name: SimmetrixSweptMeshRefinement
        /// </summary>
        /// <value>Schema name: SimmetrixSweptMeshRefinement</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SizingType
        /// </summary>
        [DataMember(Name="sizingType", EmitDefaultValue=false)]
        public OneOfSimmetrixSweptMeshRefinementSizingType SizingType { get; set; }

        /// <summary>
        /// Gets or Sets SpecifyLocalSize
        /// </summary>
        [DataMember(Name="specifyLocalSize", EmitDefaultValue=false)]
        public bool? SpecifyLocalSize { get; set; }

        /// <summary>
        /// Gets or Sets MaxElementSize
        /// </summary>
        [DataMember(Name="maxElementSize", EmitDefaultValue=false)]
        public DimensionalLength MaxElementSize { get; set; }

        /// <summary>
        /// Gets or Sets SourceTopologicalReference
        /// </summary>
        [DataMember(Name="sourceTopologicalReference", EmitDefaultValue=false)]
        public TopologicalReference SourceTopologicalReference { get; set; }

        /// <summary>
        /// Gets or Sets DestinationTopologicalReference
        /// </summary>
        [DataMember(Name="destinationTopologicalReference", EmitDefaultValue=false)]
        public TopologicalReference DestinationTopologicalReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimmetrixSweptMeshRefinement {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SizingType: ").Append(SizingType).Append("\n");
            sb.Append("  SurfaceElementType: ").Append(SurfaceElementType).Append("\n");
            sb.Append("  SpecifyLocalSize: ").Append(SpecifyLocalSize).Append("\n");
            sb.Append("  MaxElementSize: ").Append(MaxElementSize).Append("\n");
            sb.Append("  SourceTopologicalReference: ").Append(SourceTopologicalReference).Append("\n");
            sb.Append("  DestinationTopologicalReference: ").Append(DestinationTopologicalReference).Append("\n");
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
            return this.Equals(input as SimmetrixSweptMeshRefinement);
        }

        /// <summary>
        /// Returns true if SimmetrixSweptMeshRefinement instances are equal
        /// </summary>
        /// <param name="input">Instance of SimmetrixSweptMeshRefinement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimmetrixSweptMeshRefinement input)
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
                    this.SizingType == input.SizingType ||
                    (this.SizingType != null &&
                    this.SizingType.Equals(input.SizingType))
                ) && 
                (
                    this.SurfaceElementType == input.SurfaceElementType ||
                    this.SurfaceElementType.Equals(input.SurfaceElementType)
                ) && 
                (
                    this.SpecifyLocalSize == input.SpecifyLocalSize ||
                    (this.SpecifyLocalSize != null &&
                    this.SpecifyLocalSize.Equals(input.SpecifyLocalSize))
                ) && 
                (
                    this.MaxElementSize == input.MaxElementSize ||
                    (this.MaxElementSize != null &&
                    this.MaxElementSize.Equals(input.MaxElementSize))
                ) && 
                (
                    this.SourceTopologicalReference == input.SourceTopologicalReference ||
                    (this.SourceTopologicalReference != null &&
                    this.SourceTopologicalReference.Equals(input.SourceTopologicalReference))
                ) && 
                (
                    this.DestinationTopologicalReference == input.DestinationTopologicalReference ||
                    (this.DestinationTopologicalReference != null &&
                    this.DestinationTopologicalReference.Equals(input.DestinationTopologicalReference))
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
                if (this.SizingType != null)
                    hashCode = hashCode * 59 + this.SizingType.GetHashCode();
                hashCode = hashCode * 59 + this.SurfaceElementType.GetHashCode();
                if (this.SpecifyLocalSize != null)
                    hashCode = hashCode * 59 + this.SpecifyLocalSize.GetHashCode();
                if (this.MaxElementSize != null)
                    hashCode = hashCode * 59 + this.MaxElementSize.GetHashCode();
                if (this.SourceTopologicalReference != null)
                    hashCode = hashCode * 59 + this.SourceTopologicalReference.GetHashCode();
                if (this.DestinationTopologicalReference != null)
                    hashCode = hashCode * 59 + this.DestinationTopologicalReference.GetHashCode();
                return hashCode;
            }
        }

    }

}
