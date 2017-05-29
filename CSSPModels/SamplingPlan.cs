using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class SamplingPlan
    {
        #region Properties in DB
        public int SamplingPlanID { get; set; }
        public string SamplingPlanName { get; set; }
        public string ForGroupName { get; set; }
        public SampleTypeEnum SampleType { get; set; }
        public SamplingPlanTypeEnum SamplingPlanType { get; set; }
        public LabSheetTypeEnum LabSheetType { get; set; }
        public int ProvinceTVItemID { get; set; }
        public int CreatorTVItemID { get; set; }
        public int Year { get; set; }
        public string AccessCode { get; set; }
        public float DailyDuplicatePrecisionCriteria { get; set; }
        public float IntertechDuplicatePrecisionCriteria { get; set; }
        public bool IncludeLaboratoryQAQC { get; set; }
        public int? SamplingPlanFileTVItemID { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual ICollection<LabSheetDetail> LabSheetDetails { get; set; }
        public virtual ICollection<LabSheet> LabSheets { get; set; }
        public virtual ICollection<SamplingPlanSubsector> SamplingPlanSubsectors { get; set; }
        public virtual TVItem CreatorTVItem { get; set; }
        public virtual TVItem ProvinceTVItem { get; set; }
        public virtual TVItem SamplingPlanFileTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public SamplingPlan()
        {
            LabSheetDetails = new HashSet<LabSheetDetail>();
            LabSheets = new HashSet<LabSheet>();
            SamplingPlanSubsectors = new HashSet<SamplingPlanSubsector>();
        }
        #endregion Constructors

    }
}
