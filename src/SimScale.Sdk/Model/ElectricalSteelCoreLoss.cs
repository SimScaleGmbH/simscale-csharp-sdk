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
    /// ElectricalSteelCoreLoss
    /// </summary>
    [DataContract]
    public partial class ElectricalSteelCoreLoss : OneOfElectromagneticMaterialCoreLossesType, IEquatable<ElectricalSteelCoreLoss>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricalSteelCoreLoss" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ElectricalSteelCoreLoss() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricalSteelCoreLoss" /> class.
        /// </summary>
        /// <param name="type">Schema name: ElectricalSteelCoreLoss (required) (default to &quot;ELECTRICAL_STEEL&quot;).</param>
        /// <param name="hysteresisLoss">hysteresisLoss.</param>
        /// <param name="eddyLoss">eddyLoss.</param>
        /// <param name="excessLoss">excessLoss.</param>
        public ElectricalSteelCoreLoss(string type = "ELECTRICAL_STEEL", decimal? hysteresisLoss = default(decimal?), decimal? eddyLoss = default(decimal?), decimal? excessLoss = default(decimal?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for ElectricalSteelCoreLoss and cannot be null");
            this.HysteresisLoss = hysteresisLoss;
            this.EddyLoss = eddyLoss;
            this.ExcessLoss = excessLoss;
        }
        
        /// <summary>
        /// Schema name: ElectricalSteelCoreLoss
        /// </summary>
        /// <value>Schema name: ElectricalSteelCoreLoss</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets HysteresisLoss
        /// </summary>
        [DataMember(Name="hysteresisLoss", EmitDefaultValue=false)]
        public decimal? HysteresisLoss { get; set; }

        /// <summary>
        /// Gets or Sets EddyLoss
        /// </summary>
        [DataMember(Name="eddyLoss", EmitDefaultValue=false)]
        public decimal? EddyLoss { get; set; }

        /// <summary>
        /// Gets or Sets ExcessLoss
        /// </summary>
        [DataMember(Name="excessLoss", EmitDefaultValue=false)]
        public decimal? ExcessLoss { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ElectricalSteelCoreLoss {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  HysteresisLoss: ").Append(HysteresisLoss).Append("\n");
            sb.Append("  EddyLoss: ").Append(EddyLoss).Append("\n");
            sb.Append("  ExcessLoss: ").Append(ExcessLoss).Append("\n");
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
            return this.Equals(input as ElectricalSteelCoreLoss);
        }

        /// <summary>
        /// Returns true if ElectricalSteelCoreLoss instances are equal
        /// </summary>
        /// <param name="input">Instance of ElectricalSteelCoreLoss to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ElectricalSteelCoreLoss input)
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
                    this.HysteresisLoss == input.HysteresisLoss ||
                    (this.HysteresisLoss != null &&
                    this.HysteresisLoss.Equals(input.HysteresisLoss))
                ) && 
                (
                    this.EddyLoss == input.EddyLoss ||
                    (this.EddyLoss != null &&
                    this.EddyLoss.Equals(input.EddyLoss))
                ) && 
                (
                    this.ExcessLoss == input.ExcessLoss ||
                    (this.ExcessLoss != null &&
                    this.ExcessLoss.Equals(input.ExcessLoss))
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
                if (this.HysteresisLoss != null)
                    hashCode = hashCode * 59 + this.HysteresisLoss.GetHashCode();
                if (this.EddyLoss != null)
                    hashCode = hashCode * 59 + this.EddyLoss.GetHashCode();
                if (this.ExcessLoss != null)
                    hashCode = hashCode * 59 + this.ExcessLoss.GetHashCode();
                return hashCode;
            }
        }

    }

}