/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
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
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Parent site")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Site du parent")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Parent site")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Site du parent")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Parent site
        /// 
        /// **Display (fr)** --- Site du parent
        /// 
        /// **Description (en)** --- Parent site
        /// 
        /// **Description (fr)** --- Site du parent
        /// </returns>
        [StringLength(200, MinimumLength = 1)]
        [CSSPDisplayEN(DisplayEN = "Parent site")]
        [CSSPDisplayFR(DisplayFR = "Site du parent")]
        [CSSPDescriptionEN(DescriptionEN = @"Parent site")]
        [CSSPDescriptionFR(DescriptionFR = @"Site du parent")]
        public string ParentSite { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Duplicate site")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Site duplicata")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Duplicate site")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Site duplicata")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Duplicate site
        /// 
        /// **Display (fr)** --- Site duplicata
        /// 
        /// **Description (en)** --- Duplicate site
        /// 
        /// **Description (fr)** --- Site duplicata
        /// </returns>
        [StringLength(200, MinimumLength = 1)]
        [CSSPDisplayEN(DisplayEN = "Duplicate site")]
        [CSSPDisplayFR(DisplayFR = "Site duplicata")]
        [CSSPDescriptionEN(DescriptionEN = @"Duplicate site")]
        [CSSPDescriptionFR(DescriptionFR = @"Site duplicata")]
        public string DuplicateSite { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MWQMSampleDuplicateItem() : base()
        {
        }
        #endregion Constructors
    }
}
