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
    public partial class MWQMSite : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MWQMSite ID")]
        [CSSPDisplayFR(DisplayFR = "MWQMSite ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MWQMSites table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table MWQMSites")]
        public int MWQMSiteID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "16")]
        [CSSPDisplayEN(DisplayEN = "MWQM site TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Site MWQM TVItemID (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing MWQM site")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant le site MWQM (fr)")]
        public int MWQMSiteTVItemID { get; set; }
        [StringLength(8)]
        [CSSPDisplayEN(DisplayEN = "MWQM site number")]
        [CSSPDisplayFR(DisplayFR = "Numéro du site MWQM (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"MWQM site number")]
        [CSSPDescriptionFR(DescriptionFR = @"Numéro du site MWQM (fr)")]
        public string MWQMSiteNumber { get; set; }
        [StringLength(200)]
        [CSSPDisplayEN(DisplayEN = "MWQM site description")]
        [CSSPDisplayFR(DisplayFR = "Description du site MWQM (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"MWQM site description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description du site MWQM (fr)")]
        public string MWQMSiteDescription { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "MWQM site latest classification")]
        [CSSPDisplayFR(DisplayFR = "Dernière classification du site MWQM (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"MWQM site latest classification")]
        [CSSPDescriptionFR(DescriptionFR = @"Dernière classification du site MWQM (fr)")]
        public MWQMSiteLatestClassificationEnum MWQMSiteLatestClassification { get; set; }
        [Range(0, 1000)]
        [CSSPDisplayEN(DisplayEN = "Ordinal")]
        [CSSPDisplayFR(DisplayFR = "Ordre")]
        [CSSPDescriptionEN(DescriptionEN = @"Ordinal")]
        [CSSPDescriptionFR(DescriptionFR = @"Ordre")]
        public int Ordinal { get; set; }
        #endregion Properties in DB

        #region Constructors
        public MWQMSite() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSiteExtraA : MWQMSite
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMSiteTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "MWQM site TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du site MWQM (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"MWQM site TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du site MWQM (fr)")]
        public TVItemLanguage MWQMSiteTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "MWQMSiteLatestClassificationEnum", EnumType = "MWQMSiteLatestClassification")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "MWQM site latest classification text")]
        [CSSPDisplayFR(DisplayFR = "Texte de la dernière classification du site MWQM (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"MWQM site latest classification text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de la dernière classification du site MWQM (fr)")]
        public string MWQMSiteLatestClassificationText { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSiteExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSiteExtraB : MWQMSiteExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string MWQMSiteReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSiteExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
