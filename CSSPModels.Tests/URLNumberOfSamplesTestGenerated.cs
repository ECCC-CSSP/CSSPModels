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
    public partial class URLNumberOfSamplesTest : SetupData
    {
        [TestMethod]
        public void URLNumberOfSamples_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "url", "NumberOfSamples",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(URLNumberOfSamples).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void URLNumberOfSamples_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(URLNumberOfSamples).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void URLNumberOfSamples_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.URLNumberOfSamplesurl);
               Assert.IsNotNull(ModelsRes.URLNumberOfSamplesNumberOfSamples);
        }
        [TestMethod]
        public void URLNumberOfSamples_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               uRLNumberOfSamples.url = val1;
               Assert.AreEqual(val1, uRLNumberOfSamples.url);
               int val2 = 45;
               uRLNumberOfSamples.NumberOfSamples = val2;
               Assert.AreEqual(val2, uRLNumberOfSamples.NumberOfSamples);
               IEnumerable<ValidationResult> val9 = new List<ValidationResult>().AsEnumerable();
               uRLNumberOfSamples.ValidationResults = val9;
               Assert.AreEqual(val9, uRLNumberOfSamples.ValidationResults);
        }
    }
}
