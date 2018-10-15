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
    public partial class TVFileLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "TVFileLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "TVFileLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the TVFileLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table TVFileLanguages")]
        public int TVFileLanguageID { get; set; }
        [CSSPExist(ExistTypeName = "TVFile", ExistPlurial = "s", ExistFieldID = "TVFileID")]
        [CSSPDisplayEN(DisplayEN = "TV file ID")]
        [CSSPDisplayFR(DisplayFR = "Filière de l'arbre visuel ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVFiles table representing the tree view file")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVFiles représentant la filière de l'arbre visuel")]
        public int TVFileID { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Language")]
        [CSSPDisplayFR(DisplayFR = "Langage")]
        [CSSPDescriptionEN(DescriptionEN = @"Language of item")]
        [CSSPDescriptionFR(DescriptionFR = @"Langage de l'item")]
        public LanguageEnum Language { get; set; }
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "File description")]
        [CSSPDisplayFR(DisplayFR = "Description du fichier")]
        [CSSPDescriptionEN(DescriptionEN = @"File description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description du fichier")]
        public string FileDescription { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Translation status")]
        [CSSPDisplayFR(DisplayFR = "Le statut de la traduction")]
        [CSSPDescriptionEN(DescriptionEN = @"Translation status of the file description")]
        [CSSPDescriptionFR(DescriptionFR = @"Le statut de la traduction de la description du fichier")]
        public TranslationStatusEnum TranslationStatus { get; set; }
        #endregion Properties in DB

        #region Constructors
        public TVFileLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVFileLanguageExtraA : TVFileLanguage
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
        [CSSPDescriptionEN(DescriptionEN = @"Translation status text of the TVFile")]
        [CSSPDescriptionFR(DescriptionFR = @"Le texte du statut de la traduction de TVFile")]
        public string TranslationStatusText { get; set; }
        #endregion Properties

        #region Constructors
        public TVFileLanguageExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVFileLanguageExtraB : TVFileLanguageExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string TVFileLanguageReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public TVFileLanguageExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
