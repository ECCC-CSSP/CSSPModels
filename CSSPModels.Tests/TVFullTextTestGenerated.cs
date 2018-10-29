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
    public partial class TVFullTextTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private TVFullText tVFullText { get; set; }
        #endregion Properties

        #region Constructors
        public TVFullTextTest()
        {
            tVFullText = new TVFullText();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void TVFullText_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVPath", "FullText", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVFullText).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void TVFullText_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVFullText).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVFullText_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               tVFullText.TVPath = val1;
               Assert.AreEqual(val1, tVFullText.TVPath);
               string val2 = "Some text";
               tVFullText.FullText = val2;
               Assert.AreEqual(val2, tVFullText.FullText);
               bool val3 = true;
               tVFullText.HasErrors = val3;
               Assert.AreEqual(val3, tVFullText.HasErrors);
               IEnumerable<ValidationResult> val12 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               tVFullText.ValidationResults = val12;
               Assert.AreEqual(val12, tVFullText.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
