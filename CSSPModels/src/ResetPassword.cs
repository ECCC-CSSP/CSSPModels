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
        public int ResetPasswordID { get; set; }
        [StringLength(256)]
        public string Email { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime ExpireDate_Local { get; set; }
        [StringLength(8)]
        public string Code { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public ResetPasswordWeb ResetPasswordWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public ResetPasswordReport ResetPasswordReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ResetPassword() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ResetPasswordWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        [CSSPAllowNull]
        public string Password { get; set; }
        [CSSPAllowNull]
        public string ConfirmPassword { get; set; }
        #endregion Properties for web information

        #region Constructors
        public ResetPasswordWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ResetPasswordReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string ResetPasswordReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public ResetPasswordReport()
        {
        }
        #endregion Constructors
    }
}
