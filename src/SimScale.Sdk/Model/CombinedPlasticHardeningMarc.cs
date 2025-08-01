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
    /// CombinedPlasticHardeningMarc
    /// </summary>
    [DataContract]
    public partial class CombinedPlasticHardeningMarc : OneOfBilinearModelMarcHardeningRule, OneOfMultilinearModelMarcHardeningRule, IEquatable<CombinedPlasticHardeningMarc>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CombinedPlasticHardeningMarc" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CombinedPlasticHardeningMarc() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CombinedPlasticHardeningMarc" /> class.
        /// </summary>
        /// <param name="type">Schema name: CombinedPlasticHardeningMarc (required) (default to &quot;COMBINED&quot;).</param>
        /// <param name="kinematicFraction">kinematicFraction (default to 0.5M).</param>
        public CombinedPlasticHardeningMarc(string type = "COMBINED", decimal? kinematicFraction = default(decimal?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for CombinedPlasticHardeningMarc and cannot be null");
            this.KinematicFraction = kinematicFraction;
        }
        
        /// <summary>
        /// Schema name: CombinedPlasticHardeningMarc
        /// </summary>
        /// <value>Schema name: CombinedPlasticHardeningMarc</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets KinematicFraction
        /// </summary>
        [DataMember(Name="kinematicFraction", EmitDefaultValue=false)]
        public decimal? KinematicFraction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CombinedPlasticHardeningMarc {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  KinematicFraction: ").Append(KinematicFraction).Append("\n");
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
            return this.Equals(input as CombinedPlasticHardeningMarc);
        }

        /// <summary>
        /// Returns true if CombinedPlasticHardeningMarc instances are equal
        /// </summary>
        /// <param name="input">Instance of CombinedPlasticHardeningMarc to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CombinedPlasticHardeningMarc input)
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
                    this.KinematicFraction == input.KinematicFraction ||
                    (this.KinematicFraction != null &&
                    this.KinematicFraction.Equals(input.KinematicFraction))
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
                if (this.KinematicFraction != null)
                    hashCode = hashCode * 59 + this.KinematicFraction.GetHashCode();
                return hashCode;
            }
        }

    }

}
