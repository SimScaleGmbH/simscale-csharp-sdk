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
    /// AutomaticLayerOn
    /// </summary>
    [DataContract]
    public partial class AutomaticLayerOn : OneOfSimmetrixMeshingFluidAutomaticLayerSettings, IEquatable<AutomaticLayerOn>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomaticLayerOn" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AutomaticLayerOn() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomaticLayerOn" /> class.
        /// </summary>
        /// <param name="type">Schema name: AutomaticLayerOn (required) (default to &quot;AUTOMATIC_LAYER_ON&quot;).</param>
        /// <param name="numberOfLayers">The &lt;i&gt;Number of layers&lt;/i&gt; defines how many prismatic boundary layers should be created. 3 is default. (default to 3).</param>
        /// <param name="totalRelativeThickness">It defines the thickness of all prismatic boundary layers combined in relation to the local element size.&lt;img src&#x3D;\&quot;/spec/resources/help/imgs/simmetrix-overall-layer-thickness.png\&quot; class&#x3D;\&quot;helpPopupImage\&quot;/&gt;Example 3-layer thickness of 40% (0.4) of the local mesh size. (default to 0.4M).</param>
        /// <param name="layerType">layerType.</param>
        public AutomaticLayerOn(string type = "AUTOMATIC_LAYER_ON", int? numberOfLayers = default(int?), decimal? totalRelativeThickness = default(decimal?), OneOfAutomaticLayerOnLayerType layerType = default(OneOfAutomaticLayerOnLayerType))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for AutomaticLayerOn and cannot be null");
            this.NumberOfLayers = numberOfLayers;
            this.TotalRelativeThickness = totalRelativeThickness;
            this.LayerType = layerType;
        }
        
        /// <summary>
        /// Schema name: AutomaticLayerOn
        /// </summary>
        /// <value>Schema name: AutomaticLayerOn</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// The &lt;i&gt;Number of layers&lt;/i&gt; defines how many prismatic boundary layers should be created. 3 is default.
        /// </summary>
        /// <value>The &lt;i&gt;Number of layers&lt;/i&gt; defines how many prismatic boundary layers should be created. 3 is default.</value>
        [DataMember(Name="numberOfLayers", EmitDefaultValue=false)]
        public int? NumberOfLayers { get; set; }

        /// <summary>
        /// It defines the thickness of all prismatic boundary layers combined in relation to the local element size.&lt;img src&#x3D;\&quot;/spec/resources/help/imgs/simmetrix-overall-layer-thickness.png\&quot; class&#x3D;\&quot;helpPopupImage\&quot;/&gt;Example 3-layer thickness of 40% (0.4) of the local mesh size.
        /// </summary>
        /// <value>It defines the thickness of all prismatic boundary layers combined in relation to the local element size.&lt;img src&#x3D;\&quot;/spec/resources/help/imgs/simmetrix-overall-layer-thickness.png\&quot; class&#x3D;\&quot;helpPopupImage\&quot;/&gt;Example 3-layer thickness of 40% (0.4) of the local mesh size.</value>
        [DataMember(Name="totalRelativeThickness", EmitDefaultValue=false)]
        public decimal? TotalRelativeThickness { get; set; }

        /// <summary>
        /// Gets or Sets LayerType
        /// </summary>
        [DataMember(Name="layerType", EmitDefaultValue=false)]
        public OneOfAutomaticLayerOnLayerType LayerType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutomaticLayerOn {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  NumberOfLayers: ").Append(NumberOfLayers).Append("\n");
            sb.Append("  TotalRelativeThickness: ").Append(TotalRelativeThickness).Append("\n");
            sb.Append("  LayerType: ").Append(LayerType).Append("\n");
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
            return this.Equals(input as AutomaticLayerOn);
        }

        /// <summary>
        /// Returns true if AutomaticLayerOn instances are equal
        /// </summary>
        /// <param name="input">Instance of AutomaticLayerOn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutomaticLayerOn input)
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
                    this.TotalRelativeThickness == input.TotalRelativeThickness ||
                    (this.TotalRelativeThickness != null &&
                    this.TotalRelativeThickness.Equals(input.TotalRelativeThickness))
                ) && 
                (
                    this.LayerType == input.LayerType ||
                    (this.LayerType != null &&
                    this.LayerType.Equals(input.LayerType))
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
                if (this.TotalRelativeThickness != null)
                    hashCode = hashCode * 59 + this.TotalRelativeThickness.GetHashCode();
                if (this.LayerType != null)
                    hashCode = hashCode * 59 + this.LayerType.GetHashCode();
                return hashCode;
            }
        }

    }

}
