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
    /// &lt;p&gt;Define the directional dependency of this property. Isotropic means directionally independent. Orthotropic means directionally dependent.&lt;/p&gt;
    /// </summary>
    [DataContract]
    public partial class OrthotropicConductivity : OneOfSolidMaterialConductivity, IEquatable<OrthotropicConductivity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrthotropicConductivity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrthotropicConductivity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrthotropicConductivity" /> class.
        /// </summary>
        /// <param name="type">&lt;p&gt;Define the directional dependency of this property. Isotropic means directionally independent. Orthotropic means directionally dependent.&lt;/p&gt;  Schema name: OrthotropicConductivity (required) (default to &quot;ORTHOTROPIC&quot;).</param>
        /// <param name="thermalConductivityX">thermalConductivityX.</param>
        /// <param name="thermalConductivityY">thermalConductivityY.</param>
        /// <param name="thermalConductivityZ">thermalConductivityZ.</param>
        public OrthotropicConductivity(string type = "ORTHOTROPIC", DimensionalFunctionThermalConductivity thermalConductivityX = default(DimensionalFunctionThermalConductivity), DimensionalFunctionThermalConductivity thermalConductivityY = default(DimensionalFunctionThermalConductivity), DimensionalFunctionThermalConductivity thermalConductivityZ = default(DimensionalFunctionThermalConductivity))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for OrthotropicConductivity and cannot be null");
            this.ThermalConductivityX = thermalConductivityX;
            this.ThermalConductivityY = thermalConductivityY;
            this.ThermalConductivityZ = thermalConductivityZ;
        }
        
        /// <summary>
        /// &lt;p&gt;Define the directional dependency of this property. Isotropic means directionally independent. Orthotropic means directionally dependent.&lt;/p&gt;  Schema name: OrthotropicConductivity
        /// </summary>
        /// <value>&lt;p&gt;Define the directional dependency of this property. Isotropic means directionally independent. Orthotropic means directionally dependent.&lt;/p&gt;  Schema name: OrthotropicConductivity</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets ThermalConductivityX
        /// </summary>
        [DataMember(Name="thermalConductivityX", EmitDefaultValue=false)]
        public DimensionalFunctionThermalConductivity ThermalConductivityX { get; set; }

        /// <summary>
        /// Gets or Sets ThermalConductivityY
        /// </summary>
        [DataMember(Name="thermalConductivityY", EmitDefaultValue=false)]
        public DimensionalFunctionThermalConductivity ThermalConductivityY { get; set; }

        /// <summary>
        /// Gets or Sets ThermalConductivityZ
        /// </summary>
        [DataMember(Name="thermalConductivityZ", EmitDefaultValue=false)]
        public DimensionalFunctionThermalConductivity ThermalConductivityZ { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrthotropicConductivity {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ThermalConductivityX: ").Append(ThermalConductivityX).Append("\n");
            sb.Append("  ThermalConductivityY: ").Append(ThermalConductivityY).Append("\n");
            sb.Append("  ThermalConductivityZ: ").Append(ThermalConductivityZ).Append("\n");
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
            return this.Equals(input as OrthotropicConductivity);
        }

        /// <summary>
        /// Returns true if OrthotropicConductivity instances are equal
        /// </summary>
        /// <param name="input">Instance of OrthotropicConductivity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrthotropicConductivity input)
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
                    this.ThermalConductivityX == input.ThermalConductivityX ||
                    (this.ThermalConductivityX != null &&
                    this.ThermalConductivityX.Equals(input.ThermalConductivityX))
                ) && 
                (
                    this.ThermalConductivityY == input.ThermalConductivityY ||
                    (this.ThermalConductivityY != null &&
                    this.ThermalConductivityY.Equals(input.ThermalConductivityY))
                ) && 
                (
                    this.ThermalConductivityZ == input.ThermalConductivityZ ||
                    (this.ThermalConductivityZ != null &&
                    this.ThermalConductivityZ.Equals(input.ThermalConductivityZ))
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
                if (this.ThermalConductivityX != null)
                    hashCode = hashCode * 59 + this.ThermalConductivityX.GetHashCode();
                if (this.ThermalConductivityY != null)
                    hashCode = hashCode * 59 + this.ThermalConductivityY.GetHashCode();
                if (this.ThermalConductivityZ != null)
                    hashCode = hashCode * 59 + this.ThermalConductivityZ.GetHashCode();
                return hashCode;
            }
        }

    }

}
