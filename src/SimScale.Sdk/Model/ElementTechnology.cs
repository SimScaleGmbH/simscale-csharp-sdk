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
    /// ElementTechnology
    /// </summary>
    [DataContract]
    public partial class ElementTechnology : IEquatable<ElementTechnology>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElementTechnology" /> class.
        /// </summary>
        /// <param name="definitionMethod">definitionMethod.</param>
        public ElementTechnology(OneOfElementTechnologyDefinitionMethod definitionMethod = default(OneOfElementTechnologyDefinitionMethod))
        {
            this.DefinitionMethod = definitionMethod;
        }
        
        /// <summary>
        /// Gets or Sets DefinitionMethod
        /// </summary>
        [DataMember(Name="definitionMethod", EmitDefaultValue=false)]
        public OneOfElementTechnologyDefinitionMethod DefinitionMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ElementTechnology {\n");
            sb.Append("  DefinitionMethod: ").Append(DefinitionMethod).Append("\n");
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
            return this.Equals(input as ElementTechnology);
        }

        /// <summary>
        /// Returns true if ElementTechnology instances are equal
        /// </summary>
        /// <param name="input">Instance of ElementTechnology to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ElementTechnology input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefinitionMethod == input.DefinitionMethod ||
                    (this.DefinitionMethod != null &&
                    this.DefinitionMethod.Equals(input.DefinitionMethod))
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
                if (this.DefinitionMethod != null)
                    hashCode = hashCode * 59 + this.DefinitionMethod.GetHashCode();
                return hashCode;
            }
        }

    }

}
