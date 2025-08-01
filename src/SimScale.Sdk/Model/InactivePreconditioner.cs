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
    /// InactivePreconditioner
    /// </summary>
    [DataContract]
    public partial class InactivePreconditioner : OneOfAdvancedPETSCSettingsPreconditioner, IEquatable<InactivePreconditioner>
    {
        /// <summary>
        /// Choose the renumbering method for the system matrix entries:&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;RCMK&lt;/b&gt; uses the algorithm of &lt;i&gt;Reverse Cuthill-MacKee&lt;/i&gt; for the renumbering. It often effectively reduces the matrig storage space and the matrix factorization time.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;When &lt;b&gt;inactive&lt;/b&gt; is selected no renumbering is done. This option should only be chosen for testing purposes.&lt;/p&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>Choose the renumbering method for the system matrix entries:&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;RCMK&lt;/b&gt; uses the algorithm of &lt;i&gt;Reverse Cuthill-MacKee&lt;/i&gt; for the renumbering. It often effectively reduces the matrig storage space and the matrix factorization time.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;When &lt;b&gt;inactive&lt;/b&gt; is selected no renumbering is done. This option should only be chosen for testing purposes.&lt;/p&gt;&lt;/ul&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RenumberingMethodEnum
        {
            /// <summary>
            /// Enum RCMK for value: RCMK
            /// </summary>
            [EnumMember(Value = "RCMK")]
            RCMK = 1,

            /// <summary>
            /// Enum INACTIVE for value: INACTIVE
            /// </summary>
            [EnumMember(Value = "INACTIVE")]
            INACTIVE = 2

        }

        /// <summary>
        /// Choose the renumbering method for the system matrix entries:&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;RCMK&lt;/b&gt; uses the algorithm of &lt;i&gt;Reverse Cuthill-MacKee&lt;/i&gt; for the renumbering. It often effectively reduces the matrig storage space and the matrix factorization time.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;When &lt;b&gt;inactive&lt;/b&gt; is selected no renumbering is done. This option should only be chosen for testing purposes.&lt;/p&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>Choose the renumbering method for the system matrix entries:&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;RCMK&lt;/b&gt; uses the algorithm of &lt;i&gt;Reverse Cuthill-MacKee&lt;/i&gt; for the renumbering. It often effectively reduces the matrig storage space and the matrix factorization time.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;When &lt;b&gt;inactive&lt;/b&gt; is selected no renumbering is done. This option should only be chosen for testing purposes.&lt;/p&gt;&lt;/ul&gt;</value>
        [DataMember(Name="renumberingMethod", EmitDefaultValue=false)]
        public RenumberingMethodEnum? RenumberingMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InactivePreconditioner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InactivePreconditioner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InactivePreconditioner" /> class.
        /// </summary>
        /// <param name="type">Schema name: InactivePreconditioner (required) (default to &quot;INACTIVE&quot;).</param>
        /// <param name="renumberingMethod">Choose the renumbering method for the system matrix entries:&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;RCMK&lt;/b&gt; uses the algorithm of &lt;i&gt;Reverse Cuthill-MacKee&lt;/i&gt; for the renumbering. It often effectively reduces the matrig storage space and the matrix factorization time.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;When &lt;b&gt;inactive&lt;/b&gt; is selected no renumbering is done. This option should only be chosen for testing purposes.&lt;/p&gt;&lt;/ul&gt; (default to RenumberingMethodEnum.INACTIVE).</param>
        public InactivePreconditioner(string type = "INACTIVE", RenumberingMethodEnum? renumberingMethod = default(RenumberingMethodEnum?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for InactivePreconditioner and cannot be null");
            this.RenumberingMethod = renumberingMethod;
        }
        
        /// <summary>
        /// Schema name: InactivePreconditioner
        /// </summary>
        /// <value>Schema name: InactivePreconditioner</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InactivePreconditioner {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  RenumberingMethod: ").Append(RenumberingMethod).Append("\n");
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
            return this.Equals(input as InactivePreconditioner);
        }

        /// <summary>
        /// Returns true if InactivePreconditioner instances are equal
        /// </summary>
        /// <param name="input">Instance of InactivePreconditioner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InactivePreconditioner input)
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
                    this.RenumberingMethod == input.RenumberingMethod ||
                    this.RenumberingMethod.Equals(input.RenumberingMethod)
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
                hashCode = hashCode * 59 + this.RenumberingMethod.GetHashCode();
                return hashCode;
            }
        }

    }

}
