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
    /// CAD import options. Please refer to https://www.simscale.com/docs/cad-preparation/#cad-upload-options for a detailed description of the options.
    /// </summary>
    [DataContract]
    public partial class GeometryImportRequestOptions : IEquatable<GeometryImportRequestOptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeometryImportRequestOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GeometryImportRequestOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GeometryImportRequestOptions" /> class.
        /// </summary>
        /// <param name="facetSplit">_Facet Split_ tries to split the faceted parts of a model. This means it can create new faces from original faces. In this case it&#39;s not possible to use the original faces to make assignments.  (required) (default to false).</param>
        /// <param name="sewing">_Automatic Sewing_ is sewing faces or sheet bodies together. This means that it can create one new face from two (or more) original faces, as well as one solid body from two (or more) original sheet bodies. In this case, if the entities have the same ID, it will be inherited by the newly created entity. However if the original entities do not share the same ID, only one of these will be mapped to the new entity. This might not be desirable if one would like to make assignments on the original entities and not on the new (sewn) entities.  (required) (default to false).</param>
        /// <param name="improve">This option tries to improve the topology (e.g. edges, vertices) and geometry of the model by adjusting tolerances, simplifying entities, etc. As this option should improve CAD operations and data handling for all downstream applications it is recommended to use it on import. For very complex models it can take a considerable amount of time though, therefore you can also opt-out and reconsider in case you face issues in geometry handling or meshing.  (required) (default to true).</param>
        /// <param name="optimizeForLBMSolver">This option allows you to import a *.stl file that is optimized for the Incompressible LBM and Wind Comfort analysis types. It leaves out complex import steps like sewing and cleanup that are not required by the LBM solver and therefore also allows to import big and complex models fast.  (required) (default to false).</param>
        public GeometryImportRequestOptions(bool? facetSplit = false, bool? sewing = false, bool? improve = true, bool? optimizeForLBMSolver = false)
        {
            // to ensure "facetSplit" is required (not null)
            this.FacetSplit = facetSplit ?? throw new ArgumentNullException("facetSplit is a required property for GeometryImportRequestOptions and cannot be null");
            // to ensure "sewing" is required (not null)
            this.Sewing = sewing ?? throw new ArgumentNullException("sewing is a required property for GeometryImportRequestOptions and cannot be null");
            // to ensure "improve" is required (not null)
            this.Improve = improve ?? throw new ArgumentNullException("improve is a required property for GeometryImportRequestOptions and cannot be null");
            // to ensure "optimizeForLBMSolver" is required (not null)
            this.OptimizeForLBMSolver = optimizeForLBMSolver ?? throw new ArgumentNullException("optimizeForLBMSolver is a required property for GeometryImportRequestOptions and cannot be null");
        }
        
        /// <summary>
        /// _Facet Split_ tries to split the faceted parts of a model. This means it can create new faces from original faces. In this case it&#39;s not possible to use the original faces to make assignments. 
        /// </summary>
        /// <value>_Facet Split_ tries to split the faceted parts of a model. This means it can create new faces from original faces. In this case it&#39;s not possible to use the original faces to make assignments. </value>
        [DataMember(Name="facetSplit", EmitDefaultValue=false)]
        public bool? FacetSplit { get; set; }

        /// <summary>
        /// _Automatic Sewing_ is sewing faces or sheet bodies together. This means that it can create one new face from two (or more) original faces, as well as one solid body from two (or more) original sheet bodies. In this case, if the entities have the same ID, it will be inherited by the newly created entity. However if the original entities do not share the same ID, only one of these will be mapped to the new entity. This might not be desirable if one would like to make assignments on the original entities and not on the new (sewn) entities. 
        /// </summary>
        /// <value>_Automatic Sewing_ is sewing faces or sheet bodies together. This means that it can create one new face from two (or more) original faces, as well as one solid body from two (or more) original sheet bodies. In this case, if the entities have the same ID, it will be inherited by the newly created entity. However if the original entities do not share the same ID, only one of these will be mapped to the new entity. This might not be desirable if one would like to make assignments on the original entities and not on the new (sewn) entities. </value>
        [DataMember(Name="sewing", EmitDefaultValue=false)]
        public bool? Sewing { get; set; }

        /// <summary>
        /// This option tries to improve the topology (e.g. edges, vertices) and geometry of the model by adjusting tolerances, simplifying entities, etc. As this option should improve CAD operations and data handling for all downstream applications it is recommended to use it on import. For very complex models it can take a considerable amount of time though, therefore you can also opt-out and reconsider in case you face issues in geometry handling or meshing. 
        /// </summary>
        /// <value>This option tries to improve the topology (e.g. edges, vertices) and geometry of the model by adjusting tolerances, simplifying entities, etc. As this option should improve CAD operations and data handling for all downstream applications it is recommended to use it on import. For very complex models it can take a considerable amount of time though, therefore you can also opt-out and reconsider in case you face issues in geometry handling or meshing. </value>
        [DataMember(Name="improve", EmitDefaultValue=false)]
        public bool? Improve { get; set; }

        /// <summary>
        /// This option allows you to import a *.stl file that is optimized for the Incompressible LBM and Wind Comfort analysis types. It leaves out complex import steps like sewing and cleanup that are not required by the LBM solver and therefore also allows to import big and complex models fast. 
        /// </summary>
        /// <value>This option allows you to import a *.stl file that is optimized for the Incompressible LBM and Wind Comfort analysis types. It leaves out complex import steps like sewing and cleanup that are not required by the LBM solver and therefore also allows to import big and complex models fast. </value>
        [DataMember(Name="optimizeForLBMSolver", EmitDefaultValue=false)]
        public bool? OptimizeForLBMSolver { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeometryImportRequestOptions {\n");
            sb.Append("  FacetSplit: ").Append(FacetSplit).Append("\n");
            sb.Append("  Sewing: ").Append(Sewing).Append("\n");
            sb.Append("  Improve: ").Append(Improve).Append("\n");
            sb.Append("  OptimizeForLBMSolver: ").Append(OptimizeForLBMSolver).Append("\n");
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
            return this.Equals(input as GeometryImportRequestOptions);
        }

        /// <summary>
        /// Returns true if GeometryImportRequestOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of GeometryImportRequestOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeometryImportRequestOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FacetSplit == input.FacetSplit ||
                    (this.FacetSplit != null &&
                    this.FacetSplit.Equals(input.FacetSplit))
                ) && 
                (
                    this.Sewing == input.Sewing ||
                    (this.Sewing != null &&
                    this.Sewing.Equals(input.Sewing))
                ) && 
                (
                    this.Improve == input.Improve ||
                    (this.Improve != null &&
                    this.Improve.Equals(input.Improve))
                ) && 
                (
                    this.OptimizeForLBMSolver == input.OptimizeForLBMSolver ||
                    (this.OptimizeForLBMSolver != null &&
                    this.OptimizeForLBMSolver.Equals(input.OptimizeForLBMSolver))
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
                if (this.FacetSplit != null)
                    hashCode = hashCode * 59 + this.FacetSplit.GetHashCode();
                if (this.Sewing != null)
                    hashCode = hashCode * 59 + this.Sewing.GetHashCode();
                if (this.Improve != null)
                    hashCode = hashCode * 59 + this.Improve.GetHashCode();
                if (this.OptimizeForLBMSolver != null)
                    hashCode = hashCode * 59 + this.OptimizeForLBMSolver.GetHashCode();
                return hashCode;
            }
        }

    }

}
