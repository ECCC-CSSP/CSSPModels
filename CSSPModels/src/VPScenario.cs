/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class VPScenario : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "VPScenario ID")]
        [CSSPDisplayFR(DisplayFR = "VPScenario ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the VPScenarios table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau VPScenarios")]
        public int VPScenarioID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "10")]
        public int InfrastructureTVItemID { get; set; }
        [CSSPEnumType]
        public ScenarioStatusEnum VPScenarioStatus { get; set; }
        public bool UseAsBestEstimate { get; set; }
        [Range(0.0D, 1000.0D)]
        public double? EffluentFlow_m3_s { get; set; }
        [Range(0, 10000000)]
        public int? EffluentConcentration_MPN_100ml { get; set; }
        [Range(0.0D, 10000.0D)]
        public double? FroudeNumber { get; set; }
        [Range(0.0D, 10.0D)]
        public double? PortDiameter_m { get; set; }
        [Range(0.0D, 1000.0D)]
        public double? PortDepth_m { get; set; }
        [Range(0.0D, 1000.0D)]
        public double? PortElevation_m { get; set; }
        [Range(-90.0D, 90.0D)]
        public double? VerticalAngle_deg { get; set; }
        [Range(-180.0D, 180.0D)]
        public double? HorizontalAngle_deg { get; set; }
        [Range(1, 100)]
        public int? NumberOfPorts { get; set; }
        [Range(0.0D, 1000.0D)]
        public double? PortSpacing_m { get; set; }
        [Range(0.0D, 100.0D)]
        public double? AcuteMixZone_m { get; set; }
        [Range(0.0D, 40000.0D)]
        public double? ChronicMixZone_m { get; set; }
        [Range(0.0D, 40.0D)]
        public double? EffluentSalinity_PSU { get; set; }
        [Range(-10.0D, 40.0D)]
        public double? EffluentTemperature_C { get; set; }
        [Range(0.0D, 100.0D)]
        public double? EffluentVelocity_m_s { get; set; }
        [CSSPAllowNull]
        public string RawResults { get; set; }
        #endregion Properties in DB

        #region Constructors
        public VPScenario() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class VPScenarioWeb : VPScenario
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "InfrastructureTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage SubsectorTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "ScenarioStatusEnum", EnumType = "VPScenarioStatus")]
        [CSSPAllowNull]
        public string VPScenarioStatusText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public VPScenarioWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class VPScenarioReport : VPScenarioWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string VPScenarioReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public VPScenarioReport() : base()
        {
        }
        #endregion Constructors
    }
}
