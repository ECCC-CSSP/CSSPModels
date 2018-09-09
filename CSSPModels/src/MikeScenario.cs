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
    public partial class MikeScenario : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MikeScenario ID")]
        [CSSPDisplayFR(DisplayFR = "MikeScenario ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MikeScenarios table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table MikeScenarios")]
        public int MikeScenarioID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "13")]
        public int MikeScenarioTVItemID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "13")]
        public int? ParentMikeScenarioID { get; set; }
        [CSSPEnumType]
        public ScenarioStatusEnum ScenarioStatus { get; set; }
        [CSSPAllowNull]
        public string ErrorInfo { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime MikeScenarioStartDateTime_Local { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime MikeScenarioEndDateTime_Local { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? MikeScenarioStartExecutionDateTime_Local { get; set; }
        [Range(1.0D, 100000.0D)]
        public double? MikeScenarioExecutionTime_min { get; set; }
        [Range(0.0D, 100.0D)]
        public double WindSpeed_km_h { get; set; }
        [Range(0.0D, 360.0D)]
        public double WindDirection_deg { get; set; }
        [Range(0.0D, 100.0D)]
        public double DecayFactor_per_day { get; set; }
        public bool DecayIsConstant { get; set; }
        [Range(0.0D, 100.0D)]
        public double DecayFactorAmplitude { get; set; }
        [Range(0, 100)]
        public int ResultFrequency_min { get; set; }
        [Range(-10.0D, 40.0D)]
        public double AmbientTemperature_C { get; set; }
        [Range(0.0D, 40.0D)]
        public double AmbientSalinity_PSU { get; set; }
        public bool? GenerateDecouplingFiles { get; set; }
        public bool? UseDecouplingFiles { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "8")]
        public int? UseSalinityAndTemperatureInitialConditionFromTVFileTVItemID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "31")]
        public int? ForSimulatingMWQMRunTVItemID { get; set; }
        [Range(0.0D, 100.0D)]
        public double ManningNumber { get; set; }
        [Range(1, 1000000)]
        public int? NumberOfElements { get; set; }
        [Range(1, 1000000)]
        public int? NumberOfTimeSteps { get; set; }
        [Range(0, 100)]
        public int? NumberOfSigmaLayers { get; set; }
        [Range(0, 100)]
        public int? NumberOfZLayers { get; set; }
        [Range(0, 100)]
        public int? NumberOfHydroOutputParameters { get; set; }
        [Range(0, 100)]
        public int? NumberOfTransOutputParameters { get; set; }
        [Range(0, 100000000)]
        public long? EstimatedHydroFileSize { get; set; }
        [Range(0, 100000000)]
        public long? EstimatedTransFileSize { get; set; }
        #endregion Properties in DB

        #region Constructors
        public MikeScenario() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MikeScenario_A : MikeScenario
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MikeScenarioTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        public TVItemLanguage MikeScenarioTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "ScenarioStatusEnum", EnumType = "ScenarioStatus")]
        [CSSPAllowNull]
        public string ScenarioStatusText { get; set; }
        #endregion Properties

        #region Constructors
        public MikeScenario_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MikeScenario_B : MikeScenario_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string MikeScenarioReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public MikeScenario_B() : base()
        {
        }
        #endregion Constructors
    }
}
