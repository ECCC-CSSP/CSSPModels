using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class Tel
    {
        #region Properties in DB
        public int TelID { get; set; }
        public int TelTVItemID { get; set; }
        public string TelNumber { get; set; }
        public TelTypeEnum TelType { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual TVItem TelTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Tel()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
