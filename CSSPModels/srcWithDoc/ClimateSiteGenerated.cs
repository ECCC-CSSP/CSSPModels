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
    /// > <para>**DB properties for table ClimateSites** : [ClimateSiteID](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_ClimateSiteID), [ClimateSiteTVItemID](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_ClimateSiteTVItemID), [ECDBID](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_ECDBID), [ClimateSiteName](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_ClimateSiteName), [Province](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_Province), [Elevation_m](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_Elevation_m), [ClimateID](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_ClimateID), [WMOID](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_WMOID), [TCID](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_TCID), [IsProvincial](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_IsProvincial), [ProvSiteID](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_ProvSiteID), [TimeOffset_hour](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_TimeOffset_hour), [File_desc](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_File_desc), [HourlyStartDate_Local](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_HourlyStartDate_Local), [HourlyEndDate_Local](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_HourlyEndDate_Local), [HourlyNow](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_HourlyNow), [DailyStartDate_Local](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_DailyStartDate_Local), [DailyEndDate_Local](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_DailyEndDate_Local), [DailyNow](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_DailyNow), [MonthlyStartDate_Local](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_MonthlyStartDate_Local), [MonthlyEndDate_Local](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_MonthlyEndDate_Local), [MonthlyNow](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_MonthlyNow), [LastUpdateDate_UTC](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_HasErrors), [ValidationResults](CSSPModels.ClimateSite.html#CSSPModels_ClimateSite_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [ClimateSiteService](CSSPServices.ClimateSiteService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class ClimateSite : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "ClimateSite ID")]
        [CSSPDisplayFR(DisplayFR = "ClimateSite ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the ClimateSites table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table ClimateSites")]
        public int ClimateSiteID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>4 == ClimateSite</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "4")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "4")]
        [CSSPDisplayEN(DisplayEN = "ClimateSite TVItemID")]
        [CSSPDisplayFR(DisplayFR = "ClimateSite TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table with the unique identifier")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems avec l'identifiant unique")]
        public int ClimateSiteTVItemID { get; set; }
        [Range(1, 100000)]
        [CSSPDisplayEN(DisplayEN = "ECDBID")]
        [CSSPDisplayFR(DisplayFR = "ECDBID")]
        [CSSPDescriptionEN(DescriptionEN = @"ECDBID --- Environment Canada weather office web site unique id for the weather climate site")]
        [CSSPDescriptionFR(DescriptionFR = @"ECDBID --- Site Web du bureau météorologique d'Environnement Canada identifiant le site de site climatatique")]
        public int ECDBID { get; set; }
        [StringLength(100)]
        [CSSPDisplayEN(DisplayEN = "Climate site name")]
        [CSSPDisplayFR(DisplayFR = "Nom du site climatique")]
        [CSSPDescriptionEN(DescriptionEN = @"Climate site name is a unique name for the site given by Environment Canada")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du site climatique est un nom unique pour le site donné par Environnement Canada")]
        public string ClimateSiteName { get; set; }
        [StringLength(4)]
        [CSSPDisplayEN(DisplayEN = "Province")]
        [CSSPDisplayFR(DisplayFR = "Province")]
        [CSSPDescriptionEN(DescriptionEN = @"Province identified by two letters initiales")]
        [CSSPDescriptionFR(DescriptionFR = @"Province identifiée par les initiales de deux lettres")]
        public string Province { get; set; }
        [Range(0.0D, 10000.0D)]
        [CSSPDisplayEN(DisplayEN = "Elevation (m)")]
        [CSSPDisplayFR(DisplayFR = "Élévation (m)")]
        [CSSPDescriptionEN(DescriptionEN = @"Elevation (m) is the elevation above mean sea level")]
        [CSSPDescriptionFR(DescriptionFR = @"Élévation (m) est l'élévation au dessus du niveau moyen de la mer")]
        public double? Elevation_m { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(10)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Climate site ID")]
        [CSSPDisplayFR(DisplayFR = "Identifiant du site climatique")]
        [CSSPDescriptionEN(DescriptionEN = @"Climate site ID is a unique ID for the climate site for Environment Canada")]
        [CSSPDescriptionFR(DescriptionFR = @"Identifiant du site climatique est unique pour le site climatique pour Environnemement Canada")]
        public string ClimateID { get; set; }
        [Range(1, 100000)]
        [CSSPDisplayEN(DisplayEN = "WMOID")]
        [CSSPDisplayFR(DisplayFR = "WMOID")]
        [CSSPDescriptionEN(DescriptionEN = @"WMOID is a unique ID for the climate site for World Meteorological Office")]
        [CSSPDescriptionFR(DescriptionFR = @"WMOID est un identifiant unique pour le site climatique pour World Meteorological Office")]
        public int? WMOID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(3)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "TCID")]
        [CSSPDisplayFR(DisplayFR = "TCID")]
        [CSSPDescriptionEN(DescriptionEN = @"TCID is the identifier assigned by Transport Canada to identify meteorological reports from airport observing sites transmitted in real time in aviation formats.")]
        [CSSPDescriptionFR(DescriptionFR = @"TCID est l'identificateur attribué par Transports Canada pour identifier les rapports météorologiques provenant des stations localisées aux aéroports et sont transmis en temps réel dans des formats d'aviation.")]
        public string TCID { get; set; }
        [CSSPDisplayEN(DisplayEN = "Site provincial")]
        [CSSPDisplayFR(DisplayFR = "Provincial site")]
        [CSSPDescriptionEN(DescriptionEN = @"Site provincial indicates if the climate site is a provincial site")]
        [CSSPDescriptionFR(DescriptionFR = @"Provincial site indique si le site climatique est un site provincial")]
        public bool? IsProvincial { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(50)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Site provincial")]
        [CSSPDisplayFR(DisplayFR = "Provincial site")]
        [CSSPDescriptionEN(DescriptionEN = @"Site provincial indicates if the climate site is a provincial site")]
        [CSSPDescriptionFR(DescriptionFR = @"Provincial site indique si le site climatique est un site provincial")]
        public string ProvSiteID { get; set; }
        [Range(-10.0D, 0.0D)]
        [CSSPDisplayEN(DisplayEN = "Time zone offset (hour)")]
        [CSSPDisplayFR(DisplayFR = "Décalage du fuseau horaire (heure)")]
        [CSSPDescriptionEN(DescriptionEN = @"Time zone offset (hour)")]
        [CSSPDescriptionFR(DescriptionFR = @"Décalage du fuseau horaire (heure)")]
        public double? TimeOffset_hour { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(50)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "File description")]
        [CSSPDisplayFR(DisplayFR = "Description de filière")]
        [CSSPDescriptionEN(DescriptionEN = @"File description --- temporary field used while uploading data from Environment Canda weather office web site")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de filière --- champ temporaire utilisé lors du téléchargement des données du site Web du bureau météorologique d'Environnement Canada")]
        public string File_desc { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        [CSSPDisplayEN(DisplayEN = "Hourly start date")]
        [CSSPDisplayFR(DisplayFR = "Date de départ des données horaires")]
        [CSSPDescriptionEN(DescriptionEN = @"Hourly start date will contain null is the climate site does not have hourly data or the starting date of hourly data")]
        [CSSPDescriptionFR(DescriptionFR = @"Date de départ des données horaires contiendra null si le site climatique n'a pas de données horaires ou la date de départ des données horaires")]
        public DateTime? HourlyStartDate_Local { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        [CSSPDisplayEN(DisplayEN = "Hourly end date")]
        [CSSPDisplayFR(DisplayFR = "Date de fin des données horaires")]
        [CSSPDescriptionEN(DescriptionEN = @"Hourly end date will contain null is the climate site does not have hourly data or the end date of hourly data")]
        [CSSPDescriptionFR(DescriptionFR = @"Date de fin des données horaires contiendra null si le site climatique n'a pas de données horaires ou la date de fin des données horaires")]
        public DateTime? HourlyEndDate_Local { get; set; }
        [CSSPDisplayEN(DisplayEN = "Hourly now")]
        [CSSPDisplayFR(DisplayFR = "Horaire maintenant")]
        [CSSPDescriptionEN(DescriptionEN = @"Hourly now indicates if there are hourly data at this date")]
        [CSSPDescriptionFR(DescriptionFR = @"Horaire maintenant indique s'il y a des données horaires maintenant")]
        public bool? HourlyNow { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        [CSSPDisplayEN(DisplayEN = "Daily start date")]
        [CSSPDisplayFR(DisplayFR = "Date de départ des données journalières")]
        [CSSPDescriptionEN(DescriptionEN = @"Daily start date will contain null is the climate site does not have daily data or the start date of hourly data")]
        [CSSPDescriptionFR(DescriptionFR = @"Date de départ des données journalières contiendra null si le site climatique n'a pas de données journalières ou la date de départ des données journalières")]
        public DateTime? DailyStartDate_Local { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        [CSSPDisplayEN(DisplayEN = "Daily end date")]
        [CSSPDisplayFR(DisplayFR = "Date de fin des données journalières")]
        [CSSPDescriptionEN(DescriptionEN = @"Daily end date will contain null is the climate site does not have daily data or the end date of hourly data")]
        [CSSPDescriptionFR(DescriptionFR = @"Date de fin des données journalières contiendra null si le site climatique n'a pas de données journalières ou la date de fin des données journalières")]
        public DateTime? DailyEndDate_Local { get; set; }
        [CSSPDisplayEN(DisplayEN = "Daily now")]
        [CSSPDisplayFR(DisplayFR = "Jounalier maintenant")]
        [CSSPDescriptionEN(DescriptionEN = @"Daily now indicates if there are daily data at this date")]
        [CSSPDescriptionFR(DescriptionFR = @"Journalier maintenant indique s'il y a des données journalières maintenant")]
        public bool? DailyNow { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        [CSSPDisplayEN(DisplayEN = "Monthly start date")]
        [CSSPDisplayFR(DisplayFR = "Date de départ des données mensuelles")]
        [CSSPDescriptionEN(DescriptionEN = @"Monthly start date will contain null is the climate site does not have monthly data or the start date of monthly data")]
        [CSSPDescriptionFR(DescriptionFR = @"Date de départ des données mensuelles contiendra null si le site climatique n'a pas de données mensuelles ou la date de départ des données mensuelles")]
        public DateTime? MonthlyStartDate_Local { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        [CSSPDisplayEN(DisplayEN = "Monthly end date")]
        [CSSPDisplayFR(DisplayFR = "Date de fin des données mensuelles")]
        [CSSPDescriptionEN(DescriptionEN = @"Monthly end date will contain null is the climate site does not have monthly data or the end date of monthly data")]
        [CSSPDescriptionFR(DescriptionFR = @"Date de fin des données mensuelles contiendra null si le site climatique n'a pas de données mensuelles ou la date de fin des données mensuelles")]
        public DateTime? MonthlyEndDate_Local { get; set; }
        [CSSPDisplayEN(DisplayEN = "Monthly now")]
        [CSSPDisplayFR(DisplayFR = "Mensuel maintenant")]
        [CSSPDescriptionEN(DescriptionEN = @"Monthly now indicates if there are monthly data at this date")]
        [CSSPDescriptionFR(DescriptionFR = @"Mensuel maintenant indique s'il y a des données mensuelles maintenant")]
        public bool? MonthlyNow { get; set; }
        #endregion Properties in DB

        #region Constructors
        public ClimateSite() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ClimateSite_A : ClimateSite
    {
        #region Properties
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ClimateSiteTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ClimateSiteTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "ClimateSite TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage de ClimateSite")]
        [CSSPDescriptionEN(DescriptionEN = @"ClimateSite TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage de ClimateSite")]
        public TVItemLanguage ClimateSiteTVItemLanguage { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public ClimateSite_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ClimateSite_B : ClimateSite_A
    {
        #region Properties
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string ClimateSiteReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public ClimateSite_B() : base()
        {
        }
        #endregion Constructors
    }
}
