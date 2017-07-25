using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class HydrometricSite
    {
        #region Properties in DB
        [Key]
        public int HydrometricSiteID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.HydrometricSite)]
        public int HydrometricSiteTVItemID { get; set; }
        [StringLength(7)]
        public string FedSiteNumber { get; set; }
        [StringLength(7)]
        public string QuebecSiteNumber { get; set; }
        [StringLength(200)]
        [CSSPAllowNull]
        public string HydrometricSiteName { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        [StringLength(4)]
        [CSSPAllowNull]
        public string Province { get; set; }
        [Range(0.0D, 10000.0D)]
        public double? Elevation_m { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? StartDate_Local { get; set; }
        [CSSPBigger(OtherField = "StartDate_Local")]
        [CSSPAfter(Year = 1980)]
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
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Contact)]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual ICollection<HydrometricDataValue> HydrometricDataValues { get; set; }
        public virtual ICollection<RatingCurve> RatingCurves { get; set; }
        public virtual TVItem HydrometricSiteTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public HydrometricSite()
        {
            HydrometricDataValues = new HashSet<HydrometricDataValue>();
            RatingCurves = new HashSet<RatingCurve>();
        }
        #endregion Constructors

    }
}
