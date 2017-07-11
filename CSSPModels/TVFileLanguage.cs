using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class TVFileLanguage
    {
        #region Properties in DB
        public int TVFileLanguageID { get; set; }
        public int TVFileID { get; set; }
        public LanguageEnum Language { get; set; }
        public string FileDescription { get; set; }
        public TranslationStatusEnum TranslationStatus { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual TVFile TVFile { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVFileLanguage()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
