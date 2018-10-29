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
    public partial class Spill : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "Spill ID")]
        [CSSPDisplayFR(DisplayFR = "Spill ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the Spills table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table Spills")]
        public int SpillID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "15")]
        [CSSPDisplayEN(DisplayEN = "Municipality TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Municipalité TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the municipality")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant la municipalité")]
        public int MunicipalityTVItemID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "10")]
        [CSSPDisplayEN(DisplayEN = "Infrastructure TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Infrastructure TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the infrastructure")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant l'infrastructure")]
        public int? InfrastructureTVItemID { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPDisplayEN(DisplayEN = "Start date (local)")]
        [CSSPDisplayFR(DisplayFR = "Date de début (local)")]
        [CSSPDescriptionEN(DescriptionEN = @"Start date (local)")]
        [CSSPDescriptionFR(DescriptionFR = @"Date de début (local)")]
        public DateTime StartDateTime_Local { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPBigger(OtherField = "StartDateTime_Local")]
        [CSSPDisplayEN(DisplayEN = "End date (local)")]
        [CSSPDisplayFR(DisplayFR = "Date de fin (local)")]
        [CSSPDescriptionEN(DescriptionEN = @"End date (local)")]
        [CSSPDescriptionFR(DescriptionFR = @"Date de fin (local)")]
        public DateTime? EndDateTime_Local { get; set; }
        [Range(0.0D, 1000000.0D)]
        [CSSPDisplayEN(DisplayEN = "Average flow (m3/d)")]
        [CSSPDisplayFR(DisplayFR = "Débit moyen (m3/j)")]
        [CSSPDescriptionEN(DescriptionEN = @"Average flow in cubic meters per day")]
        [CSSPDescriptionFR(DescriptionFR = @"Débit moyer en mètres cube par jour")]
        public double AverageFlow_m3_day { get; set; }
        #endregion Properties in DB

        #region Constructors
        public Spill() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SpillExtraA : Spill
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MunicipalityTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Municipality text")]
        [CSSPDisplayFR(DisplayFR = "Texte de la municipalité")]
        [CSSPDescriptionEN(DescriptionEN = @"Municipality text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de la municipalité")]
        public string MunicipalityText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "InfrastructureTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Infrastructure text")]
        [CSSPDisplayFR(DisplayFR = "Texte de l'infrastructure")]
        [CSSPDescriptionEN(DescriptionEN = @"Infrastructure text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de l'infrastructure")]
        public string InfrastructureText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact ayant fait le dernière changement")]
        public string LastUpdateContactText { get; set; }
        #endregion Properties

        #region Constructors
        public SpillExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SpillExtraB : SpillExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string SpillReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public SpillExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
