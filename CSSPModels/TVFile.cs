using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class TVFile
    {
        #region Properties in DB
        [Key]
        public int TVFileID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "8")]
        public int TVFileTVItemID { get; set; }
        [CSSPEnumType]
        public TVTypeEnum TemplateTVType { get; set; }
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [CSSPEnumType]
        public FilePurposeEnum FilePurpose { get; set; }
        [CSSPEnumType]
        public FileTypeEnum FileType { get; set; }
        [Range(0, 1000000)]
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
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TemplateTVType")]
        public string TemplateTVTypeText { get; set; }
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "LanguageEnum", EnumType = "Language")]
        public string LanguageText { get; set; }
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "FilePurposeEnum", EnumType = "FilePurpose")]
        public string FilePurposeText { get; set; }
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "FileTypeEnum", EnumType = "FileType")]
        public string FileTypeText { get; set; }
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVFile()
        {
        }
        #endregion Constructors

    }
}
