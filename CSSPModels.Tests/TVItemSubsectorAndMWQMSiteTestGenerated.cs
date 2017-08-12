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
            List<string> propNameList = new List<string>() { "TVItemSubsector", "TVItemMWQMSiteList", "TVItemMWQMSiteDuplicate", "HasErrors",  }.OrderBy(c => c).ToList();
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
               Assert.IsNotNull(ModelsRes.TVItemSubsectorAndMWQMSiteHasErrors);
        }
        [TestMethod]
        public void TVItemSubsectorAndMWQMSite_Every_Property_Has_Get_Set_Test()
        {
               bool val4 = true;
               tVItemSubsectorAndMWQMSite.HasErrors = val4;
               Assert.AreEqual(val4, tVItemSubsectorAndMWQMSite.HasErrors);
               TVItem val6 = new TVItem();
               tVItemSubsectorAndMWQMSite.TVItemSubsector = val6;
               Assert.AreEqual(val6, tVItemSubsectorAndMWQMSite.TVItemSubsector);
               List<TVItem> val7 = new List<TVItem>();
               tVItemSubsectorAndMWQMSite.TVItemMWQMSiteList = val7;
               Assert.AreEqual(val7, tVItemSubsectorAndMWQMSite.TVItemMWQMSiteList);
               TVItem val8 = new TVItem();
               tVItemSubsectorAndMWQMSite.TVItemMWQMSiteDuplicate = val8;
               Assert.AreEqual(val8, tVItemSubsectorAndMWQMSite.TVItemMWQMSiteDuplicate);
               IEnumerable<ValidationResult> val15 = new List<ValidationResult>().AsEnumerable();
               tVItemSubsectorAndMWQMSite.ValidationResults = val15;
               Assert.AreEqual(val15, tVItemSubsectorAndMWQMSite.ValidationResults);
        }
    }
}
