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
    /// AdvancedSimmetrixEmSettings
    /// </summary>
    [DataContract]
    public partial class AdvancedSimmetrixEmSettings : IEquatable<AdvancedSimmetrixEmSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedSimmetrixEmSettings" /> class.
        /// </summary>
        /// <param name="smallFeatureTolerance">smallFeatureTolerance.</param>
        public AdvancedSimmetrixEmSettings(DimensionalLength smallFeatureTolerance = default(DimensionalLength))
        {
            this.SmallFeatureTolerance = smallFeatureTolerance;
        }
        
        /// <summary>
        /// Gets or Sets SmallFeatureTolerance
        /// </summary>
        [DataMember(Name="smallFeatureTolerance", EmitDefaultValue=false)]
        public DimensionalLength SmallFeatureTolerance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdvancedSimmetrixEmSettings {\n");
            sb.Append("  SmallFeatureTolerance: ").Append(SmallFeatureTolerance).Append("\n");
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
            return this.Equals(input as AdvancedSimmetrixEmSettings);
        }

        /// <summary>
        /// Returns true if AdvancedSimmetrixEmSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of AdvancedSimmetrixEmSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdvancedSimmetrixEmSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SmallFeatureTolerance == input.SmallFeatureTolerance ||
                    (this.SmallFeatureTolerance != null &&
                    this.SmallFeatureTolerance.Equals(input.SmallFeatureTolerance))
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
                if (this.SmallFeatureTolerance != null)
                    hashCode = hashCode * 59 + this.SmallFeatureTolerance.GetHashCode();
                return hashCode;
            }
        }

    }

}
