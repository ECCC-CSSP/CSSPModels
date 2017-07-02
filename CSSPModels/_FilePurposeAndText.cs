using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class FilePurposeAndText
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Required]
        public FilePurposeEnum FilePurpose { get; set; }
        [Required]
        [Range(1, 200)]
        public string FilePurposeText { get; set; }

        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public FilePurposeAndText()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
