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
    /// DestinationSchema
    /// </summary>
    [DataContract]
    public partial class DestinationSchema :  IEquatable<DestinationSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationSchema" /> class.
        /// </summary>
        /// <param name="name">The destination&#39;s name..</param>
        /// <param name="tags">Optional array of tags..</param>
        /// <param name="email">SCORM Cloud user e-mail associated with this destination. If this is not provided, it will default to the owner of the Realm. .</param>
        /// <param name="notes">Any provided notes about this Destination.</param>
        /// <param name="launchAuth">launchAuth.</param>
        public DestinationSchema(string name = default(string), List<string> tags = default(List<string>), string email = default(string), string notes = default(string), LaunchAuthSchema launchAuth = default(LaunchAuthSchema))
        {
            this.Name = name;
            this.Tags = tags;
            this.Email = email;
            this.Notes = notes;
            this.LaunchAuth = launchAuth;
        }
        
        /// <summary>
        /// The destination&#39;s name.
        /// </summary>
        /// <value>The destination&#39;s name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Optional array of tags.
        /// </summary>
        /// <value>Optional array of tags.</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// SCORM Cloud user e-mail associated with this destination. If this is not provided, it will default to the owner of the Realm. 
        /// </summary>
        /// <value>SCORM Cloud user e-mail associated with this destination. If this is not provided, it will default to the owner of the Realm. </value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Any provided notes about this Destination
        /// </summary>
        /// <value>Any provided notes about this Destination</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets LaunchAuth
        /// </summary>
        [DataMember(Name="launchAuth", EmitDefaultValue=false)]
        public LaunchAuthSchema LaunchAuth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinationSchema {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  LaunchAuth: ").Append(LaunchAuth).Append("\n");
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
            return this.Equals(input as DestinationSchema);
        }

        /// <summary>
        /// Returns true if DestinationSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinationSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinationSchema input)
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
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
                ) && 
                (
                    this.LaunchAuth == input.LaunchAuth ||
                    (this.LaunchAuth != null &&
                    this.LaunchAuth.Equals(input.LaunchAuth))
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
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                if (this.LaunchAuth != null)
                    hashCode = hashCode * 59 + this.LaunchAuth.GetHashCode();
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
