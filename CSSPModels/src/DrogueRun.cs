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
    public partial class DrogueRun : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "Drogue run ID")]
        [CSSPDisplayFR(DisplayFR = "Drogue run ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the DrogueRuns table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table DrogueRuns")]
        public int DrogueRunID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]
        [CSSPDisplayEN(DisplayEN = "Subsector")]
        [CSSPDisplayFR(DisplayFR = "Sous-secteur")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the subsector")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant le sous-secteur")]
        public int SubsectorTVItemID { get; set; }
        [Range(0, 100)]
        [CSSPDisplayEN(DisplayEN = "Drogue number")]
        [CSSPDisplayFR(DisplayFR = "Numéro de drogue")]
        [CSSPDescriptionEN(DescriptionEN = @"Drogue number")]
        [CSSPDescriptionFR(DescriptionFR = @"Numéro de drogue")]
        public int DrogueNumber { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Drogue type")]
        [CSSPDisplayFR(DisplayFR = "Type de drogue")]
        [CSSPDescriptionEN(DescriptionEN = @"Drogue type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type de drogue")]
        public DrogueTypeEnum DrogueType { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPDisplayEN(DisplayEN = "Drogue run start date and time (local)")]
        [CSSPDisplayFR(DisplayFR = "Date et temps de départ de la run drogue (local)")]
        [CSSPDescriptionEN(DescriptionEN = @"Drogue run start date and time (local)")]
        [CSSPDescriptionFR(DescriptionFR = @"Date et temps de départ de la run drogue (local)")]
        public DateTime RunStartDateTime { get; set; }
        #endregion Properties in DB

        #region Constructors
        public DrogueRun() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class DrogueRunExtraA : DrogueRun
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact ayant fait le dernière changement")]
        public string LastUpdateContactText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "DrogueTypeEnum", EnumType = "DrogueType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Drogue type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type de drogue")]
        [CSSPDescriptionEN(DescriptionEN = @"Drogue type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type de drogue")]
        public string DrogueTypeText { get; set; }
        #endregion Properties

        #region Constructors
        public DrogueRunExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class DrogueRunExtraB : DrogueRunExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string DrogueRunReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public DrogueRunExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
