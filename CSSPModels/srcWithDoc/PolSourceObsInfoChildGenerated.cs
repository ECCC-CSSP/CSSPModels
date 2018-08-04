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
    /// > <para>**Other properties** : [PolSourceObsInfo](CSSPModels.PolSourceObsInfoChild.html#CSSPModels_PolSourceObsInfoChild_PolSourceObsInfo), [PolSourceObsInfoChildStart](CSSPModels.PolSourceObsInfoChild.html#CSSPModels_PolSourceObsInfoChild_PolSourceObsInfoChildStart), [PolSourceObsInfoText](CSSPModels.PolSourceObsInfoChild.html#CSSPModels_PolSourceObsInfoChild_PolSourceObsInfoText), [PolSourceObsInfoChildStartText](CSSPModels.PolSourceObsInfoChild.html#CSSPModels_PolSourceObsInfoChild_PolSourceObsInfoChildStartText), [HasErrors](CSSPModels.PolSourceObsInfoChild.html#CSSPModels_PolSourceObsInfoChild_HasErrors), [ValidationResults](CSSPModels.PolSourceObsInfoChild.html#CSSPModels_PolSourceObsInfoChild_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [PolSourceObsInfoChildService](CSSPServices.PolSourceObsInfoChildService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [PolSourceObsInfoEnum](CSSPEnums.PolSourceObsInfoEnum.html), [PolSourceObsInfoEnum](CSSPEnums.PolSourceObsInfoEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class PolSourceObsInfoChild : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public PolSourceObsInfoEnum PolSourceObsInfo { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public PolSourceObsInfoEnum PolSourceObsInfoChildStart { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "PolSourceObsInfoEnum", EnumType = "PolSourceObsInfo")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(100)]
        [CSSPEnumTypeText(EnumTypeName = "PolSourceObsInfoEnum", EnumType = "PolSourceObsInfo")]
        [CSSPAllowNull]
        public string PolSourceObsInfoText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "PolSourceObsInfoEnum", EnumType = "PolSourceObsInfoChildStart")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(100)]
        [CSSPEnumTypeText(EnumTypeName = "PolSourceObsInfoEnum", EnumType = "PolSourceObsInfoChildStart")]
        [CSSPAllowNull]
        public string PolSourceObsInfoChildStartText { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public PolSourceObsInfoChild() : base()
        {
        }
        #endregion Constructors
    }
}
