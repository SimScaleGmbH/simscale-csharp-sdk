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
    /// FixedAugmentation
    /// </summary>
    [DataContract]
    public partial class FixedAugmentation : IEquatable<FixedAugmentation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedAugmentation" /> class.
        /// </summary>
        /// <param name="newtonIterationThreshold">&lt;p&gt;&lt;b&gt;Newton Iteration threshold&lt;/b&gt; defines the threshold below which the actual number of Newton Iterations has to fall in order to increase the time step by the percentage given by &lt;b&gt;Timestep Augmentation&lt;/b&gt;.&lt;/p&gt; (default to 5).</param>
        /// <param name="timestepAugmentation">&lt;p&gt;&lt;b&gt;Newton Iteration threshold&lt;/b&gt; defines the threshold below which the actual number of Newton Iterations has to fall in order to increase the time step by the percentage given by &lt;b&gt;Timestep Augmentation&lt;/b&gt;.&lt;/p&gt; (default to 100M).</param>
        public FixedAugmentation(int? newtonIterationThreshold = default(int?), decimal? timestepAugmentation = default(decimal?))
        {
            this.NewtonIterationThreshold = newtonIterationThreshold;
            this.TimestepAugmentation = timestepAugmentation;
        }
        
        /// <summary>
        /// &lt;p&gt;&lt;b&gt;Newton Iteration threshold&lt;/b&gt; defines the threshold below which the actual number of Newton Iterations has to fall in order to increase the time step by the percentage given by &lt;b&gt;Timestep Augmentation&lt;/b&gt;.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;&lt;b&gt;Newton Iteration threshold&lt;/b&gt; defines the threshold below which the actual number of Newton Iterations has to fall in order to increase the time step by the percentage given by &lt;b&gt;Timestep Augmentation&lt;/b&gt;.&lt;/p&gt;</value>
        [DataMember(Name="newtonIterationThreshold", EmitDefaultValue=false)]
        public int? NewtonIterationThreshold { get; set; }

        /// <summary>
        /// &lt;p&gt;&lt;b&gt;Newton Iteration threshold&lt;/b&gt; defines the threshold below which the actual number of Newton Iterations has to fall in order to increase the time step by the percentage given by &lt;b&gt;Timestep Augmentation&lt;/b&gt;.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;&lt;b&gt;Newton Iteration threshold&lt;/b&gt; defines the threshold below which the actual number of Newton Iterations has to fall in order to increase the time step by the percentage given by &lt;b&gt;Timestep Augmentation&lt;/b&gt;.&lt;/p&gt;</value>
        [DataMember(Name="timestepAugmentation", EmitDefaultValue=false)]
        public decimal? TimestepAugmentation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FixedAugmentation {\n");
            sb.Append("  NewtonIterationThreshold: ").Append(NewtonIterationThreshold).Append("\n");
            sb.Append("  TimestepAugmentation: ").Append(TimestepAugmentation).Append("\n");
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
            return this.Equals(input as FixedAugmentation);
        }

        /// <summary>
        /// Returns true if FixedAugmentation instances are equal
        /// </summary>
        /// <param name="input">Instance of FixedAugmentation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FixedAugmentation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewtonIterationThreshold == input.NewtonIterationThreshold ||
                    (this.NewtonIterationThreshold != null &&
                    this.NewtonIterationThreshold.Equals(input.NewtonIterationThreshold))
                ) && 
                (
                    this.TimestepAugmentation == input.TimestepAugmentation ||
                    (this.TimestepAugmentation != null &&
                    this.TimestepAugmentation.Equals(input.TimestepAugmentation))
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
                if (this.NewtonIterationThreshold != null)
                    hashCode = hashCode * 59 + this.NewtonIterationThreshold.GetHashCode();
                if (this.TimestepAugmentation != null)
                    hashCode = hashCode * 59 + this.TimestepAugmentation.GetHashCode();
                return hashCode;
            }
        }

    }

}