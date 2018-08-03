/*
 * Manually edited by Charles LeBlanc 
 * 
 */
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
        [CSSPDisplayEN(DisplayEN = "RatingCurve ID")]
        [CSSPDisplayFR(DisplayFR = "RatingCurve ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the RatingCurves table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau RatingCurves")]
        public int RatingCurveID { get; set; }
        [CSSPExist(ExistTypeName = "HydrometricSite", ExistPlurial = "s", ExistFieldID = "HydrometricSiteID")]
        public int HydrometricSiteID { get; set; }
        [StringLength(50)]
        public string RatingCurveNumber { get; set; }
        #endregion Properties in DB

        #region Constructors
        public RatingCurve() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class RatingCurveWeb : RatingCurve
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties for web information

        #region Constructors
        public RatingCurveWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class RatingCurveReport : RatingCurveWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string RatingCurveReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public RatingCurveReport() : base()
        {
        }
        #endregion Constructors
    }
}
