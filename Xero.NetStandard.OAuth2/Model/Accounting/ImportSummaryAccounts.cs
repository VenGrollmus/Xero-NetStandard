/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.5.0
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

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// A summary of the accounts changes
    /// </summary>
    [DataContract]
    public partial class ImportSummaryAccounts :  IEquatable<ImportSummaryAccounts>, IValidatableObject
    {
        
        /// <summary>
        /// The total number of accounts in the org
        /// </summary>
        /// <value>The total number of accounts in the org</value>
        [DataMember(Name="Total", EmitDefaultValue=false)]
        public decimal? Total { get; set; }

        /// <summary>
        /// The number of new accounts created
        /// </summary>
        /// <value>The number of new accounts created</value>
        [DataMember(Name="New", EmitDefaultValue=false)]
        public decimal? New { get; set; }

        /// <summary>
        /// The number of accounts updated
        /// </summary>
        /// <value>The number of accounts updated</value>
        [DataMember(Name="Updated", EmitDefaultValue=false)]
        public decimal? Updated { get; set; }

        /// <summary>
        /// The number of accounts deleted
        /// </summary>
        /// <value>The number of accounts deleted</value>
        [DataMember(Name="Deleted", EmitDefaultValue=false)]
        public decimal? Deleted { get; set; }

        /// <summary>
        /// The number of locked accounts
        /// </summary>
        /// <value>The number of locked accounts</value>
        [DataMember(Name="Locked", EmitDefaultValue=false)]
        public decimal? Locked { get; set; }

        /// <summary>
        /// The number of system accounts
        /// </summary>
        /// <value>The number of system accounts</value>
        [DataMember(Name="System", EmitDefaultValue=false)]
        public decimal? System { get; set; }

        /// <summary>
        /// The number of accounts that had an error
        /// </summary>
        /// <value>The number of accounts that had an error</value>
        [DataMember(Name="Errored", EmitDefaultValue=false)]
        public decimal? Errored { get; set; }

        /// <summary>
        /// Gets or Sets Present
        /// </summary>
        [DataMember(Name="Present", EmitDefaultValue=false)]
        public bool? Present { get; set; }

        /// <summary>
        /// The number of new or updated accounts
        /// </summary>
        /// <value>The number of new or updated accounts</value>
        [DataMember(Name="NewOrUpdated", EmitDefaultValue=false)]
        public decimal? NewOrUpdated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportSummaryAccounts {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  New: ").Append(New).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  System: ").Append(System).Append("\n");
            sb.Append("  Errored: ").Append(Errored).Append("\n");
            sb.Append("  Present: ").Append(Present).Append("\n");
            sb.Append("  NewOrUpdated: ").Append(NewOrUpdated).Append("\n");
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
            return this.Equals(input as ImportSummaryAccounts);
        }

        /// <summary>
        /// Returns true if ImportSummaryAccounts instances are equal
        /// </summary>
        /// <param name="input">Instance of ImportSummaryAccounts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportSummaryAccounts input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.New == input.New ||
                    this.New.Equals(input.New)
                ) && 
                (
                    this.Updated == input.Updated ||
                    this.Updated.Equals(input.Updated)
                ) && 
                (
                    this.Deleted == input.Deleted ||
                    this.Deleted.Equals(input.Deleted)
                ) && 
                (
                    this.Locked == input.Locked ||
                    this.Locked.Equals(input.Locked)
                ) && 
                (
                    this.System == input.System ||
                    this.System.Equals(input.System)
                ) && 
                (
                    this.Errored == input.Errored ||
                    this.Errored.Equals(input.Errored)
                ) && 
                (
                    this.Present == input.Present ||
                    this.Present.Equals(input.Present)
                ) && 
                (
                    this.NewOrUpdated == input.NewOrUpdated ||
                    this.NewOrUpdated.Equals(input.NewOrUpdated)
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
                hashCode = hashCode * 59 + this.Total.GetHashCode();
                hashCode = hashCode * 59 + this.New.GetHashCode();
                hashCode = hashCode * 59 + this.Updated.GetHashCode();
                hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                hashCode = hashCode * 59 + this.Locked.GetHashCode();
                hashCode = hashCode * 59 + this.System.GetHashCode();
                hashCode = hashCode * 59 + this.Errored.GetHashCode();
                hashCode = hashCode * 59 + this.Present.GetHashCode();
                hashCode = hashCode * 59 + this.NewOrUpdated.GetHashCode();
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
