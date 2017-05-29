using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MWQMSubsector
    {
        #region Properties in DB
        public int MWQMSubsectorID { get; set; }
        public int MWQMSubsectorTVItemID { get; set; }
        public string SubsectorHistoricKey { get; set; }
        public string TideLocationSIDText { get; set; }
        public float? RainDay0Limit { get; set; }
        public float? RainDay1Limit { get; set; }
        public float? RainDay2Limit { get; set; }
        public float? RainDay3Limit { get; set; }
        public float? RainDay4Limit { get; set; }
        public float? RainDay5Limit { get; set; }
        public float? RainDay6Limit { get; set; }
        public float? RainDay7Limit { get; set; }
        public float? RainDay8Limit { get; set; }
        public float? RainDay9Limit { get; set; }
        public float? RainDay10Limit { get; set; }
        public DateTime? IncludeRainStartDate { get; set; }
        public DateTime? IncludeRainEndDate { get; set; }
        public int? IncludeRainRunCount { get; set; }
        public bool? IncludeRainSelectFullYear { get; set; }
        public DateTime? NoRainStartDate { get; set; }
        public DateTime? NoRainEndDate { get; set; }
        public int? NoRainRunCount { get; set; }
        public bool? NoRainSelectFullYear { get; set; }
        public DateTime? OnlyRainStartDate { get; set; }
        public DateTime? OnlyRainEndDate { get; set; }
        public int? OnlyRainRunCount { get; set; }
        public bool? OnlyRainSelectFullYear { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
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
