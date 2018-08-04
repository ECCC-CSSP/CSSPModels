/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by Charles on CHARLES-PC machine
 *
 */ 
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [LabSheetHistoryCount](CSSPModels.SamplingPlanAndFilesLabSheetCount.html#CSSPModels_SamplingPlanAndFilesLabSheetCount_LabSheetHistoryCount), [LabSheetTransferredCount](CSSPModels.SamplingPlanAndFilesLabSheetCount.html#CSSPModels_SamplingPlanAndFilesLabSheetCount_LabSheetTransferredCount), [SamplingPlan](CSSPModels.SamplingPlanAndFilesLabSheetCount.html#CSSPModels_SamplingPlanAndFilesLabSheetCount_SamplingPlan), [TVFileSamplingPlanFileTXT](CSSPModels.SamplingPlanAndFilesLabSheetCount.html#CSSPModels_SamplingPlanAndFilesLabSheetCount_TVFileSamplingPlanFileTXT), [HasErrors](CSSPModels.SamplingPlanAndFilesLabSheetCount.html#CSSPModels_SamplingPlanAndFilesLabSheetCount_HasErrors), [ValidationResults](CSSPModels.SamplingPlanAndFilesLabSheetCount.html#CSSPModels_SamplingPlanAndFilesLabSheetCount_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [SamplingPlanAndFilesLabSheetCountService](CSSPServices.SamplingPlanAndFilesLabSheetCountService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
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
        public SamplingPlan SamplingPlan { get; set; }
        public TVFile TVFileSamplingPlanFileTXT { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public SamplingPlanAndFilesLabSheetCount() : base()
        {
        }
        #endregion Constructors
    }
}
