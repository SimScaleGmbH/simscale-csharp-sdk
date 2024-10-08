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
    /// CreateAiPredictionResponseAvailableFields
    /// </summary>
    [DataContract]
    public partial class CreateAiPredictionResponseAvailableFields : IEquatable<CreateAiPredictionResponseAvailableFields>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAiPredictionResponseAvailableFields" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="components">components.</param>
        public CreateAiPredictionResponseAvailableFields(string name = default(string), List<string> components = default(List<string>))
        {
            this.Name = name;
            this.Components = components;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Components
        /// </summary>
        [DataMember(Name="components", EmitDefaultValue=false)]
        public List<string> Components { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAiPredictionResponseAvailableFields {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Components: ").Append(Components).Append("\n");
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
            return this.Equals(input as CreateAiPredictionResponseAvailableFields);
        }

        /// <summary>
        /// Returns true if CreateAiPredictionResponseAvailableFields instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateAiPredictionResponseAvailableFields to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateAiPredictionResponseAvailableFields input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Components == input.Components ||
                    this.Components != null &&
                    input.Components != null &&
                    this.Components.SequenceEqual(input.Components)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Components != null)
                    hashCode = hashCode * 59 + this.Components.GetHashCode();
                return hashCode;
            }
        }

    }

}
