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
    /// > <para>**Other properties** : [ContourValue](CSSPModels.ContourPolygon.html#CSSPModels_ContourPolygon_ContourValue), [Layer](CSSPModels.ContourPolygon.html#CSSPModels_ContourPolygon_Layer), [Depth](CSSPModels.ContourPolygon.html#CSSPModels_ContourPolygon_Depth), [ContourNodeList](CSSPModels.ContourPolygon.html#CSSPModels_ContourPolygon_ContourNodeList), [HasErrors](CSSPModels.ContourPolygon.html#CSSPModels_ContourPolygon_HasErrors), [ValidationResults](CSSPModels.ContourPolygon.html#CSSPModels_ContourPolygon_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [ContourPolygonService](CSSPServices.ContourPolygonService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class ContourPolygon : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(0.0D, -1.0D)]
        public double ContourValue { get; set; }
        [Range(1, 100)]
        public int Layer { get; set; }
        [Range(1.0D, 10000.0D)]
        public double Depth { get; set; }
        public virtual List<Node> ContourNodeList { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ContourPolygon() : base()
        {
            ContourNodeList = new List<Node>();
        }
        #endregion Constructors
    }
}
