using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class RatingCurve : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int RatingCurveID { get; set; }
        [CSSPExist(ExistTypeName = "HydrometricSite", ExistPlurial = "s", ExistFieldID = "HydrometricSiteID")]
        public int HydrometricSiteID { get; set; }
        [StringLength(50)]
        public string RatingCurveNumber { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public RatingCurveWeb RatingCurveWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public RatingCurveReport RatingCurveReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public RatingCurve() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class RatingCurveWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string LastUpdateContactTVText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public RatingCurveWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class RatingCurveReport
    {
        #region Properties for report information
        public string RatingCurveReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public RatingCurveReport()
        {
        }
        #endregion Constructors
    }
}
