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
        [CSSPDisplayEN(DisplayEN = "InfrastructureLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "InfrastructureLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the InfrastructureLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau InfrastructureLanguages")]
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
        public InfrastructureLanguageWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class InfrastructureLanguageReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string InfrastructureLanguageReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public InfrastructureLanguageReport()
        {
        }
        #endregion Constructors
    }
}
