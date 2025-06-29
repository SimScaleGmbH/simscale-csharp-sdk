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
    /// AdvancedMUMPSSettings
    /// </summary>
    [DataContract]
    public partial class AdvancedMUMPSSettings : IEquatable<AdvancedMUMPSSettings>
    {
        /// <summary>
        /// &lt;p&gt;Choose the type of your system matrix by directly selecting the appropriate type or using the &lt;b&gt;automatic detection&lt;/b&gt;. With the selection &lt;b&gt;automatic detection&lt;/b&gt; the matrix type &lt;b&gt;symmetric positive indefinite&lt;/b&gt; is selected if a symmetric system matrix is detected, and &lt;b&gt;asymmetric&lt;/b&gt; otherwise.
        /// </summary>
        /// <value>&lt;p&gt;Choose the type of your system matrix by directly selecting the appropriate type or using the &lt;b&gt;automatic detection&lt;/b&gt;. With the selection &lt;b&gt;automatic detection&lt;/b&gt; the matrix type &lt;b&gt;symmetric positive indefinite&lt;/b&gt; is selected if a symmetric system matrix is detected, and &lt;b&gt;asymmetric&lt;/b&gt; otherwise.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MatrixTypeEnum
        {
            /// <summary>
            /// Enum ASYMMETRIC for value: ASYMMETRIC
            /// </summary>
            [EnumMember(Value = "ASYMMETRIC")]
            ASYMMETRIC = 1,

            /// <summary>
            /// Enum AUTOMATICDETECTION for value: AUTOMATIC_DETECTION
            /// </summary>
            [EnumMember(Value = "AUTOMATIC_DETECTION")]
            AUTOMATICDETECTION = 2,

            /// <summary>
            /// Enum SYMMETRICPOSITIVEINDEFINITE for value: SYMMETRIC_POSITIVE_INDEFINITE
            /// </summary>
            [EnumMember(Value = "SYMMETRIC_POSITIVE_INDEFINITE")]
            SYMMETRICPOSITIVEINDEFINITE = 3

        }

        /// <summary>
        /// &lt;p&gt;Choose the type of your system matrix by directly selecting the appropriate type or using the &lt;b&gt;automatic detection&lt;/b&gt;. With the selection &lt;b&gt;automatic detection&lt;/b&gt; the matrix type &lt;b&gt;symmetric positive indefinite&lt;/b&gt; is selected if a symmetric system matrix is detected, and &lt;b&gt;asymmetric&lt;/b&gt; otherwise.
        /// </summary>
        /// <value>&lt;p&gt;Choose the type of your system matrix by directly selecting the appropriate type or using the &lt;b&gt;automatic detection&lt;/b&gt;. With the selection &lt;b&gt;automatic detection&lt;/b&gt; the matrix type &lt;b&gt;symmetric positive indefinite&lt;/b&gt; is selected if a symmetric system matrix is detected, and &lt;b&gt;asymmetric&lt;/b&gt; otherwise.</value>
        [DataMember(Name="matrixType", EmitDefaultValue=false)]
        public MatrixTypeEnum? MatrixType { get; set; }
        /// <summary>
        /// Choose the renumbering method for the system matrix entries. The choice of the renumbering method has a big impact on the memory consumption and the solution time. Currently supported are:&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;SCOTCH&lt;/b&gt; is a powerful renumbering tool, suited for most scenarios and the standard choice for MUMPS.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;PORD&lt;/b&gt; is a renumbering tool that comes with MUMPS.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;AMD&lt;/b&gt; uses the &lt;i&gt;Approximate Minimum Degree&lt;/i&gt; method.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;AMF&lt;/b&gt; uses the &lt;i&gt;Approximate Minimum Fill&lt;/i&gt; method.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;QAMD&lt;/b&gt; is a variant of AMD with automatic detection of quasi-dense matrix lines.&lt;/p&gt;&lt;/ul&gt;If &lt;b&gt;automatic&lt;/b&gt; is selected the user let MUMPS choose the renumbering tool. The methods AMD, AMF and QAMD are generally inferior to the more sophisticated methods SCOTCH and PORD but may be a better choice in some cases.
        /// </summary>
        /// <value>Choose the renumbering method for the system matrix entries. The choice of the renumbering method has a big impact on the memory consumption and the solution time. Currently supported are:&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;SCOTCH&lt;/b&gt; is a powerful renumbering tool, suited for most scenarios and the standard choice for MUMPS.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;PORD&lt;/b&gt; is a renumbering tool that comes with MUMPS.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;AMD&lt;/b&gt; uses the &lt;i&gt;Approximate Minimum Degree&lt;/i&gt; method.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;AMF&lt;/b&gt; uses the &lt;i&gt;Approximate Minimum Fill&lt;/i&gt; method.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;QAMD&lt;/b&gt; is a variant of AMD with automatic detection of quasi-dense matrix lines.&lt;/p&gt;&lt;/ul&gt;If &lt;b&gt;automatic&lt;/b&gt; is selected the user let MUMPS choose the renumbering tool. The methods AMD, AMF and QAMD are generally inferior to the more sophisticated methods SCOTCH and PORD but may be a better choice in some cases.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RenumberingMethodEnum
        {
            /// <summary>
            /// Enum AMD for value: AMD
            /// </summary>
            [EnumMember(Value = "AMD")]
            AMD = 1,

            /// <summary>
            /// Enum SCOTCH for value: SCOTCH
            /// </summary>
            [EnumMember(Value = "SCOTCH")]
            SCOTCH = 2,

            /// <summary>
            /// Enum AMF for value: AMF
            /// </summary>
            [EnumMember(Value = "AMF")]
            AMF = 3,

            /// <summary>
            /// Enum PORD for value: PORD
            /// </summary>
            [EnumMember(Value = "PORD")]
            PORD = 4,

            /// <summary>
            /// Enum QAMD for value: QAMD
            /// </summary>
            [EnumMember(Value = "QAMD")]
            QAMD = 5,

            /// <summary>
            /// Enum AUTOMATIC for value: AUTOMATIC
            /// </summary>
            [EnumMember(Value = "AUTOMATIC")]
            AUTOMATIC = 6

        }

        /// <summary>
        /// Choose the renumbering method for the system matrix entries. The choice of the renumbering method has a big impact on the memory consumption and the solution time. Currently supported are:&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;SCOTCH&lt;/b&gt; is a powerful renumbering tool, suited for most scenarios and the standard choice for MUMPS.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;PORD&lt;/b&gt; is a renumbering tool that comes with MUMPS.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;AMD&lt;/b&gt; uses the &lt;i&gt;Approximate Minimum Degree&lt;/i&gt; method.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;AMF&lt;/b&gt; uses the &lt;i&gt;Approximate Minimum Fill&lt;/i&gt; method.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;QAMD&lt;/b&gt; is a variant of AMD with automatic detection of quasi-dense matrix lines.&lt;/p&gt;&lt;/ul&gt;If &lt;b&gt;automatic&lt;/b&gt; is selected the user let MUMPS choose the renumbering tool. The methods AMD, AMF and QAMD are generally inferior to the more sophisticated methods SCOTCH and PORD but may be a better choice in some cases.
        /// </summary>
        /// <value>Choose the renumbering method for the system matrix entries. The choice of the renumbering method has a big impact on the memory consumption and the solution time. Currently supported are:&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;SCOTCH&lt;/b&gt; is a powerful renumbering tool, suited for most scenarios and the standard choice for MUMPS.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;PORD&lt;/b&gt; is a renumbering tool that comes with MUMPS.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;AMD&lt;/b&gt; uses the &lt;i&gt;Approximate Minimum Degree&lt;/i&gt; method.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;AMF&lt;/b&gt; uses the &lt;i&gt;Approximate Minimum Fill&lt;/i&gt; method.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;QAMD&lt;/b&gt; is a variant of AMD with automatic detection of quasi-dense matrix lines.&lt;/p&gt;&lt;/ul&gt;If &lt;b&gt;automatic&lt;/b&gt; is selected the user let MUMPS choose the renumbering tool. The methods AMD, AMF and QAMD are generally inferior to the more sophisticated methods SCOTCH and PORD but may be a better choice in some cases.</value>
        [DataMember(Name="renumberingMethod", EmitDefaultValue=false)]
        public RenumberingMethodEnum? RenumberingMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedMUMPSSettings" /> class.
        /// </summary>
        /// <param name="forceSymmetric">Choose if you want to enforce a symmetric matrix. (default to false).</param>
        /// <param name="enableSingularityDetection">Enable the check for singularities in the model. This is helpful for debugging, to spot problems with the setup. (default to false).</param>
        /// <param name="precisionSingularityDetection">Define the precision value for the detection of a singular matrix. Positive values enable the check, with 9 being a good starting point. Smaller values make the check more strict. This is an advanced option that should only be used to debug a model. (default to 9).</param>
        /// <param name="stopIfSingular">Choose if the calculation should be stopped if the problem turns out to be singular. (default to false).</param>
        /// <param name="matrixType">&lt;p&gt;Choose the type of your system matrix by directly selecting the appropriate type or using the &lt;b&gt;automatic detection&lt;/b&gt;. With the selection &lt;b&gt;automatic detection&lt;/b&gt; the matrix type &lt;b&gt;symmetric positive indefinite&lt;/b&gt; is selected if a symmetric system matrix is detected, and &lt;b&gt;asymmetric&lt;/b&gt; otherwise. (default to MatrixTypeEnum.AUTOMATICDETECTION).</param>
        /// <param name="memoryPercentageForPivoting">Define how much additional memory should be reserved for the pivoting operations. If MUMPS estimates that the necessary space for factorising the matrix would be 100, choosing a value of 20 would mean that MUMPS allocates a memory space of 120. (default to 20M).</param>
        /// <param name="linearSystemRelativeResidual">Set the maximum allowable numerical error in solving the linear equation system. Use -1 if you do not wish to carry out a check on the solution error (not recommended). (default to 0.000010M).</param>
        /// <param name="matrixFilteringThreshold">This parameter allows a filtration of the matrix entries that are saved and possibly passed to the nonlinear algorithm (Newton) and is similar to a relaxation mechanism. If the given threshold value is strictly positive, MUMPS only saves the matrix entries that satisfy the following condition: |K&lt;sub&gt;ij&lt;/sub&gt;| value*(|K&lt;sub&gt;ii&lt;/sub&gt;|+|K&lt;sub&gt;jj&lt;/sub&gt;|). Thus using this functionality might save computation time as well as memory consumption, but the effects strongly depend on the given value and is only advised for the experienced user. (default to -1M).</param>
        /// <param name="singlePrecision">If this option is activated the matrix factorisation is done with single precision and thus a reduction in memory consumption (often about 50%) and computation time is gained if the problem is well conditioned. If the problem is ill-conditioned one risks that in a nonlinear computation the newton algorithm fails to converge. (default to false).</param>
        /// <param name="preprocessing">If this option is activated MUMPS performs a pre-processing on order to identify the best parameter setting for some internal parameters adapted to the current problem. (default to true).</param>
        /// <param name="renumberingMethod">Choose the renumbering method for the system matrix entries. The choice of the renumbering method has a big impact on the memory consumption and the solution time. Currently supported are:&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;SCOTCH&lt;/b&gt; is a powerful renumbering tool, suited for most scenarios and the standard choice for MUMPS.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;PORD&lt;/b&gt; is a renumbering tool that comes with MUMPS.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;AMD&lt;/b&gt; uses the &lt;i&gt;Approximate Minimum Degree&lt;/i&gt; method.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;AMF&lt;/b&gt; uses the &lt;i&gt;Approximate Minimum Fill&lt;/i&gt; method.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;QAMD&lt;/b&gt; is a variant of AMD with automatic detection of quasi-dense matrix lines.&lt;/p&gt;&lt;/ul&gt;If &lt;b&gt;automatic&lt;/b&gt; is selected the user let MUMPS choose the renumbering tool. The methods AMD, AMF and QAMD are generally inferior to the more sophisticated methods SCOTCH and PORD but may be a better choice in some cases. (default to RenumberingMethodEnum.AUTOMATIC).</param>
        /// <param name="postprocessing">With this option the user can control the iterative refinement of the linear system solution. This option only has an effect if the value of the &lt;b&gt; linear system relative residual&lt;/b&gt; given by the user is greater than zero, otherwise it is ignored. If it is &lt;b&gt;activate&lt;/b&gt; MUMPS carries out at least one additional iteration of the linear system resolution and at most 10 iterations. The process is stopped if the residual isn&#39;t reduced by at least a factor of 5. If this option is set to be &lt;b&gt;inactive&lt;/b&gt; no additional iteration is done and if &lt;b&gt;automatic&lt;/b&gt; is chosen MUMPS automatically decides if additional iterations should be done and the maximum number of iterations is set to 4. (default to &quot;AUTOMATIC&quot;).</param>
        /// <param name="mumpsAcceleration">mumpsAcceleration.</param>
        /// <param name="distributedMatrixStorage">Choose this parameter as &lt;b&gt;true&lt;/b&gt; to ensure that the system matrix saving is distributed among the processors of the computation. If multiple cores are used only the relevant part for each core is saved. If it is set to false the whole matrix is saved for each processor. Enabling this can significantly reductions in memory consumption, but introduces numerical instability in rare occasions. (default to true).</param>
        public AdvancedMUMPSSettings(bool? forceSymmetric = default(bool?), bool? enableSingularityDetection = default(bool?), int? precisionSingularityDetection = default(int?), bool? stopIfSingular = default(bool?), MatrixTypeEnum? matrixType = default(MatrixTypeEnum?), decimal? memoryPercentageForPivoting = default(decimal?), decimal? linearSystemRelativeResidual = default(decimal?), decimal? matrixFilteringThreshold = default(decimal?), bool? singlePrecision = default(bool?), bool? preprocessing = default(bool?), RenumberingMethodEnum? renumberingMethod = default(RenumberingMethodEnum?), string postprocessing = default(string), OneOfAdvancedMUMPSSettingsMumpsAcceleration mumpsAcceleration = default(OneOfAdvancedMUMPSSettingsMumpsAcceleration), bool? distributedMatrixStorage = default(bool?))
        {
            this.ForceSymmetric = forceSymmetric;
            this.EnableSingularityDetection = enableSingularityDetection;
            this.PrecisionSingularityDetection = precisionSingularityDetection;
            this.StopIfSingular = stopIfSingular;
            this.MatrixType = matrixType;
            this.MemoryPercentageForPivoting = memoryPercentageForPivoting;
            this.LinearSystemRelativeResidual = linearSystemRelativeResidual;
            this.MatrixFilteringThreshold = matrixFilteringThreshold;
            this.SinglePrecision = singlePrecision;
            this.Preprocessing = preprocessing;
            this.RenumberingMethod = renumberingMethod;
            this.Postprocessing = postprocessing;
            this.MumpsAcceleration = mumpsAcceleration;
            this.DistributedMatrixStorage = distributedMatrixStorage;
        }
        
        /// <summary>
        /// Choose if you want to enforce a symmetric matrix.
        /// </summary>
        /// <value>Choose if you want to enforce a symmetric matrix.</value>
        [DataMember(Name="forceSymmetric", EmitDefaultValue=false)]
        public bool? ForceSymmetric { get; set; }

        /// <summary>
        /// Enable the check for singularities in the model. This is helpful for debugging, to spot problems with the setup.
        /// </summary>
        /// <value>Enable the check for singularities in the model. This is helpful for debugging, to spot problems with the setup.</value>
        [DataMember(Name="enableSingularityDetection", EmitDefaultValue=false)]
        public bool? EnableSingularityDetection { get; set; }

        /// <summary>
        /// Define the precision value for the detection of a singular matrix. Positive values enable the check, with 9 being a good starting point. Smaller values make the check more strict. This is an advanced option that should only be used to debug a model.
        /// </summary>
        /// <value>Define the precision value for the detection of a singular matrix. Positive values enable the check, with 9 being a good starting point. Smaller values make the check more strict. This is an advanced option that should only be used to debug a model.</value>
        [DataMember(Name="precisionSingularityDetection", EmitDefaultValue=false)]
        public int? PrecisionSingularityDetection { get; set; }

        /// <summary>
        /// Choose if the calculation should be stopped if the problem turns out to be singular.
        /// </summary>
        /// <value>Choose if the calculation should be stopped if the problem turns out to be singular.</value>
        [DataMember(Name="stopIfSingular", EmitDefaultValue=false)]
        public bool? StopIfSingular { get; set; }

        /// <summary>
        /// Define how much additional memory should be reserved for the pivoting operations. If MUMPS estimates that the necessary space for factorising the matrix would be 100, choosing a value of 20 would mean that MUMPS allocates a memory space of 120.
        /// </summary>
        /// <value>Define how much additional memory should be reserved for the pivoting operations. If MUMPS estimates that the necessary space for factorising the matrix would be 100, choosing a value of 20 would mean that MUMPS allocates a memory space of 120.</value>
        [DataMember(Name="memoryPercentageForPivoting", EmitDefaultValue=false)]
        public decimal? MemoryPercentageForPivoting { get; set; }

        /// <summary>
        /// Set the maximum allowable numerical error in solving the linear equation system. Use -1 if you do not wish to carry out a check on the solution error (not recommended).
        /// </summary>
        /// <value>Set the maximum allowable numerical error in solving the linear equation system. Use -1 if you do not wish to carry out a check on the solution error (not recommended).</value>
        [DataMember(Name="linearSystemRelativeResidual", EmitDefaultValue=false)]
        public decimal? LinearSystemRelativeResidual { get; set; }

        /// <summary>
        /// This parameter allows a filtration of the matrix entries that are saved and possibly passed to the nonlinear algorithm (Newton) and is similar to a relaxation mechanism. If the given threshold value is strictly positive, MUMPS only saves the matrix entries that satisfy the following condition: |K&lt;sub&gt;ij&lt;/sub&gt;| value*(|K&lt;sub&gt;ii&lt;/sub&gt;|+|K&lt;sub&gt;jj&lt;/sub&gt;|). Thus using this functionality might save computation time as well as memory consumption, but the effects strongly depend on the given value and is only advised for the experienced user.
        /// </summary>
        /// <value>This parameter allows a filtration of the matrix entries that are saved and possibly passed to the nonlinear algorithm (Newton) and is similar to a relaxation mechanism. If the given threshold value is strictly positive, MUMPS only saves the matrix entries that satisfy the following condition: |K&lt;sub&gt;ij&lt;/sub&gt;| value*(|K&lt;sub&gt;ii&lt;/sub&gt;|+|K&lt;sub&gt;jj&lt;/sub&gt;|). Thus using this functionality might save computation time as well as memory consumption, but the effects strongly depend on the given value and is only advised for the experienced user.</value>
        [DataMember(Name="matrixFilteringThreshold", EmitDefaultValue=false)]
        public decimal? MatrixFilteringThreshold { get; set; }

        /// <summary>
        /// If this option is activated the matrix factorisation is done with single precision and thus a reduction in memory consumption (often about 50%) and computation time is gained if the problem is well conditioned. If the problem is ill-conditioned one risks that in a nonlinear computation the newton algorithm fails to converge.
        /// </summary>
        /// <value>If this option is activated the matrix factorisation is done with single precision and thus a reduction in memory consumption (often about 50%) and computation time is gained if the problem is well conditioned. If the problem is ill-conditioned one risks that in a nonlinear computation the newton algorithm fails to converge.</value>
        [DataMember(Name="singlePrecision", EmitDefaultValue=false)]
        public bool? SinglePrecision { get; set; }

        /// <summary>
        /// If this option is activated MUMPS performs a pre-processing on order to identify the best parameter setting for some internal parameters adapted to the current problem.
        /// </summary>
        /// <value>If this option is activated MUMPS performs a pre-processing on order to identify the best parameter setting for some internal parameters adapted to the current problem.</value>
        [DataMember(Name="preprocessing", EmitDefaultValue=false)]
        public bool? Preprocessing { get; set; }

        /// <summary>
        /// With this option the user can control the iterative refinement of the linear system solution. This option only has an effect if the value of the &lt;b&gt; linear system relative residual&lt;/b&gt; given by the user is greater than zero, otherwise it is ignored. If it is &lt;b&gt;activate&lt;/b&gt; MUMPS carries out at least one additional iteration of the linear system resolution and at most 10 iterations. The process is stopped if the residual isn&#39;t reduced by at least a factor of 5. If this option is set to be &lt;b&gt;inactive&lt;/b&gt; no additional iteration is done and if &lt;b&gt;automatic&lt;/b&gt; is chosen MUMPS automatically decides if additional iterations should be done and the maximum number of iterations is set to 4.
        /// </summary>
        /// <value>With this option the user can control the iterative refinement of the linear system solution. This option only has an effect if the value of the &lt;b&gt; linear system relative residual&lt;/b&gt; given by the user is greater than zero, otherwise it is ignored. If it is &lt;b&gt;activate&lt;/b&gt; MUMPS carries out at least one additional iteration of the linear system resolution and at most 10 iterations. The process is stopped if the residual isn&#39;t reduced by at least a factor of 5. If this option is set to be &lt;b&gt;inactive&lt;/b&gt; no additional iteration is done and if &lt;b&gt;automatic&lt;/b&gt; is chosen MUMPS automatically decides if additional iterations should be done and the maximum number of iterations is set to 4.</value>
        [DataMember(Name="postprocessing", EmitDefaultValue=false)]
        public string Postprocessing { get; set; }

        /// <summary>
        /// Gets or Sets MumpsAcceleration
        /// </summary>
        [DataMember(Name="mumpsAcceleration", EmitDefaultValue=false)]
        public OneOfAdvancedMUMPSSettingsMumpsAcceleration MumpsAcceleration { get; set; }

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
            sb.Append("class AdvancedMUMPSSettings {\n");
            sb.Append("  ForceSymmetric: ").Append(ForceSymmetric).Append("\n");
            sb.Append("  EnableSingularityDetection: ").Append(EnableSingularityDetection).Append("\n");
            sb.Append("  PrecisionSingularityDetection: ").Append(PrecisionSingularityDetection).Append("\n");
            sb.Append("  StopIfSingular: ").Append(StopIfSingular).Append("\n");
            sb.Append("  MatrixType: ").Append(MatrixType).Append("\n");
            sb.Append("  MemoryPercentageForPivoting: ").Append(MemoryPercentageForPivoting).Append("\n");
            sb.Append("  LinearSystemRelativeResidual: ").Append(LinearSystemRelativeResidual).Append("\n");
            sb.Append("  MatrixFilteringThreshold: ").Append(MatrixFilteringThreshold).Append("\n");
            sb.Append("  SinglePrecision: ").Append(SinglePrecision).Append("\n");
            sb.Append("  Preprocessing: ").Append(Preprocessing).Append("\n");
            sb.Append("  RenumberingMethod: ").Append(RenumberingMethod).Append("\n");
            sb.Append("  Postprocessing: ").Append(Postprocessing).Append("\n");
            sb.Append("  MumpsAcceleration: ").Append(MumpsAcceleration).Append("\n");
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
            return this.Equals(input as AdvancedMUMPSSettings);
        }

        /// <summary>
        /// Returns true if AdvancedMUMPSSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of AdvancedMUMPSSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdvancedMUMPSSettings input)
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
                    this.EnableSingularityDetection == input.EnableSingularityDetection ||
                    (this.EnableSingularityDetection != null &&
                    this.EnableSingularityDetection.Equals(input.EnableSingularityDetection))
                ) && 
                (
                    this.PrecisionSingularityDetection == input.PrecisionSingularityDetection ||
                    (this.PrecisionSingularityDetection != null &&
                    this.PrecisionSingularityDetection.Equals(input.PrecisionSingularityDetection))
                ) && 
                (
                    this.StopIfSingular == input.StopIfSingular ||
                    (this.StopIfSingular != null &&
                    this.StopIfSingular.Equals(input.StopIfSingular))
                ) && 
                (
                    this.MatrixType == input.MatrixType ||
                    this.MatrixType.Equals(input.MatrixType)
                ) && 
                (
                    this.MemoryPercentageForPivoting == input.MemoryPercentageForPivoting ||
                    (this.MemoryPercentageForPivoting != null &&
                    this.MemoryPercentageForPivoting.Equals(input.MemoryPercentageForPivoting))
                ) && 
                (
                    this.LinearSystemRelativeResidual == input.LinearSystemRelativeResidual ||
                    (this.LinearSystemRelativeResidual != null &&
                    this.LinearSystemRelativeResidual.Equals(input.LinearSystemRelativeResidual))
                ) && 
                (
                    this.MatrixFilteringThreshold == input.MatrixFilteringThreshold ||
                    (this.MatrixFilteringThreshold != null &&
                    this.MatrixFilteringThreshold.Equals(input.MatrixFilteringThreshold))
                ) && 
                (
                    this.SinglePrecision == input.SinglePrecision ||
                    (this.SinglePrecision != null &&
                    this.SinglePrecision.Equals(input.SinglePrecision))
                ) && 
                (
                    this.Preprocessing == input.Preprocessing ||
                    (this.Preprocessing != null &&
                    this.Preprocessing.Equals(input.Preprocessing))
                ) && 
                (
                    this.RenumberingMethod == input.RenumberingMethod ||
                    this.RenumberingMethod.Equals(input.RenumberingMethod)
                ) && 
                (
                    this.Postprocessing == input.Postprocessing ||
                    (this.Postprocessing != null &&
                    this.Postprocessing.Equals(input.Postprocessing))
                ) && 
                (
                    this.MumpsAcceleration == input.MumpsAcceleration ||
                    (this.MumpsAcceleration != null &&
                    this.MumpsAcceleration.Equals(input.MumpsAcceleration))
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
                if (this.EnableSingularityDetection != null)
                    hashCode = hashCode * 59 + this.EnableSingularityDetection.GetHashCode();
                if (this.PrecisionSingularityDetection != null)
                    hashCode = hashCode * 59 + this.PrecisionSingularityDetection.GetHashCode();
                if (this.StopIfSingular != null)
                    hashCode = hashCode * 59 + this.StopIfSingular.GetHashCode();
                hashCode = hashCode * 59 + this.MatrixType.GetHashCode();
                if (this.MemoryPercentageForPivoting != null)
                    hashCode = hashCode * 59 + this.MemoryPercentageForPivoting.GetHashCode();
                if (this.LinearSystemRelativeResidual != null)
                    hashCode = hashCode * 59 + this.LinearSystemRelativeResidual.GetHashCode();
                if (this.MatrixFilteringThreshold != null)
                    hashCode = hashCode * 59 + this.MatrixFilteringThreshold.GetHashCode();
                if (this.SinglePrecision != null)
                    hashCode = hashCode * 59 + this.SinglePrecision.GetHashCode();
                if (this.Preprocessing != null)
                    hashCode = hashCode * 59 + this.Preprocessing.GetHashCode();
                hashCode = hashCode * 59 + this.RenumberingMethod.GetHashCode();
                if (this.Postprocessing != null)
                    hashCode = hashCode * 59 + this.Postprocessing.GetHashCode();
                if (this.MumpsAcceleration != null)
                    hashCode = hashCode * 59 + this.MumpsAcceleration.GetHashCode();
                if (this.DistributedMatrixStorage != null)
                    hashCode = hashCode * 59 + this.DistributedMatrixStorage.GetHashCode();
                return hashCode;
            }
        }

    }

}
