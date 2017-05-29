using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class UseOfSite
    {
        #region Properties in DB
        public int UseOfSiteID { get; set; }
        public int SiteTVItemID { get; set; }
        public int SubsectorTVItemID { get; set; }
        public SiteTypeEnum SiteType { get; set; }
        public int Ordinal { get; set; }
        public int StartYear { get; set; }
        public int? EndYear { get; set; }
        public bool? UseWeight { get; set; }
        public float? Weight_perc { get; set; }
        public bool? UseEquation { get; set; }
        public float? Param1 { get; set; }
        public float? Param2 { get; set; }
        public float? Param3 { get; set; }
        public float? Param4 { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual TVItem SiteTVItem { get; set; }
        public virtual TVItem SubsectorTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public UseOfSite()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
