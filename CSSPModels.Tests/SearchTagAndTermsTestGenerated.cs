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
    public partial class SearchTagAndTermsTest : SetupData
    {
        [TestMethod]
        public void SearchTagAndTerms_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "SearchTag", "SearchTermList",  }.OrderBy(c => c).ToList();
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
               Assert.IsNotNull(ModelsRes.SearchTagAndTermsSearchTag);
               Assert.IsNotNull(ModelsRes.SearchTagAndTermsSearchTermList);
        }
        [TestMethod]
        public void SearchTagAndTerms_Every_Property_Has_Get_Set_Test()
        {
               SearchTagEnum val1 = (SearchTagEnum)3;
               searchTagAndTerms.SearchTag = val1;
               Assert.AreEqual(val1, searchTagAndTerms.SearchTag);
               List<String> val5 = new List<String>();
               searchTagAndTerms.SearchTermList = val5;
               Assert.AreEqual(val5, searchTagAndTerms.SearchTermList);
               IEnumerable<ValidationResult> val9 = new List<ValidationResult>().AsEnumerable();
               searchTagAndTerms.ValidationResults = val9;
               Assert.AreEqual(val9, searchTagAndTerms.ValidationResults);
        }
    }
}
