using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MWQMLookupMPN
    {
        #region Properties in DB
        public int MWQMLookupMPNID { get; set; }
        public int Tubes10 { get; set; }
        public int Tubes1 { get; set; }
        public int Tubes01 { get; set; }
        public int MPN_100ml { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MWQMLookupMPN()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
