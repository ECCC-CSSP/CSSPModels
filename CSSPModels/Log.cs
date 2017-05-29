using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class Log
    {
        #region Properties in DB
        public int LogID { get; set; }
        public string TableName { get; set; }
        public int ID { get; set; }
        public LogCommandEnum LogCommand { get; set; }
        public string Information { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Log()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
