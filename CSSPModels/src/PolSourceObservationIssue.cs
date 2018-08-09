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
        public int PolSourceObservationID { get; set; }
        [StringLength(250)]
        public string ObservationInfo { get; set; }
        [Range(0, 1000)]
        public int Ordinal { get; set; }
        [CSSPAllowNull]
        public string ExtraComment { get; set; }
        #endregion Properties in DB

        #region Constructors
        public PolSourceObservationIssue() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class PolSourceObservationIssue_A : PolSourceObservationIssue
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
        public PolSourceObservationIssue_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class PolSourceObservationIssue_B : PolSourceObservationIssue_A
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
        public PolSourceObservationIssue_B() : base()
        {
        }
        #endregion Constructors
    }
}
