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
        [Range(1, -1)]
        public int TVItemUserAuthID { get; set; }
        [StringLength(255, MinimumLength = 1)]
        public string TVText { get; set; }
        [Range(1, -1)]
        public int TVItemID1 { get; set; }
        [StringLength(255, MinimumLength = 1)]
        public string TVTypeStr { get; set; }
        [CSSPEnumType]
        public TVAuthEnum TVAuth { get; set; }
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "TVAuthEnum", EnumType = "TVAuth")]
        public string TVAuthText { get; set; }
        public bool HasErrors { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVItemTVAuth()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
