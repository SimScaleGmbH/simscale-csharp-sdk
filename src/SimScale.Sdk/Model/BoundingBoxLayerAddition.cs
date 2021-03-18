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
    /// This option enables layer refinement on the faces of the bounding box. This refinement is useful if the bounding box itself provides walls of the flow domain. It is often used for external aerodynamic cases where the floor is considered as a wall and hence the mesh should be refined with layers in the vicinity.
    /// </summary>
    [DataContract]
    public partial class BoundingBoxLayerAddition : IEquatable<BoundingBoxLayerAddition>
    {
        /// <summary>
        /// This option selects the face of the bounding box on which layers will be added. A face is selected by its normal (denoted by the respective coordinate system axis) and its position (denoted by min or max).
        /// </summary>
        /// <value>This option selects the face of the bounding box on which layers will be added. A face is selected by its normal (denoted by the respective coordinate system axis) and its position (denoted by min or max).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FaceEnum
        {
            /// <summary>
            /// Enum XMIN for value: XMIN
            /// </summary>
            [EnumMember(Value = "XMIN")]
            XMIN = 1,

            /// <summary>
            /// Enum XMAX for value: XMAX
            /// </summary>
            [EnumMember(Value = "XMAX")]
            XMAX = 2,

            /// <summary>
            /// Enum YMIN for value: YMIN
            /// </summary>
            [EnumMember(Value = "YMIN")]
            YMIN = 3,

            /// <summary>
            /// Enum YMAX for value: YMAX
            /// </summary>
            [EnumMember(Value = "YMAX")]
            YMAX = 4,

            /// <summary>
            /// Enum ZMIN for value: ZMIN
            /// </summary>
            [EnumMember(Value = "ZMIN")]
            ZMIN = 5,

            /// <summary>
            /// Enum ZMAX for value: ZMAX
            /// </summary>
            [EnumMember(Value = "ZMAX")]
            ZMAX = 6

        }

        /// <summary>
        /// This option selects the face of the bounding box on which layers will be added. A face is selected by its normal (denoted by the respective coordinate system axis) and its position (denoted by min or max).
        /// </summary>
        /// <value>This option selects the face of the bounding box on which layers will be added. A face is selected by its normal (denoted by the respective coordinate system axis) and its position (denoted by min or max).</value>
        [DataMember(Name="face", EmitDefaultValue=false)]
        public FaceEnum? Face { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBoxLayerAddition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BoundingBoxLayerAddition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BoundingBoxLayerAddition" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;BOUNDING_BOX_LAYER_ADDITION&quot;).</param>
        /// <param name="name">name (default to &quot;Bounding box layer addition&quot;).</param>
        /// <param name="face">This option selects the face of the bounding box on which layers will be added. A face is selected by its normal (denoted by the respective coordinate system axis) and its position (denoted by min or max). (default to FaceEnum.XMIN).</param>
        /// <param name="layers">The number of &lt;b&gt;layers&lt;/b&gt; defines how many boundary layers should be created. (default to 5).</param>
        /// <param name="expansionRatio">&lt;p&gt;The &lt;b&gt;Expansion ratio&lt;/b&gt; determines how the boundary layers grow in thickness from the wall to the internal mesh. The larger the ratio, the larger each cell layer will be in comparison to the neighbouring layer closer to the wall.&lt;/p&gt;&lt;p&gt;&lt;img src&#x3D;\&quot;/spec/resources/help/imgs/shm_bl_expansion-ratio.png\&quot; class&#x3D;\&quot;helpPopupImage\&quot;/&gt; The figure shows a ratio of 1.3.&lt;/p&gt; (default to 1.3M).</param>
        /// <param name="minThickness">minThickness.</param>
        /// <param name="finalThickness">finalThickness.</param>
        public BoundingBoxLayerAddition(string type = "BOUNDING_BOX_LAYER_ADDITION", string name = default(string), FaceEnum? face = default(FaceEnum?), int? layers = default(int?), decimal? expansionRatio = default(decimal?), DimensionalLength minThickness = default(DimensionalLength), DimensionalLength finalThickness = default(DimensionalLength))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for BoundingBoxLayerAddition and cannot be null");
            this.Name = name;
            this.Face = face;
            this.Layers = layers;
            this.ExpansionRatio = expansionRatio;
            this.MinThickness = minThickness;
            this.FinalThickness = finalThickness;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of &lt;b&gt;layers&lt;/b&gt; defines how many boundary layers should be created.
        /// </summary>
        /// <value>The number of &lt;b&gt;layers&lt;/b&gt; defines how many boundary layers should be created.</value>
        [DataMember(Name="layers", EmitDefaultValue=false)]
        public int? Layers { get; set; }

        /// <summary>
        /// &lt;p&gt;The &lt;b&gt;Expansion ratio&lt;/b&gt; determines how the boundary layers grow in thickness from the wall to the internal mesh. The larger the ratio, the larger each cell layer will be in comparison to the neighbouring layer closer to the wall.&lt;/p&gt;&lt;p&gt;&lt;img src&#x3D;\&quot;/spec/resources/help/imgs/shm_bl_expansion-ratio.png\&quot; class&#x3D;\&quot;helpPopupImage\&quot;/&gt; The figure shows a ratio of 1.3.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;The &lt;b&gt;Expansion ratio&lt;/b&gt; determines how the boundary layers grow in thickness from the wall to the internal mesh. The larger the ratio, the larger each cell layer will be in comparison to the neighbouring layer closer to the wall.&lt;/p&gt;&lt;p&gt;&lt;img src&#x3D;\&quot;/spec/resources/help/imgs/shm_bl_expansion-ratio.png\&quot; class&#x3D;\&quot;helpPopupImage\&quot;/&gt; The figure shows a ratio of 1.3.&lt;/p&gt;</value>
        [DataMember(Name="expansionRatio", EmitDefaultValue=false)]
        public decimal? ExpansionRatio { get; set; }

        /// <summary>
        /// Gets or Sets MinThickness
        /// </summary>
        [DataMember(Name="minThickness", EmitDefaultValue=false)]
        public DimensionalLength MinThickness { get; set; }

        /// <summary>
        /// Gets or Sets FinalThickness
        /// </summary>
        [DataMember(Name="finalThickness", EmitDefaultValue=false)]
        public DimensionalLength FinalThickness { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoundingBoxLayerAddition {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Face: ").Append(Face).Append("\n");
            sb.Append("  Layers: ").Append(Layers).Append("\n");
            sb.Append("  ExpansionRatio: ").Append(ExpansionRatio).Append("\n");
            sb.Append("  MinThickness: ").Append(MinThickness).Append("\n");
            sb.Append("  FinalThickness: ").Append(FinalThickness).Append("\n");
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
            return this.Equals(input as BoundingBoxLayerAddition);
        }

        /// <summary>
        /// Returns true if BoundingBoxLayerAddition instances are equal
        /// </summary>
        /// <param name="input">Instance of BoundingBoxLayerAddition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoundingBoxLayerAddition input)
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
                    this.Face == input.Face ||
                    this.Face.Equals(input.Face)
                ) && 
                (
                    this.Layers == input.Layers ||
                    (this.Layers != null &&
                    this.Layers.Equals(input.Layers))
                ) && 
                (
                    this.ExpansionRatio == input.ExpansionRatio ||
                    (this.ExpansionRatio != null &&
                    this.ExpansionRatio.Equals(input.ExpansionRatio))
                ) && 
                (
                    this.MinThickness == input.MinThickness ||
                    (this.MinThickness != null &&
                    this.MinThickness.Equals(input.MinThickness))
                ) && 
                (
                    this.FinalThickness == input.FinalThickness ||
                    (this.FinalThickness != null &&
                    this.FinalThickness.Equals(input.FinalThickness))
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
                hashCode = hashCode * 59 + this.Face.GetHashCode();
                if (this.Layers != null)
                    hashCode = hashCode * 59 + this.Layers.GetHashCode();
                if (this.ExpansionRatio != null)
                    hashCode = hashCode * 59 + this.ExpansionRatio.GetHashCode();
                if (this.MinThickness != null)
                    hashCode = hashCode * 59 + this.MinThickness.GetHashCode();
                if (this.FinalThickness != null)
                    hashCode = hashCode * 59 + this.FinalThickness.GetHashCode();
                return hashCode;
            }
        }

    }

}