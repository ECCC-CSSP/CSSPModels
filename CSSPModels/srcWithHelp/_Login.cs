using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class Login
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(200, MinimumLength = 6)]
        public string LoginEmail { get; set; }
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }
        [StringLength(100, MinimumLength = 6)]
        public string ConfirmPassword { get; set; }
        public bool HasErrors { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Login()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
