using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class ContactLogin
    {     
        #region Properties in DB
        public int ContactLoginID { get; set; }
        public int ContactID { get; set; }
        public string LoginEmail { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }
              
        public virtual Contact Contact { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [Required]
        [Range(6, 100)]
        public string Password { get; set; }
        [NotMapped]
        [Required]
        [Range(6, 100)]
        public string ConfirmPassword { get; set; }
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ContactLogin()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
