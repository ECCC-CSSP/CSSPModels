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
        [CSSPAfter(Year = 1980)]
        public DateTime SampleDate { get; set; }
        [Range(1, 100000000)]
        public int? FC { get; set; }
        public double? Sal { get; set; }
        public double? Temp { get; set; }
        public double? PH { get; set; }
        public double? DO { get; set; }
        public double? Depth { get; set; }
        public int? SampCount { get; set; }
        public int? MinFC { get; set; }
        public int? MaxFC { get; set; }
        public double? GeoMean { get; set; }
        public double? Median { get; set; }
        public double? P90 { get; set; }
        public double? PercOver43 { get; set; }
        public double? PercOver260 { get; set; }
        public bool HasErrors { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MWQMSiteSampleFC()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
