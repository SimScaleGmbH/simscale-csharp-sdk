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
    /// SimpleDecomposeAlgorithm
    /// </summary>
    [DataContract]
    public partial class SimpleDecomposeAlgorithm : OneOfFluidSimulationControlDecomposeAlgorithm, IEquatable<SimpleDecomposeAlgorithm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleDecomposeAlgorithm" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SimpleDecomposeAlgorithm() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleDecomposeAlgorithm" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;SIMPLE&quot;).</param>
        /// <param name="delta">Delta is cell skew factor. It represents the cell skewness allowed at the decomposed domain boundaries and is generally kept below 10^{-2}. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/simulation-control/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;. (default to 0.01M).</param>
        /// <param name="numSubdomainX">&lt;p&gt;Define the number of subdomains the mesh is split into in the specific direction.&lt;/p&gt; (default to 1).</param>
        /// <param name="numSubdomainY">&lt;p&gt;Define the number of subdomains the mesh is split into in the specific direction.&lt;/p&gt; (default to 1).</param>
        /// <param name="numSubdomainZ">&lt;p&gt;Define the number of subdomains the mesh is split into in the specific direction.&lt;/p&gt; (default to 1).</param>
        public SimpleDecomposeAlgorithm(string type = "SIMPLE", decimal? delta = default(decimal?), int? numSubdomainX = default(int?), int? numSubdomainY = default(int?), int? numSubdomainZ = default(int?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for SimpleDecomposeAlgorithm and cannot be null");
            this.Delta = delta;
            this.NumSubdomainX = numSubdomainX;
            this.NumSubdomainY = numSubdomainY;
            this.NumSubdomainZ = numSubdomainZ;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Delta is cell skew factor. It represents the cell skewness allowed at the decomposed domain boundaries and is generally kept below 10^{-2}. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/simulation-control/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.
        /// </summary>
        /// <value>Delta is cell skew factor. It represents the cell skewness allowed at the decomposed domain boundaries and is generally kept below 10^{-2}. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/simulation-control/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.</value>
        [DataMember(Name="delta", EmitDefaultValue=false)]
        public decimal? Delta { get; set; }

        /// <summary>
        /// &lt;p&gt;Define the number of subdomains the mesh is split into in the specific direction.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Define the number of subdomains the mesh is split into in the specific direction.&lt;/p&gt;</value>
        [DataMember(Name="numSubdomainX", EmitDefaultValue=false)]
        public int? NumSubdomainX { get; set; }

        /// <summary>
        /// &lt;p&gt;Define the number of subdomains the mesh is split into in the specific direction.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Define the number of subdomains the mesh is split into in the specific direction.&lt;/p&gt;</value>
        [DataMember(Name="numSubdomainY", EmitDefaultValue=false)]
        public int? NumSubdomainY { get; set; }

        /// <summary>
        /// &lt;p&gt;Define the number of subdomains the mesh is split into in the specific direction.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Define the number of subdomains the mesh is split into in the specific direction.&lt;/p&gt;</value>
        [DataMember(Name="numSubdomainZ", EmitDefaultValue=false)]
        public int? NumSubdomainZ { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimpleDecomposeAlgorithm {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Delta: ").Append(Delta).Append("\n");
            sb.Append("  NumSubdomainX: ").Append(NumSubdomainX).Append("\n");
            sb.Append("  NumSubdomainY: ").Append(NumSubdomainY).Append("\n");
            sb.Append("  NumSubdomainZ: ").Append(NumSubdomainZ).Append("\n");
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
            return this.Equals(input as SimpleDecomposeAlgorithm);
        }

        /// <summary>
        /// Returns true if SimpleDecomposeAlgorithm instances are equal
        /// </summary>
        /// <param name="input">Instance of SimpleDecomposeAlgorithm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimpleDecomposeAlgorithm input)
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
                    this.Delta == input.Delta ||
                    (this.Delta != null &&
                    this.Delta.Equals(input.Delta))
                ) && 
                (
                    this.NumSubdomainX == input.NumSubdomainX ||
                    (this.NumSubdomainX != null &&
                    this.NumSubdomainX.Equals(input.NumSubdomainX))
                ) && 
                (
                    this.NumSubdomainY == input.NumSubdomainY ||
                    (this.NumSubdomainY != null &&
                    this.NumSubdomainY.Equals(input.NumSubdomainY))
                ) && 
                (
                    this.NumSubdomainZ == input.NumSubdomainZ ||
                    (this.NumSubdomainZ != null &&
                    this.NumSubdomainZ.Equals(input.NumSubdomainZ))
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
                if (this.Delta != null)
                    hashCode = hashCode * 59 + this.Delta.GetHashCode();
                if (this.NumSubdomainX != null)
                    hashCode = hashCode * 59 + this.NumSubdomainX.GetHashCode();
                if (this.NumSubdomainY != null)
                    hashCode = hashCode * 59 + this.NumSubdomainY.GetHashCode();
                if (this.NumSubdomainZ != null)
                    hashCode = hashCode * 59 + this.NumSubdomainZ.GetHashCode();
                return hashCode;
            }
        }

    }

}