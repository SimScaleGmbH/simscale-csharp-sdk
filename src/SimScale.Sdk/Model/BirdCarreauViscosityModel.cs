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
    /// Choose between &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/materials/#newtonian-model&#39; target&#x3D;&#39;_blank&#39;&gt;Newtonian&lt;/a&gt; and &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/materials/non-newtonian-models/&#39; target&#x3D;&#39;_blank&#39;&gt;Non-Newtonian&lt;/a&gt; viscosity models.
    /// </summary>
    [DataContract]
    public partial class BirdCarreauViscosityModel : OneOfIncompressibleMaterialViscosityModel, IEquatable<BirdCarreauViscosityModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BirdCarreauViscosityModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BirdCarreauViscosityModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BirdCarreauViscosityModel" /> class.
        /// </summary>
        /// <param name="type">Choose between &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/materials/#newtonian-model&#39; target&#x3D;&#39;_blank&#39;&gt;Newtonian&lt;/a&gt; and &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/materials/non-newtonian-models/&#39; target&#x3D;&#39;_blank&#39;&gt;Non-Newtonian&lt;/a&gt; viscosity models.  Schema name: BirdCarreauViscosityModel (required) (default to &quot;BIRD_CARREAU&quot;).</param>
        /// <param name="nu0">nu0.</param>
        /// <param name="nuInf">nuInf.</param>
        /// <param name="k">k.</param>
        /// <param name="n">n.</param>
        /// <param name="a">a.</param>
        public BirdCarreauViscosityModel(string type = "BIRD_CARREAU", DimensionalKinematicViscosity nu0 = default(DimensionalKinematicViscosity), DimensionalKinematicViscosity nuInf = default(DimensionalKinematicViscosity), DimensionalTime k = default(DimensionalTime), DimensionalDimensionless n = default(DimensionalDimensionless), DimensionalDimensionless a = default(DimensionalDimensionless))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for BirdCarreauViscosityModel and cannot be null");
            this.Nu0 = nu0;
            this.NuInf = nuInf;
            this.K = k;
            this.N = n;
            this.A = a;
        }
        
        /// <summary>
        /// Choose between &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/materials/#newtonian-model&#39; target&#x3D;&#39;_blank&#39;&gt;Newtonian&lt;/a&gt; and &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/materials/non-newtonian-models/&#39; target&#x3D;&#39;_blank&#39;&gt;Non-Newtonian&lt;/a&gt; viscosity models.  Schema name: BirdCarreauViscosityModel
        /// </summary>
        /// <value>Choose between &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/materials/#newtonian-model&#39; target&#x3D;&#39;_blank&#39;&gt;Newtonian&lt;/a&gt; and &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/materials/non-newtonian-models/&#39; target&#x3D;&#39;_blank&#39;&gt;Non-Newtonian&lt;/a&gt; viscosity models.  Schema name: BirdCarreauViscosityModel</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Nu0
        /// </summary>
        [DataMember(Name="nu0", EmitDefaultValue=false)]
        public DimensionalKinematicViscosity Nu0 { get; set; }

        /// <summary>
        /// Gets or Sets NuInf
        /// </summary>
        [DataMember(Name="nuInf", EmitDefaultValue=false)]
        public DimensionalKinematicViscosity NuInf { get; set; }

        /// <summary>
        /// Gets or Sets K
        /// </summary>
        [DataMember(Name="k", EmitDefaultValue=false)]
        public DimensionalTime K { get; set; }

        /// <summary>
        /// Gets or Sets N
        /// </summary>
        [DataMember(Name="n", EmitDefaultValue=false)]
        public DimensionalDimensionless N { get; set; }

        /// <summary>
        /// Gets or Sets A
        /// </summary>
        [DataMember(Name="a", EmitDefaultValue=false)]
        public DimensionalDimensionless A { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BirdCarreauViscosityModel {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Nu0: ").Append(Nu0).Append("\n");
            sb.Append("  NuInf: ").Append(NuInf).Append("\n");
            sb.Append("  K: ").Append(K).Append("\n");
            sb.Append("  N: ").Append(N).Append("\n");
            sb.Append("  A: ").Append(A).Append("\n");
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
            return this.Equals(input as BirdCarreauViscosityModel);
        }

        /// <summary>
        /// Returns true if BirdCarreauViscosityModel instances are equal
        /// </summary>
        /// <param name="input">Instance of BirdCarreauViscosityModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BirdCarreauViscosityModel input)
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
                    this.Nu0 == input.Nu0 ||
                    (this.Nu0 != null &&
                    this.Nu0.Equals(input.Nu0))
                ) && 
                (
                    this.NuInf == input.NuInf ||
                    (this.NuInf != null &&
                    this.NuInf.Equals(input.NuInf))
                ) && 
                (
                    this.K == input.K ||
                    (this.K != null &&
                    this.K.Equals(input.K))
                ) && 
                (
                    this.N == input.N ||
                    (this.N != null &&
                    this.N.Equals(input.N))
                ) && 
                (
                    this.A == input.A ||
                    (this.A != null &&
                    this.A.Equals(input.A))
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
                if (this.Nu0 != null)
                    hashCode = hashCode * 59 + this.Nu0.GetHashCode();
                if (this.NuInf != null)
                    hashCode = hashCode * 59 + this.NuInf.GetHashCode();
                if (this.K != null)
                    hashCode = hashCode * 59 + this.K.GetHashCode();
                if (this.N != null)
                    hashCode = hashCode * 59 + this.N.GetHashCode();
                if (this.A != null)
                    hashCode = hashCode * 59 + this.A.GetHashCode();
                return hashCode;
            }
        }

    }

}
