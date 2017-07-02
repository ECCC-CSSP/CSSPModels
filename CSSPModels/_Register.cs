using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class Register
    {     
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Required]
        [Range(6, 255)]
        public string LoginEmail { get; set; }
        [Required]
        [Range(1, 100)]
        public string FirstName { get; set; }
        [Range(0, 50)]
        public string Initial { get; set; }
        [Required]
        [Range(1, 100)]
        public string LastName { get; set; }
        [Required]
        [Range(1, 100)]
        public string WebName { get; set; }
        [Required]
        [Range(6, 100)]
        public string Password { get; set; }
        [Required]
        [Range(6, 100)]
        public string ConfirmPassword { get; set; }

        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Register()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
