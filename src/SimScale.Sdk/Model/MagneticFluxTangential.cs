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
    /// The magnetic flux is enforced to be tangential to the boundary. This boundary is often appropriate when electric current enters or leaves the boundary.
    /// </summary>
    [DataContract]
    public partial class MagneticFluxTangential : OneOfElectromagneticAnalysisBoundaryConditions, IEquatable<MagneticFluxTangential>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MagneticFluxTangential" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MagneticFluxTangential() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MagneticFluxTangential" /> class.
        /// </summary>
        /// <param name="type">The magnetic flux is enforced to be tangential to the boundary. This boundary is often appropriate when electric current enters or leaves the boundary.  Schema name: MagneticFluxTangential (required) (default to &quot;MAGNETIC_FLUX_TANGENTIAL&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        public MagneticFluxTangential(string type = "MAGNETIC_FLUX_TANGENTIAL", string name = default(string), TopologicalReference topologicalReference = default(TopologicalReference))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for MagneticFluxTangential and cannot be null");
            this.Name = name;
            this.TopologicalReference = topologicalReference;
        }
        
        /// <summary>
        /// The magnetic flux is enforced to be tangential to the boundary. This boundary is often appropriate when electric current enters or leaves the boundary.  Schema name: MagneticFluxTangential
        /// </summary>
        /// <value>The magnetic flux is enforced to be tangential to the boundary. This boundary is often appropriate when electric current enters or leaves the boundary.  Schema name: MagneticFluxTangential</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

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
            sb.Append("class MagneticFluxTangential {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as MagneticFluxTangential);
        }

        /// <summary>
        /// Returns true if MagneticFluxTangential instances are equal
        /// </summary>
        /// <param name="input">Instance of MagneticFluxTangential to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MagneticFluxTangential input)
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
                if (this.TopologicalReference != null)
                    hashCode = hashCode * 59 + this.TopologicalReference.GetHashCode();
                return hashCode;
            }
        }

    }

}
