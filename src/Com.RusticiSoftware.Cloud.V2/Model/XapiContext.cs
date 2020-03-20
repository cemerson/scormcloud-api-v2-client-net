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
    /// https://github.com/adlnet/xAPI-Spec/blob/1.0.2/xAPI.md#416-context
    /// </summary>
    [DataContract]
    public partial class XapiContext :  IEquatable<XapiContext>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XapiContext" /> class.
        /// </summary>
        /// <param name="registration">registration.</param>
        /// <param name="instructor">instructor.</param>
        /// <param name="team">team.</param>
        /// <param name="contextActivities">contextActivities.</param>
        /// <param name="revision">revision.</param>
        /// <param name="platform">platform.</param>
        /// <param name="language">language.</param>
        /// <param name="statement">statement.</param>
        /// <param name="extensions">extensions.</param>
        public XapiContext(string registration = default(string), XapiAgentGroup instructor = default(XapiAgentGroup), XapiAgentGroup team = default(XapiAgentGroup), XapiContextActivity contextActivities = default(XapiContextActivity), string revision = default(string), string platform = default(string), string language = default(string), XapiStatementReference statement = default(XapiStatementReference), Dictionary<string, Object> extensions = default(Dictionary<string, Object>))
        {
            this.Registration = registration;
            this.Instructor = instructor;
            this.Team = team;
            this.ContextActivities = contextActivities;
            this.Revision = revision;
            this.Platform = platform;
            this.Language = language;
            this.Statement = statement;
            this.Extensions = extensions;
        }
        
        /// <summary>
        /// Gets or Sets Registration
        /// </summary>
        [DataMember(Name="registration", EmitDefaultValue=false)]
        public string Registration { get; set; }

        /// <summary>
        /// Gets or Sets Instructor
        /// </summary>
        [DataMember(Name="instructor", EmitDefaultValue=false)]
        public XapiAgentGroup Instructor { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public XapiAgentGroup Team { get; set; }

        /// <summary>
        /// Gets or Sets ContextActivities
        /// </summary>
        [DataMember(Name="contextActivities", EmitDefaultValue=false)]
        public XapiContextActivity ContextActivities { get; set; }

        /// <summary>
        /// Gets or Sets Revision
        /// </summary>
        [DataMember(Name="revision", EmitDefaultValue=false)]
        public string Revision { get; set; }

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name="platform", EmitDefaultValue=false)]
        public string Platform { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets Statement
        /// </summary>
        [DataMember(Name="statement", EmitDefaultValue=false)]
        public XapiStatementReference Statement { get; set; }

        /// <summary>
        /// Gets or Sets Extensions
        /// </summary>
        [DataMember(Name="extensions", EmitDefaultValue=false)]
        public Dictionary<string, Object> Extensions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XapiContext {\n");
            sb.Append("  Registration: ").Append(Registration).Append("\n");
            sb.Append("  Instructor: ").Append(Instructor).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  ContextActivities: ").Append(ContextActivities).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Statement: ").Append(Statement).Append("\n");
            sb.Append("  Extensions: ").Append(Extensions).Append("\n");
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
            return this.Equals(input as XapiContext);
        }

        /// <summary>
        /// Returns true if XapiContext instances are equal
        /// </summary>
        /// <param name="input">Instance of XapiContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XapiContext input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Registration == input.Registration ||
                    (this.Registration != null &&
                    this.Registration.Equals(input.Registration))
                ) && 
                (
                    this.Instructor == input.Instructor ||
                    (this.Instructor != null &&
                    this.Instructor.Equals(input.Instructor))
                ) && 
                (
                    this.Team == input.Team ||
                    (this.Team != null &&
                    this.Team.Equals(input.Team))
                ) && 
                (
                    this.ContextActivities == input.ContextActivities ||
                    (this.ContextActivities != null &&
                    this.ContextActivities.Equals(input.ContextActivities))
                ) && 
                (
                    this.Revision == input.Revision ||
                    (this.Revision != null &&
                    this.Revision.Equals(input.Revision))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Statement == input.Statement ||
                    (this.Statement != null &&
                    this.Statement.Equals(input.Statement))
                ) && 
                (
                    this.Extensions == input.Extensions ||
                    this.Extensions != null &&
                    this.Extensions.SequenceEqual(input.Extensions)
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
                if (this.Registration != null)
                    hashCode = hashCode * 59 + this.Registration.GetHashCode();
                if (this.Instructor != null)
                    hashCode = hashCode * 59 + this.Instructor.GetHashCode();
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                if (this.ContextActivities != null)
                    hashCode = hashCode * 59 + this.ContextActivities.GetHashCode();
                if (this.Revision != null)
                    hashCode = hashCode * 59 + this.Revision.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Statement != null)
                    hashCode = hashCode * 59 + this.Statement.GetHashCode();
                if (this.Extensions != null)
                    hashCode = hashCode * 59 + this.Extensions.GetHashCode();
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
