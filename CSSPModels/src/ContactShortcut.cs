using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class ContactShortcut : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int ContactShortcutID { get; set; }
        [CSSPExist(ExistTypeName = "Contact", ExistPlurial = "s", ExistFieldID = "ContactID")]
        public int ContactID { get; set; }
        [StringLength(100)]
        public string ShortCutText { get; set; }
        [StringLength(200)]
        public string ShortCutAddress { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public ContactShortcutWeb ContactShortcutWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public ContactShortcutReport ContactShortcutReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ContactShortcut() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ContactShortcutWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public ContactShortcutWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ContactShortcutReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string ContactShortcutReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public ContactShortcutReport()
        {
        }
        #endregion Constructors
    }
}
