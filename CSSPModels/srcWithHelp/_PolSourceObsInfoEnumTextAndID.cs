using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    /// <summary>
    ///     Entity object for CSSPModels.PolSourceObsInfoEnumTextAndIDs DB Table
    /// </summary>
    [NotMapped]
    public partial class PolSourceObsInfoEnumTextAndID
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public string Text { get; set; }
        [Range(1, -1)]
        public int ID { get; set; }
        public bool HasErrors { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public PolSourceObsInfoEnumTextAndID()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
