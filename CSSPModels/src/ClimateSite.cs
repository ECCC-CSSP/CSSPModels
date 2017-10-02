using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class ClimateSite : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int ClimateSiteID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "4")]
        public int ClimateSiteTVItemID { get; set; }
        [Range(1, 100000)]
        public int ECDBID { get; set; }
        [StringLength(100)]
        public string ClimateSiteName { get; set; }
        [StringLength(4)]
        public string Province { get; set; }
        [Range(0.0D, 10000.0D)]
        public double? Elevation_m { get; set; }
        [StringLength(10)]
        [CSSPAllowNull]
        public string ClimateID { get; set; }
        [Range(1, 100000)]
        public int? WMOID { get; set; }
        [StringLength(3)]
        [CSSPAllowNull]
        public string TCID { get; set; }
        public bool? IsProvincial { get; set; }
        [StringLength(50)]
        [CSSPAllowNull]
        public string ProvSiteID { get; set; }
        [Range(-10.0D, 0.0D)]
        public double? TimeOffset_hour { get; set; }
        [StringLength(50)]
        [CSSPAllowNull]
        public string File_desc { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? HourlyStartDate_Local { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? HourlyEndDate_Local { get; set; }
        public bool? HourlyNow { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? DailyStartDate_Local { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? DailyEndDate_Local { get; set; }
        public bool? DailyNow { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? MonthlyStartDate_Local { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? MonthlyEndDate_Local { get; set; }
        public bool? MonthlyNow { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public ClimateSiteWeb ClimateSiteWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public ClimateSiteReport ClimateSiteReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ClimateSite() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ClimateSiteWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ClimateSiteTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string ClimateSiteTVText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public ClimateSiteWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ClimateSiteReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string ClimateSiteReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public ClimateSiteReport()
        {
        }
        #endregion Constructors
    }
}
