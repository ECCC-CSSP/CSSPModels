using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    /// <summary>
    ///     Entity object for CSSPModels.VPScenarioIDAndRawResultss DB Table
    /// </summary>
    [NotMapped]
    public partial class VPScenarioIDAndRawResults
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(1, -1)]
        public int VPScenarioID { get; set; }
        public string RawResults { get; set; }
        public bool HasErrors { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public VPScenarioIDAndRawResults()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
