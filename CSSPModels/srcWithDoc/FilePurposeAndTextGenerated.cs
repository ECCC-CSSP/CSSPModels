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
    /// > <para>**Other properties** : [FilePurpose](CSSPModels.FilePurposeAndText.html#CSSPModels_FilePurposeAndText_FilePurpose), [FilePurposeText](CSSPModels.FilePurposeAndText.html#CSSPModels_FilePurposeAndText_FilePurposeText), [HasErrors](CSSPModels.FilePurposeAndText.html#CSSPModels_FilePurposeAndText_HasErrors), [ValidationResults](CSSPModels.FilePurposeAndText.html#CSSPModels_FilePurposeAndText_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [FilePurposeAndTextService](CSSPServices.FilePurposeAndTextService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [FilePurposeEnum](CSSPEnums.FilePurposeEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class FilePurposeAndText : Error
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
        public FilePurposeEnum FilePurpose { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "FilePurposeEnum", EnumType = "FilePurpose")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(100)]
        [CSSPEnumTypeText(EnumTypeName = "FilePurposeEnum", EnumType = "FilePurpose")]
        [CSSPAllowNull]
        public string FilePurposeText { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public FilePurposeAndText() : base()
        {
        }
        #endregion Constructors
    }
}
