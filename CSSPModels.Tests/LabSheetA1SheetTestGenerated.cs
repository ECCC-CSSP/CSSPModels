using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Globalization;
using System.Transactions;
using System.Collections.Generic;
using CSSPModels.Resources;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;

namespace CSSPModels.Tests
{
    public partial class LabSheetA1SheetTest
    {
        [TestMethod]
        public void LabSheetA1Sheet_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "Error", "Version", "SamplingPlanType", "SampleType", "LabSheetType", "SubsectorName", "SubsectorLocation", "SubsectorTVItemID", "RunYear", "RunMonth", "RunDay", "RunNumber", "Tides", "SampleCrewInitials", "IncubationStartSameDay", "WaterBathCount", "IncubationBath1StartTime", "IncubationBath2StartTime", "IncubationBath3StartTime", "IncubationBath1EndTime", "IncubationBath2EndTime", "IncubationBath3EndTime", "IncubationBath1TimeCalculated", "IncubationBath2TimeCalculated", "IncubationBath3TimeCalculated", "WaterBath1", "WaterBath2", "WaterBath3", "TCField1", "TCLab1", "TCHas2Coolers", "TCField2", "TCLab2", "TCFirst", "TCAverage", "ControlLot", "Positive35", "NonTarget35", "Negative35", "Bath1Positive44_5", "Bath2Positive44_5", "Bath3Positive44_5", "Bath1NonTarget44_5", "Bath2NonTarget44_5", "Bath3NonTarget44_5", "Bath1Negative44_5", "Bath2Negative44_5", "Bath3Negative44_5", "Blank35", "Bath1Blank44_5", "Bath2Blank44_5", "Bath3Blank44_5", "Lot35", "Lot44_5", "RunComment", "RunWeatherComment", "SampleBottleLotNumber", "SalinitiesReadBy", "SalinitiesReadYear", "SalinitiesReadMonth", "SalinitiesReadDay", "ResultsReadBy", "ResultsReadYear", "ResultsReadMonth", "ResultsReadDay", "ResultsRecordedBy", "ResultsRecordedYear", "ResultsRecordedMonth", "ResultsRecordedDay", "DailyDuplicateRLog", "DailyDuplicatePrecisionCriteria", "DailyDuplicateAcceptableOrUnacceptable", "IntertechDuplicateRLog", "IntertechDuplicatePrecisionCriteria", "IntertechDuplicateAcceptableOrUnacceptable", "IntertechReadAcceptableOrUnacceptable", "ApprovalYear", "ApprovalMonth", "ApprovalDay", "ApprovedBySupervisorInitials", "IncludeLaboratoryQAQC", "Log", "LabSheetA1MeasurementList",  }.OrderBy(c => c).ToList();
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
        public void LabSheetA1Sheet_Has_ValidationResults_OK()
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
               Assert.IsNotNull(ModelsRes.LabSheetA1SheetLabSheetA1MeasurementList);
        }
    }
}
