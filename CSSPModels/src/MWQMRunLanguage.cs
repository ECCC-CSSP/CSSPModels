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
    public partial class MWQMRunLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MWQMRunLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "MWQMRunLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MWQMRunLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table MWQMRunLanguages")]
        public int MWQMRunLanguageID { get; set; }
        [CSSPExist(ExistTypeName = "MWQMRun", ExistPlurial = "s", ExistFieldID = "MWQMRunID")]
        public int MWQMRunID { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        public string RunComment { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatusRunComment { get; set; }
        public string RunWeatherComment { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatusRunWeatherComment { get; set; }
        #endregion Properties in DB

        #region Constructors
        public MWQMRunLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMRunLanguage_A : MWQMRunLanguage
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
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusRunComment")]
        [CSSPAllowNull]
        public string TranslationStatusRunCommentText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusRunWeatherComment")]
        [CSSPAllowNull]
        public string TranslationStatusRunWeatherCommentText { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMRunLanguage_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMRunLanguage_B : MWQMRunLanguage_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string MWQMRunLanguageReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMRunLanguage_B() : base()
        {
        }
        #endregion Constructors
    }
}
