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
    /// AdvancedPETSCSettings
    /// </summary>
    [DataContract]
    public partial class AdvancedPETSCSettings : IEquatable<AdvancedPETSCSettings>
    {
        /// <summary>
        /// Choose the iterative solver method: &lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;FGMRES&lt;/b&gt;: &lt;i&gt;Flexible Minimal Generalised RESidual&lt;/i&gt;, best compromise between robustness and computational speed.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;CG&lt;/b&gt;: &lt;i&gt;Conjugate Gradient&lt;/i&gt;, only useful for symmetric matrices&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;CR&lt;/b&gt;: &lt;i&gt;Conjugate Residual&lt;/i&gt;, only useful for symmetric matrices&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;GCR&lt;/b&gt;: &lt;i&gt;Generalised Conjugate Residual&lt;/i&gt;, treats general matrices&lt;/p&gt;&lt;/ul&gt;All available methods are of &lt;i&gt;Krylov&lt;/i&gt; type.
        /// </summary>
        /// <value>Choose the iterative solver method: &lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;FGMRES&lt;/b&gt;: &lt;i&gt;Flexible Minimal Generalised RESidual&lt;/i&gt;, best compromise between robustness and computational speed.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;CG&lt;/b&gt;: &lt;i&gt;Conjugate Gradient&lt;/i&gt;, only useful for symmetric matrices&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;CR&lt;/b&gt;: &lt;i&gt;Conjugate Residual&lt;/i&gt;, only useful for symmetric matrices&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;GCR&lt;/b&gt;: &lt;i&gt;Generalised Conjugate Residual&lt;/i&gt;, treats general matrices&lt;/p&gt;&lt;/ul&gt;All available methods are of &lt;i&gt;Krylov&lt;/i&gt; type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlgorithmEnum
        {
            /// <summary>
            /// Enum CG for value: CG
            /// </summary>
            [EnumMember(Value = "CG")]
            CG = 1,

            /// <summary>
            /// Enum CR for value: CR
            /// </summary>
            [EnumMember(Value = "CR")]
            CR = 2,

            /// <summary>
            /// Enum GCR for value: GCR
            /// </summary>
            [EnumMember(Value = "GCR")]
            GCR = 3,

            /// <summary>
            /// Enum GMRES for value: GMRES
            /// </summary>
            [EnumMember(Value = "GMRES")]
            GMRES = 4

        }

        /// <summary>
        /// Choose the iterative solver method: &lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;FGMRES&lt;/b&gt;: &lt;i&gt;Flexible Minimal Generalised RESidual&lt;/i&gt;, best compromise between robustness and computational speed.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;CG&lt;/b&gt;: &lt;i&gt;Conjugate Gradient&lt;/i&gt;, only useful for symmetric matrices&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;CR&lt;/b&gt;: &lt;i&gt;Conjugate Residual&lt;/i&gt;, only useful for symmetric matrices&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;GCR&lt;/b&gt;: &lt;i&gt;Generalised Conjugate Residual&lt;/i&gt;, treats general matrices&lt;/p&gt;&lt;/ul&gt;All available methods are of &lt;i&gt;Krylov&lt;/i&gt; type.
        /// </summary>
        /// <value>Choose the iterative solver method: &lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;FGMRES&lt;/b&gt;: &lt;i&gt;Flexible Minimal Generalised RESidual&lt;/i&gt;, best compromise between robustness and computational speed.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;CG&lt;/b&gt;: &lt;i&gt;Conjugate Gradient&lt;/i&gt;, only useful for symmetric matrices&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;CR&lt;/b&gt;: &lt;i&gt;Conjugate Residual&lt;/i&gt;, only useful for symmetric matrices&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;GCR&lt;/b&gt;: &lt;i&gt;Generalised Conjugate Residual&lt;/i&gt;, treats general matrices&lt;/p&gt;&lt;/ul&gt;All available methods are of &lt;i&gt;Krylov&lt;/i&gt; type.</value>
        [DataMember(Name="algorithm", EmitDefaultValue=false)]
        public AlgorithmEnum? Algorithm { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedPETSCSettings" /> class.
        /// </summary>
        /// <param name="forceSymmetric">Choose if you want to enforce a symmetric matrix. (default to false).</param>
        /// <param name="algorithm">Choose the iterative solver method: &lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;FGMRES&lt;/b&gt;: &lt;i&gt;Flexible Minimal Generalised RESidual&lt;/i&gt;, best compromise between robustness and computational speed.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;CG&lt;/b&gt;: &lt;i&gt;Conjugate Gradient&lt;/i&gt;, only useful for symmetric matrices&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;CR&lt;/b&gt;: &lt;i&gt;Conjugate Residual&lt;/i&gt;, only useful for symmetric matrices&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;GCR&lt;/b&gt;: &lt;i&gt;Generalised Conjugate Residual&lt;/i&gt;, treats general matrices&lt;/p&gt;&lt;/ul&gt;All available methods are of &lt;i&gt;Krylov&lt;/i&gt; type. (default to AlgorithmEnum.GMRES).</param>
        /// <param name="preconditioner">preconditioner.</param>
        /// <param name="distributedMatrixStorage">Choose this parameter as &lt;b&gt;true&lt;/b&gt; to ensure that the system matrix saving is distributed among the processors of the computation. If multiple cores are used only the relevant part for each core is saved. If it is set to false the whole matrix is saved for each processor. Enabling this can significantly reductions in memory consumption, but introduces numerical instability in rare occasions. (default to true).</param>
        public AdvancedPETSCSettings(bool? forceSymmetric = default(bool?), AlgorithmEnum? algorithm = default(AlgorithmEnum?), OneOfAdvancedPETSCSettingsPreconditioner preconditioner = default(OneOfAdvancedPETSCSettingsPreconditioner), bool? distributedMatrixStorage = default(bool?))
        {
            this.ForceSymmetric = forceSymmetric;
            this.Algorithm = algorithm;
            this.Preconditioner = preconditioner;
            this.DistributedMatrixStorage = distributedMatrixStorage;
        }
        
        /// <summary>
        /// Choose if you want to enforce a symmetric matrix.
        /// </summary>
        /// <value>Choose if you want to enforce a symmetric matrix.</value>
        [DataMember(Name="forceSymmetric", EmitDefaultValue=false)]
        public bool? ForceSymmetric { get; set; }

        /// <summary>
        /// Gets or Sets Preconditioner
        /// </summary>
        [DataMember(Name="preconditioner", EmitDefaultValue=false)]
        public OneOfAdvancedPETSCSettingsPreconditioner Preconditioner { get; set; }

        /// <summary>
        /// Choose this parameter as &lt;b&gt;true&lt;/b&gt; to ensure that the system matrix saving is distributed among the processors of the computation. If multiple cores are used only the relevant part for each core is saved. If it is set to false the whole matrix is saved for each processor. Enabling this can significantly reductions in memory consumption, but introduces numerical instability in rare occasions.
        /// </summary>
        /// <value>Choose this parameter as &lt;b&gt;true&lt;/b&gt; to ensure that the system matrix saving is distributed among the processors of the computation. If multiple cores are used only the relevant part for each core is saved. If it is set to false the whole matrix is saved for each processor. Enabling this can significantly reductions in memory consumption, but introduces numerical instability in rare occasions.</value>
        [DataMember(Name="distributedMatrixStorage", EmitDefaultValue=false)]
        public bool? DistributedMatrixStorage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdvancedPETSCSettings {\n");
            sb.Append("  ForceSymmetric: ").Append(ForceSymmetric).Append("\n");
            sb.Append("  Algorithm: ").Append(Algorithm).Append("\n");
            sb.Append("  Preconditioner: ").Append(Preconditioner).Append("\n");
            sb.Append("  DistributedMatrixStorage: ").Append(DistributedMatrixStorage).Append("\n");
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
            return this.Equals(input as AdvancedPETSCSettings);
        }

        /// <summary>
        /// Returns true if AdvancedPETSCSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of AdvancedPETSCSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdvancedPETSCSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ForceSymmetric == input.ForceSymmetric ||
                    (this.ForceSymmetric != null &&
                    this.ForceSymmetric.Equals(input.ForceSymmetric))
                ) && 
                (
                    this.Algorithm == input.Algorithm ||
                    this.Algorithm.Equals(input.Algorithm)
                ) && 
                (
                    this.Preconditioner == input.Preconditioner ||
                    (this.Preconditioner != null &&
                    this.Preconditioner.Equals(input.Preconditioner))
                ) && 
                (
                    this.DistributedMatrixStorage == input.DistributedMatrixStorage ||
                    (this.DistributedMatrixStorage != null &&
                    this.DistributedMatrixStorage.Equals(input.DistributedMatrixStorage))
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
                if (this.ForceSymmetric != null)
                    hashCode = hashCode * 59 + this.ForceSymmetric.GetHashCode();
                hashCode = hashCode * 59 + this.Algorithm.GetHashCode();
                if (this.Preconditioner != null)
                    hashCode = hashCode * 59 + this.Preconditioner.GetHashCode();
                if (this.DistributedMatrixStorage != null)
                    hashCode = hashCode * 59 + this.DistributedMatrixStorage.GetHashCode();
                return hashCode;
            }
        }

    }

}
