using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class VPScenario
    {
        #region Properties in DB
        public int VPScenarioID { get; set; }
        public int InfrastructureTVItemID { get; set; }
        public ScenarioStatusEnum VPScenarioStatus { get; set; }
        public bool UseAsBestEstimate { get; set; }
        public float EffluentFlow_m3_s { get; set; }
        public int EffluentConcentration_MPN_100ml { get; set; }
        public float FroudeNumber { get; set; }
        public float PortDiameter_m { get; set; }
        public float PortDepth_m { get; set; }
        public float PortElevation_m { get; set; }
        public float VerticalAngle_deg { get; set; }
        public float HorizontalAngle_deg { get; set; }
        public int NumberOfPorts { get; set; }
        public float PortSpacing_m { get; set; }
        public float AcuteMixZone_m { get; set; }
        public float ChronicMixZone_m { get; set; }
        public float EffluentSalinity_PSU { get; set; }
        public float EffluentTemperature_C { get; set; }
        public float EffluentVelocity_m_s { get; set; }
        public string RawResults { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual ICollection<VPAmbient> VPAmbients { get; set; }
        public virtual ICollection<VPResult> VPResults { get; set; }
        public virtual ICollection<VPScenarioLanguage> VPScenarioLanguages { get; set; }
        public virtual TVItem InfrastructureTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public VPScenario()
        {
            VPAmbients = new HashSet<VPAmbient>();
            VPResults = new HashSet<VPResult>();
            VPScenarioLanguages = new HashSet<VPScenarioLanguage>();
        }
        #endregion Constructors

    }
}
