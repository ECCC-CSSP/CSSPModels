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
    /// > <para>**Other properties** : [TVItemSubsector](CSSPModels.TVItemSubsectorAndMWQMSite.html#CSSPModels_TVItemSubsectorAndMWQMSite_TVItemSubsector), [TVItemMWQMSiteList](CSSPModels.TVItemSubsectorAndMWQMSite.html#CSSPModels_TVItemSubsectorAndMWQMSite_TVItemMWQMSiteList), [TVItemMWQMSiteDuplicate](CSSPModels.TVItemSubsectorAndMWQMSite.html#CSSPModels_TVItemSubsectorAndMWQMSite_TVItemMWQMSiteDuplicate), [CSSPError.HasErrors](CSSPModels.CSSPError.html#CSSPModels_CSSPError_HasErrors), [CSSPError.ValidationResults](CSSPModels.CSSPError.html#CSSPModels_CSSPError_ValidationResults)</para>
    /// > 
    /// > <para>**Inherits [CSSPError](CSSPModels.CSSPError.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class TVItemSubsectorAndMWQMSite : CSSPError
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "TV item of the subsector")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "L'item de l'arbre visuel du sous-secteur")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Tree view item of the subsector")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "L'item de l'arbre visuel du sous-secteur")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- TV item of the subsector
        /// 
        /// **Display (fr)** --- L'item de l'arbre visuel du sous-secteur
        /// 
        /// **Description (en)** --- Tree view item of the subsector
        /// 
        /// **Description (fr)** --- L'item de l'arbre visuel du sous-secteur
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "TV item of the subsector")]
        [CSSPDisplayFR(DisplayFR = "L'item de l'arbre visuel du sous-secteur")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view item of the subsector")]
        [CSSPDescriptionFR(DescriptionFR = @"L'item de l'arbre visuel du sous-secteur")]
        public TVItem TVItemSubsector { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "TV item of the MWQM site")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "L'item de l'arbre visuel du site MWQM (fr)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Tree view item of the MWQM site")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "L'item de l'arbre visuel du site MWQM (fr)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- TV item of the MWQM site
        /// 
        /// **Display (fr)** --- L'item de l'arbre visuel du site MWQM (fr)
        /// 
        /// **Description (en)** --- Tree view item of the MWQM site
        /// 
        /// **Description (fr)** --- L'item de l'arbre visuel du site MWQM (fr)
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "TV item of the MWQM site")]
        [CSSPDisplayFR(DisplayFR = "L'item de l'arbre visuel du site MWQM (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view item of the MWQM site")]
        [CSSPDescriptionFR(DescriptionFR = @"L'item de l'arbre visuel du site MWQM (fr)")]
        public List<TVItem> TVItemMWQMSiteList { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "TV item of the duplicate MWQM site")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "L'item de l'arbre visuel du site duplicata MWQM (fr)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Tree view item of the duplicate MWQM site")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "L'item de l'arbre visuel du site duplicata MWQM (fr)")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- TV item of the duplicate MWQM site
        /// 
        /// **Display (fr)** --- L'item de l'arbre visuel du site duplicata MWQM (fr)
        /// 
        /// **Description (en)** --- Tree view item of the duplicate MWQM site
        /// 
        /// **Description (fr)** --- L'item de l'arbre visuel du site duplicata MWQM (fr)
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "TV item of the duplicate MWQM site")]
        [CSSPDisplayFR(DisplayFR = "L'item de l'arbre visuel du site duplicata MWQM (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"Tree view item of the duplicate MWQM site")]
        [CSSPDescriptionFR(DescriptionFR = @"L'item de l'arbre visuel du site duplicata MWQM (fr)")]
        public TVItem TVItemMWQMSiteDuplicate { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVItemSubsectorAndMWQMSite() : base()
        {
            TVItemMWQMSiteList = new List<TVItem>();
        }
        #endregion Constructors
    }
}
