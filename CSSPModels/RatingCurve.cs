using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class RatingCurve
    {
        #region Properties in DB
        public int RatingCurveID { get; set; }
        public int HydrometricSiteID { get; set; }
        public string RatingCurveNumber { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual ICollection<RatingCurveValue> RatingCurveValues { get; set; }
        public virtual HydrometricSite HydrometricSite { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public RatingCurve()
        {
            RatingCurveValues = new HashSet<RatingCurveValue>();
        }
        #endregion Constructors

    }
}
