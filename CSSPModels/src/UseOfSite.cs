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
    public partial class UseOfSite : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "UseOfSite ID")]
        [CSSPDisplayFR(DisplayFR = "UseOfSite ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the UseOfSites table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table UseOfSites")]
        public int UseOfSiteID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "4,9,22")]
        [CSSPDisplayEN(DisplayEN = "Site TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Site TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the climate site, hydrometric site or the tide site")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant le site climatique, site hydrométrique ou le site de marée")]
        public int SiteTVItemID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]
        [CSSPDisplayEN(DisplayEN = "Subsector TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Sous-secteur TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the subsector")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant le sous-secteur")]
        public int SubsectorTVItemID { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Type (climate, hydrometric or tide)")]
        [CSSPDisplayFR(DisplayFR = "Type (climatique, hydrométrique or de marée)")]
        [CSSPDescriptionEN(DescriptionEN = @"Type (climate, hydrometric or tide)")]
        [CSSPDescriptionFR(DescriptionFR = @"Type (climatique, hydrométrique or de marée)")]
        public TVTypeEnum TVType { get; set; }
        [Range(0, 1000)]
        [CSSPDisplayEN(DisplayEN = "Ordinal")]
        [CSSPDisplayFR(DisplayFR = "Ordre")]
        [CSSPDescriptionEN(DescriptionEN = @"Ordinal")]
        [CSSPDescriptionFR(DescriptionFR = @"Ordre")]
        public int Ordinal { get; set; }
        [Range(1980, 2050)]
        [CSSPDisplayEN(DisplayEN = "Start year")]
        [CSSPDisplayFR(DisplayFR = "Année de départ")]
        [CSSPDescriptionEN(DescriptionEN = @"Start year")]
        [CSSPDescriptionFR(DescriptionFR = @"Année de départ")]
        public int StartYear { get; set; }
        [Range(1980, 2050)]
        [CSSPDisplayEN(DisplayEN = "End year")]
        [CSSPDisplayFR(DisplayFR = "Année de fin")]
        [CSSPDescriptionEN(DescriptionEN = @"End year")]
        [CSSPDescriptionFR(DescriptionFR = @"Année de fin")]
        public int? EndYear { get; set; }
        [CSSPDisplayEN(DisplayEN = "Use weight")]
        [CSSPDisplayFR(DisplayFR = "Utilise poids")]
        [CSSPDescriptionEN(DescriptionEN = @"Use weight")]
        [CSSPDescriptionFR(DescriptionFR = @"Utilise poids")]
        public bool? UseWeight { get; set; }
        [Range(0.0D, 100.0D)]
        [CSSPDisplayEN(DisplayEN = "Weight (%)")]
        [CSSPDisplayFR(DisplayFR = "Poids (%)")]
        [CSSPDescriptionEN(DescriptionEN = @"Weight (%)")]
        [CSSPDescriptionFR(DescriptionFR = @"Poids (%)")]
        public double? Weight_perc { get; set; }
        [CSSPDisplayEN(DisplayEN = "Use equation")]
        [CSSPDisplayFR(DisplayFR = "Utilise équation")]
        [CSSPDescriptionEN(DescriptionEN = @"Use equation")]
        [CSSPDescriptionFR(DescriptionFR = @"Utilise équation")]
        public bool? UseEquation { get; set; }
        [Range(0.0D, 100.0D)]
        [CSSPDisplayEN(DisplayEN = "Parameter 1")]
        [CSSPDisplayFR(DisplayFR = "Paramètre 1")]
        [CSSPDescriptionEN(DescriptionEN = @"Parameter 1")]
        [CSSPDescriptionFR(DescriptionFR = @"Paramètre 1")]
        public double? Param1 { get; set; }
        [Range(0.0D, 100.0D)]
        [CSSPDisplayEN(DisplayEN = "Parameter 2")]
        [CSSPDisplayFR(DisplayFR = "Paramètre 2")]
        [CSSPDescriptionEN(DescriptionEN = @"Parameter 2")]
        [CSSPDescriptionFR(DescriptionFR = @"Paramètre 2")]
        public double? Param2 { get; set; }
        [Range(0.0D, 100.0D)]
        [CSSPDisplayEN(DisplayEN = "Parameter 3")]
        [CSSPDisplayFR(DisplayFR = "Paramètre 3")]
        [CSSPDescriptionEN(DescriptionEN = @"Parameter 3")]
        [CSSPDescriptionFR(DescriptionFR = @"Paramètre 3")]
        public double? Param3 { get; set; }
        [Range(0.0D, 100.0D)]
        [CSSPDisplayEN(DisplayEN = "Parameter 4")]
        [CSSPDisplayFR(DisplayFR = "Paramètre 4")]
        [CSSPDescriptionEN(DescriptionEN = @"Parameter 4")]
        [CSSPDescriptionFR(DescriptionFR = @"Paramètre 4")]
        public double? Param4 { get; set; }
        #endregion Properties in DB

        #region Constructors
        public UseOfSite() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class UseOfSiteExtraA : UseOfSite
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SiteTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Site text")]
        [CSSPDisplayFR(DisplayFR = "Texte du site")]
        [CSSPDescriptionEN(DescriptionEN = @"Site text (climate, hydrometric or tide)")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du site (climatique, hydrométrique ou de marée)")]
        public string SiteText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SubsectorTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Subsector text")]
        [CSSPDisplayFR(DisplayFR = "Texte du sous-secteur")]
        [CSSPDescriptionEN(DescriptionEN = @"Subsector text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du sous-secteur")]
        public string SubsectorText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact ayant fait le dernière changement")]
        public string LastUpdateContactText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TVType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "TVType text")]
        [CSSPDisplayFR(DisplayFR = "Texte de TVType")]
        [CSSPDescriptionEN(DescriptionEN = @"TVType text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de TVType")]
        public string TVTypeText { get; set; }
        #endregion Properties

        #region Constructors
        public UseOfSiteExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class UseOfSiteExtraB : UseOfSiteExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string UseOfSiteReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public UseOfSiteExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
