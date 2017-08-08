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
    public partial class EmailDistributionListTest : SetupData
    {
        [TestMethod]
        public void EmailDistributionList_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "EmailDistributionListID", "CountryTVItemID", "RegionName", "Ordinal", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "CountryTVText", "LastUpdateContactTVText",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.EmailDistributionList).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionList).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void EmailDistributionList_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionList).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionList).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void EmailDistributionList_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(EmailDistributionList).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void EmailDistributionList_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.EmailDistributionListEmailDistributionListID);
               Assert.IsNotNull(ModelsRes.EmailDistributionListCountryTVItemID);
               Assert.IsNotNull(ModelsRes.EmailDistributionListRegionName);
               Assert.IsNotNull(ModelsRes.EmailDistributionListOrdinal);
               Assert.IsNotNull(ModelsRes.EmailDistributionListLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.EmailDistributionListLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.EmailDistributionListCountryTVText);
               Assert.IsNotNull(ModelsRes.EmailDistributionListLastUpdateContactTVText);
        }
        [TestMethod]
        public void EmailDistributionList_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               emailDistributionList.EmailDistributionListID = val1;
               Assert.AreEqual(val1, emailDistributionList.EmailDistributionListID);
               int val2 = 45;
               emailDistributionList.CountryTVItemID = val2;
               Assert.AreEqual(val2, emailDistributionList.CountryTVItemID);
               string val3 = "Some text";
               emailDistributionList.RegionName = val3;
               Assert.AreEqual(val3, emailDistributionList.RegionName);
               int val4 = 45;
               emailDistributionList.Ordinal = val4;
               Assert.AreEqual(val4, emailDistributionList.Ordinal);
               DateTime val5 = new DateTime(2010, 3, 4);
               emailDistributionList.LastUpdateDate_UTC = val5;
               Assert.AreEqual(val5, emailDistributionList.LastUpdateDate_UTC);
               int val6 = 45;
               emailDistributionList.LastUpdateContactTVItemID = val6;
               Assert.AreEqual(val6, emailDistributionList.LastUpdateContactTVItemID);
               string val7 = "Some text";
               emailDistributionList.CountryTVText = val7;
               Assert.AreEqual(val7, emailDistributionList.CountryTVText);
               string val8 = "Some text";
               emailDistributionList.LastUpdateContactTVText = val8;
               Assert.AreEqual(val8, emailDistributionList.LastUpdateContactTVText);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>().AsEnumerable();
               emailDistributionList.ValidationResults = val27;
               Assert.AreEqual(val27, emailDistributionList.ValidationResults);
        }
    }
}
