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
    public partial class SamplingPlanSubsector : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "SamplingPlanSubsector ID")]
        [CSSPDisplayFR(DisplayFR = "SamplingPlanSubsector ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the SamplingPlanSubsectors table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau SamplingPlanSubsectors")]
        public int SamplingPlanSubsectorID { get; set; }
        [CSSPExist(ExistTypeName = "SamplingPlan", ExistPlurial = "s", ExistFieldID = "SamplingPlanID")]
        public int SamplingPlanID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]
        public int SubsectorTVItemID { get; set; }
        #endregion Properties in DB

        #region Constructors
        public SamplingPlanSubsector() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SamplingPlanSubsectorWeb : SamplingPlanSubsector
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SubsectorTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage SubsectorTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties for web information

        #region Constructors
        public SamplingPlanSubsectorWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SamplingPlanSubsectorReport : SamplingPlanSubsectorWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string SamplingPlanSubsectorReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public SamplingPlanSubsectorReport() : base()
        {
        }
        #endregion Constructors
    }
}
