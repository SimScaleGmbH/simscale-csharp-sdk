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
    /// Box
    /// </summary>
    [DataContract]
    public partial class Box : GeometryPrimitive, IEquatable<Box>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Box" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Box() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Box" /> class.
        /// </summary>
        /// <param name="type">Schema name: Box (required) (default to &quot;BOX&quot;).</param>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="scale">scale.</param>
        /// <param name="translation">translation.</param>
        /// <param name="rotationAxis">rotationAxis.</param>
        /// <param name="rotationAngle">rotationAngle.</param>
        public Box(string type = "BOX", Guid? id = default(Guid?), string name = default(string), DecimalVector scale = default(DecimalVector), DimensionalVectorLength translation = default(DimensionalVectorLength), DimensionalVectorLength rotationAxis = default(DimensionalVectorLength), DimensionalAngle rotationAngle = default(DimensionalAngle))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for Box and cannot be null");
            this.Id = id;
            this.Name = name;
            this.Scale = scale;
            this.Translation = translation;
            this.RotationAxis = rotationAxis;
            this.RotationAngle = rotationAngle;
        }
        
        /// <summary>
        /// Schema name: Box
        /// </summary>
        /// <value>Schema name: Box</value>
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
        /// Gets or Sets Scale
        /// </summary>
        [DataMember(Name="scale", EmitDefaultValue=false)]
        public DecimalVector Scale { get; set; }

        /// <summary>
        /// Gets or Sets Translation
        /// </summary>
        [DataMember(Name="translation", EmitDefaultValue=false)]
        public DimensionalVectorLength Translation { get; set; }

        /// <summary>
        /// Gets or Sets RotationAxis
        /// </summary>
        [DataMember(Name="rotationAxis", EmitDefaultValue=false)]
        public DimensionalVectorLength RotationAxis { get; set; }

        /// <summary>
        /// Gets or Sets RotationAngle
        /// </summary>
        [DataMember(Name="rotationAngle", EmitDefaultValue=false)]
        public DimensionalAngle RotationAngle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Box {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Scale: ").Append(Scale).Append("\n");
            sb.Append("  Translation: ").Append(Translation).Append("\n");
            sb.Append("  RotationAxis: ").Append(RotationAxis).Append("\n");
            sb.Append("  RotationAngle: ").Append(RotationAngle).Append("\n");
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
            return this.Equals(input as Box);
        }

        /// <summary>
        /// Returns true if Box instances are equal
        /// </summary>
        /// <param name="input">Instance of Box to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Box input)
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
                    this.Scale == input.Scale ||
                    (this.Scale != null &&
                    this.Scale.Equals(input.Scale))
                ) && 
                (
                    this.Translation == input.Translation ||
                    (this.Translation != null &&
                    this.Translation.Equals(input.Translation))
                ) && 
                (
                    this.RotationAxis == input.RotationAxis ||
                    (this.RotationAxis != null &&
                    this.RotationAxis.Equals(input.RotationAxis))
                ) && 
                (
                    this.RotationAngle == input.RotationAngle ||
                    (this.RotationAngle != null &&
                    this.RotationAngle.Equals(input.RotationAngle))
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
                if (this.Scale != null)
                    hashCode = hashCode * 59 + this.Scale.GetHashCode();
                if (this.Translation != null)
                    hashCode = hashCode * 59 + this.Translation.GetHashCode();
                if (this.RotationAxis != null)
                    hashCode = hashCode * 59 + this.RotationAxis.GetHashCode();
                if (this.RotationAngle != null)
                    hashCode = hashCode * 59 + this.RotationAngle.GetHashCode();
                return hashCode;
            }
        }

    }

}
