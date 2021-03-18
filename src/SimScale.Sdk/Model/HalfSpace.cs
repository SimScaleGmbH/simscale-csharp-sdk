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
    /// HalfSpace
    /// </summary>
    [DataContract]
    public partial class HalfSpace : GeometryPrimitive, IEquatable<HalfSpace>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HalfSpace" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HalfSpace() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HalfSpace" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;HALF_SPACE&quot;).</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="referencePoint">referencePoint.</param>
        /// <param name="normal">normal.</param>
        public HalfSpace(string type = "HALF_SPACE", Guid? id = default(Guid?), string name = default(string), DimensionalVectorLength referencePoint = default(DimensionalVectorLength), DimensionalVectorLength normal = default(DimensionalVectorLength))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for HalfSpace and cannot be null");
            this.Id = id;
            this.Name = name;
            this.ReferencePoint = referencePoint;
            this.Normal = normal;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ReferencePoint
        /// </summary>
        [DataMember(Name="referencePoint", EmitDefaultValue=false)]
        public DimensionalVectorLength ReferencePoint { get; set; }

        /// <summary>
        /// Gets or Sets Normal
        /// </summary>
        [DataMember(Name="normal", EmitDefaultValue=false)]
        public DimensionalVectorLength Normal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HalfSpace {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ReferencePoint: ").Append(ReferencePoint).Append("\n");
            sb.Append("  Normal: ").Append(Normal).Append("\n");
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
            return this.Equals(input as HalfSpace);
        }

        /// <summary>
        /// Returns true if HalfSpace instances are equal
        /// </summary>
        /// <param name="input">Instance of HalfSpace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HalfSpace input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ReferencePoint == input.ReferencePoint ||
                    (this.ReferencePoint != null &&
                    this.ReferencePoint.Equals(input.ReferencePoint))
                ) && 
                (
                    this.Normal == input.Normal ||
                    (this.Normal != null &&
                    this.Normal.Equals(input.Normal))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ReferencePoint != null)
                    hashCode = hashCode * 59 + this.ReferencePoint.GetHashCode();
                if (this.Normal != null)
                    hashCode = hashCode * 59 + this.Normal.GetHashCode();
                return hashCode;
            }
        }

    }

}