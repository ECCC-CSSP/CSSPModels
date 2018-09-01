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
    /// > <para>**Other properties** : [Text](CSSPModels.DataPathOfTide.html#CSSPModels_DataPathOfTide_Text), [WebTideDataSet](CSSPModels.DataPathOfTide.html#CSSPModels_DataPathOfTide_WebTideDataSet), [WebTideDataSetText](CSSPModels.DataPathOfTide.html#CSSPModels_DataPathOfTide_WebTideDataSetText), [HasErrors](CSSPModels.DataPathOfTide.html#CSSPModels_DataPathOfTide_HasErrors), [ValidationResults](CSSPModels.DataPathOfTide.html#CSSPModels_DataPathOfTide_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [DataPathOfTideService](CSSPServices.DataPathOfTideService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [WebTideDataSetEnum](CSSPEnums.WebTideDataSetEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class DataPathOfTide : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [StringLength(200, MinimumLength = 1)]
        public string Text { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        [CSSPAllowNull]
        public WebTideDataSetEnum? WebTideDataSet { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "WebTideDataSetEnum", EnumType = "WebTideDataSet")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(100)]
        [CSSPEnumTypeText(EnumTypeName = "WebTideDataSetEnum", EnumType = "WebTideDataSet")]
        [CSSPAllowNull]
        public string WebTideDataSetText { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public DataPathOfTide() : base()
        {
            Text = "";
            WebTideDataSet = null;
        }
        #endregion Constructors
    }
}
