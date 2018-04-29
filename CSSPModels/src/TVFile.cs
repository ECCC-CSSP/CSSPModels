using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class TVFile : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int TVFileID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "8")]
        public int TVFileTVItemID { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public TVTypeEnum? TemplateTVType { get; set; }
        [CSSPExist(ExistTypeName = "ReportType", ExistPlurial = "s", ExistFieldID = "ReportTypeID")]
        public int? ReportTypeID { get; set; }
        [CSSPAllowNull]
        public string Parameters { get; set; }
        [Range(1980, 2050)]
        public int? Year { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [CSSPEnumType]
        public FilePurposeEnum FilePurpose { get; set; }
        [CSSPEnumType]
        public FileTypeEnum FileType { get; set; }
        [Range(0, 100000000)]
        public int FileSize_kb { get; set; }
        [CSSPAllowNull]
        public string FileInfo { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime FileCreatedDate_UTC { get; set; }
        public bool? FromWater { get; set; }
        [StringLength(250)]
        [CSSPAllowNull]
        public string ClientFilePath { get; set; }
        [StringLength(250)]
        public string ServerFileName { get; set; }
        [StringLength(250)]
        public string ServerFilePath { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public TVFileWeb TVFileWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public TVFileReport TVFileReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVFile() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVFileWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVFileTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string TVFileTVText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TemplateTVType")]
        [CSSPAllowNull]
        public string TemplateTVTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "LanguageEnum", EnumType = "Language")]
        [CSSPAllowNull]
        public string LanguageText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "FilePurposeEnum", EnumType = "FilePurpose")]
        [CSSPAllowNull]
        public string FilePurposeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "FileTypeEnum", EnumType = "FileType")]
        [CSSPAllowNull]
        public string FileTypeText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public TVFileWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVFileReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string TVFileReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public TVFileReport()
        {
        }
        #endregion Constructors
    }
}
