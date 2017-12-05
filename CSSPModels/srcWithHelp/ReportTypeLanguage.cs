using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class ReportTypeLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int ReportTypeLanguageID { get; set; }
        [CSSPExist(ExistTypeName = "ReportType", ExistPlurial = "s", ExistFieldID = "ReportTypeID")]
        public int ReportTypeID { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatusName { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatusDescription { get; set; }
        [StringLength(100)]
        public string StartOfFileName { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatusStartOfFileName { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public ReportTypeLanguageWeb ReportTypeLanguageWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public ReportTypeLanguageReport ReportTypeLanguageReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ReportTypeLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ReportTypeLanguageWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "LanguageEnum", EnumType = "Language")]
        [CSSPAllowNull]
        public string LanguageText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusName")]
        [CSSPAllowNull]
        public string TranslationStatusNameText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusDescription")]
        [CSSPAllowNull]
        public string TranslationStatusDescriptionText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusStartOfFileName")]
        [CSSPAllowNull]
        public string TranslationStatusStartOfFileNameText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public ReportTypeLanguageWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ReportTypeLanguageReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string ReportTypeLanguageReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public ReportTypeLanguageReport()
        {
        }
        #endregion Constructors
    }
}
