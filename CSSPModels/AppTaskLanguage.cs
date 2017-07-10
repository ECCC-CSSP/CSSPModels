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
        [Key]
        public int AppTaskLanguageID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "AppTask", Plurial = "s", FieldID = "AppTaskID")]
        public int AppTaskID { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [StringLength(250)]
        public string StatusText { get; set; }
        [StringLength(250)]
        public string ErrorText { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatus { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
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
