/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
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
