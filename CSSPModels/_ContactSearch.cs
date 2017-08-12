using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class ContactSearch
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(1, -1)]
        public int ContactID { get; set; }
        [Range(1, -1)]
        public int ContactTVItemID { get; set; }
        [StringLength(255)]
        public string FullName { get; set; }

        public bool HasErrors { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ContactSearch()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
