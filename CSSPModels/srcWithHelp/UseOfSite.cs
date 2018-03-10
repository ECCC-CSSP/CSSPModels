using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class UseOfSite : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int UseOfSiteID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "4,9,22")]
        public int SiteTVItemID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]
        public int SubsectorTVItemID { get; set; }
        [CSSPEnumType]
        public SiteTypeEnum SiteType { get; set; }
        [Range(0, 1000)]
        public int Ordinal { get; set; }
        [Range(1980, 2050)]
        public int StartYear { get; set; }
        [Range(1980, 2050)]
        public int? EndYear { get; set; }
        public bool? UseWeight { get; set; }
        [Range(0.0D, 100.0D)]
        public double? Weight_perc { get; set; }
        public bool? UseEquation { get; set; }
        [Range(0.0D, 100.0D)]
        public double? Param1 { get; set; }
        [Range(0.0D, 100.0D)]
        public double? Param2 { get; set; }
        [Range(0.0D, 100.0D)]
        public double? Param3 { get; set; }
        [Range(0.0D, 100.0D)]
        public double? Param4 { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public UseOfSiteWeb UseOfSiteWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public UseOfSiteReport UseOfSiteReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public UseOfSite() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class UseOfSiteWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SiteTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string SiteTVText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SubsectorTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string SubsectorTVText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "SiteTypeEnum", EnumType = "SiteType")]
        [CSSPAllowNull]
        public string SiteTypeText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public UseOfSiteWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class UseOfSiteReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string UseOfSiteReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public UseOfSiteReport()
        {
        }
        #endregion Constructors
    }
}
