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
    /// UserInvitationSchema
    /// </summary>
    [DataContract]
    public partial class UserInvitationSchema :  IEquatable<UserInvitationSchema>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInvitationSchema" /> class.
        /// </summary>
        /// <param name="email">The email of the user who took an invitation..</param>
        /// <param name="url">The URL which the user would follow to take the invitation..</param>
        /// <param name="isStarted">A boolean flag stating if the user has started the invitation..</param>
        /// <param name="updated">updated.</param>
        /// <param name="registrationId">The id of the registration which was created from the user being invited..</param>
        /// <param name="registrationReport">registrationReport.</param>
        public UserInvitationSchema(string email = default(string), string url = default(string), bool? isStarted = default(bool?), DateTime? updated = default(DateTime?), string registrationId = default(string), UserInvitationSchemaRegistrationReport registrationReport = default(UserInvitationSchemaRegistrationReport))
        {
            this.Email = email;
            this.Url = url;
            this.IsStarted = isStarted;
            this.Updated = updated;
            this.RegistrationId = registrationId;
            this.RegistrationReport = registrationReport;
        }
        
        /// <summary>
        /// The email of the user who took an invitation.
        /// </summary>
        /// <value>The email of the user who took an invitation.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// The URL which the user would follow to take the invitation.
        /// </summary>
        /// <value>The URL which the user would follow to take the invitation.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// A boolean flag stating if the user has started the invitation.
        /// </summary>
        /// <value>A boolean flag stating if the user has started the invitation.</value>
        [DataMember(Name="isStarted", EmitDefaultValue=false)]
        public bool? IsStarted { get; set; }

        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name="updated", EmitDefaultValue=false)]
        public DateTime? Updated { get; set; }

        /// <summary>
        /// The id of the registration which was created from the user being invited.
        /// </summary>
        /// <value>The id of the registration which was created from the user being invited.</value>
        [DataMember(Name="registrationId", EmitDefaultValue=false)]
        public string RegistrationId { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationReport
        /// </summary>
        [DataMember(Name="registrationReport", EmitDefaultValue=false)]
        public UserInvitationSchemaRegistrationReport RegistrationReport { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserInvitationSchema {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  IsStarted: ").Append(IsStarted).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  RegistrationId: ").Append(RegistrationId).Append("\n");
            sb.Append("  RegistrationReport: ").Append(RegistrationReport).Append("\n");
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
            return this.Equals(input as UserInvitationSchema);
        }

        /// <summary>
        /// Returns true if UserInvitationSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of UserInvitationSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserInvitationSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.IsStarted == input.IsStarted ||
                    (this.IsStarted != null &&
                    this.IsStarted.Equals(input.IsStarted))
                ) && 
                (
                    this.Updated == input.Updated ||
                    (this.Updated != null &&
                    this.Updated.Equals(input.Updated))
                ) && 
                (
                    this.RegistrationId == input.RegistrationId ||
                    (this.RegistrationId != null &&
                    this.RegistrationId.Equals(input.RegistrationId))
                ) && 
                (
                    this.RegistrationReport == input.RegistrationReport ||
                    (this.RegistrationReport != null &&
                    this.RegistrationReport.Equals(input.RegistrationReport))
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
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.IsStarted != null)
                    hashCode = hashCode * 59 + this.IsStarted.GetHashCode();
                if (this.Updated != null)
                    hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.RegistrationId != null)
                    hashCode = hashCode * 59 + this.RegistrationId.GetHashCode();
                if (this.RegistrationReport != null)
                    hashCode = hashCode * 59 + this.RegistrationReport.GetHashCode();
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
