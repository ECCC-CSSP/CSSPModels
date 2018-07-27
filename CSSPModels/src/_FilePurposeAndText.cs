/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class FilePurposeAndText : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [CSSPEnumType]
        public FilePurposeEnum FilePurpose { get; set; }
        [StringLength(100)]
        [CSSPEnumTypeText(EnumTypeName = "FilePurposeEnum", EnumType = "FilePurpose")]
        [CSSPAllowNull]
        public string FilePurposeText { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public FilePurposeAndText() : base()
        {
        }
        #endregion Constructors
    }
}
