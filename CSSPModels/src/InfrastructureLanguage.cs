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
    public partial class InfrastructureLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "InfrastructureLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "InfrastructureLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the InfrastructureLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table InfrastructureLanguages")]
        public int InfrastructureLanguageID { get; set; }
        [CSSPExist(ExistTypeName = "Infrastructure", ExistPlurial = "s", ExistFieldID = "InfrastructureID")]
        [CSSPDisplayEN(DisplayEN = "Infrastructure")]
        [CSSPDisplayFR(DisplayFR = "Infrastructure")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the Infrastructure table representing the infrastructure")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table Infrastructure représentant l'infrastructure")]
        public int InfrastructureID { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Language")]
        [CSSPDisplayFR(DisplayFR = "Langage")]
        [CSSPDescriptionEN(DescriptionEN = @"Language of item")]
        [CSSPDescriptionFR(DescriptionFR = @"Langage de l'item")]
        public LanguageEnum Language { get; set; }
        [CSSPDisplayEN(DisplayEN = "Comment")]
        [CSSPDisplayFR(DisplayFR = "Commentaire")]
        [CSSPDescriptionEN(DescriptionEN = @"Comment")]
        [CSSPDescriptionFR(DescriptionFR = @"Commentaire")]
        public string Comment { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Translation status")]
        [CSSPDisplayFR(DisplayFR = "Le statut de la traduction")]
        [CSSPDescriptionEN(DescriptionEN = @"Translation status of the comment")]
        [CSSPDescriptionFR(DescriptionFR = @"Le statut de la traduction du commentaire")]
        public TranslationStatusEnum TranslationStatus { get; set; }
        #endregion Properties in DB

        #region Constructors
        public InfrastructureLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class InfrastructureLanguage_A : InfrastructureLanguage
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
        [CSSPDescriptionEN(DescriptionEN = @"Translation status text of the Infrastructure")]
        [CSSPDescriptionFR(DescriptionFR = @"Le texte du statut de la traduction de Infrastructure")]
        public string TranslationStatusText { get; set; }
        #endregion Properties

        #region Constructors
        public InfrastructureLanguage_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class InfrastructureLanguage_B : InfrastructureLanguage_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string InfrastructureLanguageReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public InfrastructureLanguage_B() : base()
        {
        }
        #endregion Constructors
    }
}
