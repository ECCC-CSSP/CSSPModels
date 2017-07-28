using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class SpillLanguage
    {
        #region Properties in DB
        [Key]
        public int SpillLanguageID { get; set; }
        [CSSPExist(TypeName = "Spill", Plurial = "s", FieldID = "SpillID")]
        public int SpillID { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        public string SpillComment { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatus { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Contact)]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual Spill Spill { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public SpillLanguage()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
