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
    public partial class SamplingPlanAndFilesLabSheetCount : Error
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
        #endregion Properties not in DB

        #region Constructors
        public SamplingPlanAndFilesLabSheetCount() : base()
        {
        }
        #endregion Constructors
    }
}
