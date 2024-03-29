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
    /// ModalSolver
    /// </summary>
    [DataContract]
    public partial class ModalSolver : IEquatable<ModalSolver>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModalSolver" /> class.
        /// </summary>
        /// <param name="solver">solver.</param>
        /// <param name="solverModel">solverModel.</param>
        /// <param name="eigenSolver">eigenSolver.</param>
        /// <param name="calculateFrequency">calculateFrequency.</param>
        /// <param name="eigenMode">eigenMode.</param>
        /// <param name="enhancedAccuracy">Further increase the accuracy of the results by running two simulations. The results of the first one will be used as input for the second one to fine-tune the setup. (default to false).</param>
        public ModalSolver(OneOfModalSolverSolver solver = default(OneOfModalSolverSolver), Object solverModel = default(Object), OneOfModalSolverEigenSolver eigenSolver = default(OneOfModalSolverEigenSolver), CalculateFrequency calculateFrequency = default(CalculateFrequency), EigenModeVerification eigenMode = default(EigenModeVerification), bool? enhancedAccuracy = default(bool?))
        {
            this.Solver = solver;
            this.SolverModel = solverModel;
            this.EigenSolver = eigenSolver;
            this.CalculateFrequency = calculateFrequency;
            this.EigenMode = eigenMode;
            this.EnhancedAccuracy = enhancedAccuracy;
        }
        
        /// <summary>
        /// Gets or Sets Solver
        /// </summary>
        [DataMember(Name="solver", EmitDefaultValue=false)]
        public OneOfModalSolverSolver Solver { get; set; }

        /// <summary>
        /// Gets or Sets SolverModel
        /// </summary>
        [DataMember(Name="solverModel", EmitDefaultValue=false)]
        public Object SolverModel { get; set; }

        /// <summary>
        /// Gets or Sets EigenSolver
        /// </summary>
        [DataMember(Name="eigenSolver", EmitDefaultValue=false)]
        public OneOfModalSolverEigenSolver EigenSolver { get; set; }

        /// <summary>
        /// Gets or Sets CalculateFrequency
        /// </summary>
        [DataMember(Name="calculateFrequency", EmitDefaultValue=false)]
        public CalculateFrequency CalculateFrequency { get; set; }

        /// <summary>
        /// Gets or Sets EigenMode
        /// </summary>
        [DataMember(Name="eigenMode", EmitDefaultValue=false)]
        public EigenModeVerification EigenMode { get; set; }

        /// <summary>
        /// Further increase the accuracy of the results by running two simulations. The results of the first one will be used as input for the second one to fine-tune the setup.
        /// </summary>
        /// <value>Further increase the accuracy of the results by running two simulations. The results of the first one will be used as input for the second one to fine-tune the setup.</value>
        [DataMember(Name="enhancedAccuracy", EmitDefaultValue=false)]
        public bool? EnhancedAccuracy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModalSolver {\n");
            sb.Append("  Solver: ").Append(Solver).Append("\n");
            sb.Append("  SolverModel: ").Append(SolverModel).Append("\n");
            sb.Append("  EigenSolver: ").Append(EigenSolver).Append("\n");
            sb.Append("  CalculateFrequency: ").Append(CalculateFrequency).Append("\n");
            sb.Append("  EigenMode: ").Append(EigenMode).Append("\n");
            sb.Append("  EnhancedAccuracy: ").Append(EnhancedAccuracy).Append("\n");
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
            return this.Equals(input as ModalSolver);
        }

        /// <summary>
        /// Returns true if ModalSolver instances are equal
        /// </summary>
        /// <param name="input">Instance of ModalSolver to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModalSolver input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Solver == input.Solver ||
                    (this.Solver != null &&
                    this.Solver.Equals(input.Solver))
                ) && 
                (
                    this.SolverModel == input.SolverModel ||
                    (this.SolverModel != null &&
                    this.SolverModel.Equals(input.SolverModel))
                ) && 
                (
                    this.EigenSolver == input.EigenSolver ||
                    (this.EigenSolver != null &&
                    this.EigenSolver.Equals(input.EigenSolver))
                ) && 
                (
                    this.CalculateFrequency == input.CalculateFrequency ||
                    (this.CalculateFrequency != null &&
                    this.CalculateFrequency.Equals(input.CalculateFrequency))
                ) && 
                (
                    this.EigenMode == input.EigenMode ||
                    (this.EigenMode != null &&
                    this.EigenMode.Equals(input.EigenMode))
                ) && 
                (
                    this.EnhancedAccuracy == input.EnhancedAccuracy ||
                    (this.EnhancedAccuracy != null &&
                    this.EnhancedAccuracy.Equals(input.EnhancedAccuracy))
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
                if (this.Solver != null)
                    hashCode = hashCode * 59 + this.Solver.GetHashCode();
                if (this.SolverModel != null)
                    hashCode = hashCode * 59 + this.SolverModel.GetHashCode();
                if (this.EigenSolver != null)
                    hashCode = hashCode * 59 + this.EigenSolver.GetHashCode();
                if (this.CalculateFrequency != null)
                    hashCode = hashCode * 59 + this.CalculateFrequency.GetHashCode();
                if (this.EigenMode != null)
                    hashCode = hashCode * 59 + this.EigenMode.GetHashCode();
                if (this.EnhancedAccuracy != null)
                    hashCode = hashCode * 59 + this.EnhancedAccuracy.GetHashCode();
                return hashCode;
            }
        }

    }

}
