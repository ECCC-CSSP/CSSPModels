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
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_Local { get; set; }
        [StringLength(200, MinimumLength = 1)]
        public string TVText { get; set; }
        public bool HasErrors { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public LastUpdateAndTVText()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
