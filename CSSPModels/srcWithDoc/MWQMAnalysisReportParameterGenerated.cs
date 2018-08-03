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
    /// > <para>**DB properties for table MWQMAnalysisReportParameters** : [MWQMAnalysisReportParameterID](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_MWQMAnalysisReportParameterID), [SubsectorTVItemID](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_SubsectorTVItemID), [AnalysisName](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_AnalysisName), [AnalysisReportYear](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_AnalysisReportYear), [StartDate](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_StartDate), [EndDate](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_EndDate), [AnalysisCalculationType](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_AnalysisCalculationType), [NumberOfRuns](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_NumberOfRuns), [FullYear](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_FullYear), [SalinityHighlightDeviationFromAverage](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_SalinityHighlightDeviationFromAverage), [ShortRangeNumberOfDays](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_ShortRangeNumberOfDays), [MidRangeNumberOfDays](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_MidRangeNumberOfDays), [DryLimit24h](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_DryLimit24h), [DryLimit48h](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_DryLimit48h), [DryLimit72h](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_DryLimit72h), [DryLimit96h](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_DryLimit96h), [WetLimit24h](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_WetLimit24h), [WetLimit48h](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_WetLimit48h), [WetLimit72h](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_WetLimit72h), [WetLimit96h](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_WetLimit96h), [RunsToOmit](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_RunsToOmit), [ShowDataTypes](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_ShowDataTypes), [ExcelTVFileTVItemID](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_ExcelTVFileTVItemID), [Command](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_Command), [LastUpdateDate_UTC](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_HasErrors), [ValidationResults](CSSPModels.MWQMAnalysisReportParameter.html#CSSPModels_MWQMAnalysisReportParameter_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [MWQMAnalysisReportParameterService](CSSPServices.MWQMAnalysisReportParameterService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [AnalysisCalculationTypeEnum](CSSPEnums.AnalysisCalculationTypeEnum.html), [AnalysisReportExportCommandEnum](CSSPEnums.AnalysisReportExportCommandEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class MWQMAnalysisReportParameter : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MWQMAnalysisReportParameter ID")]
        [CSSPDisplayFR(DisplayFR = "MWQMAnalysisReportParameter ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MWQMAnalysisReportParameters table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau MWQMAnalysisReportParameters")]
        public int MWQMAnalysisReportParameterID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>20 == Subsector</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]
        public int SubsectorTVItemID { get; set; }
        [StringLength(250, MinimumLength = 5)]
        public string AnalysisName { get; set; }
        [Range(1980, 2050)]
        public int? AnalysisReportYear { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime StartDate { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// > <para>[[CSSPBigger](CSSPModels.CSSPBiggerAttribute.html)(OtherField = "StartDate")]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        [CSSPBigger(OtherField = "StartDate")]
        public DateTime EndDate { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public AnalysisCalculationTypeEnum AnalysisCalculationType { get; set; }
        [Range(1, 1000)]
        public int NumberOfRuns { get; set; }
        public bool FullYear { get; set; }
        [Range(1.0D, 20.0D)]
        public double SalinityHighlightDeviationFromAverage { get; set; }
        [Range(0, 5)]
        public int ShortRangeNumberOfDays { get; set; }
        [Range(2, 7)]
        public int MidRangeNumberOfDays { get; set; }
        [Range(1, 100)]
        public int DryLimit24h { get; set; }
        [Range(1, 100)]
        public int DryLimit48h { get; set; }
        [Range(1, 100)]
        public int DryLimit72h { get; set; }
        [Range(1, 100)]
        public int DryLimit96h { get; set; }
        [Range(1, 100)]
        public int WetLimit24h { get; set; }
        [Range(1, 100)]
        public int WetLimit48h { get; set; }
        [Range(1, 100)]
        public int WetLimit72h { get; set; }
        [Range(1, 100)]
        public int WetLimit96h { get; set; }
        [StringLength(250)]
        public string RunsToOmit { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(20)]
        [CSSPAllowNull]
        public string ShowDataTypes { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>8 == File</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "8")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "8")]
        public int? ExcelTVFileTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public AnalysisReportExportCommandEnum Command { get; set; }
        #endregion Properties in DB

        #region Constructors
        public MWQMAnalysisReportParameter() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMAnalysisReportParameterWeb : MWQMAnalysisReportParameter
    {
        #region Properties for web information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ExcelTVFileTVItemID", FillReturnField = "", FillNeedLanguage = true)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ExcelTVFileTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public TVItemLanguage ExcelTVFileTVItemLanguage { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "AnalysisReportExportCommandEnum", EnumType = "Command")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "AnalysisReportExportCommandEnum", EnumType = "Command")]
        [CSSPAllowNull]
        public string CommandText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties for web information

        #region Constructors
        public MWQMAnalysisReportParameterWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMAnalysisReportParameterReport : MWQMAnalysisReportParameterWeb
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string MWQMAnalysisReportParameterReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public MWQMAnalysisReportParameterReport() : base()
        {
        }
        #endregion Constructors
    }
}
