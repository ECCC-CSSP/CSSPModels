using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    /// <summary>
    ///     Entity object for CSSPModels.Registers DB Table
    /// </summary>
    [NotMapped]
    public partial class Register
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(255, MinimumLength = 6)]
        public string LoginEmail { get; set; }
        [StringLength(100, MinimumLength = 1)]
        public string FirstName { get; set; }
        [StringLength(50)]
        [CSSPAllowNull]
        public string Initial { get; set; }
        [StringLength(100, MinimumLength = 1)]
        public string LastName { get; set; }
        [StringLength(100, MinimumLength = 1)]
        public string WebName { get; set; }
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }
        [StringLength(100, MinimumLength = 6)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public bool HasErrors { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Register()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
