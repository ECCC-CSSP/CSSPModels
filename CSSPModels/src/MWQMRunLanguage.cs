using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MWQMRunLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int MWQMRunLanguageID { get; set; }
        [CSSPExist(ExistTypeName = "MWQMRun", ExistPlurial = "s", ExistFieldID = "MWQMRunID")]
        public int MWQMRunID { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        public string RunComment { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatusRunComment { get; set; }
        public string RunWeatherComment { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatusRunWeatherComment { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public MWQMRunLanguageWeb MWQMRunLanguageWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public MWQMRunLanguageReport MWQMRunLanguageReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MWQMRunLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMRunLanguageWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "LanguageEnum", EnumType = "Language")]
        [CSSPAllowNull]
        public string LanguageText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusRunComment")]
        [CSSPAllowNull]
        public string TranslationStatusRunCommentText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusRunWeatherComment")]
        [CSSPAllowNull]
        public string TranslationStatusRunWeatherCommentText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public MWQMRunLanguageWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMRunLanguageReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string MWQMRunLanguageReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public MWQMRunLanguageReport()
        {
        }
        #endregion Constructors
    }
}
