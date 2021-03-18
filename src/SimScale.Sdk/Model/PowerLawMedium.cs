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
    /// PowerLawMedium
    /// </summary>
    [DataContract]
    public partial class PowerLawMedium : OneOfAdvancedConceptsPorousMediums, IEquatable<PowerLawMedium>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PowerLawMedium" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PowerLawMedium() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PowerLawMedium" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;POWER_LAW&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="linearCoefficient">linearCoefficient (default to 1M).</param>
        /// <param name="exponentCoefficient">exponentCoefficient (default to 2M).</param>
        /// <param name="orientation">orientation.</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        /// <param name="geometryPrimitiveUuids">geometryPrimitiveUuids.</param>
        public PowerLawMedium(string type = "POWER_LAW", string name = default(string), decimal? linearCoefficient = default(decimal?), decimal? exponentCoefficient = default(decimal?), OneOfPowerLawMediumOrientation orientation = default(OneOfPowerLawMediumOrientation), TopologicalReference topologicalReference = default(TopologicalReference), List<Guid?> geometryPrimitiveUuids = default(List<Guid?>))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for PowerLawMedium and cannot be null");
            this.Name = name;
            this.LinearCoefficient = linearCoefficient;
            this.ExponentCoefficient = exponentCoefficient;
            this.Orientation = orientation;
            this.TopologicalReference = topologicalReference;
            this.GeometryPrimitiveUuids = geometryPrimitiveUuids;
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
        /// Gets or Sets LinearCoefficient
        /// </summary>
        [DataMember(Name="linearCoefficient", EmitDefaultValue=false)]
        public decimal? LinearCoefficient { get; set; }

        /// <summary>
        /// Gets or Sets ExponentCoefficient
        /// </summary>
        [DataMember(Name="exponentCoefficient", EmitDefaultValue=false)]
        public decimal? ExponentCoefficient { get; set; }

        /// <summary>
        /// Gets or Sets Orientation
        /// </summary>
        [DataMember(Name="orientation", EmitDefaultValue=false)]
        public OneOfPowerLawMediumOrientation Orientation { get; set; }

        /// <summary>
        /// Gets or Sets TopologicalReference
        /// </summary>
        [DataMember(Name="topologicalReference", EmitDefaultValue=false)]
        public TopologicalReference TopologicalReference { get; set; }

        /// <summary>
        /// Gets or Sets GeometryPrimitiveUuids
        /// </summary>
        [DataMember(Name="geometryPrimitiveUuids", EmitDefaultValue=false)]
        public List<Guid?> GeometryPrimitiveUuids { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PowerLawMedium {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LinearCoefficient: ").Append(LinearCoefficient).Append("\n");
            sb.Append("  ExponentCoefficient: ").Append(ExponentCoefficient).Append("\n");
            sb.Append("  Orientation: ").Append(Orientation).Append("\n");
            sb.Append("  TopologicalReference: ").Append(TopologicalReference).Append("\n");
            sb.Append("  GeometryPrimitiveUuids: ").Append(GeometryPrimitiveUuids).Append("\n");
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
            return this.Equals(input as PowerLawMedium);
        }

        /// <summary>
        /// Returns true if PowerLawMedium instances are equal
        /// </summary>
        /// <param name="input">Instance of PowerLawMedium to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PowerLawMedium input)
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
                    this.LinearCoefficient == input.LinearCoefficient ||
                    (this.LinearCoefficient != null &&
                    this.LinearCoefficient.Equals(input.LinearCoefficient))
                ) && 
                (
                    this.ExponentCoefficient == input.ExponentCoefficient ||
                    (this.ExponentCoefficient != null &&
                    this.ExponentCoefficient.Equals(input.ExponentCoefficient))
                ) && 
                (
                    this.Orientation == input.Orientation ||
                    (this.Orientation != null &&
                    this.Orientation.Equals(input.Orientation))
                ) && 
                (
                    this.TopologicalReference == input.TopologicalReference ||
                    (this.TopologicalReference != null &&
                    this.TopologicalReference.Equals(input.TopologicalReference))
                ) && 
                (
                    this.GeometryPrimitiveUuids == input.GeometryPrimitiveUuids ||
                    this.GeometryPrimitiveUuids != null &&
                    input.GeometryPrimitiveUuids != null &&
                    this.GeometryPrimitiveUuids.SequenceEqual(input.GeometryPrimitiveUuids)
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
                if (this.LinearCoefficient != null)
                    hashCode = hashCode * 59 + this.LinearCoefficient.GetHashCode();
                if (this.ExponentCoefficient != null)
                    hashCode = hashCode * 59 + this.ExponentCoefficient.GetHashCode();
                if (this.Orientation != null)
                    hashCode = hashCode * 59 + this.Orientation.GetHashCode();
                if (this.TopologicalReference != null)
                    hashCode = hashCode * 59 + this.TopologicalReference.GetHashCode();
                if (this.GeometryPrimitiveUuids != null)
                    hashCode = hashCode * 59 + this.GeometryPrimitiveUuids.GetHashCode();
                return hashCode;
            }
        }

    }

}