/*
 * Manually edited by Charles LeBlanc 
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
    public partial class SamplingPlanSubsectorSite : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "SamplingPlanSubsectorSite ID")]
        [CSSPDisplayFR(DisplayFR = "SamplingPlanSubsectorSite ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the SamplingPlanSubsectorSites table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table SamplingPlanSubsectorSites")]
        public int SamplingPlanSubsectorSiteID { get; set; }
        [CSSPExist(ExistTypeName = "SamplingPlanSubsector", ExistPlurial = "s", ExistFieldID = "SamplingPlanSubsectorID")]
        [CSSPDisplayEN(DisplayEN = "Sampling plan subsector ID")]
        [CSSPDisplayFR(DisplayFR = "Sous-secteur du plan d'échantillonnage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the SamplingPlanSubsectors table representing the sampling plan subsector")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table SamplingPlanSubsectors représentant le sous-secteur du plan d'échantillonnage")]
        public int SamplingPlanSubsectorID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "16")]
        [CSSPDisplayEN(DisplayEN = "MWQM site TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Site MWQM TVItemID (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the MWQM site")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant le site MWQM (fr)")]
        public int MWQMSiteTVItemID { get; set; }
        [CSSPDisplayEN(DisplayEN = "Is duplicate")]
        [CSSPDisplayFR(DisplayFR = "Est en double")]
        [CSSPDescriptionEN(DescriptionEN = @"Is duplicate")]
        [CSSPDescriptionFR(DescriptionFR = @"Est en double")]
        public bool IsDuplicate { get; set; }
        #endregion Properties in DB

        #region Constructors
        public SamplingPlanSubsectorSite() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SamplingPlanSubsectorSiteExtraA : SamplingPlanSubsectorSite
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMSiteTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "MWQM site TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du site MWQM (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"MWQM site TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du site MWQM (fr)")]
        public TVItemLanguage MWQMSiteTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public SamplingPlanSubsectorSiteExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SamplingPlanSubsectorSiteExtraB : SamplingPlanSubsectorSiteExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string SamplingPlanSubsectorSiteReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public SamplingPlanSubsectorSiteExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
