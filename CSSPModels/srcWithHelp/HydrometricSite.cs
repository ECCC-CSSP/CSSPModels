using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class HydrometricSite : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int HydrometricSiteID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "9")]
        public int HydrometricSiteTVItemID { get; set; }
        [StringLength(7)]
        [CSSPAllowNull]
        public string FedSiteNumber { get; set; }
        [StringLength(7)]
        [CSSPAllowNull]
        public string QuebecSiteNumber { get; set; }
        [StringLength(200)]
        public string HydrometricSiteName { get; set; }
        [StringLength(200)]
        [CSSPAllowNull]
        public string Description { get; set; }
        [StringLength(4)]
        public string Province { get; set; }
        [Range(0.0D, 10000.0D)]
        public double? Elevation_m { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? StartDate_Local { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPBigger(OtherField = "StartDate_Local")]
        public DateTime? EndDate_Local { get; set; }
        [Range(-10.0D, 0.0D)]
        public double? TimeOffset_hour { get; set; }
        [Range(0.0D, 1000000.0D)]
        public double? DrainageArea_km2 { get; set; }
        public bool? IsNatural { get; set; }
        public bool? IsActive { get; set; }
        public bool? Sediment { get; set; }
        public bool? RHBN { get; set; }
        public bool? RealTime { get; set; }
        public bool? HasRatingCurve { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public HydrometricSiteWeb HydrometricSiteWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public HydrometricSiteReport HydrometricSiteReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public HydrometricSite() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class HydrometricSiteWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "HydrometricSiteTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string HydrometricTVText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public HydrometricSiteWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class HydrometricSiteReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string HydrometricSiteReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public HydrometricSiteReport()
        {
        }
        #endregion Constructors
    }
}
