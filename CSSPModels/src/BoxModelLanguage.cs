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
    public partial class BoxModelLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "BoxModelLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "BoxModelLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the BoxModelLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table BoxModelLanguages")]
        public int BoxModelLanguageID { get; set; }
        [CSSPExist(ExistTypeName = "BoxModel", ExistPlurial = "s", ExistFieldID = "BoxModelID")]
        [CSSPDisplayEN(DisplayEN = "BoxModel link")]
        [CSSPDisplayFR(DisplayFR = "Lien BoxModel")]
        [CSSPDescriptionEN(DescriptionEN = @"BoxModel link to parent BoxModels table item")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien au parent BoxModel à l'item de la table BoxModels")]
        public int BoxModelID { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Language")]
        [CSSPDisplayFR(DisplayFR = "Langage")]
        [CSSPDescriptionEN(DescriptionEN = @"Language of item")]
        [CSSPDescriptionFR(DescriptionFR = @"Langage de l'item")]
        public LanguageEnum Language { get; set; }
        [StringLength(250)]
        [CSSPDisplayEN(DisplayEN = "Scenario name")]
        [CSSPDisplayFR(DisplayFR = "Nom du scénario")]
        [CSSPDescriptionEN(DescriptionEN = @"Scenario name of the box model")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du scénario de box model")]
        public string ScenarioName { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Translation status")]
        [CSSPDisplayFR(DisplayFR = "Le statut de la traduction")]
        [CSSPDescriptionEN(DescriptionEN = @"Translation status of the scenario name")]
        [CSSPDescriptionFR(DescriptionFR = @"Le statut de la traduction du nom du scénario")]
        public TranslationStatusEnum TranslationStatus { get; set; }
        #endregion Properties in DB

        #region Constructors
        public BoxModelLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class BoxModelLanguageExtraA : BoxModelLanguage
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
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatus")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Translation status text")]
        [CSSPDisplayFR(DisplayFR = "Le texte du statut de la traduction")]
        [CSSPDescriptionEN(DescriptionEN = @"Translation status text of the BoxModel")]
        [CSSPDescriptionFR(DescriptionFR = @"Le texte du statut de la traduction de BoxModel")]
        public string TranslationStatusText { get; set; }
        #endregion Properties

        #region Constructors
        public BoxModelLanguageExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class BoxModelLanguageExtraB : BoxModelLanguageExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string BoxModelLanguageReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public BoxModelLanguageExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
