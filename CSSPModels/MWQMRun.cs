using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MWQMRun
    {
        #region Properties in DB
        public int MWQMRunID { get; set; }
        public int SubsectorTVItemID { get; set; }
        public int MWQMRunTVItemID { get; set; }
        public SampleTypeEnum RunSampleType { get; set; }
        public DateTime DateTime_Local { get; set; }
        public int RunNumber { get; set; }
        public DateTime? StartDateTime_Local { get; set; }
        public DateTime? EndDateTime_Local { get; set; }
        public DateTime? LabReceivedDateTime_Local { get; set; }
        public float? TemperatureControl1_C { get; set; }
        public float? TemperatureControl2_C { get; set; }
        public BeaufortScaleEnum? SeaStateAtStart_BeaufortScale { get; set; }
        public BeaufortScaleEnum? SeaStateAtEnd_BeaufortScale { get; set; }
        public float? WaterLevelAtBrook_m { get; set; }
        public float? WaveHightAtStart_m { get; set; }
        public float? WaveHightAtEnd_m { get; set; }
        public string SampleCrewInitials { get; set; }
        public AnalyzeMethodEnum? AnalyzeMethod { get; set; }
        public SampleMatrixEnum? SampleMatrix { get; set; }
        public LaboratoryEnum? Laboratory { get; set; }
        public SampleStatusEnum? SampleStatus { get; set; }
        public int? LabSampleApprovalContactTVItemID { get; set; }
        public DateTime? LabAnalyzeBath1IncubationStartDateTime_Local { get; set; }
        public DateTime? LabAnalyzeBath2IncubationStartDateTime_Local { get; set; }
        public DateTime? LabAnalyzeBath3IncubationStartDateTime_Local { get; set; }
        public DateTime? LabRunSampleApprovalDateTime_Local { get; set; }
        public TideTextEnum? Tide_Start { get; set; }
        public TideTextEnum? Tide_End { get; set; }
        public float? RainDay0_mm { get; set; }
        public float? RainDay1_mm { get; set; }
        public float? RainDay2_mm { get; set; }
        public float? RainDay3_mm { get; set; }
        public float? RainDay4_mm { get; set; }
        public float? RainDay5_mm { get; set; }
        public float? RainDay6_mm { get; set; }
        public float? RainDay7_mm { get; set; }
        public float? RainDay8_mm { get; set; }
        public float? RainDay9_mm { get; set; }
        public float? RainDay10_mm { get; set; }
        public bool? RemoveFromStat { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual ICollection<MWQMRunLanguage> MWQMRunLanguages { get; set; }
        public virtual TVItem LabSampleApprovalContactTVItem { get; set; }
        public virtual TVItem MWQMRunTVItem { get; set; }
        public virtual TVItem SubsectorTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MWQMRun()
        {
            MWQMRunLanguages = new HashSet<MWQMRunLanguage>();
        }
        #endregion Constructors

    }
}
