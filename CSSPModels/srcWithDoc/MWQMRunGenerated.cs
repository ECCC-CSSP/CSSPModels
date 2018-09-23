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
    /// > <para>**DB properties for table MWQMRuns** : [MWQMRunID](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_MWQMRunID), [SubsectorTVItemID](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_SubsectorTVItemID), [MWQMRunTVItemID](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_MWQMRunTVItemID), [RunSampleType](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_RunSampleType), [DateTime_Local](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_DateTime_Local), [RunNumber](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_RunNumber), [StartDateTime_Local](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_StartDateTime_Local), [EndDateTime_Local](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_EndDateTime_Local), [LabReceivedDateTime_Local](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_LabReceivedDateTime_Local), [TemperatureControl1_C](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_TemperatureControl1_C), [TemperatureControl2_C](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_TemperatureControl2_C), [SeaStateAtStart_BeaufortScale](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_SeaStateAtStart_BeaufortScale), [SeaStateAtEnd_BeaufortScale](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_SeaStateAtEnd_BeaufortScale), [WaterLevelAtBrook_m](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_WaterLevelAtBrook_m), [WaveHightAtStart_m](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_WaveHightAtStart_m), [WaveHightAtEnd_m](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_WaveHightAtEnd_m), [SampleCrewInitials](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_SampleCrewInitials), [AnalyzeMethod](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_AnalyzeMethod), [SampleMatrix](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_SampleMatrix), [Laboratory](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_Laboratory), [SampleStatus](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_SampleStatus), [LabSampleApprovalContactTVItemID](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_LabSampleApprovalContactTVItemID), [LabAnalyzeBath1IncubationStartDateTime_Local](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_LabAnalyzeBath1IncubationStartDateTime_Local), [LabAnalyzeBath2IncubationStartDateTime_Local](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_LabAnalyzeBath2IncubationStartDateTime_Local), [LabAnalyzeBath3IncubationStartDateTime_Local](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_LabAnalyzeBath3IncubationStartDateTime_Local), [LabRunSampleApprovalDateTime_Local](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_LabRunSampleApprovalDateTime_Local), [Tide_Start](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_Tide_Start), [Tide_End](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_Tide_End), [RainDay0_mm](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_RainDay0_mm), [RainDay1_mm](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_RainDay1_mm), [RainDay2_mm](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_RainDay2_mm), [RainDay3_mm](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_RainDay3_mm), [RainDay4_mm](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_RainDay4_mm), [RainDay5_mm](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_RainDay5_mm), [RainDay6_mm](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_RainDay6_mm), [RainDay7_mm](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_RainDay7_mm), [RainDay8_mm](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_RainDay8_mm), [RainDay9_mm](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_RainDay9_mm), [RainDay10_mm](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_RainDay10_mm), [RemoveFromStat](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_RemoveFromStat), [LastUpdateDate_UTC](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_HasErrors), [ValidationResults](CSSPModels.MWQMRun.html#CSSPModels_MWQMRun_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [MWQMRunService](CSSPServices.MWQMRunService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [SampleTypeEnum](CSSPEnums.SampleTypeEnum.html), [BeaufortScaleEnum](CSSPEnums.BeaufortScaleEnum.html), [BeaufortScaleEnum](CSSPEnums.BeaufortScaleEnum.html), [AnalyzeMethodEnum](CSSPEnums.AnalyzeMethodEnum.html), [SampleMatrixEnum](CSSPEnums.SampleMatrixEnum.html), [LaboratoryEnum](CSSPEnums.LaboratoryEnum.html), [SampleStatusEnum](CSSPEnums.SampleStatusEnum.html), [TideTextEnum](CSSPEnums.TideTextEnum.html), [TideTextEnum](CSSPEnums.TideTextEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class MWQMRun : LastUpdate
    {
        #region Properties in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "MWQMRun ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "MWQMRun ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Contains the unique "identifier on each row of the MWQMRuns table")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Contient l'identifiant unique sur chaque ligne de la table MWQMRuns")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- MWQMRun ID
        /// 
        /// **Display (fr)** --- MWQMRun ID
        /// 
        /// **Description (en)** --- Contains the unique "identifier on each row of the MWQMRuns table
        /// 
        /// **Description (fr)** --- Contient l'identifiant unique sur chaque ligne de la table MWQMRuns
        /// </returns>
        [Key]
        [CSSPDisplayEN(DisplayEN = "MWQMRun ID")]
        [CSSPDisplayFR(DisplayFR = "MWQMRun ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MWQMRuns table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table MWQMRuns")]
        public int MWQMRunID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>20 == Subsector</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]
        public int SubsectorTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>31 == MWQMRun</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "31")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "31")]
        public int MWQMRunTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public SampleTypeEnum RunSampleType { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime DateTime_Local { get; set; }
        [Range(1, 1000)]
        public int RunNumber { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime? StartDateTime_Local { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// > <para>[[CSSPBigger](CSSPModels.CSSPBiggerAttribute.html)(OtherField = "StartDateTime_Local")]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        [CSSPBigger(OtherField = "StartDateTime_Local")]
        public DateTime? EndDateTime_Local { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime? LabReceivedDateTime_Local { get; set; }
        [Range(-10.0D, 40.0D)]
        public double? TemperatureControl1_C { get; set; }
        [Range(-10.0D, 40.0D)]
        public double? TemperatureControl2_C { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        [CSSPAllowNull]
        public BeaufortScaleEnum? SeaStateAtStart_BeaufortScale { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        [CSSPAllowNull]
        public BeaufortScaleEnum? SeaStateAtEnd_BeaufortScale { get; set; }
        [Range(0.0D, 100.0D)]
        public double? WaterLevelAtBrook_m { get; set; }
        [Range(0.0D, 100.0D)]
        public double? WaveHightAtStart_m { get; set; }
        [Range(0.0D, 100.0D)]
        public double? WaveHightAtEnd_m { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(20)]
        [CSSPAllowNull]
        public string SampleCrewInitials { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        [CSSPAllowNull]
        public AnalyzeMethodEnum? AnalyzeMethod { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        [CSSPAllowNull]
        public SampleMatrixEnum? SampleMatrix { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        [CSSPAllowNull]
        public LaboratoryEnum? Laboratory { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        [CSSPAllowNull]
        public SampleStatusEnum? SampleStatus { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>5 == Contact</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int? LabSampleApprovalContactTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime? LabAnalyzeBath1IncubationStartDateTime_Local { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime? LabAnalyzeBath2IncubationStartDateTime_Local { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime? LabAnalyzeBath3IncubationStartDateTime_Local { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime? LabRunSampleApprovalDateTime_Local { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        [CSSPAllowNull]
        public TideTextEnum? Tide_Start { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        [CSSPAllowNull]
        public TideTextEnum? Tide_End { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay0_mm { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay1_mm { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay2_mm { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay3_mm { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay4_mm { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay5_mm { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay6_mm { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay7_mm { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay8_mm { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay9_mm { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainDay10_mm { get; set; }
        public bool? RemoveFromStat { get; set; }
        #endregion Properties in DB

        #region Constructors
        public MWQMRun() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMRun_A : MWQMRun
    {
        #region Properties
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SubsectorTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SubsectorTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        public TVItemLanguage SubsectorTVItemLanguage { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMRunTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMRunTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        public TVItemLanguage MWQMRunTVItemLanguage { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LabSampleApprovalContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LabSampleApprovalContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        public TVItemLanguage LabSampleApprovalContactTVItemLanguage { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Last update contact TVItemLanguage")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Last update contact TVItemLanguage DB object")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Object BD TVItemLanguage du contact ayant fait le dernière changement")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Last update contact TVItemLanguage
        /// 
        /// **Display (fr)** --- TVItemLanguage du contact ayant fait le dernière changement
        /// 
        /// **Description (en)** --- Last update contact TVItemLanguage DB object
        /// 
        /// **Description (fr)** --- Object BD TVItemLanguage du contact ayant fait le dernière changement
        /// </returns>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "SampleTypeEnum", EnumType = "RunSampleType")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "SampleTypeEnum", EnumType = "RunSampleType")]
        [CSSPAllowNull]
        public string RunSampleTypeText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "BeaufortScaleEnum", EnumType = "SeaStateAtStart_BeaufortScale")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "BeaufortScaleEnum", EnumType = "SeaStateAtStart_BeaufortScale")]
        [CSSPAllowNull]
        public string SeaStateAtStart_BeaufortScaleText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "BeaufortScaleEnum", EnumType = "SeaStateAtEnd_BeaufortScale")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "BeaufortScaleEnum", EnumType = "SeaStateAtEnd_BeaufortScale")]
        [CSSPAllowNull]
        public string SeaStateAtEnd_BeaufortScaleText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "AnalyzeMethodEnum", EnumType = "AnalyzeMethod")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "AnalyzeMethodEnum", EnumType = "AnalyzeMethod")]
        [CSSPAllowNull]
        public string AnalyzeMethodText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "SampleMatrixEnum", EnumType = "SampleMatrix")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "SampleMatrixEnum", EnumType = "SampleMatrix")]
        [CSSPAllowNull]
        public string SampleMatrixText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "LaboratoryEnum", EnumType = "Laboratory")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "LaboratoryEnum", EnumType = "Laboratory")]
        [CSSPAllowNull]
        public string LaboratoryText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "SampleStatusEnum", EnumType = "SampleStatus")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "SampleStatusEnum", EnumType = "SampleStatus")]
        [CSSPAllowNull]
        public string SampleStatusText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TideTextEnum", EnumType = "Tide_Start")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "TideTextEnum", EnumType = "Tide_Start")]
        [CSSPAllowNull]
        public string Tide_StartText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TideTextEnum", EnumType = "Tide_End")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "TideTextEnum", EnumType = "Tide_End")]
        [CSSPAllowNull]
        public string Tide_EndText { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMRun_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMRun_B : MWQMRun_A
    {
        #region Properties
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Report test")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Test report")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Report test description")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Description de test report")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Report test
        /// 
        /// **Display (fr)** --- Test report
        /// 
        /// **Description (en)** --- Report test description
        /// 
        /// **Description (fr)** --- Description de test report
        /// </returns>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string MWQMRunReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMRun_B() : base()
        {
        }
        #endregion Constructors
    }
}
