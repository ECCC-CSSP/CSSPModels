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
        [Key]
        public int ContactLoginID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "Contact", Plurial = "s", FieldID = "ContactID")]
        public int ContactID { get; set; }
        [StringLength(200)]
        public string LoginEmail { get; set; }
        [StringLength(200)]
        public byte[] PasswordHash { get; set; }
        [StringLength(200)]
        public byte[] PasswordSalt { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual Contact Contact { get; set; }
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
        public ContactLogin()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
