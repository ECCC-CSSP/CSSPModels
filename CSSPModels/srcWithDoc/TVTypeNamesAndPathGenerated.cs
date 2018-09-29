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
    /// > <para>**Other properties** : [TVTypeName](CSSPModels.TVTypeNamesAndPath.html#CSSPModels_TVTypeNamesAndPath_TVTypeName), [Index](CSSPModels.TVTypeNamesAndPath.html#CSSPModels_TVTypeNamesAndPath_Index), [TVPath](CSSPModels.TVTypeNamesAndPath.html#CSSPModels_TVTypeNamesAndPath_TVPath), [HasErrors](CSSPModels.TVTypeNamesAndPath.html#CSSPModels_TVTypeNamesAndPath_HasErrors), [ValidationResults](CSSPModels.TVTypeNamesAndPath.html#CSSPModels_TVTypeNamesAndPath_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [TVTypeNamesAndPathService](CSSPServices.TVTypeNamesAndPathService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class TVTypeNamesAndPath : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "TV type name")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Nom du type de l'arbre visuel")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Tree view type name")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Nom du type de l'arbre visuel")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- TV type name
        /// 
        /// **Display (fr)** --- Nom du type de l'arbre visuel
        /// 
        /// **Description (en)** --- Tree view type name
        /// 
        /// **Description (fr)** --- Nom du type de l'arbre visuel
        /// </returns>
        [StringLength(255, MinimumLength = 1)]
        [CSSPDisplayEN(DisplayEN = "TV type name")]
        [CSSPDisplayFR(DisplayFR = "Nom du type de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view type name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du type de l'arbre visuel")]
        public string TVTypeName { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Index")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Indice")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Index")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Indice")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Index
        /// 
        /// **Display (fr)** --- Indice
        /// 
        /// **Description (en)** --- Index
        /// 
        /// **Description (fr)** --- Indice
        /// </returns>
        [Range(1, -1)]
        [CSSPDisplayEN(DisplayEN = "Index")]
        [CSSPDisplayFR(DisplayFR = "Indice")]
        [CSSPDescriptionEN(DescriptionEN = @"Index")]
        [CSSPDescriptionFR(DescriptionFR = @"Indice")]
        public int Index { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "TV path")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Chemin de l'arbre visuel")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Tree view path")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Chemin de l'arbre visuel")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- TV path
        /// 
        /// **Display (fr)** --- Chemin de l'arbre visuel
        /// 
        /// **Description (en)** --- Tree view path
        /// 
        /// **Description (fr)** --- Chemin de l'arbre visuel
        /// </returns>
        [StringLength(255, MinimumLength = 1)]
        [CSSPDisplayEN(DisplayEN = "TV path")]
        [CSSPDisplayFR(DisplayFR = "Chemin de l'arbre visuel")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view path")]
        [CSSPDescriptionFR(DescriptionFR = @"Chemin de l'arbre visuel")]
        public string TVPath { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVTypeNamesAndPath() : base()
        {
        }
        #endregion Constructors
    }
}
