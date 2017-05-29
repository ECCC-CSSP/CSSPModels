using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MWQMSubsectorLanguage
    {
        #region Properties in DB
        public int MWQMSubsectorLanguageID { get; set; }
        public int MWQMSubsectorID { get; set; }
        public LanguageEnum Language { get; set; }
        public string SubsectorDesc { get; set; }
        public TranslationStatusEnum TranslationStatus { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual MWQMSubsector MWQMSubsector { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MWQMSubsectorLanguage()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
