﻿/*
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
    public partial class TVItemLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "TVItemLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the TVItemLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table TVItemLanguages")]
        public int TVItemLanguageID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,9,10,11,12,13,14,15,16,17,18,19,20,21,31,79")]
        [CSSPDisplayEN(DisplayEN = "TV Item ID")]
        [CSSPDisplayFR(DisplayFR = "L'arbre visuel ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the tree view")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant l'arbre visuel")]
        public int TVItemID { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Language")]
        [CSSPDisplayFR(DisplayFR = "Langage")]
        [CSSPDescriptionEN(DescriptionEN = @"Language of item")]
        [CSSPDescriptionFR(DescriptionFR = @"Langage de l'item")]
        public LanguageEnum Language { get; set; }
        [StringLength(200)]
        [CSSPDisplayEN(DisplayEN = "TV text")]
        [CSSPDisplayFR(DisplayFR = "Texte de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de l'arbre visuel")]
        public string TVText { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Translation status")]
        [CSSPDisplayFR(DisplayFR = "Le statut de la traduction")]
        [CSSPDescriptionEN(DescriptionEN = @"Translation status of the tree view text")]
        [CSSPDescriptionFR(DescriptionFR = @"Le statut de la traduction du texte de l'arbre visuel")]
        public TranslationStatusEnum TranslationStatus { get; set; }
        #endregion Properties in DB

        #region Constructors
        public TVItemLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVItemLanguageExtraA : TVItemLanguage
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact ayant fait le dernière changement")]
        public string LastUpdateContactText { get; set; }
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
        [CSSPDescriptionEN(DescriptionEN = @"Translation status text of the TVItem")]
        [CSSPDescriptionFR(DescriptionFR = @"Le texte du statut de la traduction de TVItem")]
        public string TranslationStatusText { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemLanguageExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVItemLanguageExtraB : TVItemLanguageExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string TVItemLanguageReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemLanguageExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
