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
    /// Schemes
    /// </summary>
    [DataContract]
    public partial class Schemes : IEquatable<Schemes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Schemes" /> class.
        /// </summary>
        /// <param name="flux">flux.</param>
        /// <param name="timeDifferentiation">timeDifferentiation.</param>
        /// <param name="gradient">gradient.</param>
        /// <param name="divergence">divergence.</param>
        /// <param name="laplacian">laplacian.</param>
        /// <param name="interpolation">interpolation.</param>
        /// <param name="surfaceNormalGradient">surfaceNormalGradient.</param>
        /// <param name="secondOrderConvection">Whether to use second-order convection scheme, which is less stable but more accurate for a given mesh. If false, first-order accurate upwind scheme is used. (default to false).</param>
        public Schemes(FluxSchemes flux = default(FluxSchemes), TimeDifferentiationSchemes timeDifferentiation = default(TimeDifferentiationSchemes), GradientSchemes gradient = default(GradientSchemes), DivergenceSchemes divergence = default(DivergenceSchemes), LaplacianSchemes laplacian = default(LaplacianSchemes), InterpolationSchemes interpolation = default(InterpolationSchemes), SurfaceNormalGradientSchemes surfaceNormalGradient = default(SurfaceNormalGradientSchemes), bool? secondOrderConvection = default(bool?))
        {
            this.Flux = flux;
            this.TimeDifferentiation = timeDifferentiation;
            this.Gradient = gradient;
            this.Divergence = divergence;
            this.Laplacian = laplacian;
            this.Interpolation = interpolation;
            this.SurfaceNormalGradient = surfaceNormalGradient;
            this.SecondOrderConvection = secondOrderConvection;
        }
        
        /// <summary>
        /// Gets or Sets Flux
        /// </summary>
        [DataMember(Name="flux", EmitDefaultValue=false)]
        public FluxSchemes Flux { get; set; }

        /// <summary>
        /// Gets or Sets TimeDifferentiation
        /// </summary>
        [DataMember(Name="timeDifferentiation", EmitDefaultValue=false)]
        public TimeDifferentiationSchemes TimeDifferentiation { get; set; }

        /// <summary>
        /// Gets or Sets Gradient
        /// </summary>
        [DataMember(Name="gradient", EmitDefaultValue=false)]
        public GradientSchemes Gradient { get; set; }

        /// <summary>
        /// Gets or Sets Divergence
        /// </summary>
        [DataMember(Name="divergence", EmitDefaultValue=false)]
        public DivergenceSchemes Divergence { get; set; }

        /// <summary>
        /// Gets or Sets Laplacian
        /// </summary>
        [DataMember(Name="laplacian", EmitDefaultValue=false)]
        public LaplacianSchemes Laplacian { get; set; }

        /// <summary>
        /// Gets or Sets Interpolation
        /// </summary>
        [DataMember(Name="interpolation", EmitDefaultValue=false)]
        public InterpolationSchemes Interpolation { get; set; }

        /// <summary>
        /// Gets or Sets SurfaceNormalGradient
        /// </summary>
        [DataMember(Name="surfaceNormalGradient", EmitDefaultValue=false)]
        public SurfaceNormalGradientSchemes SurfaceNormalGradient { get; set; }

        /// <summary>
        /// Whether to use second-order convection scheme, which is less stable but more accurate for a given mesh. If false, first-order accurate upwind scheme is used.
        /// </summary>
        /// <value>Whether to use second-order convection scheme, which is less stable but more accurate for a given mesh. If false, first-order accurate upwind scheme is used.</value>
        [DataMember(Name="secondOrderConvection", EmitDefaultValue=false)]
        public bool? SecondOrderConvection { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Schemes {\n");
            sb.Append("  Flux: ").Append(Flux).Append("\n");
            sb.Append("  TimeDifferentiation: ").Append(TimeDifferentiation).Append("\n");
            sb.Append("  Gradient: ").Append(Gradient).Append("\n");
            sb.Append("  Divergence: ").Append(Divergence).Append("\n");
            sb.Append("  Laplacian: ").Append(Laplacian).Append("\n");
            sb.Append("  Interpolation: ").Append(Interpolation).Append("\n");
            sb.Append("  SurfaceNormalGradient: ").Append(SurfaceNormalGradient).Append("\n");
            sb.Append("  SecondOrderConvection: ").Append(SecondOrderConvection).Append("\n");
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
            return this.Equals(input as Schemes);
        }

        /// <summary>
        /// Returns true if Schemes instances are equal
        /// </summary>
        /// <param name="input">Instance of Schemes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Schemes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Flux == input.Flux ||
                    (this.Flux != null &&
                    this.Flux.Equals(input.Flux))
                ) && 
                (
                    this.TimeDifferentiation == input.TimeDifferentiation ||
                    (this.TimeDifferentiation != null &&
                    this.TimeDifferentiation.Equals(input.TimeDifferentiation))
                ) && 
                (
                    this.Gradient == input.Gradient ||
                    (this.Gradient != null &&
                    this.Gradient.Equals(input.Gradient))
                ) && 
                (
                    this.Divergence == input.Divergence ||
                    (this.Divergence != null &&
                    this.Divergence.Equals(input.Divergence))
                ) && 
                (
                    this.Laplacian == input.Laplacian ||
                    (this.Laplacian != null &&
                    this.Laplacian.Equals(input.Laplacian))
                ) && 
                (
                    this.Interpolation == input.Interpolation ||
                    (this.Interpolation != null &&
                    this.Interpolation.Equals(input.Interpolation))
                ) && 
                (
                    this.SurfaceNormalGradient == input.SurfaceNormalGradient ||
                    (this.SurfaceNormalGradient != null &&
                    this.SurfaceNormalGradient.Equals(input.SurfaceNormalGradient))
                ) && 
                (
                    this.SecondOrderConvection == input.SecondOrderConvection ||
                    (this.SecondOrderConvection != null &&
                    this.SecondOrderConvection.Equals(input.SecondOrderConvection))
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
                if (this.Flux != null)
                    hashCode = hashCode * 59 + this.Flux.GetHashCode();
                if (this.TimeDifferentiation != null)
                    hashCode = hashCode * 59 + this.TimeDifferentiation.GetHashCode();
                if (this.Gradient != null)
                    hashCode = hashCode * 59 + this.Gradient.GetHashCode();
                if (this.Divergence != null)
                    hashCode = hashCode * 59 + this.Divergence.GetHashCode();
                if (this.Laplacian != null)
                    hashCode = hashCode * 59 + this.Laplacian.GetHashCode();
                if (this.Interpolation != null)
                    hashCode = hashCode * 59 + this.Interpolation.GetHashCode();
                if (this.SurfaceNormalGradient != null)
                    hashCode = hashCode * 59 + this.SurfaceNormalGradient.GetHashCode();
                if (this.SecondOrderConvection != null)
                    hashCode = hashCode * 59 + this.SecondOrderConvection.GetHashCode();
                return hashCode;
            }
        }

    }

}
