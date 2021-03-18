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
    /// SnapshotResultControl
    /// </summary>
    [DataContract]
    public partial class SnapshotResultControl : IEquatable<SnapshotResultControl>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotResultControl" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SnapshotResultControl() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotResultControl" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;SNAPSHOT&quot;).</param>
        /// <param name="exportFluid">When this switch is activated, simulation data of the flow-field enclosed in the assignments will be exported (default to true).</param>
        /// <param name="exportSurface">When this switch is activated, simulation data on all surfaces enclosed in the assignments will be exported (default to false).</param>
        /// <param name="geometryPrimitiveUuids">geometryPrimitiveUuids.</param>
        public SnapshotResultControl(string type = "SNAPSHOT", bool? exportFluid = default(bool?), bool? exportSurface = default(bool?), List<Guid?> geometryPrimitiveUuids = default(List<Guid?>))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for SnapshotResultControl and cannot be null");
            this.ExportFluid = exportFluid;
            this.ExportSurface = exportSurface;
            this.GeometryPrimitiveUuids = geometryPrimitiveUuids;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// When this switch is activated, simulation data of the flow-field enclosed in the assignments will be exported
        /// </summary>
        /// <value>When this switch is activated, simulation data of the flow-field enclosed in the assignments will be exported</value>
        [DataMember(Name="exportFluid", EmitDefaultValue=false)]
        public bool? ExportFluid { get; set; }

        /// <summary>
        /// When this switch is activated, simulation data on all surfaces enclosed in the assignments will be exported
        /// </summary>
        /// <value>When this switch is activated, simulation data on all surfaces enclosed in the assignments will be exported</value>
        [DataMember(Name="exportSurface", EmitDefaultValue=false)]
        public bool? ExportSurface { get; set; }

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
            sb.Append("class SnapshotResultControl {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ExportFluid: ").Append(ExportFluid).Append("\n");
            sb.Append("  ExportSurface: ").Append(ExportSurface).Append("\n");
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
            return this.Equals(input as SnapshotResultControl);
        }

        /// <summary>
        /// Returns true if SnapshotResultControl instances are equal
        /// </summary>
        /// <param name="input">Instance of SnapshotResultControl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SnapshotResultControl input)
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
                    this.ExportFluid == input.ExportFluid ||
                    (this.ExportFluid != null &&
                    this.ExportFluid.Equals(input.ExportFluid))
                ) && 
                (
                    this.ExportSurface == input.ExportSurface ||
                    (this.ExportSurface != null &&
                    this.ExportSurface.Equals(input.ExportSurface))
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
                if (this.ExportFluid != null)
                    hashCode = hashCode * 59 + this.ExportFluid.GetHashCode();
                if (this.ExportSurface != null)
                    hashCode = hashCode * 59 + this.ExportSurface.GetHashCode();
                if (this.GeometryPrimitiveUuids != null)
                    hashCode = hashCode * 59 + this.GeometryPrimitiveUuids.GetHashCode();
                return hashCode;
            }
        }

    }

}