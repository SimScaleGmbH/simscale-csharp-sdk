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
    /// AdvancedChronosSettings
    /// </summary>
    [DataContract]
    public partial class AdvancedChronosSettings : IEquatable<AdvancedChronosSettings>
    {
        /// <summary>
        /// The algorithm for the prolongation becomes more elaborate from Jacobi over light, medium to heavy FSAI. The stability increases as well as the computational cost. It is recommended to increase it when the problem has distored elements, is ill-conditioned  or has incompressible materials.
        /// </summary>
        /// <value>The algorithm for the prolongation becomes more elaborate from Jacobi over light, medium to heavy FSAI. The stability increases as well as the computational cost. It is recommended to increase it when the problem has distored elements, is ill-conditioned  or has incompressible materials.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AlgorithmEnum
        {
            /// <summary>
            /// Enum LIGHT for value: FSAI_LIGHT
            /// </summary>
            [EnumMember(Value = "FSAI_LIGHT")]
            LIGHT = 1,

            /// <summary>
            /// Enum MEDIUM for value: FSAI_MEDIUM
            /// </summary>
            [EnumMember(Value = "FSAI_MEDIUM")]
            MEDIUM = 2,

            /// <summary>
            /// Enum HEAVY for value: FSAI_HEAVY
            /// </summary>
            [EnumMember(Value = "FSAI_HEAVY")]
            HEAVY = 3

        }

        /// <summary>
        /// The algorithm for the prolongation becomes more elaborate from Jacobi over light, medium to heavy FSAI. The stability increases as well as the computational cost. It is recommended to increase it when the problem has distored elements, is ill-conditioned  or has incompressible materials.
        /// </summary>
        /// <value>The algorithm for the prolongation becomes more elaborate from Jacobi over light, medium to heavy FSAI. The stability increases as well as the computational cost. It is recommended to increase it when the problem has distored elements, is ill-conditioned  or has incompressible materials.</value>
        [DataMember(Name="algorithm", EmitDefaultValue=false)]
        public AlgorithmEnum? Algorithm { get; set; }
        /// <summary>
        /// The algorithm for the prolongation becomes more elaborate from Jacobi over light, medium to heavy FSAI. The stability increases as well as the computational cost. It is recommended to increase it when the problem has distored elements, is ill-conditioned  or has incompressible materials.
        /// </summary>
        /// <value>The algorithm for the prolongation becomes more elaborate from Jacobi over light, medium to heavy FSAI. The stability increases as well as the computational cost. It is recommended to increase it when the problem has distored elements, is ill-conditioned  or has incompressible materials.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SmootherEnum
        {
            /// <summary>
            /// Enum JACOBI for value: JACOBI
            /// </summary>
            [EnumMember(Value = "JACOBI")]
            JACOBI = 1,

            /// <summary>
            /// Enum FSAILIGHT for value: FSAI_LIGHT
            /// </summary>
            [EnumMember(Value = "FSAI_LIGHT")]
            FSAILIGHT = 2,

            /// <summary>
            /// Enum FSAIMEDIUM for value: FSAI_MEDIUM
            /// </summary>
            [EnumMember(Value = "FSAI_MEDIUM")]
            FSAIMEDIUM = 3,

            /// <summary>
            /// Enum FSAIHEAVY for value: FSAI_HEAVY
            /// </summary>
            [EnumMember(Value = "FSAI_HEAVY")]
            FSAIHEAVY = 4

        }

        /// <summary>
        /// The algorithm for the prolongation becomes more elaborate from Jacobi over light, medium to heavy FSAI. The stability increases as well as the computational cost. It is recommended to increase it when the problem has distored elements, is ill-conditioned  or has incompressible materials.
        /// </summary>
        /// <value>The algorithm for the prolongation becomes more elaborate from Jacobi over light, medium to heavy FSAI. The stability increases as well as the computational cost. It is recommended to increase it when the problem has distored elements, is ill-conditioned  or has incompressible materials.</value>
        [DataMember(Name="smoother", EmitDefaultValue=false)]
        public SmootherEnum? Smoother { get; set; }
        /// <summary>
        /// The algorithm for the prolongation becomes more elaborate from unsmoothed, smoothed to energy-minimization. The stability increases as well as the computational cost. It is recommended to increase it when the problem has small number of BCs and large number of elements
        /// </summary>
        /// <value>The algorithm for the prolongation becomes more elaborate from unsmoothed, smoothed to energy-minimization. The stability increases as well as the computational cost. It is recommended to increase it when the problem has small number of BCs and large number of elements</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProlongationEnum
        {
            /// <summary>
            /// Enum UNSMOOTHED for value: UNSMOOTHED
            /// </summary>
            [EnumMember(Value = "UNSMOOTHED")]
            UNSMOOTHED = 1,

            /// <summary>
            /// Enum SMOOTHED for value: SMOOTHED
            /// </summary>
            [EnumMember(Value = "SMOOTHED")]
            SMOOTHED = 2,

            /// <summary>
            /// Enum ENERGYMINIMIZATION for value: ENERGY_MINIMIZATION
            /// </summary>
            [EnumMember(Value = "ENERGY_MINIMIZATION")]
            ENERGYMINIMIZATION = 3

        }

        /// <summary>
        /// The algorithm for the prolongation becomes more elaborate from unsmoothed, smoothed to energy-minimization. The stability increases as well as the computational cost. It is recommended to increase it when the problem has small number of BCs and large number of elements
        /// </summary>
        /// <value>The algorithm for the prolongation becomes more elaborate from unsmoothed, smoothed to energy-minimization. The stability increases as well as the computational cost. It is recommended to increase it when the problem has small number of BCs and large number of elements</value>
        [DataMember(Name="prolongation", EmitDefaultValue=false)]
        public ProlongationEnum? Prolongation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvancedChronosSettings" /> class.
        /// </summary>
        /// <param name="forceFsai">Force the usage of &lt;b&gt;FSAI&lt;/b&gt; preconditioning. This can make sense for small and simple problems, because setting up the problem might be faster with FSAI than with AMG.&lt;br&gt;Otherwise, Chronos selects itself the most suitable preconditioner, depending on the characteristics of the problem. In this case, &lt;b&gt;AMG&lt;/b&gt; is preferred over &lt;b&gt;FSAI&lt;/b&gt;. (default to false).</param>
        /// <param name="algorithm">The algorithm for the prolongation becomes more elaborate from Jacobi over light, medium to heavy FSAI. The stability increases as well as the computational cost. It is recommended to increase it when the problem has distored elements, is ill-conditioned  or has incompressible materials. (default to AlgorithmEnum.LIGHT).</param>
        /// <param name="smoother">The algorithm for the prolongation becomes more elaborate from Jacobi over light, medium to heavy FSAI. The stability increases as well as the computational cost. It is recommended to increase it when the problem has distored elements, is ill-conditioned  or has incompressible materials..</param>
        /// <param name="prolongation">The algorithm for the prolongation becomes more elaborate from unsmoothed, smoothed to energy-minimization. The stability increases as well as the computational cost. It is recommended to increase it when the problem has small number of BCs and large number of elements (default to ProlongationEnum.ENERGYMINIMIZATION).</param>
        /// <param name="improveTestSpace">This should be enabled only for very complex/ill-conditioned problems, e.g. highly constrained with many BCs, incompressible/hyperelastic materials..</param>
        /// <param name="testSpaceIterations">Defaults to 20, can be increased to 50 for complicated cases. (default to 100).</param>
        /// <param name="preconditionerRecycling">Specify the recycling of the preconditioner. This can have a significant impact on the performance. The input is as follows: &lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt; &lt; 0.0&lt;/b&gt; Never recycle the preconditioner.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;0.0&lt;/b&gt; Recycle the preconditioner every second iteration.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;&lt; 1.0&lt;/b&gt; Recycle the preconditioner more often than the optimal way.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;&#x3D;&#x3D; 1.0&lt;/b&gt; recycle the preconditioner in the optimal way.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;&gt; 1.0&lt;/b&gt; recycle the preconditioner less often than the optimal way.&lt;/p&gt;&lt;/ul&gt; (default to 1M).</param>
        /// <param name="restartGmres">Choose after how many iterations the GMRES solver should be restarted.&lt;br&gt;By default, Chronos uses a &lt;b&gt;PCG&lt;/b&gt; iterative solution method. Depending on the characteristics of the problem, it might internally switch to &lt;b&gt;GMRES&lt;/b&gt;. With GMRES, the iterations become more expensive the more they grow. Therefore, it is restarted if a certain threshold is reached. Default is 50, can be increased to 100 for complicated cases. (default to 50).</param>
        /// <param name="distributedMatrixStorage">Choose this parameter as &lt;b&gt;true&lt;/b&gt; to ensure that the system matrix saving is distributed among the processors of the computation. If multiple cores are used only the relevant part for each core is saved. If it is set to false the whole matrix is saved for each processor. Enabling this can significantly reductions in memory consumption, but introduces numerical instability in rare occasions. (default to true).</param>
        /// <param name="numOfThreads">Sets the number of threads for Chronos to be used for shared memory parallelization.&lt;br&gt;The shared memory parallelization of Chronos is independent of the shared memory parallelization of Code_Aster.&lt;br&gt;Ideally, the number of threads multiplied with the number of (MPI) processes (Number of parallel processes under Simulation control) should be set to the number of cores available on the machine.&lt;br&gt;Set it to 0 to automatically choose the best setting.&lt;br&gt;Note that reducing the number of MPI-processes and increasing the number of threads can significantly reduce memory and disk space consumption. (default to 0).</param>
        /// <param name="verbosity">This is a DEVELOPER option to specify the amount of output from Chronos. Its only purpose is debugging. Don&#39;t use it for regular runs, as it will slow down the simulation a lot! 0 means no output, 1-3 means more and more output. (default to 0).</param>
        /// <param name="writeCoordsAndMatrix">This is a DEVELOPER option to output the coordinates and the matrix to a file. Its only purpose is debugging. Don&#39;t use it for regular runs, as it will slow down the simulation a lot! 0 means no output, 1 means to output the latest coords/matrix, and 2 means to output the coords/matrix for every solve (aka every iteration). (default to 0).</param>
        public AdvancedChronosSettings(bool? forceFsai = default(bool?), AlgorithmEnum? algorithm = default(AlgorithmEnum?), SmootherEnum? smoother = default(SmootherEnum?), ProlongationEnum? prolongation = default(ProlongationEnum?), bool? improveTestSpace = default(bool?), int? testSpaceIterations = default(int?), decimal? preconditionerRecycling = default(decimal?), int? restartGmres = default(int?), bool? distributedMatrixStorage = default(bool?), int? numOfThreads = default(int?), int? verbosity = default(int?), int? writeCoordsAndMatrix = default(int?))
        {
            this.ForceFsai = forceFsai;
            this.Algorithm = algorithm;
            this.Smoother = smoother;
            this.Prolongation = prolongation;
            this.ImproveTestSpace = improveTestSpace;
            this.TestSpaceIterations = testSpaceIterations;
            this.PreconditionerRecycling = preconditionerRecycling;
            this.RestartGmres = restartGmres;
            this.DistributedMatrixStorage = distributedMatrixStorage;
            this.NumOfThreads = numOfThreads;
            this.Verbosity = verbosity;
            this.WriteCoordsAndMatrix = writeCoordsAndMatrix;
        }
        
        /// <summary>
        /// Force the usage of &lt;b&gt;FSAI&lt;/b&gt; preconditioning. This can make sense for small and simple problems, because setting up the problem might be faster with FSAI than with AMG.&lt;br&gt;Otherwise, Chronos selects itself the most suitable preconditioner, depending on the characteristics of the problem. In this case, &lt;b&gt;AMG&lt;/b&gt; is preferred over &lt;b&gt;FSAI&lt;/b&gt;.
        /// </summary>
        /// <value>Force the usage of &lt;b&gt;FSAI&lt;/b&gt; preconditioning. This can make sense for small and simple problems, because setting up the problem might be faster with FSAI than with AMG.&lt;br&gt;Otherwise, Chronos selects itself the most suitable preconditioner, depending on the characteristics of the problem. In this case, &lt;b&gt;AMG&lt;/b&gt; is preferred over &lt;b&gt;FSAI&lt;/b&gt;.</value>
        [DataMember(Name="forceFsai", EmitDefaultValue=false)]
        public bool? ForceFsai { get; set; }

        /// <summary>
        /// This should be enabled only for very complex/ill-conditioned problems, e.g. highly constrained with many BCs, incompressible/hyperelastic materials.
        /// </summary>
        /// <value>This should be enabled only for very complex/ill-conditioned problems, e.g. highly constrained with many BCs, incompressible/hyperelastic materials.</value>
        [DataMember(Name="improveTestSpace", EmitDefaultValue=false)]
        public bool? ImproveTestSpace { get; set; }

        /// <summary>
        /// Defaults to 20, can be increased to 50 for complicated cases.
        /// </summary>
        /// <value>Defaults to 20, can be increased to 50 for complicated cases.</value>
        [DataMember(Name="testSpaceIterations", EmitDefaultValue=false)]
        public int? TestSpaceIterations { get; set; }

        /// <summary>
        /// Specify the recycling of the preconditioner. This can have a significant impact on the performance. The input is as follows: &lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt; &lt; 0.0&lt;/b&gt; Never recycle the preconditioner.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;0.0&lt;/b&gt; Recycle the preconditioner every second iteration.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;&lt; 1.0&lt;/b&gt; Recycle the preconditioner more often than the optimal way.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;&#x3D;&#x3D; 1.0&lt;/b&gt; recycle the preconditioner in the optimal way.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;&gt; 1.0&lt;/b&gt; recycle the preconditioner less often than the optimal way.&lt;/p&gt;&lt;/ul&gt;
        /// </summary>
        /// <value>Specify the recycling of the preconditioner. This can have a significant impact on the performance. The input is as follows: &lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt; &lt; 0.0&lt;/b&gt; Never recycle the preconditioner.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;0.0&lt;/b&gt; Recycle the preconditioner every second iteration.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;&lt; 1.0&lt;/b&gt; Recycle the preconditioner more often than the optimal way.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;&#x3D;&#x3D; 1.0&lt;/b&gt; recycle the preconditioner in the optimal way.&lt;/p&gt;&lt;/ul&gt;&lt;ul&gt;&lt;li&gt;&lt;p&gt;&lt;b&gt;&gt; 1.0&lt;/b&gt; recycle the preconditioner less often than the optimal way.&lt;/p&gt;&lt;/ul&gt;</value>
        [DataMember(Name="preconditionerRecycling", EmitDefaultValue=false)]
        public decimal? PreconditionerRecycling { get; set; }

        /// <summary>
        /// Choose after how many iterations the GMRES solver should be restarted.&lt;br&gt;By default, Chronos uses a &lt;b&gt;PCG&lt;/b&gt; iterative solution method. Depending on the characteristics of the problem, it might internally switch to &lt;b&gt;GMRES&lt;/b&gt;. With GMRES, the iterations become more expensive the more they grow. Therefore, it is restarted if a certain threshold is reached. Default is 50, can be increased to 100 for complicated cases.
        /// </summary>
        /// <value>Choose after how many iterations the GMRES solver should be restarted.&lt;br&gt;By default, Chronos uses a &lt;b&gt;PCG&lt;/b&gt; iterative solution method. Depending on the characteristics of the problem, it might internally switch to &lt;b&gt;GMRES&lt;/b&gt;. With GMRES, the iterations become more expensive the more they grow. Therefore, it is restarted if a certain threshold is reached. Default is 50, can be increased to 100 for complicated cases.</value>
        [DataMember(Name="restartGmres", EmitDefaultValue=false)]
        public int? RestartGmres { get; set; }

        /// <summary>
        /// Choose this parameter as &lt;b&gt;true&lt;/b&gt; to ensure that the system matrix saving is distributed among the processors of the computation. If multiple cores are used only the relevant part for each core is saved. If it is set to false the whole matrix is saved for each processor. Enabling this can significantly reductions in memory consumption, but introduces numerical instability in rare occasions.
        /// </summary>
        /// <value>Choose this parameter as &lt;b&gt;true&lt;/b&gt; to ensure that the system matrix saving is distributed among the processors of the computation. If multiple cores are used only the relevant part for each core is saved. If it is set to false the whole matrix is saved for each processor. Enabling this can significantly reductions in memory consumption, but introduces numerical instability in rare occasions.</value>
        [DataMember(Name="distributedMatrixStorage", EmitDefaultValue=false)]
        public bool? DistributedMatrixStorage { get; set; }

        /// <summary>
        /// Sets the number of threads for Chronos to be used for shared memory parallelization.&lt;br&gt;The shared memory parallelization of Chronos is independent of the shared memory parallelization of Code_Aster.&lt;br&gt;Ideally, the number of threads multiplied with the number of (MPI) processes (Number of parallel processes under Simulation control) should be set to the number of cores available on the machine.&lt;br&gt;Set it to 0 to automatically choose the best setting.&lt;br&gt;Note that reducing the number of MPI-processes and increasing the number of threads can significantly reduce memory and disk space consumption.
        /// </summary>
        /// <value>Sets the number of threads for Chronos to be used for shared memory parallelization.&lt;br&gt;The shared memory parallelization of Chronos is independent of the shared memory parallelization of Code_Aster.&lt;br&gt;Ideally, the number of threads multiplied with the number of (MPI) processes (Number of parallel processes under Simulation control) should be set to the number of cores available on the machine.&lt;br&gt;Set it to 0 to automatically choose the best setting.&lt;br&gt;Note that reducing the number of MPI-processes and increasing the number of threads can significantly reduce memory and disk space consumption.</value>
        [DataMember(Name="numOfThreads", EmitDefaultValue=false)]
        public int? NumOfThreads { get; set; }

        /// <summary>
        /// This is a DEVELOPER option to specify the amount of output from Chronos. Its only purpose is debugging. Don&#39;t use it for regular runs, as it will slow down the simulation a lot! 0 means no output, 1-3 means more and more output.
        /// </summary>
        /// <value>This is a DEVELOPER option to specify the amount of output from Chronos. Its only purpose is debugging. Don&#39;t use it for regular runs, as it will slow down the simulation a lot! 0 means no output, 1-3 means more and more output.</value>
        [DataMember(Name="verbosity", EmitDefaultValue=false)]
        public int? Verbosity { get; set; }

        /// <summary>
        /// This is a DEVELOPER option to output the coordinates and the matrix to a file. Its only purpose is debugging. Don&#39;t use it for regular runs, as it will slow down the simulation a lot! 0 means no output, 1 means to output the latest coords/matrix, and 2 means to output the coords/matrix for every solve (aka every iteration).
        /// </summary>
        /// <value>This is a DEVELOPER option to output the coordinates and the matrix to a file. Its only purpose is debugging. Don&#39;t use it for regular runs, as it will slow down the simulation a lot! 0 means no output, 1 means to output the latest coords/matrix, and 2 means to output the coords/matrix for every solve (aka every iteration).</value>
        [DataMember(Name="writeCoordsAndMatrix", EmitDefaultValue=false)]
        public int? WriteCoordsAndMatrix { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdvancedChronosSettings {\n");
            sb.Append("  ForceFsai: ").Append(ForceFsai).Append("\n");
            sb.Append("  Algorithm: ").Append(Algorithm).Append("\n");
            sb.Append("  Smoother: ").Append(Smoother).Append("\n");
            sb.Append("  Prolongation: ").Append(Prolongation).Append("\n");
            sb.Append("  ImproveTestSpace: ").Append(ImproveTestSpace).Append("\n");
            sb.Append("  TestSpaceIterations: ").Append(TestSpaceIterations).Append("\n");
            sb.Append("  PreconditionerRecycling: ").Append(PreconditionerRecycling).Append("\n");
            sb.Append("  RestartGmres: ").Append(RestartGmres).Append("\n");
            sb.Append("  DistributedMatrixStorage: ").Append(DistributedMatrixStorage).Append("\n");
            sb.Append("  NumOfThreads: ").Append(NumOfThreads).Append("\n");
            sb.Append("  Verbosity: ").Append(Verbosity).Append("\n");
            sb.Append("  WriteCoordsAndMatrix: ").Append(WriteCoordsAndMatrix).Append("\n");
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
            return this.Equals(input as AdvancedChronosSettings);
        }

        /// <summary>
        /// Returns true if AdvancedChronosSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of AdvancedChronosSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdvancedChronosSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ForceFsai == input.ForceFsai ||
                    (this.ForceFsai != null &&
                    this.ForceFsai.Equals(input.ForceFsai))
                ) && 
                (
                    this.Algorithm == input.Algorithm ||
                    this.Algorithm.Equals(input.Algorithm)
                ) && 
                (
                    this.Smoother == input.Smoother ||
                    this.Smoother.Equals(input.Smoother)
                ) && 
                (
                    this.Prolongation == input.Prolongation ||
                    this.Prolongation.Equals(input.Prolongation)
                ) && 
                (
                    this.ImproveTestSpace == input.ImproveTestSpace ||
                    (this.ImproveTestSpace != null &&
                    this.ImproveTestSpace.Equals(input.ImproveTestSpace))
                ) && 
                (
                    this.TestSpaceIterations == input.TestSpaceIterations ||
                    (this.TestSpaceIterations != null &&
                    this.TestSpaceIterations.Equals(input.TestSpaceIterations))
                ) && 
                (
                    this.PreconditionerRecycling == input.PreconditionerRecycling ||
                    (this.PreconditionerRecycling != null &&
                    this.PreconditionerRecycling.Equals(input.PreconditionerRecycling))
                ) && 
                (
                    this.RestartGmres == input.RestartGmres ||
                    (this.RestartGmres != null &&
                    this.RestartGmres.Equals(input.RestartGmres))
                ) && 
                (
                    this.DistributedMatrixStorage == input.DistributedMatrixStorage ||
                    (this.DistributedMatrixStorage != null &&
                    this.DistributedMatrixStorage.Equals(input.DistributedMatrixStorage))
                ) && 
                (
                    this.NumOfThreads == input.NumOfThreads ||
                    (this.NumOfThreads != null &&
                    this.NumOfThreads.Equals(input.NumOfThreads))
                ) && 
                (
                    this.Verbosity == input.Verbosity ||
                    (this.Verbosity != null &&
                    this.Verbosity.Equals(input.Verbosity))
                ) && 
                (
                    this.WriteCoordsAndMatrix == input.WriteCoordsAndMatrix ||
                    (this.WriteCoordsAndMatrix != null &&
                    this.WriteCoordsAndMatrix.Equals(input.WriteCoordsAndMatrix))
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
                if (this.ForceFsai != null)
                    hashCode = hashCode * 59 + this.ForceFsai.GetHashCode();
                hashCode = hashCode * 59 + this.Algorithm.GetHashCode();
                hashCode = hashCode * 59 + this.Smoother.GetHashCode();
                hashCode = hashCode * 59 + this.Prolongation.GetHashCode();
                if (this.ImproveTestSpace != null)
                    hashCode = hashCode * 59 + this.ImproveTestSpace.GetHashCode();
                if (this.TestSpaceIterations != null)
                    hashCode = hashCode * 59 + this.TestSpaceIterations.GetHashCode();
                if (this.PreconditionerRecycling != null)
                    hashCode = hashCode * 59 + this.PreconditionerRecycling.GetHashCode();
                if (this.RestartGmres != null)
                    hashCode = hashCode * 59 + this.RestartGmres.GetHashCode();
                if (this.DistributedMatrixStorage != null)
                    hashCode = hashCode * 59 + this.DistributedMatrixStorage.GetHashCode();
                if (this.NumOfThreads != null)
                    hashCode = hashCode * 59 + this.NumOfThreads.GetHashCode();
                if (this.Verbosity != null)
                    hashCode = hashCode * 59 + this.Verbosity.GetHashCode();
                if (this.WriteCoordsAndMatrix != null)
                    hashCode = hashCode * 59 + this.WriteCoordsAndMatrix.GetHashCode();
                return hashCode;
            }
        }

    }

}
