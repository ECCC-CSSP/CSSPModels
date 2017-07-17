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
        [Key]
        public int SamplingPlanID { get; set; }
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
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int ProvinceTVItemID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int CreatorTVItemID { get; set; }
        [Range(2000, 2050)]
        public int Year { get; set; }
        [StringLength(15)]
        public string AccessCode { get; set; }
        [Range(0.0f, 100.0f)]
        public float DailyDuplicatePrecisionCriteria { get; set; }
        [Range(0.0f, 100.0f)]
        public float IntertechDuplicatePrecisionCriteria { get; set; }
        public bool IncludeLaboratoryQAQC { get; set; }
        [StringLength(15)]
        public string ApprovalCode { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int? SamplingPlanFileTVItemID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
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
