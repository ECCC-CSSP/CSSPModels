using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class AppTaskLanguage
    {
        #region Properties in DB
        public int AppTaskLanguageID { get; set; }
        public int AppTaskID { get; set; }
        public LanguageEnum Language { get; set; }
        public string StatusText { get; set; }
        public string ErrorText { get; set; }
        public TranslationStatusEnum TranslationStatus { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual AppTask AppTask { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public AppTaskLanguage()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
