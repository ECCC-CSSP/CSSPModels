using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Globalization;
using System.Transactions;
using System.Collections.Generic;
using CSSPModels.Resources;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;
using CSSPEnums;
using System.ComponentModel.DataAnnotations;

namespace CSSPModels.Tests
{
    public partial class LabSheetA1SheetTest : SetupData
    {
        [TestMethod]
        public void LabSheetA1Sheet_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Error", "Version", "SamplingPlanType", "SampleType", "LabSheetType", "SubsectorName", "SubsectorLocation", "SubsectorTVItemID", "RunYear", "RunMonth", "RunDay", "RunNumber", "Tides", "SampleCrewInitials", "IncubationStartSameDay", "WaterBathCount", "IncubationBath1StartTime", "IncubationBath2StartTime", "IncubationBath3StartTime", "IncubationBath1EndTime", "IncubationBath2EndTime", "IncubationBath3EndTime", "IncubationBath1TimeCalculated", "IncubationBath2TimeCalculated", "IncubationBath3TimeCalculated", "WaterBath1", "WaterBath2", "WaterBath3", "TCField1", "TCLab1", "TCHas2Coolers", "TCField2", "TCLab2", "TCFirst", "TCAverage", "ControlLot", "Positive35", "NonTarget35", "Negative35", "Bath1Positive44_5", "Bath2Positive44_5", "Bath3Positive44_5", "Bath1NonTarget44_5", "Bath2NonTarget44_5", "Bath3NonTarget44_5", "Bath1Negative44_5", "Bath2Negative44_5", "Bath3Negative44_5", "Blank35", "Bath1Blank44_5", "Bath2Blank44_5", "Bath3Blank44_5", "Lot35", "Lot44_5", "RunComment", "RunWeatherComment", "SampleBottleLotNumber", "SalinitiesReadBy", "SalinitiesReadYear", "SalinitiesReadMonth", "SalinitiesReadDay", "ResultsReadBy", "ResultsReadYear", "ResultsReadMonth", "ResultsReadDay", "ResultsRecordedBy", "ResultsRecordedYear", "ResultsRecordedMonth", "ResultsRecordedDay", "DailyDuplicateRLog", "DailyDuplicatePrecisionCriteria", "DailyDuplicateAcceptableOrUnacceptable", "IntertechDuplicateRLog", "IntertechDuplicatePrecisionCriteria", "IntertechDuplicateAcceptableOrUnacceptable", "IntertechReadAcceptableOrUnacceptable", "ApprovalYear", "ApprovalMonth", "ApprovalDay", "ApprovedBySupervisorInitials", "IncludeLaboratoryQAQC", "Log", "SamplingPlanTypeText", "SampleTypeText", "LabSheetTypeText", "LabSheetA1MeasurementList",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetA1Sheet).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void LabSheetA1Sheet_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(LabSheetA1Sheet).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void LabSheetA1Sheet_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetError);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetVersion);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetSamplingPlanType);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetSampleType);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetLabSheetType);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetSubsectorName);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetSubsectorLocation);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetSubsectorTVItemID);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetRunYear);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetRunMonth);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetRunDay);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetRunNumber);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetTides);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetSampleCrewInitials);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetIncubationStartSameDay);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetWaterBathCount);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetIncubationBath1StartTime);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetIncubationBath2StartTime);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetIncubationBath3StartTime);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetIncubationBath1EndTime);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetIncubationBath2EndTime);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetIncubationBath3EndTime);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetIncubationBath1TimeCalculated);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetIncubationBath2TimeCalculated);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetIncubationBath3TimeCalculated);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetWaterBath1);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetWaterBath2);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetWaterBath3);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetTCField1);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetTCLab1);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetTCHas2Coolers);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetTCField2);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetTCLab2);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetTCFirst);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetTCAverage);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetControlLot);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetPositive35);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetNonTarget35);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetNegative35);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetBath1Positive44_5);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetBath2Positive44_5);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetBath3Positive44_5);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetBath1NonTarget44_5);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetBath2NonTarget44_5);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetBath3NonTarget44_5);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetBath1Negative44_5);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetBath2Negative44_5);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetBath3Negative44_5);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetBlank35);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetBath1Blank44_5);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetBath2Blank44_5);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetBath3Blank44_5);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetLot35);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetLot44_5);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetRunComment);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetRunWeatherComment);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetSampleBottleLotNumber);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetSalinitiesReadBy);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetSalinitiesReadYear);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetSalinitiesReadMonth);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetSalinitiesReadDay);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetResultsReadBy);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetResultsReadYear);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetResultsReadMonth);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetResultsReadDay);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetResultsRecordedBy);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetResultsRecordedYear);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetResultsRecordedMonth);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetResultsRecordedDay);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetDailyDuplicateRLog);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetDailyDuplicatePrecisionCriteria);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetDailyDuplicateAcceptableOrUnacceptable);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetIntertechDuplicateRLog);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetIntertechDuplicatePrecisionCriteria);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetIntertechDuplicateAcceptableOrUnacceptable);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetIntertechReadAcceptableOrUnacceptable);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetApprovalYear);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetApprovalMonth);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetApprovalDay);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetApprovedBySupervisorInitials);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetIncludeLaboratoryQAQC);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetLog);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetSamplingPlanTypeText);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetSampleTypeText);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetLabSheetTypeText);
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetLabSheetA1MeasurementList);
        }
        [TestMethod]
        public void LabSheetA1Sheet_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               labSheetA1Sheet.Error = val1;
               Assert.AreEqual(val1, labSheetA1Sheet.Error);
               int val2 = 45;
               labSheetA1Sheet.Version = val2;
               Assert.AreEqual(val2, labSheetA1Sheet.Version);
               SamplingPlanTypeEnum val3 = (SamplingPlanTypeEnum)3;
               labSheetA1Sheet.SamplingPlanType = val3;
               Assert.AreEqual(val3, labSheetA1Sheet.SamplingPlanType);
               SampleTypeEnum val4 = (SampleTypeEnum)3;
               labSheetA1Sheet.SampleType = val4;
               Assert.AreEqual(val4, labSheetA1Sheet.SampleType);
               LabSheetTypeEnum val5 = (LabSheetTypeEnum)3;
               labSheetA1Sheet.LabSheetType = val5;
               Assert.AreEqual(val5, labSheetA1Sheet.LabSheetType);
               string val6 = "Some text";
               labSheetA1Sheet.SubsectorName = val6;
               Assert.AreEqual(val6, labSheetA1Sheet.SubsectorName);
               string val7 = "Some text";
               labSheetA1Sheet.SubsectorLocation = val7;
               Assert.AreEqual(val7, labSheetA1Sheet.SubsectorLocation);
               int val8 = 45;
               labSheetA1Sheet.SubsectorTVItemID = val8;
               Assert.AreEqual(val8, labSheetA1Sheet.SubsectorTVItemID);
               string val9 = "Some text";
               labSheetA1Sheet.RunYear = val9;
               Assert.AreEqual(val9, labSheetA1Sheet.RunYear);
               string val10 = "Some text";
               labSheetA1Sheet.RunMonth = val10;
               Assert.AreEqual(val10, labSheetA1Sheet.RunMonth);
               string val11 = "Some text";
               labSheetA1Sheet.RunDay = val11;
               Assert.AreEqual(val11, labSheetA1Sheet.RunDay);
               int val12 = 45;
               labSheetA1Sheet.RunNumber = val12;
               Assert.AreEqual(val12, labSheetA1Sheet.RunNumber);
               string val13 = "Some text";
               labSheetA1Sheet.Tides = val13;
               Assert.AreEqual(val13, labSheetA1Sheet.Tides);
               string val14 = "Some text";
               labSheetA1Sheet.SampleCrewInitials = val14;
               Assert.AreEqual(val14, labSheetA1Sheet.SampleCrewInitials);
               string val15 = "Some text";
               labSheetA1Sheet.IncubationStartSameDay = val15;
               Assert.AreEqual(val15, labSheetA1Sheet.IncubationStartSameDay);
               int val16 = 45;
               labSheetA1Sheet.WaterBathCount = val16;
               Assert.AreEqual(val16, labSheetA1Sheet.WaterBathCount);
               string val17 = "Some text";
               labSheetA1Sheet.IncubationBath1StartTime = val17;
               Assert.AreEqual(val17, labSheetA1Sheet.IncubationBath1StartTime);
               string val18 = "Some text";
               labSheetA1Sheet.IncubationBath2StartTime = val18;
               Assert.AreEqual(val18, labSheetA1Sheet.IncubationBath2StartTime);
               string val19 = "Some text";
               labSheetA1Sheet.IncubationBath3StartTime = val19;
               Assert.AreEqual(val19, labSheetA1Sheet.IncubationBath3StartTime);
               string val20 = "Some text";
               labSheetA1Sheet.IncubationBath1EndTime = val20;
               Assert.AreEqual(val20, labSheetA1Sheet.IncubationBath1EndTime);
               string val21 = "Some text";
               labSheetA1Sheet.IncubationBath2EndTime = val21;
               Assert.AreEqual(val21, labSheetA1Sheet.IncubationBath2EndTime);
               string val22 = "Some text";
               labSheetA1Sheet.IncubationBath3EndTime = val22;
               Assert.AreEqual(val22, labSheetA1Sheet.IncubationBath3EndTime);
               string val23 = "Some text";
               labSheetA1Sheet.IncubationBath1TimeCalculated = val23;
               Assert.AreEqual(val23, labSheetA1Sheet.IncubationBath1TimeCalculated);
               string val24 = "Some text";
               labSheetA1Sheet.IncubationBath2TimeCalculated = val24;
               Assert.AreEqual(val24, labSheetA1Sheet.IncubationBath2TimeCalculated);
               string val25 = "Some text";
               labSheetA1Sheet.IncubationBath3TimeCalculated = val25;
               Assert.AreEqual(val25, labSheetA1Sheet.IncubationBath3TimeCalculated);
               string val26 = "Some text";
               labSheetA1Sheet.WaterBath1 = val26;
               Assert.AreEqual(val26, labSheetA1Sheet.WaterBath1);
               string val27 = "Some text";
               labSheetA1Sheet.WaterBath2 = val27;
               Assert.AreEqual(val27, labSheetA1Sheet.WaterBath2);
               string val28 = "Some text";
               labSheetA1Sheet.WaterBath3 = val28;
               Assert.AreEqual(val28, labSheetA1Sheet.WaterBath3);
               string val29 = "Some text";
               labSheetA1Sheet.TCField1 = val29;
               Assert.AreEqual(val29, labSheetA1Sheet.TCField1);
               string val30 = "Some text";
               labSheetA1Sheet.TCLab1 = val30;
               Assert.AreEqual(val30, labSheetA1Sheet.TCLab1);
               string val31 = "Some text";
               labSheetA1Sheet.TCHas2Coolers = val31;
               Assert.AreEqual(val31, labSheetA1Sheet.TCHas2Coolers);
               string val32 = "Some text";
               labSheetA1Sheet.TCField2 = val32;
               Assert.AreEqual(val32, labSheetA1Sheet.TCField2);
               string val33 = "Some text";
               labSheetA1Sheet.TCLab2 = val33;
               Assert.AreEqual(val33, labSheetA1Sheet.TCLab2);
               string val34 = "Some text";
               labSheetA1Sheet.TCFirst = val34;
               Assert.AreEqual(val34, labSheetA1Sheet.TCFirst);
               string val35 = "Some text";
               labSheetA1Sheet.TCAverage = val35;
               Assert.AreEqual(val35, labSheetA1Sheet.TCAverage);
               string val36 = "Some text";
               labSheetA1Sheet.ControlLot = val36;
               Assert.AreEqual(val36, labSheetA1Sheet.ControlLot);
               string val37 = "Some text";
               labSheetA1Sheet.Positive35 = val37;
               Assert.AreEqual(val37, labSheetA1Sheet.Positive35);
               string val38 = "Some text";
               labSheetA1Sheet.NonTarget35 = val38;
               Assert.AreEqual(val38, labSheetA1Sheet.NonTarget35);
               string val39 = "Some text";
               labSheetA1Sheet.Negative35 = val39;
               Assert.AreEqual(val39, labSheetA1Sheet.Negative35);
               string val40 = "Some text";
               labSheetA1Sheet.Bath1Positive44_5 = val40;
               Assert.AreEqual(val40, labSheetA1Sheet.Bath1Positive44_5);
               string val41 = "Some text";
               labSheetA1Sheet.Bath2Positive44_5 = val41;
               Assert.AreEqual(val41, labSheetA1Sheet.Bath2Positive44_5);
               string val42 = "Some text";
               labSheetA1Sheet.Bath3Positive44_5 = val42;
               Assert.AreEqual(val42, labSheetA1Sheet.Bath3Positive44_5);
               string val43 = "Some text";
               labSheetA1Sheet.Bath1NonTarget44_5 = val43;
               Assert.AreEqual(val43, labSheetA1Sheet.Bath1NonTarget44_5);
               string val44 = "Some text";
               labSheetA1Sheet.Bath2NonTarget44_5 = val44;
               Assert.AreEqual(val44, labSheetA1Sheet.Bath2NonTarget44_5);
               string val45 = "Some text";
               labSheetA1Sheet.Bath3NonTarget44_5 = val45;
               Assert.AreEqual(val45, labSheetA1Sheet.Bath3NonTarget44_5);
               string val46 = "Some text";
               labSheetA1Sheet.Bath1Negative44_5 = val46;
               Assert.AreEqual(val46, labSheetA1Sheet.Bath1Negative44_5);
               string val47 = "Some text";
               labSheetA1Sheet.Bath2Negative44_5 = val47;
               Assert.AreEqual(val47, labSheetA1Sheet.Bath2Negative44_5);
               string val48 = "Some text";
               labSheetA1Sheet.Bath3Negative44_5 = val48;
               Assert.AreEqual(val48, labSheetA1Sheet.Bath3Negative44_5);
               string val49 = "Some text";
               labSheetA1Sheet.Blank35 = val49;
               Assert.AreEqual(val49, labSheetA1Sheet.Blank35);
               string val50 = "Some text";
               labSheetA1Sheet.Bath1Blank44_5 = val50;
               Assert.AreEqual(val50, labSheetA1Sheet.Bath1Blank44_5);
               string val51 = "Some text";
               labSheetA1Sheet.Bath2Blank44_5 = val51;
               Assert.AreEqual(val51, labSheetA1Sheet.Bath2Blank44_5);
               string val52 = "Some text";
               labSheetA1Sheet.Bath3Blank44_5 = val52;
               Assert.AreEqual(val52, labSheetA1Sheet.Bath3Blank44_5);
               string val53 = "Some text";
               labSheetA1Sheet.Lot35 = val53;
               Assert.AreEqual(val53, labSheetA1Sheet.Lot35);
               string val54 = "Some text";
               labSheetA1Sheet.Lot44_5 = val54;
               Assert.AreEqual(val54, labSheetA1Sheet.Lot44_5);
               string val55 = "Some text";
               labSheetA1Sheet.RunComment = val55;
               Assert.AreEqual(val55, labSheetA1Sheet.RunComment);
               string val56 = "Some text";
               labSheetA1Sheet.RunWeatherComment = val56;
               Assert.AreEqual(val56, labSheetA1Sheet.RunWeatherComment);
               string val57 = "Some text";
               labSheetA1Sheet.SampleBottleLotNumber = val57;
               Assert.AreEqual(val57, labSheetA1Sheet.SampleBottleLotNumber);
               string val58 = "Some text";
               labSheetA1Sheet.SalinitiesReadBy = val58;
               Assert.AreEqual(val58, labSheetA1Sheet.SalinitiesReadBy);
               string val59 = "Some text";
               labSheetA1Sheet.SalinitiesReadYear = val59;
               Assert.AreEqual(val59, labSheetA1Sheet.SalinitiesReadYear);
               string val60 = "Some text";
               labSheetA1Sheet.SalinitiesReadMonth = val60;
               Assert.AreEqual(val60, labSheetA1Sheet.SalinitiesReadMonth);
               string val61 = "Some text";
               labSheetA1Sheet.SalinitiesReadDay = val61;
               Assert.AreEqual(val61, labSheetA1Sheet.SalinitiesReadDay);
               string val62 = "Some text";
               labSheetA1Sheet.ResultsReadBy = val62;
               Assert.AreEqual(val62, labSheetA1Sheet.ResultsReadBy);
               string val63 = "Some text";
               labSheetA1Sheet.ResultsReadYear = val63;
               Assert.AreEqual(val63, labSheetA1Sheet.ResultsReadYear);
               string val64 = "Some text";
               labSheetA1Sheet.ResultsReadMonth = val64;
               Assert.AreEqual(val64, labSheetA1Sheet.ResultsReadMonth);
               string val65 = "Some text";
               labSheetA1Sheet.ResultsReadDay = val65;
               Assert.AreEqual(val65, labSheetA1Sheet.ResultsReadDay);
               string val66 = "Some text";
               labSheetA1Sheet.ResultsRecordedBy = val66;
               Assert.AreEqual(val66, labSheetA1Sheet.ResultsRecordedBy);
               string val67 = "Some text";
               labSheetA1Sheet.ResultsRecordedYear = val67;
               Assert.AreEqual(val67, labSheetA1Sheet.ResultsRecordedYear);
               string val68 = "Some text";
               labSheetA1Sheet.ResultsRecordedMonth = val68;
               Assert.AreEqual(val68, labSheetA1Sheet.ResultsRecordedMonth);
               string val69 = "Some text";
               labSheetA1Sheet.ResultsRecordedDay = val69;
               Assert.AreEqual(val69, labSheetA1Sheet.ResultsRecordedDay);
               string val70 = "Some text";
               labSheetA1Sheet.DailyDuplicateRLog = val70;
               Assert.AreEqual(val70, labSheetA1Sheet.DailyDuplicateRLog);
               string val71 = "Some text";
               labSheetA1Sheet.DailyDuplicatePrecisionCriteria = val71;
               Assert.AreEqual(val71, labSheetA1Sheet.DailyDuplicatePrecisionCriteria);
               string val72 = "Some text";
               labSheetA1Sheet.DailyDuplicateAcceptableOrUnacceptable = val72;
               Assert.AreEqual(val72, labSheetA1Sheet.DailyDuplicateAcceptableOrUnacceptable);
               string val73 = "Some text";
               labSheetA1Sheet.IntertechDuplicateRLog = val73;
               Assert.AreEqual(val73, labSheetA1Sheet.IntertechDuplicateRLog);
               string val74 = "Some text";
               labSheetA1Sheet.IntertechDuplicatePrecisionCriteria = val74;
               Assert.AreEqual(val74, labSheetA1Sheet.IntertechDuplicatePrecisionCriteria);
               string val75 = "Some text";
               labSheetA1Sheet.IntertechDuplicateAcceptableOrUnacceptable = val75;
               Assert.AreEqual(val75, labSheetA1Sheet.IntertechDuplicateAcceptableOrUnacceptable);
               string val76 = "Some text";
               labSheetA1Sheet.IntertechReadAcceptableOrUnacceptable = val76;
               Assert.AreEqual(val76, labSheetA1Sheet.IntertechReadAcceptableOrUnacceptable);
               string val77 = "Some text";
               labSheetA1Sheet.ApprovalYear = val77;
               Assert.AreEqual(val77, labSheetA1Sheet.ApprovalYear);
               string val78 = "Some text";
               labSheetA1Sheet.ApprovalMonth = val78;
               Assert.AreEqual(val78, labSheetA1Sheet.ApprovalMonth);
               string val79 = "Some text";
               labSheetA1Sheet.ApprovalDay = val79;
               Assert.AreEqual(val79, labSheetA1Sheet.ApprovalDay);
               string val80 = "Some text";
               labSheetA1Sheet.ApprovedBySupervisorInitials = val80;
               Assert.AreEqual(val80, labSheetA1Sheet.ApprovedBySupervisorInitials);
               bool val81 = true;
               labSheetA1Sheet.IncludeLaboratoryQAQC = val81;
               Assert.AreEqual(val81, labSheetA1Sheet.IncludeLaboratoryQAQC);
               string val82 = "Some text";
               labSheetA1Sheet.Log = val82;
               Assert.AreEqual(val82, labSheetA1Sheet.Log);
               string val83 = "Some text";
               labSheetA1Sheet.SamplingPlanTypeText = val83;
               Assert.AreEqual(val83, labSheetA1Sheet.SamplingPlanTypeText);
               string val84 = "Some text";
               labSheetA1Sheet.SampleTypeText = val84;
               Assert.AreEqual(val84, labSheetA1Sheet.SampleTypeText);
               string val85 = "Some text";
               labSheetA1Sheet.LabSheetTypeText = val85;
               Assert.AreEqual(val85, labSheetA1Sheet.LabSheetTypeText);
               List<LabSheetA1Measurement> val173 = new List<LabSheetA1Measurement>();
               labSheetA1Sheet.LabSheetA1MeasurementList = val173;
               Assert.AreEqual(val173, labSheetA1Sheet.LabSheetA1MeasurementList);
               IEnumerable<ValidationResult> val261 = new List<ValidationResult>().AsEnumerable();
               labSheetA1Sheet.ValidationResults = val261;
               Assert.AreEqual(val261, labSheetA1Sheet.ValidationResults);
        }
    }
}
