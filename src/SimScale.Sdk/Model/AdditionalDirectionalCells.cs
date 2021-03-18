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
    /// AdditionalDirectionalCells
    /// </summary>
    [DataContract]
    public partial class AdditionalDirectionalCells : IEquatable<AdditionalDirectionalCells>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDirectionalCells" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdditionalDirectionalCells() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDirectionalCells" /> class.
        /// </summary>
        /// <param name="x">Specify the number of additional cells to be added in the X-direction. Note: additional cells in the negative X direction is not supported. (required).</param>
        /// <param name="y">Specify the number of additional cells to be added in the Y-direction. Note: additional cells in the negative Y direction is not supported. (required).</param>
        /// <param name="z">Specify the number of additional cells to be added in the Z-direction. Note: additional cells in the negative Z direction is not supported. (required).</param>
        public AdditionalDirectionalCells(int? x = default(int?), int? y = default(int?), int? z = default(int?))
        {
            // to ensure "x" is required (not null)
            this.X = x ?? throw new ArgumentNullException("x is a required property for AdditionalDirectionalCells and cannot be null");
            // to ensure "y" is required (not null)
            this.Y = y ?? throw new ArgumentNullException("y is a required property for AdditionalDirectionalCells and cannot be null");
            // to ensure "z" is required (not null)
            this.Z = z ?? throw new ArgumentNullException("z is a required property for AdditionalDirectionalCells and cannot be null");
        }
        
        /// <summary>
        /// Specify the number of additional cells to be added in the X-direction. Note: additional cells in the negative X direction is not supported.
        /// </summary>
        /// <value>Specify the number of additional cells to be added in the X-direction. Note: additional cells in the negative X direction is not supported.</value>
        [DataMember(Name="x", EmitDefaultValue=false)]
        public int? X { get; set; }

        /// <summary>
        /// Specify the number of additional cells to be added in the Y-direction. Note: additional cells in the negative Y direction is not supported.
        /// </summary>
        /// <value>Specify the number of additional cells to be added in the Y-direction. Note: additional cells in the negative Y direction is not supported.</value>
        [DataMember(Name="y", EmitDefaultValue=false)]
        public int? Y { get; set; }

        /// <summary>
        /// Specify the number of additional cells to be added in the Z-direction. Note: additional cells in the negative Z direction is not supported.
        /// </summary>
        /// <value>Specify the number of additional cells to be added in the Z-direction. Note: additional cells in the negative Z direction is not supported.</value>
        [DataMember(Name="z", EmitDefaultValue=false)]
        public int? Z { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalDirectionalCells {\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Z: ").Append(Z).Append("\n");
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
            return this.Equals(input as AdditionalDirectionalCells);
        }

        /// <summary>
        /// Returns true if AdditionalDirectionalCells instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalDirectionalCells to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalDirectionalCells input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.X == input.X ||
                    (this.X != null &&
                    this.X.Equals(input.X))
                ) && 
                (
                    this.Y == input.Y ||
                    (this.Y != null &&
                    this.Y.Equals(input.Y))
                ) && 
                (
                    this.Z == input.Z ||
                    (this.Z != null &&
                    this.Z.Equals(input.Z))
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
                if (this.X != null)
                    hashCode = hashCode * 59 + this.X.GetHashCode();
                if (this.Y != null)
                    hashCode = hashCode * 59 + this.Y.GetHashCode();
                if (this.Z != null)
                    hashCode = hashCode * 59 + this.Z.GetHashCode();
                return hashCode;
            }
        }

    }

}