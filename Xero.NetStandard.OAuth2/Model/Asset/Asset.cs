/* 
 * Xero Assets API
 *
 * This is the Xero Assets API
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

namespace Xero.NetStandard.OAuth2.Model.Asset
{
    /// <summary>
    /// Asset
    /// </summary>
    [DataContract]
    public partial class Asset :  IEquatable<Asset>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets AssetStatus
        /// </summary>
        [DataMember(Name="assetStatus", EmitDefaultValue=false)]
        public AssetStatus AssetStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Asset" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Asset() 
        { 
        }
        
        /// <summary>
        /// The Xero-generated Id for the asset
        /// </summary>
        /// <value>The Xero-generated Id for the asset</value>
        [DataMember(Name="assetId", EmitDefaultValue=false)]
        public Guid? AssetId { get; set; }

        /// <summary>
        /// The name of the asset
        /// </summary>
        /// <value>The name of the asset</value>
        [DataMember(Name="assetName", EmitDefaultValue=false)]
        public string AssetName { get; set; }

        /// <summary>
        /// The Xero-generated Id for the asset type
        /// </summary>
        /// <value>The Xero-generated Id for the asset type</value>
        [DataMember(Name="assetTypeId", EmitDefaultValue=false)]
        public Guid? AssetTypeId { get; set; }

        /// <summary>
        /// Must be unique.
        /// </summary>
        /// <value>Must be unique.</value>
        [DataMember(Name="assetNumber", EmitDefaultValue=false)]
        public string AssetNumber { get; set; }

        /// <summary>
        /// The date the asset was purchased YYYY-MM-DD
        /// </summary>
        /// <value>The date the asset was purchased YYYY-MM-DD</value>
        [DataMember(Name="purchaseDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? PurchaseDate { get; set; }

        /// <summary>
        /// The purchase price of the asset
        /// </summary>
        /// <value>The purchase price of the asset</value>
        [DataMember(Name="purchasePrice", EmitDefaultValue=false)]
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// The date the asset was disposed
        /// </summary>
        /// <value>The date the asset was disposed</value>
        [DataMember(Name="disposalDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? DisposalDate { get; set; }

        /// <summary>
        /// The price the asset was disposed at
        /// </summary>
        /// <value>The price the asset was disposed at</value>
        [DataMember(Name="disposalPrice", EmitDefaultValue=false)]
        public decimal? DisposalPrice { get; set; }

        /// <summary>
        /// The date the asset’s warranty expires (if needed) YYYY-MM-DD
        /// </summary>
        /// <value>The date the asset’s warranty expires (if needed) YYYY-MM-DD</value>
        [DataMember(Name="warrantyExpiryDate", EmitDefaultValue=false)]
        public string WarrantyExpiryDate { get; set; }

        /// <summary>
        /// The asset&#39;s serial number
        /// </summary>
        /// <value>The asset&#39;s serial number</value>
        [DataMember(Name="serialNumber", EmitDefaultValue=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or Sets BookDepreciationSetting
        /// </summary>
        [DataMember(Name="bookDepreciationSetting", EmitDefaultValue=false)]
        public BookDepreciationSetting BookDepreciationSetting { get; set; }

        /// <summary>
        /// Gets or Sets BookDepreciationDetail
        /// </summary>
        [DataMember(Name="bookDepreciationDetail", EmitDefaultValue=false)]
        public BookDepreciationDetail BookDepreciationDetail { get; set; }

        /// <summary>
        /// Boolean to indicate whether depreciation can be rolled back for this asset individually. This is true if it doesn&#39;t have &#39;legacy&#39; journal entries and if there is no lock period that would prevent this asset from rolling back.
        /// </summary>
        /// <value>Boolean to indicate whether depreciation can be rolled back for this asset individually. This is true if it doesn&#39;t have &#39;legacy&#39; journal entries and if there is no lock period that would prevent this asset from rolling back.</value>
        [DataMember(Name="canRollback", EmitDefaultValue=false)]
        public bool? CanRollback { get; set; }

        /// <summary>
        /// The accounting value of the asset
        /// </summary>
        /// <value>The accounting value of the asset</value>
        [DataMember(Name="accountingBookValue", EmitDefaultValue=false)]
        public decimal? AccountingBookValue { get; set; }

        /// <summary>
        /// Boolean to indicate whether delete is enabled
        /// </summary>
        /// <value>Boolean to indicate whether delete is enabled</value>
        [DataMember(Name="isDeleteEnabledForDate", EmitDefaultValue=false)]
        public bool? IsDeleteEnabledForDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Asset {\n");
            sb.Append("  AssetId: ").Append(AssetId).Append("\n");
            sb.Append("  AssetName: ").Append(AssetName).Append("\n");
            sb.Append("  AssetTypeId: ").Append(AssetTypeId).Append("\n");
            sb.Append("  AssetNumber: ").Append(AssetNumber).Append("\n");
            sb.Append("  PurchaseDate: ").Append(PurchaseDate).Append("\n");
            sb.Append("  PurchasePrice: ").Append(PurchasePrice).Append("\n");
            sb.Append("  DisposalDate: ").Append(DisposalDate).Append("\n");
            sb.Append("  DisposalPrice: ").Append(DisposalPrice).Append("\n");
            sb.Append("  AssetStatus: ").Append(AssetStatus).Append("\n");
            sb.Append("  WarrantyExpiryDate: ").Append(WarrantyExpiryDate).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  BookDepreciationSetting: ").Append(BookDepreciationSetting).Append("\n");
            sb.Append("  BookDepreciationDetail: ").Append(BookDepreciationDetail).Append("\n");
            sb.Append("  CanRollback: ").Append(CanRollback).Append("\n");
            sb.Append("  AccountingBookValue: ").Append(AccountingBookValue).Append("\n");
            sb.Append("  IsDeleteEnabledForDate: ").Append(IsDeleteEnabledForDate).Append("\n");
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
            return this.Equals(input as Asset);
        }

        /// <summary>
        /// Returns true if Asset instances are equal
        /// </summary>
        /// <param name="input">Instance of Asset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Asset input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssetId == input.AssetId ||
                    (this.AssetId != null &&
                    this.AssetId.Equals(input.AssetId))
                ) && 
                (
                    this.AssetName == input.AssetName ||
                    (this.AssetName != null &&
                    this.AssetName.Equals(input.AssetName))
                ) && 
                (
                    this.AssetTypeId == input.AssetTypeId ||
                    (this.AssetTypeId != null &&
                    this.AssetTypeId.Equals(input.AssetTypeId))
                ) && 
                (
                    this.AssetNumber == input.AssetNumber ||
                    (this.AssetNumber != null &&
                    this.AssetNumber.Equals(input.AssetNumber))
                ) && 
                (
                    this.PurchaseDate == input.PurchaseDate ||
                    (this.PurchaseDate != null &&
                    this.PurchaseDate.Equals(input.PurchaseDate))
                ) && 
                (
                    this.PurchasePrice == input.PurchasePrice ||
                    this.PurchasePrice.Equals(input.PurchasePrice)
                ) && 
                (
                    this.DisposalDate == input.DisposalDate ||
                    (this.DisposalDate != null &&
                    this.DisposalDate.Equals(input.DisposalDate))
                ) && 
                (
                    this.DisposalPrice == input.DisposalPrice ||
                    this.DisposalPrice.Equals(input.DisposalPrice)
                ) && 
                (
                    this.AssetStatus == input.AssetStatus ||
                    this.AssetStatus.Equals(input.AssetStatus)
                ) && 
                (
                    this.WarrantyExpiryDate == input.WarrantyExpiryDate ||
                    (this.WarrantyExpiryDate != null &&
                    this.WarrantyExpiryDate.Equals(input.WarrantyExpiryDate))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.BookDepreciationSetting == input.BookDepreciationSetting ||
                    (this.BookDepreciationSetting != null &&
                    this.BookDepreciationSetting.Equals(input.BookDepreciationSetting))
                ) && 
                (
                    this.BookDepreciationDetail == input.BookDepreciationDetail ||
                    (this.BookDepreciationDetail != null &&
                    this.BookDepreciationDetail.Equals(input.BookDepreciationDetail))
                ) && 
                (
                    this.CanRollback == input.CanRollback ||
                    this.CanRollback.Equals(input.CanRollback)
                ) && 
                (
                    this.AccountingBookValue == input.AccountingBookValue ||
                    this.AccountingBookValue.Equals(input.AccountingBookValue)
                ) && 
                (
                    this.IsDeleteEnabledForDate == input.IsDeleteEnabledForDate ||
                    this.IsDeleteEnabledForDate.Equals(input.IsDeleteEnabledForDate)
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
                if (this.AssetId != null)
                    hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.AssetName != null)
                    hashCode = hashCode * 59 + this.AssetName.GetHashCode();
                if (this.AssetTypeId != null)
                    hashCode = hashCode * 59 + this.AssetTypeId.GetHashCode();
                if (this.AssetNumber != null)
                    hashCode = hashCode * 59 + this.AssetNumber.GetHashCode();
                if (this.PurchaseDate != null)
                    hashCode = hashCode * 59 + this.PurchaseDate.GetHashCode();
                hashCode = hashCode * 59 + this.PurchasePrice.GetHashCode();
                if (this.DisposalDate != null)
                    hashCode = hashCode * 59 + this.DisposalDate.GetHashCode();
                hashCode = hashCode * 59 + this.DisposalPrice.GetHashCode();
                hashCode = hashCode * 59 + this.AssetStatus.GetHashCode();
                if (this.WarrantyExpiryDate != null)
                    hashCode = hashCode * 59 + this.WarrantyExpiryDate.GetHashCode();
                if (this.SerialNumber != null)
                    hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.BookDepreciationSetting != null)
                    hashCode = hashCode * 59 + this.BookDepreciationSetting.GetHashCode();
                if (this.BookDepreciationDetail != null)
                    hashCode = hashCode * 59 + this.BookDepreciationDetail.GetHashCode();
                hashCode = hashCode * 59 + this.CanRollback.GetHashCode();
                hashCode = hashCode * 59 + this.AccountingBookValue.GetHashCode();
                hashCode = hashCode * 59 + this.IsDeleteEnabledForDate.GetHashCode();
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
