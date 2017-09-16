using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    /// <summary>
    ///     Entity object for CSSPModels.ContactOKs DB Table
    /// </summary>
    [NotMapped]
    public partial class ContactOK
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(255)]
        public string Error { get; set; }
        [Range(1, -1)]
        public int ContactID { get; set; }
        [Range(1, -1)]
        public int ContactTVItemID { get; set; }
        public bool HasErrors { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ContactOK()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
