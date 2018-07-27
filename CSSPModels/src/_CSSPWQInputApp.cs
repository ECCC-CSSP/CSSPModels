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
    public partial class CSSPWQInputApp : Error
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
        #endregion Properties not in DB

        #region Constructors
        public CSSPWQInputApp() : base()
        {
        }
        #endregion Constructors
    }
}
