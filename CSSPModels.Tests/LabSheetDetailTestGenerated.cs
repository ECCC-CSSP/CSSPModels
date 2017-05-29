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
    public partial class LabSheetDetailTest
    {
        [TestMethod]
        public void LabSheetDetail_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "LabSheetDetailID", "LabSheetID", "SamplingPlanID", "SubsectorTVItemID", "Version", "RunDate", "Tides", "SampleCrewInitials", "WaterBathCount", "IncubationBath1StartTime", "IncubationBath2StartTime", "IncubationBath3StartTime", "IncubationBath1EndTime", "IncubationBath2EndTime", "IncubationBath3EndTime", "IncubationBath1TimeCalculated_minutes", "IncubationBath2TimeCalculated_minutes", "IncubationBath3TimeCalculated_minutes", "WaterBath1", "WaterBath2", "WaterBath3", "TCField1", "TCLab1", "TCField2", "TCLab2", "TCFirst", "TCAverage", "ControlLot", "Positive35", "NonTarget35", "Negative35", "Bath1Positive44_5", "Bath2Positive44_5", "Bath3Positive44_5", "Bath1NonTarget44_5", "Bath2NonTarget44_5", "Bath3NonTarget44_5", "Bath1Negative44_5", "Bath2Negative44_5", "Bath3Negative44_5", "Blank35", "Bath1Blank44_5", "Bath2Blank44_5", "Bath3Blank44_5", "Lot35", "Lot44_5", "Weather", "RunComment", "RunWeatherComment", "SampleBottleLotNumber", "SalinitiesReadBy", "SalinitiesReadDate", "ResultsReadBy", "ResultsReadDate", "ResultsRecordedBy", "ResultsRecordedDate", "DailyDuplicateRlog", "DailyDuplicatePrecisionCriteria", "DailyDuplicateAcceptable", "IntertechDuplicateRlog", "IntertechDuplicatePrecisionCriteria", "IntertechDuplicateAcceptable", "IntertechReadAcceptable", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (IProperty propertyType in entityType.GetProperties().OrderBy(c => c.Name))
            {
                Assert.AreEqual(propNameList[index], propertyType.Name);
                index += 1;
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
        public void LabSheetDetail_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "LabSheet", "SamplingPlan", "SubsectorTVItem",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() { "LabSheetTubeMPNDetails",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (string foreignName in (from c in entityType.GetForeignKeys() orderby c.DependentToPrincipal.Name select c.DependentToPrincipal.Name))
            {
                Assert.AreEqual(foreignNameList[index], foreignName);
                index += 1;
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
        public void LabSheetDetail_Has_ValidationResults_OK()
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
               Assert.IsNotNull(ModelsRes.LabSheetDetailDailyDuplicateRlog);
               Assert.IsNotNull(ModelsRes.LabSheetDetailDailyDuplicatePrecisionCriteria);
               Assert.IsNotNull(ModelsRes.LabSheetDetailDailyDuplicateAcceptable);
               Assert.IsNotNull(ModelsRes.LabSheetDetailIntertechDuplicateRlog);
               Assert.IsNotNull(ModelsRes.LabSheetDetailIntertechDuplicatePrecisionCriteria);
               Assert.IsNotNull(ModelsRes.LabSheetDetailIntertechDuplicateAcceptable);
               Assert.IsNotNull(ModelsRes.LabSheetDetailIntertechReadAcceptable);
               Assert.IsNotNull(ModelsRes.LabSheetDetailLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.LabSheetDetailLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.LabSheetDetailLabSheetTubeMPNDetails);
               Assert.IsNotNull(ModelsRes.LabSheetDetailLabSheet);
               Assert.IsNotNull(ModelsRes.LabSheetDetailSamplingPlan);
               Assert.IsNotNull(ModelsRes.LabSheetDetailSubsectorTVItem);
        }
    }
}
