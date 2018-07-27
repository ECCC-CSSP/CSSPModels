/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 July 27 04:53
 * by leblancc on WMON01DTCHLEBL2 machine
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
    public partial class VPScenarioIDAndRawResultsTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private VPScenarioIDAndRawResults vPScenarioIDAndRawResults { get; set; }
        #endregion Properties

        #region Constructors
        public VPScenarioIDAndRawResultsTest()
        {
            vPScenarioIDAndRawResults = new VPScenarioIDAndRawResults();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void VPScenarioIDAndRawResults_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "VPScenarioID", "RawResults", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPScenarioIDAndRawResults).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void VPScenarioIDAndRawResults_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(VPScenarioIDAndRawResults).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void VPScenarioIDAndRawResults_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.VPScenarioIDAndRawResultsVPScenarioID);
               Assert.IsNotNull(CSSPModelsRes.VPScenarioIDAndRawResultsRawResults);
               Assert.IsNotNull(CSSPModelsRes.VPScenarioIDAndRawResultsHasErrors);
        }
        [TestMethod]
        public void VPScenarioIDAndRawResults_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               vPScenarioIDAndRawResults.VPScenarioID = val1;
               Assert.AreEqual(val1, vPScenarioIDAndRawResults.VPScenarioID);
               string val2 = "Some text";
               vPScenarioIDAndRawResults.RawResults = val2;
               Assert.AreEqual(val2, vPScenarioIDAndRawResults.RawResults);
               bool val3 = true;
               vPScenarioIDAndRawResults.HasErrors = val3;
               Assert.AreEqual(val3, vPScenarioIDAndRawResults.HasErrors);
               IEnumerable<ValidationResult> val12 = new List<ValidationResult>().AsEnumerable();
               vPScenarioIDAndRawResults.ValidationResults = val12;
               Assert.AreEqual(val12, vPScenarioIDAndRawResults.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
