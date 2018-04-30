using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MWQMAnalysisReportParameter : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MWQMAnalysisReportParameter ID")]
        [CSSPDisplayFR(DisplayFR = "MWQMAnalysisReportParameter ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MWQMAnalysisReportParameters table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau MWQMAnalysisReportParameters")]
        public int MWQMAnalysisReportParameterID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]
        public int SubsectorTVItemID { get; set; }
        [StringLength(250, MinimumLength = 5)]
        public string AnalysisName { get; set; }
        [Range(1980, 2050)]
        public int? AnalysisReportYear { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime StartDate { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPBigger(OtherField = "StartDate")]
        public DateTime EndDate { get; set; }
        [CSSPEnumType]
        public AnalysisCalculationTypeEnum AnalysisCalculationType { get; set; }
        [Range(1, 1000)]
        public int NumberOfRuns { get; set; }
        public bool FullYear { get; set; }
        [Range(1.0D, 20.0D)]
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
        [StringLength(250)]
        public string RunsToOmit { get; set; }
        [StringLength(20)]
        [CSSPAllowNull]
        public string ShowDataTypes { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "8")]
        public int? ExcelTVFileTVItemID { get; set; }
        [CSSPEnumType]
        public AnalysisReportExportCommandEnum Command { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public MWQMAnalysisReportParameterWeb MWQMAnalysisReportParameterWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public MWQMAnalysisReportParameterReport MWQMAnalysisReportParameterReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MWQMAnalysisReportParameter() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMAnalysisReportParameterWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ExcelTVFileTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string ExcelTVFileTVText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "AnalysisReportExportCommandEnum", EnumType = "Command")]
        [CSSPAllowNull]
        public string CommandText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public MWQMAnalysisReportParameterWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMAnalysisReportParameterReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string MWQMAnalysisReportParameterReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public MWQMAnalysisReportParameterReport()
        {
        }
        #endregion Constructors
    }
}
