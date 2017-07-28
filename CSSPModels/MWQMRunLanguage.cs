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
        [Key]
        public int MWQMRunLanguageID { get; set; }
        [CSSPExist(TypeName = "MWQMRun", Plurial = "s", FieldID = "MWQMRunID")]
        public int MWQMRunID { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        public string RunComment { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatusRunComment { get; set; }
        public string RunWeatherComment { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatusRunWeatherComment { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Contact)]
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
