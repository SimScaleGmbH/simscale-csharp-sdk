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
    /// StressInitialConditionDomains
    /// </summary>
    [DataContract]
    public partial class StressInitialConditionDomains : IEquatable<StressInitialConditionDomains>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StressInitialConditionDomains" /> class.
        /// </summary>
        /// <param name="global">global.</param>
        /// <param name="subdomains">subdomains.</param>
        public StressInitialConditionDomains(StressTensorPressure global = default(StressTensorPressure), List<SubdomainStressInitialCondition> subdomains = default(List<SubdomainStressInitialCondition>))
        {
            this.Global = global;
            this.Subdomains = subdomains;
        }
        
        /// <summary>
        /// Gets or Sets Global
        /// </summary>
        [DataMember(Name="global", EmitDefaultValue=false)]
        public StressTensorPressure Global { get; set; }

        /// <summary>
        /// Gets or Sets Subdomains
        /// </summary>
        [DataMember(Name="subdomains", EmitDefaultValue=false)]
        public List<SubdomainStressInitialCondition> Subdomains { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StressInitialConditionDomains {\n");
            sb.Append("  Global: ").Append(Global).Append("\n");
            sb.Append("  Subdomains: ").Append(Subdomains).Append("\n");
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
            return this.Equals(input as StressInitialConditionDomains);
        }

        /// <summary>
        /// Returns true if StressInitialConditionDomains instances are equal
        /// </summary>
        /// <param name="input">Instance of StressInitialConditionDomains to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StressInitialConditionDomains input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Global == input.Global ||
                    (this.Global != null &&
                    this.Global.Equals(input.Global))
                ) && 
                (
                    this.Subdomains == input.Subdomains ||
                    this.Subdomains != null &&
                    input.Subdomains != null &&
                    this.Subdomains.SequenceEqual(input.Subdomains)
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
                if (this.Global != null)
                    hashCode = hashCode * 59 + this.Global.GetHashCode();
                if (this.Subdomains != null)
                    hashCode = hashCode * 59 + this.Subdomains.GetHashCode();
                return hashCode;
            }
        }

    }

}