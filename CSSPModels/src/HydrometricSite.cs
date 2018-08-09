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
    public partial class HydrometricSite : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "HydrometricSite ID")]
        [CSSPDisplayFR(DisplayFR = "HydrometricSite ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the HydrometricSites table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table HydrometricSites")]
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
    public partial class HydrometricSite_A : HydrometricSite
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "HydrometricSiteTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        public TVItemLanguage HydrometricTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public HydrometricSite_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class HydrometricSite_B : HydrometricSite_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string HydrometricSiteReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public HydrometricSite_B() : base()
        {
        }
        #endregion Constructors
    }
}
