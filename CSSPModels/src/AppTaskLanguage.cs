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
    public partial class AppTaskLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "AppTaskLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "AppTaskLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the AppTaskLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table AppTaskLanguages")]
        public int AppTaskLanguageID { get; set; }
        [CSSPExist(ExistTypeName = "AppTask", ExistPlurial = "s", ExistFieldID = "AppTaskID")]
        [CSSPDisplayEN(DisplayEN = "AppTask link")]
        [CSSPDisplayFR(DisplayFR = "Lien AppTask")]
        [CSSPDescriptionEN(DescriptionEN = @"AppTask link to parent AppTasks table item")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien au parent AppTask à l'item de la table AppTasks")]
        public int AppTaskID { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Language")]
        [CSSPDisplayFR(DisplayFR = "Langage")]
        [CSSPDescriptionEN(DescriptionEN = @"Language of item")]
        [CSSPDescriptionFR(DescriptionFR = @"Langage de l'item")]
        public LanguageEnum Language { get; set; }
        [StringLength(250)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Status text")]
        [CSSPDisplayFR(DisplayFR = "Texte du statut")]
        [CSSPDescriptionEN(DescriptionEN = @"Text describing the status of the AppTask")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte décrivant le statut de AppTask")]
        public string StatusText { get; set; }
        [StringLength(250)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Error text")]
        [CSSPDisplayFR(DisplayFR = "Texte de l'erreur")]
        [CSSPDescriptionEN(DescriptionEN = @"Text describing the error of the AppTask... if any")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte décrivant l'erreur de AppTask... s'il y a lieu")]
        public string ErrorText { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Translation status")]
        [CSSPDisplayFR(DisplayFR = "Le statut de la traduction")]
        [CSSPDescriptionEN(DescriptionEN = @"Translation status of status text and error text")]
        [CSSPDescriptionFR(DescriptionFR = @"Le statut de la traduction du texte du statut et du texte de l'erreur")]
        public TranslationStatusEnum TranslationStatus { get; set; }
        #endregion Properties in DB

        #region Constructors
        public AppTaskLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class AppTaskLanguageExtraA : AppTaskLanguage
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
        [CSSPDescriptionEN(DescriptionEN = @"Translation status text of the AppTask")]
        [CSSPDescriptionFR(DescriptionFR = @"Le texte du statut de la traduction de AppTask")]
        public string TranslationStatusText { get; set; }
        #endregion Properties

        #region Constructors
        public AppTaskLanguageExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class AppTaskLanguageExtraB : AppTaskLanguageExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string AppTaskLanguageReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public AppTaskLanguageExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
