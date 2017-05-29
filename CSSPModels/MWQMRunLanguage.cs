using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MWQMRunLanguage
    {
        #region Properties in DB
        public int MWQMRunLanguageID { get; set; }
        public int MWQMRunID { get; set; }
        public LanguageEnum Language { get; set; }
        public string RunComment { get; set; }
        public TranslationStatusEnum TranslationStatusRunComment { get; set; }
        public string RunWeatherComment { get; set; }
        public TranslationStatusEnum TranslationStatusRunWeatherComment { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual MWQMRun MWQMRun { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MWQMRunLanguage()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
