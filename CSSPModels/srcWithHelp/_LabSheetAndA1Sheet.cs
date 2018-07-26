/*
 * Auto generated from the CSSPModelsGenerateCode.proj by clicking on the [Generate Models With Help] button
 *
 * Do not edit this file.
 *
 * Last generated by Charles LeBlanc
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
    /// > <para>**Other properties** : [LabSheet](CSSPModels.LabSheetAndA1Sheet.html#CSSPModels_LabSheetAndA1Sheet_LabSheet), [LabSheetA1Sheet](CSSPModels.LabSheetAndA1Sheet.html#CSSPModels_LabSheetAndA1Sheet_LabSheetA1Sheet), [HasErrors](CSSPModels.LabSheetAndA1Sheet.html#CSSPModels_LabSheetAndA1Sheet_HasErrors), [ValidationResults](CSSPModels.LabSheetAndA1Sheet.html#CSSPModels_LabSheetAndA1Sheet_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [LabSheetAndA1SheetService](CSSPServices.LabSheetAndA1SheetService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class LabSheetAndA1Sheet : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public virtual LabSheet LabSheet { get; set; }
        public virtual LabSheetA1Sheet LabSheetA1Sheet { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public LabSheetAndA1Sheet() : base()
        {
        }
        #endregion Constructors
    }
}
