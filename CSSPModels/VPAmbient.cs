using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class VPAmbient
    {
        #region Properties in DB
        [Key]
        public int VPAmbientID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "VPScenario", Plurial = "s", FieldID = "VPScenarioID")]
        public int VPScenarioID { get; set; }
        [Range(0, 10)]
        public int Row { get; set; }
        [Range(0.0f, 1000.0f)]
        public float MeasurementDepth_m { get; set; }
        [Range(0.0f, 10.0f)]
        public float CurrentSpeed_m_s { get; set; }
        [Range(-180.0f, 180.0f)]
        public float CurrentDirection_deg { get; set; }
        [Range(0.0f, 40.0f)]
        public float AmbientSalinity_PSU { get; set; }
        [Range(-10.0f, 40.0f)]
        public float AmbientTemperature_C { get; set; }
        [Range(0, 10000000)]
        public int BackgroundConcentration_MPN_100ml { get; set; }
        [Range(0.0f, 100.0f)]
        public float PollutantDecayRate_per_day { get; set; }
        [Range(0.0f, 10.0f)]
        public float FarFieldCurrentSpeed_m_s { get; set; }
        [Range(-180.0f, 180.0f)]
        public float FarFieldCurrentDirection_deg { get; set; }
        [Range(0.0f, 1.0f)]
        public float FarFieldDiffusionCoefficient { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual VPScenario VPScenario { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public VPAmbient()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
