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
    /// > <para>**DB properties for table HydrometricDataValues** : [HydrometricDataValueID](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_HydrometricDataValueID), [HydrometricSiteID](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_HydrometricSiteID), [DateTime_Local](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_DateTime_Local), [Keep](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_Keep), [StorageDataType](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_StorageDataType), [HasBeenRead](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_HasBeenRead), [Discharge_m3_s](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_Discharge_m3_s), [DischargeEntered_m3_s](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_DischargeEntered_m3_s), [Level_m](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_Level_m), [HourlyValues](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_HourlyValues), [LastUpdateDate_UTC](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_HasErrors), [ValidationResults](CSSPModels.HydrometricDataValue.html#CSSPModels_HydrometricDataValue_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [HydrometricDataValueService](CSSPServices.HydrometricDataValueService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [StorageDataTypeEnum](CSSPEnums.StorageDataTypeEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class HydrometricDataValue : LastUpdate
    {
        #region Properties in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "HydrometricDataValue ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "HydrometricDataValue ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Contains the unique "identifier on each row of the HydrometricDataValues table")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Contient l'identifiant unique sur chaque ligne de la table HydrometricDataValues")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- HydrometricDataValue ID
        /// 
        /// **Display (fr)** --- HydrometricDataValue ID
        /// 
        /// **Description (en)** --- Contains the unique "identifier on each row of the HydrometricDataValues table
        /// 
        /// **Description (fr)** --- Contient l'identifiant unique sur chaque ligne de la table HydrometricDataValues
        /// </returns>
        [Key]
        [CSSPDisplayEN(DisplayEN = "HydrometricDataValue ID")]
        [CSSPDisplayFR(DisplayFR = "HydrometricDataValue ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the HydrometricDataValues table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table HydrometricDataValues")]
        public int HydrometricDataValueID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "HydrometricSite", ExistPlurial = "s", ExistFieldID = "HydrometricSiteID")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "HydrometricSite link")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Lien HydrometricSite")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "HydrometricSite link to parent HydrometricSites table item")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Lien au parent CydrometricSite à l'item de la table HydrometricSites")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- HydrometricSite link
        /// 
        /// **Display (fr)** --- Lien HydrometricSite
        /// 
        /// **Description (en)** --- HydrometricSite link to parent HydrometricSites table item
        /// 
        /// **Description (fr)** --- Lien au parent CydrometricSite à l'item de la table HydrometricSites
        /// </returns>
        [CSSPExist(ExistTypeName = "HydrometricSite", ExistPlurial = "s", ExistFieldID = "HydrometricSiteID")]
        [CSSPDisplayEN(DisplayEN = "HydrometricSite link")]
        [CSSPDisplayFR(DisplayFR = "Lien HydrometricSite")]
        [CSSPDescriptionEN(DescriptionEN = @"HydrometricSite link to parent HydrometricSites table item")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien au parent CydrometricSite à l'item de la table HydrometricSites")]
        public int HydrometricSiteID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Date and time of observation")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Date et temps de l'observation")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Date and time of observation. Almost all data is coming from the water office web site.")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Date et temps de l'observation. Pratiquement tous les données proviennent de site web water office")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Date and time of observation
        /// 
        /// **Display (fr)** --- Date et temps de l'observation
        /// 
        /// **Description (en)** --- Date and time of observation. Almost all data is coming from the water office web site.
        /// 
        /// **Description (fr)** --- Date et temps de l'observation. Pratiquement tous les données proviennent de site web water office
        /// </returns>
        [CSSPAfter(Year = 1980)]
        [CSSPDisplayEN(DisplayEN = "Date and time of observation")]
        [CSSPDisplayFR(DisplayFR = "Date et temps de l'observation")]
        [CSSPDescriptionEN(DescriptionEN = @"Date and time of observation. Almost all data is coming from the water office web site.")]
        [CSSPDescriptionFR(DescriptionFR = @"Date et temps de l'observation. Pratiquement tous les données proviennent de site web water office")]
        public DateTime DateTime_Local { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Keep")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Garder")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Keep the data within the database. Sometime the database might get some data from the water office web site as temporary data which can be removed at a later date")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Conservez les données dans la base de données. Parfois, la base de données peut obtenir des données du site Web du bureau hydrométrique en tant que données temporaires pouvant être supprimées ultérieurement.")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Keep
        /// 
        /// **Display (fr)** --- Garder
        /// 
        /// **Description (en)** --- Keep the data within the database. Sometime the database might get some data from the water office web site as temporary data which can be removed at a later date
        /// 
        /// **Description (fr)** --- Conservez les données dans la base de données. Parfois, la base de données peut obtenir des données du site Web du bureau hydrométrique en tant que données temporaires pouvant être supprimées ultérieurement.
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Keep")]
        [CSSPDisplayFR(DisplayFR = "Garder")]
        [CSSPDescriptionEN(DescriptionEN = @"Keep the data within the database. Sometime the database might get some data from the water office web site as temporary data which can be removed at a later date")]
        [CSSPDescriptionFR(DescriptionFR = @"Conservez les données dans la base de données. Parfois, la base de données peut obtenir des données du site Web du bureau hydrométrique en tant que données temporaires pouvant être supprimées ultérieurement.")]
        public bool Keep { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Storage data type")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Type de données sauvegardez")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Storage data type can be archived, forcasted or observed")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Type de données sauvegardez peut être archivés, prévisions ou observés")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Storage data type
        /// 
        /// **Display (fr)** --- Type de données sauvegardez
        /// 
        /// **Description (en)** --- Storage data type can be archived, forcasted or observed
        /// 
        /// **Description (fr)** --- Type de données sauvegardez peut être archivés, prévisions ou observés
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Storage data type")]
        [CSSPDisplayFR(DisplayFR = "Type de données sauvegardez")]
        [CSSPDescriptionEN(DescriptionEN = @"Storage data type can be archived, forcasted or observed")]
        [CSSPDescriptionFR(DescriptionFR = @"Type de données sauvegardez peut être archivés, prévisions ou observés")]
        public StorageDataTypeEnum StorageDataType { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Has been read")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Ont été lus")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "The stored data has been read from the weather office web site")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Les données stockées ont été lues sur le site Web du bureau météorologique")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Has been read
        /// 
        /// **Display (fr)** --- Ont été lus
        /// 
        /// **Description (en)** --- The stored data has been read from the weather office web site
        /// 
        /// **Description (fr)** --- Les données stockées ont été lues sur le site Web du bureau météorologique
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Has been read")]
        [CSSPDisplayFR(DisplayFR = "Ont été lus")]
        [CSSPDescriptionEN(DescriptionEN = @"The stored data has been read from the weather office web site")]
        [CSSPDescriptionFR(DescriptionFR = @"Les données stockées ont été lues sur le site Web du bureau météorologique")]
        public bool HasBeenRead { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Discharges (m3/s)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Débits (m3/s)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Discharges  in cubic meters per second")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Débits en mètres cube par second")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Discharges (m3/s)
        /// 
        /// **Display (fr)** --- Débits (m3/s)
        /// 
        /// **Description (en)** --- Discharges  in cubic meters per second
        /// 
        /// **Description (fr)** --- Débits en mètres cube par second
        /// </returns>
        [Range(0.0D, 100000.0D)]
        [CSSPDisplayEN(DisplayEN = "Discharges (m3/s)")]
        [CSSPDisplayFR(DisplayFR = "Débits (m3/s)")]
        [CSSPDescriptionEN(DescriptionEN = @"Discharges  in cubic meters per second")]
        [CSSPDescriptionFR(DescriptionFR = @"Débits en mètres cube par second")]
        public double? Discharge_m3_s { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Discharges entered (m3/s)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Débits entrés (m3/s)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Discharges entered in cubic meters per second")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Débits entrés en mètres cube par second")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Discharges entered (m3/s)
        /// 
        /// **Display (fr)** --- Débits entrés (m3/s)
        /// 
        /// **Description (en)** --- Discharges entered in cubic meters per second
        /// 
        /// **Description (fr)** --- Débits entrés en mètres cube par second
        /// </returns>
        [Range(0.0D, 100000.0D)]
        [CSSPDisplayEN(DisplayEN = "Discharges entered (m3/s)")]
        [CSSPDisplayFR(DisplayFR = "Débits entrés (m3/s)")]
        [CSSPDescriptionEN(DescriptionEN = @"Discharges entered in cubic meters per second")]
        [CSSPDescriptionFR(DescriptionFR = @"Débits entrés en mètres cube par second")]
        public double? DischargeEntered_m3_s { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Levels (m)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Niveaux (m)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Levels in meters")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Niveaux en meters")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Levels (m)
        /// 
        /// **Display (fr)** --- Niveaux (m)
        /// 
        /// **Description (en)** --- Levels in meters
        /// 
        /// **Description (fr)** --- Niveaux en meters
        /// </returns>
        [Range(0.0D, 10000.0D)]
        [CSSPDisplayEN(DisplayEN = "Levels (m)")]
        [CSSPDisplayFR(DisplayFR = "Niveaux (m)")]
        [CSSPDescriptionEN(DescriptionEN = @"Levels in meters")]
        [CSSPDescriptionFR(DescriptionFR = @"Niveaux en meters")]
        public double? Level_m { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "String containing hourly values")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte contenant les valeurs horaires")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "String containing hourly values")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte contenant les valeurs horaires")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- String containing hourly values
        /// 
        /// **Display (fr)** --- Texte contenant les valeurs horaires
        /// 
        /// **Description (en)** --- String containing hourly values
        /// 
        /// **Description (fr)** --- Texte contenant les valeurs horaires
        /// </returns>
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "String containing hourly values")]
        [CSSPDisplayFR(DisplayFR = "Texte contenant les valeurs horaires")]
        [CSSPDescriptionEN(DescriptionEN = @"String containing hourly values")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte contenant les valeurs horaires")]
        public string HourlyValues { get; set; }
        #endregion Properties in DB

        #region Constructors
        public HydrometricDataValue() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class HydrometricDataValueExtraA : HydrometricDataValue
    {
        #region Properties
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
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "StorageDataTypeEnum", EnumType = "StorageDataType")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Storage data type text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte du type de storage")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Storage data type text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte du type de storage")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Storage data type text
        /// 
        /// **Display (fr)** --- Texte du type de storage
        /// 
        /// **Description (en)** --- Storage data type text
        /// 
        /// **Description (fr)** --- Texte du type de storage
        /// </returns>
        [CSSPEnumTypeText(EnumTypeName = "StorageDataTypeEnum", EnumType = "StorageDataType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Storage data type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type de storage")]
        [CSSPDescriptionEN(DescriptionEN = @"Storage data type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type de storage")]
        public string StorageDataTypeText { get; set; }
        #endregion Properties

        #region Constructors
        public HydrometricDataValueExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class HydrometricDataValueExtraB : HydrometricDataValueExtraA
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
        public string HydrometricDataValueReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public HydrometricDataValueExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
