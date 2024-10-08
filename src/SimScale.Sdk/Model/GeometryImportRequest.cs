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
    /// GeometryImportRequest
    /// </summary>
    [DataContract]
    public partial class GeometryImportRequest : IEquatable<GeometryImportRequest>
    {
        /// <summary>
        /// The CAD format.
        /// </summary>
        /// <value>The CAD format.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatEnum
        {
            /// <summary>
            /// Enum ACIS for value: ACIS
            /// </summary>
            [EnumMember(Value = "ACIS")]
            ACIS = 1,

            /// <summary>
            /// Enum CATIA for value: CATIA
            /// </summary>
            [EnumMember(Value = "CATIA")]
            CATIA = 2,

            /// <summary>
            /// Enum CREO for value: CREO
            /// </summary>
            [EnumMember(Value = "CREO")]
            CREO = 3,

            /// <summary>
            /// Enum IGES for value: IGES
            /// </summary>
            [EnumMember(Value = "IGES")]
            IGES = 4,

            /// <summary>
            /// Enum INVENTOR for value: INVENTOR
            /// </summary>
            [EnumMember(Value = "INVENTOR")]
            INVENTOR = 5,

            /// <summary>
            /// Enum NX for value: NX
            /// </summary>
            [EnumMember(Value = "NX")]
            NX = 6,

            /// <summary>
            /// Enum PARASOLID for value: PARASOLID
            /// </summary>
            [EnumMember(Value = "PARASOLID")]
            PARASOLID = 7,

            /// <summary>
            /// Enum REVIT for value: REVIT
            /// </summary>
            [EnumMember(Value = "REVIT")]
            REVIT = 8,

            /// <summary>
            /// Enum RHINOCEROS for value: RHINOCEROS
            /// </summary>
            [EnumMember(Value = "RHINOCEROS")]
            RHINOCEROS = 9,

            /// <summary>
            /// Enum SOLIDEDGE for value: SOLIDEDGE
            /// </summary>
            [EnumMember(Value = "SOLIDEDGE")]
            SOLIDEDGE = 10,

            /// <summary>
            /// Enum SOLIDWORKS for value: SOLIDWORKS
            /// </summary>
            [EnumMember(Value = "SOLIDWORKS")]
            SOLIDWORKS = 11,

            /// <summary>
            /// Enum STEP for value: STEP
            /// </summary>
            [EnumMember(Value = "STEP")]
            STEP = 12,

            /// <summary>
            /// Enum STL for value: STL
            /// </summary>
            [EnumMember(Value = "STL")]
            STL = 13

        }

        /// <summary>
        /// The CAD format.
        /// </summary>
        /// <value>The CAD format.</value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public FormatEnum Format { get; set; }
        /// <summary>
        /// Gets or Sets InputUnit
        /// </summary>
        [DataMember(Name="inputUnit", EmitDefaultValue=false)]
        public GeometryUnit InputUnit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GeometryImportRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GeometryImportRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GeometryImportRequest" /> class.
        /// </summary>
        /// <param name="name">The name of the imported geometry. (required).</param>
        /// <param name="location">location (required).</param>
        /// <param name="format">The CAD format. (required).</param>
        /// <param name="inputUnit">inputUnit (required).</param>
        /// <param name="options">options (required).</param>
        public GeometryImportRequest(string name = default(string), GeometryImportRequestLocation location = default(GeometryImportRequestLocation), FormatEnum format = default(FormatEnum), GeometryUnit inputUnit = default(GeometryUnit), GeometryImportRequestOptions options = default(GeometryImportRequestOptions))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for GeometryImportRequest and cannot be null");
            // to ensure "location" is required (not null)
            this.Location = location ?? throw new ArgumentNullException("location is a required property for GeometryImportRequest and cannot be null");
            this.Format = format;
            this.InputUnit = inputUnit;
            // to ensure "options" is required (not null)
            this.Options = options ?? throw new ArgumentNullException("options is a required property for GeometryImportRequest and cannot be null");
        }
        
        /// <summary>
        /// The name of the imported geometry.
        /// </summary>
        /// <value>The name of the imported geometry.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public GeometryImportRequestLocation Location { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public GeometryImportRequestOptions Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeometryImportRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  InputUnit: ").Append(InputUnit).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
            return this.Equals(input as GeometryImportRequest);
        }

        /// <summary>
        /// Returns true if GeometryImportRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GeometryImportRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeometryImportRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.Format == input.Format ||
                    this.Format.Equals(input.Format)
                ) && 
                (
                    this.InputUnit == input.InputUnit ||
                    this.InputUnit.Equals(input.InputUnit)
                ) && 
                (
                    this.Options == input.Options ||
                    (this.Options != null &&
                    this.Options.Equals(input.Options))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                hashCode = hashCode * 59 + this.Format.GetHashCode();
                hashCode = hashCode * 59 + this.InputUnit.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                return hashCode;
            }
        }

    }

}
