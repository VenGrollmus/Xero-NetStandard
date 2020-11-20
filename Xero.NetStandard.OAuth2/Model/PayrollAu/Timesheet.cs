/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
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

namespace Xero.NetStandard.OAuth2.Model.PayrollAu
{
    /// <summary>
    /// Timesheet
    /// </summary>
    [DataContract]
    public partial class Timesheet :  IEquatable<Timesheet>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public TimesheetStatus Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Timesheet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Timesheet() 
        {  
          TimesheetLines = new List<TimesheetLine>();  
          ValidationErrors = new List<ValidationError>(); 
        }
        
        /// <summary>
        /// The Xero identifier for an employee
        /// </summary>
        /// <value>The Xero identifier for an employee</value>
        [DataMember(Name="EmployeeID", EmitDefaultValue=false)]
        public Guid? EmployeeID { get; set; }

        /// <summary>
        /// Period start date (YYYY-MM-DD)
        /// </summary>
        /// <value>Period start date (YYYY-MM-DD)</value>
        [DataMember(Name="StartDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Period end date (YYYY-MM-DD)
        /// </summary>
        /// <value>Period end date (YYYY-MM-DD)</value>
        [DataMember(Name="EndDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Timesheet total hours
        /// </summary>
        /// <value>Timesheet total hours</value>
        [DataMember(Name="Hours", EmitDefaultValue=false)]
        public decimal? Hours { get; set; }

        /// <summary>
        /// The Xero identifier for a Payroll Timesheet
        /// </summary>
        /// <value>The Xero identifier for a Payroll Timesheet</value>
        [DataMember(Name="TimesheetID", EmitDefaultValue=false)]
        public Guid? TimesheetID { get; set; }

        /// <summary>
        /// Gets or Sets TimesheetLines
        /// </summary>
        [DataMember(Name="TimesheetLines", EmitDefaultValue=false)]
        public List<TimesheetLine> TimesheetLines { get; set; }

        /// <summary>
        /// Last modified timestamp
        /// </summary>
        /// <value>Last modified timestamp</value>
        [DataMember(Name="UpdatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; private set; }

        /// <summary>
        /// Displays array of validation error messages from the API
        /// </summary>
        /// <value>Displays array of validation error messages from the API</value>
        [DataMember(Name="ValidationErrors", EmitDefaultValue=false)]
        public List<ValidationError> ValidationErrors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Timesheet {\n");
            sb.Append("  EmployeeID: ").Append(EmployeeID).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Hours: ").Append(Hours).Append("\n");
            sb.Append("  TimesheetID: ").Append(TimesheetID).Append("\n");
            sb.Append("  TimesheetLines: ").Append(TimesheetLines).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
            sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
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
            return this.Equals(input as Timesheet);
        }

        /// <summary>
        /// Returns true if Timesheet instances are equal
        /// </summary>
        /// <param name="input">Instance of Timesheet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Timesheet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmployeeID == input.EmployeeID ||
                    (this.EmployeeID != null &&
                    this.EmployeeID.Equals(input.EmployeeID))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Hours == input.Hours ||
                    this.Hours.Equals(input.Hours)
                ) && 
                (
                    this.TimesheetID == input.TimesheetID ||
                    (this.TimesheetID != null &&
                    this.TimesheetID.Equals(input.TimesheetID))
                ) && 
                (
                    this.TimesheetLines == input.TimesheetLines ||
                    this.TimesheetLines != null &&
                    input.TimesheetLines != null &&
                    this.TimesheetLines.SequenceEqual(input.TimesheetLines)
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
                ) && 
                (
                    this.ValidationErrors == input.ValidationErrors ||
                    this.ValidationErrors != null &&
                    input.ValidationErrors != null &&
                    this.ValidationErrors.SequenceEqual(input.ValidationErrors)
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
                if (this.EmployeeID != null)
                    hashCode = hashCode * 59 + this.EmployeeID.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.Hours.GetHashCode();
                if (this.TimesheetID != null)
                    hashCode = hashCode * 59 + this.TimesheetID.GetHashCode();
                if (this.TimesheetLines != null)
                    hashCode = hashCode * 59 + this.TimesheetLines.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
                if (this.ValidationErrors != null)
                    hashCode = hashCode * 59 + this.ValidationErrors.GetHashCode();
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
