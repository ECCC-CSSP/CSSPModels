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
    public partial class CSSPWQInputParam : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [CSSPEnumType]
        public CSSPWQInputTypeEnum CSSPWQInputType { get; set; }
        [StringLength(200, MinimumLength = 1)]
        public string Name { get; set; }
        [Range(1, -1)]
        public int TVItemID { get; set; }
        [StringLength(100)]
        [CSSPEnumTypeText(EnumTypeName = "CSSPWQInputTypeEnum", EnumType = "CSSPWQInputType")]
        [CSSPAllowNull]
        public string CSSPWQInputTypeText { get; set; }
        public virtual List<string> sidList { get; set; }
        public virtual List<string> MWQMSiteList { get; set; }
        public virtual List<int> MWQMSiteTVItemIDList { get; set; }
        public virtual List<string> DailyDuplicateMWQMSiteList { get; set; }
        public virtual List<int> DailyDuplicateMWQMSiteTVItemIDList { get; set; }
        public virtual List<string> InfrastructureList { get; set; }
        public virtual List<int> InfrastructureTVItemIDList { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public CSSPWQInputParam() : base()
        {
            sidList = new List<string>();
            MWQMSiteList = new List<string>();
            MWQMSiteTVItemIDList = new List<int>();
            DailyDuplicateMWQMSiteList = new List<string>();
            DailyDuplicateMWQMSiteTVItemIDList = new List<int>();
            InfrastructureList = new List<string>();
            InfrastructureTVItemIDList = new List<int>();
        }
        #endregion Constructors
    }
}
