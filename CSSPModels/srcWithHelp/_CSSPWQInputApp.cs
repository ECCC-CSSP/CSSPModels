using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    /// <summary>
    ///     Entity object for CSSPModels.CSSPWQInputApps DB Table
    /// </summary>
    [NotMapped]
    public partial class CSSPWQInputApp
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(100, MinimumLength = 1)]
        public string AccessCode { get; set; }
        [StringLength(4, MinimumLength = 4)]
        public string ActiveYear { get; set; }
        [Range(0.0D, 100.0D)]
        public double DailyDuplicatePrecisionCriteria { get; set; }
        [Range(0.0D, 100.0D)]
        public double IntertechDuplicatePrecisionCriteria { get; set; }
        public bool IncludeLaboratoryQAQC { get; set; }
        [StringLength(100, MinimumLength = 1)]
        public string ApprovalCode { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime ApprovalDate { get; set; }
        public bool HasErrors { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public CSSPWQInputApp()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
