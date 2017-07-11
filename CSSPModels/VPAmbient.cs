using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class VPAmbient
    {
        #region Properties in DB
        public int VPAmbientID { get; set; }
        public int VPScenarioID { get; set; }
        public int Row { get; set; }
        public float MeasurementDepth_m { get; set; }
        public float CurrentSpeed_m_s { get; set; }
        public float CurrentDirection_deg { get; set; }
        public float AmbientSalinity_PSU { get; set; }
        public float AmbientTemperature_C { get; set; }
        public int BackgroundConcentration_MPN_100ml { get; set; }
        public float PollutantDecayRate_per_day { get; set; }
        public float FarFieldCurrentSpeed_m_s { get; set; }
        public float FarFieldCurrentDirection_deg { get; set; }
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
