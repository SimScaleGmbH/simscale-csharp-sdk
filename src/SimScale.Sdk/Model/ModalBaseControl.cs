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
    /// ModalBaseControl
    /// </summary>
    [DataContract]
    public partial class ModalBaseControl : IEquatable<ModalBaseControl>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModalBaseControl" /> class.
        /// </summary>
        /// <param name="eigenfrequencyScope">eigenfrequencyScope.</param>
        public ModalBaseControl(OneOfModalBaseControlEigenfrequencyScope eigenfrequencyScope = default(OneOfModalBaseControlEigenfrequencyScope))
        {
            this.EigenfrequencyScope = eigenfrequencyScope;
        }
        
        /// <summary>
        /// Gets or Sets EigenfrequencyScope
        /// </summary>
        [DataMember(Name="eigenfrequencyScope", EmitDefaultValue=false)]
        public OneOfModalBaseControlEigenfrequencyScope EigenfrequencyScope { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModalBaseControl {\n");
            sb.Append("  EigenfrequencyScope: ").Append(EigenfrequencyScope).Append("\n");
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
            return this.Equals(input as ModalBaseControl);
        }

        /// <summary>
        /// Returns true if ModalBaseControl instances are equal
        /// </summary>
        /// <param name="input">Instance of ModalBaseControl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModalBaseControl input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EigenfrequencyScope == input.EigenfrequencyScope ||
                    (this.EigenfrequencyScope != null &&
                    this.EigenfrequencyScope.Equals(input.EigenfrequencyScope))
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
                if (this.EigenfrequencyScope != null)
                    hashCode = hashCode * 59 + this.EigenfrequencyScope.GetHashCode();
                return hashCode;
            }
        }

    }

}