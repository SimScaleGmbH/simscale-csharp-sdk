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
    /// &lt;p&gt;The thermal conductivity of a material is a measure of its ability to conduct heat.&lt;ul&gt;&lt;li&gt;&lt;strong&gt;Isotropic&lt;/strong&gt;: the thermal conductivity &amp;kappa; is the same in all directions.&lt;/li&gt;&lt;li&gt;&lt;strong&gt;Orthotropic&lt;/strong&gt;: the thermal conductivity is unique and independent in three orthogonal directions. It is defined by &amp;kappa;&lt;sub&gt;x&lt;/sub&gt;, &amp;kappa;&lt;sub&gt;y&lt;/sub&gt;, and &amp;kappa;&lt;sub&gt;z&lt;/sub&gt;.&lt;/li&gt;&lt;li&gt;&lt;strong&gt;Cross-plane orthotropic&lt;/strong&gt;: it is defined by an &lt;em&gt;in-plane&lt;/em&gt; conductivity, which is an isotropic conductivity on a given plane, and a &lt;em&gt;cross-plane&lt;strong&gt;&amp;nbsp;&lt;/strong&gt;&lt;/em&gt;conductivity, which acts in the direction normal to the aforementioned plane.&lt;/li&gt;&lt;/ul&gt;&lt;/p&gt;
    /// </summary>
    [DataContract]
    public partial class ConstAnIsoTransport : OneOfSolidCompressibleMaterialTransport, IEquatable<ConstAnIsoTransport>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstAnIsoTransport" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConstAnIsoTransport() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstAnIsoTransport" /> class.
        /// </summary>
        /// <param name="type">&lt;p&gt;The thermal conductivity of a material is a measure of its ability to conduct heat.&lt;ul&gt;&lt;li&gt;&lt;strong&gt;Isotropic&lt;/strong&gt;: the thermal conductivity &amp;kappa; is the same in all directions.&lt;/li&gt;&lt;li&gt;&lt;strong&gt;Orthotropic&lt;/strong&gt;: the thermal conductivity is unique and independent in three orthogonal directions. It is defined by &amp;kappa;&lt;sub&gt;x&lt;/sub&gt;, &amp;kappa;&lt;sub&gt;y&lt;/sub&gt;, and &amp;kappa;&lt;sub&gt;z&lt;/sub&gt;.&lt;/li&gt;&lt;li&gt;&lt;strong&gt;Cross-plane orthotropic&lt;/strong&gt;: it is defined by an &lt;em&gt;in-plane&lt;/em&gt; conductivity, which is an isotropic conductivity on a given plane, and a &lt;em&gt;cross-plane&lt;strong&gt;&amp;nbsp;&lt;/strong&gt;&lt;/em&gt;conductivity, which acts in the direction normal to the aforementioned plane.&lt;/li&gt;&lt;/ul&gt;&lt;/p&gt;  Schema name: ConstAnIsoTransport (required) (default to &quot;CONST_AN_ISO&quot;).</param>
        /// <param name="conductivity">conductivity.</param>
        /// <param name="orientation">orientation.</param>
        /// <param name="thermo">thermo.</param>
        public ConstAnIsoTransport(string type = "CONST_AN_ISO", OrthotropicConductivity conductivity = default(OrthotropicConductivity), OneOfConstAnIsoTransportOrientation orientation = default(OneOfConstAnIsoTransportOrientation), HConstThermo thermo = default(HConstThermo))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for ConstAnIsoTransport and cannot be null");
            this.Conductivity = conductivity;
            this.Orientation = orientation;
            this.Thermo = thermo;
        }
        
        /// <summary>
        /// &lt;p&gt;The thermal conductivity of a material is a measure of its ability to conduct heat.&lt;ul&gt;&lt;li&gt;&lt;strong&gt;Isotropic&lt;/strong&gt;: the thermal conductivity &amp;kappa; is the same in all directions.&lt;/li&gt;&lt;li&gt;&lt;strong&gt;Orthotropic&lt;/strong&gt;: the thermal conductivity is unique and independent in three orthogonal directions. It is defined by &amp;kappa;&lt;sub&gt;x&lt;/sub&gt;, &amp;kappa;&lt;sub&gt;y&lt;/sub&gt;, and &amp;kappa;&lt;sub&gt;z&lt;/sub&gt;.&lt;/li&gt;&lt;li&gt;&lt;strong&gt;Cross-plane orthotropic&lt;/strong&gt;: it is defined by an &lt;em&gt;in-plane&lt;/em&gt; conductivity, which is an isotropic conductivity on a given plane, and a &lt;em&gt;cross-plane&lt;strong&gt;&amp;nbsp;&lt;/strong&gt;&lt;/em&gt;conductivity, which acts in the direction normal to the aforementioned plane.&lt;/li&gt;&lt;/ul&gt;&lt;/p&gt;  Schema name: ConstAnIsoTransport
        /// </summary>
        /// <value>&lt;p&gt;The thermal conductivity of a material is a measure of its ability to conduct heat.&lt;ul&gt;&lt;li&gt;&lt;strong&gt;Isotropic&lt;/strong&gt;: the thermal conductivity &amp;kappa; is the same in all directions.&lt;/li&gt;&lt;li&gt;&lt;strong&gt;Orthotropic&lt;/strong&gt;: the thermal conductivity is unique and independent in three orthogonal directions. It is defined by &amp;kappa;&lt;sub&gt;x&lt;/sub&gt;, &amp;kappa;&lt;sub&gt;y&lt;/sub&gt;, and &amp;kappa;&lt;sub&gt;z&lt;/sub&gt;.&lt;/li&gt;&lt;li&gt;&lt;strong&gt;Cross-plane orthotropic&lt;/strong&gt;: it is defined by an &lt;em&gt;in-plane&lt;/em&gt; conductivity, which is an isotropic conductivity on a given plane, and a &lt;em&gt;cross-plane&lt;strong&gt;&amp;nbsp;&lt;/strong&gt;&lt;/em&gt;conductivity, which acts in the direction normal to the aforementioned plane.&lt;/li&gt;&lt;/ul&gt;&lt;/p&gt;  Schema name: ConstAnIsoTransport</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Conductivity
        /// </summary>
        [DataMember(Name="conductivity", EmitDefaultValue=false)]
        public OrthotropicConductivity Conductivity { get; set; }

        /// <summary>
        /// Gets or Sets Orientation
        /// </summary>
        [DataMember(Name="orientation", EmitDefaultValue=false)]
        public OneOfConstAnIsoTransportOrientation Orientation { get; set; }

        /// <summary>
        /// Gets or Sets Thermo
        /// </summary>
        [DataMember(Name="thermo", EmitDefaultValue=false)]
        public HConstThermo Thermo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConstAnIsoTransport {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Conductivity: ").Append(Conductivity).Append("\n");
            sb.Append("  Orientation: ").Append(Orientation).Append("\n");
            sb.Append("  Thermo: ").Append(Thermo).Append("\n");
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
            return this.Equals(input as ConstAnIsoTransport);
        }

        /// <summary>
        /// Returns true if ConstAnIsoTransport instances are equal
        /// </summary>
        /// <param name="input">Instance of ConstAnIsoTransport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConstAnIsoTransport input)
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
                    this.Conductivity == input.Conductivity ||
                    (this.Conductivity != null &&
                    this.Conductivity.Equals(input.Conductivity))
                ) && 
                (
                    this.Orientation == input.Orientation ||
                    (this.Orientation != null &&
                    this.Orientation.Equals(input.Orientation))
                ) && 
                (
                    this.Thermo == input.Thermo ||
                    (this.Thermo != null &&
                    this.Thermo.Equals(input.Thermo))
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
                if (this.Conductivity != null)
                    hashCode = hashCode * 59 + this.Conductivity.GetHashCode();
                if (this.Orientation != null)
                    hashCode = hashCode * 59 + this.Orientation.GetHashCode();
                if (this.Thermo != null)
                    hashCode = hashCode * 59 + this.Thermo.GetHashCode();
                return hashCode;
            }
        }

    }

}
