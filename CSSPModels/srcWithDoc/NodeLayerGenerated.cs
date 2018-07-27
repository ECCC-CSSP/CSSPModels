/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 July 27 04:56
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
    /// > <para>**Other properties** : [Layer](CSSPModels.NodeLayer.html#CSSPModels_NodeLayer_Layer), [Z](CSSPModels.NodeLayer.html#CSSPModels_NodeLayer_Z), [Node](CSSPModels.NodeLayer.html#CSSPModels_NodeLayer_Node), [HasErrors](CSSPModels.NodeLayer.html#CSSPModels_NodeLayer_HasErrors), [ValidationResults](CSSPModels.NodeLayer.html#CSSPModels_NodeLayer_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [NodeLayerService](CSSPServices.NodeLayerService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class NodeLayer : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(1, 100)]
        public int Layer { get; set; }
        public double Z { get; set; }
        public virtual Node Node { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public NodeLayer() : base()
        {
        }
        #endregion Constructors
    }
}