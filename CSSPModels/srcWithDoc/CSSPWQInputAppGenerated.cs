/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 August 01 05:00
 * by leblancc on WMON01DTCHLEBL2 machine
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
    /// > <para>**Other properties** : [AccessCode](CSSPModels.CSSPWQInputApp.html#CSSPModels_CSSPWQInputApp_AccessCode), [ActiveYear](CSSPModels.CSSPWQInputApp.html#CSSPModels_CSSPWQInputApp_ActiveYear), [DailyDuplicatePrecisionCriteria](CSSPModels.CSSPWQInputApp.html#CSSPModels_CSSPWQInputApp_DailyDuplicatePrecisionCriteria), [IntertechDuplicatePrecisionCriteria](CSSPModels.CSSPWQInputApp.html#CSSPModels_CSSPWQInputApp_IntertechDuplicatePrecisionCriteria), [IncludeLaboratoryQAQC](CSSPModels.CSSPWQInputApp.html#CSSPModels_CSSPWQInputApp_IncludeLaboratoryQAQC), [ApprovalCode](CSSPModels.CSSPWQInputApp.html#CSSPModels_CSSPWQInputApp_ApprovalCode), [ApprovalDate](CSSPModels.CSSPWQInputApp.html#CSSPModels_CSSPWQInputApp_ApprovalDate), [HasErrors](CSSPModels.CSSPWQInputApp.html#CSSPModels_CSSPWQInputApp_HasErrors), [ValidationResults](CSSPModels.CSSPWQInputApp.html#CSSPModels_CSSPWQInputApp_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [CSSPWQInputAppService](CSSPServices.CSSPWQInputAppService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
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
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
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
