using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MikeScenario
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
        [Range(1, 10000)]
        public int? NumberOfElements { get; set; }
        [Range(1, 10000)]
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
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MikeScenarioTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string MikeScenarioTVText { get; set; }
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string LastUpdateContactTVText { get; set; }
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "ScenarioStatusEnum", EnumType = "ScenarioStatus")]
        public string ScenarioStatusText { get; set; }
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MikeScenario()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
