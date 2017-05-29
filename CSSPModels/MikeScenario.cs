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
        public int MikeScenarioID { get; set; }
        public int MikeScenarioTVItemID { get; set; }
        public int? ParentMikeScenarioID { get; set; }
        public ScenarioStatusEnum ScenarioStatus { get; set; }
        public string ErrorInfo { get; set; }
        public DateTime MikeScenarioStartDateTime_Local { get; set; }
        public DateTime MikeScenarioEndDateTime_Local { get; set; }
        public DateTime? MikeScenarioStartExecutionDateTime_Local { get; set; }
        public float? MikeScenarioExecutionTime_min { get; set; }
        public float WindSpeed_km_h { get; set; }
        public float WindDirection_deg { get; set; }
        public float DecayFactor_per_day { get; set; }
        public bool DecayIsConstant { get; set; }
        public float DecayFactorAmplitude { get; set; }
        public int ResultFrequency_min { get; set; }
        public float AmbientTemperature_C { get; set; }
        public float AmbientSalinity_PSU { get; set; }
        public float ManningNumber { get; set; }
        public bool? UseWebTide { get; set; }
        public int? NumberOfElements { get; set; }
        public int? NumberOfTimeSteps { get; set; }
        public int? NumberOfSigmaLayers { get; set; }
        public int? NumberOfZlayers { get; set; }
        public int? NumberOfHydroOutputParameters { get; set; }
        public int? NumberOfTransOutputParameters { get; set; }
        public long? EstimatedHydroFileSize { get; set; }
        public long? EstimatedTransFileSize { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
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
