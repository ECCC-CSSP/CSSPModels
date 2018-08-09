﻿/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CSSPModels
{
    public partial class SamplingPlan : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "SamplingPlan ID")]
        [CSSPDisplayFR(DisplayFR = "SamplingPlan ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the SamplingPlans table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table SamplingPlans")]
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

        #region Constructors
        public SamplingPlan() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SamplingPlan_A : SamplingPlan
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ProvinceTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        public TVItemLanguage ProvinceTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "CreatorTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        public TVItemLanguage CreatorTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SamplingPlanFileTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        public TVItemLanguage SamplingPlanFileTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "SampleTypeEnum", EnumType = "SampleType")]
        [CSSPAllowNull]
        public string SampleTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "SamplingPlanTypeEnum", EnumType = "SamplingPlanType")]
        [CSSPAllowNull]
        public string SamplingPlanTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "LabSheetTypeEnum", EnumType = "LabSheetType")]
        [CSSPAllowNull]
        public string LabSheetTypeText { get; set; }
        #endregion Properties

        #region Constructors
        public SamplingPlan_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SamplingPlan_B : SamplingPlan_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string SamplingPlanReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public SamplingPlan_B() : base()
        {
        }
        #endregion Constructors
    }
}
