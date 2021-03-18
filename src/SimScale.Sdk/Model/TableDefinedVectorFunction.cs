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
    /// TableDefinedVectorFunction
    /// </summary>
    [DataContract]
    public partial class TableDefinedVectorFunction : OneOfDimensionalVectorFunctionAccelerationValue, OneOfDimensionalVectorFunctionForceValue, OneOfDimensionalVectorFunctionLengthValue, OneOfDimensionalVectorFunctionPressureValue, OneOfDimensionalVectorFunctionSpeedValue, OneOfDimensionalVectorFunctionTorqueValue, OneOfDimensionalVectorFunctionVolumeForceValue, IEquatable<TableDefinedVectorFunction>
    {
        /// <summary>
        /// Defines OutOfBounds
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OutOfBoundsEnum
        {
            /// <summary>
            /// Enum CLAMP for value: CLAMP
            /// </summary>
            [EnumMember(Value = "CLAMP")]
            CLAMP = 1

        }

        /// <summary>
        /// Gets or Sets OutOfBounds
        /// </summary>
        [DataMember(Name="outOfBounds", EmitDefaultValue=false)]
        public OutOfBoundsEnum? OutOfBounds { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TableDefinedVectorFunction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TableDefinedVectorFunction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TableDefinedVectorFunction" /> class.
        /// </summary>
        /// <param name="type">type (required) (default to &quot;TABLE_DEFINED&quot;).</param>
        /// <param name="label">label (default to &quot;Table&quot;).</param>
        /// <param name="tableId">The ID of the imported table..</param>
        /// <param name="resultIndex">Indicates which column(s) of the table contains the result values. One-based indexing must be used. For example, set this field to &#39;[2]&#39; if the second column of the table contains the dependent variable values..</param>
        /// <param name="independentVariables">independentVariables.</param>
        /// <param name="separator">Values in each row are separated by this character. Also known as a delimiter. (default to &quot;,&quot;).</param>
        /// <param name="outOfBounds">outOfBounds (default to OutOfBoundsEnum.CLAMP).</param>
        public TableDefinedVectorFunction(string type = "TABLE_DEFINED", string label = default(string), Guid? tableId = default(Guid?), List<int?> resultIndex = default(List<int?>), List<TableFunctionParameter> independentVariables = default(List<TableFunctionParameter>), string separator = default(string), OutOfBoundsEnum? outOfBounds = default(OutOfBoundsEnum?))
        {
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for TableDefinedVectorFunction and cannot be null");
            this.Label = label;
            this.TableId = tableId;
            this.ResultIndex = resultIndex;
            this.IndependentVariables = independentVariables;
            this.Separator = separator;
            this.OutOfBounds = outOfBounds;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// The ID of the imported table.
        /// </summary>
        /// <value>The ID of the imported table.</value>
        [DataMember(Name="tableId", EmitDefaultValue=false)]
        public Guid? TableId { get; set; }

        /// <summary>
        /// Indicates which column(s) of the table contains the result values. One-based indexing must be used. For example, set this field to &#39;[2]&#39; if the second column of the table contains the dependent variable values.
        /// </summary>
        /// <value>Indicates which column(s) of the table contains the result values. One-based indexing must be used. For example, set this field to &#39;[2]&#39; if the second column of the table contains the dependent variable values.</value>
        [DataMember(Name="resultIndex", EmitDefaultValue=false)]
        public List<int?> ResultIndex { get; set; }

        /// <summary>
        /// Gets or Sets IndependentVariables
        /// </summary>
        [DataMember(Name="independentVariables", EmitDefaultValue=false)]
        public List<TableFunctionParameter> IndependentVariables { get; set; }

        /// <summary>
        /// Values in each row are separated by this character. Also known as a delimiter.
        /// </summary>
        /// <value>Values in each row are separated by this character. Also known as a delimiter.</value>
        [DataMember(Name="separator", EmitDefaultValue=false)]
        public string Separator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableDefinedVectorFunction {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  TableId: ").Append(TableId).Append("\n");
            sb.Append("  ResultIndex: ").Append(ResultIndex).Append("\n");
            sb.Append("  IndependentVariables: ").Append(IndependentVariables).Append("\n");
            sb.Append("  Separator: ").Append(Separator).Append("\n");
            sb.Append("  OutOfBounds: ").Append(OutOfBounds).Append("\n");
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
            return this.Equals(input as TableDefinedVectorFunction);
        }

        /// <summary>
        /// Returns true if TableDefinedVectorFunction instances are equal
        /// </summary>
        /// <param name="input">Instance of TableDefinedVectorFunction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TableDefinedVectorFunction input)
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
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.TableId == input.TableId ||
                    (this.TableId != null &&
                    this.TableId.Equals(input.TableId))
                ) && 
                (
                    this.ResultIndex == input.ResultIndex ||
                    this.ResultIndex != null &&
                    input.ResultIndex != null &&
                    this.ResultIndex.SequenceEqual(input.ResultIndex)
                ) && 
                (
                    this.IndependentVariables == input.IndependentVariables ||
                    this.IndependentVariables != null &&
                    input.IndependentVariables != null &&
                    this.IndependentVariables.SequenceEqual(input.IndependentVariables)
                ) && 
                (
                    this.Separator == input.Separator ||
                    (this.Separator != null &&
                    this.Separator.Equals(input.Separator))
                ) && 
                (
                    this.OutOfBounds == input.OutOfBounds ||
                    this.OutOfBounds.Equals(input.OutOfBounds)
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
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.TableId != null)
                    hashCode = hashCode * 59 + this.TableId.GetHashCode();
                if (this.ResultIndex != null)
                    hashCode = hashCode * 59 + this.ResultIndex.GetHashCode();
                if (this.IndependentVariables != null)
                    hashCode = hashCode * 59 + this.IndependentVariables.GetHashCode();
                if (this.Separator != null)
                    hashCode = hashCode * 59 + this.Separator.GetHashCode();
                hashCode = hashCode * 59 + this.OutOfBounds.GetHashCode();
                return hashCode;
            }
        }

    }

}