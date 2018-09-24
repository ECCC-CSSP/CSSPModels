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
    public partial class TideSite : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "TideSite ID")]
        [CSSPDisplayFR(DisplayFR = "TideSite ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the TideSites table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table TideSites")]
        public int TideSiteID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "22")]
        [CSSPDisplayEN(DisplayEN = "Tide site TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Site de marée TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the tide site")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant le site de marée")]
        public int TideSiteTVItemID { get; set; }
        [StringLength(100)]
        [CSSPDisplayEN(DisplayEN = "Web tide model")]
        [CSSPDisplayFR(DisplayFR = "Modèle de web tide")]
        [CSSPDescriptionEN(DescriptionEN = @"Web tide model")]
        [CSSPDescriptionFR(DescriptionFR = @"Modèle de web tide")]
        public string WebTideModel { get; set; }
        [Range(-100.0D, 100.0D)]
        [CSSPDisplayEN(DisplayEN = "Web tide datum (m)")]
        [CSSPDisplayFR(DisplayFR = "Datum de web tide (m)")]
        [CSSPDescriptionEN(DescriptionEN = @"Web tide model in meters")]
        [CSSPDescriptionFR(DescriptionFR = @"Datum de web tide en mètres")]
        public double WebTideDatum_m { get; set; }
        #endregion Properties in DB

        #region Constructors
        public TideSite() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TideSite_A : TideSite
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TideSiteTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Tide site TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du site de marée")]
        [CSSPDescriptionEN(DescriptionEN = @"Tide site TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du site de marée")]
        public TVItemLanguage TideSiteTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public TideSite_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TideSite_B : TideSite_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string TideSiteReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public TideSite_B() : base()
        {
        }
        #endregion Constructors
    }
}
