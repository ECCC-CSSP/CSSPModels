/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 July 28 01:58
 * by Charles on CHARLES-PC machine
 *
 */ 
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
    [TestClass]
    public partial class SearchTagAndTermsTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private SearchTagAndTerms searchTagAndTerms { get; set; }
        #endregion Properties

        #region Constructors
        public SearchTagAndTermsTest()
        {
            searchTagAndTerms = new SearchTagAndTerms();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void SearchTagAndTerms_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "SearchTag", "SearchTagText", "SearchTermList", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SearchTagAndTerms).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void SearchTagAndTerms_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(SearchTagAndTerms).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void SearchTagAndTerms_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.SearchTagAndTermsSearchTag);
               Assert.IsNotNull(CSSPModelsRes.SearchTagAndTermsSearchTagText);
               Assert.IsNotNull(CSSPModelsRes.SearchTagAndTermsSearchTermList);
               Assert.IsNotNull(CSSPModelsRes.SearchTagAndTermsHasErrors);
        }
        [TestMethod]
        public void SearchTagAndTerms_Every_Property_Has_Get_Set_Test()
        {
               SearchTagEnum val1 = (SearchTagEnum)3;
               searchTagAndTerms.SearchTag = val1;
               Assert.AreEqual(val1, searchTagAndTerms.SearchTag);
               string val2 = "Some text";
               searchTagAndTerms.SearchTagText = val2;
               Assert.AreEqual(val2, searchTagAndTerms.SearchTagText);
               bool val4 = true;
               searchTagAndTerms.HasErrors = val4;
               Assert.AreEqual(val4, searchTagAndTerms.HasErrors);
               List<String> val8 = new List<String>();
               searchTagAndTerms.SearchTermList = val8;
               Assert.AreEqual(val8, searchTagAndTerms.SearchTermList);
               IEnumerable<ValidationResult> val15 = new List<ValidationResult>().AsEnumerable();
               searchTagAndTerms.ValidationResults = val15;
               Assert.AreEqual(val15, searchTagAndTerms.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
