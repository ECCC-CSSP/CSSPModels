using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MWQMAnalysisReportParameter
    {
        #region Properties in DB
        [Key]
        public int MWQMAnalysisReportParameterID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID")]
        public int MWQMSubsectorTVItemID { get; set; }
        [StringLength(250, MinimumLength = 5)]
        public string Name { get; set; }
        [Range(1980, 2050)]
        public int AnalysisReportYear { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime StartDate_Local { get; set; }
        [CSSPBigger(OtherField = "StartDate_Local")]
        [CSSPAfter(Year = 1980)]
        public DateTime EndDate_Local { get; set; }
        [CSSPEnumType]
        public AnalysisCalculationTypeEnum AnalysisCalculationType { get; set; }
        [Range(1, 1000)]
        public int NumberOfRuns { get; set; }
        public bool FullYear { get; set; }
        [Range(1.0f, 20.0f)]
        public double SalinityHighlightDeviationFromAverage { get; set; }
        [Range(0, 5)]
        public int ShortRangeNumberOfDays { get; set; }
        [Range(2, 7)]
        public int MidRangeNumberOfDays { get; set; }
        [Range(1, 100)]
        public int DryLimit24h { get; set; }
        [Range(1, 100)]
        public int DryLimit48h { get; set; }
        [Range(1, 100)]
        public int DryLimit72h { get; set; }
        [Range(1, 100)]
        public int DryLimit96h { get; set; }
        [Range(1, 100)]
        public int WetLimit24h { get; set; }
        [Range(1, 100)]
        public int WetLimit48h { get; set; }
        [Range(1, 100)]
        public int WetLimit72h { get; set; }
        [Range(1, 100)]
        public int WetLimit96h { get; set; }
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
        public bool HasErrors { get; set; }
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MWQMAnalysisReportParameter()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
