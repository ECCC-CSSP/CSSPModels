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
    /// > <para>**DB properties for table LabSheetDetails** : [LabSheetDetailID](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_LabSheetDetailID), [LabSheetID](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_LabSheetID), [SamplingPlanID](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_SamplingPlanID), [SubsectorTVItemID](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_SubsectorTVItemID), [Version](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_Version), [RunDate](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_RunDate), [Tides](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_Tides), [SampleCrewInitials](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_SampleCrewInitials), [WaterBathCount](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_WaterBathCount), [IncubationBath1StartTime](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_IncubationBath1StartTime), [IncubationBath2StartTime](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_IncubationBath2StartTime), [IncubationBath3StartTime](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_IncubationBath3StartTime), [IncubationBath1EndTime](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_IncubationBath1EndTime), [IncubationBath2EndTime](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_IncubationBath2EndTime), [IncubationBath3EndTime](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_IncubationBath3EndTime), [IncubationBath1TimeCalculated_minutes](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_IncubationBath1TimeCalculated_minutes), [IncubationBath2TimeCalculated_minutes](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_IncubationBath2TimeCalculated_minutes), [IncubationBath3TimeCalculated_minutes](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_IncubationBath3TimeCalculated_minutes), [WaterBath1](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_WaterBath1), [WaterBath2](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_WaterBath2), [WaterBath3](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_WaterBath3), [TCField1](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_TCField1), [TCLab1](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_TCLab1), [TCField2](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_TCField2), [TCLab2](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_TCLab2), [TCFirst](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_TCFirst), [TCAverage](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_TCAverage), [ControlLot](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_ControlLot), [Positive35](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_Positive35), [NonTarget35](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_NonTarget35), [Negative35](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_Negative35), [Bath1Positive44_5](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_Bath1Positive44_5), [Bath2Positive44_5](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_Bath2Positive44_5), [Bath3Positive44_5](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_Bath3Positive44_5), [Bath1NonTarget44_5](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_Bath1NonTarget44_5), [Bath2NonTarget44_5](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_Bath2NonTarget44_5), [Bath3NonTarget44_5](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_Bath3NonTarget44_5), [Bath1Negative44_5](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_Bath1Negative44_5), [Bath2Negative44_5](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_Bath2Negative44_5), [Bath3Negative44_5](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_Bath3Negative44_5), [Blank35](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_Blank35), [Bath1Blank44_5](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_Bath1Blank44_5), [Bath2Blank44_5](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_Bath2Blank44_5), [Bath3Blank44_5](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_Bath3Blank44_5), [Lot35](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_Lot35), [Lot44_5](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_Lot44_5), [Weather](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_Weather), [RunComment](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_RunComment), [RunWeatherComment](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_RunWeatherComment), [SampleBottleLotNumber](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_SampleBottleLotNumber), [SalinitiesReadBy](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_SalinitiesReadBy), [SalinitiesReadDate](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_SalinitiesReadDate), [ResultsReadBy](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_ResultsReadBy), [ResultsReadDate](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_ResultsReadDate), [ResultsRecordedBy](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_ResultsRecordedBy), [ResultsRecordedDate](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_ResultsRecordedDate), [DailyDuplicateRLog](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_DailyDuplicateRLog), [DailyDuplicatePrecisionCriteria](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_DailyDuplicatePrecisionCriteria), [DailyDuplicateAcceptable](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_DailyDuplicateAcceptable), [IntertechDuplicateRLog](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_IntertechDuplicateRLog), [IntertechDuplicatePrecisionCriteria](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_IntertechDuplicatePrecisionCriteria), [IntertechDuplicateAcceptable](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_IntertechDuplicateAcceptable), [IntertechReadAcceptable](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_IntertechReadAcceptable), [LastUpdateDate_UTC](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_HasErrors), [ValidationResults](CSSPModels.LabSheetDetail.html#CSSPModels_LabSheetDetail_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [LabSheetDetailService](CSSPServices.LabSheetDetailService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class LabSheetDetail : LastUpdate
    {
        #region Properties in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "LabSheetDetail ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "LabSheetDetail ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Contains the unique "identifier on each row of the LabSheetDetails table")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Contient l'identifiant unique sur chaque ligne de la table LabSheetDetails")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- LabSheetDetail ID
        /// 
        /// **Display (fr)** --- LabSheetDetail ID
        /// 
        /// **Description (en)** --- Contains the unique "identifier on each row of the LabSheetDetails table
        /// 
        /// **Description (fr)** --- Contient l'identifiant unique sur chaque ligne de la table LabSheetDetails
        /// </returns>
        [Key]
        [CSSPDisplayEN(DisplayEN = "LabSheetDetail ID")]
        [CSSPDisplayFR(DisplayFR = "LabSheetDetail ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the LabSheetDetails table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table LabSheetDetails")]
        public int LabSheetDetailID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "LabSheet", ExistPlurial = "s", ExistFieldID = "LabSheetID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "LabSheet", ExistPlurial = "s", ExistFieldID = "LabSheetID")]
        public int LabSheetID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "SamplingPlan", ExistPlurial = "s", ExistFieldID = "SamplingPlanID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "SamplingPlan", ExistPlurial = "s", ExistFieldID = "SamplingPlanID")]
        public int SamplingPlanID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>20 == Subsector</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]
        public int SubsectorTVItemID { get; set; }
        [Range(1, 5)]
        public int Version { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime RunDate { get; set; }
        [StringLength(7, MinimumLength = 1)]
        public string Tides { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(20)]
        [CSSPAllowNull]
        public string SampleCrewInitials { get; set; }
        [Range(1, 3)]
        public int? WaterBathCount { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime? IncubationBath1StartTime { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime? IncubationBath2StartTime { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime? IncubationBath3StartTime { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime? IncubationBath1EndTime { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime? IncubationBath2EndTime { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime? IncubationBath3EndTime { get; set; }
        [Range(0, 10000)]
        public int? IncubationBath1TimeCalculated_minutes { get; set; }
        [Range(0, 10000)]
        public int? IncubationBath2TimeCalculated_minutes { get; set; }
        [Range(0, 10000)]
        public int? IncubationBath3TimeCalculated_minutes { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(10)]
        [CSSPAllowNull]
        public string WaterBath1 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(10)]
        [CSSPAllowNull]
        public string WaterBath2 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(10)]
        [CSSPAllowNull]
        public string WaterBath3 { get; set; }
        [Range(-10.0D, 40.0D)]
        public double? TCField1 { get; set; }
        [Range(-10.0D, 40.0D)]
        public double? TCLab1 { get; set; }
        [Range(-10.0D, 40.0D)]
        public double? TCField2 { get; set; }
        [Range(-10.0D, 40.0D)]
        public double? TCLab2 { get; set; }
        [Range(-10.0D, 40.0D)]
        public double? TCFirst { get; set; }
        [Range(-10.0D, 40.0D)]
        public double? TCAverage { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(100)]
        [CSSPAllowNull]
        public string ControlLot { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Positive35 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string NonTarget35 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Negative35 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Bath1Positive44_5 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Bath2Positive44_5 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Bath3Positive44_5 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Bath1NonTarget44_5 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Bath2NonTarget44_5 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Bath3NonTarget44_5 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Bath1Negative44_5 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Bath2Negative44_5 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Bath3Negative44_5 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Blank35 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Bath1Blank44_5 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Bath2Blank44_5 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(1, MinimumLength = 1)]
        [CSSPAllowNull]
        public string Bath3Blank44_5 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(20)]
        [CSSPAllowNull]
        public string Lot35 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(20)]
        [CSSPAllowNull]
        public string Lot44_5 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(250)]
        [CSSPAllowNull]
        public string Weather { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(250)]
        [CSSPAllowNull]
        public string RunComment { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(250)]
        [CSSPAllowNull]
        public string RunWeatherComment { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(20)]
        [CSSPAllowNull]
        public string SampleBottleLotNumber { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(20)]
        [CSSPAllowNull]
        public string SalinitiesReadBy { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime? SalinitiesReadDate { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(20)]
        [CSSPAllowNull]
        public string ResultsReadBy { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime? ResultsReadDate { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(20)]
        [CSSPAllowNull]
        public string ResultsRecordedBy { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime? ResultsRecordedDate { get; set; }
        [Range(0.0D, 100.0D)]
        public double? DailyDuplicateRLog { get; set; }
        [Range(0.0D, 100.0D)]
        public double? DailyDuplicatePrecisionCriteria { get; set; }
        public bool? DailyDuplicateAcceptable { get; set; }
        [Range(0.0D, 100.0D)]
        public double? IntertechDuplicateRLog { get; set; }
        [Range(0.0D, 100.0D)]
        public double? IntertechDuplicatePrecisionCriteria { get; set; }
        public bool? IntertechDuplicateAcceptable { get; set; }
        public bool? IntertechReadAcceptable { get; set; }
        #endregion Properties in DB

        #region Constructors
        public LabSheetDetail() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class LabSheetDetail_A : LabSheetDetail
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
        #endregion Properties

        #region Constructors
        public LabSheetDetail_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class LabSheetDetail_B : LabSheetDetail_A
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
        public string LabSheetDetailReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public LabSheetDetail_B() : base()
        {
        }
        #endregion Constructors
    }
}
