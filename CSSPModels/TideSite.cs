using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class TideSite
    {
        #region Properties in DB
        public int TideSiteID { get; set; }
        public int TideSiteTVItemID { get; set; }
        public string WebTideModel { get; set; }
        public float WebTideDatum_m { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual TVItem TideSiteTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TideSite()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
