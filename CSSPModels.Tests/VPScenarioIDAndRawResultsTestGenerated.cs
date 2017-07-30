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
    public partial class VPScenarioIDAndRawResultsTest : SetupData
    {
        [TestMethod]
        public void VPScenarioIDAndRawResults_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "VPScenarioID", "RawResults",  }.OrderBy(c => c).ToList();
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
               Assert.IsNotNull(ModelsRes.VPScenarioIDAndRawResultsVPScenarioID);
               Assert.IsNotNull(ModelsRes.VPScenarioIDAndRawResultsRawResults);
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
               IEnumerable<ValidationResult> val9 = new List<ValidationResult>().AsEnumerable();
               vPScenarioIDAndRawResults.ValidationResults = val9;
               Assert.AreEqual(val9, vPScenarioIDAndRawResults.ValidationResults);
        }
    }
}
