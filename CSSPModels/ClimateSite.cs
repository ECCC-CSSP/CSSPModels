using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class ClimateSite
    {
        #region Properties in DB
        [Key]
        public int ClimateSiteID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.ClimateSite)]
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
        public string ClimateID { get; set; }
        [Range(1, 100000)]
        public int? WMOID { get; set; }
        [StringLength(3)]
        public string TCID { get; set; }
        public bool? IsProvincial { get; set; }
        [StringLength(50)]
        public string ProvSiteID { get; set; }
        [Range(-10.0D, 0.0D)]
        public double? TimeOffset_hour { get; set; }
        [StringLength(50)]
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
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Contact)]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual ICollection<ClimateDataValue> ClimateDataValues { get; set; }
        public virtual TVItem ClimateSiteTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ClimateSite()
        {
            ClimateDataValues = new HashSet<ClimateDataValue>();
        }
        #endregion Constructors

    }
}
