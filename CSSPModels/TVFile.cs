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
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.File)]
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
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Contact)]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual ICollection<TVFileLanguage> TVFileLanguages { get; set; }
        public virtual TVItem TVFileTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVFile()
        {
            TVFileLanguages = new HashSet<TVFileLanguage>();
        }
        #endregion Constructors

    }
}
