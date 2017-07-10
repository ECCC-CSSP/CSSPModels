using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class OtherFilesToUpload
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public string Error { get; set; }
        [Range(1, -1)]
        public int MikeScenarioID { get; set; }

        public virtual List<TVFile> TVFileList { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public OtherFilesToUpload()
        {
            TVFileList = new List<TVFile>();
        }
        #endregion Constructors
    }
}
