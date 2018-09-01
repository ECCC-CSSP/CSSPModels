/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by Charles on CHARLES-PC machine
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
    /// > <para>**DB properties for table MikeScenarios** : [MikeScenarioID](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_MikeScenarioID), [MikeScenarioTVItemID](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_MikeScenarioTVItemID), [ParentMikeScenarioID](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_ParentMikeScenarioID), [ScenarioStatus](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_ScenarioStatus), [ErrorInfo](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_ErrorInfo), [MikeScenarioStartDateTime_Local](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_MikeScenarioStartDateTime_Local), [MikeScenarioEndDateTime_Local](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_MikeScenarioEndDateTime_Local), [MikeScenarioStartExecutionDateTime_Local](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_MikeScenarioStartExecutionDateTime_Local), [MikeScenarioExecutionTime_min](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_MikeScenarioExecutionTime_min), [WindSpeed_km_h](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_WindSpeed_km_h), [WindDirection_deg](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_WindDirection_deg), [DecayFactor_per_day](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_DecayFactor_per_day), [DecayIsConstant](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_DecayIsConstant), [DecayFactorAmplitude](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_DecayFactorAmplitude), [ResultFrequency_min](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_ResultFrequency_min), [AmbientTemperature_C](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_AmbientTemperature_C), [AmbientSalinity_PSU](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_AmbientSalinity_PSU), [ManningNumber](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_ManningNumber), [NumberOfElements](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_NumberOfElements), [NumberOfTimeSteps](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_NumberOfTimeSteps), [NumberOfSigmaLayers](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_NumberOfSigmaLayers), [NumberOfZLayers](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_NumberOfZLayers), [NumberOfHydroOutputParameters](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_NumberOfHydroOutputParameters), [NumberOfTransOutputParameters](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_NumberOfTransOutputParameters), [EstimatedHydroFileSize](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_EstimatedHydroFileSize), [EstimatedTransFileSize](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_EstimatedTransFileSize), [LastUpdateDate_UTC](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_HasErrors), [ValidationResults](CSSPModels.MikeScenario.html#CSSPModels_MikeScenario_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [MikeScenarioService](CSSPServices.MikeScenarioService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [ScenarioStatusEnum](CSSPEnums.ScenarioStatusEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class MikeScenario : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MikeScenario ID")]
        [CSSPDisplayFR(DisplayFR = "MikeScenario ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MikeScenarios table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table MikeScenarios")]
        public int MikeScenarioID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>13 == MikeScenario</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "13")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "13")]
        public int MikeScenarioTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>13 == MikeScenario</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "13")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "13")]
        public int? ParentMikeScenarioID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public ScenarioStatusEnum ScenarioStatus { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string ErrorInfo { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime MikeScenarioStartDateTime_Local { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime MikeScenarioEndDateTime_Local { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
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
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MikeScenarioTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MikeScenarioTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        public TVItemLanguage MikeScenarioTVItemLanguage { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "ScenarioStatusEnum", EnumType = "ScenarioStatus")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
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
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
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
