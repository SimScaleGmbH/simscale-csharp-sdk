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
    /// ForceAndTorque
    /// </summary>
    [DataContract]
    public partial class ForceAndTorque : IEquatable<ForceAndTorque>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForceAndTorque" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        /// <param name="torqueReferencePoint">torqueReferencePoint.</param>
        public ForceAndTorque(string name = default(string), TopologicalReference topologicalReference = default(TopologicalReference), DimensionalVectorLength torqueReferencePoint = default(DimensionalVectorLength))
        {
            this.Name = name;
            this.TopologicalReference = topologicalReference;
            this.TorqueReferencePoint = torqueReferencePoint;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets TopologicalReference
        /// </summary>
        [DataMember(Name="topologicalReference", EmitDefaultValue=false)]
        public TopologicalReference TopologicalReference { get; set; }

        /// <summary>
        /// Gets or Sets TorqueReferencePoint
        /// </summary>
        [DataMember(Name="torqueReferencePoint", EmitDefaultValue=false)]
        public DimensionalVectorLength TorqueReferencePoint { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForceAndTorque {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TopologicalReference: ").Append(TopologicalReference).Append("\n");
            sb.Append("  TorqueReferencePoint: ").Append(TorqueReferencePoint).Append("\n");
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
            return this.Equals(input as ForceAndTorque);
        }

        /// <summary>
        /// Returns true if ForceAndTorque instances are equal
        /// </summary>
        /// <param name="input">Instance of ForceAndTorque to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForceAndTorque input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TopologicalReference == input.TopologicalReference ||
                    (this.TopologicalReference != null &&
                    this.TopologicalReference.Equals(input.TopologicalReference))
                ) && 
                (
                    this.TorqueReferencePoint == input.TorqueReferencePoint ||
                    (this.TorqueReferencePoint != null &&
                    this.TorqueReferencePoint.Equals(input.TorqueReferencePoint))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TopologicalReference != null)
                    hashCode = hashCode * 59 + this.TopologicalReference.GetHashCode();
                if (this.TorqueReferencePoint != null)
                    hashCode = hashCode * 59 + this.TorqueReferencePoint.GetHashCode();
                return hashCode;
            }
        }

    }

}