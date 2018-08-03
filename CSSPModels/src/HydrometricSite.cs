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
    public partial class HydrometricSite : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "HydrometricSite ID")]
        [CSSPDisplayFR(DisplayFR = "HydrometricSite ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the HydrometricSites table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau HydrometricSites")]
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
        [CSSPAfter(Year = 1849)]
        public DateTime? StartDate_Local { get; set; }
        [CSSPAfter(Year = 1849)]
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

        #region Constructors
        public HydrometricSite() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class HydrometricSiteWeb : HydrometricSite
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "HydrometricSiteTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage HydrometricTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties for web information

        #region Constructors
        public HydrometricSiteWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class HydrometricSiteReport : HydrometricSiteWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string HydrometricSiteReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public HydrometricSiteReport() : base()
        {
        }
        #endregion Constructors
    }
}
