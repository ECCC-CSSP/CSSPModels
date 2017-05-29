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
        public int LabSheetID { get; set; }
        public int OtherServerLabSheetID { get; set; }
        public int SamplingPlanID { get; set; }
        public string SamplingPlanName { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int RunNumber { get; set; }
        public int SubsectorTVItemID { get; set; }
        public int? MWQMRunTVItemID { get; set; }
        public SamplingPlanTypeEnum SamplingPlanType { get; set; }
        public SampleTypeEnum SampleType { get; set; }
        public LabSheetTypeEnum LabSheetType { get; set; }
        public LabSheetStatusEnum LabSheetStatus { get; set; }
        public string FileName { get; set; }
        public DateTime FileLastModifiedDate_Local { get; set; }
        public string FileContent { get; set; }
        public int? AcceptedOrRejectedByContactTVItemID { get; set; }
        public DateTime? AcceptedOrRejectedDateTime { get; set; }
        public string RejectReason { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
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
