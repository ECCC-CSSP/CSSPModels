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
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int MikeScenarioTVItemID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int? ParentMikeScenarioID { get; set; }
        [CSSPEnumType]
        public ScenarioStatusEnum ScenarioStatus { get; set; }
        public string ErrorInfo { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime MikeScenarioStartDateTime_Local { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime MikeScenarioEndDateTime_Local { get; set; }
        public DateTime? MikeScenarioStartExecutionDateTime_Local { get; set; }
        [Range(1.0f, 100000.0f)]
        public float? MikeScenarioExecutionTime_min { get; set; }
        [Range(0.0f, 100.0f)]
        public float WindSpeed_km_h { get; set; }
        [Range(0.0f, 360.0f)]
        public float WindDirection_deg { get; set; }
        [Range(0.0f, 100.0f)]
        public float DecayFactor_per_day { get; set; }
        public bool DecayIsConstant { get; set; }
        [Range(0.0f, 100.0f)]
        public float DecayFactorAmplitude { get; set; }
        [Range(0, 100)]
        public int ResultFrequency_min { get; set; }
        [Range(-10.0f, 40.0f)]
        public float AmbientTemperature_C { get; set; }
        [Range(0.0f, 40.0f)]
        public float AmbientSalinity_PSU { get; set; }
        [Range(0.0f, 100.0f)]
        public float ManningNumber { get; set; }
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
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual TVItem MikeScenarioTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
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
