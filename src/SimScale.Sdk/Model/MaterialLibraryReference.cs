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
    /// MaterialLibraryReference
    /// </summary>
    [DataContract]
    public partial class MaterialLibraryReference : IEquatable<MaterialLibraryReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialLibraryReference" /> class.
        /// </summary>
        /// <param name="materialGroupId">materialGroupId.</param>
        /// <param name="materialId">materialId.</param>
        /// <param name="interpolationParameters">interpolationParameters.</param>
        public MaterialLibraryReference(string materialGroupId = default(string), string materialId = default(string), Dictionary<string, InterpolationParameter> interpolationParameters = default(Dictionary<string, InterpolationParameter>))
        {
            this.MaterialGroupId = materialGroupId;
            this.MaterialId = materialId;
            this.InterpolationParameters = interpolationParameters;
        }
        
        /// <summary>
        /// Gets or Sets MaterialGroupId
        /// </summary>
        [DataMember(Name="materialGroupId", EmitDefaultValue=false)]
        public string MaterialGroupId { get; set; }

        /// <summary>
        /// Gets or Sets MaterialId
        /// </summary>
        [DataMember(Name="materialId", EmitDefaultValue=false)]
        public string MaterialId { get; set; }

        /// <summary>
        /// Gets or Sets InterpolationParameters
        /// </summary>
        [DataMember(Name="interpolationParameters", EmitDefaultValue=false)]
        public Dictionary<string, InterpolationParameter> InterpolationParameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MaterialLibraryReference {\n");
            sb.Append("  MaterialGroupId: ").Append(MaterialGroupId).Append("\n");
            sb.Append("  MaterialId: ").Append(MaterialId).Append("\n");
            sb.Append("  InterpolationParameters: ").Append(InterpolationParameters).Append("\n");
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
            return this.Equals(input as MaterialLibraryReference);
        }

        /// <summary>
        /// Returns true if MaterialLibraryReference instances are equal
        /// </summary>
        /// <param name="input">Instance of MaterialLibraryReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MaterialLibraryReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaterialGroupId == input.MaterialGroupId ||
                    (this.MaterialGroupId != null &&
                    this.MaterialGroupId.Equals(input.MaterialGroupId))
                ) && 
                (
                    this.MaterialId == input.MaterialId ||
                    (this.MaterialId != null &&
                    this.MaterialId.Equals(input.MaterialId))
                ) && 
                (
                    this.InterpolationParameters == input.InterpolationParameters ||
                    this.InterpolationParameters != null &&
                    input.InterpolationParameters != null &&
                    this.InterpolationParameters.SequenceEqual(input.InterpolationParameters)
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
                if (this.MaterialGroupId != null)
                    hashCode = hashCode * 59 + this.MaterialGroupId.GetHashCode();
                if (this.MaterialId != null)
                    hashCode = hashCode * 59 + this.MaterialId.GetHashCode();
                if (this.InterpolationParameters != null)
                    hashCode = hashCode * 59 + this.InterpolationParameters.GetHashCode();
                return hashCode;
            }
        }

    }

}
