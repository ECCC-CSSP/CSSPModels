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
    public partial class SamplingPlanSubsectorTest : SetupData
    {
        [TestMethod]
        public void SamplingPlanSubsector_Properties_Test()
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
        public void SamplingPlanSubsector_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

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
        public void SamplingPlanSubsector_Has_ValidationResults_Test()
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
        }
        [TestMethod]
        public void SamplingPlanSubsector_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               samplingPlanSubsector.SamplingPlanSubsectorID = val1;
               Assert.AreEqual(val1, samplingPlanSubsector.SamplingPlanSubsectorID);
               int val2 = 45;
               samplingPlanSubsector.SamplingPlanID = val2;
               Assert.AreEqual(val2, samplingPlanSubsector.SamplingPlanID);
               int val3 = 45;
               samplingPlanSubsector.SubsectorTVItemID = val3;
               Assert.AreEqual(val3, samplingPlanSubsector.SubsectorTVItemID);
               DateTime val4 = new DateTime(2010, 3, 4);
               samplingPlanSubsector.LastUpdateDate_UTC = val4;
               Assert.AreEqual(val4, samplingPlanSubsector.LastUpdateDate_UTC);
               int val5 = 45;
               samplingPlanSubsector.LastUpdateContactTVItemID = val5;
               Assert.AreEqual(val5, samplingPlanSubsector.LastUpdateContactTVItemID);
               IEnumerable<ValidationResult> val18 = new List<ValidationResult>().AsEnumerable();
               samplingPlanSubsector.ValidationResults = val18;
               Assert.AreEqual(val18, samplingPlanSubsector.ValidationResults);
        }
    }
}
