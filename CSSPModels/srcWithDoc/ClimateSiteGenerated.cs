/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by leblancc on WMON01DTCHLEBL2 machine
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
    /// > <para>**DB properties for table ClimateSites** : [ClimateSiteID](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_ClimateSiteID), [ClimateSiteTVItemID](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_ClimateSiteTVItemID), [ECDBID](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_ECDBID), [ClimateSiteName](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_ClimateSiteName), [Province](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_Province), [Elevation_m](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_Elevation_m), [ClimateID](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_ClimateID), [WMOID](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_WMOID), [TCID](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_TCID), [IsProvincial](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_IsProvincial), [ProvSiteID](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_ProvSiteID), [TimeOffset_hour](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_TimeOffset_hour), [File_desc](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_File_desc), [HourlyStartDate_Local](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_HourlyStartDate_Local), [HourlyEndDate_Local](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_HourlyEndDate_Local), [HourlyNow](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_HourlyNow), [DailyStartDate_Local](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_DailyStartDate_Local), [DailyEndDate_Local](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_DailyEndDate_Local), [DailyNow](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_DailyNow), [MonthlyStartDate_Local](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_MonthlyStartDate_Local), [MonthlyEndDate_Local](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_MonthlyEndDate_Local), [MonthlyNow](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_MonthlyNow), [LastUpdateDate_UTC](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_HasErrors), [ValidationResults](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [ClimateSiteService](CSSPServices.ClimateSiteService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class ClimateSite : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "ClimateSite ID")]
        [CSSPDisplayFR(DisplayFR = "ClimateSite ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the ClimateSites table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau ClimateSites")]
        public int ClimateSiteID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>4 == ClimateSite</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "4")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "4")]
        public int ClimateSiteTVItemID { get; set; }
        [Range(1, 100000)]
        public int ECDBID { get; set; }
        [StringLength(100)]
        public string ClimateSiteName { get; set; }
        [StringLength(4)]
        public string Province { get; set; }
        [Range(0.0D, 10000.0D)]
        public double? Elevation_m { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(10)]
        [CSSPAllowNull]
        public string ClimateID { get; set; }
        [Range(1, 100000)]
        public int? WMOID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(3)]
        [CSSPAllowNull]
        public string TCID { get; set; }
        public bool? IsProvincial { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(50)]
        [CSSPAllowNull]
        public string ProvSiteID { get; set; }
        [Range(-10.0D, 0.0D)]
        public double? TimeOffset_hour { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(50)]
        [CSSPAllowNull]
        public string File_desc { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime? HourlyStartDate_Local { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime? HourlyEndDate_Local { get; set; }
        public bool? HourlyNow { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime? DailyStartDate_Local { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime? DailyEndDate_Local { get; set; }
        public bool? DailyNow { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime? MonthlyStartDate_Local { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime? MonthlyEndDate_Local { get; set; }
        public bool? MonthlyNow { get; set; }
        #endregion Properties in DB

        #region Constructors
        public ClimateSite() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ClimateSiteWeb : ClimateSite
    {
        #region Properties for web information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ClimateSiteTVItemID", FillReturnField = "", FillNeedLanguage = true)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ClimateSiteTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage ClimateSiteTVItemLanguage { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties for web information

        #region Constructors
        public ClimateSiteWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ClimateSiteReport : ClimateSiteWeb
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string ClimateSiteReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public ClimateSiteReport() : base()
        {
        }
        #endregion Constructors
    }
}
