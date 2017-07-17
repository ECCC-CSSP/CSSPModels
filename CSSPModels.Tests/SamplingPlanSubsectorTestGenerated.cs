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
    public partial class SamplingPlanSubsectorTest
    {
        [TestMethod]
        public void SamplingPlanSubsector_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "SamplingPlanSubsectorID", "SamplingPlanID", "SubsectorTVItemID", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.SamplingPlanSubsector).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(SamplingPlanSubsector).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void SamplingPlanSubsector_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "SamplingPlan", "SubsectorTVItem",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() { "SamplingPlanSubsectorSites",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SamplingPlanSubsector).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SamplingPlanSubsector).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void SamplingPlanSubsector_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(SamplingPlanSubsector).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void SamplingPlanSubsector_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.SamplingPlanSubsectorSamplingPlanSubsectorID);
               Assert.IsNotNull(ModelsRes.SamplingPlanSubsectorSamplingPlanID);
               Assert.IsNotNull(ModelsRes.SamplingPlanSubsectorSubsectorTVItemID);
               Assert.IsNotNull(ModelsRes.SamplingPlanSubsectorLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.SamplingPlanSubsectorLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.SamplingPlanSubsectorSamplingPlanSubsectorSites);
               Assert.IsNotNull(ModelsRes.SamplingPlanSubsectorSamplingPlan);
               Assert.IsNotNull(ModelsRes.SamplingPlanSubsectorSubsectorTVItem);
        }
    }
}
