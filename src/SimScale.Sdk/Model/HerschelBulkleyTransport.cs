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
    /// HerschelBulkleyTransport
    /// </summary>
    [DataContract]
    public partial class HerschelBulkleyTransport : OneOfFluidCompressibleMaterialTransport, IEquatable<HerschelBulkleyTransport>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HerschelBulkleyTransport" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HerschelBulkleyTransport() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HerschelBulkleyTransport" /> class.
        /// </summary>
        /// <param name="type">Schema name: HerschelBulkleyTransport (required) (default to &quot;HERSCHEL_BULKLEY&quot;).</param>
        /// <param name="viscosityModel">viscosityModel.</param>
        /// <param name="prandtlNumber">Prandtl number (&lt;i&gt;Pr&lt;/i&gt;) is the ratio of momentum transport to thermal tranport. Fluids with low &lt;i&gt;Pr&lt;/i&gt; are free flowing and good for heat conduction..</param>
        /// <param name="turbulentPrandtlNumber">Turbulent Prandtl number is used to calculate the heat transfer due to turbulent effects in the domain..</param>
        /// <param name="thermo">thermo.</param>
        public HerschelBulkleyTransport(string type = "HERSCHEL_BULKLEY", StandardHerschelBulkleyViscosityModel viscosityModel = default(StandardHerschelBulkleyViscosityModel), decimal? prandtlNumber = default(decimal?), decimal? turbulentPrandtlNumber = default(decimal?), HConstThermo thermo = default(HConstThermo))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for HerschelBulkleyTransport and cannot be null");
            this.ViscosityModel = viscosityModel;
            this.PrandtlNumber = prandtlNumber;
            this.TurbulentPrandtlNumber = turbulentPrandtlNumber;
            this.Thermo = thermo;
        }
        
        /// <summary>
        /// Schema name: HerschelBulkleyTransport
        /// </summary>
        /// <value>Schema name: HerschelBulkleyTransport</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets ViscosityModel
        /// </summary>
        [DataMember(Name="viscosityModel", EmitDefaultValue=false)]
        public StandardHerschelBulkleyViscosityModel ViscosityModel { get; set; }

        /// <summary>
        /// Prandtl number (&lt;i&gt;Pr&lt;/i&gt;) is the ratio of momentum transport to thermal tranport. Fluids with low &lt;i&gt;Pr&lt;/i&gt; are free flowing and good for heat conduction.
        /// </summary>
        /// <value>Prandtl number (&lt;i&gt;Pr&lt;/i&gt;) is the ratio of momentum transport to thermal tranport. Fluids with low &lt;i&gt;Pr&lt;/i&gt; are free flowing and good for heat conduction.</value>
        [DataMember(Name="prandtlNumber", EmitDefaultValue=false)]
        public decimal? PrandtlNumber { get; set; }

        /// <summary>
        /// Turbulent Prandtl number is used to calculate the heat transfer due to turbulent effects in the domain.
        /// </summary>
        /// <value>Turbulent Prandtl number is used to calculate the heat transfer due to turbulent effects in the domain.</value>
        [DataMember(Name="turbulentPrandtlNumber", EmitDefaultValue=false)]
        public decimal? TurbulentPrandtlNumber { get; set; }

        /// <summary>
        /// Gets or Sets Thermo
        /// </summary>
        [DataMember(Name="thermo", EmitDefaultValue=false)]
        public HConstThermo Thermo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HerschelBulkleyTransport {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ViscosityModel: ").Append(ViscosityModel).Append("\n");
            sb.Append("  PrandtlNumber: ").Append(PrandtlNumber).Append("\n");
            sb.Append("  TurbulentPrandtlNumber: ").Append(TurbulentPrandtlNumber).Append("\n");
            sb.Append("  Thermo: ").Append(Thermo).Append("\n");
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
            return this.Equals(input as HerschelBulkleyTransport);
        }

        /// <summary>
        /// Returns true if HerschelBulkleyTransport instances are equal
        /// </summary>
        /// <param name="input">Instance of HerschelBulkleyTransport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HerschelBulkleyTransport input)
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
                    this.ViscosityModel == input.ViscosityModel ||
                    (this.ViscosityModel != null &&
                    this.ViscosityModel.Equals(input.ViscosityModel))
                ) && 
                (
                    this.PrandtlNumber == input.PrandtlNumber ||
                    (this.PrandtlNumber != null &&
                    this.PrandtlNumber.Equals(input.PrandtlNumber))
                ) && 
                (
                    this.TurbulentPrandtlNumber == input.TurbulentPrandtlNumber ||
                    (this.TurbulentPrandtlNumber != null &&
                    this.TurbulentPrandtlNumber.Equals(input.TurbulentPrandtlNumber))
                ) && 
                (
                    this.Thermo == input.Thermo ||
                    (this.Thermo != null &&
                    this.Thermo.Equals(input.Thermo))
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
                if (this.ViscosityModel != null)
                    hashCode = hashCode * 59 + this.ViscosityModel.GetHashCode();
                if (this.PrandtlNumber != null)
                    hashCode = hashCode * 59 + this.PrandtlNumber.GetHashCode();
                if (this.TurbulentPrandtlNumber != null)
                    hashCode = hashCode * 59 + this.TurbulentPrandtlNumber.GetHashCode();
                if (this.Thermo != null)
                    hashCode = hashCode * 59 + this.Thermo.GetHashCode();
                return hashCode;
            }
        }

    }

}