using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class ClimateDataValue
    {
        #region Properties in DB
        [Key]
        public int ClimateDataValueID { get; set; }
        [CSSPExist(ExistTypeName = "ClimateSite", ExistPlurial = "s", ExistFieldID = "ClimateSiteID")]
        public int ClimateSiteID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime DateTime_Local { get; set; }
        public bool Keep { get; set; }
        [CSSPEnumType]
        public StorageDataTypeEnum StorageDataType { get; set; }
        [Range(0.0D, 10000.0D)]
        public double? Snow_cm { get; set; }
        [Range(0.0D, 10000.0D)]
        public double? Rainfall_mm { get; set; }
        [Range(0.0D, 10000.0D)]
        public double? RainfallEntered_mm { get; set; }
        [Range(0.0D, 10000.0D)]
        public double? TotalPrecip_mm_cm { get; set; }
        [Range(-50.0D, 50.0D)]
        public double? MaxTemp_C { get; set; }
        [Range(-50.0D, 50.0D)]
        public double? MinTemp_C { get; set; }
        [Range(-1000.0D, 100.0D)]
        public double? HeatDegDays_C { get; set; }
        [Range(-1000.0D, 100.0D)]
        public double? CoolDegDays_C { get; set; }
        [Range(0.0D, 10000.0D)]
        public double? SnowOnGround_cm { get; set; }
        [Range(0.0D, 360.0D)]
        public double? DirMaxGust_0North { get; set; }
        [Range(0.0D, 300.0D)]
        public double? SpdMaxGust_kmh { get; set; }
        [CSSPAllowNull]
        public string HourlyValues { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string LastUpdateContactTVText { get; set; }
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "StorageDataTypeEnum", EnumType = "StorageDataType")]
        public string StorageDataTypeEnumText { get; set; }
        [NotMapped]
        public bool HasErrors { get; set; }
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ClimateDataValue()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
