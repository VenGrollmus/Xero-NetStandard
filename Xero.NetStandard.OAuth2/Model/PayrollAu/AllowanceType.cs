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
    /// Defines AllowanceType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AllowanceType
    {
        /// <summary>
        /// Enum CAR for value: CAR
        /// </summary>
        [EnumMember(Value = "CAR")]
        CAR = 1,

        /// <summary>
        /// Enum TRANSPORT for value: TRANSPORT
        /// </summary>
        [EnumMember(Value = "TRANSPORT")]
        TRANSPORT = 2,

        /// <summary>
        /// Enum TRAVEL for value: TRAVEL
        /// </summary>
        [EnumMember(Value = "TRAVEL")]
        TRAVEL = 3,

        /// <summary>
        /// Enum LAUNDRY for value: LAUNDRY
        /// </summary>
        [EnumMember(Value = "LAUNDRY")]
        LAUNDRY = 4,

        /// <summary>
        /// Enum MEALS for value: MEALS
        /// </summary>
        [EnumMember(Value = "MEALS")]
        MEALS = 5,

        /// <summary>
        /// Enum JOBKEEPER for value: JOBKEEPER
        /// </summary>
        [EnumMember(Value = "JOBKEEPER")]
        JOBKEEPER = 6,

        /// <summary>
        /// Enum OTHER for value: OTHER
        /// </summary>
        [EnumMember(Value = "OTHER")]
        OTHER = 7

    }

}
