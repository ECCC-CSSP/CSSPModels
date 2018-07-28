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
    /// > <para>**Other properties** : [ParentSite](CSSPModels.MWQMSampleDuplicateItem.html#CSSPModels_MWQMSampleDuplicateItem_ParentSite), [DuplicateSite](CSSPModels.MWQMSampleDuplicateItem.html#CSSPModels_MWQMSampleDuplicateItem_DuplicateSite), [HasErrors](CSSPModels.MWQMSampleDuplicateItem.html#CSSPModels_MWQMSampleDuplicateItem_HasErrors), [ValidationResults](CSSPModels.MWQMSampleDuplicateItem.html#CSSPModels_MWQMSampleDuplicateItem_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [MWQMSampleDuplicateItemService](CSSPServices.MWQMSampleDuplicateItemService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class MWQMSampleDuplicateItem : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(200, MinimumLength = 1)]
        public string ParentSite { get; set; }
        [StringLength(200, MinimumLength = 1)]
        public string DuplicateSite { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MWQMSampleDuplicateItem() : base()
        {
        }
        #endregion Constructors
    }
}
