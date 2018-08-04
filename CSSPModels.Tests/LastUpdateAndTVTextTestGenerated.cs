/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by Charles on CHARLES-PC machine
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
    public partial class LastUpdateAndTVTextTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private LastUpdateAndTVText lastUpdateAndTVText { get; set; }
        #endregion Properties

        #region Constructors
        public LastUpdateAndTVTextTest()
        {
            lastUpdateAndTVText = new LastUpdateAndTVText();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void LastUpdateAndTVText_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Error", "LastUpdateAndTVTextDate_UTC", "LastUpdateDate_Local", "TVText", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LastUpdateAndTVText).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void LastUpdateAndTVText_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(LastUpdateAndTVText).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void LastUpdateAndTVText_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               lastUpdateAndTVText.Error = val1;
               Assert.AreEqual(val1, lastUpdateAndTVText.Error);
               DateTime val2 = new DateTime(2010, 3, 4);
               lastUpdateAndTVText.LastUpdateAndTVTextDate_UTC = val2;
               Assert.AreEqual(val2, lastUpdateAndTVText.LastUpdateAndTVTextDate_UTC);
               DateTime val3 = new DateTime(2010, 3, 4);
               lastUpdateAndTVText.LastUpdateDate_Local = val3;
               Assert.AreEqual(val3, lastUpdateAndTVText.LastUpdateDate_Local);
               string val4 = "Some text";
               lastUpdateAndTVText.TVText = val4;
               Assert.AreEqual(val4, lastUpdateAndTVText.TVText);
               bool val5 = true;
               lastUpdateAndTVText.HasErrors = val5;
               Assert.AreEqual(val5, lastUpdateAndTVText.HasErrors);
               IEnumerable<ValidationResult> val18 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               lastUpdateAndTVText.ValidationResults = val18;
               Assert.AreEqual(val18, lastUpdateAndTVText.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
