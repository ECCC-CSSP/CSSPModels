using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class UseOfSite
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
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SiteTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string SiteTVText { get; set; }
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SubsectorTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string SubsectorTVText { get; set; }
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string LastUpdateContactTVText { get; set; }
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "SiteTypeEnum", EnumType = "SiteType")]
        public string SiteTypeText { get; set; }
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public UseOfSite()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
