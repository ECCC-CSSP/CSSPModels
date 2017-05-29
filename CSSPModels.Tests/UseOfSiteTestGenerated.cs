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
    public partial class UseOfSiteTest
    {
        [TestMethod]
        public void UseOfSite_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "UseOfSiteID", "SiteTVItemID", "SubsectorTVItemID", "SiteType", "Ordinal", "StartYear", "EndYear", "UseWeight", "Weight_perc", "UseEquation", "Param1", "Param2", "Param3", "Param4", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (IProperty propertyType in entityType.GetProperties().OrderBy(c => c.Name))
            {
                Assert.AreEqual(propNameList[index], propertyType.Name);
                index += 1;
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
        public void UseOfSite_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "SiteTVItem", "SubsectorTVItem",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (string foreignName in (from c in entityType.GetForeignKeys() orderby c.DependentToPrincipal.Name select c.DependentToPrincipal.Name))
            {
                Assert.AreEqual(foreignNameList[index], foreignName);
                index += 1;
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
        public void UseOfSite_Has_ValidationResults_OK()
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
               Assert.IsNotNull(ModelsRes.UseOfSiteSiteTVItem);
               Assert.IsNotNull(ModelsRes.UseOfSiteSubsectorTVItem);
        }
    }
}
