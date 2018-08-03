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
    public partial class SamplingPlanSubsectorSite : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "SamplingPlanSubsectorSite ID")]
        [CSSPDisplayFR(DisplayFR = "SamplingPlanSubsectorSite ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the SamplingPlanSubsectorSites table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau SamplingPlanSubsectorSites")]
        public int SamplingPlanSubsectorSiteID { get; set; }
        [CSSPExist(ExistTypeName = "SamplingPlanSubsector", ExistPlurial = "s", ExistFieldID = "SamplingPlanSubsectorID")]
        public int SamplingPlanSubsectorID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "16")]
        public int MWQMSiteTVItemID { get; set; }
        public bool IsDuplicate { get; set; }
        #endregion Properties in DB

        #region Constructors
        public SamplingPlanSubsectorSite() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SamplingPlanSubsectorSiteWeb : SamplingPlanSubsectorSite
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMSiteTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage MWQMSiteTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties for web information

        #region Constructors
        public SamplingPlanSubsectorSiteWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SamplingPlanSubsectorSiteReport : SamplingPlanSubsectorSiteWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string SamplingPlanSubsectorSiteReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public SamplingPlanSubsectorSiteReport() : base()
        {
        }
        #endregion Constructors
    }
}
