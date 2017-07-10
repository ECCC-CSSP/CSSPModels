using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class TVTextLanguage
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public string TVText { get; set; }
        public LanguageEnum Language { get; set; }

        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVTextLanguage()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
