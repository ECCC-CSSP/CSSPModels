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
        [CSSPExist(ExistTypeName = "Contact", ExistPlurial = "s", ExistFieldID = "ContactID")]
        public int ContactID { get; set; }
        [StringLength(200)]
        [DataType(DataType.EmailAddress)]
        public string LoginEmail { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string LastUpdateContactTVText { get; set; }
        [NotMapped]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }
        [NotMapped]
        [StringLength(100, MinimumLength = 6)]
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
