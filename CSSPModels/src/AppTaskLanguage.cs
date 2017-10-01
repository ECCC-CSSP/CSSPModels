using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class AppTaskLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int AppTaskLanguageID { get; set; }
        [CSSPExist(ExistTypeName = "AppTask", ExistPlurial = "s", ExistFieldID = "AppTaskID")]
        public int AppTaskID { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [StringLength(250)]
        [CSSPAllowNull]
        public string StatusText { get; set; }
        [StringLength(250)]
        [CSSPAllowNull]
        public string ErrorText { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatus { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public AppTaskLanguageWeb AppTaskLanguageWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public AppTaskLanguageReport AppTaskLanguageReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public AppTaskLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class AppTaskLanguageWeb
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
        public AppTaskLanguageWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class AppTaskLanguageReport
    {
        #region Properties for report information
        public string AppTaskLanguageReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public AppTaskLanguageReport()
        {
        }
        #endregion Constructors
    }
}
