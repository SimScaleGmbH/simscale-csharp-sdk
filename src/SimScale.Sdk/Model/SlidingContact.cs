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
    /// SlidingContact
    /// </summary>
    [DataContract]
    public partial class SlidingContact : OneOfContactConnections, IEquatable<SlidingContact>
    {
        /// <summary>
        /// Defines EnableHeatTransfer
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EnableHeatTransferEnum
        {
            /// <summary>
            /// Enum YES for value: YES
            /// </summary>
            [EnumMember(Value = "YES")]
            YES = 1,

            /// <summary>
            /// Enum NO for value: NO
            /// </summary>
            [EnumMember(Value = "NO")]
            NO = 2,

            /// <summary>
            /// Enum HEATTRANSFERONLY for value: HEAT_TRANSFER_ONLY
            /// </summary>
            [EnumMember(Value = "HEAT_TRANSFER_ONLY")]
            HEATTRANSFERONLY = 3

        }

        /// <summary>
        /// Gets or Sets EnableHeatTransfer
        /// </summary>
        [DataMember(Name="enableHeatTransfer", EmitDefaultValue=false)]
        public EnableHeatTransferEnum? EnableHeatTransfer { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SlidingContact" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SlidingContact() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SlidingContact" /> class.
        /// </summary>
        /// <param name="type">Schema name: SlidingContact (required) (default to &quot;SLIDING_CONTACT&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="enableHeatTransfer">enableHeatTransfer (default to EnableHeatTransferEnum.YES).</param>
        /// <param name="positionTolerance">positionTolerance.</param>
        /// <param name="masterTopologicalReference">masterTopologicalReference.</param>
        /// <param name="slaveTopologicalReference">slaveTopologicalReference.</param>
        public SlidingContact(string type = "SLIDING_CONTACT", string name = default(string), EnableHeatTransferEnum? enableHeatTransfer = default(EnableHeatTransferEnum?), OneOfSlidingContactPositionTolerance positionTolerance = default(OneOfSlidingContactPositionTolerance), TopologicalReference masterTopologicalReference = default(TopologicalReference), TopologicalReference slaveTopologicalReference = default(TopologicalReference))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for SlidingContact and cannot be null");
            this.Name = name;
            this.EnableHeatTransfer = enableHeatTransfer;
            this.PositionTolerance = positionTolerance;
            this.MasterTopologicalReference = masterTopologicalReference;
            this.SlaveTopologicalReference = slaveTopologicalReference;
        }
        
        /// <summary>
        /// Schema name: SlidingContact
        /// </summary>
        /// <value>Schema name: SlidingContact</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PositionTolerance
        /// </summary>
        [DataMember(Name="positionTolerance", EmitDefaultValue=false)]
        public OneOfSlidingContactPositionTolerance PositionTolerance { get; set; }

        /// <summary>
        /// Gets or Sets MasterTopologicalReference
        /// </summary>
        [DataMember(Name="masterTopologicalReference", EmitDefaultValue=false)]
        public TopologicalReference MasterTopologicalReference { get; set; }

        /// <summary>
        /// Gets or Sets SlaveTopologicalReference
        /// </summary>
        [DataMember(Name="slaveTopologicalReference", EmitDefaultValue=false)]
        public TopologicalReference SlaveTopologicalReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SlidingContact {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EnableHeatTransfer: ").Append(EnableHeatTransfer).Append("\n");
            sb.Append("  PositionTolerance: ").Append(PositionTolerance).Append("\n");
            sb.Append("  MasterTopologicalReference: ").Append(MasterTopologicalReference).Append("\n");
            sb.Append("  SlaveTopologicalReference: ").Append(SlaveTopologicalReference).Append("\n");
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
            return this.Equals(input as SlidingContact);
        }

        /// <summary>
        /// Returns true if SlidingContact instances are equal
        /// </summary>
        /// <param name="input">Instance of SlidingContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SlidingContact input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.EnableHeatTransfer == input.EnableHeatTransfer ||
                    this.EnableHeatTransfer.Equals(input.EnableHeatTransfer)
                ) && 
                (
                    this.PositionTolerance == input.PositionTolerance ||
                    (this.PositionTolerance != null &&
                    this.PositionTolerance.Equals(input.PositionTolerance))
                ) && 
                (
                    this.MasterTopologicalReference == input.MasterTopologicalReference ||
                    (this.MasterTopologicalReference != null &&
                    this.MasterTopologicalReference.Equals(input.MasterTopologicalReference))
                ) && 
                (
                    this.SlaveTopologicalReference == input.SlaveTopologicalReference ||
                    (this.SlaveTopologicalReference != null &&
                    this.SlaveTopologicalReference.Equals(input.SlaveTopologicalReference))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.EnableHeatTransfer.GetHashCode();
                if (this.PositionTolerance != null)
                    hashCode = hashCode * 59 + this.PositionTolerance.GetHashCode();
                if (this.MasterTopologicalReference != null)
                    hashCode = hashCode * 59 + this.MasterTopologicalReference.GetHashCode();
                if (this.SlaveTopologicalReference != null)
                    hashCode = hashCode * 59 + this.SlaveTopologicalReference.GetHashCode();
                return hashCode;
            }
        }

    }

}
