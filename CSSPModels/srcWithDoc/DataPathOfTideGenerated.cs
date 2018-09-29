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
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Text
        /// 
        /// **Display (fr)** --- Texte
        /// 
        /// **Description (en)** --- Text
        /// 
        /// **Description (fr)** --- Texte
        /// </returns>
        [StringLength(200, MinimumLength = 1)]
        [CSSPDisplayEN(DisplayEN = "Text")]
        [CSSPDisplayFR(DisplayFR = "Texte")]
        [CSSPDescriptionEN(DescriptionEN = @"Text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte")]
        public string Text { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Web tide dataset")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Données web tide")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Web tide dataset")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Données web tide")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Web tide dataset
        /// 
        /// **Display (fr)** --- Données web tide
        /// 
        /// **Description (en)** --- Web tide dataset
        /// 
        /// **Description (fr)** --- Données web tide
        /// </returns>
        [CSSPEnumType]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Web tide dataset")]
        [CSSPDisplayFR(DisplayFR = "Données web tide")]
        [CSSPDescriptionEN(DescriptionEN = @"Web tide dataset")]
        [CSSPDescriptionFR(DescriptionFR = @"Données web tide")]
        public WebTideDataSetEnum? WebTideDataSet { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "WebTideDataSetEnum", EnumType = "WebTideDataSet")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Web tide dataset text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte de données web tide")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Web tide dataset text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte de données web tide")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Web tide dataset text
        /// 
        /// **Display (fr)** --- Texte de données web tide
        /// 
        /// **Description (en)** --- Web tide dataset text
        /// 
        /// **Description (fr)** --- Texte de données web tide
        /// </returns>
        [StringLength(100)]
        [CSSPEnumTypeText(EnumTypeName = "WebTideDataSetEnum", EnumType = "WebTideDataSet")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Web tide dataset text")]
        [CSSPDisplayFR(DisplayFR = "Texte de données web tide")]
        [CSSPDescriptionEN(DescriptionEN = @"Web tide dataset text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte de données web tide")]
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
