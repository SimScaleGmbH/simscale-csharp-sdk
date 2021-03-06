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
    /// SimulationRun
    /// </summary>
    [DataContract]
    public partial class SimulationRun : IEquatable<SimulationRun>
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public Status? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRun" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SimulationRun() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRun" /> class.
        /// </summary>
        /// <param name="name">The name of the simulation run. (required).</param>
        /// <param name="computeResource">computeResource.</param>
        /// <param name="status">status.</param>
        public SimulationRun(string name = default(string), SimulationRunComputeResource computeResource = default(SimulationRunComputeResource), Status? status = default(Status?))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for SimulationRun and cannot be null");
            this.ComputeResource = computeResource;
            this.Status = status;
        }
        
        /// <summary>
        /// Gets or Sets RunId
        /// </summary>
        [DataMember(Name="runId", EmitDefaultValue=false)]
        public Guid? RunId { get; private set; }

        /// <summary>
        /// The name of the simulation run.
        /// </summary>
        /// <value>The name of the simulation run.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The time when the simulation run was created.
        /// </summary>
        /// <value>The time when the simulation run was created.</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTimeOffset? CreatedAt { get; private set; }

        /// <summary>
        /// The time when the simulation run was started.
        /// </summary>
        /// <value>The time when the simulation run was started.</value>
        [DataMember(Name="startedAt", EmitDefaultValue=false)]
        public DateTimeOffset? StartedAt { get; private set; }

        /// <summary>
        /// The time when the simulation run was finished.
        /// </summary>
        /// <value>The time when the simulation run was finished.</value>
        [DataMember(Name="finishedAt", EmitDefaultValue=false)]
        public DateTimeOffset? FinishedAt { get; private set; }

        /// <summary>
        /// The actual duration of the simulation run.
        /// </summary>
        /// <value>The actual duration of the simulation run.</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public string Duration { get; private set; }

        /// <summary>
        /// Gets or Sets ComputeResource
        /// </summary>
        [DataMember(Name="computeResource", EmitDefaultValue=false)]
        public SimulationRunComputeResource ComputeResource { get; set; }

        /// <summary>
        /// The current progress while the simulation run is in progress.
        /// </summary>
        /// <value>The current progress while the simulation run is in progress.</value>
        [DataMember(Name="progress", EmitDefaultValue=false)]
        public decimal? Progress { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimulationRun {\n");
            sb.Append("  RunId: ").Append(RunId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  StartedAt: ").Append(StartedAt).Append("\n");
            sb.Append("  FinishedAt: ").Append(FinishedAt).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  ComputeResource: ").Append(ComputeResource).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
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
            return this.Equals(input as SimulationRun);
        }

        /// <summary>
        /// Returns true if SimulationRun instances are equal
        /// </summary>
        /// <param name="input">Instance of SimulationRun to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimulationRun input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RunId == input.RunId ||
                    (this.RunId != null &&
                    this.RunId.Equals(input.RunId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.StartedAt == input.StartedAt ||
                    (this.StartedAt != null &&
                    this.StartedAt.Equals(input.StartedAt))
                ) && 
                (
                    this.FinishedAt == input.FinishedAt ||
                    (this.FinishedAt != null &&
                    this.FinishedAt.Equals(input.FinishedAt))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.ComputeResource == input.ComputeResource ||
                    (this.ComputeResource != null &&
                    this.ComputeResource.Equals(input.ComputeResource))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Progress == input.Progress ||
                    (this.Progress != null &&
                    this.Progress.Equals(input.Progress))
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
                if (this.RunId != null)
                    hashCode = hashCode * 59 + this.RunId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.StartedAt != null)
                    hashCode = hashCode * 59 + this.StartedAt.GetHashCode();
                if (this.FinishedAt != null)
                    hashCode = hashCode * 59 + this.FinishedAt.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.ComputeResource != null)
                    hashCode = hashCode * 59 + this.ComputeResource.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Progress != null)
                    hashCode = hashCode * 59 + this.Progress.GetHashCode();
                return hashCode;
            }
        }

    }

}
