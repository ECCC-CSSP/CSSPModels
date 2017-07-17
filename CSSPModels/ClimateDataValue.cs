﻿using CSSPEnums;
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
        [Range(1, -1)]
        [CSSPExist(TypeName = "ClimateSite", Plurial = "s", FieldID = "ClimateSiteID")]
        public int ClimateSiteID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime DateTime_Local { get; set; }
        public bool Keep { get; set; }
        [CSSPEnumType]
        public StorageDataTypeEnum StorageDataType { get; set; }
        public float? Snow_cm { get; set; }
        public float? Rainfall_mm { get; set; }
        public float? RainfallEntered_mm { get; set; }
        public float? TotalPrecip_mm_cm { get; set; }
        public float? MaxTemp_C { get; set; }
        public float? MinTemp_C { get; set; }
        public float? HeatDegDays_C { get; set; }
        public float? CoolDegDays_C { get; set; }
        public float? SnowOnGround_cm { get; set; }
        public float? DirMaxGust_0North { get; set; }
        public float? SpdMaxGust_kmh { get; set; }
        public string HourlyValues { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual ClimateSite ClimateSite { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ClimateDataValue()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
