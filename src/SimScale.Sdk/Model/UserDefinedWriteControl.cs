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
    /// &lt;p&gt;Define how frequently intermediate results should be saved. With the selection of &lt;b&gt;initial time steps&lt;/b&gt; only the user defined time steps are stored in the result and by selecting &lt;b&gt;all computed time steps&lt;/b&gt; also intermediate results that were created by the automatic time stepping are saved. With the selection of &lt;b&gt;write interval&lt;/b&gt; a specific write frequency can be chosen which reduces the result size. Finally using &lt;b&gt;user defined time steps&lt;/b&gt; there can either be a constant time increment for result storage given or a table with varying time intervals analogous to the &lt;b&gt;time step length&lt;/b&gt; definition.&lt;/p&gt;
    /// </summary>
    [DataContract]
    public partial class UserDefinedWriteControl : OneOfSolidSimulationControlWriteControlDefinition, IEquatable<UserDefinedWriteControl>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDefinedWriteControl" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserDefinedWriteControl() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDefinedWriteControl" /> class.
        /// </summary>
        /// <param name="type">&lt;p&gt;Define how frequently intermediate results should be saved. With the selection of &lt;b&gt;initial time steps&lt;/b&gt; only the user defined time steps are stored in the result and by selecting &lt;b&gt;all computed time steps&lt;/b&gt; also intermediate results that were created by the automatic time stepping are saved. With the selection of &lt;b&gt;write interval&lt;/b&gt; a specific write frequency can be chosen which reduces the result size. Finally using &lt;b&gt;user defined time steps&lt;/b&gt; there can either be a constant time increment for result storage given or a table with varying time intervals analogous to the &lt;b&gt;time step length&lt;/b&gt; definition.&lt;/p&gt;  Schema name: UserDefinedWriteControl (required) (default to &quot;USER_DEFINED_V21&quot;).</param>
        /// <param name="writeIncrement">writeIncrement.</param>
        public UserDefinedWriteControl(string type = "USER_DEFINED_V21", RestrictedDimensionalFunctionTime writeIncrement = default(RestrictedDimensionalFunctionTime))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for UserDefinedWriteControl and cannot be null");
            this.WriteIncrement = writeIncrement;
        }
        
        /// <summary>
        /// &lt;p&gt;Define how frequently intermediate results should be saved. With the selection of &lt;b&gt;initial time steps&lt;/b&gt; only the user defined time steps are stored in the result and by selecting &lt;b&gt;all computed time steps&lt;/b&gt; also intermediate results that were created by the automatic time stepping are saved. With the selection of &lt;b&gt;write interval&lt;/b&gt; a specific write frequency can be chosen which reduces the result size. Finally using &lt;b&gt;user defined time steps&lt;/b&gt; there can either be a constant time increment for result storage given or a table with varying time intervals analogous to the &lt;b&gt;time step length&lt;/b&gt; definition.&lt;/p&gt;  Schema name: UserDefinedWriteControl
        /// </summary>
        /// <value>&lt;p&gt;Define how frequently intermediate results should be saved. With the selection of &lt;b&gt;initial time steps&lt;/b&gt; only the user defined time steps are stored in the result and by selecting &lt;b&gt;all computed time steps&lt;/b&gt; also intermediate results that were created by the automatic time stepping are saved. With the selection of &lt;b&gt;write interval&lt;/b&gt; a specific write frequency can be chosen which reduces the result size. Finally using &lt;b&gt;user defined time steps&lt;/b&gt; there can either be a constant time increment for result storage given or a table with varying time intervals analogous to the &lt;b&gt;time step length&lt;/b&gt; definition.&lt;/p&gt;  Schema name: UserDefinedWriteControl</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets WriteIncrement
        /// </summary>
        [DataMember(Name="writeIncrement", EmitDefaultValue=false)]
        public RestrictedDimensionalFunctionTime WriteIncrement { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserDefinedWriteControl {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  WriteIncrement: ").Append(WriteIncrement).Append("\n");
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
            return this.Equals(input as UserDefinedWriteControl);
        }

        /// <summary>
        /// Returns true if UserDefinedWriteControl instances are equal
        /// </summary>
        /// <param name="input">Instance of UserDefinedWriteControl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserDefinedWriteControl input)
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
                    this.WriteIncrement == input.WriteIncrement ||
                    (this.WriteIncrement != null &&
                    this.WriteIncrement.Equals(input.WriteIncrement))
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
                if (this.WriteIncrement != null)
                    hashCode = hashCode * 59 + this.WriteIncrement.GetHashCode();
                return hashCode;
            }
        }

    }

}
