using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class HydrometricSite
    {
        #region Properties in DB
        public int HydrometricSiteID { get; set; }
        public int HydrometricSiteTVItemID { get; set; }
        public string FedSiteNumber { get; set; }
        public string QuebecSiteNumber { get; set; }
        public string HydrometricSiteName { get; set; }
        public string Description { get; set; }
        public string Province { get; set; }
        public float? Elevation_m { get; set; }
        public DateTime? StartDate_Local { get; set; }
        public DateTime? EndDate_Local { get; set; }
        public float? TimeOffset_hour { get; set; }
        public float? DrainageArea_km2 { get; set; }
        public bool? IsNatural { get; set; }
        public bool? IsActive { get; set; }
        public bool? Sediment { get; set; }
        public bool? RHBN { get; set; }
        public bool? RealTime { get; set; }
        public bool? HasRatingCurve { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
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
