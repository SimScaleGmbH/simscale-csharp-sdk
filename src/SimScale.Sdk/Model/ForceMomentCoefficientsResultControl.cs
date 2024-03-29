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
    /// ForceMomentCoefficientsResultControl
    /// </summary>
    [DataContract]
    public partial class ForceMomentCoefficientsResultControl : OneOfFluidResultControlsForcesMoments, IEquatable<ForceMomentCoefficientsResultControl>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForceMomentCoefficientsResultControl" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ForceMomentCoefficientsResultControl() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ForceMomentCoefficientsResultControl" /> class.
        /// </summary>
        /// <param name="type">Schema name: ForceMomentCoefficientsResultControl (required) (default to &quot;FORCE_AND_MOMENT_COEFFICIENTS&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="centerOfRotation">centerOfRotation.</param>
        /// <param name="liftDirection">liftDirection.</param>
        /// <param name="dragDirection">dragDirection.</param>
        /// <param name="pitchAxis">pitchAxis.</param>
        /// <param name="freestreamVelocityMagnitude">freestreamVelocityMagnitude.</param>
        /// <param name="referenceLength">referenceLength.</param>
        /// <param name="referenceAreaValue">referenceAreaValue.</param>
        /// <param name="writeControl">writeControl.</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        public ForceMomentCoefficientsResultControl(string type = "FORCE_AND_MOMENT_COEFFICIENTS", string name = default(string), DimensionalVectorLength centerOfRotation = default(DimensionalVectorLength), DimensionalVectorLength liftDirection = default(DimensionalVectorLength), DimensionalVectorLength dragDirection = default(DimensionalVectorLength), DimensionalVectorLength pitchAxis = default(DimensionalVectorLength), DimensionalSpeed freestreamVelocityMagnitude = default(DimensionalSpeed), DimensionalLength referenceLength = default(DimensionalLength), DimensionalArea referenceAreaValue = default(DimensionalArea), OneOfForceMomentCoefficientsResultControlWriteControl writeControl = default(OneOfForceMomentCoefficientsResultControlWriteControl), TopologicalReference topologicalReference = default(TopologicalReference))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for ForceMomentCoefficientsResultControl and cannot be null");
            this.Name = name;
            this.CenterOfRotation = centerOfRotation;
            this.LiftDirection = liftDirection;
            this.DragDirection = dragDirection;
            this.PitchAxis = pitchAxis;
            this.FreestreamVelocityMagnitude = freestreamVelocityMagnitude;
            this.ReferenceLength = referenceLength;
            this.ReferenceAreaValue = referenceAreaValue;
            this.WriteControl = writeControl;
            this.TopologicalReference = topologicalReference;
        }
        
        /// <summary>
        /// Schema name: ForceMomentCoefficientsResultControl
        /// </summary>
        /// <value>Schema name: ForceMomentCoefficientsResultControl</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets CenterOfRotation
        /// </summary>
        [DataMember(Name="centerOfRotation", EmitDefaultValue=false)]
        public DimensionalVectorLength CenterOfRotation { get; set; }

        /// <summary>
        /// Gets or Sets LiftDirection
        /// </summary>
        [DataMember(Name="liftDirection", EmitDefaultValue=false)]
        public DimensionalVectorLength LiftDirection { get; set; }

        /// <summary>
        /// Gets or Sets DragDirection
        /// </summary>
        [DataMember(Name="dragDirection", EmitDefaultValue=false)]
        public DimensionalVectorLength DragDirection { get; set; }

        /// <summary>
        /// Gets or Sets PitchAxis
        /// </summary>
        [DataMember(Name="pitchAxis", EmitDefaultValue=false)]
        public DimensionalVectorLength PitchAxis { get; set; }

        /// <summary>
        /// Gets or Sets FreestreamVelocityMagnitude
        /// </summary>
        [DataMember(Name="freestreamVelocityMagnitude", EmitDefaultValue=false)]
        public DimensionalSpeed FreestreamVelocityMagnitude { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceLength
        /// </summary>
        [DataMember(Name="referenceLength", EmitDefaultValue=false)]
        public DimensionalLength ReferenceLength { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceAreaValue
        /// </summary>
        [DataMember(Name="referenceAreaValue", EmitDefaultValue=false)]
        public DimensionalArea ReferenceAreaValue { get; set; }

        /// <summary>
        /// Gets or Sets WriteControl
        /// </summary>
        [DataMember(Name="writeControl", EmitDefaultValue=false)]
        public OneOfForceMomentCoefficientsResultControlWriteControl WriteControl { get; set; }

        /// <summary>
        /// Gets or Sets TopologicalReference
        /// </summary>
        [DataMember(Name="topologicalReference", EmitDefaultValue=false)]
        public TopologicalReference TopologicalReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForceMomentCoefficientsResultControl {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CenterOfRotation: ").Append(CenterOfRotation).Append("\n");
            sb.Append("  LiftDirection: ").Append(LiftDirection).Append("\n");
            sb.Append("  DragDirection: ").Append(DragDirection).Append("\n");
            sb.Append("  PitchAxis: ").Append(PitchAxis).Append("\n");
            sb.Append("  FreestreamVelocityMagnitude: ").Append(FreestreamVelocityMagnitude).Append("\n");
            sb.Append("  ReferenceLength: ").Append(ReferenceLength).Append("\n");
            sb.Append("  ReferenceAreaValue: ").Append(ReferenceAreaValue).Append("\n");
            sb.Append("  WriteControl: ").Append(WriteControl).Append("\n");
            sb.Append("  TopologicalReference: ").Append(TopologicalReference).Append("\n");
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
            return this.Equals(input as ForceMomentCoefficientsResultControl);
        }

        /// <summary>
        /// Returns true if ForceMomentCoefficientsResultControl instances are equal
        /// </summary>
        /// <param name="input">Instance of ForceMomentCoefficientsResultControl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForceMomentCoefficientsResultControl input)
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
                    this.CenterOfRotation == input.CenterOfRotation ||
                    (this.CenterOfRotation != null &&
                    this.CenterOfRotation.Equals(input.CenterOfRotation))
                ) && 
                (
                    this.LiftDirection == input.LiftDirection ||
                    (this.LiftDirection != null &&
                    this.LiftDirection.Equals(input.LiftDirection))
                ) && 
                (
                    this.DragDirection == input.DragDirection ||
                    (this.DragDirection != null &&
                    this.DragDirection.Equals(input.DragDirection))
                ) && 
                (
                    this.PitchAxis == input.PitchAxis ||
                    (this.PitchAxis != null &&
                    this.PitchAxis.Equals(input.PitchAxis))
                ) && 
                (
                    this.FreestreamVelocityMagnitude == input.FreestreamVelocityMagnitude ||
                    (this.FreestreamVelocityMagnitude != null &&
                    this.FreestreamVelocityMagnitude.Equals(input.FreestreamVelocityMagnitude))
                ) && 
                (
                    this.ReferenceLength == input.ReferenceLength ||
                    (this.ReferenceLength != null &&
                    this.ReferenceLength.Equals(input.ReferenceLength))
                ) && 
                (
                    this.ReferenceAreaValue == input.ReferenceAreaValue ||
                    (this.ReferenceAreaValue != null &&
                    this.ReferenceAreaValue.Equals(input.ReferenceAreaValue))
                ) && 
                (
                    this.WriteControl == input.WriteControl ||
                    (this.WriteControl != null &&
                    this.WriteControl.Equals(input.WriteControl))
                ) && 
                (
                    this.TopologicalReference == input.TopologicalReference ||
                    (this.TopologicalReference != null &&
                    this.TopologicalReference.Equals(input.TopologicalReference))
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
                if (this.CenterOfRotation != null)
                    hashCode = hashCode * 59 + this.CenterOfRotation.GetHashCode();
                if (this.LiftDirection != null)
                    hashCode = hashCode * 59 + this.LiftDirection.GetHashCode();
                if (this.DragDirection != null)
                    hashCode = hashCode * 59 + this.DragDirection.GetHashCode();
                if (this.PitchAxis != null)
                    hashCode = hashCode * 59 + this.PitchAxis.GetHashCode();
                if (this.FreestreamVelocityMagnitude != null)
                    hashCode = hashCode * 59 + this.FreestreamVelocityMagnitude.GetHashCode();
                if (this.ReferenceLength != null)
                    hashCode = hashCode * 59 + this.ReferenceLength.GetHashCode();
                if (this.ReferenceAreaValue != null)
                    hashCode = hashCode * 59 + this.ReferenceAreaValue.GetHashCode();
                if (this.WriteControl != null)
                    hashCode = hashCode * 59 + this.WriteControl.GetHashCode();
                if (this.TopologicalReference != null)
                    hashCode = hashCode * 59 + this.TopologicalReference.GetHashCode();
                return hashCode;
            }
        }

    }

}
