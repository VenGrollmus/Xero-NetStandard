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
    /// EmployeeLeave
    /// </summary>
    [DataContract]
    public partial class EmployeeLeave :  IEquatable<EmployeeLeave>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeLeave" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public EmployeeLeave() 
        {  
          Periods = new List<LeavePeriod>(); 
        }
        
        /// <summary>
        /// The Xero identifier for LeaveType
        /// </summary>
        /// <value>The Xero identifier for LeaveType</value>
        [DataMember(Name="leaveID", EmitDefaultValue=false)]
        public Guid? LeaveID { get; set; }

        /// <summary>
        /// The Xero identifier for LeaveType
        /// </summary>
        /// <value>The Xero identifier for LeaveType</value>
        [DataMember(Name="leaveTypeID", EmitDefaultValue=false)]
        public Guid? LeaveTypeID { get; set; }

        /// <summary>
        /// The description of the leave  (max length &#x3D; 50)
        /// </summary>
        /// <value>The description of the leave  (max length &#x3D; 50)</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Start date of the leave (YYYY-MM-DD)
        /// </summary>
        /// <value>Start date of the leave (YYYY-MM-DD)</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// End date of the leave (YYYY-MM-DD)
        /// </summary>
        /// <value>End date of the leave (YYYY-MM-DD)</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The leave period information. The StartDate, EndDate and NumberOfUnits needs to be specified when you do not want to calculate NumberOfUnits automatically. Using incorrect period StartDate and EndDate will result in automatic computation of the NumberOfUnits.
        /// </summary>
        /// <value>The leave period information. The StartDate, EndDate and NumberOfUnits needs to be specified when you do not want to calculate NumberOfUnits automatically. Using incorrect period StartDate and EndDate will result in automatic computation of the NumberOfUnits.</value>
        [DataMember(Name="periods", EmitDefaultValue=false)]
        public List<LeavePeriod> Periods { get; set; }

        /// <summary>
        /// UTC timestamp of last update to the leave type note
        /// </summary>
        /// <value>UTC timestamp of last update to the leave type note</value>
        [DataMember(Name="updatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmployeeLeave {\n");
            sb.Append("  LeaveID: ").Append(LeaveID).Append("\n");
            sb.Append("  LeaveTypeID: ").Append(LeaveTypeID).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Periods: ").Append(Periods).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
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
            return this.Equals(input as EmployeeLeave);
        }

        /// <summary>
        /// Returns true if EmployeeLeave instances are equal
        /// </summary>
        /// <param name="input">Instance of EmployeeLeave to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployeeLeave input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LeaveID == input.LeaveID ||
                    (this.LeaveID != null &&
                    this.LeaveID.Equals(input.LeaveID))
                ) && 
                (
                    this.LeaveTypeID == input.LeaveTypeID ||
                    (this.LeaveTypeID != null &&
                    this.LeaveTypeID.Equals(input.LeaveTypeID))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                    this.Periods == input.Periods ||
                    this.Periods != null &&
                    input.Periods != null &&
                    this.Periods.SequenceEqual(input.Periods)
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
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
                if (this.LeaveID != null)
                    hashCode = hashCode * 59 + this.LeaveID.GetHashCode();
                if (this.LeaveTypeID != null)
                    hashCode = hashCode * 59 + this.LeaveTypeID.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Periods != null)
                    hashCode = hashCode * 59 + this.Periods.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
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
