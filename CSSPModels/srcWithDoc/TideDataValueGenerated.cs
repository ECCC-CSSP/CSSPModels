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
    /// > <para>**DB properties for table TideDataValues** : [TideDataValueID](CSSPModels.TideDataValue.html#CSSPModels_TideDataValue_TideDataValueID), [TideSiteTVItemID](CSSPModels.TideDataValue.html#CSSPModels_TideDataValue_TideSiteTVItemID), [DateTime_Local](CSSPModels.TideDataValue.html#CSSPModels_TideDataValue_DateTime_Local), [Keep](CSSPModels.TideDataValue.html#CSSPModels_TideDataValue_Keep), [TideDataType](CSSPModels.TideDataValue.html#CSSPModels_TideDataValue_TideDataType), [StorageDataType](CSSPModels.TideDataValue.html#CSSPModels_TideDataValue_StorageDataType), [Depth_m](CSSPModels.TideDataValue.html#CSSPModels_TideDataValue_Depth_m), [UVelocity_m_s](CSSPModels.TideDataValue.html#CSSPModels_TideDataValue_UVelocity_m_s), [VVelocity_m_s](CSSPModels.TideDataValue.html#CSSPModels_TideDataValue_VVelocity_m_s), [TideStart](CSSPModels.TideDataValue.html#CSSPModels_TideDataValue_TideStart), [TideEnd](CSSPModels.TideDataValue.html#CSSPModels_TideDataValue_TideEnd), [LastUpdate.LastUpdateDate_UTC](CSSPModels.LastUpdate.html#CSSPModels_LastUpdate_LastUpdateDate_UTC), [LastUpdate.LastUpdateContactTVItemID](CSSPModels.LastUpdate.html#CSSPModels_LastUpdate_LastUpdateContactTVItemID)</para>
    /// > <para>**Other properties** : [CSSPError.HasErrors](CSSPModels.CSSPError.html#CSSPModels_CSSPError_HasErrors), [CSSPError.ValidationResults](CSSPModels.CSSPError.html#CSSPModels_CSSPError_ValidationResults)</para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [TideDataValueService](CSSPServices.TideDataValueService.html)</para>
    /// > <para>**Used by [CSSPWebAPI.Controllers](CSSPWebAPI.Controllers.html)** : [TideDataValueController](CSSPWebAPI.Controllers.TideDataValueController.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [TideDataTypeEnum](CSSPEnums.TideDataTypeEnum.html), [StorageDataTypeEnum](CSSPEnums.StorageDataTypeEnum.html), [TideTextEnum](CSSPEnums.TideTextEnum.html), [TideTextEnum](CSSPEnums.TideTextEnum.html)</para>
    /// > <para>**Inherits [LastUpdate](CSSPModels.LastUpdate.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class TideDataValue : LastUpdate
    {
        #region Properties in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "TideDataValue ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "TideDataValue ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Contains the unique "identifier on each row of the TideDataValues table")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Contient l'identifiant unique sur chaque ligne de la table TideDataValues")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- TideDataValue ID
        /// 
        /// **Display (fr)** --- TideDataValue ID
        /// 
        /// **Description (en)** --- Contains the unique "identifier on each row of the TideDataValues table
        /// 
        /// **Description (fr)** --- Contient l'identifiant unique sur chaque ligne de la table TideDataValues
        /// </returns>
        [Key]
        [CSSPDisplayEN(DisplayEN = "TideDataValue ID")]
        [CSSPDisplayFR(DisplayFR = "TideDataValue ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the TideDataValues table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table TideDataValues")]
        public int TideDataValueID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>22 == TideSite</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "22")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Tide site")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Site de marée")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Link to the TVItems table representing the tide site")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Lien à la table TVItems représentant le site de marée")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Tide site
        /// 
        /// **Display (fr)** --- Site de marée
        /// 
        /// **Description (en)** --- Link to the TVItems table representing the tide site
        /// 
        /// **Description (fr)** --- Lien à la table TVItems représentant le site de marée
        /// </returns>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "22")]
        [CSSPDisplayEN(DisplayEN = "Tide site")]
        [CSSPDisplayFR(DisplayFR = "Site de marée")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the tide site")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant le site de marée")]
        public int TideSiteTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Date (local)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Date (local)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Date (local)")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Date (local)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Date (local)
        /// 
        /// **Display (fr)** --- Date (local)
        /// 
        /// **Description (en)** --- Date (local)
        /// 
        /// **Description (fr)** --- Date (local)
        /// </returns>
        [CSSPAfter(Year = 1980)]
        [CSSPDisplayEN(DisplayEN = "Date (local)")]
        [CSSPDisplayFR(DisplayFR = "Date (local)")]
        [CSSPDescriptionEN(DescriptionEN = @"Date (local)")]
        [CSSPDescriptionFR(DescriptionFR = @"Date (local)")]
        public DateTime DateTime_Local { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Keep")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Sauvegarder")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Keep")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Sauvegarder")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Keep
        /// 
        /// **Display (fr)** --- Sauvegarder
        /// 
        /// **Description (en)** --- Keep
        /// 
        /// **Description (fr)** --- Sauvegarder
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Keep")]
        [CSSPDisplayFR(DisplayFR = "Sauvegarder")]
        [CSSPDescriptionEN(DescriptionEN = @"Keep")]
        [CSSPDescriptionFR(DescriptionFR = @"Sauvegarder")]
        public bool Keep { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Tide data type")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Type de donnée de marée")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Tide data type")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Type de donnée de marée")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Tide data type
        /// 
        /// **Display (fr)** --- Type de donnée de marée
        /// 
        /// **Description (en)** --- Tide data type
        /// 
        /// **Description (fr)** --- Type de donnée de marée
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Tide data type")]
        [CSSPDisplayFR(DisplayFR = "Type de donnée de marée")]
        [CSSPDescriptionEN(DescriptionEN = @"Tide data type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type de donnée de marée")]
        public TideDataTypeEnum TideDataType { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Storage data type")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Type de sauvegarde des données")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Storage data type")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Type de sauvegarde des données")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Storage data type
        /// 
        /// **Display (fr)** --- Type de sauvegarde des données
        /// 
        /// **Description (en)** --- Storage data type
        /// 
        /// **Description (fr)** --- Type de sauvegarde des données
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Storage data type")]
        [CSSPDisplayFR(DisplayFR = "Type de sauvegarde des données")]
        [CSSPDescriptionEN(DescriptionEN = @"Storage data type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type de sauvegarde des données")]
        public StorageDataTypeEnum StorageDataType { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Depth (m)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Profondeur (m)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Depth in meters")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Profondeur en mètres")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Depth (m)
        /// 
        /// **Display (fr)** --- Profondeur (m)
        /// 
        /// **Description (en)** --- Depth in meters
        /// 
        /// **Description (fr)** --- Profondeur en mètres
        /// </returns>
        [Range(0.0D, 10000.0D)]
        [CSSPDisplayEN(DisplayEN = "Depth (m)")]
        [CSSPDisplayFR(DisplayFR = "Profondeur (m)")]
        [CSSPDescriptionEN(DescriptionEN = @"Depth in meters")]
        [CSSPDescriptionFR(DescriptionFR = @"Profondeur en mètres")]
        public double Depth_m { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "U velocity (m/s)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "U vélocité (m/s)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "U velocity in meters per second")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "U vélocité en mètres par second")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- U velocity (m/s)
        /// 
        /// **Display (fr)** --- U vélocité (m/s)
        /// 
        /// **Description (en)** --- U velocity in meters per second
        /// 
        /// **Description (fr)** --- U vélocité en mètres par second
        /// </returns>
        [Range(0.0D, 10.0D)]
        [CSSPDisplayEN(DisplayEN = "U velocity (m/s)")]
        [CSSPDisplayFR(DisplayFR = "U vélocité (m/s)")]
        [CSSPDescriptionEN(DescriptionEN = @"U velocity in meters per second")]
        [CSSPDescriptionFR(DescriptionFR = @"U vélocité en mètres par second")]
        public double UVelocity_m_s { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "V velocity (m/s)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "V vélocité (m/s)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "V velocity in meters per second")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "V vélocité en mètres par second")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- V velocity (m/s)
        /// 
        /// **Display (fr)** --- V vélocité (m/s)
        /// 
        /// **Description (en)** --- V velocity in meters per second
        /// 
        /// **Description (fr)** --- V vélocité en mètres par second
        /// </returns>
        [Range(0.0D, 10.0D)]
        [CSSPDisplayEN(DisplayEN = "V velocity (m/s)")]
        [CSSPDisplayFR(DisplayFR = "V vélocité (m/s)")]
        [CSSPDescriptionEN(DescriptionEN = @"V velocity in meters per second")]
        [CSSPDescriptionFR(DescriptionFR = @"V vélocité en mètres par second")]
        public double VVelocity_m_s { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Tide text start")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Tide text de départ")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Tide text start")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Tide text de départ")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Tide text start
        /// 
        /// **Display (fr)** --- Tide text de départ
        /// 
        /// **Description (en)** --- Tide text start
        /// 
        /// **Description (fr)** --- Tide text de départ
        /// </returns>
        [CSSPEnumType]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Tide text start")]
        [CSSPDisplayFR(DisplayFR = "Tide text de départ")]
        [CSSPDescriptionEN(DescriptionEN = @"Tide text start")]
        [CSSPDescriptionFR(DescriptionFR = @"Tide text de départ")]
        public TideTextEnum? TideStart { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Tide text end")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Tide text de fin")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Tide text end")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Tide text de fin")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Tide text end
        /// 
        /// **Display (fr)** --- Tide text de fin
        /// 
        /// **Description (en)** --- Tide text end
        /// 
        /// **Description (fr)** --- Tide text de fin
        /// </returns>
        [CSSPEnumType]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Tide text end")]
        [CSSPDisplayFR(DisplayFR = "Tide text de fin")]
        [CSSPDescriptionEN(DescriptionEN = @"Tide text end")]
        [CSSPDescriptionFR(DescriptionFR = @"Tide text de fin")]
        public TideTextEnum? TideEnd { get; set; }
        #endregion Properties in DB

        #region Constructors
        public TideDataValue() : base()
        {
        }
        #endregion Constructors
    }
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [TideSiteText](CSSPModels.TideDataValue.html#CSSPModels_TideDataValue_TideSiteText), [LastUpdateContactText](CSSPModels.TideDataValue.html#CSSPModels_TideDataValue_LastUpdateContactText), [TideDataTypeText](CSSPModels.TideDataValue.html#CSSPModels_TideDataValue_TideDataTypeText), [StorageDataTypeText](CSSPModels.TideDataValue.html#CSSPModels_TideDataValue_StorageDataTypeText), [TideStartText](CSSPModels.TideDataValue.html#CSSPModels_TideDataValue_TideStartText), [TideEndText](CSSPModels.TideDataValue.html#CSSPModels_TideDataValue_TideEndText)</para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [TideDataValueService](CSSPServices.TideDataValueService.html)</para>
    /// > <para>**Used by [CSSPWebAPI.Controllers](CSSPWebAPI.Controllers.html)** : [TideDataValueController](CSSPWebAPI.Controllers.TideDataValueController.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [TideDataTypeEnum](CSSPEnums.TideDataTypeEnum.html), [StorageDataTypeEnum](CSSPEnums.StorageDataTypeEnum.html), [TideTextEnum](CSSPEnums.TideTextEnum.html), [TideTextEnum](CSSPEnums.TideTextEnum.html)</para>
    /// > <para>**Inherits [TideDataValue](CSSPModels.TideDataValue.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class TideDataValueExtraA : TideDataValue
    {
        #region Properties
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TideSiteTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Tide site text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte du site de marée")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Tide site text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte du site de marée")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Tide site text
        /// 
        /// **Display (fr)** --- Texte du site de marée
        /// 
        /// **Description (en)** --- Tide site text
        /// 
        /// **Description (fr)** --- Texte du site de marée
        /// </returns>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TideSiteTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Tide site text")]
        [CSSPDisplayFR(DisplayFR = "Texte du site de marée")]
        [CSSPDescriptionEN(DescriptionEN = @"Tide site text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du site de marée")]
        public string TideSiteText { get; set; }
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
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TideDataTypeEnum", EnumType = "TideDataType")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Tide data type text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte du type de marée")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Tide data type text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte du type de marée")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Tide data type text
        /// 
        /// **Display (fr)** --- Texte du type de marée
        /// 
        /// **Description (en)** --- Tide data type text
        /// 
        /// **Description (fr)** --- Texte du type de marée
        /// </returns>
        [CSSPEnumTypeText(EnumTypeName = "TideDataTypeEnum", EnumType = "TideDataType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Tide data type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type de marée")]
        [CSSPDescriptionEN(DescriptionEN = @"Tide data type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type de marée")]
        public string TideDataTypeText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "StorageDataTypeEnum", EnumType = "StorageDataType")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Storage data type text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte du type de sauvegarde des données")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Storage data type text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte du type de sauvegarde des données")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Storage data type text
        /// 
        /// **Display (fr)** --- Texte du type de sauvegarde des données
        /// 
        /// **Description (en)** --- Storage data type text
        /// 
        /// **Description (fr)** --- Texte du type de sauvegarde des données
        /// </returns>
        [CSSPEnumTypeText(EnumTypeName = "StorageDataTypeEnum", EnumType = "StorageDataType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Storage data type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type de sauvegarde des données")]
        [CSSPDescriptionEN(DescriptionEN = @"Storage data type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type de sauvegarde des données")]
        public string StorageDataTypeText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TideTextEnum", EnumType = "TideStart")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Tide text start")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte des marées de début")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Tide text start")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte des marées de début")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Tide text start
        /// 
        /// **Display (fr)** --- Texte des marées de début
        /// 
        /// **Description (en)** --- Tide text start
        /// 
        /// **Description (fr)** --- Texte des marées de début
        /// </returns>
        [CSSPEnumTypeText(EnumTypeName = "TideTextEnum", EnumType = "TideStart")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Tide text start")]
        [CSSPDisplayFR(DisplayFR = "Texte des marées de début")]
        [CSSPDescriptionEN(DescriptionEN = @"Tide text start")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte des marées de début")]
        public string TideStartText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TideTextEnum", EnumType = "TideEnd")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Tide text end")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte des marées de fin")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Tide text end")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte des marées de fin")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Tide text end
        /// 
        /// **Display (fr)** --- Texte des marées de fin
        /// 
        /// **Description (en)** --- Tide text end
        /// 
        /// **Description (fr)** --- Texte des marées de fin
        /// </returns>
        [CSSPEnumTypeText(EnumTypeName = "TideTextEnum", EnumType = "TideEnd")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Tide text end")]
        [CSSPDisplayFR(DisplayFR = "Texte des marées de fin")]
        [CSSPDescriptionEN(DescriptionEN = @"Tide text end")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte des marées de fin")]
        public string TideEndText { get; set; }
        #endregion Properties

        #region Constructors
        public TideDataValueExtraA() : base()
        {
        }
        #endregion Constructors
    }
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [TideDataValueReportTest](CSSPModels.TideDataValue.html#CSSPModels_TideDataValue_TideDataValueReportTest)</para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [TideDataValueService](CSSPServices.TideDataValueService.html)</para>
    /// > <para>**Used by [CSSPWebAPI.Controllers](CSSPWebAPI.Controllers.html)** : [TideDataValueController](CSSPWebAPI.Controllers.TideDataValueController.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [TideDataTypeEnum](CSSPEnums.TideDataTypeEnum.html), [StorageDataTypeEnum](CSSPEnums.StorageDataTypeEnum.html), [TideTextEnum](CSSPEnums.TideTextEnum.html), [TideTextEnum](CSSPEnums.TideTextEnum.html)</para>
    /// > <para>**Inherits [TideDataValueExtraA](CSSPModels.TideDataValueExtraA.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class TideDataValueExtraB : TideDataValueExtraA
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
        public string TideDataValueReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public TideDataValueExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
