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
    public partial class LabSheetDetailTest : SetupData
    {
        [TestMethod]
        public void LabSheetDetail_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LabSheetDetailID", "LabSheetID", "SamplingPlanID", "SubsectorTVItemID", "Version", "RunDate", "Tides", "SampleCrewInitials", "WaterBathCount", "IncubationBath1StartTime", "IncubationBath2StartTime", "IncubationBath3StartTime", "IncubationBath1EndTime", "IncubationBath2EndTime", "IncubationBath3EndTime", "IncubationBath1TimeCalculated_minutes", "IncubationBath2TimeCalculated_minutes", "IncubationBath3TimeCalculated_minutes", "WaterBath1", "WaterBath2", "WaterBath3", "TCField1", "TCLab1", "TCField2", "TCLab2", "TCFirst", "TCAverage", "ControlLot", "Positive35", "NonTarget35", "Negative35", "Bath1Positive44_5", "Bath2Positive44_5", "Bath3Positive44_5", "Bath1NonTarget44_5", "Bath2NonTarget44_5", "Bath3NonTarget44_5", "Bath1Negative44_5", "Bath2Negative44_5", "Bath3Negative44_5", "Blank35", "Bath1Blank44_5", "Bath2Blank44_5", "Bath3Blank44_5", "Lot35", "Lot44_5", "Weather", "RunComment", "RunWeatherComment", "SampleBottleLotNumber", "SalinitiesReadBy", "SalinitiesReadDate", "ResultsReadBy", "ResultsReadDate", "ResultsRecordedBy", "ResultsRecordedDate", "DailyDuplicateRLog", "DailyDuplicatePrecisionCriteria", "DailyDuplicateAcceptable", "IntertechDuplicateRLog", "IntertechDuplicatePrecisionCriteria", "IntertechDuplicateAcceptable", "IntertechReadAcceptable", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "SubsectorTVText", "LastUpdateContactTVText", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.LabSheetDetail).GetProperties().OrderBy(c => c.Name))
            {
                if (!propertyInfo.GetGetMethod().IsVirtual
                    && propertyInfo.Name != "ValidationResults"
                    && !propertyInfo.CustomAttributes.Where(c => c.AttributeType.Name.Contains("NotMappedAttribute")).Any())
                {
                    Assert.AreEqual(propNameList[index], propertyInfo.Name);
                    index += 1;
                }
            }

            Assert.AreEqual(propNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetDetail).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                foreach (CustomAttributeData customAttributeData in propertyInfo.CustomAttributes)
                {
                    if (customAttributeData.AttributeType.Name == "NotMappedAttribute")
                    {
                        Assert.AreEqual(propertyInfo.Name, propNameNotMappedList[index]);
                        index += 1;
                    }
                }
            }

            Assert.AreEqual(propNameNotMappedList.Count, index);

        }
        [TestMethod]
        public void LabSheetDetail_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetDetail).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetDetail).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                if (propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameCollectionList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameCollectionList.Count, index);

        }
        [TestMethod]
        public void LabSheetDetail_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(LabSheetDetail).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void LabSheetDetail_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.LabSheetDetailLabSheetDetailID);
               Assert.IsNotNull(ModelsRes.LabSheetDetailLabSheetID);
               Assert.IsNotNull(ModelsRes.LabSheetDetailSamplingPlanID);
               Assert.IsNotNull(ModelsRes.LabSheetDetailSubsectorTVItemID);
               Assert.IsNotNull(ModelsRes.LabSheetDetailVersion);
               Assert.IsNotNull(ModelsRes.LabSheetDetailRunDate);
               Assert.IsNotNull(ModelsRes.LabSheetDetailTides);
               Assert.IsNotNull(ModelsRes.LabSheetDetailSampleCrewInitials);
               Assert.IsNotNull(ModelsRes.LabSheetDetailWaterBathCount);
               Assert.IsNotNull(ModelsRes.LabSheetDetailIncubationBath1StartTime);
               Assert.IsNotNull(ModelsRes.LabSheetDetailIncubationBath2StartTime);
               Assert.IsNotNull(ModelsRes.LabSheetDetailIncubationBath3StartTime);
               Assert.IsNotNull(ModelsRes.LabSheetDetailIncubationBath1EndTime);
               Assert.IsNotNull(ModelsRes.LabSheetDetailIncubationBath2EndTime);
               Assert.IsNotNull(ModelsRes.LabSheetDetailIncubationBath3EndTime);
               Assert.IsNotNull(ModelsRes.LabSheetDetailIncubationBath1TimeCalculated_minutes);
               Assert.IsNotNull(ModelsRes.LabSheetDetailIncubationBath2TimeCalculated_minutes);
               Assert.IsNotNull(ModelsRes.LabSheetDetailIncubationBath3TimeCalculated_minutes);
               Assert.IsNotNull(ModelsRes.LabSheetDetailWaterBath1);
               Assert.IsNotNull(ModelsRes.LabSheetDetailWaterBath2);
               Assert.IsNotNull(ModelsRes.LabSheetDetailWaterBath3);
               Assert.IsNotNull(ModelsRes.LabSheetDetailTCField1);
               Assert.IsNotNull(ModelsRes.LabSheetDetailTCLab1);
               Assert.IsNotNull(ModelsRes.LabSheetDetailTCField2);
               Assert.IsNotNull(ModelsRes.LabSheetDetailTCLab2);
               Assert.IsNotNull(ModelsRes.LabSheetDetailTCFirst);
               Assert.IsNotNull(ModelsRes.LabSheetDetailTCAverage);
               Assert.IsNotNull(ModelsRes.LabSheetDetailControlLot);
               Assert.IsNotNull(ModelsRes.LabSheetDetailPositive35);
               Assert.IsNotNull(ModelsRes.LabSheetDetailNonTarget35);
               Assert.IsNotNull(ModelsRes.LabSheetDetailNegative35);
               Assert.IsNotNull(ModelsRes.LabSheetDetailBath1Positive44_5);
               Assert.IsNotNull(ModelsRes.LabSheetDetailBath2Positive44_5);
               Assert.IsNotNull(ModelsRes.LabSheetDetailBath3Positive44_5);
               Assert.IsNotNull(ModelsRes.LabSheetDetailBath1NonTarget44_5);
               Assert.IsNotNull(ModelsRes.LabSheetDetailBath2NonTarget44_5);
               Assert.IsNotNull(ModelsRes.LabSheetDetailBath3NonTarget44_5);
               Assert.IsNotNull(ModelsRes.LabSheetDetailBath1Negative44_5);
               Assert.IsNotNull(ModelsRes.LabSheetDetailBath2Negative44_5);
               Assert.IsNotNull(ModelsRes.LabSheetDetailBath3Negative44_5);
               Assert.IsNotNull(ModelsRes.LabSheetDetailBlank35);
               Assert.IsNotNull(ModelsRes.LabSheetDetailBath1Blank44_5);
               Assert.IsNotNull(ModelsRes.LabSheetDetailBath2Blank44_5);
               Assert.IsNotNull(ModelsRes.LabSheetDetailBath3Blank44_5);
               Assert.IsNotNull(ModelsRes.LabSheetDetailLot35);
               Assert.IsNotNull(ModelsRes.LabSheetDetailLot44_5);
               Assert.IsNotNull(ModelsRes.LabSheetDetailWeather);
               Assert.IsNotNull(ModelsRes.LabSheetDetailRunComment);
               Assert.IsNotNull(ModelsRes.LabSheetDetailRunWeatherComment);
               Assert.IsNotNull(ModelsRes.LabSheetDetailSampleBottleLotNumber);
               Assert.IsNotNull(ModelsRes.LabSheetDetailSalinitiesReadBy);
               Assert.IsNotNull(ModelsRes.LabSheetDetailSalinitiesReadDate);
               Assert.IsNotNull(ModelsRes.LabSheetDetailResultsReadBy);
               Assert.IsNotNull(ModelsRes.LabSheetDetailResultsReadDate);
               Assert.IsNotNull(ModelsRes.LabSheetDetailResultsRecordedBy);
               Assert.IsNotNull(ModelsRes.LabSheetDetailResultsRecordedDate);
               Assert.IsNotNull(ModelsRes.LabSheetDetailDailyDuplicateRLog);
               Assert.IsNotNull(ModelsRes.LabSheetDetailDailyDuplicatePrecisionCriteria);
               Assert.IsNotNull(ModelsRes.LabSheetDetailDailyDuplicateAcceptable);
               Assert.IsNotNull(ModelsRes.LabSheetDetailIntertechDuplicateRLog);
               Assert.IsNotNull(ModelsRes.LabSheetDetailIntertechDuplicatePrecisionCriteria);
               Assert.IsNotNull(ModelsRes.LabSheetDetailIntertechDuplicateAcceptable);
               Assert.IsNotNull(ModelsRes.LabSheetDetailIntertechReadAcceptable);
               Assert.IsNotNull(ModelsRes.LabSheetDetailLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.LabSheetDetailLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.LabSheetDetailSubsectorTVText);
               Assert.IsNotNull(ModelsRes.LabSheetDetailLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.LabSheetDetailHasErrors);
        }
        [TestMethod]
        public void LabSheetDetail_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               labSheetDetail.LabSheetDetailID = val1;
               Assert.AreEqual(val1, labSheetDetail.LabSheetDetailID);
               int val2 = 45;
               labSheetDetail.LabSheetID = val2;
               Assert.AreEqual(val2, labSheetDetail.LabSheetID);
               int val3 = 45;
               labSheetDetail.SamplingPlanID = val3;
               Assert.AreEqual(val3, labSheetDetail.SamplingPlanID);
               int val4 = 45;
               labSheetDetail.SubsectorTVItemID = val4;
               Assert.AreEqual(val4, labSheetDetail.SubsectorTVItemID);
               int val5 = 45;
               labSheetDetail.Version = val5;
               Assert.AreEqual(val5, labSheetDetail.Version);
               DateTime val6 = new DateTime(2010, 3, 4);
               labSheetDetail.RunDate = val6;
               Assert.AreEqual(val6, labSheetDetail.RunDate);
               string val7 = "Some text";
               labSheetDetail.Tides = val7;
               Assert.AreEqual(val7, labSheetDetail.Tides);
               string val8 = "Some text";
               labSheetDetail.SampleCrewInitials = val8;
               Assert.AreEqual(val8, labSheetDetail.SampleCrewInitials);
               int val9 = 45;
               labSheetDetail.WaterBathCount = val9;
               Assert.AreEqual(val9, labSheetDetail.WaterBathCount);
               DateTime val10 = new DateTime(2010, 3, 4);
               labSheetDetail.IncubationBath1StartTime = val10;
               Assert.AreEqual(val10, labSheetDetail.IncubationBath1StartTime);
               DateTime val11 = new DateTime(2010, 3, 4);
               labSheetDetail.IncubationBath2StartTime = val11;
               Assert.AreEqual(val11, labSheetDetail.IncubationBath2StartTime);
               DateTime val12 = new DateTime(2010, 3, 4);
               labSheetDetail.IncubationBath3StartTime = val12;
               Assert.AreEqual(val12, labSheetDetail.IncubationBath3StartTime);
               DateTime val13 = new DateTime(2010, 3, 4);
               labSheetDetail.IncubationBath1EndTime = val13;
               Assert.AreEqual(val13, labSheetDetail.IncubationBath1EndTime);
               DateTime val14 = new DateTime(2010, 3, 4);
               labSheetDetail.IncubationBath2EndTime = val14;
               Assert.AreEqual(val14, labSheetDetail.IncubationBath2EndTime);
               DateTime val15 = new DateTime(2010, 3, 4);
               labSheetDetail.IncubationBath3EndTime = val15;
               Assert.AreEqual(val15, labSheetDetail.IncubationBath3EndTime);
               int val16 = 45;
               labSheetDetail.IncubationBath1TimeCalculated_minutes = val16;
               Assert.AreEqual(val16, labSheetDetail.IncubationBath1TimeCalculated_minutes);
               int val17 = 45;
               labSheetDetail.IncubationBath2TimeCalculated_minutes = val17;
               Assert.AreEqual(val17, labSheetDetail.IncubationBath2TimeCalculated_minutes);
               int val18 = 45;
               labSheetDetail.IncubationBath3TimeCalculated_minutes = val18;
               Assert.AreEqual(val18, labSheetDetail.IncubationBath3TimeCalculated_minutes);
               string val19 = "Some text";
               labSheetDetail.WaterBath1 = val19;
               Assert.AreEqual(val19, labSheetDetail.WaterBath1);
               string val20 = "Some text";
               labSheetDetail.WaterBath2 = val20;
               Assert.AreEqual(val20, labSheetDetail.WaterBath2);
               string val21 = "Some text";
               labSheetDetail.WaterBath3 = val21;
               Assert.AreEqual(val21, labSheetDetail.WaterBath3);
               double val22 = 87.9D;
               labSheetDetail.TCField1 = val22;
               Assert.AreEqual(val22, labSheetDetail.TCField1);
               double val23 = 87.9D;
               labSheetDetail.TCLab1 = val23;
               Assert.AreEqual(val23, labSheetDetail.TCLab1);
               double val24 = 87.9D;
               labSheetDetail.TCField2 = val24;
               Assert.AreEqual(val24, labSheetDetail.TCField2);
               double val25 = 87.9D;
               labSheetDetail.TCLab2 = val25;
               Assert.AreEqual(val25, labSheetDetail.TCLab2);
               double val26 = 87.9D;
               labSheetDetail.TCFirst = val26;
               Assert.AreEqual(val26, labSheetDetail.TCFirst);
               double val27 = 87.9D;
               labSheetDetail.TCAverage = val27;
               Assert.AreEqual(val27, labSheetDetail.TCAverage);
               string val28 = "Some text";
               labSheetDetail.ControlLot = val28;
               Assert.AreEqual(val28, labSheetDetail.ControlLot);
               string val29 = "Some text";
               labSheetDetail.Positive35 = val29;
               Assert.AreEqual(val29, labSheetDetail.Positive35);
               string val30 = "Some text";
               labSheetDetail.NonTarget35 = val30;
               Assert.AreEqual(val30, labSheetDetail.NonTarget35);
               string val31 = "Some text";
               labSheetDetail.Negative35 = val31;
               Assert.AreEqual(val31, labSheetDetail.Negative35);
               string val32 = "Some text";
               labSheetDetail.Bath1Positive44_5 = val32;
               Assert.AreEqual(val32, labSheetDetail.Bath1Positive44_5);
               string val33 = "Some text";
               labSheetDetail.Bath2Positive44_5 = val33;
               Assert.AreEqual(val33, labSheetDetail.Bath2Positive44_5);
               string val34 = "Some text";
               labSheetDetail.Bath3Positive44_5 = val34;
               Assert.AreEqual(val34, labSheetDetail.Bath3Positive44_5);
               string val35 = "Some text";
               labSheetDetail.Bath1NonTarget44_5 = val35;
               Assert.AreEqual(val35, labSheetDetail.Bath1NonTarget44_5);
               string val36 = "Some text";
               labSheetDetail.Bath2NonTarget44_5 = val36;
               Assert.AreEqual(val36, labSheetDetail.Bath2NonTarget44_5);
               string val37 = "Some text";
               labSheetDetail.Bath3NonTarget44_5 = val37;
               Assert.AreEqual(val37, labSheetDetail.Bath3NonTarget44_5);
               string val38 = "Some text";
               labSheetDetail.Bath1Negative44_5 = val38;
               Assert.AreEqual(val38, labSheetDetail.Bath1Negative44_5);
               string val39 = "Some text";
               labSheetDetail.Bath2Negative44_5 = val39;
               Assert.AreEqual(val39, labSheetDetail.Bath2Negative44_5);
               string val40 = "Some text";
               labSheetDetail.Bath3Negative44_5 = val40;
               Assert.AreEqual(val40, labSheetDetail.Bath3Negative44_5);
               string val41 = "Some text";
               labSheetDetail.Blank35 = val41;
               Assert.AreEqual(val41, labSheetDetail.Blank35);
               string val42 = "Some text";
               labSheetDetail.Bath1Blank44_5 = val42;
               Assert.AreEqual(val42, labSheetDetail.Bath1Blank44_5);
               string val43 = "Some text";
               labSheetDetail.Bath2Blank44_5 = val43;
               Assert.AreEqual(val43, labSheetDetail.Bath2Blank44_5);
               string val44 = "Some text";
               labSheetDetail.Bath3Blank44_5 = val44;
               Assert.AreEqual(val44, labSheetDetail.Bath3Blank44_5);
               string val45 = "Some text";
               labSheetDetail.Lot35 = val45;
               Assert.AreEqual(val45, labSheetDetail.Lot35);
               string val46 = "Some text";
               labSheetDetail.Lot44_5 = val46;
               Assert.AreEqual(val46, labSheetDetail.Lot44_5);
               string val47 = "Some text";
               labSheetDetail.Weather = val47;
               Assert.AreEqual(val47, labSheetDetail.Weather);
               string val48 = "Some text";
               labSheetDetail.RunComment = val48;
               Assert.AreEqual(val48, labSheetDetail.RunComment);
               string val49 = "Some text";
               labSheetDetail.RunWeatherComment = val49;
               Assert.AreEqual(val49, labSheetDetail.RunWeatherComment);
               string val50 = "Some text";
               labSheetDetail.SampleBottleLotNumber = val50;
               Assert.AreEqual(val50, labSheetDetail.SampleBottleLotNumber);
               string val51 = "Some text";
               labSheetDetail.SalinitiesReadBy = val51;
               Assert.AreEqual(val51, labSheetDetail.SalinitiesReadBy);
               DateTime val52 = new DateTime(2010, 3, 4);
               labSheetDetail.SalinitiesReadDate = val52;
               Assert.AreEqual(val52, labSheetDetail.SalinitiesReadDate);
               string val53 = "Some text";
               labSheetDetail.ResultsReadBy = val53;
               Assert.AreEqual(val53, labSheetDetail.ResultsReadBy);
               DateTime val54 = new DateTime(2010, 3, 4);
               labSheetDetail.ResultsReadDate = val54;
               Assert.AreEqual(val54, labSheetDetail.ResultsReadDate);
               string val55 = "Some text";
               labSheetDetail.ResultsRecordedBy = val55;
               Assert.AreEqual(val55, labSheetDetail.ResultsRecordedBy);
               DateTime val56 = new DateTime(2010, 3, 4);
               labSheetDetail.ResultsRecordedDate = val56;
               Assert.AreEqual(val56, labSheetDetail.ResultsRecordedDate);
               double val57 = 87.9D;
               labSheetDetail.DailyDuplicateRLog = val57;
               Assert.AreEqual(val57, labSheetDetail.DailyDuplicateRLog);
               double val58 = 87.9D;
               labSheetDetail.DailyDuplicatePrecisionCriteria = val58;
               Assert.AreEqual(val58, labSheetDetail.DailyDuplicatePrecisionCriteria);
               bool val59 = true;
               labSheetDetail.DailyDuplicateAcceptable = val59;
               Assert.AreEqual(val59, labSheetDetail.DailyDuplicateAcceptable);
               double val60 = 87.9D;
               labSheetDetail.IntertechDuplicateRLog = val60;
               Assert.AreEqual(val60, labSheetDetail.IntertechDuplicateRLog);
               double val61 = 87.9D;
               labSheetDetail.IntertechDuplicatePrecisionCriteria = val61;
               Assert.AreEqual(val61, labSheetDetail.IntertechDuplicatePrecisionCriteria);
               bool val62 = true;
               labSheetDetail.IntertechDuplicateAcceptable = val62;
               Assert.AreEqual(val62, labSheetDetail.IntertechDuplicateAcceptable);
               bool val63 = true;
               labSheetDetail.IntertechReadAcceptable = val63;
               Assert.AreEqual(val63, labSheetDetail.IntertechReadAcceptable);
               DateTime val64 = new DateTime(2010, 3, 4);
               labSheetDetail.LastUpdateDate_UTC = val64;
               Assert.AreEqual(val64, labSheetDetail.LastUpdateDate_UTC);
               int val65 = 45;
               labSheetDetail.LastUpdateContactTVItemID = val65;
               Assert.AreEqual(val65, labSheetDetail.LastUpdateContactTVItemID);
               string val66 = "Some text";
               labSheetDetail.SubsectorTVText = val66;
               Assert.AreEqual(val66, labSheetDetail.SubsectorTVText);
               string val67 = "Some text";
               labSheetDetail.LastUpdateContactTVText = val67;
               Assert.AreEqual(val67, labSheetDetail.LastUpdateContactTVText);
               bool val68 = true;
               labSheetDetail.HasErrors = val68;
               Assert.AreEqual(val68, labSheetDetail.HasErrors);
               IEnumerable<ValidationResult> val207 = new List<ValidationResult>().AsEnumerable();
               labSheetDetail.ValidationResults = val207;
               Assert.AreEqual(val207, labSheetDetail.ValidationResults);
        }
    }
}
