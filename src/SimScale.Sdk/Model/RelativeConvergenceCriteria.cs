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
    /// RelativeConvergenceCriteria
    /// </summary>
    [DataContract]
    public partial class RelativeConvergenceCriteria : OneOfNewtonKrylovResolutionTypeConvergenceCriteria, OneOfNewtonResolutionTypeConvergenceCriteria, IEquatable<RelativeConvergenceCriteria>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelativeConvergenceCriteria" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RelativeConvergenceCriteria() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RelativeConvergenceCriteria" /> class.
        /// </summary>
        /// <param name="type">Schema name: RelativeConvergenceCriteria (required) (default to &quot;RELATIVE&quot;).</param>
        /// <param name="tolerance">&lt;p&gt;Set the threshold value for the relative convergence criterion. With this criterion, the solver considers a time step as converged if the maximum relative residual - - the maximum absolute residual divided by external loads and support reactions - - in a Newton iteration falls below the given value.&lt;/p&gt;Important remarks: This value is a compromise between solution time and accuracy. A larger value leads to a faster solution time at the cost of losing accuracy in each Newton iteration and possibly causing convergence problems in the following steps. We recommend an upper limit of 1&lt;sup&gt;-3&lt;/sup&gt;. (default to 0.000050M).</param>
        public RelativeConvergenceCriteria(string type = "RELATIVE", decimal? tolerance = default(decimal?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for RelativeConvergenceCriteria and cannot be null");
            this.Tolerance = tolerance;
        }
        
        /// <summary>
        /// Schema name: RelativeConvergenceCriteria
        /// </summary>
        /// <value>Schema name: RelativeConvergenceCriteria</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// &lt;p&gt;Set the threshold value for the relative convergence criterion. With this criterion, the solver considers a time step as converged if the maximum relative residual - - the maximum absolute residual divided by external loads and support reactions - - in a Newton iteration falls below the given value.&lt;/p&gt;Important remarks: This value is a compromise between solution time and accuracy. A larger value leads to a faster solution time at the cost of losing accuracy in each Newton iteration and possibly causing convergence problems in the following steps. We recommend an upper limit of 1&lt;sup&gt;-3&lt;/sup&gt;.
        /// </summary>
        /// <value>&lt;p&gt;Set the threshold value for the relative convergence criterion. With this criterion, the solver considers a time step as converged if the maximum relative residual - - the maximum absolute residual divided by external loads and support reactions - - in a Newton iteration falls below the given value.&lt;/p&gt;Important remarks: This value is a compromise between solution time and accuracy. A larger value leads to a faster solution time at the cost of losing accuracy in each Newton iteration and possibly causing convergence problems in the following steps. We recommend an upper limit of 1&lt;sup&gt;-3&lt;/sup&gt;.</value>
        [DataMember(Name="tolerance", EmitDefaultValue=false)]
        public decimal? Tolerance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelativeConvergenceCriteria {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Tolerance: ").Append(Tolerance).Append("\n");
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
            return this.Equals(input as RelativeConvergenceCriteria);
        }

        /// <summary>
        /// Returns true if RelativeConvergenceCriteria instances are equal
        /// </summary>
        /// <param name="input">Instance of RelativeConvergenceCriteria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelativeConvergenceCriteria input)
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
                    this.Tolerance == input.Tolerance ||
                    (this.Tolerance != null &&
                    this.Tolerance.Equals(input.Tolerance))
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
                if (this.Tolerance != null)
                    hashCode = hashCode * 59 + this.Tolerance.GetHashCode();
                return hashCode;
            }
        }

    }

}
