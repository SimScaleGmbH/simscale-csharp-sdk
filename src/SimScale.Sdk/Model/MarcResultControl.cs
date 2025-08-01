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
    /// MarcResultControl
    /// </summary>
    [DataContract]
    public partial class MarcResultControl : IEquatable<MarcResultControl>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarcResultControl" /> class.
        /// </summary>
        /// <param name="solutionFields">solutionFields.</param>
        /// <param name="areaCalculation">areaCalculation.</param>
        /// <param name="volumeCalculation">volumeCalculation.</param>
        public MarcResultControl(List<OneOfMarcResultControlSolutionFields> solutionFields = default(List<OneOfMarcResultControlSolutionFields>), List<OneOfMarcResultControlAreaCalculation> areaCalculation = default(List<OneOfMarcResultControlAreaCalculation>), List<OneOfMarcResultControlVolumeCalculation> volumeCalculation = default(List<OneOfMarcResultControlVolumeCalculation>))
        {
            this.SolutionFields = solutionFields;
            this.AreaCalculation = areaCalculation;
            this.VolumeCalculation = volumeCalculation;
        }
        
        /// <summary>
        /// Gets or Sets SolutionFields
        /// </summary>
        [DataMember(Name="solutionFields", EmitDefaultValue=false)]
        public List<OneOfMarcResultControlSolutionFields> SolutionFields { get; set; }

        /// <summary>
        /// Gets or Sets AreaCalculation
        /// </summary>
        [DataMember(Name="areaCalculation", EmitDefaultValue=false)]
        public List<OneOfMarcResultControlAreaCalculation> AreaCalculation { get; set; }

        /// <summary>
        /// Gets or Sets VolumeCalculation
        /// </summary>
        [DataMember(Name="volumeCalculation", EmitDefaultValue=false)]
        public List<OneOfMarcResultControlVolumeCalculation> VolumeCalculation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MarcResultControl {\n");
            sb.Append("  SolutionFields: ").Append(SolutionFields).Append("\n");
            sb.Append("  AreaCalculation: ").Append(AreaCalculation).Append("\n");
            sb.Append("  VolumeCalculation: ").Append(VolumeCalculation).Append("\n");
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
            return this.Equals(input as MarcResultControl);
        }

        /// <summary>
        /// Returns true if MarcResultControl instances are equal
        /// </summary>
        /// <param name="input">Instance of MarcResultControl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarcResultControl input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SolutionFields == input.SolutionFields ||
                    this.SolutionFields != null &&
                    input.SolutionFields != null &&
                    this.SolutionFields.SequenceEqual(input.SolutionFields)
                ) && 
                (
                    this.AreaCalculation == input.AreaCalculation ||
                    this.AreaCalculation != null &&
                    input.AreaCalculation != null &&
                    this.AreaCalculation.SequenceEqual(input.AreaCalculation)
                ) && 
                (
                    this.VolumeCalculation == input.VolumeCalculation ||
                    this.VolumeCalculation != null &&
                    input.VolumeCalculation != null &&
                    this.VolumeCalculation.SequenceEqual(input.VolumeCalculation)
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
                if (this.SolutionFields != null)
                    hashCode = hashCode * 59 + this.SolutionFields.GetHashCode();
                if (this.AreaCalculation != null)
                    hashCode = hashCode * 59 + this.AreaCalculation.GetHashCode();
                if (this.VolumeCalculation != null)
                    hashCode = hashCode * 59 + this.VolumeCalculation.GetHashCode();
                return hashCode;
            }
        }

    }

}
