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
    /// ConjugateHeatTransfer
    /// </summary>
    [DataContract]
    public partial class ConjugateHeatTransfer : Analysis, IEquatable<ConjugateHeatTransfer>
    {
        /// <summary>
        /// Choose a turbulence model for your CFD analysis:&lt;ul&gt;&lt;li&gt;&lt;strong&gt;No turbulence&lt;/strong&gt;: Laminar&lt;/li&gt;&lt;li&gt;&lt;strong&gt;RANS&lt;/strong&gt;: &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/global-settings/k-epsilon/&#39; target&#x3D;&#39;_blank&#39;&gt;k-epsilon&lt;/a&gt;, &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/global-settings/k-omega-sst/&#39; target&#x3D;&#39;_blank&#39;&gt;k-omega and k-omega SST&lt;/a&gt;&lt;/li&gt;&lt;li&gt;&lt;strong&gt;LES&lt;/strong&gt;: Smagorinsky, Spalart-Allmaras&lt;/li&gt;&lt;/ul&gt;&lt;p&gt;&lt;p&gt;&lt;a href&#x3D;&#39;https://www.simscale.com/blog/2017/12/turbulence-cfd-analysis/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.&lt;/p&gt;
        /// </summary>
        /// <value>Choose a turbulence model for your CFD analysis:&lt;ul&gt;&lt;li&gt;&lt;strong&gt;No turbulence&lt;/strong&gt;: Laminar&lt;/li&gt;&lt;li&gt;&lt;strong&gt;RANS&lt;/strong&gt;: &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/global-settings/k-epsilon/&#39; target&#x3D;&#39;_blank&#39;&gt;k-epsilon&lt;/a&gt;, &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/global-settings/k-omega-sst/&#39; target&#x3D;&#39;_blank&#39;&gt;k-omega and k-omega SST&lt;/a&gt;&lt;/li&gt;&lt;li&gt;&lt;strong&gt;LES&lt;/strong&gt;: Smagorinsky, Spalart-Allmaras&lt;/li&gt;&lt;/ul&gt;&lt;p&gt;&lt;p&gt;&lt;a href&#x3D;&#39;https://www.simscale.com/blog/2017/12/turbulence-cfd-analysis/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.&lt;/p&gt;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TurbulenceModelEnum
        {
            /// <summary>
            /// Enum SMAGORINSKY for value: SMAGORINSKY
            /// </summary>
            [EnumMember(Value = "SMAGORINSKY")]
            SMAGORINSKY = 1,

            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE = 2,

            /// <summary>
            /// Enum KEPSILON for value: KEPSILON
            /// </summary>
            [EnumMember(Value = "KEPSILON")]
            KEPSILON = 3,

            /// <summary>
            /// Enum KOMEGASST for value: KOMEGASST
            /// </summary>
            [EnumMember(Value = "KOMEGASST")]
            KOMEGASST = 4

        }

        /// <summary>
        /// Choose a turbulence model for your CFD analysis:&lt;ul&gt;&lt;li&gt;&lt;strong&gt;No turbulence&lt;/strong&gt;: Laminar&lt;/li&gt;&lt;li&gt;&lt;strong&gt;RANS&lt;/strong&gt;: &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/global-settings/k-epsilon/&#39; target&#x3D;&#39;_blank&#39;&gt;k-epsilon&lt;/a&gt;, &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/global-settings/k-omega-sst/&#39; target&#x3D;&#39;_blank&#39;&gt;k-omega and k-omega SST&lt;/a&gt;&lt;/li&gt;&lt;li&gt;&lt;strong&gt;LES&lt;/strong&gt;: Smagorinsky, Spalart-Allmaras&lt;/li&gt;&lt;/ul&gt;&lt;p&gt;&lt;p&gt;&lt;a href&#x3D;&#39;https://www.simscale.com/blog/2017/12/turbulence-cfd-analysis/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.&lt;/p&gt;
        /// </summary>
        /// <value>Choose a turbulence model for your CFD analysis:&lt;ul&gt;&lt;li&gt;&lt;strong&gt;No turbulence&lt;/strong&gt;: Laminar&lt;/li&gt;&lt;li&gt;&lt;strong&gt;RANS&lt;/strong&gt;: &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/global-settings/k-epsilon/&#39; target&#x3D;&#39;_blank&#39;&gt;k-epsilon&lt;/a&gt;, &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/global-settings/k-omega-sst/&#39; target&#x3D;&#39;_blank&#39;&gt;k-omega and k-omega SST&lt;/a&gt;&lt;/li&gt;&lt;li&gt;&lt;strong&gt;LES&lt;/strong&gt;: Smagorinsky, Spalart-Allmaras&lt;/li&gt;&lt;/ul&gt;&lt;p&gt;&lt;p&gt;&lt;a href&#x3D;&#39;https://www.simscale.com/blog/2017/12/turbulence-cfd-analysis/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.&lt;/p&gt;</value>
        [DataMember(Name="turbulenceModel", EmitDefaultValue=false)]
        public TurbulenceModelEnum? TurbulenceModel { get; set; }
        /// <summary>
        /// Defines ContactHandlingMode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContactHandlingModeEnum
        {
            /// <summary>
            /// Enum MANUAL for value: MANUAL
            /// </summary>
            [EnumMember(Value = "MANUAL")]
            MANUAL = 1,

            /// <summary>
            /// Enum AUTO for value: AUTO
            /// </summary>
            [EnumMember(Value = "AUTO")]
            AUTO = 2

        }

        /// <summary>
        /// Gets or Sets ContactHandlingMode
        /// </summary>
        [DataMember(Name="contactHandlingMode", EmitDefaultValue=false)]
        public ContactHandlingModeEnum? ContactHandlingMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConjugateHeatTransfer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConjugateHeatTransfer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConjugateHeatTransfer" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;CONJUGATE_HEAT_TRANSFER&quot;).</param>
        /// <param name="enableRadiation">Heat transfer through radiation takes place in the form of electromagnetic waves and it can be calculated in the simulation. This phenomenon becomes more important when the temperatures involved in the simulation are large. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/analysis-types/convective-heat-transfer-analysis/radiation/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;. (default to false).</param>
        /// <param name="turbulenceModel">Choose a turbulence model for your CFD analysis:&lt;ul&gt;&lt;li&gt;&lt;strong&gt;No turbulence&lt;/strong&gt;: Laminar&lt;/li&gt;&lt;li&gt;&lt;strong&gt;RANS&lt;/strong&gt;: &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/global-settings/k-epsilon/&#39; target&#x3D;&#39;_blank&#39;&gt;k-epsilon&lt;/a&gt;, &lt;a href&#x3D;&#39;https://www.simscale.com/docs/simulation-setup/global-settings/k-omega-sst/&#39; target&#x3D;&#39;_blank&#39;&gt;k-omega and k-omega SST&lt;/a&gt;&lt;/li&gt;&lt;li&gt;&lt;strong&gt;LES&lt;/strong&gt;: Smagorinsky, Spalart-Allmaras&lt;/li&gt;&lt;/ul&gt;&lt;p&gt;&lt;p&gt;&lt;a href&#x3D;&#39;https://www.simscale.com/blog/2017/12/turbulence-cfd-analysis/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.&lt;/p&gt; (default to TurbulenceModelEnum.NONE).</param>
        /// <param name="timeDependency">timeDependency.</param>
        /// <param name="connectionGroups">connectionGroups.</param>
        /// <param name="model">model.</param>
        /// <param name="materials">materials.</param>
        /// <param name="initialConditions">initialConditions.</param>
        /// <param name="boundaryConditions">boundaryConditions.</param>
        /// <param name="advancedConcepts">advancedConcepts.</param>
        /// <param name="numerics">numerics.</param>
        /// <param name="simulationControl">simulationControl.</param>
        /// <param name="resultControl">resultControl.</param>
        /// <param name="contactHandlingMode">contactHandlingMode (default to ContactHandlingModeEnum.MANUAL).</param>
        public ConjugateHeatTransfer(string type = "CONJUGATE_HEAT_TRANSFER", bool? enableRadiation = default(bool?), TurbulenceModelEnum? turbulenceModel = default(TurbulenceModelEnum?), OneOfConjugateHeatTransferTimeDependency timeDependency = default(OneOfConjugateHeatTransferTimeDependency), List<FluidInterface> connectionGroups = default(List<FluidInterface>), FluidModel model = default(FluidModel), ConjugateHeatTransferMaterials materials = default(ConjugateHeatTransferMaterials), FluidInitialConditions initialConditions = default(FluidInitialConditions), List<OneOfConjugateHeatTransferBoundaryConditions> boundaryConditions = default(List<OneOfConjugateHeatTransferBoundaryConditions>), AdvancedConcepts advancedConcepts = default(AdvancedConcepts), FluidNumerics numerics = default(FluidNumerics), FluidSimulationControl simulationControl = default(FluidSimulationControl), FluidResultControls resultControl = default(FluidResultControls), ContactHandlingModeEnum? contactHandlingMode = default(ContactHandlingModeEnum?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for ConjugateHeatTransfer and cannot be null");
            this.EnableRadiation = enableRadiation;
            this.TurbulenceModel = turbulenceModel;
            this.TimeDependency = timeDependency;
            this.ConnectionGroups = connectionGroups;
            this.Model = model;
            this.Materials = materials;
            this.InitialConditions = initialConditions;
            this.BoundaryConditions = boundaryConditions;
            this.AdvancedConcepts = advancedConcepts;
            this.Numerics = numerics;
            this.SimulationControl = simulationControl;
            this.ResultControl = resultControl;
            this.ContactHandlingMode = contactHandlingMode;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Heat transfer through radiation takes place in the form of electromagnetic waves and it can be calculated in the simulation. This phenomenon becomes more important when the temperatures involved in the simulation are large. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/analysis-types/convective-heat-transfer-analysis/radiation/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.
        /// </summary>
        /// <value>Heat transfer through radiation takes place in the form of electromagnetic waves and it can be calculated in the simulation. This phenomenon becomes more important when the temperatures involved in the simulation are large. &lt;a href&#x3D;&#39;https://www.simscale.com/docs/analysis-types/convective-heat-transfer-analysis/radiation/&#39; target&#x3D;&#39;_blank&#39;&gt;Learn more&lt;/a&gt;.</value>
        [DataMember(Name="enableRadiation", EmitDefaultValue=false)]
        public bool? EnableRadiation { get; set; }

        /// <summary>
        /// Gets or Sets TimeDependency
        /// </summary>
        [DataMember(Name="timeDependency", EmitDefaultValue=false)]
        public OneOfConjugateHeatTransferTimeDependency TimeDependency { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionGroups
        /// </summary>
        [DataMember(Name="connectionGroups", EmitDefaultValue=false)]
        public List<FluidInterface> ConnectionGroups { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name="model", EmitDefaultValue=false)]
        public FluidModel Model { get; set; }

        /// <summary>
        /// Gets or Sets Materials
        /// </summary>
        [DataMember(Name="materials", EmitDefaultValue=false)]
        public ConjugateHeatTransferMaterials Materials { get; set; }

        /// <summary>
        /// Gets or Sets InitialConditions
        /// </summary>
        [DataMember(Name="initialConditions", EmitDefaultValue=false)]
        public FluidInitialConditions InitialConditions { get; set; }

        /// <summary>
        /// Gets or Sets BoundaryConditions
        /// </summary>
        [DataMember(Name="boundaryConditions", EmitDefaultValue=false)]
        public List<OneOfConjugateHeatTransferBoundaryConditions> BoundaryConditions { get; set; }

        /// <summary>
        /// Gets or Sets AdvancedConcepts
        /// </summary>
        [DataMember(Name="advancedConcepts", EmitDefaultValue=false)]
        public AdvancedConcepts AdvancedConcepts { get; set; }

        /// <summary>
        /// Gets or Sets Numerics
        /// </summary>
        [DataMember(Name="numerics", EmitDefaultValue=false)]
        public FluidNumerics Numerics { get; set; }

        /// <summary>
        /// Gets or Sets SimulationControl
        /// </summary>
        [DataMember(Name="simulationControl", EmitDefaultValue=false)]
        public FluidSimulationControl SimulationControl { get; set; }

        /// <summary>
        /// Gets or Sets ResultControl
        /// </summary>
        [DataMember(Name="resultControl", EmitDefaultValue=false)]
        public FluidResultControls ResultControl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConjugateHeatTransfer {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  EnableRadiation: ").Append(EnableRadiation).Append("\n");
            sb.Append("  TurbulenceModel: ").Append(TurbulenceModel).Append("\n");
            sb.Append("  TimeDependency: ").Append(TimeDependency).Append("\n");
            sb.Append("  ConnectionGroups: ").Append(ConnectionGroups).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Materials: ").Append(Materials).Append("\n");
            sb.Append("  InitialConditions: ").Append(InitialConditions).Append("\n");
            sb.Append("  BoundaryConditions: ").Append(BoundaryConditions).Append("\n");
            sb.Append("  AdvancedConcepts: ").Append(AdvancedConcepts).Append("\n");
            sb.Append("  Numerics: ").Append(Numerics).Append("\n");
            sb.Append("  SimulationControl: ").Append(SimulationControl).Append("\n");
            sb.Append("  ResultControl: ").Append(ResultControl).Append("\n");
            sb.Append("  ContactHandlingMode: ").Append(ContactHandlingMode).Append("\n");
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
            return this.Equals(input as ConjugateHeatTransfer);
        }

        /// <summary>
        /// Returns true if ConjugateHeatTransfer instances are equal
        /// </summary>
        /// <param name="input">Instance of ConjugateHeatTransfer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConjugateHeatTransfer input)
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
                    this.EnableRadiation == input.EnableRadiation ||
                    (this.EnableRadiation != null &&
                    this.EnableRadiation.Equals(input.EnableRadiation))
                ) && 
                (
                    this.TurbulenceModel == input.TurbulenceModel ||
                    this.TurbulenceModel.Equals(input.TurbulenceModel)
                ) && 
                (
                    this.TimeDependency == input.TimeDependency ||
                    (this.TimeDependency != null &&
                    this.TimeDependency.Equals(input.TimeDependency))
                ) && 
                (
                    this.ConnectionGroups == input.ConnectionGroups ||
                    this.ConnectionGroups != null &&
                    input.ConnectionGroups != null &&
                    this.ConnectionGroups.SequenceEqual(input.ConnectionGroups)
                ) && 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.Materials == input.Materials ||
                    (this.Materials != null &&
                    this.Materials.Equals(input.Materials))
                ) && 
                (
                    this.InitialConditions == input.InitialConditions ||
                    (this.InitialConditions != null &&
                    this.InitialConditions.Equals(input.InitialConditions))
                ) && 
                (
                    this.BoundaryConditions == input.BoundaryConditions ||
                    this.BoundaryConditions != null &&
                    input.BoundaryConditions != null &&
                    this.BoundaryConditions.SequenceEqual(input.BoundaryConditions)
                ) && 
                (
                    this.AdvancedConcepts == input.AdvancedConcepts ||
                    (this.AdvancedConcepts != null &&
                    this.AdvancedConcepts.Equals(input.AdvancedConcepts))
                ) && 
                (
                    this.Numerics == input.Numerics ||
                    (this.Numerics != null &&
                    this.Numerics.Equals(input.Numerics))
                ) && 
                (
                    this.SimulationControl == input.SimulationControl ||
                    (this.SimulationControl != null &&
                    this.SimulationControl.Equals(input.SimulationControl))
                ) && 
                (
                    this.ResultControl == input.ResultControl ||
                    (this.ResultControl != null &&
                    this.ResultControl.Equals(input.ResultControl))
                ) && 
                (
                    this.ContactHandlingMode == input.ContactHandlingMode ||
                    this.ContactHandlingMode.Equals(input.ContactHandlingMode)
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
                if (this.EnableRadiation != null)
                    hashCode = hashCode * 59 + this.EnableRadiation.GetHashCode();
                hashCode = hashCode * 59 + this.TurbulenceModel.GetHashCode();
                if (this.TimeDependency != null)
                    hashCode = hashCode * 59 + this.TimeDependency.GetHashCode();
                if (this.ConnectionGroups != null)
                    hashCode = hashCode * 59 + this.ConnectionGroups.GetHashCode();
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.Materials != null)
                    hashCode = hashCode * 59 + this.Materials.GetHashCode();
                if (this.InitialConditions != null)
                    hashCode = hashCode * 59 + this.InitialConditions.GetHashCode();
                if (this.BoundaryConditions != null)
                    hashCode = hashCode * 59 + this.BoundaryConditions.GetHashCode();
                if (this.AdvancedConcepts != null)
                    hashCode = hashCode * 59 + this.AdvancedConcepts.GetHashCode();
                if (this.Numerics != null)
                    hashCode = hashCode * 59 + this.Numerics.GetHashCode();
                if (this.SimulationControl != null)
                    hashCode = hashCode * 59 + this.SimulationControl.GetHashCode();
                if (this.ResultControl != null)
                    hashCode = hashCode * 59 + this.ResultControl.GetHashCode();
                hashCode = hashCode * 59 + this.ContactHandlingMode.GetHashCode();
                return hashCode;
            }
        }

    }

}