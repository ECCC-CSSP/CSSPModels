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
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Infrastructure)]
        public int InfrastructureTVItemID { get; set; }
        [CSSPEnumType]
        public ScenarioStatusEnum VPScenarioStatus { get; set; }
        public bool UseAsBestEstimate { get; set; }
        [Range(0.0D, 1000.0D)]
        public double EffluentFlow_m3_s { get; set; }
        [Range(0, 10000000)]
        public int EffluentConcentration_MPN_100ml { get; set; }
        [Range(0.0D, 10000.0D)]
        public double FroudeNumber { get; set; }
        [Range(0.0D, 10.0D)]
        public double PortDiameter_m { get; set; }
        [Range(0.0D, 1000.0D)]
        public double PortDepth_m { get; set; }
        [Range(0.0D, 1000.0D)]
        public double PortElevation_m { get; set; }
        [Range(-90.0D, 90.0D)]
        public double VerticalAngle_deg { get; set; }
        [Range(-180.0D, 180.0D)]
        public double HorizontalAngle_deg { get; set; }
        [Range(1, 100)]
        public int NumberOfPorts { get; set; }
        [Range(0.0D, 1000.0D)]
        public double PortSpacing_m { get; set; }
        [Range(0.0D, 100.0D)]
        public double AcuteMixZone_m { get; set; }
        [Range(0.0D, 40000.0D)]
        public double ChronicMixZone_m { get; set; }
        [Range(0.0D, 40.0D)]
        public double EffluentSalinity_PSU { get; set; }
        [Range(-10.0D, 40.0D)]
        public double EffluentTemperature_C { get; set; }
        [Range(0.0D, 100.0D)]
        public double EffluentVelocity_m_s { get; set; }
        [CSSPAllowNull]
        public string RawResults { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Contact)]
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
