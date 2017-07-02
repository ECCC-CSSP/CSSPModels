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
        [Required]
        [Range(1, 200)]
        public string LoginEmail { get; set; }
        [Required]
        [Range(1, 200)]
        public string FirstName { get; set; }
        [Required]
        [Range(1, 200)]
        public string LastName { get; set; }
        public string Initial { get; set; }
        public ContactTitleEnum? ContactTitle { get; set; }

        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public NewContact()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
