using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class OtherFilesToUpload : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public string Error { get; set; }
        [Range(1, -1)]
        public int MikeScenarioID { get; set; }
        public virtual List<TVFile> TVFileList { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public OtherFilesToUpload() : base()
        {
            TVFileList = new List<TVFile>();
        }
        #endregion Constructors
    }
}
