/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 August 01 05:00
 * by leblancc on WMON01DTCHLEBL2 machine
 *
 */ 
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**DB properties for table ClimateDataValues** : [ClimateDataValueID](CSSPModels.ClimateDataValue.html#CSSPModels_ClimateDataValue_ClimateDataValueID), [ClimateSiteID](CSSPModels.ClimateDataValue.html#CSSPModels_ClimateDataValue_ClimateSiteID), [DateTime_Local](CSSPModels.ClimateDataValue.html#CSSPModels_ClimateDataValue_DateTime_Local), [Keep](CSSPModels.ClimateDataValue.html#CSSPModels_ClimateDataValue_Keep), [StorageDataType](CSSPModels.ClimateDataValue.html#CSSPModels_ClimateDataValue_StorageDataType), [HasBeenRead](CSSPModels.ClimateDataValue.html#CSSPModels_ClimateDataValue_HasBeenRead), [Snow_cm](CSSPModels.ClimateDataValue.html#CSSPModels_ClimateDataValue_Snow_cm), [Rainfall_mm](CSSPModels.ClimateDataValue.html#CSSPModels_ClimateDataValue_Rainfall_mm), [RainfallEntered_mm](CSSPModels.ClimateDataValue.html#CSSPModels_ClimateDataValue_RainfallEntered_mm), [TotalPrecip_mm_cm](CSSPModels.ClimateDataValue.html#CSSPModels_ClimateDataValue_TotalPrecip_mm_cm), [MaxTemp_C](CSSPModels.ClimateDataValue.html#CSSPModels_ClimateDataValue_MaxTemp_C), [MinTemp_C](CSSPModels.ClimateDataValue.html#CSSPModels_ClimateDataValue_MinTemp_C), [HeatDegDays_C](CSSPModels.ClimateDataValue.html#CSSPModels_ClimateDataValue_HeatDegDays_C), [CoolDegDays_C](CSSPModels.ClimateDataValue.html#CSSPModels_ClimateDataValue_CoolDegDays_C), [SnowOnGround_cm](CSSPModels.ClimateDataValue.html#CSSPModels_ClimateDataValue_SnowOnGround_cm), [DirMaxGust_0North](CSSPModels.ClimateDataValue.html#CSSPModels_ClimateDataValue_DirMaxGust_0North), [SpdMaxGust_kmh](CSSPModels.ClimateDataValue.html#CSSPModels_ClimateDataValue_SpdMaxGust_kmh), [HourlyValues](CSSPModels.ClimateDataValue.html#CSSPModels_ClimateDataValue_HourlyValues), [LastUpdateDate_UTC](CSSPModels.ClimateDataValue.html#CSSPModels_ClimateDataValue_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.ClimateDataValue.html#CSSPModels_ClimateDataValue_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [ClimateDataValueWeb](CSSPModels.ClimateDataValue.html#CSSPModels_ClimateDataValue_ClimateDataValueWeb), [ClimateDataValueReport](CSSPModels.ClimateDataValue.html#CSSPModels_ClimateDataValue_ClimateDataValueReport), [HasErrors](CSSPModels.ClimateDataValue.html#CSSPModels_ClimateDataValue_HasErrors), [ValidationResults](CSSPModels.ClimateDataValue.html#CSSPModels_ClimateDataValue_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [ClimateDataValueService](CSSPServices.ClimateDataValueService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [StorageDataTypeEnum](CSSPEnums.StorageDataTypeEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class ClimateDataValue : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "ClimateDataValue ID")]
        [CSSPDisplayFR(DisplayFR = "ClimateDataValue ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the ClimateDataValues table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau ClimateDataValues")]
        public int ClimateDataValueID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "ClimateSite", ExistPlurial = "s", ExistFieldID = "ClimateSiteID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "ClimateSite", ExistPlurial = "s", ExistFieldID = "ClimateSiteID")]
        public int ClimateSiteID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime DateTime_Local { get; set; }
        public bool Keep { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public StorageDataTypeEnum StorageDataType { get; set; }
        public bool HasBeenRead { get; set; }
        [Range(0.0D, 10000.0D)]
        public double? Snow_cm { get; set; }
        [Range(0.0D, 10000.0D)]
        public double? Rainfall_mm { get; set; }
        [Range(0.0D, 10000.0D)]
        public double? RainfallEntered_mm { get; set; }
        [Range(0.0D, 10000.0D)]
        public double? TotalPrecip_mm_cm { get; set; }
        [Range(-50.0D, 50.0D)]
        public double? MaxTemp_C { get; set; }
        [Range(-50.0D, 50.0D)]
        public double? MinTemp_C { get; set; }
        [Range(-1000.0D, 100.0D)]
        public double? HeatDegDays_C { get; set; }
        [Range(-1000.0D, 100.0D)]
        public double? CoolDegDays_C { get; set; }
        [Range(0.0D, 10000.0D)]
        public double? SnowOnGround_cm { get; set; }
        [Range(0.0D, 360.0D)]
        public double? DirMaxGust_0North { get; set; }
        [Range(0.0D, 300.0D)]
        public double? SpdMaxGust_kmh { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string HourlyValues { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public ClimateDataValueWeb ClimateDataValueWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public ClimateDataValueReport ClimateDataValueReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ClimateDataValue() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ClimateDataValueWeb
    {
        #region Properties for web information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "StorageDataTypeEnum", EnumType = "StorageDataType")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "StorageDataTypeEnum", EnumType = "StorageDataType")]
        [CSSPAllowNull]
        public string StorageDataTypeEnumText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public ClimateDataValueWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ClimateDataValueReport
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string ClimateDataValueReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public ClimateDataValueReport()
        {
        }
        #endregion Constructors
    }
}
