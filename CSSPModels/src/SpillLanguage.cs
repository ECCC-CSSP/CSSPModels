/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class SpillLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "SpillLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "SpillLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the SpillLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau SpillLanguages")]
        public int SpillLanguageID { get; set; }
        [CSSPExist(ExistTypeName = "Spill", ExistPlurial = "s", ExistFieldID = "SpillID")]
        public int SpillID { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        public string SpillComment { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatus { get; set; }
        #endregion Properties in DB

        #region Constructors
        public SpillLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SpillLanguageWeb : SpillLanguage
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "LanguageEnum", EnumType = "Language")]
        [CSSPAllowNull]
        public string LanguageText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatus")]
        [CSSPAllowNull]
        public string TranslationStatusText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public SpillLanguageWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SpillLanguageReport : SpillLanguageWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string SpillLanguageReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public SpillLanguageReport() : base()
        {
        }
        #endregion Constructors
    }
}
