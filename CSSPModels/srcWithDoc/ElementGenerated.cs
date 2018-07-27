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
    /// > <para>**Other properties** : [ID](CSSPModels.Element.html#CSSPModels_Element_ID), [Type](CSSPModels.Element.html#CSSPModels_Element_Type), [NumbOfNodes](CSSPModels.Element.html#CSSPModels_Element_NumbOfNodes), [Value](CSSPModels.Element.html#CSSPModels_Element_Value), [XNode0](CSSPModels.Element.html#CSSPModels_Element_XNode0), [YNode0](CSSPModels.Element.html#CSSPModels_Element_YNode0), [ZNode0](CSSPModels.Element.html#CSSPModels_Element_ZNode0), [NodeList](CSSPModels.Element.html#CSSPModels_Element_NodeList), [HasErrors](CSSPModels.Element.html#CSSPModels_Element_HasErrors), [ValidationResults](CSSPModels.Element.html#CSSPModels_Element_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [ElementService](CSSPServices.ElementService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class Element : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(1, -1)]
        public int ID { get; set; }
        [Range(1, -1)]
        public int Type { get; set; }
        [Range(1, -1)]
        public int NumbOfNodes { get; set; }
        public double Value { get; set; }
        public double XNode0 { get; set; }
        public double YNode0 { get; set; }
        public double ZNode0 { get; set; }
        public virtual List<Node> NodeList { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Element() : base()
        {
            NodeList = new List<Node>();
        }
        #endregion Constructors
    }
}