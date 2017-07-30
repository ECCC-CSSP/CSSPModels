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
    public partial class TVItemSubsectorAndMWQMSiteTest : SetupData
    {
        [TestMethod]
        public void TVItemSubsectorAndMWQMSite_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVItemSubsector", "TVItemMWQMSiteList", "TVItemMWQMSiteDuplicate",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemSubsectorAndMWQMSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void TVItemSubsectorAndMWQMSite_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVItemSubsectorAndMWQMSite).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVItemSubsectorAndMWQMSite_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.TVItemSubsectorAndMWQMSiteTVItemSubsector);
               Assert.IsNotNull(ModelsRes.TVItemSubsectorAndMWQMSiteTVItemMWQMSiteList);
               Assert.IsNotNull(ModelsRes.TVItemSubsectorAndMWQMSiteTVItemMWQMSiteDuplicate);
        }
        [TestMethod]
        public void TVItemSubsectorAndMWQMSite_Every_Property_Has_Get_Set_Test()
        {
               TVItem val5 = new TVItem();
               tVItemSubsectorAndMWQMSite.TVItemSubsector = val5;
               Assert.AreEqual(val5, tVItemSubsectorAndMWQMSite.TVItemSubsector);
               List<TVItem> val6 = new List<TVItem>();
               tVItemSubsectorAndMWQMSite.TVItemMWQMSiteList = val6;
               Assert.AreEqual(val6, tVItemSubsectorAndMWQMSite.TVItemMWQMSiteList);
               TVItem val7 = new TVItem();
               tVItemSubsectorAndMWQMSite.TVItemMWQMSiteDuplicate = val7;
               Assert.AreEqual(val7, tVItemSubsectorAndMWQMSite.TVItemMWQMSiteDuplicate);
               IEnumerable<ValidationResult> val12 = new List<ValidationResult>().AsEnumerable();
               tVItemSubsectorAndMWQMSite.ValidationResults = val12;
               Assert.AreEqual(val12, tVItemSubsectorAndMWQMSite.ValidationResults);
        }
    }
}
