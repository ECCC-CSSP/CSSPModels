using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class BoxModelLanguage
    {
        #region Properties in DB
        public int BoxModelLanguageID { get; set; }
        public int BoxModelID { get; set; }
        public LanguageEnum Language { get; set; }
        public string ScenarioName { get; set; }
        public TranslationStatusEnum TranslationStatus { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual BoxModel BoxModel { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public BoxModelLanguage()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
