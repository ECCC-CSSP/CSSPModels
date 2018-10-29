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
    public partial class SamplingPlanSubsector : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "SamplingPlanSubsector ID")]
        [CSSPDisplayFR(DisplayFR = "SamplingPlanSubsector ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the SamplingPlanSubsectors table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table SamplingPlanSubsectors")]
        public int SamplingPlanSubsectorID { get; set; }
        [CSSPExist(ExistTypeName = "SamplingPlan", ExistPlurial = "s", ExistFieldID = "SamplingPlanID")]
        [CSSPDisplayEN(DisplayEN = "Sampling plan ID")]
        [CSSPDisplayFR(DisplayFR = "Plan d'échantillonnage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the SamplingPlan table representing the sampling plan")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table SamplingPlan représentant le plan d'échantillonnage")]
        public int SamplingPlanID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]
        [CSSPDisplayEN(DisplayEN = "Subsector TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Sous-secteur TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the subsector")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant le sous-secteur")]
        public int SubsectorTVItemID { get; set; }
        #endregion Properties in DB

        #region Constructors
        public SamplingPlanSubsector() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SamplingPlanSubsectorExtraA : SamplingPlanSubsector
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SubsectorTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Subsector text")]
        [CSSPDisplayFR(DisplayFR = "Texte du sous-secteur")]
        [CSSPDescriptionEN(DescriptionEN = @"Subsector text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du sous-secteur")]
        public string SubsectorText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact ayant fait le dernière changement")]
        public string LastUpdateContactText { get; set; }
        #endregion Properties

        #region Constructors
        public SamplingPlanSubsectorExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SamplingPlanSubsectorExtraB : SamplingPlanSubsectorExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string SamplingPlanSubsectorReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public SamplingPlanSubsectorExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
