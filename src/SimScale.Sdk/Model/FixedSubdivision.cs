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
    /// FixedSubdivision
    /// </summary>
    [DataContract]
    public partial class FixedSubdivision : IEquatable<FixedSubdivision>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FixedSubdivision" /> class.
        /// </summary>
        /// <param name="numSubdivisions">&lt;p&gt;Define the number of equal subdivisions of a time step in case of an adaptation event.&lt;/p&gt; (default to 4).</param>
        /// <param name="maxSubdivisionDepth">&lt;p&gt;Define maximum depth of the timestep subdivisions. If this value is exceeded the computation will stop. Example: If this value is set to 3, the number of subdivisions to 2 and the initial time step length is set to 1 sec, than the maximum depth is reached after 3 consecutive subdivisions (e.g. a time step of 1/8 sec based on &lt;i&gt;1.(1/2)&lt;sup&gt;3&lt;/sup&gt;&lt;/i&gt;).&lt;/p&gt; (default to 3).</param>
        public FixedSubdivision(int? numSubdivisions = default(int?), int? maxSubdivisionDepth = default(int?))
        {
            this.NumSubdivisions = numSubdivisions;
            this.MaxSubdivisionDepth = maxSubdivisionDepth;
        }
        
        /// <summary>
        /// &lt;p&gt;Define the number of equal subdivisions of a time step in case of an adaptation event.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Define the number of equal subdivisions of a time step in case of an adaptation event.&lt;/p&gt;</value>
        [DataMember(Name="numSubdivisions", EmitDefaultValue=false)]
        public int? NumSubdivisions { get; set; }

        /// <summary>
        /// &lt;p&gt;Define maximum depth of the timestep subdivisions. If this value is exceeded the computation will stop. Example: If this value is set to 3, the number of subdivisions to 2 and the initial time step length is set to 1 sec, than the maximum depth is reached after 3 consecutive subdivisions (e.g. a time step of 1/8 sec based on &lt;i&gt;1.(1/2)&lt;sup&gt;3&lt;/sup&gt;&lt;/i&gt;).&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Define maximum depth of the timestep subdivisions. If this value is exceeded the computation will stop. Example: If this value is set to 3, the number of subdivisions to 2 and the initial time step length is set to 1 sec, than the maximum depth is reached after 3 consecutive subdivisions (e.g. a time step of 1/8 sec based on &lt;i&gt;1.(1/2)&lt;sup&gt;3&lt;/sup&gt;&lt;/i&gt;).&lt;/p&gt;</value>
        [DataMember(Name="maxSubdivisionDepth", EmitDefaultValue=false)]
        public int? MaxSubdivisionDepth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FixedSubdivision {\n");
            sb.Append("  NumSubdivisions: ").Append(NumSubdivisions).Append("\n");
            sb.Append("  MaxSubdivisionDepth: ").Append(MaxSubdivisionDepth).Append("\n");
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
            return this.Equals(input as FixedSubdivision);
        }

        /// <summary>
        /// Returns true if FixedSubdivision instances are equal
        /// </summary>
        /// <param name="input">Instance of FixedSubdivision to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FixedSubdivision input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumSubdivisions == input.NumSubdivisions ||
                    (this.NumSubdivisions != null &&
                    this.NumSubdivisions.Equals(input.NumSubdivisions))
                ) && 
                (
                    this.MaxSubdivisionDepth == input.MaxSubdivisionDepth ||
                    (this.MaxSubdivisionDepth != null &&
                    this.MaxSubdivisionDepth.Equals(input.MaxSubdivisionDepth))
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
                if (this.NumSubdivisions != null)
                    hashCode = hashCode * 59 + this.NumSubdivisions.GetHashCode();
                if (this.MaxSubdivisionDepth != null)
                    hashCode = hashCode * 59 + this.MaxSubdivisionDepth.GetHashCode();
                return hashCode;
            }
        }

    }

}
