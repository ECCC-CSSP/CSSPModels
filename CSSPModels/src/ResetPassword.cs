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
    public partial class ResetPassword : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "ResetPassword ID")]
        [CSSPDisplayFR(DisplayFR = "ResetPassword ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the ResetPasswords table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table ResetPasswords")]
        public int ResetPasswordID { get; set; }
        [StringLength(256)]
        public string Email { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime ExpireDate_Local { get; set; }
        [StringLength(8)]
        public string Code { get; set; }
        #endregion Properties in DB

        #region Constructors
        public ResetPassword() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ResetPassword_A : ResetPassword
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
        public ResetPassword_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ResetPassword_B : ResetPassword_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string ResetPasswordReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public ResetPassword_B() : base()
        {
        }
        #endregion Constructors
    }
}
