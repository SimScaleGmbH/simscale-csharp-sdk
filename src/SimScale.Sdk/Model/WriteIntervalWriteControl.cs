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
    public partial class WriteIntervalWriteControl : OneOfSolidSimulationControlWriteControlDefinition, IEquatable<WriteIntervalWriteControl>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WriteIntervalWriteControl" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WriteIntervalWriteControl() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WriteIntervalWriteControl" /> class.
        /// </summary>
        /// <param name="type">&lt;p&gt;Define how frequently intermediate results should be saved. With the selection of &lt;b&gt;initial time steps&lt;/b&gt; only the user defined time steps are stored in the result and by selecting &lt;b&gt;all computed time steps&lt;/b&gt; also intermediate results that were created by the automatic time stepping are saved. With the selection of &lt;b&gt;write interval&lt;/b&gt; a specific write frequency can be chosen which reduces the result size. Finally using &lt;b&gt;user defined time steps&lt;/b&gt; there can either be a constant time increment for result storage given or a table with varying time intervals analogous to the &lt;b&gt;time step length&lt;/b&gt; definition.&lt;/p&gt;  Schema name: WriteIntervalWriteControl (required) (default to &quot;WRITE_INTERVAL&quot;).</param>
        /// <param name="writeInterval">&lt;p&gt;Define the write frequency of the intermediate results to the result file. Selecting a write interval of 2 means that every second computed time step is saved in the final result database, independently if it is a pre-defined user time step or an intermediate one that was added during automatic time stepping. &lt;/p&gt; (default to 5).</param>
        public WriteIntervalWriteControl(string type = "WRITE_INTERVAL", int? writeInterval = default(int?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for WriteIntervalWriteControl and cannot be null");
            this.WriteInterval = writeInterval;
        }
        
        /// <summary>
        /// &lt;p&gt;Define how frequently intermediate results should be saved. With the selection of &lt;b&gt;initial time steps&lt;/b&gt; only the user defined time steps are stored in the result and by selecting &lt;b&gt;all computed time steps&lt;/b&gt; also intermediate results that were created by the automatic time stepping are saved. With the selection of &lt;b&gt;write interval&lt;/b&gt; a specific write frequency can be chosen which reduces the result size. Finally using &lt;b&gt;user defined time steps&lt;/b&gt; there can either be a constant time increment for result storage given or a table with varying time intervals analogous to the &lt;b&gt;time step length&lt;/b&gt; definition.&lt;/p&gt;  Schema name: WriteIntervalWriteControl
        /// </summary>
        /// <value>&lt;p&gt;Define how frequently intermediate results should be saved. With the selection of &lt;b&gt;initial time steps&lt;/b&gt; only the user defined time steps are stored in the result and by selecting &lt;b&gt;all computed time steps&lt;/b&gt; also intermediate results that were created by the automatic time stepping are saved. With the selection of &lt;b&gt;write interval&lt;/b&gt; a specific write frequency can be chosen which reduces the result size. Finally using &lt;b&gt;user defined time steps&lt;/b&gt; there can either be a constant time increment for result storage given or a table with varying time intervals analogous to the &lt;b&gt;time step length&lt;/b&gt; definition.&lt;/p&gt;  Schema name: WriteIntervalWriteControl</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// &lt;p&gt;Define the write frequency of the intermediate results to the result file. Selecting a write interval of 2 means that every second computed time step is saved in the final result database, independently if it is a pre-defined user time step or an intermediate one that was added during automatic time stepping. &lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Define the write frequency of the intermediate results to the result file. Selecting a write interval of 2 means that every second computed time step is saved in the final result database, independently if it is a pre-defined user time step or an intermediate one that was added during automatic time stepping. &lt;/p&gt;</value>
        [DataMember(Name="writeInterval", EmitDefaultValue=false)]
        public int? WriteInterval { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WriteIntervalWriteControl {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  WriteInterval: ").Append(WriteInterval).Append("\n");
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
            return this.Equals(input as WriteIntervalWriteControl);
        }

        /// <summary>
        /// Returns true if WriteIntervalWriteControl instances are equal
        /// </summary>
        /// <param name="input">Instance of WriteIntervalWriteControl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WriteIntervalWriteControl input)
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
                    this.WriteInterval == input.WriteInterval ||
                    (this.WriteInterval != null &&
                    this.WriteInterval.Equals(input.WriteInterval))
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
                if (this.WriteInterval != null)
                    hashCode = hashCode * 59 + this.WriteInterval.GetHashCode();
                return hashCode;
            }
        }

    }

}
