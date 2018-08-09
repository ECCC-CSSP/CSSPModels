/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CSSPModels
{
    public partial class ReportTypeLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "ReportTypeLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "ReportTypeLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the ReportTypeLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table ReportTypeLanguages")]
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
    public partial class ReportTypeLanguage_A : ReportTypeLanguage
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
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
        #endregion Properties

        #region Constructors
        public ReportTypeLanguage_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ReportTypeLanguage_B : ReportTypeLanguage_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string ReportTypeLanguageReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public ReportTypeLanguage_B() : base()
        {
        }
        #endregion Constructors
    }
}
