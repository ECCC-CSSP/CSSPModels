/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 July 27 04:56
 * by leblancc on WMON01DTCHLEBL2 machine
 *
 */ 
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**DB properties for table VPScenarios** : [VPScenarioID](CSSPModels.VPScenario.html#CSSPModels_VPScenario_VPScenarioID), [InfrastructureTVItemID](CSSPModels.VPScenario.html#CSSPModels_VPScenario_InfrastructureTVItemID), [VPScenarioStatus](CSSPModels.VPScenario.html#CSSPModels_VPScenario_VPScenarioStatus), [UseAsBestEstimate](CSSPModels.VPScenario.html#CSSPModels_VPScenario_UseAsBestEstimate), [EffluentFlow_m3_s](CSSPModels.VPScenario.html#CSSPModels_VPScenario_EffluentFlow_m3_s), [EffluentConcentration_MPN_100ml](CSSPModels.VPScenario.html#CSSPModels_VPScenario_EffluentConcentration_MPN_100ml), [FroudeNumber](CSSPModels.VPScenario.html#CSSPModels_VPScenario_FroudeNumber), [PortDiameter_m](CSSPModels.VPScenario.html#CSSPModels_VPScenario_PortDiameter_m), [PortDepth_m](CSSPModels.VPScenario.html#CSSPModels_VPScenario_PortDepth_m), [PortElevation_m](CSSPModels.VPScenario.html#CSSPModels_VPScenario_PortElevation_m), [VerticalAngle_deg](CSSPModels.VPScenario.html#CSSPModels_VPScenario_VerticalAngle_deg), [HorizontalAngle_deg](CSSPModels.VPScenario.html#CSSPModels_VPScenario_HorizontalAngle_deg), [NumberOfPorts](CSSPModels.VPScenario.html#CSSPModels_VPScenario_NumberOfPorts), [PortSpacing_m](CSSPModels.VPScenario.html#CSSPModels_VPScenario_PortSpacing_m), [AcuteMixZone_m](CSSPModels.VPScenario.html#CSSPModels_VPScenario_AcuteMixZone_m), [ChronicMixZone_m](CSSPModels.VPScenario.html#CSSPModels_VPScenario_ChronicMixZone_m), [EffluentSalinity_PSU](CSSPModels.VPScenario.html#CSSPModels_VPScenario_EffluentSalinity_PSU), [EffluentTemperature_C](CSSPModels.VPScenario.html#CSSPModels_VPScenario_EffluentTemperature_C), [EffluentVelocity_m_s](CSSPModels.VPScenario.html#CSSPModels_VPScenario_EffluentVelocity_m_s), [RawResults](CSSPModels.VPScenario.html#CSSPModels_VPScenario_RawResults), [LastUpdateDate_UTC](CSSPModels.VPScenario.html#CSSPModels_VPScenario_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.VPScenario.html#CSSPModels_VPScenario_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [VPScenarioWeb](CSSPModels.VPScenario.html#CSSPModels_VPScenario_VPScenarioWeb), [VPScenarioReport](CSSPModels.VPScenario.html#CSSPModels_VPScenario_VPScenarioReport), [HasErrors](CSSPModels.VPScenario.html#CSSPModels_VPScenario_HasErrors), [ValidationResults](CSSPModels.VPScenario.html#CSSPModels_VPScenario_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [VPScenarioService](CSSPServices.VPScenarioService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [ScenarioStatusEnum](CSSPEnums.ScenarioStatusEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class VPScenario : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "VPScenario ID")]
        [CSSPDisplayFR(DisplayFR = "VPScenario ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the VPScenarios table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau VPScenarios")]
        public int VPScenarioID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>10 == Infrastructure</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "10")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "10")]
        public int InfrastructureTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
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
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string RawResults { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public VPScenarioWeb VPScenarioWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public VPScenarioReport VPScenarioReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public VPScenario() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class VPScenarioWeb
    {
        #region Properties for web information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "InfrastructureTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "InfrastructureTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string SubsectorTVText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "ScenarioStatusEnum", EnumType = "VPScenarioStatus")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "ScenarioStatusEnum", EnumType = "VPScenarioStatus")]
        [CSSPAllowNull]
        public string VPScenarioStatusText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public VPScenarioWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class VPScenarioReport
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string VPScenarioReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public VPScenarioReport()
        {
        }
        #endregion Constructors
    }
}