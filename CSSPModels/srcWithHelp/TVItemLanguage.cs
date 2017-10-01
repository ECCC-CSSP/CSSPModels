using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class TVItemLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int TVItemLanguageID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,6,18,3,19,20,4,8,9,10,12,11,13,14,15,31,16,23,17,40,26,22")]
        public int TVItemID { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [StringLength(200)]
        public string TVText { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatus { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public TVItemLanguageWeb TVItemLanguageWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public TVItemLanguageReport TVItemLanguageReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVItemLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVItemLanguageWeb
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
        public TVItemLanguageWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVItemLanguageReport
    {
        #region Properties for report information
        public string TVItemLanguageReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public TVItemLanguageReport()
        {
        }
        #endregion Constructors
    }
}
