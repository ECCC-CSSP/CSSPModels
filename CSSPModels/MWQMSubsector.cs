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
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int MWQMSubsectorTVItemID { get; set; }
        [StringLength(20)]
        public string SubsectorHistoricKey { get; set; }
        [StringLength(20)]
        public string TideLocationSIDText { get; set; }
        [Range(0.0f, 300.0f)]
        public float? RainDay0Limit { get; set; }
        [Range(0.0f, 300.0f)]
        public float? RainDay1Limit { get; set; }
        [Range(0.0f, 300.0f)]
        public float? RainDay2Limit { get; set; }
        [Range(0.0f, 300.0f)]
        public float? RainDay3Limit { get; set; }
        [Range(0.0f, 300.0f)]
        public float? RainDay4Limit { get; set; }
        [Range(0.0f, 300.0f)]
        public float? RainDay5Limit { get; set; }
        [Range(0.0f, 300.0f)]
        public float? RainDay6Limit { get; set; }
        [Range(0.0f, 300.0f)]
        public float? RainDay7Limit { get; set; }
        [Range(0.0f, 300.0f)]
        public float? RainDay8Limit { get; set; }
        [Range(0.0f, 300.0f)]
        public float? RainDay9Limit { get; set; }
        [Range(0.0f, 300.0f)]
        public float? RainDay10Limit { get; set; }
        public DateTime? IncludeRainStartDate { get; set; }
        public DateTime? IncludeRainEndDate { get; set; }
        [Range(0, 10)]
        public int? IncludeRainRunCount { get; set; }
        public bool? IncludeRainSelectFullYear { get; set; }
        public DateTime? NoRainStartDate { get; set; }
        public DateTime? NoRainEndDate { get; set; }
        [Range(0, 10)]
        public int? NoRainRunCount { get; set; }
        public bool? NoRainSelectFullYear { get; set; }
        public DateTime? OnlyRainStartDate { get; set; }
        public DateTime? OnlyRainEndDate { get; set; }
        [Range(0, 10)]
        public int? OnlyRainRunCount { get; set; }
        public bool? OnlyRainSelectFullYear { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual ICollection<MWQMSubsectorLanguage> MWQMSubsectorLanguages { get; set; }
        public virtual TVItem MWQMSubsectorTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MWQMSubsector()
        {
            MWQMSubsectorLanguages = new HashSet<MWQMSubsectorLanguage>();
        }
        #endregion Constructors

    }
}
