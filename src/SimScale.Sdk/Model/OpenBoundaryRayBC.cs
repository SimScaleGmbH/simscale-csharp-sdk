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
    /// &lt;p&gt;&lt;b&gt;Radiative behaviour of the wall&lt;/b&gt;. The Kirchhoff&#39;s law of thermal radiation is applied in all options. This means that the &lt;b&gt;absorptivity of the surface is equal to its emissivity&lt;/b&gt;. &lt;br&gt; &lt;ul&gt;&lt;li&gt;&lt;b&gt;Opaque&lt;/b&gt; is applied to surfaces with transmissivity equal to 0. The radiation that hits the surface will be absorbed and reflected, but not transmitted, e.g.: brick or concrete walls.&lt;/li&gt;&lt;li&gt;&lt;b&gt;Transparent&lt;/b&gt; is applied to surfaces with transmissivity equal to 1. The radiation that hits the surface will be fully transmitted to the other side, e.g.: inlets, outlets or regular windows.&lt;/li&gt;&lt;li&gt;&lt;b&gt;Semi-transparent&lt;/b&gt; is applied to non-fully transparent surfaces. The radiation that hits the surface will be absorbed, reflected and transmitted, e.g. some stained glass windows.&lt;/li&gt;&lt;/ul&gt;&lt;/p&gt;
    /// </summary>
    [DataContract]
    public partial class OpenBoundaryRayBC : OneOfFanBCRadiativeIntensityRay, OneOfPressureInletBCRadiativeIntensityRay, OneOfPressureOutletBCRadiativeIntensityRay, OneOfVelocityInletBCRadiativeIntensityRay, OneOfVelocityOutletBCRadiativeIntensityRay, OneOfWallBCRadiativeIntensityRay, IEquatable<OpenBoundaryRayBC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenBoundaryRayBC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OpenBoundaryRayBC() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenBoundaryRayBC" /> class.
        /// </summary>
        /// <param name="type">&lt;p&gt;&lt;b&gt;Radiative behaviour of the wall&lt;/b&gt;. The Kirchhoff&#39;s law of thermal radiation is applied in all options. This means that the &lt;b&gt;absorptivity of the surface is equal to its emissivity&lt;/b&gt;. &lt;br&gt; &lt;ul&gt;&lt;li&gt;&lt;b&gt;Opaque&lt;/b&gt; is applied to surfaces with transmissivity equal to 0. The radiation that hits the surface will be absorbed and reflected, but not transmitted, e.g.: brick or concrete walls.&lt;/li&gt;&lt;li&gt;&lt;b&gt;Transparent&lt;/b&gt; is applied to surfaces with transmissivity equal to 1. The radiation that hits the surface will be fully transmitted to the other side, e.g.: inlets, outlets or regular windows.&lt;/li&gt;&lt;li&gt;&lt;b&gt;Semi-transparent&lt;/b&gt; is applied to non-fully transparent surfaces. The radiation that hits the surface will be absorbed, reflected and transmitted, e.g. some stained glass windows.&lt;/li&gt;&lt;/ul&gt;&lt;/p&gt;  Schema name: OpenBoundaryRayBC (required) (default to &quot;OPEN_BOUNDARY_RAY&quot;).</param>
        /// <param name="farfieldBlackBodyTemperature">farfieldBlackBodyTemperature.</param>
        public OpenBoundaryRayBC(string type = "OPEN_BOUNDARY_RAY", DimensionalTemperature farfieldBlackBodyTemperature = default(DimensionalTemperature))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for OpenBoundaryRayBC and cannot be null");
            this.FarfieldBlackBodyTemperature = farfieldBlackBodyTemperature;
        }
        
        /// <summary>
        /// &lt;p&gt;&lt;b&gt;Radiative behaviour of the wall&lt;/b&gt;. The Kirchhoff&#39;s law of thermal radiation is applied in all options. This means that the &lt;b&gt;absorptivity of the surface is equal to its emissivity&lt;/b&gt;. &lt;br&gt; &lt;ul&gt;&lt;li&gt;&lt;b&gt;Opaque&lt;/b&gt; is applied to surfaces with transmissivity equal to 0. The radiation that hits the surface will be absorbed and reflected, but not transmitted, e.g.: brick or concrete walls.&lt;/li&gt;&lt;li&gt;&lt;b&gt;Transparent&lt;/b&gt; is applied to surfaces with transmissivity equal to 1. The radiation that hits the surface will be fully transmitted to the other side, e.g.: inlets, outlets or regular windows.&lt;/li&gt;&lt;li&gt;&lt;b&gt;Semi-transparent&lt;/b&gt; is applied to non-fully transparent surfaces. The radiation that hits the surface will be absorbed, reflected and transmitted, e.g. some stained glass windows.&lt;/li&gt;&lt;/ul&gt;&lt;/p&gt;  Schema name: OpenBoundaryRayBC
        /// </summary>
        /// <value>&lt;p&gt;&lt;b&gt;Radiative behaviour of the wall&lt;/b&gt;. The Kirchhoff&#39;s law of thermal radiation is applied in all options. This means that the &lt;b&gt;absorptivity of the surface is equal to its emissivity&lt;/b&gt;. &lt;br&gt; &lt;ul&gt;&lt;li&gt;&lt;b&gt;Opaque&lt;/b&gt; is applied to surfaces with transmissivity equal to 0. The radiation that hits the surface will be absorbed and reflected, but not transmitted, e.g.: brick or concrete walls.&lt;/li&gt;&lt;li&gt;&lt;b&gt;Transparent&lt;/b&gt; is applied to surfaces with transmissivity equal to 1. The radiation that hits the surface will be fully transmitted to the other side, e.g.: inlets, outlets or regular windows.&lt;/li&gt;&lt;li&gt;&lt;b&gt;Semi-transparent&lt;/b&gt; is applied to non-fully transparent surfaces. The radiation that hits the surface will be absorbed, reflected and transmitted, e.g. some stained glass windows.&lt;/li&gt;&lt;/ul&gt;&lt;/p&gt;  Schema name: OpenBoundaryRayBC</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets FarfieldBlackBodyTemperature
        /// </summary>
        [DataMember(Name="farfieldBlackBodyTemperature", EmitDefaultValue=false)]
        public DimensionalTemperature FarfieldBlackBodyTemperature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenBoundaryRayBC {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FarfieldBlackBodyTemperature: ").Append(FarfieldBlackBodyTemperature).Append("\n");
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
            return this.Equals(input as OpenBoundaryRayBC);
        }

        /// <summary>
        /// Returns true if OpenBoundaryRayBC instances are equal
        /// </summary>
        /// <param name="input">Instance of OpenBoundaryRayBC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenBoundaryRayBC input)
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
                    this.FarfieldBlackBodyTemperature == input.FarfieldBlackBodyTemperature ||
                    (this.FarfieldBlackBodyTemperature != null &&
                    this.FarfieldBlackBodyTemperature.Equals(input.FarfieldBlackBodyTemperature))
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
                if (this.FarfieldBlackBodyTemperature != null)
                    hashCode = hashCode * 59 + this.FarfieldBlackBodyTemperature.GetHashCode();
                return hashCode;
            }
        }

    }

}
