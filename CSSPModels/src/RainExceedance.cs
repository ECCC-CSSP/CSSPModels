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
    public partial class RainExceedance : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "RainExceedance ID")]
        [CSSPDisplayFR(DisplayFR = "RainExceedance ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the RainExceedances table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table RainExceedances")]
        public int RainExceedanceID { get; set; }
        [CSSPDisplayEN(DisplayEN = "Year round")]
        [CSSPDisplayFR(DisplayFR = "Toute l'année")]
        [CSSPDescriptionEN(DescriptionEN = @"Year round")]
        [CSSPDescriptionFR(DescriptionFR = @"Toute l'année")]
        public bool YearRound { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPDisplayEN(DisplayEN = "Start date")]
        [CSSPDisplayFR(DisplayFR = "Date de début")]
        [CSSPDescriptionEN(DescriptionEN = @"Start date")]
        [CSSPDescriptionFR(DescriptionFR = @"Date de début")]
        public DateTime? StartDate_Local { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPBigger(OtherField = "StartDate_Local")]
        [CSSPDisplayEN(DisplayEN = "End date")]
        [CSSPDisplayFR(DisplayFR = "Date de fin")]
        [CSSPDescriptionEN(DescriptionEN = @"End date")]
        [CSSPDescriptionFR(DescriptionFR = @"Date de fin")]
        public DateTime? EndDate_Local { get; set; }
        [Range(0.0D, 300.0D)]
        [CSSPDisplayEN(DisplayEN = "Rain maximum (mm)")]
        [CSSPDisplayFR(DisplayFR = "Pluie maximale (mm)")]
        [CSSPDescriptionEN(DescriptionEN = @"Rain maximum in millimètres")]
        [CSSPDescriptionFR(DescriptionFR = @"Pluie maximale en millimètres")]
        public double? RainMaximum_mm { get; set; }
        [Range(0.0D, 300.0D)]
        [CSSPDisplayEN(DisplayEN = "Rain extreme (mm)")]
        [CSSPDisplayFR(DisplayFR = "Pluie extrême (mm)")]
        [CSSPDescriptionEN(DescriptionEN = @"Rain extreme in millimètres")]
        [CSSPDescriptionFR(DescriptionFR = @"Pluie extrême en millimètres")]
        public double? RainExtreme_mm { get; set; }
        [Range(0, 30)]
        [CSSPDisplayEN(DisplayEN = "Number of days prior to start")]
        [CSSPDisplayFR(DisplayFR = "Nombre de jour avant le début")]
        [CSSPDescriptionEN(DescriptionEN = @"Number of days prior to start")]
        [CSSPDescriptionFR(DescriptionFR = @"Nombre de jour avant le début")]
        public int DaysPriorToStart { get; set; }
        [CSSPDisplayEN(DisplayEN = "Repeat every year")]
        [CSSPDisplayFR(DisplayFR = "Répété tous les années")]
        [CSSPDescriptionEN(DescriptionEN = @"Repeat every year")]
        [CSSPDescriptionFR(DescriptionFR = @"Répété tous les années")]
        public bool RepeatEveryYear { get; set; }
        [StringLength(250)]
        [CSSPDisplayEN(DisplayEN = "Province TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Province TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the province")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant la province")]
        public string ProvinceTVItemIDs { get; set; }
        [StringLength(250)]
        [CSSPDisplayEN(DisplayEN = "Subsector TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Sous-secteur TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the subsector")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant le sous-secteur")]
        public string SubsectorTVItemIDs { get; set; }
        [StringLength(250)]
        [CSSPDisplayEN(DisplayEN = "Climate site TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Site climatique TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the climate site")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant le site climatique")]
        public string ClimateSiteTVItemIDs { get; set; }
        [StringLength(250)]
        [CSSPDisplayEN(DisplayEN = "Email distribution list ID")]
        [CSSPDisplayFR(DisplayFR = "Liste de distribution de courriels ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the email distribution list")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant la liste de distribution de courriels")]
        public string EmailDistributionListIDs { get; set; }
        #endregion Properties in DB

        #region Constructors
        public RainExceedance() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class RainExceedance_A : RainExceedance
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Province TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage de la province")]
        [CSSPDescriptionEN(DescriptionEN = @"Province TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage de la province")]
        public TVItemLanguage ProvinceTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Subsector TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du sous-secteur")]
        [CSSPDescriptionEN(DescriptionEN = @"Subsector TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du sous-secteur")]
        public TVItemLanguage SubsectorTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Climate site TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du site climatique")]
        [CSSPDescriptionEN(DescriptionEN = @"Climate site TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du site climatique")]
        public TVItemLanguage ClimateSiteTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public RainExceedance_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class RainExceedance_B : RainExceedance_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string RainExceedanceReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public RainExceedance_B() : base()
        {
        }
        #endregion Constructors
    }
}
