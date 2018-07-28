/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 July 28 02:03
 * by Charles on CHARLES-PC machine
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
    /// > <para>**Other properties** : [Error](CSSPModels.InputSummary.html#CSSPModels_InputSummary_Error), [Summary](CSSPModels.InputSummary.html#CSSPModels_InputSummary_Summary), [HasErrors](CSSPModels.InputSummary.html#CSSPModels_InputSummary_HasErrors), [ValidationResults](CSSPModels.InputSummary.html#CSSPModels_InputSummary_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [InputSummaryService](CSSPServices.InputSummaryService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class InputSummary : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public string Error { get; set; }
        public string Summary { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public InputSummary() : base()
        {
        }
        #endregion Constructors
    }
}
