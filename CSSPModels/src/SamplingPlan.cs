/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class SamplingPlan : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "SamplingPlan ID")]
        [CSSPDisplayFR(DisplayFR = "SamplingPlan ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the SamplingPlans table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau SamplingPlans")]
        public int SamplingPlanID { get; set; }
        public bool IsActive { get; set; }
        [StringLength(200)]
        public string SamplingPlanName { get; set; }
        [StringLength(100)]
        public string ForGroupName { get; set; }
        [CSSPEnumType]
        public SampleTypeEnum SampleType { get; set; }
        [CSSPEnumType]
        public SamplingPlanTypeEnum SamplingPlanType { get; set; }
        [CSSPEnumType]
        public LabSheetTypeEnum LabSheetType { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "18")]
        public int ProvinceTVItemID { get; set; }
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
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "8")]
        public int? SamplingPlanFileTVItemID { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public AnalyzeMethodEnum? AnalyzeMethodDefault { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public SampleMatrixEnum? SampleMatrixDefault { get; set; }
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
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ProvinceTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string ProvinceTVText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "CreatorTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string CreatorTVText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SamplingPlanFileTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string SamplingPlanFileTVText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "SampleTypeEnum", EnumType = "SampleType")]
        [CSSPAllowNull]
        public string SampleTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "SamplingPlanTypeEnum", EnumType = "SamplingPlanType")]
        [CSSPAllowNull]
        public string SamplingPlanTypeText { get; set; }
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
