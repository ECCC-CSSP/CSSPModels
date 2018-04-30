/*
 * Auto generated from the CSSPModelsGenerateCode.proj by clicking on the [Generate Models With Help] button
 *
 * Do not edit this file.
 *
 * Last generated by Charles LeBlanc
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
    /// > <para>**DB properties for table LabSheets** : [LabSheetID](CSSPModels.LabSheet.html#CSSPModels_LabSheet_LabSheetID), [OtherServerLabSheetID](CSSPModels.LabSheet.html#CSSPModels_LabSheet_OtherServerLabSheetID), [SamplingPlanID](CSSPModels.LabSheet.html#CSSPModels_LabSheet_SamplingPlanID), [SamplingPlanName](CSSPModels.LabSheet.html#CSSPModels_LabSheet_SamplingPlanName), [Year](CSSPModels.LabSheet.html#CSSPModels_LabSheet_Year), [Month](CSSPModels.LabSheet.html#CSSPModels_LabSheet_Month), [Day](CSSPModels.LabSheet.html#CSSPModels_LabSheet_Day), [RunNumber](CSSPModels.LabSheet.html#CSSPModels_LabSheet_RunNumber), [SubsectorTVItemID](CSSPModels.LabSheet.html#CSSPModels_LabSheet_SubsectorTVItemID), [MWQMRunTVItemID](CSSPModels.LabSheet.html#CSSPModels_LabSheet_MWQMRunTVItemID), [SamplingPlanType](CSSPModels.LabSheet.html#CSSPModels_LabSheet_SamplingPlanType), [SampleType](CSSPModels.LabSheet.html#CSSPModels_LabSheet_SampleType), [LabSheetType](CSSPModels.LabSheet.html#CSSPModels_LabSheet_LabSheetType), [LabSheetStatus](CSSPModels.LabSheet.html#CSSPModels_LabSheet_LabSheetStatus), [FileName](CSSPModels.LabSheet.html#CSSPModels_LabSheet_FileName), [FileLastModifiedDate_Local](CSSPModels.LabSheet.html#CSSPModels_LabSheet_FileLastModifiedDate_Local), [FileContent](CSSPModels.LabSheet.html#CSSPModels_LabSheet_FileContent), [AcceptedOrRejectedByContactTVItemID](CSSPModels.LabSheet.html#CSSPModels_LabSheet_AcceptedOrRejectedByContactTVItemID), [AcceptedOrRejectedDateTime](CSSPModels.LabSheet.html#CSSPModels_LabSheet_AcceptedOrRejectedDateTime), [RejectReason](CSSPModels.LabSheet.html#CSSPModels_LabSheet_RejectReason), [LastUpdateDate_UTC](CSSPModels.LabSheet.html#CSSPModels_LabSheet_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.LabSheet.html#CSSPModels_LabSheet_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [LabSheetWeb](CSSPModels.LabSheet.html#CSSPModels_LabSheet_LabSheetWeb), [LabSheetReport](CSSPModels.LabSheet.html#CSSPModels_LabSheet_LabSheetReport), [HasErrors](CSSPModels.LabSheet.html#CSSPModels_LabSheet_HasErrors), [ValidationResults](CSSPModels.LabSheet.html#CSSPModels_LabSheet_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [LabSheetService](CSSPServices.LabSheetService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [SamplingPlanTypeEnum](CSSPEnums.SamplingPlanTypeEnum.html), [SampleTypeEnum](CSSPEnums.SampleTypeEnum.html), [LabSheetTypeEnum](CSSPEnums.LabSheetTypeEnum.html), [LabSheetStatusEnum](CSSPEnums.LabSheetStatusEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class LabSheet : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int LabSheetID { get; set; }
        [Range(1, -1)]
        public int OtherServerLabSheetID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "SamplingPlan", ExistPlurial = "s", ExistFieldID = "SamplingPlanID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "SamplingPlan", ExistPlurial = "s", ExistFieldID = "SamplingPlanID")]
        public int SamplingPlanID { get; set; }
        [StringLength(250, MinimumLength = 1)]
        public string SamplingPlanName { get; set; }
        [Range(1980, -1)]
        public int Year { get; set; }
        [Range(1, 12)]
        public int Month { get; set; }
        [Range(1, 31)]
        public int Day { get; set; }
        [Range(1, 100)]
        public int RunNumber { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>20 == Subsector</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]
        public int SubsectorTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>31 == MWQMRun</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "31")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "31")]
        public int? MWQMRunTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public SamplingPlanTypeEnum SamplingPlanType { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public SampleTypeEnum SampleType { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public LabSheetTypeEnum LabSheetType { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public LabSheetStatusEnum LabSheetStatus { get; set; }
        [StringLength(250, MinimumLength = 1)]
        public string FileName { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime FileLastModifiedDate_Local { get; set; }
        public string FileContent { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>5 == Contact</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int? AcceptedOrRejectedByContactTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime? AcceptedOrRejectedDateTime { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(250)]
        [CSSPAllowNull]
        public string RejectReason { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public LabSheetWeb LabSheetWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public LabSheetReport LabSheetReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public LabSheet() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class LabSheetWeb
    {
        #region Properties for web information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SubsectorTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SubsectorTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string SubsectorTVText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMRunTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMRunTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string MWQMRunTVText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "AcceptedOrRejectedByContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "AcceptedOrRejectedByContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string AcceptedOrRejectedByContactTVText { get; set; }
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
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "SamplingPlanTypeEnum", EnumType = "SamplingPlanType")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "SamplingPlanTypeEnum", EnumType = "SamplingPlanType")]
        [CSSPAllowNull]
        public string SamplingPlanTypeText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "SampleTypeEnum", EnumType = "SampleType")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "SampleTypeEnum", EnumType = "SampleType")]
        [CSSPAllowNull]
        public string SampleTypeText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "LabSheetTypeEnum", EnumType = "LabSheetType")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "LabSheetTypeEnum", EnumType = "LabSheetType")]
        [CSSPAllowNull]
        public string LabSheetTypeText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "LabSheetStatusEnum", EnumType = "LabSheetStatus")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "LabSheetStatusEnum", EnumType = "LabSheetStatus")]
        [CSSPAllowNull]
        public string LabSheetStatusText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public LabSheetWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class LabSheetReport
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string LabSheetReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public LabSheetReport()
        {
        }
        #endregion Constructors
    }
}
