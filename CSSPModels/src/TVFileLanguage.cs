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
    public partial class TVFileLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "TVFileLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "TVFileLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the TVFileLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau TVFileLanguages")]
        public int TVFileLanguageID { get; set; }
        [CSSPExist(ExistTypeName = "TVFile", ExistPlurial = "s", ExistFieldID = "TVFileID")]
        public int TVFileID { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [CSSPAllowNull]
        public string FileDescription { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatus { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public TVFileLanguageWeb TVFileLanguageWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public TVFileLanguageReport TVFileLanguageReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVFileLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVFileLanguageWeb
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
        public TVFileLanguageWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVFileLanguageReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string TVFileLanguageReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public TVFileLanguageReport()
        {
        }
        #endregion Constructors
    }
}
