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
    public partial class ReportTypeLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "ReportTypeLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "ReportTypeLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the ReportTypeLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau ReportTypeLanguages")]
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

        #region Constructors
        public ReportTypeLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ReportTypeLanguageWeb : ReportTypeLanguage
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
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
        public ReportTypeLanguageWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ReportTypeLanguageReport : ReportTypeLanguageWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string ReportTypeLanguageReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public ReportTypeLanguageReport() : base()
        {
        }
        #endregion Constructors
    }
}
