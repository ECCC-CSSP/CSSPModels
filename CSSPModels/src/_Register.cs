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
    [NotMapped]
    public partial class Register : Error
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
        #endregion Properties not in DB

        #region Constructors
        public Register() : base()
        {
        }
        #endregion Constructors
    }
}
