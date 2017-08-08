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
    public partial class RainExceedanceTest : SetupData
    {
        [TestMethod]
        public void RainExceedance_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "RainExceedanceID", "YearRound", "StartDate_Local", "EndDate_Local", "RainMaximum_mm", "RainExtreme_mm", "DaysPriorToStart", "RepeatEveryYear", "ProvinceTVItemIDs", "SubsectorTVItemIDs", "ClimateSiteTVItemIDs", "EmailDistributionListIDs", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "LastUpdateContactTVText",  }.OrderBy(c => c).ToList();

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
        public void RainExceedance_Navigation_Test()
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
        public void RainExceedance_Has_ValidationResults_Test()
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
               Assert.IsNotNull(ModelsRes.RainExceedanceLastUpdateContactTVText);
        }
        [TestMethod]
        public void RainExceedance_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               rainExceedance.RainExceedanceID = val1;
               Assert.AreEqual(val1, rainExceedance.RainExceedanceID);
               bool val2 = true;
               rainExceedance.YearRound = val2;
               Assert.AreEqual(val2, rainExceedance.YearRound);
               DateTime val3 = new DateTime(2010, 3, 4);
               rainExceedance.StartDate_Local = val3;
               Assert.AreEqual(val3, rainExceedance.StartDate_Local);
               DateTime val4 = new DateTime(2010, 3, 4);
               rainExceedance.EndDate_Local = val4;
               Assert.AreEqual(val4, rainExceedance.EndDate_Local);
               double val5 = 87.9D;
               rainExceedance.RainMaximum_mm = val5;
               Assert.AreEqual(val5, rainExceedance.RainMaximum_mm);
               double val6 = 87.9D;
               rainExceedance.RainExtreme_mm = val6;
               Assert.AreEqual(val6, rainExceedance.RainExtreme_mm);
               int val7 = 45;
               rainExceedance.DaysPriorToStart = val7;
               Assert.AreEqual(val7, rainExceedance.DaysPriorToStart);
               bool val8 = true;
               rainExceedance.RepeatEveryYear = val8;
               Assert.AreEqual(val8, rainExceedance.RepeatEveryYear);
               string val9 = "Some text";
               rainExceedance.ProvinceTVItemIDs = val9;
               Assert.AreEqual(val9, rainExceedance.ProvinceTVItemIDs);
               string val10 = "Some text";
               rainExceedance.SubsectorTVItemIDs = val10;
               Assert.AreEqual(val10, rainExceedance.SubsectorTVItemIDs);
               string val11 = "Some text";
               rainExceedance.ClimateSiteTVItemIDs = val11;
               Assert.AreEqual(val11, rainExceedance.ClimateSiteTVItemIDs);
               string val12 = "Some text";
               rainExceedance.EmailDistributionListIDs = val12;
               Assert.AreEqual(val12, rainExceedance.EmailDistributionListIDs);
               DateTime val13 = new DateTime(2010, 3, 4);
               rainExceedance.LastUpdateDate_UTC = val13;
               Assert.AreEqual(val13, rainExceedance.LastUpdateDate_UTC);
               int val14 = 45;
               rainExceedance.LastUpdateContactTVItemID = val14;
               Assert.AreEqual(val14, rainExceedance.LastUpdateContactTVItemID);
               string val15 = "Some text";
               rainExceedance.LastUpdateContactTVText = val15;
               Assert.AreEqual(val15, rainExceedance.LastUpdateContactTVText);
               IEnumerable<ValidationResult> val48 = new List<ValidationResult>().AsEnumerable();
               rainExceedance.ValidationResults = val48;
               Assert.AreEqual(val48, rainExceedance.ValidationResults);
        }
    }
}
