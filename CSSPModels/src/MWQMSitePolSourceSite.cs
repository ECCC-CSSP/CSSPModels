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
    public partial class MWQMSitePolSourceSite : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MWQMSitePolSourceSite ID")]
        [CSSPDisplayFR(DisplayFR = "MWQMSitePolSourceSite ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MWQMSitePolSourceSites table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table MWQMSitePolSourceSites")]
        public int MWQMSitePolSourceSiteID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "16")]
        [CSSPDisplayEN(DisplayEN = "MWQM site TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Site MWQM TVItemID (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing MWQM site")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant le site MWQM (fr)")]
        public int MWQMSiteTVItemID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "17")]
        [CSSPDisplayEN(DisplayEN = "Pollution source site TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Site de source de pollution TVItemID (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing pollution source site")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant le site de source de pollution (fr)")]
        public int PolSourceSiteTVItemID { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Tree view type")]
        [CSSPDisplayFR(DisplayFR = "Type arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view type (can be infrastructure or pollution source site)")]
        [CSSPDescriptionFR(DescriptionFR = @"Type d'arbre visuel (peut être infrastructure ou site de source de pollution")]
        public TVTypeEnum TVType { get; set; }
        [StringLength(4000)]
        [CSSPDisplayEN(DisplayEN = "Link reasons")]
        [CSSPDisplayFR(DisplayFR = "Raisons du lien")]
        [CSSPDescriptionEN(DescriptionEN = @"Link reasons")]
        [CSSPDescriptionFR(DescriptionFR = @"Raisons du lien")]
        public string LinkReasons { get; set; }
        #endregion Properties in DB

        #region Constructors
        public MWQMSitePolSourceSite() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSitePolSourceSiteExtraA : MWQMSitePolSourceSite
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMSiteTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "MWQM site TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du site MWQM (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"MWQM site TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du site MWQM (fr)")]
        public TVItemLanguage MWQMSiteTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "PolSourceSiteTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Pollution source site TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du site de source de pollution")]
        [CSSPDescriptionEN(DescriptionEN = @"Pollution source site TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du site de source de pollution")]
        public TVItemLanguage PolSourceSiteTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TVType")]
        [CSSPDisplayEN(DisplayEN = "Tree view type text")]
        [CSSPDisplayFR(DisplayFR = "Text de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Text de l'arbre visuel")]
        public string TVTypeText { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSitePolSourceSiteExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSitePolSourceSiteExtraB : MWQMSitePolSourceSiteExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string MWQMSitePolSourceSiteReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSitePolSourceSiteExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
