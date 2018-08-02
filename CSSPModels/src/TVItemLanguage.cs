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
    public partial class TVItemLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "TVItemLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the TVItemLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau TVItemLanguages")]
        public int TVItemLanguageID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,9,10,11,12,13,14,15,16,17,18,19,20,21,31,79")]
        public int TVItemID { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [StringLength(200)]
        public string TVText { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatus { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public TVItemLanguageWeb TVItemLanguageWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public TVItemLanguageReport TVItemLanguageReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVItemLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVItemLanguageWeb
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
        public TVItemLanguageWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVItemLanguageReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string TVItemLanguageReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public TVItemLanguageReport()
        {
        }
        #endregion Constructors
    }
}
