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
    /// ComfortCriterionDefinitionV2
    /// </summary>
    [DataContract]
    public partial class ComfortCriterionDefinitionV2 : IEquatable<ComfortCriterionDefinitionV2>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComfortCriterionDefinitionV2" /> class.
        /// </summary>
        /// <param name="windSpeedThresholds">windSpeedThresholds.</param>
        public ComfortCriterionDefinitionV2(DimensionalFunctionSpeed windSpeedThresholds = default(DimensionalFunctionSpeed))
        {
            this.WindSpeedThresholds = windSpeedThresholds;
        }
        
        /// <summary>
        /// Gets or Sets WindSpeedThresholds
        /// </summary>
        [DataMember(Name="windSpeedThresholds", EmitDefaultValue=false)]
        public DimensionalFunctionSpeed WindSpeedThresholds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComfortCriterionDefinitionV2 {\n");
            sb.Append("  WindSpeedThresholds: ").Append(WindSpeedThresholds).Append("\n");
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
            return this.Equals(input as ComfortCriterionDefinitionV2);
        }

        /// <summary>
        /// Returns true if ComfortCriterionDefinitionV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of ComfortCriterionDefinitionV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ComfortCriterionDefinitionV2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WindSpeedThresholds == input.WindSpeedThresholds ||
                    (this.WindSpeedThresholds != null &&
                    this.WindSpeedThresholds.Equals(input.WindSpeedThresholds))
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
                if (this.WindSpeedThresholds != null)
                    hashCode = hashCode * 59 + this.WindSpeedThresholds.GetHashCode();
                return hashCode;
            }
        }

    }

}