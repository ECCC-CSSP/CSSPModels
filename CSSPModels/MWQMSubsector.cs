using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MWQMSubsector
    {
        #region Properties in DB
        [Key]
        public int MWQMSubsectorID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]
        public int MWQMSubsectorTVItemID { get; set; }
        [StringLength(20)]
        public string SubsectorHistoricKey { get; set; }
        [StringLength(20)]
        [CSSPAllowNull]
        public string TideLocationSIDText { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay0Limit { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay1Limit { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay2Limit { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay3Limit { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay4Limit { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay5Limit { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay6Limit { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay7Limit { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay8Limit { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay9Limit { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay10Limit { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? IncludeRainStartDate { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? IncludeRainEndDate { get; set; }
        [Range(0, 10)]
        public int? IncludeRainRunCount { get; set; }
        public bool? IncludeRainSelectFullYear { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? NoRainStartDate { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? NoRainEndDate { get; set; }
        [Range(0, 10)]
        public int? NoRainRunCount { get; set; }
        public bool? NoRainSelectFullYear { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? OnlyRainStartDate { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? OnlyRainEndDate { get; set; }
        [Range(0, 10)]
        public int? OnlyRainRunCount { get; set; }
        public bool? OnlyRainSelectFullYear { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMSubsectorTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string SubsectorTVText { get; set; }
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string LastUpdateContactTVText { get; set; }
        [NotMapped]
        public bool HasErrors { get; set; }
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MWQMSubsector()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors

    }
}
