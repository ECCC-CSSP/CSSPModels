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
    public partial class SamplingPlanSubsectorSiteTest : SetupData
    {
        [TestMethod]
        public void SamplingPlanSubsectorSite_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "SamplingPlanSubsectorSiteID", "SamplingPlanSubsectorID", "MWQMSiteTVItemID", "IsDuplicate", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.SamplingPlanSubsectorSite).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(SamplingPlanSubsectorSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void SamplingPlanSubsectorSite_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() { "MWQMSiteTVItem", "SamplingPlanSubsector",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SamplingPlanSubsectorSite).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SamplingPlanSubsectorSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void SamplingPlanSubsectorSite_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(SamplingPlanSubsectorSite).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void SamplingPlanSubsectorSite_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.SamplingPlanSubsectorSiteSamplingPlanSubsectorSiteID);
               Assert.IsNotNull(ModelsRes.SamplingPlanSubsectorSiteSamplingPlanSubsectorID);
               Assert.IsNotNull(ModelsRes.SamplingPlanSubsectorSiteMWQMSiteTVItemID);
               Assert.IsNotNull(ModelsRes.SamplingPlanSubsectorSiteIsDuplicate);
               Assert.IsNotNull(ModelsRes.SamplingPlanSubsectorSiteLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.SamplingPlanSubsectorSiteLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.SamplingPlanSubsectorSiteMWQMSiteTVItem);
               Assert.IsNotNull(ModelsRes.SamplingPlanSubsectorSiteSamplingPlanSubsector);
        }
        [TestMethod]
        public void SamplingPlanSubsectorSite_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               samplingPlanSubsectorSite.SamplingPlanSubsectorSiteID = val1;
               Assert.AreEqual(val1, samplingPlanSubsectorSite.SamplingPlanSubsectorSiteID);
               int val2 = 45;
               samplingPlanSubsectorSite.SamplingPlanSubsectorID = val2;
               Assert.AreEqual(val2, samplingPlanSubsectorSite.SamplingPlanSubsectorID);
               int val3 = 45;
               samplingPlanSubsectorSite.MWQMSiteTVItemID = val3;
               Assert.AreEqual(val3, samplingPlanSubsectorSite.MWQMSiteTVItemID);
               bool val4 = true;
               samplingPlanSubsectorSite.IsDuplicate = val4;
               Assert.AreEqual(val4, samplingPlanSubsectorSite.IsDuplicate);
               DateTime val5 = new DateTime(2010, 3, 4);
               samplingPlanSubsectorSite.LastUpdateDate_UTC = val5;
               Assert.AreEqual(val5, samplingPlanSubsectorSite.LastUpdateDate_UTC);
               int val6 = 45;
               samplingPlanSubsectorSite.LastUpdateContactTVItemID = val6;
               Assert.AreEqual(val6, samplingPlanSubsectorSite.LastUpdateContactTVItemID);
               TVItem val16 = new TVItem();
               samplingPlanSubsectorSite.MWQMSiteTVItem = val16;
               Assert.AreEqual(val16, samplingPlanSubsectorSite.MWQMSiteTVItem);
               SamplingPlanSubsector val17 = new SamplingPlanSubsector();
               samplingPlanSubsectorSite.SamplingPlanSubsector = val17;
               Assert.AreEqual(val17, samplingPlanSubsectorSite.SamplingPlanSubsector);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>().AsEnumerable();
               samplingPlanSubsectorSite.ValidationResults = val27;
               Assert.AreEqual(val27, samplingPlanSubsectorSite.ValidationResults);
        }
    }
}
