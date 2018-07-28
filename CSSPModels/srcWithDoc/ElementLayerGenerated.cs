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
    /// > <para>**Other properties** : [Layer](CSSPModels.ElementLayer.html#CSSPModels_ElementLayer_Layer), [ZMin](CSSPModels.ElementLayer.html#CSSPModels_ElementLayer_ZMin), [ZMax](CSSPModels.ElementLayer.html#CSSPModels_ElementLayer_ZMax), [Element](CSSPModels.ElementLayer.html#CSSPModels_ElementLayer_Element), [HasErrors](CSSPModels.ElementLayer.html#CSSPModels_ElementLayer_HasErrors), [ValidationResults](CSSPModels.ElementLayer.html#CSSPModels_ElementLayer_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [ElementLayerService](CSSPServices.ElementLayerService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class ElementLayer : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(1, 1000)]
        public int Layer { get; set; }
        public double ZMin { get; set; }
        public double ZMax { get; set; }
        public virtual Element Element { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ElementLayer() : base()
        {
        }
        #endregion Constructors
    }
}
