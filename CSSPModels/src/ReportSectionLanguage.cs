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
    public partial class ReportSectionLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "ReportSectionLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "ReportSectionLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the ReportSectionLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau ReportSectionLanguages")]
        public int ReportSectionLanguageID { get; set; }
        [CSSPExist(ExistTypeName = "ReportSection", ExistPlurial = "s", ExistFieldID = "ReportSectionID")]
        public int ReportSectionID { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [StringLength(100)]
        public string ReportSectionName { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatusReportSectionName { get; set; }
        [StringLength(10000)]
        public string ReportSectionText { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatusReportSectionText { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public ReportSectionLanguageWeb ReportSectionLanguageWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public ReportSectionLanguageReport ReportSectionLanguageReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ReportSectionLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ReportSectionLanguageWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "LanguageEnum", EnumType = "Language")]
        [CSSPAllowNull]
        public string LanguageText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusReportSectionName")]
        [CSSPAllowNull]
        public string TranslationStatusReportSectionNameText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusReportSectionText")]
        [CSSPAllowNull]
        public string TranslationStatusReportSectionNameTextText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public ReportSectionLanguageWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ReportSectionLanguageReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string ReportSectionLanguageReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public ReportSectionLanguageReport()
        {
        }
        #endregion Constructors
    }
}
