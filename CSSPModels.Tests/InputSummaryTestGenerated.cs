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
    public partial class InputSummaryTest : SetupData
    {
        [TestMethod]
        public void InputSummary_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Error", "Summary",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(InputSummary).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void InputSummary_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(InputSummary).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void InputSummary_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.InputSummaryError);
               Assert.IsNotNull(ModelsRes.InputSummarySummary);
        }
        [TestMethod]
        public void InputSummary_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               inputSummary.Error = val1;
               Assert.AreEqual(val1, inputSummary.Error);
               string val2 = "Some text";
               inputSummary.Summary = val2;
               Assert.AreEqual(val2, inputSummary.Summary);
               IEnumerable<ValidationResult> val9 = new List<ValidationResult>().AsEnumerable();
               inputSummary.ValidationResults = val9;
               Assert.AreEqual(val9, inputSummary.ValidationResults);
        }
    }
}
