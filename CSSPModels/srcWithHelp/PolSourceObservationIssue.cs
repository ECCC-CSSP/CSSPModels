using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class PolSourceObservationIssue : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "PolSourceObservationIssue ID")]
        [CSSPDisplayFR(DisplayFR = "PolSourceObservationIssue ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the PolSourceObservationIssues table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau PolSourceObservationIssues")]
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

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public PolSourceObservationIssueWeb PolSourceObservationIssueWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public PolSourceObservationIssueReport PolSourceObservationIssueReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public PolSourceObservationIssue() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class PolSourceObservationIssueWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public PolSourceObservationIssueWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class PolSourceObservationIssueReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string PolSourceObservationIssueReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public PolSourceObservationIssueReport()
        {
        }
        #endregion Constructors
    }
}
