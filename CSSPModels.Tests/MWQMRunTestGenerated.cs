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
    public partial class MWQMRunTest
    {
        [TestMethod]
        public void MWQMRun_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "MWQMRunID", "SubsectorTVItemID", "MWQMRunTVItemID", "RunSampleType", "DateTime_Local", "RunNumber", "StartDateTime_Local", "EndDateTime_Local", "LabReceivedDateTime_Local", "TemperatureControl1_C", "TemperatureControl2_C", "SeaStateAtStart_BeaufortScale", "SeaStateAtEnd_BeaufortScale", "WaterLevelAtBrook_m", "WaveHightAtStart_m", "WaveHightAtEnd_m", "SampleCrewInitials", "AnalyzeMethod", "SampleMatrix", "Laboratory", "SampleStatus", "LabSampleApprovalContactTVItemID", "LabAnalyzeBath1IncubationStartDateTime_Local", "LabAnalyzeBath2IncubationStartDateTime_Local", "LabAnalyzeBath3IncubationStartDateTime_Local", "LabRunSampleApprovalDateTime_Local", "Tide_Start", "Tide_End", "RainDay0_mm", "RainDay1_mm", "RainDay2_mm", "RainDay3_mm", "RainDay4_mm", "RainDay5_mm", "RainDay6_mm", "RainDay7_mm", "RainDay8_mm", "RainDay9_mm", "RainDay10_mm", "RemoveFromStat", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (IProperty propertyType in entityType.GetProperties().OrderBy(c => c.Name))
            {
                Assert.AreEqual(propNameList[index], propertyType.Name);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMRun).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMRun_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "LabSampleApprovalContactTVItem", "MWQMRunTVItem", "SubsectorTVItem",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() { "MWQMRunLanguages",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (string foreignName in (from c in entityType.GetForeignKeys() orderby c.DependentToPrincipal.Name select c.DependentToPrincipal.Name))
            {
                Assert.AreEqual(foreignNameList[index], foreignName);
                index += 1;
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMRun).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMRun_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(MWQMRun).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMRun_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.MWQMRunMWQMRunID);
               Assert.IsNotNull(ModelsRes.MWQMRunSubsectorTVItemID);
               Assert.IsNotNull(ModelsRes.MWQMRunMWQMRunTVItemID);
               Assert.IsNotNull(ModelsRes.MWQMRunRunSampleType);
               Assert.IsNotNull(ModelsRes.MWQMRunDateTime_Local);
               Assert.IsNotNull(ModelsRes.MWQMRunRunNumber);
               Assert.IsNotNull(ModelsRes.MWQMRunStartDateTime_Local);
               Assert.IsNotNull(ModelsRes.MWQMRunEndDateTime_Local);
               Assert.IsNotNull(ModelsRes.MWQMRunLabReceivedDateTime_Local);
               Assert.IsNotNull(ModelsRes.MWQMRunTemperatureControl1_C);
               Assert.IsNotNull(ModelsRes.MWQMRunTemperatureControl2_C);
               Assert.IsNotNull(ModelsRes.MWQMRunSeaStateAtStart_BeaufortScale);
               Assert.IsNotNull(ModelsRes.MWQMRunSeaStateAtEnd_BeaufortScale);
               Assert.IsNotNull(ModelsRes.MWQMRunWaterLevelAtBrook_m);
               Assert.IsNotNull(ModelsRes.MWQMRunWaveHightAtStart_m);
               Assert.IsNotNull(ModelsRes.MWQMRunWaveHightAtEnd_m);
               Assert.IsNotNull(ModelsRes.MWQMRunSampleCrewInitials);
               Assert.IsNotNull(ModelsRes.MWQMRunAnalyzeMethod);
               Assert.IsNotNull(ModelsRes.MWQMRunSampleMatrix);
               Assert.IsNotNull(ModelsRes.MWQMRunLaboratory);
               Assert.IsNotNull(ModelsRes.MWQMRunSampleStatus);
               Assert.IsNotNull(ModelsRes.MWQMRunLabSampleApprovalContactTVItemID);
               Assert.IsNotNull(ModelsRes.MWQMRunLabAnalyzeBath1IncubationStartDateTime_Local);
               Assert.IsNotNull(ModelsRes.MWQMRunLabAnalyzeBath2IncubationStartDateTime_Local);
               Assert.IsNotNull(ModelsRes.MWQMRunLabAnalyzeBath3IncubationStartDateTime_Local);
               Assert.IsNotNull(ModelsRes.MWQMRunLabRunSampleApprovalDateTime_Local);
               Assert.IsNotNull(ModelsRes.MWQMRunTide_Start);
               Assert.IsNotNull(ModelsRes.MWQMRunTide_End);
               Assert.IsNotNull(ModelsRes.MWQMRunRainDay0_mm);
               Assert.IsNotNull(ModelsRes.MWQMRunRainDay1_mm);
               Assert.IsNotNull(ModelsRes.MWQMRunRainDay2_mm);
               Assert.IsNotNull(ModelsRes.MWQMRunRainDay3_mm);
               Assert.IsNotNull(ModelsRes.MWQMRunRainDay4_mm);
               Assert.IsNotNull(ModelsRes.MWQMRunRainDay5_mm);
               Assert.IsNotNull(ModelsRes.MWQMRunRainDay6_mm);
               Assert.IsNotNull(ModelsRes.MWQMRunRainDay7_mm);
               Assert.IsNotNull(ModelsRes.MWQMRunRainDay8_mm);
               Assert.IsNotNull(ModelsRes.MWQMRunRainDay9_mm);
               Assert.IsNotNull(ModelsRes.MWQMRunRainDay10_mm);
               Assert.IsNotNull(ModelsRes.MWQMRunRemoveFromStat);
               Assert.IsNotNull(ModelsRes.MWQMRunLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.MWQMRunLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.MWQMRunMWQMRunLanguages);
               Assert.IsNotNull(ModelsRes.MWQMRunLabSampleApprovalContactTVItem);
               Assert.IsNotNull(ModelsRes.MWQMRunMWQMRunTVItem);
               Assert.IsNotNull(ModelsRes.MWQMRunSubsectorTVItem);
        }
    }
}
