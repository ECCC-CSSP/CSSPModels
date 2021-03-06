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
    public partial class LastUpdateAndContactTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private LastUpdateAndContact lastUpdateAndContact { get; set; }
        #endregion Properties

        #region Constructors
        public LastUpdateAndContactTest()
        {
            lastUpdateAndContact = new LastUpdateAndContact();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void LastUpdateAndContact_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateAndContactDate_UTC", "LastUpdateAndContactTVItemID", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LastUpdateAndContact).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void LastUpdateAndContact_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(LastUpdateAndContact).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void LastUpdateAndContact_Every_Property_Has_Get_Set_Test()
        {
               DateTime val1 = new DateTime(2010, 3, 4);
               lastUpdateAndContact.LastUpdateAndContactDate_UTC = val1;
               Assert.AreEqual(val1, lastUpdateAndContact.LastUpdateAndContactDate_UTC);
               int val2 = 45;
               lastUpdateAndContact.LastUpdateAndContactTVItemID = val2;
               Assert.AreEqual(val2, lastUpdateAndContact.LastUpdateAndContactTVItemID);
               bool val3 = true;
               lastUpdateAndContact.HasErrors = val3;
               Assert.AreEqual(val3, lastUpdateAndContact.HasErrors);
               IEnumerable<ValidationResult> val12 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               lastUpdateAndContact.ValidationResults = val12;
               Assert.AreEqual(val12, lastUpdateAndContact.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
