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
    public partial class MWQMSubsectorTest
    {
        [TestMethod]
        public void MWQMSubsector_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "MWQMSubsectorID", "MWQMSubsectorTVItemID", "SubsectorHistoricKey", "TideLocationSIDText", "RainDay0Limit", "RainDay1Limit", "RainDay2Limit", "RainDay3Limit", "RainDay4Limit", "RainDay5Limit", "RainDay6Limit", "RainDay7Limit", "RainDay8Limit", "RainDay9Limit", "RainDay10Limit", "IncludeRainStartDate", "IncludeRainEndDate", "IncludeRainRunCount", "IncludeRainSelectFullYear", "NoRainStartDate", "NoRainEndDate", "NoRainRunCount", "NoRainSelectFullYear", "OnlyRainStartDate", "OnlyRainEndDate", "OnlyRainRunCount", "OnlyRainSelectFullYear", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.MWQMSubsector).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsector).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSubsector_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "MWQMSubsectorTVItem",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() { "MWQMSubsectorLanguages",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsector).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsector).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSubsector_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(MWQMSubsector).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSubsector_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.MWQMSubsectorMWQMSubsectorID);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorMWQMSubsectorTVItemID);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorSubsectorHistoricKey);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorTideLocationSIDText);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorRainDay0Limit);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorRainDay1Limit);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorRainDay2Limit);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorRainDay3Limit);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorRainDay4Limit);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorRainDay5Limit);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorRainDay6Limit);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorRainDay7Limit);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorRainDay8Limit);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorRainDay9Limit);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorRainDay10Limit);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorIncludeRainStartDate);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorIncludeRainEndDate);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorIncludeRainRunCount);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorIncludeRainSelectFullYear);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorNoRainStartDate);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorNoRainEndDate);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorNoRainRunCount);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorNoRainSelectFullYear);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorOnlyRainStartDate);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorOnlyRainEndDate);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorOnlyRainRunCount);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorOnlyRainSelectFullYear);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorMWQMSubsectorLanguages);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorMWQMSubsectorTVItem);
        }
    }
}
