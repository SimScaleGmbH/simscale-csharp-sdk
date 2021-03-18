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
    /// MULESSolver
    /// </summary>
    [DataContract]
    public partial class MULESSolver : IEquatable<MULESSolver>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MULESSolver" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MULESSolver() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MULESSolver" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;MULES_V7&quot;).</param>
        /// <param name="alphaCorrectors">alphaCorrectors (default to 2).</param>
        /// <param name="alphaSubCycles">alphaSubCycles (default to 2).</param>
        /// <param name="compressionCoefficient">compressionCoefficient (default to 1M).</param>
        /// <param name="isotropicCompressionCoefficient">isotropicCompressionCoefficient (default to 0.25M).</param>
        /// <param name="semiImplicit">semiImplicit.</param>
        public MULESSolver(string type = "MULES_V7", int? alphaCorrectors = default(int?), int? alphaSubCycles = default(int?), decimal? compressionCoefficient = default(decimal?), decimal? isotropicCompressionCoefficient = default(decimal?), OneOfMULESSolverSemiImplicit semiImplicit = default(OneOfMULESSolverSemiImplicit))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for MULESSolver and cannot be null");
            this.AlphaCorrectors = alphaCorrectors;
            this.AlphaSubCycles = alphaSubCycles;
            this.CompressionCoefficient = compressionCoefficient;
            this.IsotropicCompressionCoefficient = isotropicCompressionCoefficient;
            this.SemiImplicit = semiImplicit;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets AlphaCorrectors
        /// </summary>
        [DataMember(Name="alphaCorrectors", EmitDefaultValue=false)]
        public int? AlphaCorrectors { get; set; }

        /// <summary>
        /// Gets or Sets AlphaSubCycles
        /// </summary>
        [DataMember(Name="alphaSubCycles", EmitDefaultValue=false)]
        public int? AlphaSubCycles { get; set; }

        /// <summary>
        /// Gets or Sets CompressionCoefficient
        /// </summary>
        [DataMember(Name="compressionCoefficient", EmitDefaultValue=false)]
        public decimal? CompressionCoefficient { get; set; }

        /// <summary>
        /// Gets or Sets IsotropicCompressionCoefficient
        /// </summary>
        [DataMember(Name="isotropicCompressionCoefficient", EmitDefaultValue=false)]
        public decimal? IsotropicCompressionCoefficient { get; set; }

        /// <summary>
        /// Gets or Sets SemiImplicit
        /// </summary>
        [DataMember(Name="semiImplicit", EmitDefaultValue=false)]
        public OneOfMULESSolverSemiImplicit SemiImplicit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MULESSolver {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AlphaCorrectors: ").Append(AlphaCorrectors).Append("\n");
            sb.Append("  AlphaSubCycles: ").Append(AlphaSubCycles).Append("\n");
            sb.Append("  CompressionCoefficient: ").Append(CompressionCoefficient).Append("\n");
            sb.Append("  IsotropicCompressionCoefficient: ").Append(IsotropicCompressionCoefficient).Append("\n");
            sb.Append("  SemiImplicit: ").Append(SemiImplicit).Append("\n");
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
            return this.Equals(input as MULESSolver);
        }

        /// <summary>
        /// Returns true if MULESSolver instances are equal
        /// </summary>
        /// <param name="input">Instance of MULESSolver to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MULESSolver input)
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
                    this.AlphaCorrectors == input.AlphaCorrectors ||
                    (this.AlphaCorrectors != null &&
                    this.AlphaCorrectors.Equals(input.AlphaCorrectors))
                ) && 
                (
                    this.AlphaSubCycles == input.AlphaSubCycles ||
                    (this.AlphaSubCycles != null &&
                    this.AlphaSubCycles.Equals(input.AlphaSubCycles))
                ) && 
                (
                    this.CompressionCoefficient == input.CompressionCoefficient ||
                    (this.CompressionCoefficient != null &&
                    this.CompressionCoefficient.Equals(input.CompressionCoefficient))
                ) && 
                (
                    this.IsotropicCompressionCoefficient == input.IsotropicCompressionCoefficient ||
                    (this.IsotropicCompressionCoefficient != null &&
                    this.IsotropicCompressionCoefficient.Equals(input.IsotropicCompressionCoefficient))
                ) && 
                (
                    this.SemiImplicit == input.SemiImplicit ||
                    (this.SemiImplicit != null &&
                    this.SemiImplicit.Equals(input.SemiImplicit))
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
                if (this.AlphaCorrectors != null)
                    hashCode = hashCode * 59 + this.AlphaCorrectors.GetHashCode();
                if (this.AlphaSubCycles != null)
                    hashCode = hashCode * 59 + this.AlphaSubCycles.GetHashCode();
                if (this.CompressionCoefficient != null)
                    hashCode = hashCode * 59 + this.CompressionCoefficient.GetHashCode();
                if (this.IsotropicCompressionCoefficient != null)
                    hashCode = hashCode * 59 + this.IsotropicCompressionCoefficient.GetHashCode();
                if (this.SemiImplicit != null)
                    hashCode = hashCode * 59 + this.SemiImplicit.GetHashCode();
                return hashCode;
            }
        }

    }

}