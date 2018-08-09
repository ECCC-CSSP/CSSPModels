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
        public int PolSourceSiteTVItemID { get; set; }
        [StringLength(50)]
        [CSSPAllowNull]
        public string Temp_Locator_CanDelete { get; set; }
        [Range(0, 1000)]
        public int? Oldsiteid { get; set; }
        [Range(0, 1000)]
        public int? Site { get; set; }
        [Range(0, 1000)]
        public int? SiteID { get; set; }
        public bool IsPointSource { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public PolSourceInactiveReasonEnum? InactiveReason { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "2")]
        public int? CivicAddressTVItemID { get; set; }
        #endregion Properties in DB

        #region Constructors
        public PolSourceSite() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class PolSourceSite_A : PolSourceSite
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "PolSourceSiteTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        public TVItemLanguage PolSourceSiteTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "PolSourceInactiveReasonEnum", EnumType = "InactiveReason")]
        [CSSPAllowNull]
        public string InactiveReasonText { get; set; }
        #endregion Properties

        #region Constructors
        public PolSourceSite_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class PolSourceSite_B : PolSourceSite_A
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
        public PolSourceSite_B() : base()
        {
        }
        #endregion Constructors
    }
}
