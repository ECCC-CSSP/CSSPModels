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
    /// > <para>**DB properties for table MWQMSamples** : [MWQMSampleID](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_MWQMSampleID), [MWQMSiteTVItemID](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_MWQMSiteTVItemID), [MWQMRunTVItemID](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_MWQMRunTVItemID), [SampleDateTime_Local](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_SampleDateTime_Local), [Depth_m](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_Depth_m), [FecCol_MPN_100ml](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_FecCol_MPN_100ml), [Salinity_PPT](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_Salinity_PPT), [WaterTemp_C](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_WaterTemp_C), [PH](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_PH), [SampleTypesText](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_SampleTypesText), [SampleType_old](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_SampleType_old), [Tube_10](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_Tube_10), [Tube_1_0](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_Tube_1_0), [Tube_0_1](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_Tube_0_1), [ProcessedBy](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_ProcessedBy), [UseForOpenData](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_UseForOpenData), [LastUpdate.LastUpdateDate_UTC](CSSPModels.LastUpdate.html#CSSPModels_LastUpdate_LastUpdateDate_UTC), [LastUpdate.LastUpdateContactTVItemID](CSSPModels.LastUpdate.html#CSSPModels_LastUpdate_LastUpdateContactTVItemID)</para>
    /// > <para>**Other properties** : [CSSPError.HasErrors](CSSPModels.CSSPError.html#CSSPModels_CSSPError_HasErrors), [CSSPError.ValidationResults](CSSPModels.CSSPError.html#CSSPModels_CSSPError_ValidationResults)</para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [MWQMSampleService](CSSPServices.MWQMSampleService.html)</para>
    /// > <para>**Used by [CSSPWebAPI.Controllers](CSSPWebAPI.Controllers.html)** : [MWQMSampleController](CSSPWebAPI.Controllers.MWQMSampleController.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [SampleTypeEnum](CSSPEnums.SampleTypeEnum.html)</para>
    /// > <para>**Inherits [LastUpdate](CSSPModels.LastUpdate.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class MWQMSample : LastUpdate
    {
        #region Properties in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MWQMSample ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "MWQMSample ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Contains the unique "identifier on each row of the MWQMSamples table")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Contient l'identifiant unique sur chaque ligne de la table MWQMSamples")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MWQMSample ID
        /// 
        /// **Display (fr)** --- MWQMSample ID
        /// 
        /// **Description (en)** --- Contains the unique "identifier on each row of the MWQMSamples table
        /// 
        /// **Description (fr)** --- Contient l'identifiant unique sur chaque ligne de la table MWQMSamples
        /// </returns>
        [Key]
        [CSSPDisplayEN(DisplayEN = "MWQMSample ID")]
        [CSSPDisplayFR(DisplayFR = "MWQMSample ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MWQMSamples table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table MWQMSamples")]
        public int MWQMSampleID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>16 == MWQMSite</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "16")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "16")]
        public int MWQMSiteTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>31 == MWQMRun</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "31")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MWQM run TVItemID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Tournée MWQM TVItemID (fr)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Link to the TVItems table representing MWQM run")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Lien à la table TVItems représentant le la tournée MWQM")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MWQM run TVItemID
        /// 
        /// **Display (fr)** --- Tournée MWQM TVItemID (fr)
        /// 
        /// **Description (en)** --- Link to the TVItems table representing MWQM run
        /// 
        /// **Description (fr)** --- Lien à la table TVItems représentant le la tournée MWQM
        /// </returns>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "31")]
        [CSSPDisplayEN(DisplayEN = "MWQM run TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Tournée MWQM TVItemID (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing MWQM run")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant le la tournée MWQM")]
        public int MWQMRunTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Sample date and time (local)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Date et temps de l'échantillon (local)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Sample date and time (local)")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Date et temps de l'échantillon (local)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Sample date and time (local)
        /// 
        /// **Display (fr)** --- Date et temps de l'échantillon (local)
        /// 
        /// **Description (en)** --- Sample date and time (local)
        /// 
        /// **Description (fr)** --- Date et temps de l'échantillon (local)
        /// </returns>
        [CSSPAfter(Year = 1980)]
        [CSSPDisplayEN(DisplayEN = "Sample date and time (local)")]
        [CSSPDisplayFR(DisplayFR = "Date et temps de l'échantillon (local)")]
        [CSSPDescriptionEN(DescriptionEN = @"Sample date and time (local)")]
        [CSSPDescriptionFR(DescriptionFR = @"Date et temps de l'échantillon (local)")]
        public DateTime SampleDateTime_Local { get; set; }
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
        [Range(0.0D, 1000.0D)]
        [CSSPDisplayEN(DisplayEN = "Depth (m)")]
        [CSSPDisplayFR(DisplayFR = "Profondeur (m)")]
        [CSSPDescriptionEN(DescriptionEN = @"Depth in meters")]
        [CSSPDescriptionFR(DescriptionFR = @"Profondeur en mètres")]
        public double? Depth_m { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "FC (MPN / 100 mL)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "CF (NPP / 100 mL)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Most probable number of fecal coliform colonies per 100 milli-Litres")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Number plus probable de colonies de coliform fécaux par 100 milli-Litres")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- FC (MPN / 100 mL)
        /// 
        /// **Display (fr)** --- CF (NPP / 100 mL)
        /// 
        /// **Description (en)** --- Most probable number of fecal coliform colonies per 100 milli-Litres
        /// 
        /// **Description (fr)** --- Number plus probable de colonies de coliform fécaux par 100 milli-Litres
        /// </returns>
        [Range(0, 10000000)]
        [CSSPDisplayEN(DisplayEN = "FC (MPN / 100 mL)")]
        [CSSPDisplayFR(DisplayFR = "CF (NPP / 100 mL)")]
        [CSSPDescriptionEN(DescriptionEN = @"Most probable number of fecal coliform colonies per 100 milli-Litres")]
        [CSSPDescriptionFR(DescriptionFR = @"Number plus probable de colonies de coliform fécaux par 100 milli-Litres")]
        public int FecCol_MPN_100ml { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Salinity (PPT)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Salinité (PPT) (fr)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Salinity in parts per thousand")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Salinité en partis par millier")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Salinity (PPT)
        /// 
        /// **Display (fr)** --- Salinité (PPT) (fr)
        /// 
        /// **Description (en)** --- Salinity in parts per thousand
        /// 
        /// **Description (fr)** --- Salinité en partis par millier
        /// </returns>
        [Range(0.0D, 40.0D)]
        [CSSPDisplayEN(DisplayEN = "Salinity (PPT)")]
        [CSSPDisplayFR(DisplayFR = "Salinité (PPT) (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"Salinity in parts per thousand")]
        [CSSPDescriptionFR(DescriptionFR = @"Salinité en partis par millier")]
        public double? Salinity_PPT { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Temperature (°C)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Température (°C)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Temperatrue in degree Celcius")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Température en dégré Celcius")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Temperature (°C)
        /// 
        /// **Display (fr)** --- Température (°C)
        /// 
        /// **Description (en)** --- Temperatrue in degree Celcius
        /// 
        /// **Description (fr)** --- Température en dégré Celcius
        /// </returns>
        [Range(-10.0D, 40.0D)]
        [CSSPDisplayEN(DisplayEN = "Temperature (°C)")]
        [CSSPDisplayFR(DisplayFR = "Température (°C)")]
        [CSSPDescriptionEN(DescriptionEN = @"Temperatrue in degree Celcius")]
        [CSSPDescriptionFR(DescriptionFR = @"Température en dégré Celcius")]
        public double? WaterTemp_C { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "pH")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "pH")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "pH")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "pH")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- pH
        /// 
        /// **Display (fr)** --- pH
        /// 
        /// **Description (en)** --- pH
        /// 
        /// **Description (fr)** --- pH
        /// </returns>
        [Range(0.0D, 14.0D)]
        [CSSPDisplayEN(DisplayEN = "pH")]
        [CSSPDisplayFR(DisplayFR = "pH")]
        [CSSPDescriptionEN(DescriptionEN = @"pH")]
        [CSSPDescriptionFR(DescriptionFR = @"pH")]
        public double? PH { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Sample types")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Types de l'échantillon")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Sample types")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Types de l'échantillon")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Sample types
        /// 
        /// **Display (fr)** --- Types de l'échantillon
        /// 
        /// **Description (en)** --- Sample types
        /// 
        /// **Description (fr)** --- Types de l'échantillon
        /// </returns>
        [StringLength(50)]
        [CSSPDisplayEN(DisplayEN = "Sample types")]
        [CSSPDisplayFR(DisplayFR = "Types de l'échantillon")]
        [CSSPDescriptionEN(DescriptionEN = @"Sample types")]
        [CSSPDescriptionFR(DescriptionFR = @"Types de l'échantillon")]
        public string SampleTypesText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Old sample type")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Vieu type d'échantillon")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Old sample type")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Vieu type d'échantillon")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Old sample type
        /// 
        /// **Display (fr)** --- Vieu type d'échantillon
        /// 
        /// **Description (en)** --- Old sample type
        /// 
        /// **Description (fr)** --- Vieu type d'échantillon
        /// </returns>
        [CSSPEnumType]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Old sample type")]
        [CSSPDisplayFR(DisplayFR = "Vieu type d'échantillon")]
        [CSSPDescriptionEN(DescriptionEN = @"Old sample type")]
        [CSSPDescriptionFR(DescriptionFR = @"Vieu type d'échantillon")]
        public SampleTypeEnum? SampleType_old { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Tube 10")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Tube 10")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Number of positive tube for Tube 10")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Nombre de tube positif pour Tube 10")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Tube 10
        /// 
        /// **Display (fr)** --- Tube 10
        /// 
        /// **Description (en)** --- Number of positive tube for Tube 10
        /// 
        /// **Description (fr)** --- Nombre de tube positif pour Tube 10
        /// </returns>
        [Range(0, 5)]
        [CSSPDisplayEN(DisplayEN = "Tube 10")]
        [CSSPDisplayFR(DisplayFR = "Tube 10")]
        [CSSPDescriptionEN(DescriptionEN = @"Number of positive tube for Tube 10")]
        [CSSPDescriptionFR(DescriptionFR = @"Nombre de tube positif pour Tube 10")]
        public int? Tube_10 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Tube 1")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Tube 1")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Number of positive tube for Tube 1")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Nombre de tube positif pour Tube 1")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Tube 1
        /// 
        /// **Display (fr)** --- Tube 1
        /// 
        /// **Description (en)** --- Number of positive tube for Tube 1
        /// 
        /// **Description (fr)** --- Nombre de tube positif pour Tube 1
        /// </returns>
        [Range(0, 5)]
        [CSSPDisplayEN(DisplayEN = "Tube 1")]
        [CSSPDisplayFR(DisplayFR = "Tube 1")]
        [CSSPDescriptionEN(DescriptionEN = @"Number of positive tube for Tube 1")]
        [CSSPDescriptionFR(DescriptionFR = @"Nombre de tube positif pour Tube 1")]
        public int? Tube_1_0 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Tube .1")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Tube .1")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Number of positive tube for Tube .1")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Nombre de tube positif pour Tube .1")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Tube .1
        /// 
        /// **Display (fr)** --- Tube .1
        /// 
        /// **Description (en)** --- Number of positive tube for Tube .1
        /// 
        /// **Description (fr)** --- Nombre de tube positif pour Tube .1
        /// </returns>
        [Range(0, 5)]
        [CSSPDisplayEN(DisplayEN = "Tube .1")]
        [CSSPDisplayFR(DisplayFR = "Tube .1")]
        [CSSPDescriptionEN(DescriptionEN = @"Number of positive tube for Tube .1")]
        [CSSPDescriptionFR(DescriptionFR = @"Nombre de tube positif pour Tube .1")]
        public int? Tube_0_1 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Processed by")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Traité par")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Processed by")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Traité par")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Processed by
        /// 
        /// **Display (fr)** --- Traité par
        /// 
        /// **Description (en)** --- Processed by
        /// 
        /// **Description (fr)** --- Traité par
        /// </returns>
        [StringLength(10)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Processed by")]
        [CSSPDisplayFR(DisplayFR = "Traité par")]
        [CSSPDescriptionEN(DescriptionEN = @"Processed by")]
        [CSSPDescriptionFR(DescriptionFR = @"Traité par")]
        public string ProcessedBy { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Used for open data")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Utilisé pour les données ouvertes")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Used for open data")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Utilisé pour les données ouvertes")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Used for open data
        /// 
        /// **Display (fr)** --- Utilisé pour les données ouvertes
        /// 
        /// **Description (en)** --- Used for open data
        /// 
        /// **Description (fr)** --- Utilisé pour les données ouvertes
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Used for open data")]
        [CSSPDisplayFR(DisplayFR = "Utilisé pour les données ouvertes")]
        [CSSPDescriptionEN(DescriptionEN = @"Used for open data")]
        [CSSPDescriptionFR(DescriptionFR = @"Utilisé pour les données ouvertes")]
        public bool UseForOpenData { get; set; }
        #endregion Properties in DB

        #region Constructors
        public MWQMSample() : base()
        {
        }
        #endregion Constructors
    }
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [MWQMSiteText](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_MWQMSiteText), [MWQMRunText](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_MWQMRunText), [LastUpdateContactText](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_LastUpdateContactText), [SampleType_oldText](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_SampleType_oldText)</para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [MWQMSampleService](CSSPServices.MWQMSampleService.html)</para>
    /// > <para>**Used by [CSSPWebAPI.Controllers](CSSPWebAPI.Controllers.html)** : [MWQMSampleController](CSSPWebAPI.Controllers.MWQMSampleController.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [SampleTypeEnum](CSSPEnums.SampleTypeEnum.html)</para>
    /// > <para>**Inherits [MWQMSample](CSSPModels.MWQMSample.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class MWQMSampleExtraA : MWQMSample
    {
        #region Properties
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMSiteTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MWQM site text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte du site MWQM (fr)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "MWQM site text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte du site MWQM (fr)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MWQM site text
        /// 
        /// **Display (fr)** --- Texte du site MWQM (fr)
        /// 
        /// **Description (en)** --- MWQM site text
        /// 
        /// **Description (fr)** --- Texte du site MWQM (fr)
        /// </returns>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMSiteTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "MWQM site text")]
        [CSSPDisplayFR(DisplayFR = "Texte du site MWQM (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"MWQM site text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du site MWQM (fr)")]
        public string MWQMSiteText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMRunTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MWQM run text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte de la tournée MWQM (fr)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "MWQM run text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte de la tournée MWQM (fr)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MWQM run text
        /// 
        /// **Display (fr)** --- Texte de la tournée MWQM (fr)
        /// 
        /// **Description (en)** --- MWQM run text
        /// 
        /// **Description (fr)** --- Texte de la tournée MWQM (fr)
        /// </returns>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMRunTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "MWQM run text")]
        [CSSPDisplayFR(DisplayFR = "Texte de la tournée MWQM (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"MWQM run text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de la tournée MWQM (fr)")]
        public string MWQMRunText { get; set; }
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
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "SampleTypeEnum", EnumType = "SampleType_old")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Old sample type text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte du vieu type de l'échantillon")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Old sample type text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte du vieu type de l'échantillon")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Old sample type text
        /// 
        /// **Display (fr)** --- Texte du vieu type de l'échantillon
        /// 
        /// **Description (en)** --- Old sample type text
        /// 
        /// **Description (fr)** --- Texte du vieu type de l'échantillon
        /// </returns>
        [CSSPEnumTypeText(EnumTypeName = "SampleTypeEnum", EnumType = "SampleType_old")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Old sample type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du vieu type de l'échantillon")]
        [CSSPDescriptionEN(DescriptionEN = @"Old sample type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du vieu type de l'échantillon")]
        public string SampleType_oldText { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSampleExtraA() : base()
        {
        }
        #endregion Constructors
    }
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [MWQMSampleReportTest](CSSPModels.MWQMSample.html#CSSPModels_MWQMSample_MWQMSampleReportTest)</para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [MWQMSampleService](CSSPServices.MWQMSampleService.html)</para>
    /// > <para>**Used by [CSSPWebAPI.Controllers](CSSPWebAPI.Controllers.html)** : [MWQMSampleController](CSSPWebAPI.Controllers.MWQMSampleController.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [SampleTypeEnum](CSSPEnums.SampleTypeEnum.html)</para>
    /// > <para>**Inherits [MWQMSampleExtraA](CSSPModels.MWQMSampleExtraA.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class MWQMSampleExtraB : MWQMSampleExtraA
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
        public string MWQMSampleReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSampleExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
