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
    /// Storage
    /// </summary>
    [DataContract]
    public partial class Storage : IEquatable<Storage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Storage" /> class.
        /// </summary>
        /// <param name="storageId">The storage ID..</param>
        /// <param name="expiresAt">The expiration time..</param>
        public Storage(string storageId = default(string), DateTimeOffset? expiresAt = default(DateTimeOffset?))
        {
            this.StorageId = storageId;
            this.ExpiresAt = expiresAt;
        }
        
        /// <summary>
        /// The URL of the temporary storage location.
        /// </summary>
        /// <value>The URL of the temporary storage location.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; private set; }

        /// <summary>
        /// The storage ID.
        /// </summary>
        /// <value>The storage ID.</value>
        [DataMember(Name="storageId", EmitDefaultValue=false)]
        public string StorageId { get; set; }

        /// <summary>
        /// The expiration time.
        /// </summary>
        /// <value>The expiration time.</value>
        [DataMember(Name="expiresAt", EmitDefaultValue=false)]
        public DateTimeOffset? ExpiresAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Storage {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  StorageId: ").Append(StorageId).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
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
            return this.Equals(input as Storage);
        }

        /// <summary>
        /// Returns true if Storage instances are equal
        /// </summary>
        /// <param name="input">Instance of Storage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Storage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.StorageId == input.StorageId ||
                    (this.StorageId != null &&
                    this.StorageId.Equals(input.StorageId))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.StorageId != null)
                    hashCode = hashCode * 59 + this.StorageId.GetHashCode();
                if (this.ExpiresAt != null)
                    hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                return hashCode;
            }
        }

    }

}