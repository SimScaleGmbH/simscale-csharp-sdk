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
    /// VariableGroupMAGNETICFIELDSTRENGTH
    /// </summary>
    [DataContract]
    public partial class VariableGroupMAGNETICFIELDSTRENGTH : IEquatable<VariableGroupMAGNETICFIELDSTRENGTH>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableGroupMAGNETICFIELDSTRENGTH" /> class.
        /// </summary>
        /// <param name="h">h.</param>
        public VariableGroupMAGNETICFIELDSTRENGTH(UnitMagneticFieldStrength h = default(UnitMagneticFieldStrength))
        {
            this.H = h;
        }
        
        /// <summary>
        /// Gets or Sets H
        /// </summary>
        [DataMember(Name="H", EmitDefaultValue=false)]
        public UnitMagneticFieldStrength H { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariableGroupMAGNETICFIELDSTRENGTH {\n");
            sb.Append("  H: ").Append(H).Append("\n");
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
            return this.Equals(input as VariableGroupMAGNETICFIELDSTRENGTH);
        }

        /// <summary>
        /// Returns true if VariableGroupMAGNETICFIELDSTRENGTH instances are equal
        /// </summary>
        /// <param name="input">Instance of VariableGroupMAGNETICFIELDSTRENGTH to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariableGroupMAGNETICFIELDSTRENGTH input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.H == input.H ||
                    (this.H != null &&
                    this.H.Equals(input.H))
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
                if (this.H != null)
                    hashCode = hashCode * 59 + this.H.GetHashCode();
                return hashCode;
            }
        }

    }

}
