using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class TVItemUserAuthorization
    {
        #region Properties in DB
        public int TVItemUserAuthorizationID { get; set; }
        public int ContactTVItemID { get; set; }
        public int TVItemID1 { get; set; }
        public int? TVItemID2 { get; set; }
        public int? TVItemID3 { get; set; }
        public int? TVItemID4 { get; set; }
        public TVAuthEnum TVAuth { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual TVItem ContactTVItem { get; set; }
        public virtual TVItem TVItemID1Navigation { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVItemUserAuthorization()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
