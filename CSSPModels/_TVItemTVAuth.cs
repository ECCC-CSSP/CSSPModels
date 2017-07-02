using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class TVItemTVAuth
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public string Error { get; set; }
        [Required]
        [Range(1, -1)]
        public int TVItemUserAuthID { get; set; }
        [Required]
        [Range(1, 255)]
        public string TVText { get; set; }
        [Required]
        [Range(1, -1)]
        public int TVItemID1 { get; set; }
        public string TVTypeStr { get; set; }
        public TVAuthEnum TVAuth { get; set; }

        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVItemTVAuth()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
