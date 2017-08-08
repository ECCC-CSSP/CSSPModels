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
        [Key]
        public int MWQMSubsectorLanguageID { get; set; }
        [CSSPExist(ExistTypeName = "MWQMSubsector", ExistPlurial = "s", ExistFieldID = "MWQMSubsectorID")]
        public int MWQMSubsectorID { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [StringLength(250)]
        public string SubsectorDesc { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatus { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string LastUpdateContactTVText { get; set; }
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "LanguageEnum", EnumType = "Language")]
        public string LanguageText { get; set; }
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatus")]
        public string TranslationStatusText { get; set; }
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
