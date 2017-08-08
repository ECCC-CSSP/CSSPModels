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
    public partial class UseOfSiteTest : SetupData
    {
        [TestMethod]
        public void UseOfSite_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "UseOfSiteID", "SiteTVItemID", "SubsectorTVItemID", "SiteType", "Ordinal", "StartYear", "EndYear", "UseWeight", "Weight_perc", "UseEquation", "Param1", "Param2", "Param3", "Param4", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "SiteTVText", "SubsectorTVText", "LastUpdateContactTVText", "SiteTypeText",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.UseOfSite).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(UseOfSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void UseOfSite_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(UseOfSite).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(UseOfSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void UseOfSite_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(UseOfSite).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void UseOfSite_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.UseOfSiteUseOfSiteID);
               Assert.IsNotNull(ModelsRes.UseOfSiteSiteTVItemID);
               Assert.IsNotNull(ModelsRes.UseOfSiteSubsectorTVItemID);
               Assert.IsNotNull(ModelsRes.UseOfSiteSiteType);
               Assert.IsNotNull(ModelsRes.UseOfSiteOrdinal);
               Assert.IsNotNull(ModelsRes.UseOfSiteStartYear);
               Assert.IsNotNull(ModelsRes.UseOfSiteEndYear);
               Assert.IsNotNull(ModelsRes.UseOfSiteUseWeight);
               Assert.IsNotNull(ModelsRes.UseOfSiteWeight_perc);
               Assert.IsNotNull(ModelsRes.UseOfSiteUseEquation);
               Assert.IsNotNull(ModelsRes.UseOfSiteParam1);
               Assert.IsNotNull(ModelsRes.UseOfSiteParam2);
               Assert.IsNotNull(ModelsRes.UseOfSiteParam3);
               Assert.IsNotNull(ModelsRes.UseOfSiteParam4);
               Assert.IsNotNull(ModelsRes.UseOfSiteLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.UseOfSiteLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.UseOfSiteSiteTVText);
               Assert.IsNotNull(ModelsRes.UseOfSiteSubsectorTVText);
               Assert.IsNotNull(ModelsRes.UseOfSiteLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.UseOfSiteSiteTypeText);
        }
        [TestMethod]
        public void UseOfSite_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               useOfSite.UseOfSiteID = val1;
               Assert.AreEqual(val1, useOfSite.UseOfSiteID);
               int val2 = 45;
               useOfSite.SiteTVItemID = val2;
               Assert.AreEqual(val2, useOfSite.SiteTVItemID);
               int val3 = 45;
               useOfSite.SubsectorTVItemID = val3;
               Assert.AreEqual(val3, useOfSite.SubsectorTVItemID);
               SiteTypeEnum val4 = (SiteTypeEnum)3;
               useOfSite.SiteType = val4;
               Assert.AreEqual(val4, useOfSite.SiteType);
               int val5 = 45;
               useOfSite.Ordinal = val5;
               Assert.AreEqual(val5, useOfSite.Ordinal);
               int val6 = 45;
               useOfSite.StartYear = val6;
               Assert.AreEqual(val6, useOfSite.StartYear);
               int val7 = 45;
               useOfSite.EndYear = val7;
               Assert.AreEqual(val7, useOfSite.EndYear);
               bool val8 = true;
               useOfSite.UseWeight = val8;
               Assert.AreEqual(val8, useOfSite.UseWeight);
               double val9 = 87.9D;
               useOfSite.Weight_perc = val9;
               Assert.AreEqual(val9, useOfSite.Weight_perc);
               bool val10 = true;
               useOfSite.UseEquation = val10;
               Assert.AreEqual(val10, useOfSite.UseEquation);
               double val11 = 87.9D;
               useOfSite.Param1 = val11;
               Assert.AreEqual(val11, useOfSite.Param1);
               double val12 = 87.9D;
               useOfSite.Param2 = val12;
               Assert.AreEqual(val12, useOfSite.Param2);
               double val13 = 87.9D;
               useOfSite.Param3 = val13;
               Assert.AreEqual(val13, useOfSite.Param3);
               double val14 = 87.9D;
               useOfSite.Param4 = val14;
               Assert.AreEqual(val14, useOfSite.Param4);
               DateTime val15 = new DateTime(2010, 3, 4);
               useOfSite.LastUpdateDate_UTC = val15;
               Assert.AreEqual(val15, useOfSite.LastUpdateDate_UTC);
               int val16 = 45;
               useOfSite.LastUpdateContactTVItemID = val16;
               Assert.AreEqual(val16, useOfSite.LastUpdateContactTVItemID);
               string val17 = "Some text";
               useOfSite.SiteTVText = val17;
               Assert.AreEqual(val17, useOfSite.SiteTVText);
               string val18 = "Some text";
               useOfSite.SubsectorTVText = val18;
               Assert.AreEqual(val18, useOfSite.SubsectorTVText);
               string val19 = "Some text";
               useOfSite.LastUpdateContactTVText = val19;
               Assert.AreEqual(val19, useOfSite.LastUpdateContactTVText);
               string val20 = "Some text";
               useOfSite.SiteTypeText = val20;
               Assert.AreEqual(val20, useOfSite.SiteTypeText);
               IEnumerable<ValidationResult> val63 = new List<ValidationResult>().AsEnumerable();
               useOfSite.ValidationResults = val63;
               Assert.AreEqual(val63, useOfSite.ValidationResults);
        }
    }
}
