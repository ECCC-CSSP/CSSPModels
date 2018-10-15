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
    /// > <para>**DB properties for table MikeSourceStartEnds** : [MikeSourceStartEndID](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_MikeSourceStartEndID), [MikeSourceID](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_MikeSourceID), [StartDateAndTime_Local](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_StartDateAndTime_Local), [EndDateAndTime_Local](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_EndDateAndTime_Local), [SourceFlowStart_m3_day](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_SourceFlowStart_m3_day), [SourceFlowEnd_m3_day](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_SourceFlowEnd_m3_day), [SourcePollutionStart_MPN_100ml](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_SourcePollutionStart_MPN_100ml), [SourcePollutionEnd_MPN_100ml](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_SourcePollutionEnd_MPN_100ml), [SourceTemperatureStart_C](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_SourceTemperatureStart_C), [SourceTemperatureEnd_C](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_SourceTemperatureEnd_C), [SourceSalinityStart_PSU](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_SourceSalinityStart_PSU), [SourceSalinityEnd_PSU](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_SourceSalinityEnd_PSU), [LastUpdateDate_UTC](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_HasErrors), [ValidationResults](CSSPModels.MikeSourceStartEnd.html#CSSPModels_MikeSourceStartEnd_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [MikeSourceStartEndService](CSSPServices.MikeSourceStartEndService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class MikeSourceStartEnd : LastUpdate
    {
        #region Properties in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MikeSourceStartEnd ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "MikeSourceStartEnd ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Contains the unique "identifier on each row of the MikeSourceStartEnds table")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Contient l'identifiant unique sur chaque ligne de la table MikeSourceStartEnds")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MikeSourceStartEnd ID
        /// 
        /// **Display (fr)** --- MikeSourceStartEnd ID
        /// 
        /// **Description (en)** --- Contains the unique "identifier on each row of the MikeSourceStartEnds table
        /// 
        /// **Description (fr)** --- Contient l'identifiant unique sur chaque ligne de la table MikeSourceStartEnds
        /// </returns>
        [Key]
        [CSSPDisplayEN(DisplayEN = "MikeSourceStartEnd ID")]
        [CSSPDisplayFR(DisplayFR = "MikeSourceStartEnd ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MikeSourceStartEnds table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table MikeSourceStartEnds")]
        public int MikeSourceStartEndID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "MikeSource", ExistPlurial = "s", ExistFieldID = "MikeSourceID")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MIKE source ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "ID de source MIKE")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Link to the MikeSources table representing MIKE source")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Lien à la table MikeSources représentant une source MIKE")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MIKE source ID
        /// 
        /// **Display (fr)** --- ID de source MIKE
        /// 
        /// **Description (en)** --- Link to the MikeSources table representing MIKE source
        /// 
        /// **Description (fr)** --- Lien à la table MikeSources représentant une source MIKE
        /// </returns>
        [CSSPExist(ExistTypeName = "MikeSource", ExistPlurial = "s", ExistFieldID = "MikeSourceID")]
        [CSSPDisplayEN(DisplayEN = "MIKE source ID")]
        [CSSPDisplayFR(DisplayFR = "ID de source MIKE")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the MikeSources table representing MIKE source")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table MikeSources représentant une source MIKE")]
        public int MikeSourceID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Start date and time (local)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Date et temps du début (local)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Start date and time (local)")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Date et temps du début (local)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Start date and time (local)
        /// 
        /// **Display (fr)** --- Date et temps du début (local)
        /// 
        /// **Description (en)** --- Start date and time (local)
        /// 
        /// **Description (fr)** --- Date et temps du début (local)
        /// </returns>
        [CSSPAfter(Year = 1980)]
        [CSSPDisplayEN(DisplayEN = "Start date and time (local)")]
        [CSSPDisplayFR(DisplayFR = "Date et temps du début (local)")]
        [CSSPDescriptionEN(DescriptionEN = @"Start date and time (local)")]
        [CSSPDescriptionFR(DescriptionFR = @"Date et temps du début (local)")]
        public DateTime StartDateAndTime_Local { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// > <para>[[CSSPBigger](CSSPModels.CSSPBiggerAttribute.html)(OtherField = "StartDateAndTime_Local")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "End date and time (local)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Date et temps de fin (local)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "End date and time (local)")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Date et temps de fin (local)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- End date and time (local)
        /// 
        /// **Display (fr)** --- Date et temps de fin (local)
        /// 
        /// **Description (en)** --- End date and time (local)
        /// 
        /// **Description (fr)** --- Date et temps de fin (local)
        /// </returns>
        [CSSPAfter(Year = 1980)]
        [CSSPBigger(OtherField = "StartDateAndTime_Local")]
        [CSSPDisplayEN(DisplayEN = "End date and time (local)")]
        [CSSPDisplayFR(DisplayFR = "Date et temps de fin (local)")]
        [CSSPDescriptionEN(DescriptionEN = @"End date and time (local)")]
        [CSSPDescriptionFR(DescriptionFR = @"Date et temps de fin (local)")]
        public DateTime EndDateAndTime_Local { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Start of source flow (m3/d)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Début de débit de source (m3/j)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Start of source flow in cubic meters per day")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Début de débit de source en mètres cubes par jour")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Start of source flow (m3/d)
        /// 
        /// **Display (fr)** --- Début de débit de source (m3/j)
        /// 
        /// **Description (en)** --- Start of source flow in cubic meters per day
        /// 
        /// **Description (fr)** --- Début de débit de source en mètres cubes par jour
        /// </returns>
        [Range(0.0D, 1000000.0D)]
        [CSSPDisplayEN(DisplayEN = "Start of source flow (m3/d)")]
        [CSSPDisplayFR(DisplayFR = "Début de débit de source (m3/j)")]
        [CSSPDescriptionEN(DescriptionEN = @"Start of source flow in cubic meters per day")]
        [CSSPDescriptionFR(DescriptionFR = @"Début de débit de source en mètres cubes par jour")]
        public double SourceFlowStart_m3_day { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "End of source flow (m3/d)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Fin de débit de source (m3/j)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "End of source flow in cubic meters per day")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Fin de débit de source en mètres cubes par jour")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- End of source flow (m3/d)
        /// 
        /// **Display (fr)** --- Fin de débit de source (m3/j)
        /// 
        /// **Description (en)** --- End of source flow in cubic meters per day
        /// 
        /// **Description (fr)** --- Fin de débit de source en mètres cubes par jour
        /// </returns>
        [Range(0.0D, 1000000.0D)]
        [CSSPDisplayEN(DisplayEN = "End of source flow (m3/d)")]
        [CSSPDisplayFR(DisplayFR = "Fin de débit de source (m3/j)")]
        [CSSPDescriptionEN(DescriptionEN = @"End of source flow in cubic meters per day")]
        [CSSPDescriptionFR(DescriptionFR = @"Fin de débit de source en mètres cubes par jour")]
        public double SourceFlowEnd_m3_day { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Start of source concentration (MPN / 100 mL)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Début de concentration de source (NPP / 100 mL)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Start of source concentration in most probable number of fecal coliform colonies per 100 milli-Litres")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Début de concentration de source en nombre plus probable de colonie de coliform fécaux par 100 milli-Litres")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Start of source concentration (MPN / 100 mL)
        /// 
        /// **Display (fr)** --- Début de concentration de source (NPP / 100 mL)
        /// 
        /// **Description (en)** --- Start of source concentration in most probable number of fecal coliform colonies per 100 milli-Litres
        /// 
        /// **Description (fr)** --- Début de concentration de source en nombre plus probable de colonie de coliform fécaux par 100 milli-Litres
        /// </returns>
        [Range(0, 10000000)]
        [CSSPDisplayEN(DisplayEN = "Start of source concentration (MPN / 100 mL)")]
        [CSSPDisplayFR(DisplayFR = "Début de concentration de source (NPP / 100 mL)")]
        [CSSPDescriptionEN(DescriptionEN = @"Start of source concentration in most probable number of fecal coliform colonies per 100 milli-Litres")]
        [CSSPDescriptionFR(DescriptionFR = @"Début de concentration de source en nombre plus probable de colonie de coliform fécaux par 100 milli-Litres")]
        public int SourcePollutionStart_MPN_100ml { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "End of source concentration (MPN / 100 mL)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Fin de concentration de source (NPP / 100 mL)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "End of source concentration in most probable number of fecal coliform colonies per 100 milli-Litres")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Fin de concentration de source en nombre plus probable de colonie de coliform fécaux par 100 milli-Litres")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- End of source concentration (MPN / 100 mL)
        /// 
        /// **Display (fr)** --- Fin de concentration de source (NPP / 100 mL)
        /// 
        /// **Description (en)** --- End of source concentration in most probable number of fecal coliform colonies per 100 milli-Litres
        /// 
        /// **Description (fr)** --- Fin de concentration de source en nombre plus probable de colonie de coliform fécaux par 100 milli-Litres
        /// </returns>
        [Range(0, 10000000)]
        [CSSPDisplayEN(DisplayEN = "End of source concentration (MPN / 100 mL)")]
        [CSSPDisplayFR(DisplayFR = "Fin de concentration de source (NPP / 100 mL)")]
        [CSSPDescriptionEN(DescriptionEN = @"End of source concentration in most probable number of fecal coliform colonies per 100 milli-Litres")]
        [CSSPDescriptionFR(DescriptionFR = @"Fin de concentration de source en nombre plus probable de colonie de coliform fécaux par 100 milli-Litres")]
        public int SourcePollutionEnd_MPN_100ml { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Start of source temperature (°C)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Début de température de source (°C)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Start of source temperature in degree Celcius")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Début de température de source en dégré Celcius")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Start of source temperature (°C)
        /// 
        /// **Display (fr)** --- Début de température de source (°C)
        /// 
        /// **Description (en)** --- Start of source temperature in degree Celcius
        /// 
        /// **Description (fr)** --- Début de température de source en dégré Celcius
        /// </returns>
        [Range(-10.0D, 40.0D)]
        [CSSPDisplayEN(DisplayEN = "Start of source temperature (°C)")]
        [CSSPDisplayFR(DisplayFR = "Début de température de source (°C)")]
        [CSSPDescriptionEN(DescriptionEN = @"Start of source temperature in degree Celcius")]
        [CSSPDescriptionFR(DescriptionFR = @"Début de température de source en dégré Celcius")]
        public double SourceTemperatureStart_C { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "End of source temperature (°C)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Fin de température de source (°C)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "End of source temperature in degree Celcius")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Fin de température de source en dégré Celcius")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- End of source temperature (°C)
        /// 
        /// **Display (fr)** --- Fin de température de source (°C)
        /// 
        /// **Description (en)** --- End of source temperature in degree Celcius
        /// 
        /// **Description (fr)** --- Fin de température de source en dégré Celcius
        /// </returns>
        [Range(-10.0D, 40.0D)]
        [CSSPDisplayEN(DisplayEN = "End of source temperature (°C)")]
        [CSSPDisplayFR(DisplayFR = "Fin de température de source (°C)")]
        [CSSPDescriptionEN(DescriptionEN = @"End of source temperature in degree Celcius")]
        [CSSPDescriptionFR(DescriptionFR = @"Fin de température de source en dégré Celcius")]
        public double SourceTemperatureEnd_C { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Start of source salinity (PSU)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Début de salinité de source (PSU) (fr)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Start of source salinity (PSU)")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Début de salinité de source (PSU) (fr)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Start of source salinity (PSU)
        /// 
        /// **Display (fr)** --- Début de salinité de source (PSU) (fr)
        /// 
        /// **Description (en)** --- Start of source salinity (PSU)
        /// 
        /// **Description (fr)** --- Début de salinité de source (PSU) (fr)
        /// </returns>
        [Range(0.0D, 40.0D)]
        [CSSPDisplayEN(DisplayEN = "Start of source salinity (PSU)")]
        [CSSPDisplayFR(DisplayFR = "Début de salinité de source (PSU) (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"Start of source salinity (PSU)")]
        [CSSPDescriptionFR(DescriptionFR = @"Début de salinité de source (PSU) (fr)")]
        public double SourceSalinityStart_PSU { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "End of source salinity (PSU)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Fin de salinité de source (PSU) (fr)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "End of source salinity (PSU)")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Fin de salinité de source (PSU) (fr)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- End of source salinity (PSU)
        /// 
        /// **Display (fr)** --- Fin de salinité de source (PSU) (fr)
        /// 
        /// **Description (en)** --- End of source salinity (PSU)
        /// 
        /// **Description (fr)** --- Fin de salinité de source (PSU) (fr)
        /// </returns>
        [Range(0.0D, 40.0D)]
        [CSSPDisplayEN(DisplayEN = "End of source salinity (PSU)")]
        [CSSPDisplayFR(DisplayFR = "Fin de salinité de source (PSU) (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"End of source salinity (PSU)")]
        [CSSPDescriptionFR(DescriptionFR = @"Fin de salinité de source (PSU) (fr)")]
        public double SourceSalinityEnd_PSU { get; set; }
        #endregion Properties in DB

        #region Constructors
        public MikeSourceStartEnd() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MikeSourceStartEndExtraA : MikeSourceStartEnd
    {
        #region Properties
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
        #endregion Properties

        #region Constructors
        public MikeSourceStartEndExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MikeSourceStartEndExtraB : MikeSourceStartEndExtraA
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
        public string MikeSourceStartEndReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public MikeSourceStartEndExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
