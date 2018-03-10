using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class BoxModelLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int BoxModelLanguageID { get; set; }
        [CSSPExist(ExistTypeName = "BoxModel", ExistPlurial = "s", ExistFieldID = "BoxModelID")]
        public int BoxModelID { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [StringLength(250)]
        public string ScenarioName { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatus { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public BoxModelLanguageWeb BoxModelLanguageWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public BoxModelLanguageReport BoxModelLanguageReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public BoxModelLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class BoxModelLanguageWeb
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
        public BoxModelLanguageWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class BoxModelLanguageReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string BoxModelLanguageReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public BoxModelLanguageReport()
        {
        }
        #endregion Constructors
    }
}
