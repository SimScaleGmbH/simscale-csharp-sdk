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
    /// &lt;i&gt;Humidity sources&lt;/i&gt; can be used to simulate humidity generation or purification from a volume. Three types are available:&lt;br&gt;&lt;li&gt;&lt;b&gt;Species source&lt;/b&gt; (recommended)&lt;/li&gt;: Used when the mass of the species entering the fluid domain per second are known.&lt;li&gt;&lt;b&gt;Absolute humidity source&lt;/b&gt;&lt;/li&gt;: Used when the local change of the absolute humidity over time is known.&lt;li&gt;&lt;b&gt;Specific humidity source&lt;/b&gt;&lt;/li&gt;: Similar to absolute humidity source but for the specific humidity.
    /// </summary>
    [DataContract]
    public partial class AbsoluteHumiditySource : OneOfAdvancedConceptsHumiditySources, IEquatable<AbsoluteHumiditySource>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbsoluteHumiditySource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AbsoluteHumiditySource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbsoluteHumiditySource" /> class.
        /// </summary>
        /// <param name="type">&lt;i&gt;Humidity sources&lt;/i&gt; can be used to simulate humidity generation or purification from a volume. Three types are available:&lt;br&gt;&lt;li&gt;&lt;b&gt;Species source&lt;/b&gt; (recommended)&lt;/li&gt;: Used when the mass of the species entering the fluid domain per second are known.&lt;li&gt;&lt;b&gt;Absolute humidity source&lt;/b&gt;&lt;/li&gt;: Used when the local change of the absolute humidity over time is known.&lt;li&gt;&lt;b&gt;Specific humidity source&lt;/b&gt;&lt;/li&gt;: Similar to absolute humidity source but for the specific humidity.  Schema name: AbsoluteHumiditySource (required) (default to &quot;ABSOLUTE_HUMIDITY_RATE&quot;).</param>
        /// <param name="name">name.</param>
        /// <param name="absoluteHumidityRate">absoluteHumidityRate.</param>
        /// <param name="topologicalReference">topologicalReference.</param>
        /// <param name="geometryPrimitiveUuids">geometryPrimitiveUuids.</param>
        public AbsoluteHumiditySource(string type = "ABSOLUTE_HUMIDITY_RATE", string name = default(string), DimensionalAbsoluteHumidityRate absoluteHumidityRate = default(DimensionalAbsoluteHumidityRate), TopologicalReference topologicalReference = default(TopologicalReference), List<Guid?> geometryPrimitiveUuids = default(List<Guid?>))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for AbsoluteHumiditySource and cannot be null");
            this.Name = name;
            this.AbsoluteHumidityRate = absoluteHumidityRate;
            this.TopologicalReference = topologicalReference;
            this.GeometryPrimitiveUuids = geometryPrimitiveUuids;
        }
        
        /// <summary>
        /// &lt;i&gt;Humidity sources&lt;/i&gt; can be used to simulate humidity generation or purification from a volume. Three types are available:&lt;br&gt;&lt;li&gt;&lt;b&gt;Species source&lt;/b&gt; (recommended)&lt;/li&gt;: Used when the mass of the species entering the fluid domain per second are known.&lt;li&gt;&lt;b&gt;Absolute humidity source&lt;/b&gt;&lt;/li&gt;: Used when the local change of the absolute humidity over time is known.&lt;li&gt;&lt;b&gt;Specific humidity source&lt;/b&gt;&lt;/li&gt;: Similar to absolute humidity source but for the specific humidity.  Schema name: AbsoluteHumiditySource
        /// </summary>
        /// <value>&lt;i&gt;Humidity sources&lt;/i&gt; can be used to simulate humidity generation or purification from a volume. Three types are available:&lt;br&gt;&lt;li&gt;&lt;b&gt;Species source&lt;/b&gt; (recommended)&lt;/li&gt;: Used when the mass of the species entering the fluid domain per second are known.&lt;li&gt;&lt;b&gt;Absolute humidity source&lt;/b&gt;&lt;/li&gt;: Used when the local change of the absolute humidity over time is known.&lt;li&gt;&lt;b&gt;Specific humidity source&lt;/b&gt;&lt;/li&gt;: Similar to absolute humidity source but for the specific humidity.  Schema name: AbsoluteHumiditySource</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AbsoluteHumidityRate
        /// </summary>
        [DataMember(Name="absoluteHumidityRate", EmitDefaultValue=false)]
        public DimensionalAbsoluteHumidityRate AbsoluteHumidityRate { get; set; }

        /// <summary>
        /// Gets or Sets TopologicalReference
        /// </summary>
        [DataMember(Name="topologicalReference", EmitDefaultValue=false)]
        public TopologicalReference TopologicalReference { get; set; }

        /// <summary>
        /// Gets or Sets GeometryPrimitiveUuids
        /// </summary>
        [DataMember(Name="geometryPrimitiveUuids", EmitDefaultValue=false)]
        public List<Guid?> GeometryPrimitiveUuids { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbsoluteHumiditySource {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AbsoluteHumidityRate: ").Append(AbsoluteHumidityRate).Append("\n");
            sb.Append("  TopologicalReference: ").Append(TopologicalReference).Append("\n");
            sb.Append("  GeometryPrimitiveUuids: ").Append(GeometryPrimitiveUuids).Append("\n");
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
            return this.Equals(input as AbsoluteHumiditySource);
        }

        /// <summary>
        /// Returns true if AbsoluteHumiditySource instances are equal
        /// </summary>
        /// <param name="input">Instance of AbsoluteHumiditySource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbsoluteHumiditySource input)
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
                    this.AbsoluteHumidityRate == input.AbsoluteHumidityRate ||
                    (this.AbsoluteHumidityRate != null &&
                    this.AbsoluteHumidityRate.Equals(input.AbsoluteHumidityRate))
                ) && 
                (
                    this.TopologicalReference == input.TopologicalReference ||
                    (this.TopologicalReference != null &&
                    this.TopologicalReference.Equals(input.TopologicalReference))
                ) && 
                (
                    this.GeometryPrimitiveUuids == input.GeometryPrimitiveUuids ||
                    this.GeometryPrimitiveUuids != null &&
                    input.GeometryPrimitiveUuids != null &&
                    this.GeometryPrimitiveUuids.SequenceEqual(input.GeometryPrimitiveUuids)
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
                if (this.AbsoluteHumidityRate != null)
                    hashCode = hashCode * 59 + this.AbsoluteHumidityRate.GetHashCode();
                if (this.TopologicalReference != null)
                    hashCode = hashCode * 59 + this.TopologicalReference.GetHashCode();
                if (this.GeometryPrimitiveUuids != null)
                    hashCode = hashCode * 59 + this.GeometryPrimitiveUuids.GetHashCode();
                return hashCode;
            }
        }

    }

}