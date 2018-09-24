/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CSSPModels
{
    public partial class RatingCurveValue : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "RatingCurveValue ID")]
        [CSSPDisplayFR(DisplayFR = "RatingCurveValue ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the RatingCurveValues table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table RatingCurveValues")]
        public int RatingCurveValueID { get; set; }
        [CSSPExist(ExistTypeName = "RatingCurve", ExistPlurial = "s", ExistFieldID = "RatingCurveID")]
        [CSSPDisplayEN(DisplayEN = "Rating curve ID")]
        [CSSPDisplayFR(DisplayFR = "Identifiant de la courbe de tarage")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the RatingCurves table representing the rating curve")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table RatingCurves représentant la courve de tarage")]
        public int RatingCurveID { get; set; }
        [Range(0.0D, 1000.0D)]
        [CSSPDisplayEN(DisplayEN = "Stage value (m)")]
        [CSSPDisplayFR(DisplayFR = "Valeur de niveau (m)")]
        [CSSPDescriptionEN(DescriptionEN = @"Stage value in meters")]
        [CSSPDescriptionFR(DescriptionFR = @"Valeur de niveau en mètres")]
        public double StageValue_m { get; set; }
        [Range(0.0D, 1000000.0D)]
        [CSSPDisplayEN(DisplayEN = "Discharge value (m3/s)")]
        [CSSPDisplayFR(DisplayFR = "Valeur du débits (m3/s)")]
        [CSSPDescriptionEN(DescriptionEN = @"Discharge value in cubic meters per second")]
        [CSSPDescriptionFR(DescriptionFR = @"Valeur du débits en mètres cube par second")]
        public double DischargeValue_m3_s { get; set; }
        #endregion Properties in DB

        #region Constructors
        public RatingCurveValue() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class RatingCurveValue_A : RatingCurveValue
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public RatingCurveValue_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class RatingCurveValue_B : RatingCurveValue_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string RatingCurveValueReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public RatingCurveValue_B() : base()
        {
        }
        #endregion Constructors
    }
}
