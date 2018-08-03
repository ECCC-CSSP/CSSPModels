/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class EmailDistributionListContactLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "EmailDistributionListContactLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "EmailDistributionListContactLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the EmailDistributionListContactLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau EmailDistributionListContactLanguages")]
        public int EmailDistributionListContactLanguageID { get; set; }
        [CSSPExist(ExistTypeName = "EmailDistributionListContact", ExistPlurial = "s", ExistFieldID = "EmailDistributionListContactID")]
        public int EmailDistributionListContactID { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [StringLength(100, MinimumLength = 1)]
        public string Agency { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatus { get; set; }
        #endregion Properties in DB

        #region Constructors
        public EmailDistributionListContactLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class EmailDistributionListContactLanguageWeb : EmailDistributionListContactLanguage
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "LanguageEnum", EnumType = "Language")]
        [CSSPAllowNull]
        public string LanguageText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatus")]
        [CSSPAllowNull]
        public string TranslationStatusText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public EmailDistributionListContactLanguageWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class EmailDistributionListContactLanguageReport : EmailDistributionListContactLanguageWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string EmailDistributionListContactLanguageReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public EmailDistributionListContactLanguageReport() : base()
        {
        }
        #endregion Constructors
    }
}
