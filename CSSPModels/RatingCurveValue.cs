using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class RatingCurveValue
    {
        #region Properties in DB
        public int RatingCurveValueID { get; set; }
        public int RatingCurveID { get; set; }
        public float StageValue_m { get; set; }
        public float DischargeValue_m3_s { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual RatingCurve RatingCurve { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public RatingCurveValue()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
