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
    /// > <para>**DB properties for table BoxModels** : [BoxModelID](CSSPModels.BoxModel.html#CSSPModels_BoxModel_BoxModelID), [InfrastructureTVItemID](CSSPModels.BoxModel.html#CSSPModels_BoxModel_InfrastructureTVItemID), [Discharge_m3_day](CSSPModels.BoxModel.html#CSSPModels_BoxModel_Discharge_m3_day), [Depth_m](CSSPModels.BoxModel.html#CSSPModels_BoxModel_Depth_m), [Temperature_C](CSSPModels.BoxModel.html#CSSPModels_BoxModel_Temperature_C), [Dilution](CSSPModels.BoxModel.html#CSSPModels_BoxModel_Dilution), [DecayRate_per_day](CSSPModels.BoxModel.html#CSSPModels_BoxModel_DecayRate_per_day), [FCUntreated_MPN_100ml](CSSPModels.BoxModel.html#CSSPModels_BoxModel_FCUntreated_MPN_100ml), [FCPreDisinfection_MPN_100ml](CSSPModels.BoxModel.html#CSSPModels_BoxModel_FCPreDisinfection_MPN_100ml), [Concentration_MPN_100ml](CSSPModels.BoxModel.html#CSSPModels_BoxModel_Concentration_MPN_100ml), [T90_hour](CSSPModels.BoxModel.html#CSSPModels_BoxModel_T90_hour), [DischargeDuration_hour](CSSPModels.BoxModel.html#CSSPModels_BoxModel_DischargeDuration_hour), [LastUpdate.LastUpdateDate_UTC](CSSPModels.LastUpdate.html#CSSPModels_LastUpdate_LastUpdateDate_UTC), [LastUpdate.LastUpdateContactTVItemID](CSSPModels.LastUpdate.html#CSSPModels_LastUpdate_LastUpdateContactTVItemID)</para>
    /// > <para>**Other properties** : [CSSPError.HasErrors](CSSPModels.CSSPError.html#CSSPModels_CSSPError_HasErrors), [CSSPError.ValidationResults](CSSPModels.CSSPError.html#CSSPModels_CSSPError_ValidationResults)</para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [BoxModelService](CSSPServices.BoxModelService.html)</para>
    /// > <para>**Used by [CSSPWebAPI.Controllers](CSSPWebAPI.Controllers.html)** : [BoxModelController](CSSPWebAPI.Controllers.BoxModelController.html)</para>
    /// > <para>**Inherits [LastUpdate](CSSPModels.LastUpdate.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class BoxModel : LastUpdate
    {
        #region Properties in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "BoxModel ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "BoxModel ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Contains the unique "identifier on each row of the BoxModels table")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Contient l'identifiant unique sur chaque ligne de la table BoxModels")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- BoxModel ID
        /// 
        /// **Display (fr)** --- BoxModel ID
        /// 
        /// **Description (en)** --- Contains the unique "identifier on each row of the BoxModels table
        /// 
        /// **Description (fr)** --- Contient l'identifiant unique sur chaque ligne de la table BoxModels
        /// </returns>
        [Key]
        [CSSPDisplayEN(DisplayEN = "BoxModel ID")]
        [CSSPDisplayFR(DisplayFR = "BoxModel ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the BoxModels table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table BoxModels")]
        public int BoxModelID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>10 == Infrastructure</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "10")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Infrastructure")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Infrastructure")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Link to the TVItems table representing the infrastructure")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Lien à la table TVItems représentant la infrastructure")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Infrastructure
        /// 
        /// **Display (fr)** --- Infrastructure
        /// 
        /// **Description (en)** --- Link to the TVItems table representing the infrastructure
        /// 
        /// **Description (fr)** --- Lien à la table TVItems représentant la infrastructure
        /// </returns>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "10")]
        [CSSPDisplayEN(DisplayEN = "Infrastructure")]
        [CSSPDisplayFR(DisplayFR = "Infrastructure")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the infrastructure")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant la infrastructure")]
        public int InfrastructureTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Discharge (m3/d)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Débit (m3/j)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Discharge (m3/d) spilled by the infrastructure")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Débit (m3/d) déversé par l' infrastructure")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Discharge (m3/d)
        /// 
        /// **Display (fr)** --- Débit (m3/j)
        /// 
        /// **Description (en)** --- Discharge (m3/d) spilled by the infrastructure
        /// 
        /// **Description (fr)** --- Débit (m3/d) déversé par l' infrastructure
        /// </returns>
        [Range(0.0D, 10000.0D)]
        [CSSPDisplayEN(DisplayEN = "Discharge (m3/d)")]
        [CSSPDisplayFR(DisplayFR = "Débit (m3/j)")]
        [CSSPDescriptionEN(DescriptionEN = @"Discharge (m3/d) spilled by the infrastructure")]
        [CSSPDescriptionFR(DescriptionFR = @"Débit (m3/d) déversé par l' infrastructure")]
        public double Discharge_m3_day { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Depth (m)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Profondeur (m)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Average depth (m) of water in the vicinity of the spill")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Profondeur moyenne (m) des eaux aux environs du déversement")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Depth (m)
        /// 
        /// **Display (fr)** --- Profondeur (m)
        /// 
        /// **Description (en)** --- Average depth (m) of water in the vicinity of the spill
        /// 
        /// **Description (fr)** --- Profondeur moyenne (m) des eaux aux environs du déversement
        /// </returns>
        [Range(0.0D, 1000.0D)]
        [CSSPDisplayEN(DisplayEN = "Depth (m)")]
        [CSSPDisplayFR(DisplayFR = "Profondeur (m)")]
        [CSSPDescriptionEN(DescriptionEN = @"Average depth (m) of water in the vicinity of the spill")]
        [CSSPDescriptionFR(DescriptionFR = @"Profondeur moyenne (m) des eaux aux environs du déversement")]
        public double Depth_m { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Temperature (deg C)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Température (dég C)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Temperature (deg C) of water in the vicinity of the spill")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Température (deg C) des eaux aux environs du déversement")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Temperature (deg C)
        /// 
        /// **Display (fr)** --- Température (dég C)
        /// 
        /// **Description (en)** --- Temperature (deg C) of water in the vicinity of the spill
        /// 
        /// **Description (fr)** --- Température (deg C) des eaux aux environs du déversement
        /// </returns>
        [Range(-15.0D, 40.0D)]
        [CSSPDisplayEN(DisplayEN = "Temperature (deg C)")]
        [CSSPDisplayFR(DisplayFR = "Température (dég C)")]
        [CSSPDescriptionEN(DescriptionEN = @"Temperature (deg C) of water in the vicinity of the spill")]
        [CSSPDescriptionFR(DescriptionFR = @"Température (deg C) des eaux aux environs du déversement")]
        public double Temperature_C { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Dilution (MPN / 100 mL)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Dilution (NPP / 100 mL)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Dilution (MPN / 100 mL) level to uptain in the vicinity of the spill")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Niveau de dilution (NPP / 100 mL) à obtenir aux environs du déversement")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Dilution (MPN / 100 mL)
        /// 
        /// **Display (fr)** --- Dilution (NPP / 100 mL)
        /// 
        /// **Description (en)** --- Dilution (MPN / 100 mL) level to uptain in the vicinity of the spill
        /// 
        /// **Description (fr)** --- Niveau de dilution (NPP / 100 mL) à obtenir aux environs du déversement
        /// </returns>
        [Range(0, 10000000)]
        [CSSPDisplayEN(DisplayEN = "Dilution (MPN / 100 mL)")]
        [CSSPDisplayFR(DisplayFR = "Dilution (NPP / 100 mL)")]
        [CSSPDescriptionEN(DescriptionEN = @"Dilution (MPN / 100 mL) level to uptain in the vicinity of the spill")]
        [CSSPDescriptionFR(DescriptionFR = @"Niveau de dilution (NPP / 100 mL) à obtenir aux environs du déversement")]
        public int Dilution { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Decay rate (/day)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Taux de décroissance (/jour)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Average decay rate (/day) of the fecal coliform colonies")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Taux de décroissance moyen (/jour) des colonies de coliform fécaux")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Decay rate (/day)
        /// 
        /// **Display (fr)** --- Taux de décroissance (/jour)
        /// 
        /// **Description (en)** --- Average decay rate (/day) of the fecal coliform colonies
        /// 
        /// **Description (fr)** --- Taux de décroissance moyen (/jour) des colonies de coliform fécaux
        /// </returns>
        [Range(0.0D, 100.0D)]
        [CSSPDisplayEN(DisplayEN = "Decay rate (/day)")]
        [CSSPDisplayFR(DisplayFR = "Taux de décroissance (/jour)")]
        [CSSPDescriptionEN(DescriptionEN = @"Average decay rate (/day) of the fecal coliform colonies")]
        [CSSPDescriptionFR(DescriptionFR = @"Taux de décroissance moyen (/jour) des colonies de coliform fécaux")]
        public double DecayRate_per_day { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Fecal coliform concentration of untreaded waste water (MPN / 100 mL)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Concentration de coliform fécaux des eaux usées non traité (NPP / 100 mL)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Fecal coliform concentration of untreaded waste water (MPN / 100 mL)")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Concentration de coliform fécaux des eaux usées non traité (NPP / 100 mL)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Fecal coliform concentration of untreaded waste water (MPN / 100 mL)
        /// 
        /// **Display (fr)** --- Concentration de coliform fécaux des eaux usées non traité (NPP / 100 mL)
        /// 
        /// **Description (en)** --- Fecal coliform concentration of untreaded waste water (MPN / 100 mL)
        /// 
        /// **Description (fr)** --- Concentration de coliform fécaux des eaux usées non traité (NPP / 100 mL)
        /// </returns>
        [Range(0, 10000000)]
        [CSSPDisplayEN(DisplayEN = "Fecal coliform concentration of untreaded waste water (MPN / 100 mL)")]
        [CSSPDisplayFR(DisplayFR = "Concentration de coliform fécaux des eaux usées non traité (NPP / 100 mL)")]
        [CSSPDescriptionEN(DescriptionEN = @"Fecal coliform concentration of untreaded waste water (MPN / 100 mL)")]
        [CSSPDescriptionFR(DescriptionFR = @"Concentration de coliform fécaux des eaux usées non traité (NPP / 100 mL)")]
        public int FCUntreated_MPN_100ml { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Fecal coliform concentration of pre-disinfected waste water (MPN / 100 mL)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Concentration de coliform fécaux des eaux usées pré-désinfecté (NPP / 100 mL)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Fecal coliform concentration of pre-disinfected waste water (MPN / 100 mL)")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Concentration de coliform fécaux des eaux usées pré-désinfecté (NPP / 100 mL)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Fecal coliform concentration of pre-disinfected waste water (MPN / 100 mL)
        /// 
        /// **Display (fr)** --- Concentration de coliform fécaux des eaux usées pré-désinfecté (NPP / 100 mL)
        /// 
        /// **Description (en)** --- Fecal coliform concentration of pre-disinfected waste water (MPN / 100 mL)
        /// 
        /// **Description (fr)** --- Concentration de coliform fécaux des eaux usées pré-désinfecté (NPP / 100 mL)
        /// </returns>
        [Range(0, 10000000)]
        [CSSPDisplayEN(DisplayEN = "Fecal coliform concentration of pre-disinfected waste water (MPN / 100 mL)")]
        [CSSPDisplayFR(DisplayFR = "Concentration de coliform fécaux des eaux usées pré-désinfecté (NPP / 100 mL)")]
        [CSSPDescriptionEN(DescriptionEN = @"Fecal coliform concentration of pre-disinfected waste water (MPN / 100 mL)")]
        [CSSPDescriptionFR(DescriptionFR = @"Concentration de coliform fécaux des eaux usées pré-désinfecté (NPP / 100 mL)")]
        public int FCPreDisinfection_MPN_100ml { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Fecal coliform concentration objective after dilution (MPN / 100 mL)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Objectif de concentration de coliform fécaux apres dilution (NPP / 100 mL)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Fecal coliform concentration objective after dilution (MPN / 100 mL)")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Objectif de concentration de coliform fécaux apres dilution (NPP / 100 mL)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Fecal coliform concentration objective after dilution (MPN / 100 mL)
        /// 
        /// **Display (fr)** --- Objectif de concentration de coliform fécaux apres dilution (NPP / 100 mL)
        /// 
        /// **Description (en)** --- Fecal coliform concentration objective after dilution (MPN / 100 mL)
        /// 
        /// **Description (fr)** --- Objectif de concentration de coliform fécaux apres dilution (NPP / 100 mL)
        /// </returns>
        [Range(0, 10000000)]
        [CSSPDisplayEN(DisplayEN = "Fecal coliform concentration objective after dilution (MPN / 100 mL)")]
        [CSSPDisplayFR(DisplayFR = "Objectif de concentration de coliform fécaux apres dilution (NPP / 100 mL)")]
        [CSSPDescriptionEN(DescriptionEN = @"Fecal coliform concentration objective after dilution (MPN / 100 mL)")]
        [CSSPDescriptionFR(DescriptionFR = @"Objectif de concentration de coliform fécaux apres dilution (NPP / 100 mL)")]
        public int Concentration_MPN_100ml { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "T90 (hour)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "T90 (heur)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Time (hour) required for 90 % of the fecal coliform colonies to die off")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Temps (heur) requis pour que 90% des colonies de coliformes fécaux meurent")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- T90 (hour)
        /// 
        /// **Display (fr)** --- T90 (heur)
        /// 
        /// **Description (en)** --- Time (hour) required for 90 % of the fecal coliform colonies to die off
        /// 
        /// **Description (fr)** --- Temps (heur) requis pour que 90% des colonies de coliformes fécaux meurent
        /// </returns>
        [Range(0.0D, -1.0D)]
        [CSSPDisplayEN(DisplayEN = "T90 (hour)")]
        [CSSPDisplayFR(DisplayFR = "T90 (heur)")]
        [CSSPDescriptionEN(DescriptionEN = @"Time (hour) required for 90 % of the fecal coliform colonies to die off")]
        [CSSPDescriptionFR(DescriptionFR = @"Temps (heur) requis pour que 90% des colonies de coliformes fécaux meurent")]
        public double T90_hour { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Discharge duration (hour/day)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Durée de l'écoulement (heur/jour)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Discharge duration (hour/day)")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Durée de l'écoulement (heur/jour)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Discharge duration (hour/day)
        /// 
        /// **Display (fr)** --- Durée de l'écoulement (heur/jour)
        /// 
        /// **Description (en)** --- Discharge duration (hour/day)
        /// 
        /// **Description (fr)** --- Durée de l'écoulement (heur/jour)
        /// </returns>
        [Range(0.0D, 24.0D)]
        [CSSPDisplayEN(DisplayEN = "Discharge duration (hour/day)")]
        [CSSPDisplayFR(DisplayFR = "Durée de l'écoulement (heur/jour)")]
        [CSSPDescriptionEN(DescriptionEN = @"Discharge duration (hour/day)")]
        [CSSPDescriptionFR(DescriptionFR = @"Durée de l'écoulement (heur/jour)")]
        public double DischargeDuration_hour { get; set; }
        #endregion Properties in DB

        #region Constructors
        public BoxModel() : base()
        {
        }
        #endregion Constructors
    }
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [InfrastructureText](CSSPModels.BoxModel.html#CSSPModels_BoxModel_InfrastructureText), [LastUpdateContactText](CSSPModels.BoxModel.html#CSSPModels_BoxModel_LastUpdateContactText)</para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [BoxModelService](CSSPServices.BoxModelService.html)</para>
    /// > <para>**Used by [CSSPWebAPI.Controllers](CSSPWebAPI.Controllers.html)** : [BoxModelController](CSSPWebAPI.Controllers.BoxModelController.html)</para>
    /// > <para>**Inherits [BoxModel](CSSPModels.BoxModel.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class BoxModelExtraA : BoxModel
    {
        #region Properties
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "InfrastructureTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Infrastructure TVItemLanguage")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "TVItemLanguage de l'infrastructure")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Infrastructure TVItemLanguage DB object")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Object BD TVItemLanguage de l'infrastructure")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Infrastructure TVItemLanguage
        /// 
        /// **Display (fr)** --- TVItemLanguage de l'infrastructure
        /// 
        /// **Description (en)** --- Infrastructure TVItemLanguage DB object
        /// 
        /// **Description (fr)** --- Object BD TVItemLanguage de l'infrastructure
        /// </returns>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "InfrastructureTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Infrastructure TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage de l'infrastructure")]
        [CSSPDescriptionEN(DescriptionEN = @"Infrastructure TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage de l'infrastructure")]
        public string InfrastructureText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Last update contact name")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Nom du contact ayant fait le dernière changement")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Last update contact name")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Nom du contact ayant fait le dernière changement")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Last update contact name
        /// 
        /// **Display (fr)** --- Nom du contact ayant fait le dernière changement
        /// 
        /// **Description (en)** --- Last update contact name
        /// 
        /// **Description (fr)** --- Nom du contact ayant fait le dernière changement
        /// </returns>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact ayant fait le dernière changement")]
        public string LastUpdateContactText { get; set; }
        #endregion Properties

        #region Constructors
        public BoxModelExtraA() : base()
        {
        }
        #endregion Constructors
    }
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [BoxModelReportTest](CSSPModels.BoxModel.html#CSSPModels_BoxModel_BoxModelReportTest)</para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [BoxModelService](CSSPServices.BoxModelService.html)</para>
    /// > <para>**Used by [CSSPWebAPI.Controllers](CSSPWebAPI.Controllers.html)** : [BoxModelController](CSSPWebAPI.Controllers.BoxModelController.html)</para>
    /// > <para>**Inherits [BoxModelExtraA](CSSPModels.BoxModelExtraA.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class BoxModelExtraB : BoxModelExtraA
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
        public string BoxModelReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public BoxModelExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
