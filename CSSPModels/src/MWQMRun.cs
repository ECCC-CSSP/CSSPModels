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
    public partial class MWQMRun : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MWQMRun ID")]
        [CSSPDisplayFR(DisplayFR = "MWQMRun ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MWQMRuns table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table MWQMRuns")]
        public int MWQMRunID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]
        public int SubsectorTVItemID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "31")]
        public int MWQMRunTVItemID { get; set; }
        [CSSPEnumType]
        public SampleTypeEnum RunSampleType { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime DateTime_Local { get; set; }
        [Range(1, 1000)]
        public int RunNumber { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? StartDateTime_Local { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPBigger(OtherField = "StartDateTime_Local")]
        public DateTime? EndDateTime_Local { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? LabReceivedDateTime_Local { get; set; }
        [Range(-10.0D, 40.0D)]
        public double? TemperatureControl1_C { get; set; }
        [Range(-10.0D, 40.0D)]
        public double? TemperatureControl2_C { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public BeaufortScaleEnum? SeaStateAtStart_BeaufortScale { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public BeaufortScaleEnum? SeaStateAtEnd_BeaufortScale { get; set; }
        [Range(0.0D, 100.0D)]
        public double? WaterLevelAtBrook_m { get; set; }
        [Range(0.0D, 100.0D)]
        public double? WaveHightAtStart_m { get; set; }
        [Range(0.0D, 100.0D)]
        public double? WaveHightAtEnd_m { get; set; }
        [StringLength(20)]
        [CSSPAllowNull]
        public string SampleCrewInitials { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public AnalyzeMethodEnum? AnalyzeMethod { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public SampleMatrixEnum? SampleMatrix { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public LaboratoryEnum? Laboratory { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public SampleStatusEnum? SampleStatus { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int? LabSampleApprovalContactTVItemID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? LabAnalyzeBath1IncubationStartDateTime_Local { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? LabAnalyzeBath2IncubationStartDateTime_Local { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? LabAnalyzeBath3IncubationStartDateTime_Local { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? LabRunSampleApprovalDateTime_Local { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public TideTextEnum? Tide_Start { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public TideTextEnum? Tide_End { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay0_mm { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay1_mm { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay2_mm { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay3_mm { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay4_mm { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay5_mm { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay6_mm { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay7_mm { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay8_mm { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay9_mm { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay10_mm { get; set; }
        public bool? RemoveFromStat { get; set; }
        #endregion Properties in DB

        #region Constructors
        public MWQMRun() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMRunWeb : MWQMRun
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SubsectorTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage SubsectorTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMRunTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage MWQMRunTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LabSampleApprovalContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LabSampleApprovalContactTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "SampleTypeEnum", EnumType = "RunSampleType")]
        [CSSPAllowNull]
        public string RunSampleTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "BeaufortScaleEnum", EnumType = "SeaStateAtStart_BeaufortScale")]
        [CSSPAllowNull]
        public string SeaStateAtStart_BeaufortScaleText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "BeaufortScaleEnum", EnumType = "SeaStateAtEnd_BeaufortScale")]
        [CSSPAllowNull]
        public string SeaStateAtEnd_BeaufortScaleText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "AnalyzeMethodEnum", EnumType = "AnalyzeMethod")]
        [CSSPAllowNull]
        public string AnalyzeMethodText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "SampleMatrixEnum", EnumType = "SampleMatrix")]
        [CSSPAllowNull]
        public string SampleMatrixText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "LaboratoryEnum", EnumType = "Laboratory")]
        [CSSPAllowNull]
        public string LaboratoryText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "SampleStatusEnum", EnumType = "SampleStatus")]
        [CSSPAllowNull]
        public string SampleStatusText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TideTextEnum", EnumType = "Tide_Start")]
        [CSSPAllowNull]
        public string Tide_StartText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TideTextEnum", EnumType = "Tide_End")]
        [CSSPAllowNull]
        public string Tide_EndText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public MWQMRunWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMRunReport : MWQMRunWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string MWQMRunReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public MWQMRunReport() : base()
        {
        }
        #endregion Constructors
    }
}
