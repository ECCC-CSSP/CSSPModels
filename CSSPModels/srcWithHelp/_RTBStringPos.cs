using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    /// <summary>
    ///     Entity object for CSSPModels.RTBStringPoss DB Table
    /// </summary>
    [NotMapped]
    public partial class RTBStringPos
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(0, -1)]
        public int StartPos { get; set; }
        [Range(0, -1)]
        public int EndPos { get; set; }
        public string Text { get; set; }
        public string TagText { get; set; }
        public bool HasErrors { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public RTBStringPos()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
