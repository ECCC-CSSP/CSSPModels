using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MWQMSite
    {
        #region Properties in DB
        public int MWQMSiteID { get; set; }
        public int MWQMSiteTVItemID { get; set; }
        public string MWQMSiteNumber { get; set; }
        public string MWQMSiteDescription { get; set; }
        public MWQMSiteLatestClassificationEnum MWQMSiteLatestClassification { get; set; }
        public int Ordinal { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual TVItem MWQMSiteTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MWQMSite()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
