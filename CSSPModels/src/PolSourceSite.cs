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
    public partial class PolSourceSite : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "PolSourceSite ID")]
        [CSSPDisplayFR(DisplayFR = "PolSourceSite ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the PolSourceSites table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau PolSourceSites")]
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

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public PolSourceSiteWeb PolSourceSiteWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public PolSourceSiteReport PolSourceSiteReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public PolSourceSite() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class PolSourceSiteWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "PolSourceSiteTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage PolSourceSiteTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "PolSourceInactiveReasonEnum", EnumType = "InactiveReason")]
        [CSSPAllowNull]
        public string InactiveReasonText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public PolSourceSiteWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class PolSourceSiteReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string PolSourceSiteReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public PolSourceSiteReport()
        {
        }
        #endregion Constructors
    }
}
