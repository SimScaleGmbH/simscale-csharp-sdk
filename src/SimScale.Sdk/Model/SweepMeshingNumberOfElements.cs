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
    /// SweepMeshingNumberOfElements
    /// </summary>
    [DataContract]
    public partial class SweepMeshingNumberOfElements : OneOfSimmetrixExtrusionMeshRefinementSizingType, OneOfSimmetrixSweptMeshRefinementSizingType, OneOfSimmetrixThinSectionMeshRefinementSizingType, IEquatable<SweepMeshingNumberOfElements>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SweepMeshingNumberOfElements" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SweepMeshingNumberOfElements() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SweepMeshingNumberOfElements" /> class.
        /// </summary>
        /// <param name="type">Schema name: SweepMeshingNumberOfElements (required) (default to &quot;SWEEP_MESHING_NUMBER_OF_ELEMENTS&quot;).</param>
        /// <param name="numberOfElements">numberOfElements (default to 10).</param>
        public SweepMeshingNumberOfElements(string type = "SWEEP_MESHING_NUMBER_OF_ELEMENTS", int? numberOfElements = default(int?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for SweepMeshingNumberOfElements and cannot be null");
            this.NumberOfElements = numberOfElements;
        }
        
        /// <summary>
        /// Schema name: SweepMeshingNumberOfElements
        /// </summary>
        /// <value>Schema name: SweepMeshingNumberOfElements</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfElements
        /// </summary>
        [DataMember(Name="numberOfElements", EmitDefaultValue=false)]
        public int? NumberOfElements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SweepMeshingNumberOfElements {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  NumberOfElements: ").Append(NumberOfElements).Append("\n");
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
            return this.Equals(input as SweepMeshingNumberOfElements);
        }

        /// <summary>
        /// Returns true if SweepMeshingNumberOfElements instances are equal
        /// </summary>
        /// <param name="input">Instance of SweepMeshingNumberOfElements to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SweepMeshingNumberOfElements input)
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
                    this.NumberOfElements == input.NumberOfElements ||
                    (this.NumberOfElements != null &&
                    this.NumberOfElements.Equals(input.NumberOfElements))
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
                if (this.NumberOfElements != null)
                    hashCode = hashCode * 59 + this.NumberOfElements.GetHashCode();
                return hashCode;
            }
        }

    }

}
