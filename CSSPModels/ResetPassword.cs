using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class ResetPassword
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
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Contact)]
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
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
        public ResetPassword()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
