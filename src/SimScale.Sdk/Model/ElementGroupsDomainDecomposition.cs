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
    /// ElementGroupsDomainDecomposition
    /// </summary>
    [DataContract]
    public partial class ElementGroupsDomainDecomposition : OneOfComputingCoreDomainDecomposition, IEquatable<ElementGroupsDomainDecomposition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElementGroupsDomainDecomposition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ElementGroupsDomainDecomposition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ElementGroupsDomainDecomposition" /> class.
        /// </summary>
        /// <param name="type">Schema name: ElementGroupsDomainDecomposition (required) (default to &quot;ELEMENT_GROUPS&quot;).</param>
        /// <param name="maxElementGroupSize">maxElementGroupSize (default to 1000).</param>
        public ElementGroupsDomainDecomposition(string type = "ELEMENT_GROUPS", int? maxElementGroupSize = default(int?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for ElementGroupsDomainDecomposition and cannot be null");
            this.MaxElementGroupSize = maxElementGroupSize;
        }
        
        /// <summary>
        /// Schema name: ElementGroupsDomainDecomposition
        /// </summary>
        /// <value>Schema name: ElementGroupsDomainDecomposition</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets MaxElementGroupSize
        /// </summary>
        [DataMember(Name="maxElementGroupSize", EmitDefaultValue=false)]
        public int? MaxElementGroupSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ElementGroupsDomainDecomposition {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MaxElementGroupSize: ").Append(MaxElementGroupSize).Append("\n");
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
            return this.Equals(input as ElementGroupsDomainDecomposition);
        }

        /// <summary>
        /// Returns true if ElementGroupsDomainDecomposition instances are equal
        /// </summary>
        /// <param name="input">Instance of ElementGroupsDomainDecomposition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ElementGroupsDomainDecomposition input)
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
                    this.MaxElementGroupSize == input.MaxElementGroupSize ||
                    (this.MaxElementGroupSize != null &&
                    this.MaxElementGroupSize.Equals(input.MaxElementGroupSize))
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
                if (this.MaxElementGroupSize != null)
                    hashCode = hashCode * 59 + this.MaxElementGroupSize.GetHashCode();
                return hashCode;
            }
        }

    }

}