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
    /// ElectromagneticResultControl
    /// </summary>
    [DataContract]
    public partial class ElectromagneticResultControl : IEquatable<ElectromagneticResultControl>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectromagneticResultControl" /> class.
        /// </summary>
        /// <param name="forcesAndTorques">forcesAndTorques.</param>
        public ElectromagneticResultControl(List<ForceAndTorque> forcesAndTorques = default(List<ForceAndTorque>))
        {
            this.ForcesAndTorques = forcesAndTorques;
        }
        
        /// <summary>
        /// Gets or Sets ForcesAndTorques
        /// </summary>
        [DataMember(Name="forcesAndTorques", EmitDefaultValue=false)]
        public List<ForceAndTorque> ForcesAndTorques { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ElectromagneticResultControl {\n");
            sb.Append("  ForcesAndTorques: ").Append(ForcesAndTorques).Append("\n");
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
            return this.Equals(input as ElectromagneticResultControl);
        }

        /// <summary>
        /// Returns true if ElectromagneticResultControl instances are equal
        /// </summary>
        /// <param name="input">Instance of ElectromagneticResultControl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ElectromagneticResultControl input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ForcesAndTorques == input.ForcesAndTorques ||
                    this.ForcesAndTorques != null &&
                    input.ForcesAndTorques != null &&
                    this.ForcesAndTorques.SequenceEqual(input.ForcesAndTorques)
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
                if (this.ForcesAndTorques != null)
                    hashCode = hashCode * 59 + this.ForcesAndTorques.GetHashCode();
                return hashCode;
            }
        }

    }

}