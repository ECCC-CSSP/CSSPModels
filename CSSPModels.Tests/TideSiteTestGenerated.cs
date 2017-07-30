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
    public partial class TideSiteTest : SetupData
    {
        [TestMethod]
        public void TideSite_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TideSiteID", "TideSiteTVItemID", "WebTideModel", "WebTideDatum_m", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.TideSite).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TideSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TideSite_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() { "TideSiteTVItem",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideSite).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TideSite_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TideSite).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TideSite_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.TideSiteTideSiteID);
               Assert.IsNotNull(ModelsRes.TideSiteTideSiteTVItemID);
               Assert.IsNotNull(ModelsRes.TideSiteWebTideModel);
               Assert.IsNotNull(ModelsRes.TideSiteWebTideDatum_m);
               Assert.IsNotNull(ModelsRes.TideSiteLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.TideSiteLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.TideSiteTideSiteTVItem);
        }
        [TestMethod]
        public void TideSite_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               tideSite.TideSiteID = val1;
               Assert.AreEqual(val1, tideSite.TideSiteID);
               int val2 = 45;
               tideSite.TideSiteTVItemID = val2;
               Assert.AreEqual(val2, tideSite.TideSiteTVItemID);
               string val3 = "Some text";
               tideSite.WebTideModel = val3;
               Assert.AreEqual(val3, tideSite.WebTideModel);
               double val4 = 87.9D;
               tideSite.WebTideDatum_m = val4;
               Assert.AreEqual(val4, tideSite.WebTideDatum_m);
               DateTime val5 = new DateTime(2010, 3, 4);
               tideSite.LastUpdateDate_UTC = val5;
               Assert.AreEqual(val5, tideSite.LastUpdateDate_UTC);
               int val6 = 45;
               tideSite.LastUpdateContactTVItemID = val6;
               Assert.AreEqual(val6, tideSite.LastUpdateContactTVItemID);
               TVItem val15 = new TVItem();
               tideSite.TideSiteTVItem = val15;
               Assert.AreEqual(val15, tideSite.TideSiteTVItem);
               IEnumerable<ValidationResult> val24 = new List<ValidationResult>().AsEnumerable();
               tideSite.ValidationResults = val24;
               Assert.AreEqual(val24, tideSite.ValidationResults);
        }
    }
}
