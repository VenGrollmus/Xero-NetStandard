/* 
 * Xero Files API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.8.3
 * Contact: api@xero.com
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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.Files
{
    /// <summary>
    /// Association
    /// </summary>
    [DataContract]
    public partial class Association :  IEquatable<Association>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ObjectGroup
        /// </summary>
        [DataMember(Name="ObjectGroup", EmitDefaultValue=false)]
        public ObjectGroup ObjectGroup { get; set; }
        /// <summary>
        /// Gets or Sets ObjectType
        /// </summary>
        [DataMember(Name="ObjectType", EmitDefaultValue=false)]
        public ObjectType ObjectType { get; set; }
        
        /// <summary>
        /// The unique identifier of the file
        /// </summary>
        /// <value>The unique identifier of the file</value>
        [DataMember(Name="FileId", EmitDefaultValue=false)]
        public Guid? FileId { get; set; }

        /// <summary>
        /// The identifier of the object that the file is being associated with (e.g. InvoiceID, BankTransactionID, ContactID)
        /// </summary>
        /// <value>The identifier of the object that the file is being associated with (e.g. InvoiceID, BankTransactionID, ContactID)</value>
        [DataMember(Name="ObjectId", EmitDefaultValue=false)]
        public Guid? ObjectId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Association {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  ObjectGroup: ").Append(ObjectGroup).Append("\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
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
            return this.Equals(input as Association);
        }

        /// <summary>
        /// Returns true if Association instances are equal
        /// </summary>
        /// <param name="input">Instance of Association to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Association input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileId == input.FileId ||
                    (this.FileId != null &&
                    this.FileId.Equals(input.FileId))
                ) && 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
                ) && 
                (
                    this.ObjectGroup == input.ObjectGroup ||
                    this.ObjectGroup.Equals(input.ObjectGroup)
                ) && 
                (
                    this.ObjectType == input.ObjectType ||
                    this.ObjectType.Equals(input.ObjectType)
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
                if (this.FileId != null)
                    hashCode = hashCode * 59 + this.FileId.GetHashCode();
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                hashCode = hashCode * 59 + this.ObjectGroup.GetHashCode();
                hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
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
