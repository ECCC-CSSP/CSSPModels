/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by leblancc on WMON01DTCHLEBL2 machine
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
    /// > <para>**Other properties** : [Error](CSSPModels.BoxModelCalNumb.html#CSSPModels_BoxModelCalNumb_Error), [BoxModelResultType](CSSPModels.BoxModelCalNumb.html#CSSPModels_BoxModelCalNumb_BoxModelResultType), [CalLength_m](CSSPModels.BoxModelCalNumb.html#CSSPModels_BoxModelCalNumb_CalLength_m), [CalRadius_m](CSSPModels.BoxModelCalNumb.html#CSSPModels_BoxModelCalNumb_CalRadius_m), [CalSurface_m2](CSSPModels.BoxModelCalNumb.html#CSSPModels_BoxModelCalNumb_CalSurface_m2), [CalVolume_m3](CSSPModels.BoxModelCalNumb.html#CSSPModels_BoxModelCalNumb_CalVolume_m3), [CalWidth_m](CSSPModels.BoxModelCalNumb.html#CSSPModels_BoxModelCalNumb_CalWidth_m), [FixLength](CSSPModels.BoxModelCalNumb.html#CSSPModels_BoxModelCalNumb_FixLength), [FixWidth](CSSPModels.BoxModelCalNumb.html#CSSPModels_BoxModelCalNumb_FixWidth), [BoxModelResultTypeText](CSSPModels.BoxModelCalNumb.html#CSSPModels_BoxModelCalNumb_BoxModelResultTypeText), [HasErrors](CSSPModels.BoxModelCalNumb.html#CSSPModels_BoxModelCalNumb_HasErrors), [ValidationResults](CSSPModels.BoxModelCalNumb.html#CSSPModels_BoxModelCalNumb_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [BoxModelCalNumbService](CSSPServices.BoxModelCalNumbService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [BoxModelResultTypeEnum](CSSPEnums.BoxModelResultTypeEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class BoxModelCalNumb : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(255)]
        public string Error { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public BoxModelResultTypeEnum BoxModelResultType { get; set; }
        [Range(0.0D, -1.0D)]
        public double CalLength_m { get; set; }
        [Range(0.0D, -1.0D)]
        public double CalRadius_m { get; set; }
        [Range(0.0D, -1.0D)]
        public double CalSurface_m2 { get; set; }
        [Range(0.0D, -1.0D)]
        public double CalVolume_m3 { get; set; }
        [Range(0.0D, -1.0D)]
        public double CalWidth_m { get; set; }
        public bool FixLength { get; set; }
        public bool FixWidth { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "BoxModelResultTypeEnum", EnumType = "BoxModelResultType")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(100)]
        [CSSPEnumTypeText(EnumTypeName = "BoxModelResultTypeEnum", EnumType = "BoxModelResultType")]
        [CSSPAllowNull]
        public string BoxModelResultTypeText { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public BoxModelCalNumb() : base()
        {
        }
        #endregion Constructors
    }
}
