/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
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
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Infrastructure TVItemID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Infrastructure TVItemID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Link to the TVItems table representing the infrastructure")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Lien à la table TVItems représentant l'infrastructure")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Infrastructure TVItemID
        /// 
        /// **Display (fr)** --- Infrastructure TVItemID
        /// 
        /// **Description (en)** --- Link to the TVItems table representing the infrastructure
        /// 
        /// **Description (fr)** --- Lien à la table TVItems représentant l'infrastructure
        /// </returns>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "10")]
        [CSSPDisplayEN(DisplayEN = "Infrastructure TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Infrastructure TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the infrastructure")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant l'infrastructure")]
        public int InfrastructureTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "VP scenario status")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "État du scénario VP")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Visual plumes scenario status")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "État du scénario visual plumes")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- VP scenario status
        /// 
        /// **Display (fr)** --- État du scénario VP
        /// 
        /// **Description (en)** --- Visual plumes scenario status
        /// 
        /// **Description (fr)** --- État du scénario visual plumes
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "VP scenario status")]
        [CSSPDisplayFR(DisplayFR = "État du scénario VP")]
        [CSSPDescriptionEN(DescriptionEN = @"Visual plumes scenario status")]
        [CSSPDescriptionFR(DescriptionFR = @"État du scénario visual plumes")]
        public ScenarioStatusEnum VPScenarioStatus { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Use as best estimate")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Utilise comme meilleur estimation")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Use as best estimate")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Utilise comme meilleur estimation")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Use as best estimate
        /// 
        /// **Display (fr)** --- Utilise comme meilleur estimation
        /// 
        /// **Description (en)** --- Use as best estimate
        /// 
        /// **Description (fr)** --- Utilise comme meilleur estimation
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Use as best estimate")]
        [CSSPDisplayFR(DisplayFR = "Utilise comme meilleur estimation")]
        [CSSPDescriptionEN(DescriptionEN = @"Use as best estimate")]
        [CSSPDescriptionFR(DescriptionFR = @"Utilise comme meilleur estimation")]
        public bool UseAsBestEstimate { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Effluent flow (m3/s)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Débit de l'effluent (m3/s)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Effluent flow in cubic meters per second")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Débit de l'effluent en mètres cube par second")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Effluent flow (m3/s)
        /// 
        /// **Display (fr)** --- Débit de l'effluent (m3/s)
        /// 
        /// **Description (en)** --- Effluent flow in cubic meters per second
        /// 
        /// **Description (fr)** --- Débit de l'effluent en mètres cube par second
        /// </returns>
        [Range(0.0D, 1000.0D)]
        [CSSPDisplayEN(DisplayEN = "Effluent flow (m3/s)")]
        [CSSPDisplayFR(DisplayFR = "Débit de l'effluent (m3/s)")]
        [CSSPDescriptionEN(DescriptionEN = @"Effluent flow in cubic meters per second")]
        [CSSPDescriptionFR(DescriptionFR = @"Débit de l'effluent en mètres cube par second")]
        public double? EffluentFlow_m3_s { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Effluent concentration (MPN / 100 mL)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Concentration de l'effluent (NPP / 100 mL)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Effluent concentration in most probable number per 100 milli-Litres")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Concentration de l'effluent en nombre le plus probable par 100 milli-Litres")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Effluent concentration (MPN / 100 mL)
        /// 
        /// **Display (fr)** --- Concentration de l'effluent (NPP / 100 mL)
        /// 
        /// **Description (en)** --- Effluent concentration in most probable number per 100 milli-Litres
        /// 
        /// **Description (fr)** --- Concentration de l'effluent en nombre le plus probable par 100 milli-Litres
        /// </returns>
        [Range(0, 10000000)]
        [CSSPDisplayEN(DisplayEN = "Effluent concentration (MPN / 100 mL)")]
        [CSSPDisplayFR(DisplayFR = "Concentration de l'effluent (NPP / 100 mL)")]
        [CSSPDescriptionEN(DescriptionEN = @"Effluent concentration in most probable number per 100 milli-Litres")]
        [CSSPDescriptionFR(DescriptionFR = @"Concentration de l'effluent en nombre le plus probable par 100 milli-Litres")]
        public int? EffluentConcentration_MPN_100ml { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Froude number")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Nombre de Froude")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Froude number")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Nombre de Froude")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Froude number
        /// 
        /// **Display (fr)** --- Nombre de Froude
        /// 
        /// **Description (en)** --- Froude number
        /// 
        /// **Description (fr)** --- Nombre de Froude
        /// </returns>
        [Range(0.0D, 10000.0D)]
        [CSSPDisplayEN(DisplayEN = "Froude number")]
        [CSSPDisplayFR(DisplayFR = "Nombre de Froude")]
        [CSSPDescriptionEN(DescriptionEN = @"Froude number")]
        [CSSPDescriptionFR(DescriptionFR = @"Nombre de Froude")]
        public double? FroudeNumber { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Port diameter (m)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Diamètre de l'orifice (m)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Port diameter in meters")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Diamètre de l'orifice en mètres")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Port diameter (m)
        /// 
        /// **Display (fr)** --- Diamètre de l'orifice (m)
        /// 
        /// **Description (en)** --- Port diameter in meters
        /// 
        /// **Description (fr)** --- Diamètre de l'orifice en mètres
        /// </returns>
        [Range(0.0D, 10.0D)]
        [CSSPDisplayEN(DisplayEN = "Port diameter (m)")]
        [CSSPDisplayFR(DisplayFR = "Diamètre de l'orifice (m)")]
        [CSSPDescriptionEN(DescriptionEN = @"Port diameter in meters")]
        [CSSPDescriptionFR(DescriptionFR = @"Diamètre de l'orifice en mètres")]
        public double? PortDiameter_m { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Port depth (m)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Profondeur de l'orifice (m)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Port depth in meters")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Profondeur de l'orifice en mètres")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Port depth (m)
        /// 
        /// **Display (fr)** --- Profondeur de l'orifice (m)
        /// 
        /// **Description (en)** --- Port depth in meters
        /// 
        /// **Description (fr)** --- Profondeur de l'orifice en mètres
        /// </returns>
        [Range(0.0D, 1000.0D)]
        [CSSPDisplayEN(DisplayEN = "Port depth (m)")]
        [CSSPDisplayFR(DisplayFR = "Profondeur de l'orifice (m)")]
        [CSSPDescriptionEN(DescriptionEN = @"Port depth in meters")]
        [CSSPDescriptionFR(DescriptionFR = @"Profondeur de l'orifice en mètres")]
        public double? PortDepth_m { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Port elevation (m)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Élévation de l'orifice (m)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Port elevation in meters")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Élévation de l'orifice en mètres")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Port elevation (m)
        /// 
        /// **Display (fr)** --- Élévation de l'orifice (m)
        /// 
        /// **Description (en)** --- Port elevation in meters
        /// 
        /// **Description (fr)** --- Élévation de l'orifice en mètres
        /// </returns>
        [Range(0.0D, 1000.0D)]
        [CSSPDisplayEN(DisplayEN = "Port elevation (m)")]
        [CSSPDisplayFR(DisplayFR = "Élévation de l'orifice (m)")]
        [CSSPDescriptionEN(DescriptionEN = @"Port elevation in meters")]
        [CSSPDescriptionFR(DescriptionFR = @"Élévation de l'orifice en mètres")]
        public double? PortElevation_m { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Vertical angle (deg)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Angle vertical (deg)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Vertical angle in degree")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Angle vertical en dégré")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Vertical angle (deg)
        /// 
        /// **Display (fr)** --- Angle vertical (deg)
        /// 
        /// **Description (en)** --- Vertical angle in degree
        /// 
        /// **Description (fr)** --- Angle vertical en dégré
        /// </returns>
        [Range(-90.0D, 90.0D)]
        [CSSPDisplayEN(DisplayEN = "Vertical angle (deg)")]
        [CSSPDisplayFR(DisplayFR = "Angle vertical (deg)")]
        [CSSPDescriptionEN(DescriptionEN = @"Vertical angle in degree")]
        [CSSPDescriptionFR(DescriptionFR = @"Angle vertical en dégré")]
        public double? VerticalAngle_deg { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Horizontal angle (deg)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Angle horizontal (deg)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Horizontal angle in degree")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Angle horizontal en dégré")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Horizontal angle (deg)
        /// 
        /// **Display (fr)** --- Angle horizontal (deg)
        /// 
        /// **Description (en)** --- Horizontal angle in degree
        /// 
        /// **Description (fr)** --- Angle horizontal en dégré
        /// </returns>
        [Range(-180.0D, 180.0D)]
        [CSSPDisplayEN(DisplayEN = "Horizontal angle (deg)")]
        [CSSPDisplayFR(DisplayFR = "Angle horizontal (deg)")]
        [CSSPDescriptionEN(DescriptionEN = @"Horizontal angle in degree")]
        [CSSPDescriptionFR(DescriptionFR = @"Angle horizontal en dégré")]
        public double? HorizontalAngle_deg { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Number of ports")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Nombre d'orifice")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Number of ports")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Nombre d'orifice")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Number of ports
        /// 
        /// **Display (fr)** --- Nombre d'orifice
        /// 
        /// **Description (en)** --- Number of ports
        /// 
        /// **Description (fr)** --- Nombre d'orifice
        /// </returns>
        [Range(1, 100)]
        [CSSPDisplayEN(DisplayEN = "Number of ports")]
        [CSSPDisplayFR(DisplayFR = "Nombre d'orifice")]
        [CSSPDescriptionEN(DescriptionEN = @"Number of ports")]
        [CSSPDescriptionFR(DescriptionFR = @"Nombre d'orifice")]
        public int? NumberOfPorts { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Port spacing (m)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Distance entre les orifices (m)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Port spacing in meters")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Distance entre les orifices en mètres")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Port spacing (m)
        /// 
        /// **Display (fr)** --- Distance entre les orifices (m)
        /// 
        /// **Description (en)** --- Port spacing in meters
        /// 
        /// **Description (fr)** --- Distance entre les orifices en mètres
        /// </returns>
        [Range(0.0D, 1000.0D)]
        [CSSPDisplayEN(DisplayEN = "Port spacing (m)")]
        [CSSPDisplayFR(DisplayFR = "Distance entre les orifices (m)")]
        [CSSPDescriptionEN(DescriptionEN = @"Port spacing in meters")]
        [CSSPDescriptionFR(DescriptionFR = @"Distance entre les orifices en mètres")]
        public double? PortSpacing_m { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Acute mix zone (m)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Zone de pollution aigüe (m)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Acute mix zone in meters")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Zone de pollution aigüe en mètres")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Acute mix zone (m)
        /// 
        /// **Display (fr)** --- Zone de pollution aigüe (m)
        /// 
        /// **Description (en)** --- Acute mix zone in meters
        /// 
        /// **Description (fr)** --- Zone de pollution aigüe en mètres
        /// </returns>
        [Range(0.0D, 100.0D)]
        [CSSPDisplayEN(DisplayEN = "Acute mix zone (m)")]
        [CSSPDisplayFR(DisplayFR = "Zone de pollution aigüe (m)")]
        [CSSPDescriptionEN(DescriptionEN = @"Acute mix zone in meters")]
        [CSSPDescriptionFR(DescriptionFR = @"Zone de pollution aigüe en mètres")]
        public double? AcuteMixZone_m { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Chronic mix zone (m)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Zone de pollution chronique (m)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Chronic mix zone in meters")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Zone de pollution chronique en mètres")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Chronic mix zone (m)
        /// 
        /// **Display (fr)** --- Zone de pollution chronique (m)
        /// 
        /// **Description (en)** --- Chronic mix zone in meters
        /// 
        /// **Description (fr)** --- Zone de pollution chronique en mètres
        /// </returns>
        [Range(0.0D, 40000.0D)]
        [CSSPDisplayEN(DisplayEN = "Chronic mix zone (m)")]
        [CSSPDisplayFR(DisplayFR = "Zone de pollution chronique (m)")]
        [CSSPDescriptionEN(DescriptionEN = @"Chronic mix zone in meters")]
        [CSSPDescriptionFR(DescriptionFR = @"Zone de pollution chronique en mètres")]
        public double? ChronicMixZone_m { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Effluent salinity (PSU)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Salinité de l'effluent (PSU)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Effluent salinity in PSU")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Salinité de l'effluent en PSU")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Effluent salinity (PSU)
        /// 
        /// **Display (fr)** --- Salinité de l'effluent (PSU)
        /// 
        /// **Description (en)** --- Effluent salinity in PSU
        /// 
        /// **Description (fr)** --- Salinité de l'effluent en PSU
        /// </returns>
        [Range(0.0D, 40.0D)]
        [CSSPDisplayEN(DisplayEN = "Effluent salinity (PSU)")]
        [CSSPDisplayFR(DisplayFR = "Salinité de l'effluent (PSU)")]
        [CSSPDescriptionEN(DescriptionEN = @"Effluent salinity in PSU")]
        [CSSPDescriptionFR(DescriptionFR = @"Salinité de l'effluent en PSU")]
        public double? EffluentSalinity_PSU { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Effluent temperature (°C)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Température de l'effluent (°C)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Effluent temperature in degree Celcius")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Température de l'effluent en dégré Celcius")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Effluent temperature (°C)
        /// 
        /// **Display (fr)** --- Température de l'effluent (°C)
        /// 
        /// **Description (en)** --- Effluent temperature in degree Celcius
        /// 
        /// **Description (fr)** --- Température de l'effluent en dégré Celcius
        /// </returns>
        [Range(-10.0D, 40.0D)]
        [CSSPDisplayEN(DisplayEN = "Effluent temperature (°C)")]
        [CSSPDisplayFR(DisplayFR = "Température de l'effluent (°C)")]
        [CSSPDescriptionEN(DescriptionEN = @"Effluent temperature in degree Celcius")]
        [CSSPDescriptionFR(DescriptionFR = @"Température de l'effluent en dégré Celcius")]
        public double? EffluentTemperature_C { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Effluent velocity (m/s)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Vitesse de l'effluent (m/s)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Effluent velocity in meters per second")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Vitesse de l'effluent en mètres par second")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Effluent velocity (m/s)
        /// 
        /// **Display (fr)** --- Vitesse de l'effluent (m/s)
        /// 
        /// **Description (en)** --- Effluent velocity in meters per second
        /// 
        /// **Description (fr)** --- Vitesse de l'effluent en mètres par second
        /// </returns>
        [Range(0.0D, 100.0D)]
        [CSSPDisplayEN(DisplayEN = "Effluent velocity (m/s)")]
        [CSSPDisplayFR(DisplayFR = "Vitesse de l'effluent (m/s)")]
        [CSSPDescriptionEN(DescriptionEN = @"Effluent velocity in meters per second")]
        [CSSPDescriptionFR(DescriptionFR = @"Vitesse de l'effluent en mètres par second")]
        public double? EffluentVelocity_m_s { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Raw results")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Résultats bruts")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Raw results")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Résultats bruts")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Raw results
        /// 
        /// **Display (fr)** --- Résultats bruts
        /// 
        /// **Description (en)** --- Raw results
        /// 
        /// **Description (fr)** --- Résultats bruts
        /// </returns>
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Raw results")]
        [CSSPDisplayFR(DisplayFR = "Résultats bruts")]
        [CSSPDescriptionEN(DescriptionEN = @"Raw results")]
        [CSSPDescriptionFR(DescriptionFR = @"Résultats bruts")]
        public string RawResults { get; set; }
        #endregion Properties in DB

        #region Constructors
        public VPScenario() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class VPScenarioExtraA : VPScenario
    {
        #region Properties
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "InfrastructureTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Subsector TVItemLanguage")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "TVItemLanguage du sous-secteur")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Subsector TVItemLanguage DB object")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Object BD TVItemLanguage du sous-secteur")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Subsector TVItemLanguage
        /// 
        /// **Display (fr)** --- TVItemLanguage du sous-secteur
        /// 
        /// **Description (en)** --- Subsector TVItemLanguage DB object
        /// 
        /// **Description (fr)** --- Object BD TVItemLanguage du sous-secteur
        /// </returns>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "InfrastructureTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Subsector TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du sous-secteur")]
        [CSSPDescriptionEN(DescriptionEN = @"Subsector TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du sous-secteur")]
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
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "VP scenario status text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte de l'état du scénario VP")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Visual plumes scenario status text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte de l'état du scénario visual plumes")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- VP scenario status text
        /// 
        /// **Display (fr)** --- Texte de l'état du scénario VP
        /// 
        /// **Description (en)** --- Visual plumes scenario status text
        /// 
        /// **Description (fr)** --- Texte de l'état du scénario visual plumes
        /// </returns>
        [CSSPEnumTypeText(EnumTypeName = "ScenarioStatusEnum", EnumType = "VPScenarioStatus")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "VP scenario status text")]
        [CSSPDisplayFR(DisplayFR = "Texte de l'état du scénario VP")]
        [CSSPDescriptionEN(DescriptionEN = @"Visual plumes scenario status text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de l'état du scénario visual plumes")]
        public string VPScenarioStatusText { get; set; }
        #endregion Properties

        #region Constructors
        public VPScenarioExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class VPScenarioExtraB : VPScenarioExtraA
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
        public VPScenarioExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
