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
    /// IRAMSorensen
    /// </summary>
    [DataContract]
    public partial class IRAMSorensen : OneOfSolidNumericsEigenSolver, IEquatable<IRAMSorensen>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IRAMSorensen" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IRAMSorensen() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IRAMSorensen" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;SORENSEN&quot;).</param>
        /// <param name="precSoren">precSoren (default to 0M).</param>
        /// <param name="nmaxIterSoren">nmaxIterSoren (default to 20).</param>
        public IRAMSorensen(string type = "SORENSEN", decimal? precSoren = default(decimal?), int? nmaxIterSoren = default(int?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for IRAMSorensen and cannot be null");
            this.PrecSoren = precSoren;
            this.NmaxIterSoren = nmaxIterSoren;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets PrecSoren
        /// </summary>
        [DataMember(Name="precSoren", EmitDefaultValue=false)]
        public decimal? PrecSoren { get; set; }

        /// <summary>
        /// Gets or Sets NmaxIterSoren
        /// </summary>
        [DataMember(Name="nmaxIterSoren", EmitDefaultValue=false)]
        public int? NmaxIterSoren { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IRAMSorensen {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  PrecSoren: ").Append(PrecSoren).Append("\n");
            sb.Append("  NmaxIterSoren: ").Append(NmaxIterSoren).Append("\n");
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
            return this.Equals(input as IRAMSorensen);
        }

        /// <summary>
        /// Returns true if IRAMSorensen instances are equal
        /// </summary>
        /// <param name="input">Instance of IRAMSorensen to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IRAMSorensen input)
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
                    this.PrecSoren == input.PrecSoren ||
                    (this.PrecSoren != null &&
                    this.PrecSoren.Equals(input.PrecSoren))
                ) && 
                (
                    this.NmaxIterSoren == input.NmaxIterSoren ||
                    (this.NmaxIterSoren != null &&
                    this.NmaxIterSoren.Equals(input.NmaxIterSoren))
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
                if (this.PrecSoren != null)
                    hashCode = hashCode * 59 + this.PrecSoren.GetHashCode();
                if (this.NmaxIterSoren != null)
                    hashCode = hashCode * 59 + this.NmaxIterSoren.GetHashCode();
                return hashCode;
            }
        }

    }

}