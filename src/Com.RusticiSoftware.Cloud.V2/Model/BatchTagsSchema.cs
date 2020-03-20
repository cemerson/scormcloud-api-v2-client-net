/* 
 * SCORM Cloud Rest API
 *
 * REST API used for SCORM Cloud integrations.
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Com.RusticiSoftware.Cloud.V2.Client.SwaggerDateConverter;

namespace Com.RusticiSoftware.Cloud.V2.Model
{
    /// <summary>
    /// BatchTagsSchema
    /// </summary>
    [DataContract]
    public partial class BatchTagsSchema :  IEquatable<BatchTagsSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchTagsSchema" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BatchTagsSchema() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchTagsSchema" /> class.
        /// </summary>
        /// <param name="ids">ids (required).</param>
        /// <param name="tags">tags (required).</param>
        public BatchTagsSchema(List<string> ids = default(List<string>), List<string> tags = default(List<string>))
        {
            // to ensure "ids" is required (not null)
            if (ids == null)
            {
                throw new InvalidDataException("ids is a required property for BatchTagsSchema and cannot be null");
            }
            else
            {
                this.Ids = ids;
            }
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new InvalidDataException("tags is a required property for BatchTagsSchema and cannot be null");
            }
            else
            {
                this.Tags = tags;
            }
        }
        
        /// <summary>
        /// Gets or Sets Ids
        /// </summary>
        [DataMember(Name="ids", EmitDefaultValue=false)]
        public List<string> Ids { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchTagsSchema {\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as BatchTagsSchema);
        }

        /// <summary>
        /// Returns true if BatchTagsSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of BatchTagsSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BatchTagsSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ids == input.Ids ||
                    this.Ids != null &&
                    this.Ids.SequenceEqual(input.Ids)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.Ids != null)
                    hashCode = hashCode * 59 + this.Ids.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
