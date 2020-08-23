/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.2.13
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
    /// ReportRows
    /// </summary>
    [DataContract]
    public partial class ReportRows :  IEquatable<ReportRows>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets RowType
        /// </summary>
        [DataMember(Name="RowType", EmitDefaultValue=false)]
        public RowType RowType { get; set; }
        
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="Title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Cells
        /// </summary>
        [DataMember(Name="Cells", EmitDefaultValue=false)]
        public List<ReportCell> Cells { get; set; }

        /// <summary>
        /// Gets or Sets Rows
        /// </summary>
        [DataMember(Name="Rows", EmitDefaultValue=false)]
        public List<ReportRow> Rows { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportRows {\n");
            sb.Append("  RowType: ").Append(RowType).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Cells: ").Append(Cells).Append("\n");
            sb.Append("  Rows: ").Append(Rows).Append("\n");
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
            return this.Equals(input as ReportRows);
        }

        /// <summary>
        /// Returns true if ReportRows instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportRows to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportRows input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RowType == input.RowType ||
                    this.RowType.Equals(input.RowType)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Cells == input.Cells ||
                    this.Cells != null &&
                    input.Cells != null &&
                    this.Cells.SequenceEqual(input.Cells)
                ) && 
                (
                    this.Rows == input.Rows ||
                    this.Rows != null &&
                    input.Rows != null &&
                    this.Rows.SequenceEqual(input.Rows)
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
                hashCode = hashCode * 59 + this.RowType.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Cells != null)
                    hashCode = hashCode * 59 + this.Cells.GetHashCode();
                if (this.Rows != null)
                    hashCode = hashCode * 59 + this.Rows.GetHashCode();
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
