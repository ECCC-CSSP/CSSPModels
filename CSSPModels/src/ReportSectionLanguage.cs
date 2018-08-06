﻿/*
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
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table ReportSectionLanguages")]
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

        #region Constructors
        public ReportSectionLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ReportSectionLanguageWeb : ReportSectionLanguage
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
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
        public ReportSectionLanguageWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ReportSectionLanguageReport : ReportSectionLanguageWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string ReportSectionLanguageReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public ReportSectionLanguageReport() : base()
        {
        }
        #endregion Constructors
    }
}
