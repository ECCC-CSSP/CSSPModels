using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class SamplingPlanSubsector
    {
        #region Properties in DB
        public int SamplingPlanSubsectorID { get; set; }
        public int SamplingPlanID { get; set; }
        public int SubsectorTVItemID { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual ICollection<SamplingPlanSubsectorSite> SamplingPlanSubsectorSites { get; set; }
        public virtual SamplingPlan SamplingPlan { get; set; }
        public virtual TVItem SubsectorTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public SamplingPlanSubsector()
        {
            SamplingPlanSubsectorSites = new HashSet<SamplingPlanSubsectorSite>();
        }
        #endregion Constructors

    }
}
