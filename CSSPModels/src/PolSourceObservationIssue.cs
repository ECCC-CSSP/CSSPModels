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
    public partial class PolSourceObservationIssue : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "PolSourceObservationIssue ID")]
        [CSSPDisplayFR(DisplayFR = "PolSourceObservationIssue ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the PolSourceObservationIssues table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table PolSourceObservationIssues")]
        public int PolSourceObservationIssueID { get; set; }
        [CSSPExist(ExistTypeName = "PolSourceObservation", ExistPlurial = "s", ExistFieldID = "PolSourceObservationID")]
        [CSSPDisplayEN(DisplayEN = "Pollution source observation ID")]
        [CSSPDisplayFR(DisplayFR = "Observation de la source de pollution ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the PolSourceObservations table representing the pollution source observation")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table PolSourceObservations représentant l'observation de source de pollution")]
        public int PolSourceObservationID { get; set; }
        [StringLength(250)]
        [CSSPDisplayEN(DisplayEN = "Observation information")]
        [CSSPDisplayFR(DisplayFR = "L'information de l'observation")]
        [CSSPDescriptionEN(DescriptionEN = @"Observation information is a series of numbers representing the path of a collection of descriptive text")]
        [CSSPDescriptionFR(DescriptionFR = @"L'information de l'observation est une liste de chiffres représentant la ligne d'une collection de texte descriptif")]
        public string ObservationInfo { get; set; }
        [Range(0, 1000)]
        [CSSPDisplayEN(DisplayEN = "Ordinal")]
        [CSSPDisplayFR(DisplayFR = "Ordre")]
        [CSSPDescriptionEN(DescriptionEN = @"Ordinal")]
        [CSSPDescriptionFR(DescriptionFR = @"Ordre")]
        public int Ordinal { get; set; }
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Extra comment")]
        [CSSPDisplayFR(DisplayFR = "Commentaire d'extra")]
        [CSSPDescriptionEN(DescriptionEN = @"Extra comment")]
        [CSSPDescriptionFR(DescriptionFR = @"Commentaire d'extra")]
        public string ExtraComment { get; set; }
        #endregion Properties in DB

        #region Constructors
        public PolSourceObservationIssue() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class PolSourceObservationIssueExtraA : PolSourceObservationIssue
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public PolSourceObservationIssueExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class PolSourceObservationIssueExtraB : PolSourceObservationIssueExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string PolSourceObservationIssueReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public PolSourceObservationIssueExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
