/*
 * Manually edited by Charles LeBlanc 
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
    public partial class HydrometricSite : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "HydrometricSite ID")]
        [CSSPDisplayFR(DisplayFR = "HydrometricSite ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the HydrometricSites table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table HydrometricSites")]
        public int HydrometricSiteID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "9")]
        [CSSPDisplayEN(DisplayEN = "HydrometricSite TVItemID")]
        [CSSPDisplayFR(DisplayFR = "HydrometricSite TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table with the unique identifier")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems avec l'identifiant unique")]
        public int HydrometricSiteTVItemID { get; set; }
        [StringLength(7)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Fed. site number")]
        [CSSPDisplayFR(DisplayFR = "Numéro de site féd.")]
        [CSSPDescriptionEN(DescriptionEN = @"Federal site number")]
        [CSSPDescriptionFR(DescriptionFR = @"Numéro de site fédéral")]
        public string FedSiteNumber { get; set; }
        [StringLength(7)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "QC site number")]
        [CSSPDisplayFR(DisplayFR = "Numéro de site QC")]
        [CSSPDescriptionEN(DescriptionEN = @"Quebec site number")]
        [CSSPDescriptionFR(DescriptionFR = @"Numéro de site du Québec")]
        public string QuebecSiteNumber { get; set; }
        [StringLength(200)]
        [CSSPDisplayEN(DisplayEN = "Hydrometric site name")]
        [CSSPDisplayFR(DisplayFR = "Nom du site hydrométrique")]
        [CSSPDescriptionEN(DescriptionEN = @"Hydrometric site name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du site hydrométrique")]
        public string HydrometricSiteName { get; set; }
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Hydrometric site description")]
        [CSSPDisplayFR(DisplayFR = "Description du site hydrométrique")]
        [CSSPDescriptionEN(DescriptionEN = @"Hydrometric site description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description du site hydrométrique")]
        public string Description { get; set; }
        [StringLength(4)]
        [CSSPDisplayEN(DisplayEN = "Province")]
        [CSSPDisplayFR(DisplayFR = "Province")]
        [CSSPDescriptionEN(DescriptionEN = @"Province (4 characters)")]
        [CSSPDescriptionFR(DescriptionFR = @"Province (4 charactères)")]
        public string Province { get; set; }
        [Range(0.0D, 10000.0D)]
        [CSSPDisplayEN(DisplayEN = "Elevation")]
        [CSSPDisplayFR(DisplayFR = "Élévation")]
        [CSSPDescriptionEN(DescriptionEN = @"Site Elevation in meters above mean sea level")]
        [CSSPDescriptionFR(DescriptionFR = @"Élévation du site en mètres au dessus du niveau moyen de la mer")]
        public double? Elevation_m { get; set; }
        [CSSPAfter(Year = 1849)]
        [CSSPDisplayEN(DisplayEN = "Start date")]
        [CSSPDisplayFR(DisplayFR = "Date de début")]
        [CSSPDescriptionEN(DescriptionEN = @"Data collection start date")]
        [CSSPDescriptionFR(DescriptionFR = @"Date de début de monitoring")]
        public DateTime? StartDate_Local { get; set; }
        [CSSPAfter(Year = 1849)]
        [CSSPBigger(OtherField = "StartDate_Local")]
        [CSSPDisplayEN(DisplayEN = "End date")]
        [CSSPDisplayFR(DisplayFR = "Date de fin")]
        [CSSPDescriptionEN(DescriptionEN = @"Data collection end date")]
        [CSSPDescriptionFR(DescriptionFR = @"Date de fin de monitoring")]
        public DateTime? EndDate_Local { get; set; }
        [Range(-10.0D, 0.0D)]
        [CSSPDisplayEN(DisplayEN = "Time offset (h)")]
        [CSSPDisplayFR(DisplayFR = "Décalage horaire (h)")]
        [CSSPDescriptionEN(DescriptionEN = @"Time offset in hour (decimal)")]
        [CSSPDescriptionFR(DescriptionFR = @"Décalage horaire en heure (décimal)")]
        public double? TimeOffset_hour { get; set; }
        [Range(0.0D, 1000000.0D)]
        [CSSPDisplayEN(DisplayEN = "Drainage area (km2)")]
        [CSSPDisplayFR(DisplayFR = "Bassin versant (km2)")]
        [CSSPDescriptionEN(DescriptionEN = @"Drainage area in square kilometers")]
        [CSSPDescriptionFR(DescriptionFR = @"Bassin versant en kilomètres carrés")]
        public double? DrainageArea_km2 { get; set; }
        [CSSPDisplayEN(DisplayEN = "Is natural")]
        [CSSPDisplayFR(DisplayFR = "Est naturel")]
        [CSSPDescriptionEN(DescriptionEN = @"Regulartion type")]
        [CSSPDescriptionFR(DescriptionFR = @"Régime naturel")]
        public bool? IsNatural { get; set; }
        [CSSPDisplayEN(DisplayEN = "Is active")]
        [CSSPDisplayFR(DisplayFR = "Est active")]
        [CSSPDescriptionEN(DescriptionEN = @"Is currently active")]
        [CSSPDescriptionFR(DescriptionFR = @"Est maintenant active")]
        public bool? IsActive { get; set; }
        [CSSPDisplayEN(DisplayEN = "Sediment")]
        [CSSPDisplayFR(DisplayFR = "Sédiments")]
        [CSSPDescriptionEN(DescriptionEN = @"Sediment data available")]
        [CSSPDescriptionFR(DescriptionFR = @"Données sur les sédiments disponibles")]
        public bool? Sediment { get; set; }
        [CSSPDisplayEN(DisplayEN = "RHBN")]
        [CSSPDisplayFR(DisplayFR = "RHR")]
        [CSSPDescriptionEN(DescriptionEN = @"Reference hydrometric based network")]
        [CSSPDescriptionFR(DescriptionFR = @"Réseau hydrométrique de référence")]
        public bool? RHBN { get; set; }
        [CSSPDisplayEN(DisplayEN = "Real-Time")]
        [CSSPDisplayFR(DisplayFR = "Temps réel")]
        [CSSPDescriptionEN(DescriptionEN = @"Real-time data available")]
        [CSSPDescriptionFR(DescriptionFR = @"Données en temps réel disponibles")]
        public bool? RealTime { get; set; }
        [CSSPDisplayEN(DisplayEN = "Measure discharges")]
        [CSSPDisplayFR(DisplayFR = "Mesure débits")]
        [CSSPDescriptionEN(DescriptionEN = @"Measure discharges")]
        [CSSPDescriptionFR(DescriptionFR = @"Mesure débits")]
        public bool? HasDischarge { get; set; }
        [CSSPDisplayEN(DisplayEN = "Measure levels")]
        [CSSPDisplayFR(DisplayFR = "Mesure niveaux")]
        [CSSPDescriptionEN(DescriptionEN = @"Measure levels")]
        [CSSPDescriptionFR(DescriptionFR = @"Mesure niveaux")]
        public bool? HasLevel { get; set; }
        [CSSPDisplayEN(DisplayEN = "Rating curve")]
        [CSSPDisplayFR(DisplayFR = "Courbe de tarage")]
        [CSSPDescriptionEN(DescriptionEN = @"Rating curve")]
        [CSSPDescriptionFR(DescriptionFR = @"Courbe de tarage")]
        public bool? HasRatingCurve { get; set; }
        #endregion Properties in DB

        #region Constructors
        public HydrometricSite() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class HydrometricSite_A : HydrometricSite
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "HydrometricSiteTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "HydrometricSite TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage de HydrometricSite")]
        [CSSPDescriptionEN(DescriptionEN = @"HydrometricSite TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage de HydrometricSite")]
        public TVItemLanguage HydrometricTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public HydrometricSite_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class HydrometricSite_B : HydrometricSite_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string HydrometricSiteReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public HydrometricSite_B() : base()
        {
        }
        #endregion Constructors
    }
}
