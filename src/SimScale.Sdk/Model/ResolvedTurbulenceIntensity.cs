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
    /// ResolvedTurbulenceIntensity
    /// </summary>
    [DataContract]
    public partial class ResolvedTurbulenceIntensity : IEquatable<ResolvedTurbulenceIntensity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResolvedTurbulenceIntensity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResolvedTurbulenceIntensity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResolvedTurbulenceIntensity" /> class.
        /// </summary>
        /// <param name="type">Schema name: ResolvedTurbulenceIntensity (required) (default to &quot;RESOLVED_TURBULENCE_INTENSITY&quot;).</param>
        public ResolvedTurbulenceIntensity(string type = "RESOLVED_TURBULENCE_INTENSITY")
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for ResolvedTurbulenceIntensity and cannot be null");
        }
        
        /// <summary>
        /// Schema name: ResolvedTurbulenceIntensity
        /// </summary>
        /// <value>Schema name: ResolvedTurbulenceIntensity</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResolvedTurbulenceIntensity {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ResolvedTurbulenceIntensity);
        }

        /// <summary>
        /// Returns true if ResolvedTurbulenceIntensity instances are equal
        /// </summary>
        /// <param name="input">Instance of ResolvedTurbulenceIntensity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResolvedTurbulenceIntensity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                return hashCode;
            }
        }

    }

}