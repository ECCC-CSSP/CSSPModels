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
    public partial class BoxModelLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "BoxModelLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "BoxModelLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the BoxModelLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau BoxModelLanguages")]
        public int BoxModelLanguageID { get; set; }
        [CSSPExist(ExistTypeName = "BoxModel", ExistPlurial = "s", ExistFieldID = "BoxModelID")]
        public int BoxModelID { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [StringLength(250)]
        public string ScenarioName { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatus { get; set; }
        #endregion Properties in DB

        #region Constructors
        public BoxModelLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class BoxModelLanguageWeb : BoxModelLanguage
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
        public BoxModelLanguageWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class BoxModelLanguageReport : BoxModelLanguageWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string BoxModelLanguageReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public BoxModelLanguageReport() : base()
        {
        }
        #endregion Constructors
    }
}
