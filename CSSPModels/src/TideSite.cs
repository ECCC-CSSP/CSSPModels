using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class TideSite : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int TideSiteID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "22")]
        public int TideSiteTVItemID { get; set; }
        [StringLength(100)]
        public string WebTideModel { get; set; }
        [Range(-100.0D, 100.0D)]
        public double WebTideDatum_m { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public TideSiteWeb TideSiteWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public TideSiteReport TideSiteReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TideSite() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TideSiteWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TideSiteTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string TideSiteTVText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string LastUpdateContactTVText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public TideSiteWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TideSiteReport
    {
        #region Properties for report information
        public string TideSiteReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public TideSiteReport()
        {
        }
        #endregion Constructors
    }
}
