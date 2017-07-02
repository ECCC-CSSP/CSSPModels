using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class LastUpdateAndTVText
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public string Error { get; set; }
        [Required]
        public System.DateTime LastUpdateDate_UTC { get; set; }
        public System.DateTime LastUpdateDate_Local { get; set; }
        [Required]
        [Range(1, 200)]
        public string TVText { get; set; }

        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public LastUpdateAndTVText()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
