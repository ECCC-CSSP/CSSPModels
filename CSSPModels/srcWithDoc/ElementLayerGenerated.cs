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
    /// > <para>**Other properties** : [Layer](CSSPModels.ElementLayer.html#CSSPModels_ElementLayer_Layer), [ZMin](CSSPModels.ElementLayer.html#CSSPModels_ElementLayer_ZMin), [ZMax](CSSPModels.ElementLayer.html#CSSPModels_ElementLayer_ZMax), [Element](CSSPModels.ElementLayer.html#CSSPModels_ElementLayer_Element), [CSSPError.HasErrors](CSSPModels.CSSPError.html#CSSPModels_CSSPError_HasErrors), [CSSPError.ValidationResults](CSSPModels.CSSPError.html#CSSPModels_CSSPError_ValidationResults)</para>
    /// > 
    /// > <para>**Inherits [CSSPError](CSSPModels.CSSPError.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class ElementLayer : CSSPError
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Layer")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Couche")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Layer")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Couche")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Layer
        /// 
        /// **Display (fr)** --- Couche
        /// 
        /// **Description (en)** --- Layer
        /// 
        /// **Description (fr)** --- Couche
        /// </returns>
        [Range(1, 1000)]
        [CSSPDisplayEN(DisplayEN = "Layer")]
        [CSSPDisplayFR(DisplayFR = "Couche")]
        [CSSPDescriptionEN(DescriptionEN = @"Layer")]
        [CSSPDescriptionFR(DescriptionFR = @"Couche")]
        public int Layer { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Z min")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Z min")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Z minimum")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Z minimum")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Z min
        /// 
        /// **Display (fr)** --- Z min
        /// 
        /// **Description (en)** --- Z minimum
        /// 
        /// **Description (fr)** --- Z minimum
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Z min")]
        [CSSPDisplayFR(DisplayFR = "Z min")]
        [CSSPDescriptionEN(DescriptionEN = @"Z minimum")]
        [CSSPDescriptionFR(DescriptionFR = @"Z minimum")]
        public double ZMin { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Z max")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Z max")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Z maximum")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Z maximum")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Z max
        /// 
        /// **Display (fr)** --- Z max
        /// 
        /// **Description (en)** --- Z maximum
        /// 
        /// **Description (fr)** --- Z maximum
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Z max")]
        [CSSPDisplayFR(DisplayFR = "Z max")]
        [CSSPDescriptionEN(DescriptionEN = @"Z maximum")]
        [CSSPDescriptionFR(DescriptionFR = @"Z maximum")]
        public double ZMax { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Element")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Élément")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Element")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Élément")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Element
        /// 
        /// **Display (fr)** --- Élément
        /// 
        /// **Description (en)** --- Element
        /// 
        /// **Description (fr)** --- Élément
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Element")]
        [CSSPDisplayFR(DisplayFR = "Élément")]
        [CSSPDescriptionEN(DescriptionEN = @"Element")]
        [CSSPDescriptionFR(DescriptionFR = @"Élément")]
        public Element Element { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ElementLayer() : base()
        {
        }
        #endregion Constructors
    }
}
