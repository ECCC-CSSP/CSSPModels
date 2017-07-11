﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class SamplingPlanSubsectorSite
    {
        #region Properties in DB
        [Key]
        public int SamplingPlanSubsectorSiteID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "SamplingPlanSubsector", Plurial = "s", FieldID = "SamplingPlanSubsectorID")]
        public int SamplingPlanSubsectorID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int MWQMSiteTVItemID { get; set; }
        public bool IsDuplicate { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual TVItem MWQMSiteTVItem { get; set; }
        public virtual SamplingPlanSubsector SamplingPlanSubsector { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public SamplingPlanSubsectorSite()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
