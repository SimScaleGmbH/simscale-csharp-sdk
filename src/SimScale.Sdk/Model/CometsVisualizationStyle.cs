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
    /// CometsVisualizationStyle
    /// </summary>
    [DataContract]
    public partial class CometsVisualizationStyle : OneOfVisualizationStyle, IEquatable<CometsVisualizationStyle>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CometsVisualizationStyle" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CometsVisualizationStyle() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CometsVisualizationStyle" /> class.
        /// </summary>
        /// <param name="representation">The representation to use for particle traces. (required) (default to &quot;COMETS&quot;).</param>
        /// <param name="numPulses">This value specifies how many pulses there should be in the model. (required) (default to 15).</param>
        /// <param name="relativeCometLength">The length of the tail of the comets. It is specified in time and is a fraction of the global total time range for all particles in this particle trace. For example, if the total trace time is 2, and the relativeCometLength is 0.01, then the length of the tail will be 0.02. (required) (default to 0.000010D).</param>
        public CometsVisualizationStyle(string representation = "COMETS", int? numPulses = 15, double? relativeCometLength = 0.000010D)
        {
            // to ensure "representation" is required (not null)
            this.Representation = representation ?? throw new ArgumentNullException("representation is a required property for CometsVisualizationStyle and cannot be null");
            // to ensure "numPulses" is required (not null)
            this.NumPulses = numPulses ?? throw new ArgumentNullException("numPulses is a required property for CometsVisualizationStyle and cannot be null");
            // to ensure "relativeCometLength" is required (not null)
            this.RelativeCometLength = relativeCometLength ?? throw new ArgumentNullException("relativeCometLength is a required property for CometsVisualizationStyle and cannot be null");
        }
        
        /// <summary>
        /// The representation to use for particle traces.
        /// </summary>
        /// <value>The representation to use for particle traces.</value>
        [DataMember(Name="representation", EmitDefaultValue=false)]
        public string Representation { get; set; }

        /// <summary>
        /// This value specifies how many pulses there should be in the model.
        /// </summary>
        /// <value>This value specifies how many pulses there should be in the model.</value>
        [DataMember(Name="numPulses", EmitDefaultValue=false)]
        public int? NumPulses { get; set; }

        /// <summary>
        /// The length of the tail of the comets. It is specified in time and is a fraction of the global total time range for all particles in this particle trace. For example, if the total trace time is 2, and the relativeCometLength is 0.01, then the length of the tail will be 0.02.
        /// </summary>
        /// <value>The length of the tail of the comets. It is specified in time and is a fraction of the global total time range for all particles in this particle trace. For example, if the total trace time is 2, and the relativeCometLength is 0.01, then the length of the tail will be 0.02.</value>
        [DataMember(Name="relativeCometLength", EmitDefaultValue=false)]
        public double? RelativeCometLength { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CometsVisualizationStyle {\n");
            sb.Append("  Representation: ").Append(Representation).Append("\n");
            sb.Append("  NumPulses: ").Append(NumPulses).Append("\n");
            sb.Append("  RelativeCometLength: ").Append(RelativeCometLength).Append("\n");
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
            return this.Equals(input as CometsVisualizationStyle);
        }

        /// <summary>
        /// Returns true if CometsVisualizationStyle instances are equal
        /// </summary>
        /// <param name="input">Instance of CometsVisualizationStyle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CometsVisualizationStyle input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Representation == input.Representation ||
                    (this.Representation != null &&
                    this.Representation.Equals(input.Representation))
                ) && 
                (
                    this.NumPulses == input.NumPulses ||
                    (this.NumPulses != null &&
                    this.NumPulses.Equals(input.NumPulses))
                ) && 
                (
                    this.RelativeCometLength == input.RelativeCometLength ||
                    (this.RelativeCometLength != null &&
                    this.RelativeCometLength.Equals(input.RelativeCometLength))
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
                if (this.Representation != null)
                    hashCode = hashCode * 59 + this.Representation.GetHashCode();
                if (this.NumPulses != null)
                    hashCode = hashCode * 59 + this.NumPulses.GetHashCode();
                if (this.RelativeCometLength != null)
                    hashCode = hashCode * 59 + this.RelativeCometLength.GetHashCode();
                return hashCode;
            }
        }

    }

}