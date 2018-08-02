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
    public partial class RatingCurveValue : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "RatingCurveValue ID")]
        [CSSPDisplayFR(DisplayFR = "RatingCurveValue ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the RatingCurveValues table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau RatingCurveValues")]
        public int RatingCurveValueID { get; set; }
        [CSSPExist(ExistTypeName = "RatingCurve", ExistPlurial = "s", ExistFieldID = "RatingCurveID")]
        public int RatingCurveID { get; set; }
        [Range(0.0D, 1000.0D)]
        public double StageValue_m { get; set; }
        [Range(0.0D, 1000000.0D)]
        public double DischargeValue_m3_s { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public RatingCurveValueWeb RatingCurveValueWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public RatingCurveValueReport RatingCurveValueReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public RatingCurveValue() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class RatingCurveValueWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties for web information

        #region Constructors
        public RatingCurveValueWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class RatingCurveValueReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string RatingCurveValueReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public RatingCurveValueReport()
        {
        }
        #endregion Constructors
    }
}
