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
        [Key]
        public int VPScenarioID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int InfrastructureTVItemID { get; set; }
        [CSSPEnumType]
        public ScenarioStatusEnum VPScenarioStatus { get; set; }
        public bool UseAsBestEstimate { get; set; }
        [Range(0.0f, 1000.0f)]
        public float EffluentFlow_m3_s { get; set; }
        [Range(0, 10000000)]
        public int EffluentConcentration_MPN_100ml { get; set; }
        [Range(0.0f, 10000.0f)]
        public float FroudeNumber { get; set; }
        [Range(0.0f, 10.0f)]
        public float PortDiameter_m { get; set; }
        [Range(0.0f, 1000.0f)]
        public float PortDepth_m { get; set; }
        [Range(0.0f, 1000.0f)]
        public float PortElevation_m { get; set; }
        [Range(-90.0f, 90.0f)]
        public float VerticalAngle_deg { get; set; }
        [Range(-180.0f, 180.0f)]
        public float HorizontalAngle_deg { get; set; }
        [Range(1, 100)]
        public int NumberOfPorts { get; set; }
        [Range(0.0f, 1000.0f)]
        public float PortSpacing_m { get; set; }
        [Range(0.0f, 100.0f)]
        public float AcuteMixZone_m { get; set; }
        [Range(0.0f, 40000.0f)]
        public float ChronicMixZone_m { get; set; }
        [Range(0.0f, 40.0f)]
        public float EffluentSalinity_PSU { get; set; }
        [Range(-10.0f, 40.0f)]
        public float EffluentTemperature_C { get; set; }
        [Range(0.0f, 100.0f)]
        public float EffluentVelocity_m_s { get; set; }
        public string RawResults { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
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
