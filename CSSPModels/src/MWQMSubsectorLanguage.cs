using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MWQMSubsectorLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MWQMSubsectorLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "MWQMSubsectorLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MWQMSubsectorLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau MWQMSubsectorLanguages")]
        public int MWQMSubsectorLanguageID { get; set; }
        [CSSPExist(ExistTypeName = "MWQMSubsector", ExistPlurial = "s", ExistFieldID = "MWQMSubsectorID")]
        public int MWQMSubsectorID { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [StringLength(250)]
        public string SubsectorDesc { get; set; }
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatusSubsectorDesc { get; set; }
        [CSSPAllowNull]
        public string LogBook { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public TranslationStatusEnum? TranslationStatusLogBook { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public MWQMSubsectorLanguageWeb MWQMSubsectorLanguageWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public MWQMSubsectorLanguageReport MWQMSubsectorLanguageReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MWQMSubsectorLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSubsectorLanguageWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "LanguageEnum", EnumType = "Language")]
        [CSSPAllowNull]
        public string LanguageText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusSubsectorDesc")]
        [CSSPAllowNull]
        public string TranslationStatusSubsectorDescText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusLogBook")]
        [CSSPAllowNull]
        public string TranslationStatusLogBookText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public MWQMSubsectorLanguageWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSubsectorLanguageReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string MWQMSubsectorLanguageReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public MWQMSubsectorLanguageReport()
        {
        }
        #endregion Constructors
    }
}
