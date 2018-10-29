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
    /// > <para>**Other properties** : [ID](CSSPModels.Node.html#CSSPModels_Node_ID), [X](CSSPModels.Node.html#CSSPModels_Node_X), [Y](CSSPModels.Node.html#CSSPModels_Node_Y), [Z](CSSPModels.Node.html#CSSPModels_Node_Z), [Code](CSSPModels.Node.html#CSSPModels_Node_Code), [Value](CSSPModels.Node.html#CSSPModels_Node_Value), [ElementList](CSSPModels.Node.html#CSSPModels_Node_ElementList), [ConnectNodeList](CSSPModels.Node.html#CSSPModels_Node_ConnectNodeList), [HasErrors](CSSPModels.Node.html#CSSPModels_Node_HasErrors), [ValidationResults](CSSPModels.Node.html#CSSPModels_Node_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [NodeService](CSSPServices.NodeService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class Node : CSSPError
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "ID")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Identifiant")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- ID
        /// 
        /// **Display (fr)** --- ID
        /// 
        /// **Description (en)** --- ID
        /// 
        /// **Description (fr)** --- Identifiant
        /// </returns>
        [Range(1, 1000000)]
        [CSSPDisplayEN(DisplayEN = "ID")]
        [CSSPDisplayFR(DisplayFR = "ID")]
        [CSSPDescriptionEN(DescriptionEN = @"ID")]
        [CSSPDescriptionFR(DescriptionFR = @"Identifiant")]
        public int ID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "X")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "X")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "X coordinate")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Coordonée X")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- X
        /// 
        /// **Display (fr)** --- X
        /// 
        /// **Description (en)** --- X coordinate
        /// 
        /// **Description (fr)** --- Coordonée X
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "X")]
        [CSSPDisplayFR(DisplayFR = "X")]
        [CSSPDescriptionEN(DescriptionEN = @"X coordinate")]
        [CSSPDescriptionFR(DescriptionFR = @"Coordonée X")]
        public double X { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Y")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Y")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Y coordinate")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Coordonée Y")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Y
        /// 
        /// **Display (fr)** --- Y
        /// 
        /// **Description (en)** --- Y coordinate
        /// 
        /// **Description (fr)** --- Coordonée Y
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Y")]
        [CSSPDisplayFR(DisplayFR = "Y")]
        [CSSPDescriptionEN(DescriptionEN = @"Y coordinate")]
        [CSSPDescriptionFR(DescriptionFR = @"Coordonée Y")]
        public double Y { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Z")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Z")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Z coordinate")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Coordonée Z")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Z
        /// 
        /// **Display (fr)** --- Z
        /// 
        /// **Description (en)** --- Z coordinate
        /// 
        /// **Description (fr)** --- Coordonée Z
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Z")]
        [CSSPDisplayFR(DisplayFR = "Z")]
        [CSSPDescriptionEN(DescriptionEN = @"Z coordinate")]
        [CSSPDescriptionFR(DescriptionFR = @"Coordonée Z")]
        public double Z { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Code")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Code")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Code")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Code")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Code
        /// 
        /// **Display (fr)** --- Code
        /// 
        /// **Description (en)** --- Code
        /// 
        /// **Description (fr)** --- Code
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Code")]
        [CSSPDisplayFR(DisplayFR = "Code")]
        [CSSPDescriptionEN(DescriptionEN = @"Code")]
        [CSSPDescriptionFR(DescriptionFR = @"Code")]
        public int Code { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Value")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Valeur")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Value")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Valeur")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Value
        /// 
        /// **Display (fr)** --- Valeur
        /// 
        /// **Description (en)** --- Value
        /// 
        /// **Description (fr)** --- Valeur
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Value")]
        [CSSPDisplayFR(DisplayFR = "Valeur")]
        [CSSPDescriptionEN(DescriptionEN = @"Value")]
        [CSSPDescriptionFR(DescriptionFR = @"Valeur")]
        public double Value { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Element list")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Liste d'élément")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Element list")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Liste d'élément")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Element list
        /// 
        /// **Display (fr)** --- Liste d'élément
        /// 
        /// **Description (en)** --- Element list
        /// 
        /// **Description (fr)** --- Liste d'élément
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Element list")]
        [CSSPDisplayFR(DisplayFR = "Liste d'élément")]
        [CSSPDescriptionEN(DescriptionEN = @"Element list")]
        [CSSPDescriptionFR(DescriptionFR = @"Liste d'élément")]
        public List<Element> ElementList { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Connect node list")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Liste de noeux de connexion")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Connect node list")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Liste de noeux de connexion")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Connect node list
        /// 
        /// **Display (fr)** --- Liste de noeux de connexion
        /// 
        /// **Description (en)** --- Connect node list
        /// 
        /// **Description (fr)** --- Liste de noeux de connexion
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Connect node list")]
        [CSSPDisplayFR(DisplayFR = "Liste de noeux de connexion")]
        [CSSPDescriptionEN(DescriptionEN = @"Connect node list")]
        [CSSPDescriptionFR(DescriptionFR = @"Liste de noeux de connexion")]
        public List<Node> ConnectNodeList { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Node() : base()
        {
            ElementList = new List<Element>();
            ConnectNodeList = new List<Node>();
        }
        #endregion Constructors
    }
}
