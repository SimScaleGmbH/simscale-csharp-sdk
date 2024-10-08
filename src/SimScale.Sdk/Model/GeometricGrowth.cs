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
    /// GeometricGrowth
    /// </summary>
    [DataContract]
    public partial class GeometricGrowth : OneOfAutomaticLayerOnLayerType, OneOfSimmetrixBoundaryLayerRefinementLayerType, IEquatable<GeometricGrowth>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeometricGrowth" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GeometricGrowth() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GeometricGrowth" /> class.
        /// </summary>
        /// <param name="type">Schema name: GeometricGrowth (required) (default to &quot;GEOMETRIC_GROWTH&quot;).</param>
        /// <param name="numberOfLayers">The &lt;i&gt;Number of layers&lt;/i&gt; defines how many prismatic boundary layers should be created. 3 is default. (default to 3).</param>
        /// <param name="totalAbsoluteThickness">totalAbsoluteThickness.</param>
        /// <param name="firstLayerSize">firstLayerSize.</param>
        public GeometricGrowth(string type = "GEOMETRIC_GROWTH", int? numberOfLayers = default(int?), DimensionalLength totalAbsoluteThickness = default(DimensionalLength), DimensionalLength firstLayerSize = default(DimensionalLength))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for GeometricGrowth and cannot be null");
            this.NumberOfLayers = numberOfLayers;
            this.TotalAbsoluteThickness = totalAbsoluteThickness;
            this.FirstLayerSize = firstLayerSize;
        }
        
        /// <summary>
        /// Schema name: GeometricGrowth
        /// </summary>
        /// <value>Schema name: GeometricGrowth</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// The &lt;i&gt;Number of layers&lt;/i&gt; defines how many prismatic boundary layers should be created. 3 is default.
        /// </summary>
        /// <value>The &lt;i&gt;Number of layers&lt;/i&gt; defines how many prismatic boundary layers should be created. 3 is default.</value>
        [DataMember(Name="numberOfLayers", EmitDefaultValue=false)]
        public int? NumberOfLayers { get; set; }

        /// <summary>
        /// Gets or Sets TotalAbsoluteThickness
        /// </summary>
        [DataMember(Name="totalAbsoluteThickness", EmitDefaultValue=false)]
        public DimensionalLength TotalAbsoluteThickness { get; set; }

        /// <summary>
        /// Gets or Sets FirstLayerSize
        /// </summary>
        [DataMember(Name="firstLayerSize", EmitDefaultValue=false)]
        public DimensionalLength FirstLayerSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeometricGrowth {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  NumberOfLayers: ").Append(NumberOfLayers).Append("\n");
            sb.Append("  TotalAbsoluteThickness: ").Append(TotalAbsoluteThickness).Append("\n");
            sb.Append("  FirstLayerSize: ").Append(FirstLayerSize).Append("\n");
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
            return this.Equals(input as GeometricGrowth);
        }

        /// <summary>
        /// Returns true if GeometricGrowth instances are equal
        /// </summary>
        /// <param name="input">Instance of GeometricGrowth to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeometricGrowth input)
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
                    this.NumberOfLayers == input.NumberOfLayers ||
                    (this.NumberOfLayers != null &&
                    this.NumberOfLayers.Equals(input.NumberOfLayers))
                ) && 
                (
                    this.TotalAbsoluteThickness == input.TotalAbsoluteThickness ||
                    (this.TotalAbsoluteThickness != null &&
                    this.TotalAbsoluteThickness.Equals(input.TotalAbsoluteThickness))
                ) && 
                (
                    this.FirstLayerSize == input.FirstLayerSize ||
                    (this.FirstLayerSize != null &&
                    this.FirstLayerSize.Equals(input.FirstLayerSize))
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
                if (this.NumberOfLayers != null)
                    hashCode = hashCode * 59 + this.NumberOfLayers.GetHashCode();
                if (this.TotalAbsoluteThickness != null)
                    hashCode = hashCode * 59 + this.TotalAbsoluteThickness.GetHashCode();
                if (this.FirstLayerSize != null)
                    hashCode = hashCode * 59 + this.FirstLayerSize.GetHashCode();
                return hashCode;
            }
        }

    }

}
