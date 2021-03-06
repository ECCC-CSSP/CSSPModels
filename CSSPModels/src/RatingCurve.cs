﻿/*
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
    public partial class RatingCurve : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "RatingCurve ID")]
        [CSSPDisplayFR(DisplayFR = "RatingCurve ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the RatingCurves table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table RatingCurves")]
        public int RatingCurveID { get; set; }
        [CSSPExist(ExistTypeName = "HydrometricSite", ExistPlurial = "s", ExistFieldID = "HydrometricSiteID")]
        [CSSPDisplayEN(DisplayEN = "Hydrometric site ID")]
        [CSSPDisplayFR(DisplayFR = "Site hydrométrique ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the Hydrometrics table representing the hydrometric site")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table Hydrometrics représentant le site hydrométrique")]
        public int HydrometricSiteID { get; set; }
        [StringLength(50)]
        [CSSPDisplayEN(DisplayEN = "Rating curve number")]
        [CSSPDisplayFR(DisplayFR = "Numéro de la courbe de tarage")]
        [CSSPDescriptionEN(DescriptionEN = @"Rating curve number")]
        [CSSPDescriptionFR(DescriptionFR = @"Numéro de la courbe de tarage")]
        public string RatingCurveNumber { get; set; }
        #endregion Properties in DB

        #region Constructors
        public RatingCurve() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class RatingCurveExtraA : RatingCurve
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact ayant fait le dernière changement")]
        public string LastUpdateContactText { get; set; }
        #endregion Properties

        #region Constructors
        public RatingCurveExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class RatingCurveExtraB : RatingCurveExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string RatingCurveReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public RatingCurveExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
