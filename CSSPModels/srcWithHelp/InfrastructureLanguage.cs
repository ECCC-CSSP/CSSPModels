using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class InfrastructureLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int InfrastructureLanguageID { get; set; }
        [CSSPExist(ExistTypeName = "Infrastructure", ExistPlurial = "s", ExistFieldID = "InfrastructureID")]
        public int InfrastructureID { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        public string Comment { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatus { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public InfrastructureLanguageWeb InfrastructureLanguageWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public InfrastructureLanguageReport InfrastructureLanguageReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public InfrastructureLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class InfrastructureLanguageWeb
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
        public InfrastructureLanguageWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class InfrastructureLanguageReport
    {
        #region Properties for report information
        public string InfrastructureLanguageReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public InfrastructureLanguageReport()
        {
        }
        #endregion Constructors
    }
}
