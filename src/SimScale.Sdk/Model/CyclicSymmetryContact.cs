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
    /// CyclicSymmetryContact
    /// </summary>
    [DataContract]
    public partial class CyclicSymmetryContact : OneOfContactConnections, IEquatable<CyclicSymmetryContact>
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
        /// Initializes a new instance of the <see cref="CyclicSymmetryContact" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CyclicSymmetryContact() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CyclicSymmetryContact" /> class.
        /// </summary>
        /// <param name="type">Schema name: CyclicSymmetryContact (required) (default to &quot;CYCLIC_SYMMETRY&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="enableHeatTransfer">enableHeatTransfer (default to EnableHeatTransferEnum.YES).</param>
        /// <param name="axisOrigin">axisOrigin.</param>
        /// <param name="axisDirection">axisDirection.</param>
        /// <param name="sectorAngle">sectorAngle.</param>
        /// <param name="masterTopologicalReference">masterTopologicalReference.</param>
        /// <param name="slaveTopologicalReference">slaveTopologicalReference.</param>
        public CyclicSymmetryContact(string type = "CYCLIC_SYMMETRY", string name = default(string), EnableHeatTransferEnum? enableHeatTransfer = default(EnableHeatTransferEnum?), DimensionalVectorLength axisOrigin = default(DimensionalVectorLength), DimensionalVectorLength axisDirection = default(DimensionalVectorLength), DimensionalAngle sectorAngle = default(DimensionalAngle), TopologicalReference masterTopologicalReference = default(TopologicalReference), TopologicalReference slaveTopologicalReference = default(TopologicalReference))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for CyclicSymmetryContact and cannot be null");
            this.Name = name;
            this.EnableHeatTransfer = enableHeatTransfer;
            this.AxisOrigin = axisOrigin;
            this.AxisDirection = axisDirection;
            this.SectorAngle = sectorAngle;
            this.MasterTopologicalReference = masterTopologicalReference;
            this.SlaveTopologicalReference = slaveTopologicalReference;
        }
        
        /// <summary>
        /// Schema name: CyclicSymmetryContact
        /// </summary>
        /// <value>Schema name: CyclicSymmetryContact</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AxisOrigin
        /// </summary>
        [DataMember(Name="axisOrigin", EmitDefaultValue=false)]
        public DimensionalVectorLength AxisOrigin { get; set; }

        /// <summary>
        /// Gets or Sets AxisDirection
        /// </summary>
        [DataMember(Name="axisDirection", EmitDefaultValue=false)]
        public DimensionalVectorLength AxisDirection { get; set; }

        /// <summary>
        /// Gets or Sets SectorAngle
        /// </summary>
        [DataMember(Name="sectorAngle", EmitDefaultValue=false)]
        public DimensionalAngle SectorAngle { get; set; }

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
            sb.Append("class CyclicSymmetryContact {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EnableHeatTransfer: ").Append(EnableHeatTransfer).Append("\n");
            sb.Append("  AxisOrigin: ").Append(AxisOrigin).Append("\n");
            sb.Append("  AxisDirection: ").Append(AxisDirection).Append("\n");
            sb.Append("  SectorAngle: ").Append(SectorAngle).Append("\n");
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
            return this.Equals(input as CyclicSymmetryContact);
        }

        /// <summary>
        /// Returns true if CyclicSymmetryContact instances are equal
        /// </summary>
        /// <param name="input">Instance of CyclicSymmetryContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CyclicSymmetryContact input)
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
                    this.AxisOrigin == input.AxisOrigin ||
                    (this.AxisOrigin != null &&
                    this.AxisOrigin.Equals(input.AxisOrigin))
                ) && 
                (
                    this.AxisDirection == input.AxisDirection ||
                    (this.AxisDirection != null &&
                    this.AxisDirection.Equals(input.AxisDirection))
                ) && 
                (
                    this.SectorAngle == input.SectorAngle ||
                    (this.SectorAngle != null &&
                    this.SectorAngle.Equals(input.SectorAngle))
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
                if (this.AxisOrigin != null)
                    hashCode = hashCode * 59 + this.AxisOrigin.GetHashCode();
                if (this.AxisDirection != null)
                    hashCode = hashCode * 59 + this.AxisDirection.GetHashCode();
                if (this.SectorAngle != null)
                    hashCode = hashCode * 59 + this.SectorAngle.GetHashCode();
                if (this.MasterTopologicalReference != null)
                    hashCode = hashCode * 59 + this.MasterTopologicalReference.GetHashCode();
                if (this.SlaveTopologicalReference != null)
                    hashCode = hashCode * 59 + this.SlaveTopologicalReference.GetHashCode();
                return hashCode;
            }
        }

    }

}