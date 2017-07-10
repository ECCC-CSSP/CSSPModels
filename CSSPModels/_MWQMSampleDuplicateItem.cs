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
        [Range(1, 200)]
        public string ParentSite { get; set; }
        [Range(1, 200)]
        public string DuplicateSite { get; set; }

        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MWQMSampleDuplicateItem()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
