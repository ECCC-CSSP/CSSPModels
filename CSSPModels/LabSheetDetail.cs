using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class LabSheetDetail
    {
        #region Properties in DB
        public int LabSheetDetailID { get; set; }
        public int LabSheetID { get; set; }
        public int SamplingPlanID { get; set; }
        public int SubsectorTVItemID { get; set; }
        public int Version { get; set; }
        public DateTime RunDate { get; set; }
        public string Tides { get; set; }
        public string SampleCrewInitials { get; set; }
        public int? WaterBathCount { get; set; }
        public DateTime? IncubationBath1StartTime { get; set; }
        public DateTime? IncubationBath2StartTime { get; set; }
        public DateTime? IncubationBath3StartTime { get; set; }
        public DateTime? IncubationBath1EndTime { get; set; }
        public DateTime? IncubationBath2EndTime { get; set; }
        public DateTime? IncubationBath3EndTime { get; set; }
        public int? IncubationBath1TimeCalculated_minutes { get; set; }
        public int? IncubationBath2TimeCalculated_minutes { get; set; }
        public int? IncubationBath3TimeCalculated_minutes { get; set; }
        public string WaterBath1 { get; set; }
        public string WaterBath2 { get; set; }
        public string WaterBath3 { get; set; }
        public float? TCField1 { get; set; }
        public float? TCLab1 { get; set; }
        public float? TCField2 { get; set; }
        public float? TCLab2 { get; set; }
        public float? TCFirst { get; set; }
        public float? TCAverage { get; set; }
        public string ControlLot { get; set; }
        public string Positive35 { get; set; }
        public string NonTarget35 { get; set; }
        public string Negative35 { get; set; }
        public string Bath1Positive44_5 { get; set; }
        public string Bath2Positive44_5 { get; set; }
        public string Bath3Positive44_5 { get; set; }
        public string Bath1NonTarget44_5 { get; set; }
        public string Bath2NonTarget44_5 { get; set; }
        public string Bath3NonTarget44_5 { get; set; }
        public string Bath1Negative44_5 { get; set; }
        public string Bath2Negative44_5 { get; set; }
        public string Bath3Negative44_5 { get; set; }
        public string Blank35 { get; set; }
        public string Bath1Blank44_5 { get; set; }
        public string Bath2Blank44_5 { get; set; }
        public string Bath3Blank44_5 { get; set; }
        public string Lot35 { get; set; }
        public string Lot44_5 { get; set; }
        public string Weather { get; set; }
        public string RunComment { get; set; }
        public string RunWeatherComment { get; set; }
        public string SampleBottleLotNumber { get; set; }
        public string SalinitiesReadBy { get; set; }
        public DateTime? SalinitiesReadDate { get; set; }
        public string ResultsReadBy { get; set; }
        public DateTime? ResultsReadDate { get; set; }
        public string ResultsRecordedBy { get; set; }
        public DateTime? ResultsRecordedDate { get; set; }
        public float? DailyDuplicateRlog { get; set; }
        public float? DailyDuplicatePrecisionCriteria { get; set; }
        public bool? DailyDuplicateAcceptable { get; set; }
        public float? IntertechDuplicateRlog { get; set; }
        public float? IntertechDuplicatePrecisionCriteria { get; set; }
        public bool? IntertechDuplicateAcceptable { get; set; }
        public bool? IntertechReadAcceptable { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual ICollection<LabSheetTubeMPNDetail> LabSheetTubeMPNDetails { get; set; }
        public virtual LabSheet LabSheet { get; set; }
        public virtual SamplingPlan SamplingPlan { get; set; }
        public virtual TVItem SubsectorTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public LabSheetDetail()
        {
            LabSheetTubeMPNDetails = new HashSet<LabSheetTubeMPNDetail>();
        }
        #endregion Constructors

    }
}
