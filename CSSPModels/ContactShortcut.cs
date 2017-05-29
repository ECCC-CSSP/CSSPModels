using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class ContactShortcut
    {
        #region Properties in DB
        public int ContactShortcutID { get; set; }
        public int ContactID { get; set; }
        public string ShortCutText { get; set; }
        public string ShortCutAddress { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }

        public virtual Contact Contact { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ContactShortcut()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
