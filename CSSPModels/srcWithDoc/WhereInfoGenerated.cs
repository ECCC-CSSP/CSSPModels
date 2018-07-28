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
    /// > <para>**Other properties** : [PropertyName](CSSPModels.WhereInfo.html#CSSPModels_WhereInfo_PropertyName), [PropertyType](CSSPModels.WhereInfo.html#CSSPModels_WhereInfo_PropertyType), [WhereOperator](CSSPModels.WhereInfo.html#CSSPModels_WhereInfo_WhereOperator), [Value](CSSPModels.WhereInfo.html#CSSPModels_WhereInfo_Value), [ValueInt](CSSPModels.WhereInfo.html#CSSPModels_WhereInfo_ValueInt), [ValueDouble](CSSPModels.WhereInfo.html#CSSPModels_WhereInfo_ValueDouble), [ValueBool](CSSPModels.WhereInfo.html#CSSPModels_WhereInfo_ValueBool), [ValueDateTime](CSSPModels.WhereInfo.html#CSSPModels_WhereInfo_ValueDateTime), [ValueEnumText](CSSPModels.WhereInfo.html#CSSPModels_WhereInfo_ValueEnumText), [HasErrors](CSSPModels.WhereInfo.html#CSSPModels_WhereInfo_HasErrors), [ValidationResults](CSSPModels.WhereInfo.html#CSSPModels_WhereInfo_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [WhereInfoService](CSSPServices.WhereInfoService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [PropertyTypeEnum](CSSPEnums.PropertyTypeEnum.html), [WhereOperatorEnum](CSSPEnums.WhereOperatorEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class WhereInfo : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(100)]
        public string PropertyName { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public PropertyTypeEnum PropertyType { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public WhereOperatorEnum WhereOperator { get; set; }
        [StringLength(100)]
        public string Value { get; set; }
        [Range(-1, -1)]
        public int ValueInt { get; set; }
        [Range(-1.0D, -1.0D)]
        public double ValueDouble { get; set; }
        public bool ValueBool { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1900)]</para>
        /// </summary>
        [CSSPAfter(Year = 1900)]
        public DateTime ValueDateTime { get; set; }
        [StringLength(100)]
        public string ValueEnumText { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public WhereInfo() : base()
        {
        }
        #endregion Constructors
    }
}
