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
using System.Linq;

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
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Lab sheet history count")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Nombre de feuille de lab historique")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Laboratory sheet history count")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Nombre de feuille de laboratoire historique")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Lab sheet history count
        /// 
        /// **Display (fr)** --- Nombre de feuille de lab historique
        /// 
        /// **Description (en)** --- Laboratory sheet history count
        /// 
        /// **Description (fr)** --- Nombre de feuille de laboratoire historique
        /// </returns>
        [Range(0, -1)]
        [CSSPDisplayEN(DisplayEN = "Lab sheet history count")]
        [CSSPDisplayFR(DisplayFR = "Nombre de feuille de lab historique")]
        [CSSPDescriptionEN(DescriptionEN = @"Laboratory sheet history count")]
        [CSSPDescriptionFR(DescriptionFR = @"Nombre de feuille de laboratoire historique")]
        public int LabSheetHistoryCount { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Lab sheet transferred count")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Nombre de feuille de lab transférées")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Laboratory sheet transferred count")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Nombre de feuille de laboratoire transférées")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Lab sheet transferred count
        /// 
        /// **Display (fr)** --- Nombre de feuille de lab transférées
        /// 
        /// **Description (en)** --- Laboratory sheet transferred count
        /// 
        /// **Description (fr)** --- Nombre de feuille de laboratoire transférées
        /// </returns>
        [Range(0, -1)]
        [CSSPDisplayEN(DisplayEN = "Lab sheet transferred count")]
        [CSSPDisplayFR(DisplayFR = "Nombre de feuille de lab transférées")]
        [CSSPDescriptionEN(DescriptionEN = @"Laboratory sheet transferred count")]
        [CSSPDescriptionFR(DescriptionFR = @"Nombre de feuille de laboratoire transférées")]
        public int LabSheetTransferredCount { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Sampling plan")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Plan d'échantillonnage")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Samling plan")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Plan d'échantillonnage")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Sampling plan
        /// 
        /// **Display (fr)** --- Plan d'échantillonnage
        /// 
        /// **Description (en)** --- Samling plan
        /// 
        /// **Description (fr)** --- Plan d'échantillonnage
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Sampling plan")]
        [CSSPDisplayFR(DisplayFR = "Plan d'échantillonnage")]
        [CSSPDescriptionEN(DescriptionEN = @"Samling plan")]
        [CSSPDescriptionFR(DescriptionFR = @"Plan d'échantillonnage")]
        public SamplingPlan SamplingPlan { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Sampling plan file (.txt)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Filière du plan d'échantillonnage (.txt)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "TVFile sampling plan file (.txt)")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Filière du plan d'échantillonnage (.txt)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Sampling plan file (.txt)
        /// 
        /// **Display (fr)** --- Filière du plan d'échantillonnage (.txt)
        /// 
        /// **Description (en)** --- TVFile sampling plan file (.txt)
        /// 
        /// **Description (fr)** --- Filière du plan d'échantillonnage (.txt)
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Sampling plan file (.txt)")]
        [CSSPDisplayFR(DisplayFR = "Filière du plan d'échantillonnage (.txt)")]
        [CSSPDescriptionEN(DescriptionEN = @"TVFile sampling plan file (.txt)")]
        [CSSPDescriptionFR(DescriptionFR = @"Filière du plan d'échantillonnage (.txt)")]
        public TVFile TVFileSamplingPlanFileTXT { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public SamplingPlanAndFilesLabSheetCount() : base()
        {
        }
        #endregion Constructors
    }
}
