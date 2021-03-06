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
    /// > <para>**Other properties** : [StartNode](CSSPModels.Vector.html#CSSPModels_Vector_StartNode), [EndNode](CSSPModels.Vector.html#CSSPModels_Vector_EndNode), [CSSPError.HasErrors](CSSPModels.CSSPError.html#CSSPModels_CSSPError_HasErrors), [CSSPError.ValidationResults](CSSPModels.CSSPError.html#CSSPModels_CSSPError_ValidationResults)</para>
    /// > 
    /// > <para>**Inherits [CSSPError](CSSPModels.CSSPError.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class Vector : CSSPError
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Start node")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Node de départ")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Start node")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Node de départ")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Start node
        /// 
        /// **Display (fr)** --- Node de départ
        /// 
        /// **Description (en)** --- Start node
        /// 
        /// **Description (fr)** --- Node de départ
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Start node")]
        [CSSPDisplayFR(DisplayFR = "Node de départ")]
        [CSSPDescriptionEN(DescriptionEN = @"Start node")]
        [CSSPDescriptionFR(DescriptionFR = @"Node de départ")]
        public Node StartNode { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "End node")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Node de fin")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "End node")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Node de fin")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- End node
        /// 
        /// **Display (fr)** --- Node de fin
        /// 
        /// **Description (en)** --- End node
        /// 
        /// **Description (fr)** --- Node de fin
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "End node")]
        [CSSPDisplayFR(DisplayFR = "Node de fin")]
        [CSSPDescriptionEN(DescriptionEN = @"End node")]
        [CSSPDescriptionFR(DescriptionFR = @"Node de fin")]
        public Node EndNode { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Vector() : base()
        {
        }
        #endregion Constructors
    }
}
