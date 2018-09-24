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
        [CSSPDisplayEN(DisplayEN = "Report type ID")]
        [CSSPDisplayFR(DisplayFR = "Type de raport ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the ReportTypes table representing the report type")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table ReportTypes représentant le type de raport")]
        public int ReportTypeID { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Language")]
        [CSSPDisplayFR(DisplayFR = "Langage")]
        [CSSPDescriptionEN(DescriptionEN = @"Language of item")]
        [CSSPDescriptionFR(DescriptionFR = @"Langage de l'item")]
        public LanguageEnum Language { get; set; }
        [StringLength(100)]
        [CSSPDisplayEN(DisplayEN = "Name")]
        [CSSPDisplayFR(DisplayFR = "Nom")]
        [CSSPDescriptionEN(DescriptionEN = @"Name of the report type")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du type de raport")]
        public string Name { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Translation status")]
        [CSSPDisplayFR(DisplayFR = "Le statut de la traduction")]
        [CSSPDescriptionEN(DescriptionEN = @"Translation status of the report type name")]
        [CSSPDescriptionFR(DescriptionFR = @"Le statut de la traduction du nom du type de raport")]
        public TranslationStatusEnum TranslationStatusName { get; set; }
        [StringLength(1000)]
        [CSSPDisplayEN(DisplayEN = "Description")]
        [CSSPDisplayFR(DisplayFR = "Description")]
        [CSSPDescriptionEN(DescriptionEN = @"Description of the report type")]
        [CSSPDescriptionFR(DescriptionFR = @"Description du type de raport")]
        public string Description { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Translation status")]
        [CSSPDisplayFR(DisplayFR = "Le statut de la traduction")]
        [CSSPDescriptionEN(DescriptionEN = @"Translation status of the report type description")]
        [CSSPDescriptionFR(DescriptionFR = @"Le statut de la traduction de la description du type de raport")]
        public TranslationStatusEnum TranslationStatusDescription { get; set; }
        [StringLength(100)]
        [CSSPDisplayEN(DisplayEN = "Start of file name")]
        [CSSPDisplayFR(DisplayFR = "Début du nom de la filière")]
        [CSSPDescriptionEN(DescriptionEN = @"Start of file name")]
        [CSSPDescriptionFR(DescriptionFR = @"Début du nom de la filière")]
        public string StartOfFileName { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Translation status")]
        [CSSPDisplayFR(DisplayFR = "Le statut de la traduction")]
        [CSSPDescriptionEN(DescriptionEN = @"Translation status of the start of file name")]
        [CSSPDescriptionFR(DescriptionFR = @"Le statut de la traduction du début du nom de la filière")]
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
        [CSSPDisplayEN(DisplayEN = "Language text")]
        [CSSPDisplayFR(DisplayFR = "Texte du langage")]
        [CSSPDescriptionEN(DescriptionEN = @"Language text [en, fr]")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du langage [en, fr]")]
        public string LanguageText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusName")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Translation status text")]
        [CSSPDisplayFR(DisplayFR = "Le texte du statut de la traduction")]
        [CSSPDescriptionEN(DescriptionEN = @"Translation status text of the report type name")]
        [CSSPDescriptionFR(DescriptionFR = @"Le texte du statut de la traduction du nom du type de raport")]
        public string TranslationStatusNameText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusDescription")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Translation status text")]
        [CSSPDisplayFR(DisplayFR = "Le texte du statut de la traduction")]
        [CSSPDescriptionEN(DescriptionEN = @"Translation status text of the report type description")]
        [CSSPDescriptionFR(DescriptionFR = @"Le texte du statut de la traduction de la description du type de raport")]
        public string TranslationStatusDescriptionText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusStartOfFileName")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Translation status text")]
        [CSSPDisplayFR(DisplayFR = "Le texte du statut de la traduction")]
        [CSSPDescriptionEN(DescriptionEN = @"Translation status text of the start of file name")]
        [CSSPDescriptionFR(DescriptionFR = @"Le texte du statut de la traduction du début du nom de la filière")]
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
