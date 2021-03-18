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
    /// &lt;p&gt;Choose if the Jacobian matrix should automatically change from tangent stiffnes matrix to elastic matrix if the time increment is falling below a given threshold. On the assumption that below a given time increment value the nonlinearities are not evolving within the time step one can strongly save computation time by switching to the elastic matrix.&lt;/p&gt;
    /// </summary>
    [DataContract]
    public partial class TrueChangeJacobianMatrix : OneOfTangentJacobianMatrixChangeJacobianMatrix, IEquatable<TrueChangeJacobianMatrix>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrueChangeJacobianMatrix" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrueChangeJacobianMatrix() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrueChangeJacobianMatrix" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;TRUE&quot;).</param>
        /// <param name="thresholdTimeStepValue">&lt;p&gt;Set the threshold value of the Jacobian matrix changing. If the time increment is lower than this value the elastic matrix is used.&lt;/p&gt; (default to 0.0000010M).</param>
        /// <param name="matrixReactualizationIteration">&lt;p&gt;Set how often the elastic stiffness matrix should be recomputed. If this parameter is set to 10, the elastic matrix is recomputed every 10th iteration within a given time step. If it is set to 0, the elastic stiffness matrix is not updated within any time step.&lt;/p&gt; (default to 0).</param>
        /// <param name="maxNewtonIterations">&lt;p&gt;Maximum number of allowed Newton iterations per time increment. If this value is reached the simulation is considered non-converging. If an automatic time stepping is activated the time increment is reduced in order to reach convergence.&lt;/p&gt; (default to 35).</param>
        public TrueChangeJacobianMatrix(string type = "TRUE", decimal? thresholdTimeStepValue = default(decimal?), int? matrixReactualizationIteration = default(int?), int? maxNewtonIterations = default(int?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for TrueChangeJacobianMatrix and cannot be null");
            this.ThresholdTimeStepValue = thresholdTimeStepValue;
            this.MatrixReactualizationIteration = matrixReactualizationIteration;
            this.MaxNewtonIterations = maxNewtonIterations;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// &lt;p&gt;Set the threshold value of the Jacobian matrix changing. If the time increment is lower than this value the elastic matrix is used.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Set the threshold value of the Jacobian matrix changing. If the time increment is lower than this value the elastic matrix is used.&lt;/p&gt;</value>
        [DataMember(Name="thresholdTimeStepValue", EmitDefaultValue=false)]
        public decimal? ThresholdTimeStepValue { get; set; }

        /// <summary>
        /// &lt;p&gt;Set how often the elastic stiffness matrix should be recomputed. If this parameter is set to 10, the elastic matrix is recomputed every 10th iteration within a given time step. If it is set to 0, the elastic stiffness matrix is not updated within any time step.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Set how often the elastic stiffness matrix should be recomputed. If this parameter is set to 10, the elastic matrix is recomputed every 10th iteration within a given time step. If it is set to 0, the elastic stiffness matrix is not updated within any time step.&lt;/p&gt;</value>
        [DataMember(Name="matrixReactualizationIteration", EmitDefaultValue=false)]
        public int? MatrixReactualizationIteration { get; set; }

        /// <summary>
        /// &lt;p&gt;Maximum number of allowed Newton iterations per time increment. If this value is reached the simulation is considered non-converging. If an automatic time stepping is activated the time increment is reduced in order to reach convergence.&lt;/p&gt;
        /// </summary>
        /// <value>&lt;p&gt;Maximum number of allowed Newton iterations per time increment. If this value is reached the simulation is considered non-converging. If an automatic time stepping is activated the time increment is reduced in order to reach convergence.&lt;/p&gt;</value>
        [DataMember(Name="maxNewtonIterations", EmitDefaultValue=false)]
        public int? MaxNewtonIterations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrueChangeJacobianMatrix {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ThresholdTimeStepValue: ").Append(ThresholdTimeStepValue).Append("\n");
            sb.Append("  MatrixReactualizationIteration: ").Append(MatrixReactualizationIteration).Append("\n");
            sb.Append("  MaxNewtonIterations: ").Append(MaxNewtonIterations).Append("\n");
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
            return this.Equals(input as TrueChangeJacobianMatrix);
        }

        /// <summary>
        /// Returns true if TrueChangeJacobianMatrix instances are equal
        /// </summary>
        /// <param name="input">Instance of TrueChangeJacobianMatrix to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrueChangeJacobianMatrix input)
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
                    this.ThresholdTimeStepValue == input.ThresholdTimeStepValue ||
                    (this.ThresholdTimeStepValue != null &&
                    this.ThresholdTimeStepValue.Equals(input.ThresholdTimeStepValue))
                ) && 
                (
                    this.MatrixReactualizationIteration == input.MatrixReactualizationIteration ||
                    (this.MatrixReactualizationIteration != null &&
                    this.MatrixReactualizationIteration.Equals(input.MatrixReactualizationIteration))
                ) && 
                (
                    this.MaxNewtonIterations == input.MaxNewtonIterations ||
                    (this.MaxNewtonIterations != null &&
                    this.MaxNewtonIterations.Equals(input.MaxNewtonIterations))
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
                if (this.ThresholdTimeStepValue != null)
                    hashCode = hashCode * 59 + this.ThresholdTimeStepValue.GetHashCode();
                if (this.MatrixReactualizationIteration != null)
                    hashCode = hashCode * 59 + this.MatrixReactualizationIteration.GetHashCode();
                if (this.MaxNewtonIterations != null)
                    hashCode = hashCode * 59 + this.MaxNewtonIterations.GetHashCode();
                return hashCode;
            }
        }

    }

}