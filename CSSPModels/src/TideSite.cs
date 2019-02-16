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
        [CSSPDisplayEN(DisplayEN = "Tide site name")]
        [CSSPDisplayFR(DisplayFR = "Tide site name (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"Tide site name")]
        [CSSPDescriptionFR(DescriptionFR = @"Tide site name (fr)")]
        public string TideSiteName { get; set; }
        [StringLength(2, MinimumLength = 2)]
        [CSSPDisplayEN(DisplayEN = "Province")]
        [CSSPDisplayFR(DisplayFR = "Province")]
        [CSSPDescriptionEN(DescriptionEN = @"Province")]
        [CSSPDescriptionFR(DescriptionFR = @"Province")]
        public string Province { get; set; }
        [Range(0, 10000)]
        [CSSPDisplayEN(DisplayEN = "sid")]
        [CSSPDisplayFR(DisplayFR = "sid")]
        [CSSPDescriptionEN(DescriptionEN = @"sid")]
        [CSSPDescriptionFR(DescriptionFR = @"sid")]
        public int sid { get; set; }
        [Range(0, 10000)]
        [CSSPDisplayEN(DisplayEN = "Zone")]
        [CSSPDisplayFR(DisplayFR = "Zone")]
        [CSSPDescriptionEN(DescriptionEN = @"Zone")]
        [CSSPDescriptionFR(DescriptionFR = @"Zone")]
        public int Zone { get; set; }
        #endregion Properties in DB

        #region Constructors
        public TideSite() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TideSiteExtraA : TideSite
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TideSiteTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Tide site text")]
        [CSSPDisplayFR(DisplayFR = "Texte du site de marée")]
        [CSSPDescriptionEN(DescriptionEN = @"Tide site text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du site de marée")]
        public string TideSiteText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact ayant fait le dernière changement")]
        public string LastUpdateContactText { get; set; }
        #endregion Properties

        #region Constructors
        public TideSiteExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TideSiteExtraB : TideSiteExtraA
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
        public TideSiteExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
