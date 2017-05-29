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
    public partial class SamplingPlanTest
    {
        [TestMethod]
        public void SamplingPlan_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "SamplingPlanID", "SamplingPlanName", "ForGroupName", "SampleType", "SamplingPlanType", "LabSheetType", "ProvinceTVItemID", "CreatorTVItemID", "Year", "AccessCode", "DailyDuplicatePrecisionCriteria", "IntertechDuplicatePrecisionCriteria", "IncludeLaboratoryQAQC", "SamplingPlanFileTVItemID", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (IProperty propertyType in entityType.GetProperties().OrderBy(c => c.Name))
            {
                Assert.AreEqual(propNameList[index], propertyType.Name);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SamplingPlan).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void SamplingPlan_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "CreatorTVItem", "ProvinceTVItem", "SamplingPlanFileTVItem",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() { "LabSheetDetails", "LabSheets", "SamplingPlanSubsectors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (string foreignName in (from c in entityType.GetForeignKeys() orderby c.DependentToPrincipal.Name select c.DependentToPrincipal.Name))
            {
                Assert.AreEqual(foreignNameList[index], foreignName);
                index += 1;
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SamplingPlan).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void SamplingPlan_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(SamplingPlan).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void SamplingPlan_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.SamplingPlanSamplingPlanID);
               Assert.IsNotNull(ModelsRes.SamplingPlanSamplingPlanName);
               Assert.IsNotNull(ModelsRes.SamplingPlanForGroupName);
               Assert.IsNotNull(ModelsRes.SamplingPlanSampleType);
               Assert.IsNotNull(ModelsRes.SamplingPlanSamplingPlanType);
               Assert.IsNotNull(ModelsRes.SamplingPlanLabSheetType);
               Assert.IsNotNull(ModelsRes.SamplingPlanProvinceTVItemID);
               Assert.IsNotNull(ModelsRes.SamplingPlanCreatorTVItemID);
               Assert.IsNotNull(ModelsRes.SamplingPlanYear);
               Assert.IsNotNull(ModelsRes.SamplingPlanAccessCode);
               Assert.IsNotNull(ModelsRes.SamplingPlanDailyDuplicatePrecisionCriteria);
               Assert.IsNotNull(ModelsRes.SamplingPlanIntertechDuplicatePrecisionCriteria);
               Assert.IsNotNull(ModelsRes.SamplingPlanIncludeLaboratoryQAQC);
               Assert.IsNotNull(ModelsRes.SamplingPlanSamplingPlanFileTVItemID);
               Assert.IsNotNull(ModelsRes.SamplingPlanLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.SamplingPlanLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.SamplingPlanLabSheetDetails);
               Assert.IsNotNull(ModelsRes.SamplingPlanLabSheets);
               Assert.IsNotNull(ModelsRes.SamplingPlanSamplingPlanSubsectors);
               Assert.IsNotNull(ModelsRes.SamplingPlanCreatorTVItem);
               Assert.IsNotNull(ModelsRes.SamplingPlanProvinceTVItem);
               Assert.IsNotNull(ModelsRes.SamplingPlanSamplingPlanFileTVItem);
        }
    }
}
