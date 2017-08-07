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
    public partial class MWQMSiteStartEndDateTest : SetupData
    {
        [TestMethod]
        public void MWQMSiteStartEndDate_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMSiteStartEndDateID", "MWQMSiteTVItemID", "StartDate", "EndDate", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.MWQMSiteStartEndDate).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMSiteStartEndDate).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSiteStartEndDate_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSiteStartEndDate).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSiteStartEndDate).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSiteStartEndDate_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSiteStartEndDate).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSiteStartEndDate_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.MWQMSiteStartEndDateMWQMSiteStartEndDateID);
               Assert.IsNotNull(ModelsRes.MWQMSiteStartEndDateMWQMSiteTVItemID);
               Assert.IsNotNull(ModelsRes.MWQMSiteStartEndDateStartDate);
               Assert.IsNotNull(ModelsRes.MWQMSiteStartEndDateEndDate);
               Assert.IsNotNull(ModelsRes.MWQMSiteStartEndDateLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.MWQMSiteStartEndDateLastUpdateContactTVItemID);
        }
        [TestMethod]
        public void MWQMSiteStartEndDate_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mWQMSiteStartEndDate.MWQMSiteStartEndDateID = val1;
               Assert.AreEqual(val1, mWQMSiteStartEndDate.MWQMSiteStartEndDateID);
               int val2 = 45;
               mWQMSiteStartEndDate.MWQMSiteTVItemID = val2;
               Assert.AreEqual(val2, mWQMSiteStartEndDate.MWQMSiteTVItemID);
               DateTime val3 = new DateTime(2010, 3, 4);
               mWQMSiteStartEndDate.StartDate = val3;
               Assert.AreEqual(val3, mWQMSiteStartEndDate.StartDate);
               DateTime val4 = new DateTime(2010, 3, 4);
               mWQMSiteStartEndDate.EndDate = val4;
               Assert.AreEqual(val4, mWQMSiteStartEndDate.EndDate);
               DateTime val5 = new DateTime(2010, 3, 4);
               mWQMSiteStartEndDate.LastUpdateDate_UTC = val5;
               Assert.AreEqual(val5, mWQMSiteStartEndDate.LastUpdateDate_UTC);
               int val6 = 45;
               mWQMSiteStartEndDate.LastUpdateContactTVItemID = val6;
               Assert.AreEqual(val6, mWQMSiteStartEndDate.LastUpdateContactTVItemID);
               IEnumerable<ValidationResult> val21 = new List<ValidationResult>().AsEnumerable();
               mWQMSiteStartEndDate.ValidationResults = val21;
               Assert.AreEqual(val21, mWQMSiteStartEndDate.ValidationResults);
        }
    }
}
