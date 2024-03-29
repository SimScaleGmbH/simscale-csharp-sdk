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
using JsonSubTypes;
using OpenAPIDateConverter = SimScale.Sdk.Client.OpenAPIDateConverter;

namespace SimScale.Sdk.Model
{
    /// <summary>
    /// OneOfSimmetrixMeshingFluidRefinements
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(RegionRefinementWithLength), "REGION_LENGTH")]
    [JsonSubtypes.KnownSubType(typeof(SurfaceCustomSizing), "SURFACE_CUSTOM_SIZING")]
    [JsonSubtypes.KnownSubType(typeof(VolumeCustomSizing), "VOLUME_CUSTOM_SIZING")]
    [JsonSubtypes.KnownSubType(typeof(SimmetrixLocalSizingRefinement), "SIMMETRIX_LOCAL_SIZING_V10")]
    [JsonSubtypes.KnownSubType(typeof(SimmetrixBoundaryLayerRefinement), "SIMMETRIX_BOUNDARY_LAYER_V13")]
    [JsonSubtypes.KnownSubType(typeof(SimmetrixSweptMeshRefinement), "SIMMETRIX_SWEPT_MESH_REFINEMENT")]
    [JsonSubtypes.KnownSubType(typeof(SimmetrixThinSectionMeshRefinement), "SIMMETRIX_THIN_SECTION_MESH_REFINEMENT")]
    [JsonSubtypes.KnownSubType(typeof(SimmetrixExtrusionMeshRefinement), "SIMMETRIX_EXTRUSION_MESH_REFINEMENT")]
    public interface OneOfSimmetrixMeshingFluidRefinements
    {
        /// <summary>
        /// Gets Type
        /// </summary>
        string Type { get; }
    }
}
