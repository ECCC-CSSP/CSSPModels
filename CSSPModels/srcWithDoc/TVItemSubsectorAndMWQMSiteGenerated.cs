/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 August 01 05:00
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
    /// > <para>**Other properties** : [TVItemSubsector](CSSPModels.TVItemSubsectorAndMWQMSite.html#CSSPModels_TVItemSubsectorAndMWQMSite_TVItemSubsector), [TVItemMWQMSiteList](CSSPModels.TVItemSubsectorAndMWQMSite.html#CSSPModels_TVItemSubsectorAndMWQMSite_TVItemMWQMSiteList), [TVItemMWQMSiteDuplicate](CSSPModels.TVItemSubsectorAndMWQMSite.html#CSSPModels_TVItemSubsectorAndMWQMSite_TVItemMWQMSiteDuplicate), [HasErrors](CSSPModels.TVItemSubsectorAndMWQMSite.html#CSSPModels_TVItemSubsectorAndMWQMSite_HasErrors), [ValidationResults](CSSPModels.TVItemSubsectorAndMWQMSite.html#CSSPModels_TVItemSubsectorAndMWQMSite_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [TVItemSubsectorAndMWQMSiteService](CSSPServices.TVItemSubsectorAndMWQMSiteService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class TVItemSubsectorAndMWQMSite : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public virtual TVItem TVItemSubsector { get; set; }
        public virtual List<TVItem> TVItemMWQMSiteList { get; set; }
        public virtual TVItem TVItemMWQMSiteDuplicate { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVItemSubsectorAndMWQMSite() : base()
        {
            TVItemMWQMSiteList = new List<TVItem>();
        }
        #endregion Constructors
    }
}
