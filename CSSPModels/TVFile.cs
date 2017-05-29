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
        public int TVFileID { get; set; }
        public int TVFileTVItemID { get; set; }
        public TVTypeEnum TemplateTVType { get; set; }
        public LanguageEnum Language { get; set; }
        public FilePurposeEnum FilePurpose { get; set; }
        public FileTypeEnum FileType { get; set; }
        public int FileSize_kb { get; set; }
        public string FileInfo { get; set; }
        public DateTime FileCreatedDate_UTC { get; set; }
        public bool? FromWater { get; set; }
        public string ClientFilePath { get; set; }
        public string ServerFileName { get; set; }
        public string ServerFilePath { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
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
