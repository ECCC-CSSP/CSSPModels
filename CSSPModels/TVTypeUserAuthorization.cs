using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class TVTypeUserAuthorization
    {
        #region Properties in DB
        public int TVTypeUserAuthorizationID { get; set; }
        public int ContactTVItemID { get; set; }
        public TVTypeEnum TVType { get; set; }
        public TVAuthEnum TVAuth { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual TVItem ContactTVItem { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVTypeUserAuthorization()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
