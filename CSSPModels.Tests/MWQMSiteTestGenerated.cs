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
    public partial class MWQMSiteTest : SetupData
    {
        [TestMethod]
        public void MWQMSite_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMSiteID", "MWQMSiteTVItemID", "MWQMSiteNumber", "MWQMSiteDescription", "MWQMSiteLatestClassification", "Ordinal", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "MWQMSiteLatestClassificationText",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.MWQMSite).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSite_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSite).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSite_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSite).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSite_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.MWQMSiteMWQMSiteID);
               Assert.IsNotNull(ModelsRes.MWQMSiteMWQMSiteTVItemID);
               Assert.IsNotNull(ModelsRes.MWQMSiteMWQMSiteNumber);
               Assert.IsNotNull(ModelsRes.MWQMSiteMWQMSiteDescription);
               Assert.IsNotNull(ModelsRes.MWQMSiteMWQMSiteLatestClassification);
               Assert.IsNotNull(ModelsRes.MWQMSiteOrdinal);
               Assert.IsNotNull(ModelsRes.MWQMSiteLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.MWQMSiteLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.MWQMSiteMWQMSiteLatestClassificationText);
        }
        [TestMethod]
        public void MWQMSite_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mWQMSite.MWQMSiteID = val1;
               Assert.AreEqual(val1, mWQMSite.MWQMSiteID);
               int val2 = 45;
               mWQMSite.MWQMSiteTVItemID = val2;
               Assert.AreEqual(val2, mWQMSite.MWQMSiteTVItemID);
               string val3 = "Some text";
               mWQMSite.MWQMSiteNumber = val3;
               Assert.AreEqual(val3, mWQMSite.MWQMSiteNumber);
               string val4 = "Some text";
               mWQMSite.MWQMSiteDescription = val4;
               Assert.AreEqual(val4, mWQMSite.MWQMSiteDescription);
               MWQMSiteLatestClassificationEnum val5 = (MWQMSiteLatestClassificationEnum)3;
               mWQMSite.MWQMSiteLatestClassification = val5;
               Assert.AreEqual(val5, mWQMSite.MWQMSiteLatestClassification);
               int val6 = 45;
               mWQMSite.Ordinal = val6;
               Assert.AreEqual(val6, mWQMSite.Ordinal);
               DateTime val7 = new DateTime(2010, 3, 4);
               mWQMSite.LastUpdateDate_UTC = val7;
               Assert.AreEqual(val7, mWQMSite.LastUpdateDate_UTC);
               int val8 = 45;
               mWQMSite.LastUpdateContactTVItemID = val8;
               Assert.AreEqual(val8, mWQMSite.LastUpdateContactTVItemID);
               string val9 = "Some text";
               mWQMSite.MWQMSiteLatestClassificationText = val9;
               Assert.AreEqual(val9, mWQMSite.MWQMSiteLatestClassificationText);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>().AsEnumerable();
               mWQMSite.ValidationResults = val30;
               Assert.AreEqual(val30, mWQMSite.ValidationResults);
        }
    }
}
