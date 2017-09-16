using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    [NotMapped]
    public partial class SamplingPlanAndFilesLabSheetCount
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(0, -1)]
        public int LabSheetHistoryCount { get; set; }
        [Range(0, -1)]
        public int LabSheetTransferredCount { get; set; }
        public virtual SamplingPlan SamplingPlan { get; set; }
        public virtual TVFile TVFileSamplingPlanFileTXT { get; set; }
        public bool HasErrors { get; set; }
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public SamplingPlanAndFilesLabSheetCount()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
