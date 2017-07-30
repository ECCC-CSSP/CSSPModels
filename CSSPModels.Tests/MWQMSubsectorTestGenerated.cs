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
    public partial class MWQMSubsectorTest : SetupData
    {
        [TestMethod]
        public void MWQMSubsector_Properties_Test()
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
        public void MWQMSubsector_Navigation_Test()
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
        public void MWQMSubsector_Has_ValidationResults_Test()
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
        [TestMethod]
        public void MWQMSubsector_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mWQMSubsector.MWQMSubsectorID = val1;
               Assert.AreEqual(val1, mWQMSubsector.MWQMSubsectorID);
               int val2 = 45;
               mWQMSubsector.MWQMSubsectorTVItemID = val2;
               Assert.AreEqual(val2, mWQMSubsector.MWQMSubsectorTVItemID);
               string val3 = "Some text";
               mWQMSubsector.SubsectorHistoricKey = val3;
               Assert.AreEqual(val3, mWQMSubsector.SubsectorHistoricKey);
               string val4 = "Some text";
               mWQMSubsector.TideLocationSIDText = val4;
               Assert.AreEqual(val4, mWQMSubsector.TideLocationSIDText);
               double val5 = 87.9D;
               mWQMSubsector.RainDay0Limit = val5;
               Assert.AreEqual(val5, mWQMSubsector.RainDay0Limit);
               double val6 = 87.9D;
               mWQMSubsector.RainDay1Limit = val6;
               Assert.AreEqual(val6, mWQMSubsector.RainDay1Limit);
               double val7 = 87.9D;
               mWQMSubsector.RainDay2Limit = val7;
               Assert.AreEqual(val7, mWQMSubsector.RainDay2Limit);
               double val8 = 87.9D;
               mWQMSubsector.RainDay3Limit = val8;
               Assert.AreEqual(val8, mWQMSubsector.RainDay3Limit);
               double val9 = 87.9D;
               mWQMSubsector.RainDay4Limit = val9;
               Assert.AreEqual(val9, mWQMSubsector.RainDay4Limit);
               double val10 = 87.9D;
               mWQMSubsector.RainDay5Limit = val10;
               Assert.AreEqual(val10, mWQMSubsector.RainDay5Limit);
               double val11 = 87.9D;
               mWQMSubsector.RainDay6Limit = val11;
               Assert.AreEqual(val11, mWQMSubsector.RainDay6Limit);
               double val12 = 87.9D;
               mWQMSubsector.RainDay7Limit = val12;
               Assert.AreEqual(val12, mWQMSubsector.RainDay7Limit);
               double val13 = 87.9D;
               mWQMSubsector.RainDay8Limit = val13;
               Assert.AreEqual(val13, mWQMSubsector.RainDay8Limit);
               double val14 = 87.9D;
               mWQMSubsector.RainDay9Limit = val14;
               Assert.AreEqual(val14, mWQMSubsector.RainDay9Limit);
               double val15 = 87.9D;
               mWQMSubsector.RainDay10Limit = val15;
               Assert.AreEqual(val15, mWQMSubsector.RainDay10Limit);
               DateTime val16 = new DateTime(2010, 3, 4);
               mWQMSubsector.IncludeRainStartDate = val16;
               Assert.AreEqual(val16, mWQMSubsector.IncludeRainStartDate);
               DateTime val17 = new DateTime(2010, 3, 4);
               mWQMSubsector.IncludeRainEndDate = val17;
               Assert.AreEqual(val17, mWQMSubsector.IncludeRainEndDate);
               int val18 = 45;
               mWQMSubsector.IncludeRainRunCount = val18;
               Assert.AreEqual(val18, mWQMSubsector.IncludeRainRunCount);
               bool val19 = true;
               mWQMSubsector.IncludeRainSelectFullYear = val19;
               Assert.AreEqual(val19, mWQMSubsector.IncludeRainSelectFullYear);
               DateTime val20 = new DateTime(2010, 3, 4);
               mWQMSubsector.NoRainStartDate = val20;
               Assert.AreEqual(val20, mWQMSubsector.NoRainStartDate);
               DateTime val21 = new DateTime(2010, 3, 4);
               mWQMSubsector.NoRainEndDate = val21;
               Assert.AreEqual(val21, mWQMSubsector.NoRainEndDate);
               int val22 = 45;
               mWQMSubsector.NoRainRunCount = val22;
               Assert.AreEqual(val22, mWQMSubsector.NoRainRunCount);
               bool val23 = true;
               mWQMSubsector.NoRainSelectFullYear = val23;
               Assert.AreEqual(val23, mWQMSubsector.NoRainSelectFullYear);
               DateTime val24 = new DateTime(2010, 3, 4);
               mWQMSubsector.OnlyRainStartDate = val24;
               Assert.AreEqual(val24, mWQMSubsector.OnlyRainStartDate);
               DateTime val25 = new DateTime(2010, 3, 4);
               mWQMSubsector.OnlyRainEndDate = val25;
               Assert.AreEqual(val25, mWQMSubsector.OnlyRainEndDate);
               int val26 = 45;
               mWQMSubsector.OnlyRainRunCount = val26;
               Assert.AreEqual(val26, mWQMSubsector.OnlyRainRunCount);
               bool val27 = true;
               mWQMSubsector.OnlyRainSelectFullYear = val27;
               Assert.AreEqual(val27, mWQMSubsector.OnlyRainSelectFullYear);
               DateTime val28 = new DateTime(2010, 3, 4);
               mWQMSubsector.LastUpdateDate_UTC = val28;
               Assert.AreEqual(val28, mWQMSubsector.LastUpdateDate_UTC);
               int val29 = 45;
               mWQMSubsector.LastUpdateContactTVItemID = val29;
               Assert.AreEqual(val29, mWQMSubsector.LastUpdateContactTVItemID);
               ICollection<MWQMSubsectorLanguage> val62 = new List<MWQMSubsectorLanguage>();
               mWQMSubsector.MWQMSubsectorLanguages = val62;
               Assert.AreEqual(val62, mWQMSubsector.MWQMSubsectorLanguages);
               TVItem val63 = new TVItem();
               mWQMSubsector.MWQMSubsectorTVItem = val63;
               Assert.AreEqual(val63, mWQMSubsector.MWQMSubsectorTVItem);
               IEnumerable<ValidationResult> val96 = new List<ValidationResult>().AsEnumerable();
               mWQMSubsector.ValidationResults = val96;
               Assert.AreEqual(val96, mWQMSubsector.ValidationResults);
        }
    }
}
