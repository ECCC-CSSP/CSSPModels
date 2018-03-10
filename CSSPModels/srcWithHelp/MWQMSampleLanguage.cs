using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MWQMSampleLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int MWQMSampleLanguageID { get; set; }
        [CSSPExist(ExistTypeName = "MWQMSample", ExistPlurial = "s", ExistFieldID = "MWQMSampleID")]
        public int MWQMSampleID { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        public string MWQMSampleNote { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatus { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public MWQMSampleLanguageWeb MWQMSampleLanguageWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public MWQMSampleLanguageReport MWQMSampleLanguageReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MWQMSampleLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSampleLanguageWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "LanguageEnum", EnumType = "Language")]
        [CSSPAllowNull]
        public string LanguageText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatus")]
        [CSSPAllowNull]
        public string TranslationStatusText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public MWQMSampleLanguageWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSampleLanguageReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string MWQMSampleLanguageReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public MWQMSampleLanguageReport()
        {
        }
        #endregion Constructors
    }
}
