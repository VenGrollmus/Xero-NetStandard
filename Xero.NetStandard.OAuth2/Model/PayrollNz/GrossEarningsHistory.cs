/* 
 * Xero Payroll NZ
 *
 * This is the Xero Payroll API for orgs in the NZ region.
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

namespace Xero.NetStandard.OAuth2.Model.PayrollNz
{
    /// <summary>
    /// GrossEarningsHistory
    /// </summary>
    [DataContract]
    public partial class GrossEarningsHistory :  IEquatable<GrossEarningsHistory>, IValidatableObject
    {
        
        /// <summary>
        /// Number of days the employee worked in the pay period (0 - 365)
        /// </summary>
        /// <value>Number of days the employee worked in the pay period (0 - 365)</value>
        [DataMember(Name="daysPaid", EmitDefaultValue=false)]
        public int? DaysPaid { get; set; }

        /// <summary>
        /// Number of full weeks the employee didn&#39;t work in the pay period (0 - 52)
        /// </summary>
        /// <value>Number of full weeks the employee didn&#39;t work in the pay period (0 - 52)</value>
        [DataMember(Name="unpaidWeeks", EmitDefaultValue=false)]
        public int? UnpaidWeeks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GrossEarningsHistory {\n");
            sb.Append("  DaysPaid: ").Append(DaysPaid).Append("\n");
            sb.Append("  UnpaidWeeks: ").Append(UnpaidWeeks).Append("\n");
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
            return this.Equals(input as GrossEarningsHistory);
        }

        /// <summary>
        /// Returns true if GrossEarningsHistory instances are equal
        /// </summary>
        /// <param name="input">Instance of GrossEarningsHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GrossEarningsHistory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DaysPaid == input.DaysPaid ||
                    this.DaysPaid.Equals(input.DaysPaid)
                ) && 
                (
                    this.UnpaidWeeks == input.UnpaidWeeks ||
                    this.UnpaidWeeks.Equals(input.UnpaidWeeks)
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
                hashCode = hashCode * 59 + this.DaysPaid.GetHashCode();
                hashCode = hashCode * 59 + this.UnpaidWeeks.GetHashCode();
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
