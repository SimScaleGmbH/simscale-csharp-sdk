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
    /// &lt;p&gt;This parameter determines the &lt;b&gt;fineness of the mesh&lt;/b&gt; and affects the overall number of cells. It is recommended to start with the &lt;i&gt;coarse&lt;/i&gt; setting. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/analysis-types/pedestrian-wind-comfort-analysis/mesh-settings/&#39; target&#x3D;&#39;_blank&#39;&gt;Find out more.&lt;/a&gt;&lt;/p&gt;&lt;p&gt;&lt;b&gt;Note:&lt;/b&gt; This setting will impact the accuracy of your results as well as computing time and result size. A finer mesh will be more demanding in terms of machine size and memory but lead to more accurate results in most cases.&lt;/p&gt;
    /// </summary>
    [DataContract]
    public partial class PacefishFinenessModerate : OneOfPacefishAutomeshNewFineness, OneOfRegionRefinementWindComfortNewFineness, OneOfSurfaceRefinementWindComfortNewFineness, OneOfWindComfortMeshWindComfortFineness, IEquatable<PacefishFinenessModerate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PacefishFinenessModerate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PacefishFinenessModerate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PacefishFinenessModerate" /> class.
        /// </summary>
        /// <param name="type">&lt;p&gt;This parameter determines the &lt;b&gt;fineness of the mesh&lt;/b&gt; and affects the overall number of cells. It is recommended to start with the &lt;i&gt;coarse&lt;/i&gt; setting. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/analysis-types/pedestrian-wind-comfort-analysis/mesh-settings/&#39; target&#x3D;&#39;_blank&#39;&gt;Find out more.&lt;/a&gt;&lt;/p&gt;&lt;p&gt;&lt;b&gt;Note:&lt;/b&gt; This setting will impact the accuracy of your results as well as computing time and result size. A finer mesh will be more demanding in terms of machine size and memory but lead to more accurate results in most cases.&lt;/p&gt;  Schema name: PacefishFinenessModerate (required) (default to &quot;MODERATE&quot;).</param>
        public PacefishFinenessModerate(string type = "MODERATE")
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for PacefishFinenessModerate and cannot be null");
        }
        
        /// <summary>
        /// &lt;p&gt;This parameter determines the &lt;b&gt;fineness of the mesh&lt;/b&gt; and affects the overall number of cells. It is recommended to start with the &lt;i&gt;coarse&lt;/i&gt; setting. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/analysis-types/pedestrian-wind-comfort-analysis/mesh-settings/&#39; target&#x3D;&#39;_blank&#39;&gt;Find out more.&lt;/a&gt;&lt;/p&gt;&lt;p&gt;&lt;b&gt;Note:&lt;/b&gt; This setting will impact the accuracy of your results as well as computing time and result size. A finer mesh will be more demanding in terms of machine size and memory but lead to more accurate results in most cases.&lt;/p&gt;  Schema name: PacefishFinenessModerate
        /// </summary>
        /// <value>&lt;p&gt;This parameter determines the &lt;b&gt;fineness of the mesh&lt;/b&gt; and affects the overall number of cells. It is recommended to start with the &lt;i&gt;coarse&lt;/i&gt; setting. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/analysis-types/pedestrian-wind-comfort-analysis/mesh-settings/&#39; target&#x3D;&#39;_blank&#39;&gt;Find out more.&lt;/a&gt;&lt;/p&gt;&lt;p&gt;&lt;b&gt;Note:&lt;/b&gt; This setting will impact the accuracy of your results as well as computing time and result size. A finer mesh will be more demanding in terms of machine size and memory but lead to more accurate results in most cases.&lt;/p&gt;  Schema name: PacefishFinenessModerate</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PacefishFinenessModerate {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as PacefishFinenessModerate);
        }

        /// <summary>
        /// Returns true if PacefishFinenessModerate instances are equal
        /// </summary>
        /// <param name="input">Instance of PacefishFinenessModerate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PacefishFinenessModerate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                return hashCode;
            }
        }

    }

}
