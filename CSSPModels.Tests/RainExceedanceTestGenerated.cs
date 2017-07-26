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
    public partial class RainExceedanceTest
    {
        [TestMethod]
        public void RainExceedance_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "RainExceedanceID", "YearRound", "StartDate_Local", "EndDate_Local", "RainMaximum_mm", "RainExtreme_mm", "DaysPriorToStart", "RepeatEveryYear", "ProvinceTVItemIDs", "SubsectorTVItemIDs", "ClimateSiteTVItemIDs", "EmailDistributionListIDs", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.RainExceedance).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(RainExceedance).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void RainExceedance_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(RainExceedance).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(RainExceedance).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void RainExceedance_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(RainExceedance).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void RainExceedance_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.RainExceedanceRainExceedanceID);
               Assert.IsNotNull(ModelsRes.RainExceedanceYearRound);
               Assert.IsNotNull(ModelsRes.RainExceedanceStartDate_Local);
               Assert.IsNotNull(ModelsRes.RainExceedanceEndDate_Local);
               Assert.IsNotNull(ModelsRes.RainExceedanceRainMaximum_mm);
               Assert.IsNotNull(ModelsRes.RainExceedanceRainExtreme_mm);
               Assert.IsNotNull(ModelsRes.RainExceedanceDaysPriorToStart);
               Assert.IsNotNull(ModelsRes.RainExceedanceRepeatEveryYear);
               Assert.IsNotNull(ModelsRes.RainExceedanceProvinceTVItemIDs);
               Assert.IsNotNull(ModelsRes.RainExceedanceSubsectorTVItemIDs);
               Assert.IsNotNull(ModelsRes.RainExceedanceClimateSiteTVItemIDs);
               Assert.IsNotNull(ModelsRes.RainExceedanceEmailDistributionListIDs);
               Assert.IsNotNull(ModelsRes.RainExceedanceLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.RainExceedanceLastUpdateContactTVItemID);
        }
    }
}