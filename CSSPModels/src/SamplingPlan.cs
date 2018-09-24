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
    public partial class SamplingPlan : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "SamplingPlan ID")]
        [CSSPDisplayFR(DisplayFR = "SamplingPlan ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the SamplingPlans table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table SamplingPlans")]
        public int SamplingPlanID { get; set; }
        [CSSPDisplayEN(DisplayEN = "Is active")]
        [CSSPDisplayFR(DisplayFR = "Est actif")]
        [CSSPDescriptionEN(DescriptionEN = @"Is active")]
        [CSSPDescriptionFR(DescriptionFR = @"Est actif")]
        public bool IsActive { get; set; }
        [StringLength(200)]
        [CSSPDisplayEN(DisplayEN = "Sampling plan name")]
        [CSSPDisplayFR(DisplayFR = "Nom du plan d'échantillonnage")]
        [CSSPDescriptionEN(DescriptionEN = @"Sampling plan name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du plan d'échantillonnage")]
        public string SamplingPlanName { get; set; }
        [StringLength(100)]
        [CSSPDisplayEN(DisplayEN = "For group name")]
        [CSSPDisplayFR(DisplayFR = "Nom pour le group")]
        [CSSPDescriptionEN(DescriptionEN = @"For group name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom pour le group")]
        public string ForGroupName { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Sample type")]
        [CSSPDisplayFR(DisplayFR = "Type d'échantillon")]
        [CSSPDescriptionEN(DescriptionEN = @"Sample type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type d'échantillon")]
        public SampleTypeEnum SampleType { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Sampling plan type")]
        [CSSPDisplayFR(DisplayFR = "Type de plan d'échantillonnage")]
        [CSSPDescriptionEN(DescriptionEN = @"Sampling plan type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type de plan d'échantillonnage")]
        public SamplingPlanTypeEnum SamplingPlanType { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Lab sheet type")]
        [CSSPDisplayFR(DisplayFR = "Type de feuille de laboratoire")]
        [CSSPDescriptionEN(DescriptionEN = @"Lab sheet type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type de feuille de laboratoire")]
        public LabSheetTypeEnum LabSheetType { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "18")]
        [CSSPDisplayEN(DisplayEN = "Province TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Province TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the province")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant la province")]
        public int ProvinceTVItemID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        [CSSPDisplayEN(DisplayEN = "Creator of sampling plan TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Créateur du plan d'échantillonnage TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the creator of the sampling plan")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant le créateur du plan d'échantillonnage")]
        public int CreatorTVItemID { get; set; }
        [Range(2000, 2050)]
        [CSSPDisplayEN(DisplayEN = "Year")]
        [CSSPDisplayFR(DisplayFR = "Année")]
        [CSSPDescriptionEN(DescriptionEN = @"Year")]
        [CSSPDescriptionFR(DescriptionFR = @"Année")]
        public int Year { get; set; }
        [StringLength(15)]
        [CSSPDisplayEN(DisplayEN = "Access code")]
        [CSSPDisplayFR(DisplayFR = "Code d'accès")]
        [CSSPDescriptionEN(DescriptionEN = @"Access code")]
        [CSSPDescriptionFR(DescriptionFR = @"Code d'accès")]
        public string AccessCode { get; set; }
        [Range(0.0D, 100.0D)]
        [CSSPDisplayEN(DisplayEN = "Daily duplicate precision criteria")]
        [CSSPDisplayFR(DisplayFR = "Critère de précision pour le duplicata journalier")]
        [CSSPDescriptionEN(DescriptionEN = @"Daily duplicate precision criteria")]
        [CSSPDescriptionFR(DescriptionFR = @"Critère de précision pour le duplicata journalier")]
        public double DailyDuplicatePrecisionCriteria { get; set; }
        [Range(0.0D, 100.0D)]
        [CSSPDisplayEN(DisplayEN = "Intertech duplicate precision criteria")]
        [CSSPDisplayFR(DisplayFR = "Critère de précision pour le duplicata intertech")]
        [CSSPDescriptionEN(DescriptionEN = @"Intertech duplicate precision criteria")]
        [CSSPDescriptionFR(DescriptionFR = @"Critère de précision pour le duplicata intertech")]
        public double IntertechDuplicatePrecisionCriteria { get; set; }
        [CSSPDisplayEN(DisplayEN = "Include laboratory QA/QC")]
        [CSSPDisplayFR(DisplayFR = "Inclure le QA/QC de laboratoire")]
        [CSSPDescriptionEN(DescriptionEN = @"Include laboratory QA/QC")]
        [CSSPDescriptionFR(DescriptionFR = @"Inclure le QA/QC de laboratoire")]
        public bool IncludeLaboratoryQAQC { get; set; }
        [StringLength(15)]
        [CSSPDisplayEN(DisplayEN = "Approval code")]
        [CSSPDisplayFR(DisplayFR = "Code d'approbation")]
        [CSSPDescriptionEN(DescriptionEN = @"Approval code")]
        [CSSPDescriptionFR(DescriptionFR = @"Code d'approbation")]
        public string ApprovalCode { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "8")]
        [CSSPDisplayEN(DisplayEN = "Sampling plan file TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Filière du plan d'échantillonnage TVItemID")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the sampling plan file")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant la filière du plan d'échantillonnage")]
        public int? SamplingPlanFileTVItemID { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Analyze method")]
        [CSSPDisplayFR(DisplayFR = "Méthode d'analyse")]
        [CSSPDescriptionEN(DescriptionEN = @"Analyze method")]
        [CSSPDescriptionFR(DescriptionFR = @"Méthode d'analyse")]
        public AnalyzeMethodEnum? AnalyzeMethodDefault { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Sample matrix")]
        [CSSPDisplayFR(DisplayFR = "Milieu d'échantillon")]
        [CSSPDescriptionEN(DescriptionEN = @"Sample matrix")]
        [CSSPDescriptionFR(DescriptionFR = @"Milieu d'échantillon")]
        public SampleMatrixEnum? SampleMatrixDefault { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Laboratory")]
        [CSSPDisplayFR(DisplayFR = "Laboratoire")]
        [CSSPDescriptionEN(DescriptionEN = @"Laboratory")]
        [CSSPDescriptionFR(DescriptionFR = @"Laboratoire")]
        public LaboratoryEnum? LaboratoryDefault { get; set; }
        [StringLength(250)]
        [CSSPDisplayEN(DisplayEN = "Backup directory")]
        [CSSPDisplayFR(DisplayFR = "Répertoire de sauvegarde")]
        [CSSPDescriptionEN(DescriptionEN = @"Backup directory")]
        [CSSPDescriptionFR(DescriptionFR = @"Répertoire de sauvegarde")]
        public string BackupDirectory { get; set; }
        #endregion Properties in DB

        #region Constructors
        public SamplingPlan() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SamplingPlan_A : SamplingPlan
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ProvinceTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Province TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage de la province")]
        [CSSPDescriptionEN(DescriptionEN = @"Province TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage de la province")]
        public TVItemLanguage ProvinceTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "CreatorTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Creator of the sampling plan TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du créateur du plan d'échantillonnage")]
        [CSSPDescriptionEN(DescriptionEN = @"Creator of the sampling plan TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du créateur du plan d'échantillonnage")]
        public TVItemLanguage CreatorTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SamplingPlanFileTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Sampling plan file TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage de la filière du plan d'échantillonnage")]
        [CSSPDescriptionEN(DescriptionEN = @"ampling plan file TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage de la filière du plan d'échantillonnage")]
        public TVItemLanguage SamplingPlanFileTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "SampleTypeEnum", EnumType = "SampleType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Sample type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type d'échantillon")]
        [CSSPDescriptionEN(DescriptionEN = @"Sample type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type d'échantillon")]
        public string SampleTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "SamplingPlanTypeEnum", EnumType = "SamplingPlanType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Sampling plan type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type du plan d'échantillonnage")]
        [CSSPDescriptionEN(DescriptionEN = @"Sampling plan type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type du plan d'échantillonnage")]
        public string SamplingPlanTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "LabSheetTypeEnum", EnumType = "LabSheetType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Lab sheet type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type de feuille de laboratoire")]
        [CSSPDescriptionEN(DescriptionEN = @"Labratory sheet type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type de feuille de laboratoire")]
        public string LabSheetTypeText { get; set; }
        #endregion Properties

        #region Constructors
        public SamplingPlan_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SamplingPlan_B : SamplingPlan_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string SamplingPlanReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public SamplingPlan_B() : base()
        {
        }
        #endregion Constructors
    }
}
