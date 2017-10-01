using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class SpillLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int SpillLanguageID { get; set; }
        [CSSPExist(ExistTypeName = "Spill", ExistPlurial = "s", ExistFieldID = "SpillID")]
        public int SpillID { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        public string SpillComment { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatus { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public SpillLanguageWeb SpillLanguageWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public SpillLanguageReport SpillLanguageReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public SpillLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SpillLanguageWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string LastUpdateContactTVText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "LanguageEnum", EnumType = "Language")]
        public string LanguageText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatus")]
        public string TranslationStatusText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public SpillLanguageWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SpillLanguageReport
    {
        #region Properties for report information
        public string SpillLanguageReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public SpillLanguageReport()
        {
        }
        #endregion Constructors
    }
}
