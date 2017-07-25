using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class RatingCurve
    {
        #region Properties in DB
        [Key]
        public int RatingCurveID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "HydrometricSite", Plurial = "s", FieldID = "HydrometricSiteID")]
        public int HydrometricSiteID { get; set; }
        [StringLength(50)]
        public string RatingCurveNumber { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Contact)]
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
