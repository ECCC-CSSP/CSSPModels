using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class ContactShortcut
    {
        #region Properties in DB
        [Key]
        public int ContactShortcutID { get; set; }
        [CSSPExist(TypeName = "Contact", Plurial = "s", FieldID = "ContactID")]
        public int ContactID { get; set; }
        [StringLength(100)]
        public string ShortCutText { get; set; }
        [StringLength(200)]
        public string ShortCutAddress { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID", TVType = TVTypeEnum.Contact)]
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
