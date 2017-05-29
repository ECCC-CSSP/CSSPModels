using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class DocTemplate
    {
        #region Properties in DB
        public int DocTemplateID { get; set; }
        public LanguageEnum Language { get; set; }
        public TVTypeEnum TVType { get; set; }
        public int TVFileTVItemID { get; set; }
        public string FileName { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual TVItem TVFileTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public DocTemplate()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
