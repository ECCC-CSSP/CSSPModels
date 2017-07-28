using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class AppErrLog
    {
        #region Properties in DB
        [Key]
        public int AppErrLogID { get; set; }
        [StringLength(100)]
        public string Tag { get; set; }
        [Range(1, -1)]
        public int LineNumber { get; set; }
        public string Source { get; set; }
        public string Message { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime DateTime_UTC { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Contact)]
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
