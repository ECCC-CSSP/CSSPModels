/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 */ 
using System;
using System.Text;
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
    [TestClass]
    public partial class TVItemSubsectorAndMWQMSiteTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private TVItemSubsectorAndMWQMSite tVItemSubsectorAndMWQMSite { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemSubsectorAndMWQMSiteTest()
        {
            tVItemSubsectorAndMWQMSite = new TVItemSubsectorAndMWQMSite();
        }
        #endregion Constructors

        #region Tests Functions public
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
        public void TVItemSubsectorAndMWQMSite_Every_Property_Has_Get_Set_Test()
        {
               TVItem val1 = new TVItem();
               tVItemSubsectorAndMWQMSite.TVItemSubsector = val1;
               Assert.AreEqual(val1, tVItemSubsectorAndMWQMSite.TVItemSubsector);
               List<TVItem> val2 = new List<TVItem>() { new TVItem(), new TVItem() };
               tVItemSubsectorAndMWQMSite.TVItemMWQMSiteList = val2;
               Assert.AreEqual(val2, tVItemSubsectorAndMWQMSite.TVItemMWQMSiteList);
               TVItem val3 = new TVItem();
               tVItemSubsectorAndMWQMSite.TVItemMWQMSiteDuplicate = val3;
               Assert.AreEqual(val3, tVItemSubsectorAndMWQMSite.TVItemMWQMSiteDuplicate);
               bool val4 = true;
               tVItemSubsectorAndMWQMSite.HasErrors = val4;
               Assert.AreEqual(val4, tVItemSubsectorAndMWQMSite.HasErrors);
               IEnumerable<ValidationResult> val15 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               tVItemSubsectorAndMWQMSite.ValidationResults = val15;
               Assert.AreEqual(val15, tVItemSubsectorAndMWQMSite.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
