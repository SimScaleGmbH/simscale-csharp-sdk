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
    /// LayerAddingControls
    /// </summary>
    [DataContract]
    public partial class LayerAddingControls : IEquatable<LayerAddingControls>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LayerAddingControls" /> class.
        /// </summary>
        /// <param name="relativeSize">&lt;p&gt;If turned on, the length parameters for layer refinements (e.g. &#39;Thickness of the final layer&#39;, &#39;Minimum overall layer thickness&#39;) are multiplied by the local cell size outside that layer. Else, they are used as absolute lengths.&lt;/p&gt; (default to true).</param>
        /// <param name="maxCancelledLayersNearSharpFeatures">&lt;p&gt;If the algorithm faces difficulty generating layers, this is the maximum number of layers that are NOT generated in that region. Such cases might occur near sharp features. Set to 0 to force layer generation for all cases.&lt;/p&gt; (default to 0).</param>
        /// <param name="featureAngle">featureAngle.</param>
        /// <param name="slipFeatureAngle">slipFeatureAngle.</param>
        /// <param name="relaxIterations">&lt;p&gt;Specify the maximum number of relaxation iterations for the snapping process for layers.&lt;/p&gt; (default to 8).</param>
        /// <param name="surfaceNormalsMaxSmoothingIterations">&lt;p&gt;Specify the maximum number of smoothing iterations for the surface normals.&lt;/p&gt; (default to 2).</param>
        /// <param name="internalMeshMaxSmoothingIterations">&lt;p&gt;Specify the number of smoothing iterations for the interior mesh movement. This movement occurs in order to make space for layers.&lt;/p&gt; (default to 5).</param>
        /// <param name="layerThicknessMaxSmoothingIterations">&lt;p&gt;This specifies the number of iterations for smoothing of the overall layer thickness over different surface patches.&lt;/p&gt; (default to 10).</param>
        /// <param name="maxFaceThicknessRatio">&lt;p&gt;Specify the maximum allowable face aspect ratio beyond which layers will not be added.&lt;/p&gt; (default to 0.5M).</param>
        /// <param name="maxThicknessToMedialRatio">&lt;p&gt;The medial length is a measure of the aspect ratio for a non-quadrilateral face. This parameter prevents layer addition for non-quad faces that are highly anisotropic.&lt;/p&gt; (default to 0.3M).</param>
        /// <param name="minMedianAxisAngle">minMedianAxisAngle.</param>
        /// <param name="bufferCellsNoExtrude">&lt;p&gt;This parameter specifies the number of buffer cells to be extruded at cell-faces where layers terminate. Set to &lt; 0 to disable.&lt;/p&gt; (default to 0).</param>
        /// <param name="layerAdditionMaxIterations">&lt;p&gt;Specify the overall layer addition iteration number. The algorithm will abort definitely as soon as this number is reached. In this case, the mesh might be illegal.&lt;/p&gt; (default to 50).</param>
        /// <param name="maxIterationsWithStrictQualityControls">&lt;p&gt;This parameter specifies the maximum number of layer iterations that are done with the mesh quality controls. On exceeding these, the algorithm switches to less strict controls specified in the &#39;relaxed&#39; category.&lt;/p&gt; (default to 20).</param>
        public LayerAddingControls(bool? relativeSize = default(bool?), int? maxCancelledLayersNearSharpFeatures = default(int?), DimensionalAngle featureAngle = default(DimensionalAngle), DimensionalAngle slipFeatureAngle = default(DimensionalAngle), int? relaxIterations = default(int?), int? surfaceNormalsMaxSmoothingIterations = default(int?), int? internalMeshMaxSmoothingIterations = default(int?), int? layerThicknessMaxSmoothingIterations = default(int?), decimal? maxFaceThicknessRatio = default(decimal?), decimal? maxThicknessToMedialRatio = default(decimal?), DimensionalAngle minMedianAxisAngle = default(DimensionalAngle), int? bufferCellsNoExtrude = default(int?), int? layerAdditionMaxIterations = default(int?), int? maxIterationsWithStrictQualityControls = default(int?))
        {
            this.RelativeSize = relativeSize;
            this.MaxCancelledLayersNearSharpFeatures = maxCancelledLayersNearSharpFeatures;
            this.FeatureAngle = featureAngle;
            this.SlipFeatureAngle = slipFeatureAngle;
            this.RelaxIterations = relaxIterations;
            this.SurfaceNormalsMaxSmoothingIterations = surfaceNormalsMaxSmoothingIterations;
            this.InternalMeshMaxSmoothingIterations = internalMeshMaxSmoothingIterations;
            this.LayerThicknessMaxSmoothingIterations = layerThicknessMaxSmoothingIterations;
            this.MaxFaceThicknessRatio = maxFaceThicknessRatio;
            this.MaxThicknessToMedialRatio = maxThicknessToMedialRatio;
            this.MinMedianAxisAngle = minMedianAxisAngle;
            this.BufferCellsNoExtrude = bufferCellsNoExtrude;
            this.LayerAdditionMaxIterations = layerAdditionMaxIterations;
            this.MaxIterationsWithStrictQualityControls = maxIterationsWithStrictQualityControls;
        }
        
        /// <summary>
        /// &lt;p&gt;If turned on, the length parameters for layer refinements (e.g. &#39;Thickness of the final layer&#39;, &#39;Minimum overall layer thickness&#39;) are multiplied by the local cell size outside that layer. Else, they are used as absolute lengths.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;If turned on, the length parameters for layer refinements (e.g. &#39;Thickness of the final layer&#39;, &#39;Minimum overall layer thickness&#39;) are multiplied by the local cell size outside that layer. Else, they are used as absolute lengths.&lt;/p&gt;</value>
        [DataMember(Name="relativeSize", EmitDefaultValue=false)]
        public bool? RelativeSize { get; set; }

        /// <summary>
        /// &lt;p&gt;If the algorithm faces difficulty generating layers, this is the maximum number of layers that are NOT generated in that region. Such cases might occur near sharp features. Set to 0 to force layer generation for all cases.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;If the algorithm faces difficulty generating layers, this is the maximum number of layers that are NOT generated in that region. Such cases might occur near sharp features. Set to 0 to force layer generation for all cases.&lt;/p&gt;</value>
        [DataMember(Name="maxCancelledLayersNearSharpFeatures", EmitDefaultValue=false)]
        public int? MaxCancelledLayersNearSharpFeatures { get; set; }

        /// <summary>
        /// Gets or Sets FeatureAngle
        /// </summary>
        [DataMember(Name="featureAngle", EmitDefaultValue=false)]
        public DimensionalAngle FeatureAngle { get; set; }

        /// <summary>
        /// Gets or Sets SlipFeatureAngle
        /// </summary>
        [DataMember(Name="slipFeatureAngle", EmitDefaultValue=false)]
        public DimensionalAngle SlipFeatureAngle { get; set; }

        /// <summary>
        /// &lt;p&gt;Specify the maximum number of relaxation iterations for the snapping process for layers.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Specify the maximum number of relaxation iterations for the snapping process for layers.&lt;/p&gt;</value>
        [DataMember(Name="relaxIterations", EmitDefaultValue=false)]
        public int? RelaxIterations { get; set; }

        /// <summary>
        /// &lt;p&gt;Specify the maximum number of smoothing iterations for the surface normals.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Specify the maximum number of smoothing iterations for the surface normals.&lt;/p&gt;</value>
        [DataMember(Name="surfaceNormalsMaxSmoothingIterations", EmitDefaultValue=false)]
        public int? SurfaceNormalsMaxSmoothingIterations { get; set; }

        /// <summary>
        /// &lt;p&gt;Specify the number of smoothing iterations for the interior mesh movement. This movement occurs in order to make space for layers.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Specify the number of smoothing iterations for the interior mesh movement. This movement occurs in order to make space for layers.&lt;/p&gt;</value>
        [DataMember(Name="internalMeshMaxSmoothingIterations", EmitDefaultValue=false)]
        public int? InternalMeshMaxSmoothingIterations { get; set; }

        /// <summary>
        /// &lt;p&gt;This specifies the number of iterations for smoothing of the overall layer thickness over different surface patches.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;This specifies the number of iterations for smoothing of the overall layer thickness over different surface patches.&lt;/p&gt;</value>
        [DataMember(Name="layerThicknessMaxSmoothingIterations", EmitDefaultValue=false)]
        public int? LayerThicknessMaxSmoothingIterations { get; set; }

        /// <summary>
        /// &lt;p&gt;Specify the maximum allowable face aspect ratio beyond which layers will not be added.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Specify the maximum allowable face aspect ratio beyond which layers will not be added.&lt;/p&gt;</value>
        [DataMember(Name="maxFaceThicknessRatio", EmitDefaultValue=false)]
        public decimal? MaxFaceThicknessRatio { get; set; }

        /// <summary>
        /// &lt;p&gt;The medial length is a measure of the aspect ratio for a non-quadrilateral face. This parameter prevents layer addition for non-quad faces that are highly anisotropic.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;The medial length is a measure of the aspect ratio for a non-quadrilateral face. This parameter prevents layer addition for non-quad faces that are highly anisotropic.&lt;/p&gt;</value>
        [DataMember(Name="maxThicknessToMedialRatio", EmitDefaultValue=false)]
        public decimal? MaxThicknessToMedialRatio { get; set; }

        /// <summary>
        /// Gets or Sets MinMedianAxisAngle
        /// </summary>
        [DataMember(Name="minMedianAxisAngle", EmitDefaultValue=false)]
        public DimensionalAngle MinMedianAxisAngle { get; set; }

        /// <summary>
        /// &lt;p&gt;This parameter specifies the number of buffer cells to be extruded at cell-faces where layers terminate. Set to &lt; 0 to disable.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;This parameter specifies the number of buffer cells to be extruded at cell-faces where layers terminate. Set to &lt; 0 to disable.&lt;/p&gt;</value>
        [DataMember(Name="bufferCellsNoExtrude", EmitDefaultValue=false)]
        public int? BufferCellsNoExtrude { get; set; }

        /// <summary>
        /// &lt;p&gt;Specify the overall layer addition iteration number. The algorithm will abort definitely as soon as this number is reached. In this case, the mesh might be illegal.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Specify the overall layer addition iteration number. The algorithm will abort definitely as soon as this number is reached. In this case, the mesh might be illegal.&lt;/p&gt;</value>
        [DataMember(Name="layerAdditionMaxIterations", EmitDefaultValue=false)]
        public int? LayerAdditionMaxIterations { get; set; }

        /// <summary>
        /// &lt;p&gt;This parameter specifies the maximum number of layer iterations that are done with the mesh quality controls. On exceeding these, the algorithm switches to less strict controls specified in the &#39;relaxed&#39; category.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;This parameter specifies the maximum number of layer iterations that are done with the mesh quality controls. On exceeding these, the algorithm switches to less strict controls specified in the &#39;relaxed&#39; category.&lt;/p&gt;</value>
        [DataMember(Name="maxIterationsWithStrictQualityControls", EmitDefaultValue=false)]
        public int? MaxIterationsWithStrictQualityControls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LayerAddingControls {\n");
            sb.Append("  RelativeSize: ").Append(RelativeSize).Append("\n");
            sb.Append("  MaxCancelledLayersNearSharpFeatures: ").Append(MaxCancelledLayersNearSharpFeatures).Append("\n");
            sb.Append("  FeatureAngle: ").Append(FeatureAngle).Append("\n");
            sb.Append("  SlipFeatureAngle: ").Append(SlipFeatureAngle).Append("\n");
            sb.Append("  RelaxIterations: ").Append(RelaxIterations).Append("\n");
            sb.Append("  SurfaceNormalsMaxSmoothingIterations: ").Append(SurfaceNormalsMaxSmoothingIterations).Append("\n");
            sb.Append("  InternalMeshMaxSmoothingIterations: ").Append(InternalMeshMaxSmoothingIterations).Append("\n");
            sb.Append("  LayerThicknessMaxSmoothingIterations: ").Append(LayerThicknessMaxSmoothingIterations).Append("\n");
            sb.Append("  MaxFaceThicknessRatio: ").Append(MaxFaceThicknessRatio).Append("\n");
            sb.Append("  MaxThicknessToMedialRatio: ").Append(MaxThicknessToMedialRatio).Append("\n");
            sb.Append("  MinMedianAxisAngle: ").Append(MinMedianAxisAngle).Append("\n");
            sb.Append("  BufferCellsNoExtrude: ").Append(BufferCellsNoExtrude).Append("\n");
            sb.Append("  LayerAdditionMaxIterations: ").Append(LayerAdditionMaxIterations).Append("\n");
            sb.Append("  MaxIterationsWithStrictQualityControls: ").Append(MaxIterationsWithStrictQualityControls).Append("\n");
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
            return this.Equals(input as LayerAddingControls);
        }

        /// <summary>
        /// Returns true if LayerAddingControls instances are equal
        /// </summary>
        /// <param name="input">Instance of LayerAddingControls to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LayerAddingControls input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RelativeSize == input.RelativeSize ||
                    (this.RelativeSize != null &&
                    this.RelativeSize.Equals(input.RelativeSize))
                ) && 
                (
                    this.MaxCancelledLayersNearSharpFeatures == input.MaxCancelledLayersNearSharpFeatures ||
                    (this.MaxCancelledLayersNearSharpFeatures != null &&
                    this.MaxCancelledLayersNearSharpFeatures.Equals(input.MaxCancelledLayersNearSharpFeatures))
                ) && 
                (
                    this.FeatureAngle == input.FeatureAngle ||
                    (this.FeatureAngle != null &&
                    this.FeatureAngle.Equals(input.FeatureAngle))
                ) && 
                (
                    this.SlipFeatureAngle == input.SlipFeatureAngle ||
                    (this.SlipFeatureAngle != null &&
                    this.SlipFeatureAngle.Equals(input.SlipFeatureAngle))
                ) && 
                (
                    this.RelaxIterations == input.RelaxIterations ||
                    (this.RelaxIterations != null &&
                    this.RelaxIterations.Equals(input.RelaxIterations))
                ) && 
                (
                    this.SurfaceNormalsMaxSmoothingIterations == input.SurfaceNormalsMaxSmoothingIterations ||
                    (this.SurfaceNormalsMaxSmoothingIterations != null &&
                    this.SurfaceNormalsMaxSmoothingIterations.Equals(input.SurfaceNormalsMaxSmoothingIterations))
                ) && 
                (
                    this.InternalMeshMaxSmoothingIterations == input.InternalMeshMaxSmoothingIterations ||
                    (this.InternalMeshMaxSmoothingIterations != null &&
                    this.InternalMeshMaxSmoothingIterations.Equals(input.InternalMeshMaxSmoothingIterations))
                ) && 
                (
                    this.LayerThicknessMaxSmoothingIterations == input.LayerThicknessMaxSmoothingIterations ||
                    (this.LayerThicknessMaxSmoothingIterations != null &&
                    this.LayerThicknessMaxSmoothingIterations.Equals(input.LayerThicknessMaxSmoothingIterations))
                ) && 
                (
                    this.MaxFaceThicknessRatio == input.MaxFaceThicknessRatio ||
                    (this.MaxFaceThicknessRatio != null &&
                    this.MaxFaceThicknessRatio.Equals(input.MaxFaceThicknessRatio))
                ) && 
                (
                    this.MaxThicknessToMedialRatio == input.MaxThicknessToMedialRatio ||
                    (this.MaxThicknessToMedialRatio != null &&
                    this.MaxThicknessToMedialRatio.Equals(input.MaxThicknessToMedialRatio))
                ) && 
                (
                    this.MinMedianAxisAngle == input.MinMedianAxisAngle ||
                    (this.MinMedianAxisAngle != null &&
                    this.MinMedianAxisAngle.Equals(input.MinMedianAxisAngle))
                ) && 
                (
                    this.BufferCellsNoExtrude == input.BufferCellsNoExtrude ||
                    (this.BufferCellsNoExtrude != null &&
                    this.BufferCellsNoExtrude.Equals(input.BufferCellsNoExtrude))
                ) && 
                (
                    this.LayerAdditionMaxIterations == input.LayerAdditionMaxIterations ||
                    (this.LayerAdditionMaxIterations != null &&
                    this.LayerAdditionMaxIterations.Equals(input.LayerAdditionMaxIterations))
                ) && 
                (
                    this.MaxIterationsWithStrictQualityControls == input.MaxIterationsWithStrictQualityControls ||
                    (this.MaxIterationsWithStrictQualityControls != null &&
                    this.MaxIterationsWithStrictQualityControls.Equals(input.MaxIterationsWithStrictQualityControls))
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
                if (this.RelativeSize != null)
                    hashCode = hashCode * 59 + this.RelativeSize.GetHashCode();
                if (this.MaxCancelledLayersNearSharpFeatures != null)
                    hashCode = hashCode * 59 + this.MaxCancelledLayersNearSharpFeatures.GetHashCode();
                if (this.FeatureAngle != null)
                    hashCode = hashCode * 59 + this.FeatureAngle.GetHashCode();
                if (this.SlipFeatureAngle != null)
                    hashCode = hashCode * 59 + this.SlipFeatureAngle.GetHashCode();
                if (this.RelaxIterations != null)
                    hashCode = hashCode * 59 + this.RelaxIterations.GetHashCode();
                if (this.SurfaceNormalsMaxSmoothingIterations != null)
                    hashCode = hashCode * 59 + this.SurfaceNormalsMaxSmoothingIterations.GetHashCode();
                if (this.InternalMeshMaxSmoothingIterations != null)
                    hashCode = hashCode * 59 + this.InternalMeshMaxSmoothingIterations.GetHashCode();
                if (this.LayerThicknessMaxSmoothingIterations != null)
                    hashCode = hashCode * 59 + this.LayerThicknessMaxSmoothingIterations.GetHashCode();
                if (this.MaxFaceThicknessRatio != null)
                    hashCode = hashCode * 59 + this.MaxFaceThicknessRatio.GetHashCode();
                if (this.MaxThicknessToMedialRatio != null)
                    hashCode = hashCode * 59 + this.MaxThicknessToMedialRatio.GetHashCode();
                if (this.MinMedianAxisAngle != null)
                    hashCode = hashCode * 59 + this.MinMedianAxisAngle.GetHashCode();
                if (this.BufferCellsNoExtrude != null)
                    hashCode = hashCode * 59 + this.BufferCellsNoExtrude.GetHashCode();
                if (this.LayerAdditionMaxIterations != null)
                    hashCode = hashCode * 59 + this.LayerAdditionMaxIterations.GetHashCode();
                if (this.MaxIterationsWithStrictQualityControls != null)
                    hashCode = hashCode * 59 + this.MaxIterationsWithStrictQualityControls.GetHashCode();
                return hashCode;
            }
        }

    }

}
