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
    public partial class SamplingPlanEmail : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "SamplingPlanEmail ID")]
        [CSSPDisplayFR(DisplayFR = "SamplingPlanEmail ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the SamplingPlanEmails table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table SamplingPlanEmails")]
        public int SamplingPlanEmailID { get; set; }
        [CSSPExist(ExistTypeName = "SamplingPlan", ExistPlurial = "s", ExistFieldID = "SamplingPlanID")]
        public int SamplingPlanID { get; set; }
        [StringLength(150)]
        public string Email { get; set; }
        public bool IsContractor { get; set; }
        public bool LabSheetHasValueOver500 { get; set; }
        public bool LabSheetReceived { get; set; }
        public bool LabSheetAccepted { get; set; }
        public bool LabSheetRejected { get; set; }
        #endregion Properties in DB

        #region Constructors
        public SamplingPlanEmail() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SamplingPlanEmail_A : SamplingPlanEmail
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
        public SamplingPlanEmail_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SamplingPlanEmail_B : SamplingPlanEmail_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string SamplingPlanEmailReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public SamplingPlanEmail_B() : base()
        {
        }
        #endregion Constructors
    }
}
