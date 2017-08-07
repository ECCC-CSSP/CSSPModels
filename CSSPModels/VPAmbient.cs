using CSSPEnums;
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
        [CSSPExist(ExistTypeName = "VPScenario", ExistPlurial = "s", ExistFieldID = "VPScenarioID")]
        public int VPScenarioID { get; set; }
        [Range(0, 10)]
        public int Row { get; set; }
        [Range(0.0D, 1000.0D)]
        public double MeasurementDepth_m { get; set; }
        [Range(0.0D, 10.0D)]
        public double CurrentSpeed_m_s { get; set; }
        [Range(-180.0D, 180.0D)]
        public double CurrentDirection_deg { get; set; }
        [Range(0.0D, 40.0D)]
        public double AmbientSalinity_PSU { get; set; }
        [Range(-10.0D, 40.0D)]
        public double AmbientTemperature_C { get; set; }
        [Range(0, 10000000)]
        public int BackgroundConcentration_MPN_100ml { get; set; }
        [Range(0.0D, 100.0D)]
        public double PollutantDecayRate_per_day { get; set; }
        [Range(0.0D, 10.0D)]
        public double FarFieldCurrentSpeed_m_s { get; set; }
        [Range(-180.0D, 180.0D)]
        public double FarFieldCurrentDirection_deg { get; set; }
        [Range(0.0D, 1.0D)]
        public double FarFieldDiffusionCoefficient { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int LastUpdateContactTVItemID { get; set; }
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
