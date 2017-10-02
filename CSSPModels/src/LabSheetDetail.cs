using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class LabSheetDetail : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int LabSheetDetailID { get; set; }
        [CSSPExist(ExistTypeName = "LabSheet", ExistPlurial = "s", ExistFieldID = "LabSheetID")]
        public int LabSheetID { get; set; }
        [CSSPExist(ExistTypeName = "SamplingPlan", ExistPlurial = "s", ExistFieldID = "SamplingPlanID")]
        public int SamplingPlanID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]
        public int SubsectorTVItemID { get; set; }
        [Range(1, 5)]
        public int Version { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime RunDate { get; set; }
        [StringLength(7, MinimumLength = 1)]
        public string Tides { get; set; }
        [StringLength(20)]
        [CSSPAllowNull]
        public string SampleCrewInitials { get; set; }
        [Range(1, 3)]
        public int? WaterBathCount { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? IncubationBath1StartTime { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? IncubationBath2StartTime { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? IncubationBath3StartTime { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? IncubationBath1EndTime { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? IncubationBath2EndTime { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? IncubationBath3EndTime { get; set; }
        [Range(0, 10000)]
        public int? IncubationBath1TimeCalculated_minutes { get; set; }
        [Range(0, 10000)]
        public int? IncubationBath2TimeCalculated_minutes { get; set; }
        [Range(0, 10000)]
        public int? IncubationBath3TimeCalculated_minutes { get; set; }
        [StringLength(10)]
        [CSSPAllowNull]
        public string WaterBath1 { get; set; }
        [StringLength(10)]
        [CSSPAllowNull]
        public string WaterBath2 { get; set; }
        [StringLength(10)]
        [CSSPAllowNull]
        public string WaterBath3 { get; set; }
        [Range(-10.0D, 40.0D)]
        public double? TCField1 { get; set; }
        [Range(-10.0D, 40.0D)]
        public double? TCLab1 { get; set; }
        [Range(-10.0D, 40.0D)]
        public double? TCField2 { get; set; }
        [Range(-10.0D, 40.0D)]
        public double? TCLab2 { get; set; }
        [Range(-10.0D, 40.0D)]
        public double? TCFirst { get; set; }
        [Range(-10.0D, 40.0D)]
        public double? TCAverage { get; set; }
        [StringLength(100)]
        [CSSPAllowNull]
        public string ControlLot { get; set; }
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Positive35 { get; set; }
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string NonTarget35 { get; set; }
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Negative35 { get; set; }
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Bath1Positive44_5 { get; set; }
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Bath2Positive44_5 { get; set; }
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Bath3Positive44_5 { get; set; }
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Bath1NonTarget44_5 { get; set; }
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Bath2NonTarget44_5 { get; set; }
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Bath3NonTarget44_5 { get; set; }
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Bath1Negative44_5 { get; set; }
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Bath2Negative44_5 { get; set; }
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Bath3Negative44_5 { get; set; }
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Blank35 { get; set; }
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Bath1Blank44_5 { get; set; }
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Bath2Blank44_5 { get; set; }
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Bath3Blank44_5 { get; set; }
        [StringLength(20)]
        [CSSPAllowNull]
        public string Lot35 { get; set; }
        [StringLength(20)]
        [CSSPAllowNull]
        public string Lot44_5 { get; set; }
        [StringLength(250)]
        [CSSPAllowNull]
        public string Weather { get; set; }
        [StringLength(250)]
        [CSSPAllowNull]
        public string RunComment { get; set; }
        [StringLength(250)]
        [CSSPAllowNull]
        public string RunWeatherComment { get; set; }
        [StringLength(20)]
        [CSSPAllowNull]
        public string SampleBottleLotNumber { get; set; }
        [StringLength(20)]
        [CSSPAllowNull]
        public string SalinitiesReadBy { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? SalinitiesReadDate { get; set; }
        [StringLength(20)]
        [CSSPAllowNull]
        public string ResultsReadBy { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? ResultsReadDate { get; set; }
        [StringLength(20)]
        [CSSPAllowNull]
        public string ResultsRecordedBy { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? ResultsRecordedDate { get; set; }
        [Range(0.0D, 100.0D)]
        public double? DailyDuplicateRLog { get; set; }
        [Range(0.0D, 100.0D)]
        public double? DailyDuplicatePrecisionCriteria { get; set; }
        public bool? DailyDuplicateAcceptable { get; set; }
        [Range(0.0D, 100.0D)]
        public double? IntertechDuplicateRLog { get; set; }
        [Range(0.0D, 100.0D)]
        public double? IntertechDuplicatePrecisionCriteria { get; set; }
        public bool? IntertechDuplicateAcceptable { get; set; }
        public bool? IntertechReadAcceptable { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public LabSheetDetailWeb LabSheetDetailWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public LabSheetDetailReport LabSheetDetailReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public LabSheetDetail() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class LabSheetDetailWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SubsectorTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string SubsectorTVText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public LabSheetDetailWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class LabSheetDetailReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string LabSheetDetailReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public LabSheetDetailReport()
        {
        }
        #endregion Constructors
    }
}
