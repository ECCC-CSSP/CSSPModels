using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class ResetPassword
    {
        #region Properties in DB
        public int ResetPasswordID { get; set; }
        public string Email { get; set; }
        public DateTime ExpireDate_Local { get; set; }
        public string Code { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [Range(6, 100)]
        public string Password { get; set; }
        [NotMapped]
        [Range(6, 100)]
        public string ConfirmPassword { get; set; }
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ResetPassword()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
