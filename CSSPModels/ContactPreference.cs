using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class ContactPreference
    {
        #region Properties in DB
        public int ContactPreferenceID { get; set; }
        public int ContactID { get; set; }
        public TVTypeEnum TVType { get; set; }
        public int MarkerSize { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual Contact Contact { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ContactPreference()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
