using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    /// <summary>
    ///     Entity object for CSSPModels.LabSheetAndA1Sheets DB Table
    /// </summary>
    [NotMapped]
    public partial class LabSheetAndA1Sheet
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public virtual LabSheet LabSheet { get; set; }
        public virtual LabSheetA1Sheet LabSheetA1Sheet { get; set; }
        public bool HasErrors { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public LabSheetAndA1Sheet()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
