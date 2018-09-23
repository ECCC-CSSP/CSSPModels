/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by Charles on CHARLES-PC machine
 *
 */ 
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CSSPModels
{
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**DB properties for table VPScenarios** : [VPScenarioID](CSSPModels.VPScenario.html#CSSPModels_VPScenario_VPScenarioID), [InfrastructureTVItemID](CSSPModels.VPScenario.html#CSSPModels_VPScenario_InfrastructureTVItemID), [VPScenarioStatus](CSSPModels.VPScenario.html#CSSPModels_VPScenario_VPScenarioStatus), [UseAsBestEstimate](CSSPModels.VPScenario.html#CSSPModels_VPScenario_UseAsBestEstimate), [EffluentFlow_m3_s](CSSPModels.VPScenario.html#CSSPModels_VPScenario_EffluentFlow_m3_s), [EffluentConcentration_MPN_100ml](CSSPModels.VPScenario.html#CSSPModels_VPScenario_EffluentConcentration_MPN_100ml), [FroudeNumber](CSSPModels.VPScenario.html#CSSPModels_VPScenario_FroudeNumber), [PortDiameter_m](CSSPModels.VPScenario.html#CSSPModels_VPScenario_PortDiameter_m), [PortDepth_m](CSSPModels.VPScenario.html#CSSPModels_VPScenario_PortDepth_m), [PortElevation_m](CSSPModels.VPScenario.html#CSSPModels_VPScenario_PortElevation_m), [VerticalAngle_deg](CSSPModels.VPScenario.html#CSSPModels_VPScenario_VerticalAngle_deg), [HorizontalAngle_deg](CSSPModels.VPScenario.html#CSSPModels_VPScenario_HorizontalAngle_deg), [NumberOfPorts](CSSPModels.VPScenario.html#CSSPModels_VPScenario_NumberOfPorts), [PortSpacing_m](CSSPModels.VPScenario.html#CSSPModels_VPScenario_PortSpacing_m), [AcuteMixZone_m](CSSPModels.VPScenario.html#CSSPModels_VPScenario_AcuteMixZone_m), [ChronicMixZone_m](CSSPModels.VPScenario.html#CSSPModels_VPScenario_ChronicMixZone_m), [EffluentSalinity_PSU](CSSPModels.VPScenario.html#CSSPModels_VPScenario_EffluentSalinity_PSU), [EffluentTemperature_C](CSSPModels.VPScenario.html#CSSPModels_VPScenario_EffluentTemperature_C), [EffluentVelocity_m_s](CSSPModels.VPScenario.html#CSSPModels_VPScenario_EffluentVelocity_m_s), [RawResults](CSSPModels.VPScenario.html#CSSPModels_VPScenario_RawResults), [LastUpdateDate_UTC](CSSPModels.VPScenario.html#CSSPModels_VPScenario_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.VPScenario.html#CSSPModels_VPScenario_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.VPScenario.html#CSSPModels_VPScenario_HasErrors), [ValidationResults](CSSPModels.VPScenario.html#CSSPModels_VPScenario_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [VPScenarioService](CSSPServices.VPScenarioService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [ScenarioStatusEnum](CSSPEnums.ScenarioStatusEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class VPScenario : LastUpdate
    {
        #region Properties in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "VPScenario ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "VPScenario ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Contains the unique "identifier on each row of the VPScenarios table")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Contient l'identifiant unique sur chaque ligne de la table VPScenarios")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- VPScenario ID
        /// 
        /// **Display (fr)** --- VPScenario ID
        /// 
        /// **Description (en)** --- Contains the unique "identifier on each row of the VPScenarios table
        /// 
        /// **Description (fr)** --- Contient l'identifiant unique sur chaque ligne de la table VPScenarios
        /// </returns>
        [Key]
        [CSSPDisplayEN(DisplayEN = "VPScenario ID")]
        [CSSPDisplayFR(DisplayFR = "VPScenario ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the VPScenarios table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table VPScenarios")]
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

        #region Constructors
        public VPScenario() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class VPScenario_A : VPScenario
    {
        #region Properties
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "InfrastructureTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "InfrastructureTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        public TVItemLanguage SubsectorTVItemLanguage { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Last update contact TVItemLanguage")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Last update contact TVItemLanguage DB object")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Object BD TVItemLanguage du contact ayant fait le dernière changement")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Last update contact TVItemLanguage
        /// 
        /// **Display (fr)** --- TVItemLanguage du contact ayant fait le dernière changement
        /// 
        /// **Description (en)** --- Last update contact TVItemLanguage DB object
        /// 
        /// **Description (fr)** --- Object BD TVItemLanguage du contact ayant fait le dernière changement
        /// </returns>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "ScenarioStatusEnum", EnumType = "VPScenarioStatus")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "ScenarioStatusEnum", EnumType = "VPScenarioStatus")]
        [CSSPAllowNull]
        public string VPScenarioStatusText { get; set; }
        #endregion Properties

        #region Constructors
        public VPScenario_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class VPScenario_B : VPScenario_A
    {
        #region Properties
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Report test")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Test report")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Report test description")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Description de test report")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Report test
        /// 
        /// **Display (fr)** --- Test report
        /// 
        /// **Description (en)** --- Report test description
        /// 
        /// **Description (fr)** --- Description de test report
        /// </returns>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string VPScenarioReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public VPScenario_B() : base()
        {
        }
        #endregion Constructors
    }
}
