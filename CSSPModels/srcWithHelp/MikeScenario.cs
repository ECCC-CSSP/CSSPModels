using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MikeScenario : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int MikeScenarioID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "13")]
        public int MikeScenarioTVItemID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "13")]
        public int? ParentMikeScenarioID { get; set; }
        [CSSPEnumType]
        public ScenarioStatusEnum ScenarioStatus { get; set; }
        [CSSPAllowNull]
        public string ErrorInfo { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime MikeScenarioStartDateTime_Local { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime MikeScenarioEndDateTime_Local { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? MikeScenarioStartExecutionDateTime_Local { get; set; }
        [Range(1.0D, 100000.0D)]
        public double? MikeScenarioExecutionTime_min { get; set; }
        [Range(0.0D, 100.0D)]
        public double WindSpeed_km_h { get; set; }
        [Range(0.0D, 360.0D)]
        public double WindDirection_deg { get; set; }
        [Range(0.0D, 100.0D)]
        public double DecayFactor_per_day { get; set; }
        public bool DecayIsConstant { get; set; }
        [Range(0.0D, 100.0D)]
        public double DecayFactorAmplitude { get; set; }
        [Range(0, 100)]
        public int ResultFrequency_min { get; set; }
        [Range(-10.0D, 40.0D)]
        public double AmbientTemperature_C { get; set; }
        [Range(0.0D, 40.0D)]
        public double AmbientSalinity_PSU { get; set; }
        [Range(0.0D, 100.0D)]
        public double ManningNumber { get; set; }
        [Range(1, 1000000)]
        public int? NumberOfElements { get; set; }
        [Range(1, 1000000)]
        public int? NumberOfTimeSteps { get; set; }
        [Range(0, 100)]
        public int? NumberOfSigmaLayers { get; set; }
        [Range(0, 100)]
        public int? NumberOfZLayers { get; set; }
        [Range(0, 100)]
        public int? NumberOfHydroOutputParameters { get; set; }
        [Range(0, 100)]
        public int? NumberOfTransOutputParameters { get; set; }
        [Range(0, 100000000)]
        public long? EstimatedHydroFileSize { get; set; }
        [Range(0, 100000000)]
        public long? EstimatedTransFileSize { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public MikeScenarioWeb MikeScenarioWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public MikeScenarioReport MikeScenarioReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MikeScenario() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MikeScenarioWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MikeScenarioTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string MikeScenarioTVText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "ScenarioStatusEnum", EnumType = "ScenarioStatus")]
        [CSSPAllowNull]
        public string ScenarioStatusText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public MikeScenarioWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MikeScenarioReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string MikeScenarioReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public MikeScenarioReport()
        {
        }
        #endregion Constructors
    }
}
