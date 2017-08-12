using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class MWQMSampleDuplicateItem
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(200, MinimumLength = 1)]
        public string ParentSite { get; set; }
        [StringLength(200, MinimumLength = 1)]
        public string DuplicateSite { get; set; }

        public bool HasErrors { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MWQMSampleDuplicateItem()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
