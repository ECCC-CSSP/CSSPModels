using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class LabSheet
    {
        #region Properties in DB
        [Key]
        public int LabSheetID { get; set; }
        [Range(1, -1)]
        public int OtherServerLabSheetID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "SamplingPlan", Plurial = "s", FieldID = "SamplingPlanID")]
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
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int SubsectorTVItemID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        [CSSPAllowNull]
        public int? MWQMRunTVItemID { get; set; }
        [CSSPEnumType]
        public SamplingPlanTypeEnum SamplingPlanType { get; set; }
        [CSSPEnumType]
        public SampleTypeEnum SampleType { get; set; }
        [CSSPEnumType]
        public LabSheetTypeEnum LabSheetType { get; set; }
        [CSSPEnumType]
        public LabSheetStatusEnum LabSheetStatus { get; set; }
        [StringLength(250, MinimumLength = 1)]
        public string FileName { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime FileLastModifiedDate_Local { get; set; }

        public string FileContent { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int? AcceptedOrRejectedByContactTVItemID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? AcceptedOrRejectedDateTime { get; set; }
        [StringLength(250)]
        [CSSPAllowNull]
        public string RejectReason { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual ICollection<LabSheetDetail> LabSheetDetails { get; set; }
        public virtual TVItem AcceptedOrRejectedByContactTVItem { get; set; }
        public virtual TVItem MWQMRunTVItem { get; set; }
        public virtual SamplingPlan SamplingPlan { get; set; }
        public virtual TVItem SubsectorTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public LabSheet()
        {
            LabSheetDetails = new HashSet<LabSheetDetail>();
        }
        #endregion Constructors

    }
}
