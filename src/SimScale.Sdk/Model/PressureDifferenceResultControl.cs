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
    /// PressureDifferenceResultControl
    /// </summary>
    [DataContract]
    public partial class PressureDifferenceResultControl : OneOfFluidResultControlsSurfaceData, IEquatable<PressureDifferenceResultControl>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PressureDifferenceResultControl" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PressureDifferenceResultControl() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PressureDifferenceResultControl" /> class.
        /// </summary>
        /// <param name="type">Schema name: PressureDifferenceResultControl (required) (default to &quot;PRESSURE_DIFFERENCE&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="inletFaceTopologicalReference">inletFaceTopologicalReference.</param>
        /// <param name="outletFaceTopologicalReference">outletFaceTopologicalReference.</param>
        public PressureDifferenceResultControl(string type = "PRESSURE_DIFFERENCE", string name = default(string), TopologicalReference inletFaceTopologicalReference = default(TopologicalReference), TopologicalReference outletFaceTopologicalReference = default(TopologicalReference))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for PressureDifferenceResultControl and cannot be null");
            this.Name = name;
            this.InletFaceTopologicalReference = inletFaceTopologicalReference;
            this.OutletFaceTopologicalReference = outletFaceTopologicalReference;
        }
        
        /// <summary>
        /// Schema name: PressureDifferenceResultControl
        /// </summary>
        /// <value>Schema name: PressureDifferenceResultControl</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets InletFaceTopologicalReference
        /// </summary>
        [DataMember(Name="inletFaceTopologicalReference", EmitDefaultValue=false)]
        public TopologicalReference InletFaceTopologicalReference { get; set; }

        /// <summary>
        /// Gets or Sets OutletFaceTopologicalReference
        /// </summary>
        [DataMember(Name="outletFaceTopologicalReference", EmitDefaultValue=false)]
        public TopologicalReference OutletFaceTopologicalReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PressureDifferenceResultControl {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  InletFaceTopologicalReference: ").Append(InletFaceTopologicalReference).Append("\n");
            sb.Append("  OutletFaceTopologicalReference: ").Append(OutletFaceTopologicalReference).Append("\n");
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
            return this.Equals(input as PressureDifferenceResultControl);
        }

        /// <summary>
        /// Returns true if PressureDifferenceResultControl instances are equal
        /// </summary>
        /// <param name="input">Instance of PressureDifferenceResultControl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PressureDifferenceResultControl input)
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
                    this.InletFaceTopologicalReference == input.InletFaceTopologicalReference ||
                    (this.InletFaceTopologicalReference != null &&
                    this.InletFaceTopologicalReference.Equals(input.InletFaceTopologicalReference))
                ) && 
                (
                    this.OutletFaceTopologicalReference == input.OutletFaceTopologicalReference ||
                    (this.OutletFaceTopologicalReference != null &&
                    this.OutletFaceTopologicalReference.Equals(input.OutletFaceTopologicalReference))
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
                if (this.InletFaceTopologicalReference != null)
                    hashCode = hashCode * 59 + this.InletFaceTopologicalReference.GetHashCode();
                if (this.OutletFaceTopologicalReference != null)
                    hashCode = hashCode * 59 + this.OutletFaceTopologicalReference.GetHashCode();
                return hashCode;
            }
        }

    }

}