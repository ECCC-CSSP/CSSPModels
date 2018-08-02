/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by leblancc on WMON01DTCHLEBL2 machine
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
    public partial class SearchTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private Search search { get; set; }
        #endregion Properties

        #region Constructors
        public SearchTest()
        {
            search = new Search();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void Search_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "value", "id", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Search).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void Search_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(Search).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void Search_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.Searchvalue);
               Assert.IsNotNull(CSSPModelsRes.Searchid);
               Assert.IsNotNull(CSSPModelsRes.SearchHasErrors);
        }
        [TestMethod]
        public void Search_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               search.value = val1;
               Assert.AreEqual(val1, search.value);
               int val2 = 45;
               search.id = val2;
               Assert.AreEqual(val2, search.id);
               bool val3 = true;
               search.HasErrors = val3;
               Assert.AreEqual(val3, search.HasErrors);
               IEnumerable<ValidationResult> val12 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               search.ValidationResults = val12;
               Assert.AreEqual(val12, search.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
