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
    public partial class MWQMSampleLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MWQMSampleLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "MWQMSampleLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MWQMSampleLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table MWQMSampleLanguages")]
        public int MWQMSampleLanguageID { get; set; }
        [CSSPExist(ExistTypeName = "MWQMSample", ExistPlurial = "s", ExistFieldID = "MWQMSampleID")]
        [CSSPDisplayEN(DisplayEN = "MWQM sample ID")]
        [CSSPDisplayFR(DisplayFR = "Échantillon MWQM ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the MWQMSamples table representing the MWQM sample")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table MWQMSamples représentant l'échantillon MWQM")]
        public int MWQMSampleID { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Language")]
        [CSSPDisplayFR(DisplayFR = "Langage")]
        [CSSPDescriptionEN(DescriptionEN = @"Language of item")]
        [CSSPDescriptionFR(DescriptionFR = @"Langage de l'item")]
        public LanguageEnum Language { get; set; }
        [CSSPDisplayEN(DisplayEN = "MWQM sample note")]
        [CSSPDisplayFR(DisplayFR = "Échantillon MWQM note")]
        [CSSPDescriptionEN(DescriptionEN = @"MWQM sample note")]
        [CSSPDescriptionFR(DescriptionFR = @"Échantillon MWQM note")]
        public string MWQMSampleNote { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Translation status")]
        [CSSPDisplayFR(DisplayFR = "Le statut de la traduction")]
        [CSSPDescriptionEN(DescriptionEN = @"Translation status of the comment")]
        [CSSPDescriptionFR(DescriptionFR = @"Le statut de la traduction du commentaire")]
        public TranslationStatusEnum TranslationStatus { get; set; }
        #endregion Properties in DB

        #region Constructors
        public MWQMSampleLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSampleLanguageExtraA : MWQMSampleLanguage
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
        [CSSPDescriptionEN(DescriptionEN = @"Translation status text of the MWQMSample")]
        [CSSPDescriptionFR(DescriptionFR = @"Le texte du statut de la traduction de MWQMSample")]
        public string TranslationStatusText { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSampleLanguageExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSampleLanguageExtraB : MWQMSampleLanguageExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string MWQMSampleLanguageReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSampleLanguageExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
