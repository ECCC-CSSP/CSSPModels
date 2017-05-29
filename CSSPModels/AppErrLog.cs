using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class AppErrLog
    {
        #region Properties in DB
        public int AppErrLogID { get; set; }
        public string Tag { get; set; }
        public int LineNumber { get; set; }
        public string Source { get; set; }
        public string Message { get; set; }
        public DateTime DateTime_UTC { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public AppErrLog()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
