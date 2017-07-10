﻿using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
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
        [Range(0.0f, 100.0f)]
        public float DailyDuplicatePrecisionCriteria { get; set; }
        [Range(0.0f, 100.0f)]
        public float IntertechDuplicatePrecisionCriteria { get; set; }
        public bool IncludeLaboratoryQAQC { get; set; }
        [StringLength(100, MinimumLength = 1)]
        public string ApprovalCode { get; set; }
        public DateTime ApprovalDate { get; set; }

        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public CSSPWQInputApp()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
