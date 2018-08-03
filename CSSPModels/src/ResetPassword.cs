/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class ResetPassword : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "ResetPassword ID")]
        [CSSPDisplayFR(DisplayFR = "ResetPassword ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the ResetPasswords table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau ResetPasswords")]
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
    public partial class ResetPasswordWeb : ResetPassword
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties for web information

        #region Constructors
        public ResetPasswordWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ResetPasswordReport : ResetPasswordWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string ResetPasswordReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public ResetPasswordReport() : base()
        {
        }
        #endregion Constructors
    }
}
