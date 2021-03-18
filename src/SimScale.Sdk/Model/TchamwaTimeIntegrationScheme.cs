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
    /// TchamwaTimeIntegrationScheme
    /// </summary>
    [DataContract]
    public partial class TchamwaTimeIntegrationScheme : OneOfExplicitTimeIntegrationTypeScheme, IEquatable<TchamwaTimeIntegrationScheme>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TchamwaTimeIntegrationScheme" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TchamwaTimeIntegrationScheme() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TchamwaTimeIntegrationScheme" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;TCHAMWA&quot;).</param>
        /// <param name="phi">&lt;p&gt;The parameter &lt;b&gt;&amp;phi;&lt;/b&gt; allows inducing numerical damping. For &lt;b&gt;&amp;phi;&lt;/b&gt; &#x3D; 1.0 there is no numerical damping whereas for &lt;b&gt;&amp;phi;&lt;/b&gt; &gt; 1.0&lt;/p&gt; the damping grows with the parameter value. It is thus not recommended to use a value for &lt;b&gt;&amp;phi;&lt;/b&gt; greater than 1.1.&lt;/p&gt; (default to 1.05M).</param>
        public TchamwaTimeIntegrationScheme(string type = "TCHAMWA", decimal? phi = default(decimal?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for TchamwaTimeIntegrationScheme and cannot be null");
            this.Phi = phi;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// &lt;p&gt;The parameter &lt;b&gt;&amp;phi;&lt;/b&gt; allows inducing numerical damping. For &lt;b&gt;&amp;phi;&lt;/b&gt; &#x3D; 1.0 there is no numerical damping whereas for &lt;b&gt;&amp;phi;&lt;/b&gt; &gt; 1.0&lt;/p&gt; the damping grows with the parameter value. It is thus not recommended to use a value for &lt;b&gt;&amp;phi;&lt;/b&gt; greater than 1.1.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;The parameter &lt;b&gt;&amp;phi;&lt;/b&gt; allows inducing numerical damping. For &lt;b&gt;&amp;phi;&lt;/b&gt; &#x3D; 1.0 there is no numerical damping whereas for &lt;b&gt;&amp;phi;&lt;/b&gt; &gt; 1.0&lt;/p&gt; the damping grows with the parameter value. It is thus not recommended to use a value for &lt;b&gt;&amp;phi;&lt;/b&gt; greater than 1.1.&lt;/p&gt;</value>
        [DataMember(Name="phi", EmitDefaultValue=false)]
        public decimal? Phi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TchamwaTimeIntegrationScheme {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Phi: ").Append(Phi).Append("\n");
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
            return this.Equals(input as TchamwaTimeIntegrationScheme);
        }

        /// <summary>
        /// Returns true if TchamwaTimeIntegrationScheme instances are equal
        /// </summary>
        /// <param name="input">Instance of TchamwaTimeIntegrationScheme to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TchamwaTimeIntegrationScheme input)
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
                    this.Phi == input.Phi ||
                    (this.Phi != null &&
                    this.Phi.Equals(input.Phi))
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
                if (this.Phi != null)
                    hashCode = hashCode * 59 + this.Phi.GetHashCode();
                return hashCode;
            }
        }

    }

}