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
    public partial class MWQMSubsectorLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MWQMSubsectorLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "MWQMSubsectorLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MWQMSubsectorLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table MWQMSubsectorLanguages")]
        public int MWQMSubsectorLanguageID { get; set; }
        [CSSPExist(ExistTypeName = "MWQMSubsector", ExistPlurial = "s", ExistFieldID = "MWQMSubsectorID")]
        [CSSPDisplayEN(DisplayEN = "MWQM subsector ID")]
        [CSSPDisplayFR(DisplayFR = "Sous-secteur MWQM ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the MWQMSubsectors table representing the MWQM subsector")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table MWQMSubsectors représentant le sous-secteur MWQM")]
        public int MWQMSubsectorID { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Language")]
        [CSSPDisplayFR(DisplayFR = "Langage")]
        [CSSPDescriptionEN(DescriptionEN = @"Language of item")]
        [CSSPDescriptionFR(DescriptionFR = @"Langage de l'item")]
        public LanguageEnum Language { get; set; }
        [StringLength(250)]
        [CSSPDisplayEN(DisplayEN = "Subsector description")]
        [CSSPDisplayFR(DisplayFR = "Description du sous-secteur")]
        [CSSPDescriptionEN(DescriptionEN = @"Subsector description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description du sous-secteur")]
        public string SubsectorDesc { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Translation status")]
        [CSSPDisplayFR(DisplayFR = "Le statut de la traduction")]
        [CSSPDescriptionEN(DescriptionEN = @"Translation status of the subsector description")]
        [CSSPDescriptionFR(DescriptionFR = @"Le statut de la traduction du la description du sous-secteur")]
        public TranslationStatusEnum TranslationStatusSubsectorDesc { get; set; }
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Log book")]
        [CSSPDisplayFR(DisplayFR = "Carnet de bord")]
        [CSSPDescriptionEN(DescriptionEN = @"Log book")]
        [CSSPDescriptionFR(DescriptionFR = @"Carnet de bord")]
        public string LogBook { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Translation status")]
        [CSSPDisplayFR(DisplayFR = "Le statut de la traduction")]
        [CSSPDescriptionEN(DescriptionEN = @"Translation status of the log book")]
        [CSSPDescriptionFR(DescriptionFR = @"Le statut de la traduction du carnet de bord")]
        public TranslationStatusEnum? TranslationStatusLogBook { get; set; }
        #endregion Properties in DB

        #region Constructors
        public MWQMSubsectorLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSubsectorLanguage_A : MWQMSubsectorLanguage
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
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusSubsectorDesc")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Translation status text")]
        [CSSPDisplayFR(DisplayFR = "Le texte du statut de la traduction")]
        [CSSPDescriptionEN(DescriptionEN = @"Translation status text of the subsector description")]
        [CSSPDescriptionFR(DescriptionFR = @"Le texte du statut de la traduction de la description du sous-secteur")]
        public string TranslationStatusSubsectorDescText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusLogBook")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Translation status text")]
        [CSSPDisplayFR(DisplayFR = "Le texte du statut de la traduction")]
        [CSSPDescriptionEN(DescriptionEN = @"Translation status text of the log book")]
        [CSSPDescriptionFR(DescriptionFR = @"Le texte du statut de la traduction de carnet de bord")]
        public string TranslationStatusLogBookText { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSubsectorLanguage_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSubsectorLanguage_B : MWQMSubsectorLanguage_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string MWQMSubsectorLanguageReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSubsectorLanguage_B() : base()
        {
        }
        #endregion Constructors
    }
}
