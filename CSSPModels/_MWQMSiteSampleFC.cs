using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class MWQMSiteSampleFC
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public string Error { get; set; }
        [Required]
        public DateTime SampleDate { get; set; }
        [Range(1, 100000000)]
        public int? FC { get; set; }
        public float? Sal { get; set; }
        public float? Temp { get; set; }
        public float? PH { get; set; }
        public float? DO { get; set; }
        public float? Depth { get; set; }
        public int? SampCount { get; set; }
        public int? MinFC { get; set; }
        public int? MaxFC { get; set; }
        public float? GeoMean { get; set; }
        public float? Median { get; set; }
        public float? P90 { get; set; }
        public float? PercOver43 { get; set; }
        public float? PercOver260 { get; set; }

        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MWQMSiteSampleFC()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
