using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class NewContact
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(200, MinimumLength = 1)]
        public string LoginEmail { get; set; }
        [StringLength(200, MinimumLength = 1)]
        public string FirstName { get; set; }
        [StringLength(200, MinimumLength = 1)]
        public string LastName { get; set; }
        [StringLength(50)]
        [CSSPAllowNull]
        public string Initial { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public ContactTitleEnum? ContactTitle { get; set; }
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "ContactTitleEnum", EnumType = "ContactTitle")]
        public string ContactTitleText { get; set; }

        public bool HasErrors { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public NewContact()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
