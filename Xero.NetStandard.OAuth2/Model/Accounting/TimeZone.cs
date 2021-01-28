/* 
 * Accounting API
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

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// Timezone specifications
    /// </summary>
    /// <value>Timezone specifications</value>
    
    [JsonConverter(typeof(Client.CustomStringEnumConverter))]
    
    public enum TimeZone
    {
        /// <summary>
        /// Enum MOROCCOSTANDARDTIME for value: MOROCCOSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "MOROCCOSTANDARDTIME")]
        MOROCCOSTANDARDTIME = 1,

        /// <summary>
        /// Enum UTC for value: UTC
        /// </summary>
        [EnumMember(Value = "UTC")]
        UTC = 2,

        /// <summary>
        /// Enum GMTSTANDARDTIME for value: GMTSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "GMTSTANDARDTIME")]
        GMTSTANDARDTIME = 3,

        /// <summary>
        /// Enum GREENWICHSTANDARDTIME for value: GREENWICHSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "GREENWICHSTANDARDTIME")]
        GREENWICHSTANDARDTIME = 4,

        /// <summary>
        /// Enum WEUROPESTANDARDTIME for value: WEUROPESTANDARDTIME
        /// </summary>
        [EnumMember(Value = "WEUROPESTANDARDTIME")]
        WEUROPESTANDARDTIME = 5,

        /// <summary>
        /// Enum CENTRALEUROPESTANDARDTIME for value: CENTRALEUROPESTANDARDTIME
        /// </summary>
        [EnumMember(Value = "CENTRALEUROPESTANDARDTIME")]
        CENTRALEUROPESTANDARDTIME = 6,

        /// <summary>
        /// Enum ROMANCESTANDARDTIME for value: ROMANCESTANDARDTIME
        /// </summary>
        [EnumMember(Value = "ROMANCESTANDARDTIME")]
        ROMANCESTANDARDTIME = 7,

        /// <summary>
        /// Enum CENTRALEUROPEANSTANDARDTIME for value: CENTRALEUROPEANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "CENTRALEUROPEANSTANDARDTIME")]
        CENTRALEUROPEANSTANDARDTIME = 8,

        /// <summary>
        /// Enum WCENTRALAFRICASTANDARDTIME for value: WCENTRALAFRICASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "WCENTRALAFRICASTANDARDTIME")]
        WCENTRALAFRICASTANDARDTIME = 9,

        /// <summary>
        /// Enum NAMIBIASTANDARDTIME for value: NAMIBIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "NAMIBIASTANDARDTIME")]
        NAMIBIASTANDARDTIME = 10,

        /// <summary>
        /// Enum JORDANSTANDARDTIME for value: JORDANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "JORDANSTANDARDTIME")]
        JORDANSTANDARDTIME = 11,

        /// <summary>
        /// Enum GTBSTANDARDTIME for value: GTBSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "GTBSTANDARDTIME")]
        GTBSTANDARDTIME = 12,

        /// <summary>
        /// Enum MIDDLEEASTSTANDARDTIME for value: MIDDLEEASTSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "MIDDLEEASTSTANDARDTIME")]
        MIDDLEEASTSTANDARDTIME = 13,

        /// <summary>
        /// Enum EGYPTSTANDARDTIME for value: EGYPTSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "EGYPTSTANDARDTIME")]
        EGYPTSTANDARDTIME = 14,

        /// <summary>
        /// Enum SYRIASTANDARDTIME for value: SYRIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "SYRIASTANDARDTIME")]
        SYRIASTANDARDTIME = 15,

        /// <summary>
        /// Enum EEUROPESTANDARDTIME for value: EEUROPESTANDARDTIME
        /// </summary>
        [EnumMember(Value = "EEUROPESTANDARDTIME")]
        EEUROPESTANDARDTIME = 16,

        /// <summary>
        /// Enum SOUTHAFRICASTANDARDTIME for value: SOUTHAFRICASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "SOUTHAFRICASTANDARDTIME")]
        SOUTHAFRICASTANDARDTIME = 17,

        /// <summary>
        /// Enum FLESTANDARDTIME for value: FLESTANDARDTIME
        /// </summary>
        [EnumMember(Value = "FLESTANDARDTIME")]
        FLESTANDARDTIME = 18,

        /// <summary>
        /// Enum TURKEYSTANDARDTIME for value: TURKEYSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "TURKEYSTANDARDTIME")]
        TURKEYSTANDARDTIME = 19,

        /// <summary>
        /// Enum ISRAELSTANDARDTIME for value: ISRAELSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "ISRAELSTANDARDTIME")]
        ISRAELSTANDARDTIME = 20,

        /// <summary>
        /// Enum KALININGRADSTANDARDTIME for value: KALININGRADSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "KALININGRADSTANDARDTIME")]
        KALININGRADSTANDARDTIME = 21,

        /// <summary>
        /// Enum LIBYASTANDARDTIME for value: LIBYASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "LIBYASTANDARDTIME")]
        LIBYASTANDARDTIME = 22,

        /// <summary>
        /// Enum ARABICSTANDARDTIME for value: ARABICSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "ARABICSTANDARDTIME")]
        ARABICSTANDARDTIME = 23,

        /// <summary>
        /// Enum ARABSTANDARDTIME for value: ARABSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "ARABSTANDARDTIME")]
        ARABSTANDARDTIME = 24,

        /// <summary>
        /// Enum BELARUSSTANDARDTIME for value: BELARUSSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "BELARUSSTANDARDTIME")]
        BELARUSSTANDARDTIME = 25,

        /// <summary>
        /// Enum RUSSIANSTANDARDTIME for value: RUSSIANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "RUSSIANSTANDARDTIME")]
        RUSSIANSTANDARDTIME = 26,

        /// <summary>
        /// Enum EAFRICASTANDARDTIME for value: EAFRICASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "EAFRICASTANDARDTIME")]
        EAFRICASTANDARDTIME = 27,

        /// <summary>
        /// Enum IRANSTANDARDTIME for value: IRANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "IRANSTANDARDTIME")]
        IRANSTANDARDTIME = 28,

        /// <summary>
        /// Enum ARABIANSTANDARDTIME for value: ARABIANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "ARABIANSTANDARDTIME")]
        ARABIANSTANDARDTIME = 29,

        /// <summary>
        /// Enum AZERBAIJANSTANDARDTIME for value: AZERBAIJANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "AZERBAIJANSTANDARDTIME")]
        AZERBAIJANSTANDARDTIME = 30,

        /// <summary>
        /// Enum RUSSIATIMEZONE3 for value: RUSSIATIMEZONE3
        /// </summary>
        [EnumMember(Value = "RUSSIATIMEZONE3")]
        RUSSIATIMEZONE3 = 31,

        /// <summary>
        /// Enum MAURITIUSSTANDARDTIME for value: MAURITIUSSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "MAURITIUSSTANDARDTIME")]
        MAURITIUSSTANDARDTIME = 32,

        /// <summary>
        /// Enum GEORGIANSTANDARDTIME for value: GEORGIANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "GEORGIANSTANDARDTIME")]
        GEORGIANSTANDARDTIME = 33,

        /// <summary>
        /// Enum CAUCASUSSTANDARDTIME for value: CAUCASUSSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "CAUCASUSSTANDARDTIME")]
        CAUCASUSSTANDARDTIME = 34,

        /// <summary>
        /// Enum AFGHANISTANSTANDARDTIME for value: AFGHANISTANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "AFGHANISTANSTANDARDTIME")]
        AFGHANISTANSTANDARDTIME = 35,

        /// <summary>
        /// Enum WESTASIASTANDARDTIME for value: WESTASIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "WESTASIASTANDARDTIME")]
        WESTASIASTANDARDTIME = 36,

        /// <summary>
        /// Enum EKATERINBURGSTANDARDTIME for value: EKATERINBURGSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "EKATERINBURGSTANDARDTIME")]
        EKATERINBURGSTANDARDTIME = 37,

        /// <summary>
        /// Enum PAKISTANSTANDARDTIME for value: PAKISTANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "PAKISTANSTANDARDTIME")]
        PAKISTANSTANDARDTIME = 38,

        /// <summary>
        /// Enum INDIASTANDARDTIME for value: INDIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "INDIASTANDARDTIME")]
        INDIASTANDARDTIME = 39,

        /// <summary>
        /// Enum SRILANKASTANDARDTIME for value: SRILANKASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "SRILANKASTANDARDTIME")]
        SRILANKASTANDARDTIME = 40,

        /// <summary>
        /// Enum NEPALSTANDARDTIME for value: NEPALSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "NEPALSTANDARDTIME")]
        NEPALSTANDARDTIME = 41,

        /// <summary>
        /// Enum CENTRALASIASTANDARDTIME for value: CENTRALASIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "CENTRALASIASTANDARDTIME")]
        CENTRALASIASTANDARDTIME = 42,

        /// <summary>
        /// Enum BANGLADESHSTANDARDTIME for value: BANGLADESHSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "BANGLADESHSTANDARDTIME")]
        BANGLADESHSTANDARDTIME = 43,

        /// <summary>
        /// Enum NCENTRALASIASTANDARDTIME for value: NCENTRALASIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "NCENTRALASIASTANDARDTIME")]
        NCENTRALASIASTANDARDTIME = 44,

        /// <summary>
        /// Enum MYANMARSTANDARDTIME for value: MYANMARSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "MYANMARSTANDARDTIME")]
        MYANMARSTANDARDTIME = 45,

        /// <summary>
        /// Enum SEASIASTANDARDTIME for value: SEASIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "SEASIASTANDARDTIME")]
        SEASIASTANDARDTIME = 46,

        /// <summary>
        /// Enum NORTHASIASTANDARDTIME for value: NORTHASIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "NORTHASIASTANDARDTIME")]
        NORTHASIASTANDARDTIME = 47,

        /// <summary>
        /// Enum CHINASTANDARDTIME for value: CHINASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "CHINASTANDARDTIME")]
        CHINASTANDARDTIME = 48,

        /// <summary>
        /// Enum NORTHASIAEASTSTANDARDTIME for value: NORTHASIAEASTSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "NORTHASIAEASTSTANDARDTIME")]
        NORTHASIAEASTSTANDARDTIME = 49,

        /// <summary>
        /// Enum SINGAPORESTANDARDTIME for value: SINGAPORESTANDARDTIME
        /// </summary>
        [EnumMember(Value = "SINGAPORESTANDARDTIME")]
        SINGAPORESTANDARDTIME = 50,

        /// <summary>
        /// Enum WAUSTRALIASTANDARDTIME for value: WAUSTRALIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "WAUSTRALIASTANDARDTIME")]
        WAUSTRALIASTANDARDTIME = 51,

        /// <summary>
        /// Enum TAIPEISTANDARDTIME for value: TAIPEISTANDARDTIME
        /// </summary>
        [EnumMember(Value = "TAIPEISTANDARDTIME")]
        TAIPEISTANDARDTIME = 52,

        /// <summary>
        /// Enum ULAANBAATARSTANDARDTIME for value: ULAANBAATARSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "ULAANBAATARSTANDARDTIME")]
        ULAANBAATARSTANDARDTIME = 53,

        /// <summary>
        /// Enum TOKYOSTANDARDTIME for value: TOKYOSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "TOKYOSTANDARDTIME")]
        TOKYOSTANDARDTIME = 54,

        /// <summary>
        /// Enum KOREASTANDARDTIME for value: KOREASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "KOREASTANDARDTIME")]
        KOREASTANDARDTIME = 55,

        /// <summary>
        /// Enum YAKUTSKSTANDARDTIME for value: YAKUTSKSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "YAKUTSKSTANDARDTIME")]
        YAKUTSKSTANDARDTIME = 56,

        /// <summary>
        /// Enum CENAUSTRALIASTANDARDTIME for value: CENAUSTRALIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "CENAUSTRALIASTANDARDTIME")]
        CENAUSTRALIASTANDARDTIME = 57,

        /// <summary>
        /// Enum AUSCENTRALSTANDARDTIME for value: AUSCENTRALSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "AUSCENTRALSTANDARDTIME")]
        AUSCENTRALSTANDARDTIME = 58,

        /// <summary>
        /// Enum EAUSTRALIASTANDARDTIME for value: EAUSTRALIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "EAUSTRALIASTANDARDTIME")]
        EAUSTRALIASTANDARDTIME = 59,

        /// <summary>
        /// Enum AUSEASTERNSTANDARDTIME for value: AUSEASTERNSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "AUSEASTERNSTANDARDTIME")]
        AUSEASTERNSTANDARDTIME = 60,

        /// <summary>
        /// Enum WESTPACIFICSTANDARDTIME for value: WESTPACIFICSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "WESTPACIFICSTANDARDTIME")]
        WESTPACIFICSTANDARDTIME = 61,

        /// <summary>
        /// Enum TASMANIASTANDARDTIME for value: TASMANIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "TASMANIASTANDARDTIME")]
        TASMANIASTANDARDTIME = 62,

        /// <summary>
        /// Enum MAGADANSTANDARDTIME for value: MAGADANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "MAGADANSTANDARDTIME")]
        MAGADANSTANDARDTIME = 63,

        /// <summary>
        /// Enum VLADIVOSTOKSTANDARDTIME for value: VLADIVOSTOKSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "VLADIVOSTOKSTANDARDTIME")]
        VLADIVOSTOKSTANDARDTIME = 64,

        /// <summary>
        /// Enum RUSSIATIMEZONE10 for value: RUSSIATIMEZONE10
        /// </summary>
        [EnumMember(Value = "RUSSIATIMEZONE10")]
        RUSSIATIMEZONE10 = 65,

        /// <summary>
        /// Enum CENTRALPACIFICSTANDARDTIME for value: CENTRALPACIFICSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "CENTRALPACIFICSTANDARDTIME")]
        CENTRALPACIFICSTANDARDTIME = 66,

        /// <summary>
        /// Enum RUSSIATIMEZONE11 for value: RUSSIATIMEZONE11
        /// </summary>
        [EnumMember(Value = "RUSSIATIMEZONE11")]
        RUSSIATIMEZONE11 = 67,

        /// <summary>
        /// Enum NEWZEALANDSTANDARDTIME for value: NEWZEALANDSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "NEWZEALANDSTANDARDTIME")]
        NEWZEALANDSTANDARDTIME = 68,

        /// <summary>
        /// Enum UTC12 for value: UTC+12
        /// </summary>
        [EnumMember(Value = "UTC+12")]
        UTC12 = 69,

        /// <summary>
        /// Enum UTC13 for value: UTC+13
        /// </summary>
        [EnumMember(Value = "UTC+13")]
        UTC13 = 70,

        /// <summary>
        /// Enum FIJISTANDARDTIME for value: FIJISTANDARDTIME
        /// </summary>
        [EnumMember(Value = "FIJISTANDARDTIME")]
        FIJISTANDARDTIME = 71,

        /// <summary>
        /// Enum KAMCHATKASTANDARDTIME for value: KAMCHATKASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "KAMCHATKASTANDARDTIME")]
        KAMCHATKASTANDARDTIME = 72,

        /// <summary>
        /// Enum TONGASTANDARDTIME for value: TONGASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "TONGASTANDARDTIME")]
        TONGASTANDARDTIME = 73,

        /// <summary>
        /// Enum SAMOASTANDARDTIME for value: SAMOASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "SAMOASTANDARDTIME")]
        SAMOASTANDARDTIME = 74,

        /// <summary>
        /// Enum LINEISLANDSSTANDARDTIME for value: LINEISLANDSSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "LINEISLANDSSTANDARDTIME")]
        LINEISLANDSSTANDARDTIME = 75,

        /// <summary>
        /// Enum AZORESSTANDARDTIME for value: AZORESSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "AZORESSTANDARDTIME")]
        AZORESSTANDARDTIME = 76,

        /// <summary>
        /// Enum CAPEVERDESTANDARDTIME for value: CAPEVERDESTANDARDTIME
        /// </summary>
        [EnumMember(Value = "CAPEVERDESTANDARDTIME")]
        CAPEVERDESTANDARDTIME = 77,

        /// <summary>
        /// Enum UTC02 for value: UTC02
        /// </summary>
        [EnumMember(Value = "UTC02")]
        UTC02 = 78,

        /// <summary>
        /// Enum MIDATLANTICSTANDARDTIME for value: MIDATLANTICSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "MIDATLANTICSTANDARDTIME")]
        MIDATLANTICSTANDARDTIME = 79,

        /// <summary>
        /// Enum ESOUTHAMERICASTANDARDTIME for value: ESOUTHAMERICASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "ESOUTHAMERICASTANDARDTIME")]
        ESOUTHAMERICASTANDARDTIME = 80,

        /// <summary>
        /// Enum ARGENTINASTANDARDTIME for value: ARGENTINASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "ARGENTINASTANDARDTIME")]
        ARGENTINASTANDARDTIME = 81,

        /// <summary>
        /// Enum SAEASTERNSTANDARDTIME for value: SAEASTERNSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "SAEASTERNSTANDARDTIME")]
        SAEASTERNSTANDARDTIME = 82,

        /// <summary>
        /// Enum GREENLANDSTANDARDTIME for value: GREENLANDSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "GREENLANDSTANDARDTIME")]
        GREENLANDSTANDARDTIME = 83,

        /// <summary>
        /// Enum MONTEVIDEOSTANDARDTIME for value: MONTEVIDEOSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "MONTEVIDEOSTANDARDTIME")]
        MONTEVIDEOSTANDARDTIME = 84,

        /// <summary>
        /// Enum BAHIASTANDARDTIME for value: BAHIASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "BAHIASTANDARDTIME")]
        BAHIASTANDARDTIME = 85,

        /// <summary>
        /// Enum NEWFOUNDLANDSTANDARDTIME for value: NEWFOUNDLANDSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "NEWFOUNDLANDSTANDARDTIME")]
        NEWFOUNDLANDSTANDARDTIME = 86,

        /// <summary>
        /// Enum PARAGUAYSTANDARDTIME for value: PARAGUAYSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "PARAGUAYSTANDARDTIME")]
        PARAGUAYSTANDARDTIME = 87,

        /// <summary>
        /// Enum ATLANTICSTANDARDTIME for value: ATLANTICSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "ATLANTICSTANDARDTIME")]
        ATLANTICSTANDARDTIME = 88,

        /// <summary>
        /// Enum CENTRALBRAZILIANSTANDARDTIME for value: CENTRALBRAZILIANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "CENTRALBRAZILIANSTANDARDTIME")]
        CENTRALBRAZILIANSTANDARDTIME = 89,

        /// <summary>
        /// Enum SAWESTERNSTANDARDTIME for value: SAWESTERNSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "SAWESTERNSTANDARDTIME")]
        SAWESTERNSTANDARDTIME = 90,

        /// <summary>
        /// Enum PACIFICSASTANDARDTIME for value: PACIFICSASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "PACIFICSASTANDARDTIME")]
        PACIFICSASTANDARDTIME = 91,

        /// <summary>
        /// Enum VENEZUELASTANDARDTIME for value: VENEZUELASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "VENEZUELASTANDARDTIME")]
        VENEZUELASTANDARDTIME = 92,

        /// <summary>
        /// Enum SAPACIFICSTANDARDTIME for value: SAPACIFICSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "SAPACIFICSTANDARDTIME")]
        SAPACIFICSTANDARDTIME = 93,

        /// <summary>
        /// Enum EASTERNSTANDARDTIME for value: EASTERNSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "EASTERNSTANDARDTIME")]
        EASTERNSTANDARDTIME = 94,

        /// <summary>
        /// Enum USEASTERNSTANDARDTIME for value: USEASTERNSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "USEASTERNSTANDARDTIME")]
        USEASTERNSTANDARDTIME = 95,

        /// <summary>
        /// Enum CENTRALAMERICASTANDARDTIME for value: CENTRALAMERICASTANDARDTIME
        /// </summary>
        [EnumMember(Value = "CENTRALAMERICASTANDARDTIME")]
        CENTRALAMERICASTANDARDTIME = 96,

        /// <summary>
        /// Enum CENTRALSTANDARDTIME for value: CENTRALSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "CENTRALSTANDARDTIME")]
        CENTRALSTANDARDTIME = 97,

        /// <summary>
        /// Enum CENTRALSTANDARDTIMEMEXICO for value: CENTRALSTANDARDTIME(MEXICO)
        /// </summary>
        [EnumMember(Value = "CENTRALSTANDARDTIME(MEXICO)")]
        CENTRALSTANDARDTIMEMEXICO = 98,

        /// <summary>
        /// Enum CANADACENTRALSTANDARDTIME for value: CANADACENTRALSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "CANADACENTRALSTANDARDTIME")]
        CANADACENTRALSTANDARDTIME = 99,

        /// <summary>
        /// Enum USMOUNTAINSTANDARDTIME for value: USMOUNTAINSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "USMOUNTAINSTANDARDTIME")]
        USMOUNTAINSTANDARDTIME = 100,

        /// <summary>
        /// Enum MOUNTAINSTANDARDTIMEMEXICO for value: MOUNTAINSTANDARDTIME(MEXICO)
        /// </summary>
        [EnumMember(Value = "MOUNTAINSTANDARDTIME(MEXICO)")]
        MOUNTAINSTANDARDTIMEMEXICO = 101,

        /// <summary>
        /// Enum MOUNTAINSTANDARDTIME for value: MOUNTAINSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "MOUNTAINSTANDARDTIME")]
        MOUNTAINSTANDARDTIME = 102,

        /// <summary>
        /// Enum PACIFICSTANDARDTIMEMEXICO for value: PACIFICSTANDARDTIME(MEXICO)
        /// </summary>
        [EnumMember(Value = "PACIFICSTANDARDTIME(MEXICO)")]
        PACIFICSTANDARDTIMEMEXICO = 103,

        /// <summary>
        /// Enum PACIFICSTANDARDTIME for value: PACIFICSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "PACIFICSTANDARDTIME")]
        PACIFICSTANDARDTIME = 104,

        /// <summary>
        /// Enum ALASKANSTANDARDTIME for value: ALASKANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "ALASKANSTANDARDTIME")]
        ALASKANSTANDARDTIME = 105,

        /// <summary>
        /// Enum HAWAIIANSTANDARDTIME for value: HAWAIIANSTANDARDTIME
        /// </summary>
        [EnumMember(Value = "HAWAIIANSTANDARDTIME")]
        HAWAIIANSTANDARDTIME = 106,

        /// <summary>
        /// Enum UTC11 for value: UTC11
        /// </summary>
        [EnumMember(Value = "UTC11")]
        UTC11 = 107,

        /// <summary>
        /// Enum DATELINESTANDARDTIME for value: DATELINESTANDARDTIME
        /// </summary>
        [EnumMember(Value = "DATELINESTANDARDTIME")]
        DATELINESTANDARDTIME = 108

    }

}
