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
        [CSSPEnumType]
        public FilePurposeEnum FilePurpose { get; set; }
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "FilePurposeEnum", EnumType = "FilePurpose")]
        public string FilePurposeText { get; set; }
        public bool HasErrors { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public FilePurposeAndText()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
