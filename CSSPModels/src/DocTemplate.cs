using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class DocTemplate : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int DocTemplateID { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [CSSPEnumType]
        public TVTypeEnum TVType { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "8")]
        public int TVFileTVItemID { get; set; }
        [StringLength(150)]
        public string FileName { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public DocTemplateWeb DocTemplateWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public DocTemplateReport DocTemplateReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public DocTemplate() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class DocTemplateWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "LanguageEnum", EnumType = "Language")]
        [CSSPAllowNull]
        public string LanguageText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TVType")]
        [CSSPAllowNull]
        public string TVTypeText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public DocTemplateWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class DocTemplateReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string DocTemplateReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public DocTemplateReport()
        {
        }
        #endregion Constructors
    }
}
