using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    /// <summary>
    ///     Entity object for CSSPModels.VPScenarios DB Table
    /// </summary>
    public partial class VPScenario
    {
        #region Properties in DB
        [Key]
        public int VPScenarioID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "10")]
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
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "InfrastructureTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string SubsectorTVText { get; set; }
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string LastUpdateContactTVText { get; set; }
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "ScenarioStatusEnum", EnumType = "VPScenarioStatus")]
        public string VPScenarioStatusText { get; set; }
        [NotMapped]
        public bool HasErrors { get; set; }
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public VPScenario()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
