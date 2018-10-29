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
    public partial class PolSourceSite : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "PolSourceSite ID")]
        [CSSPDisplayFR(DisplayFR = "PolSourceSite ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the PolSourceSites table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table PolSourceSites")]
        public int PolSourceSiteID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "17")]
        [CSSPDisplayEN(DisplayEN = "Pollution source site TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Site de source de pollution TVItemID (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing pollution source site")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant le site de source de pollution")]
        public int PolSourceSiteTVItemID { get; set; }
        [StringLength(50)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Temporary locator which can be deleted in the future")]
        [CSSPDisplayFR(DisplayFR = "Localisateur temporaire qui peut être supprimé à l'avenir")]
        [CSSPDescriptionEN(DescriptionEN = @"Temporary locator which can be deleted in the future")]
        [CSSPDescriptionFR(DescriptionFR = @"Localisateur temporaire qui peut être supprimé à l'avenir")]
        public string Temp_Locator_CanDelete { get; set; }
        [Range(0, 1000)]
        [CSSPDisplayEN(DisplayEN = "Old site ID")]
        [CSSPDisplayFR(DisplayFR = "Ancien identifiant du site")]
        [CSSPDescriptionEN(DescriptionEN = @"Old site ID")]
        [CSSPDescriptionFR(DescriptionFR = @"Ancien identifiant du site")]
        public int? Oldsiteid { get; set; }
        [Range(0, 1000)]
        [CSSPDisplayEN(DisplayEN = "Site number/text")]
        [CSSPDisplayFR(DisplayFR = "Numéro/texte du site")]
        [CSSPDescriptionEN(DescriptionEN = @"Site number/text")]
        [CSSPDescriptionFR(DescriptionFR = @"Numéro/texte du site")]
        public int? Site { get; set; }
        [Range(0, 1000)]
        [CSSPDisplayEN(DisplayEN = "Site ID (not used)")]
        [CSSPDisplayFR(DisplayFR = "Identifiant Site (not used)")]
        [CSSPDescriptionEN(DescriptionEN = @"Site ID (not used)")]
        [CSSPDescriptionFR(DescriptionFR = @"Identifiant Site (not used)")]
        public int? SiteID { get; set; }
        [CSSPDisplayEN(DisplayEN = "Is point source")]
        [CSSPDisplayFR(DisplayFR = "Est une source ponctuelle")]
        [CSSPDescriptionEN(DescriptionEN = @"Is point source")]
        [CSSPDescriptionFR(DescriptionFR = @"Est une source ponctuelle")]
        public bool IsPointSource { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Pollution source inactive reason")]
        [CSSPDisplayFR(DisplayFR = "Raison que la source de pollution est inactive")]
        [CSSPDescriptionEN(DescriptionEN = @"Pollution source inactive reason")]
        [CSSPDescriptionFR(DescriptionFR = @"Raison que la source de pollution est inactive")]
        public PolSourceInactiveReasonEnum? InactiveReason { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "2")]
        [CSSPDisplayEN(DisplayEN = "Civic address TVItemID")]
        [CSSPDisplayFR(DisplayFR = "L'adresse civique TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the civic address")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant l'adresse civique")]
        public int? CivicAddressTVItemID { get; set; }
        #endregion Properties in DB

        #region Constructors
        public PolSourceSite() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class PolSourceSiteExtraA : PolSourceSite
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "PolSourceSiteTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Pollution source site text")]
        [CSSPDisplayFR(DisplayFR = "Texte du site de source de pollution")]
        [CSSPDescriptionEN(DescriptionEN = @"Pollution source site text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du site de source de pollution")]
        public string PolSourceSiteText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact ayant fait le dernière changement")]
        public string LastUpdateContactText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "PolSourceInactiveReasonEnum", EnumType = "InactiveReason")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Inactive reason text")]
        [CSSPDisplayFR(DisplayFR = "Texte de la raison de l'inactivité")]
        [CSSPDescriptionEN(DescriptionEN = @"Inactive reason text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de la raison de l'inactivité")]
        public string InactiveReasonText { get; set; }
        #endregion Properties

        #region Constructors
        public PolSourceSiteExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class PolSourceSiteExtraB : PolSourceSiteExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string PolSourceSiteReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public PolSourceSiteExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
