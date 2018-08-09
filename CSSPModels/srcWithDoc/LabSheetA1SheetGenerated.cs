/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by leblancc on WMON01DTCHLEBL2 machine
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
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [Error](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_Error), [Version](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_Version), [SamplingPlanType](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_SamplingPlanType), [SampleType](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_SampleType), [LabSheetType](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_LabSheetType), [SubsectorName](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_SubsectorName), [SubsectorLocation](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_SubsectorLocation), [SubsectorTVItemID](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_SubsectorTVItemID), [RunYear](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_RunYear), [RunMonth](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_RunMonth), [RunDay](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_RunDay), [RunNumber](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_RunNumber), [Tides](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_Tides), [SampleCrewInitials](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_SampleCrewInitials), [IncubationStartSameDay](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_IncubationStartSameDay), [WaterBathCount](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_WaterBathCount), [IncubationBath1StartTime](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_IncubationBath1StartTime), [IncubationBath2StartTime](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_IncubationBath2StartTime), [IncubationBath3StartTime](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_IncubationBath3StartTime), [IncubationBath1EndTime](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_IncubationBath1EndTime), [IncubationBath2EndTime](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_IncubationBath2EndTime), [IncubationBath3EndTime](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_IncubationBath3EndTime), [IncubationBath1TimeCalculated](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_IncubationBath1TimeCalculated), [IncubationBath2TimeCalculated](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_IncubationBath2TimeCalculated), [IncubationBath3TimeCalculated](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_IncubationBath3TimeCalculated), [WaterBath1](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_WaterBath1), [WaterBath2](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_WaterBath2), [WaterBath3](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_WaterBath3), [TCField1](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_TCField1), [TCLab1](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_TCLab1), [TCHas2Coolers](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_TCHas2Coolers), [TCField2](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_TCField2), [TCLab2](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_TCLab2), [TCFirst](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_TCFirst), [TCAverage](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_TCAverage), [ControlLot](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_ControlLot), [Positive35](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_Positive35), [NonTarget35](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_NonTarget35), [Negative35](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_Negative35), [Bath1Positive44_5](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_Bath1Positive44_5), [Bath2Positive44_5](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_Bath2Positive44_5), [Bath3Positive44_5](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_Bath3Positive44_5), [Bath1NonTarget44_5](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_Bath1NonTarget44_5), [Bath2NonTarget44_5](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_Bath2NonTarget44_5), [Bath3NonTarget44_5](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_Bath3NonTarget44_5), [Bath1Negative44_5](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_Bath1Negative44_5), [Bath2Negative44_5](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_Bath2Negative44_5), [Bath3Negative44_5](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_Bath3Negative44_5), [Blank35](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_Blank35), [Bath1Blank44_5](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_Bath1Blank44_5), [Bath2Blank44_5](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_Bath2Blank44_5), [Bath3Blank44_5](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_Bath3Blank44_5), [Lot35](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_Lot35), [Lot44_5](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_Lot44_5), [RunComment](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_RunComment), [RunWeatherComment](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_RunWeatherComment), [SampleBottleLotNumber](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_SampleBottleLotNumber), [SalinitiesReadBy](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_SalinitiesReadBy), [SalinitiesReadYear](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_SalinitiesReadYear), [SalinitiesReadMonth](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_SalinitiesReadMonth), [SalinitiesReadDay](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_SalinitiesReadDay), [ResultsReadBy](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_ResultsReadBy), [ResultsReadYear](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_ResultsReadYear), [ResultsReadMonth](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_ResultsReadMonth), [ResultsReadDay](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_ResultsReadDay), [ResultsRecordedBy](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_ResultsRecordedBy), [ResultsRecordedYear](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_ResultsRecordedYear), [ResultsRecordedMonth](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_ResultsRecordedMonth), [ResultsRecordedDay](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_ResultsRecordedDay), [DailyDuplicateRLog](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_DailyDuplicateRLog), [DailyDuplicatePrecisionCriteria](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_DailyDuplicatePrecisionCriteria), [DailyDuplicateAcceptableOrUnacceptable](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_DailyDuplicateAcceptableOrUnacceptable), [IntertechDuplicateRLog](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_IntertechDuplicateRLog), [IntertechDuplicatePrecisionCriteria](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_IntertechDuplicatePrecisionCriteria), [IntertechDuplicateAcceptableOrUnacceptable](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_IntertechDuplicateAcceptableOrUnacceptable), [IntertechReadAcceptableOrUnacceptable](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_IntertechReadAcceptableOrUnacceptable), [ApprovalYear](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_ApprovalYear), [ApprovalMonth](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_ApprovalMonth), [ApprovalDay](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_ApprovalDay), [ApprovedBySupervisorInitials](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_ApprovedBySupervisorInitials), [IncludeLaboratoryQAQC](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_IncludeLaboratoryQAQC), [Log](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_Log), [SamplingPlanTypeText](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_SamplingPlanTypeText), [SampleTypeText](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_SampleTypeText), [LabSheetTypeText](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_LabSheetTypeText), [LabSheetA1MeasurementList](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_LabSheetA1MeasurementList), [HasErrors](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_HasErrors), [ValidationResults](CSSPModels.LabSheetA1Sheet.html#CSSPModels_LabSheetA1Sheet_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [LabSheetA1SheetService](CSSPServices.LabSheetA1SheetService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [SamplingPlanTypeEnum](CSSPEnums.SamplingPlanTypeEnum.html), [SampleTypeEnum](CSSPEnums.SampleTypeEnum.html), [LabSheetTypeEnum](CSSPEnums.LabSheetTypeEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class LabSheetA1Sheet : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public string Error { get; set; }
        [Range(1, 100)]
        public int Version { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public SamplingPlanTypeEnum SamplingPlanType { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public SampleTypeEnum SampleType { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public LabSheetTypeEnum LabSheetType { get; set; }
        public string SubsectorName { get; set; }
        public string SubsectorLocation { get; set; }
        public int SubsectorTVItemID { get; set; }
        public string RunYear { get; set; }
        public string RunMonth { get; set; }
        public string RunDay { get; set; }
        public int RunNumber { get; set; }
        public string Tides { get; set; }
        public string SampleCrewInitials { get; set; }
        public string IncubationStartSameDay { get; set; }
        public int WaterBathCount { get; set; }
        public string IncubationBath1StartTime { get; set; }
        public string IncubationBath2StartTime { get; set; }
        public string IncubationBath3StartTime { get; set; }
        public string IncubationBath1EndTime { get; set; }
        public string IncubationBath2EndTime { get; set; }
        public string IncubationBath3EndTime { get; set; }
        public string IncubationBath1TimeCalculated { get; set; }
        public string IncubationBath2TimeCalculated { get; set; }
        public string IncubationBath3TimeCalculated { get; set; }
        public string WaterBath1 { get; set; }
        public string WaterBath2 { get; set; }
        public string WaterBath3 { get; set; }
        public string TCField1 { get; set; }
        public string TCLab1 { get; set; }
        public string TCHas2Coolers { get; set; }
        public string TCField2 { get; set; }
        public string TCLab2 { get; set; }
        public string TCFirst { get; set; }
        public string TCAverage { get; set; }
        public string ControlLot { get; set; }
        public string Positive35 { get; set; }
        public string NonTarget35 { get; set; }
        public string Negative35 { get; set; }
        public string Bath1Positive44_5 { get; set; }
        public string Bath2Positive44_5 { get; set; }
        public string Bath3Positive44_5 { get; set; }
        public string Bath1NonTarget44_5 { get; set; }
        public string Bath2NonTarget44_5 { get; set; }
        public string Bath3NonTarget44_5 { get; set; }
        public string Bath1Negative44_5 { get; set; }
        public string Bath2Negative44_5 { get; set; }
        public string Bath3Negative44_5 { get; set; }
        public string Blank35 { get; set; }
        public string Bath1Blank44_5 { get; set; }
        public string Bath2Blank44_5 { get; set; }
        public string Bath3Blank44_5 { get; set; }
        public string Lot35 { get; set; }
        public string Lot44_5 { get; set; }
        public string RunComment { get; set; }
        public string RunWeatherComment { get; set; }
        public string SampleBottleLotNumber { get; set; }
        public string SalinitiesReadBy { get; set; }
        public string SalinitiesReadYear { get; set; }
        public string SalinitiesReadMonth { get; set; }
        public string SalinitiesReadDay { get; set; }
        public string ResultsReadBy { get; set; }
        public string ResultsReadYear { get; set; }
        public string ResultsReadMonth { get; set; }
        public string ResultsReadDay { get; set; }
        public string ResultsRecordedBy { get; set; }
        public string ResultsRecordedYear { get; set; }
        public string ResultsRecordedMonth { get; set; }
        public string ResultsRecordedDay { get; set; }
        public string DailyDuplicateRLog { get; set; }
        public string DailyDuplicatePrecisionCriteria { get; set; }
        public string DailyDuplicateAcceptableOrUnacceptable { get; set; }
        public string IntertechDuplicateRLog { get; set; }
        public string IntertechDuplicatePrecisionCriteria { get; set; }
        public string IntertechDuplicateAcceptableOrUnacceptable { get; set; }
        public string IntertechReadAcceptableOrUnacceptable { get; set; }
        public string ApprovalYear { get; set; }
        public string ApprovalMonth { get; set; }
        public string ApprovalDay { get; set; }
        public string ApprovedBySupervisorInitials { get; set; }
        public bool IncludeLaboratoryQAQC { get; set; }
        public string Log { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "SamplingPlanTypeEnum", EnumType = "SamplingPlanType")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(100)]
        [CSSPEnumTypeText(EnumTypeName = "SamplingPlanTypeEnum", EnumType = "SamplingPlanType")]
        [CSSPAllowNull]
        public string SamplingPlanTypeText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "SampleTypeEnum", EnumType = "SampleType")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(100)]
        [CSSPEnumTypeText(EnumTypeName = "SampleTypeEnum", EnumType = "SampleType")]
        [CSSPAllowNull]
        public string SampleTypeText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "LabSheetTypeEnum", EnumType = "LabSheetType")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(100)]
        [CSSPEnumTypeText(EnumTypeName = "LabSheetTypeEnum", EnumType = "LabSheetType")]
        [CSSPAllowNull]
        public string LabSheetTypeText { get; set; }
        public List<LabSheetA1Measurement> LabSheetA1MeasurementList { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public LabSheetA1Sheet() : base()
        {
            LabSheetA1MeasurementList = new List<LabSheetA1Measurement>();
        }
        #endregion Constructors
    }
}
