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
    public partial class URLNumberOfSamplesTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private URLNumberOfSamples uRLNumberOfSamples { get; set; }
        #endregion Properties

        #region Constructors
        public URLNumberOfSamplesTest()
        {
            uRLNumberOfSamples = new URLNumberOfSamples();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void URLNumberOfSamples_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "url", "NumberOfSamples", "HasErrors",  }.OrderBy(c => c).ToList();
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
        public void URLNumberOfSamples_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               uRLNumberOfSamples.url = val1;
               Assert.AreEqual(val1, uRLNumberOfSamples.url);
               int val2 = 45;
               uRLNumberOfSamples.NumberOfSamples = val2;
               Assert.AreEqual(val2, uRLNumberOfSamples.NumberOfSamples);
               bool val3 = true;
               uRLNumberOfSamples.HasErrors = val3;
               Assert.AreEqual(val3, uRLNumberOfSamples.HasErrors);
               IEnumerable<ValidationResult> val12 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               uRLNumberOfSamples.ValidationResults = val12;
               Assert.AreEqual(val12, uRLNumberOfSamples.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
