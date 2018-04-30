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
    /// > <para>**DB properties for table SamplingPlans** : [SamplingPlanID](CSSPModels.SamplingPlan.html#CSSPModels_SamplingPlan_SamplingPlanID), [IsActive](CSSPModels.SamplingPlan.html#CSSPModels_SamplingPlan_IsActive), [SamplingPlanName](CSSPModels.SamplingPlan.html#CSSPModels_SamplingPlan_SamplingPlanName), [ForGroupName](CSSPModels.SamplingPlan.html#CSSPModels_SamplingPlan_ForGroupName), [SampleType](CSSPModels.SamplingPlan.html#CSSPModels_SamplingPlan_SampleType), [SamplingPlanType](CSSPModels.SamplingPlan.html#CSSPModels_SamplingPlan_SamplingPlanType), [LabSheetType](CSSPModels.SamplingPlan.html#CSSPModels_SamplingPlan_LabSheetType), [ProvinceTVItemID](CSSPModels.SamplingPlan.html#CSSPModels_SamplingPlan_ProvinceTVItemID), [CreatorTVItemID](CSSPModels.SamplingPlan.html#CSSPModels_SamplingPlan_CreatorTVItemID), [Year](CSSPModels.SamplingPlan.html#CSSPModels_SamplingPlan_Year), [AccessCode](CSSPModels.SamplingPlan.html#CSSPModels_SamplingPlan_AccessCode), [DailyDuplicatePrecisionCriteria](CSSPModels.SamplingPlan.html#CSSPModels_SamplingPlan_DailyDuplicatePrecisionCriteria), [IntertechDuplicatePrecisionCriteria](CSSPModels.SamplingPlan.html#CSSPModels_SamplingPlan_IntertechDuplicatePrecisionCriteria), [IncludeLaboratoryQAQC](CSSPModels.SamplingPlan.html#CSSPModels_SamplingPlan_IncludeLaboratoryQAQC), [ApprovalCode](CSSPModels.SamplingPlan.html#CSSPModels_SamplingPlan_ApprovalCode), [SamplingPlanFileTVItemID](CSSPModels.SamplingPlan.html#CSSPModels_SamplingPlan_SamplingPlanFileTVItemID), [AnalyzeMethodDefault](CSSPModels.SamplingPlan.html#CSSPModels_SamplingPlan_AnalyzeMethodDefault), [SampleMatrixDefault](CSSPModels.SamplingPlan.html#CSSPModels_SamplingPlan_SampleMatrixDefault), [LaboratoryDefault](CSSPModels.SamplingPlan.html#CSSPModels_SamplingPlan_LaboratoryDefault), [BackupDirectory](CSSPModels.SamplingPlan.html#CSSPModels_SamplingPlan_BackupDirectory), [LastUpdateDate_UTC](CSSPModels.SamplingPlan.html#CSSPModels_SamplingPlan_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.SamplingPlan.html#CSSPModels_SamplingPlan_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [SamplingPlanWeb](CSSPModels.SamplingPlan.html#CSSPModels_SamplingPlan_SamplingPlanWeb), [SamplingPlanReport](CSSPModels.SamplingPlan.html#CSSPModels_SamplingPlan_SamplingPlanReport), [HasErrors](CSSPModels.SamplingPlan.html#CSSPModels_SamplingPlan_HasErrors), [ValidationResults](CSSPModels.SamplingPlan.html#CSSPModels_SamplingPlan_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [SamplingPlanService](CSSPServices.SamplingPlanService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [SampleTypeEnum](CSSPEnums.SampleTypeEnum.html), [SamplingPlanTypeEnum](CSSPEnums.SamplingPlanTypeEnum.html), [LabSheetTypeEnum](CSSPEnums.LabSheetTypeEnum.html), [AnalyzeMethodEnum](CSSPEnums.AnalyzeMethodEnum.html), [SampleMatrixEnum](CSSPEnums.SampleMatrixEnum.html), [LaboratoryEnum](CSSPEnums.LaboratoryEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class SamplingPlan : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int SamplingPlanID { get; set; }
        public bool IsActive { get; set; }
        [StringLength(200)]
        public string SamplingPlanName { get; set; }
        [StringLength(100)]
        public string ForGroupName { get; set; }
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
        public SamplingPlanTypeEnum SamplingPlanType { get; set; }
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
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>18 == Province</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "18")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "18")]
        public int ProvinceTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>5 == Contact</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int CreatorTVItemID { get; set; }
        [Range(2000, 2050)]
        public int Year { get; set; }
        [StringLength(15)]
        public string AccessCode { get; set; }
        [Range(0.0D, 100.0D)]
        public double DailyDuplicatePrecisionCriteria { get; set; }
        [Range(0.0D, 100.0D)]
        public double IntertechDuplicatePrecisionCriteria { get; set; }
        public bool IncludeLaboratoryQAQC { get; set; }
        [StringLength(15)]
        public string ApprovalCode { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>8 == File</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "8")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "8")]
        public int? SamplingPlanFileTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        [CSSPAllowNull]
        public AnalyzeMethodEnum? AnalyzeMethodDefault { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        [CSSPAllowNull]
        public SampleMatrixEnum? SampleMatrixDefault { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        [CSSPAllowNull]
        public LaboratoryEnum? LaboratoryDefault { get; set; }
        [StringLength(250)]
        public string BackupDirectory { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public SamplingPlanWeb SamplingPlanWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public SamplingPlanReport SamplingPlanReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public SamplingPlan() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SamplingPlanWeb
    {
        #region Properties for web information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ProvinceTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ProvinceTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string ProvinceTVText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "CreatorTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "CreatorTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string CreatorTVText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SamplingPlanFileTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SamplingPlanFileTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string SamplingPlanFileTVText { get; set; }
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
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "SampleTypeEnum", EnumType = "SampleType")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "SampleTypeEnum", EnumType = "SampleType")]
        [CSSPAllowNull]
        public string SampleTypeText { get; set; }
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
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "LabSheetTypeEnum", EnumType = "LabSheetType")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "LabSheetTypeEnum", EnumType = "LabSheetType")]
        [CSSPAllowNull]
        public string LabSheetTypeText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public SamplingPlanWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SamplingPlanReport
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string SamplingPlanReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public SamplingPlanReport()
        {
        }
        #endregion Constructors
    }
}
