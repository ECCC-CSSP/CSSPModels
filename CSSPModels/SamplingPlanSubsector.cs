using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class SamplingPlanSubsector
    {
        #region Properties in DB
        [Key]
        public int SamplingPlanSubsectorID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "SamplingPlan", Plurial = "s", FieldID = "SamplingPlanID")]
        public int SamplingPlanID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Subsector)]
        public int SubsectorTVItemID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Contact)]
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
