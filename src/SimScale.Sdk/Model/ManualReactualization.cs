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
    /// ManualReactualization
    /// </summary>
    [DataContract]
    public partial class ManualReactualization : OneOfFixedPointNonLinearityResolutionGeometryReactualization, IEquatable<ManualReactualization>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManualReactualization" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ManualReactualization() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ManualReactualization" /> class.
        /// </summary>
        /// <param name="type">Schema name: ManualReactualization (required) (default to &quot;MANUAL&quot;).</param>
        /// <param name="numIterations">numIterations (default to 2).</param>
        public ManualReactualization(string type = "MANUAL", int? numIterations = default(int?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for ManualReactualization and cannot be null");
            this.NumIterations = numIterations;
        }
        
        /// <summary>
        /// Schema name: ManualReactualization
        /// </summary>
        /// <value>Schema name: ManualReactualization</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets NumIterations
        /// </summary>
        [DataMember(Name="numIterations", EmitDefaultValue=false)]
        public int? NumIterations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManualReactualization {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  NumIterations: ").Append(NumIterations).Append("\n");
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
            return this.Equals(input as ManualReactualization);
        }

        /// <summary>
        /// Returns true if ManualReactualization instances are equal
        /// </summary>
        /// <param name="input">Instance of ManualReactualization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManualReactualization input)
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
                    this.NumIterations == input.NumIterations ||
                    (this.NumIterations != null &&
                    this.NumIterations.Equals(input.NumIterations))
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
                if (this.NumIterations != null)
                    hashCode = hashCode * 59 + this.NumIterations.GetHashCode();
                return hashCode;
            }
        }

    }

}
