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
    public partial class DataPathOfTideTest : SetupData
    {
        [TestMethod]
        public void DataPathOfTide_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Text", "WebTideDataSet",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(DataPathOfTide).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void DataPathOfTide_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(DataPathOfTide).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void DataPathOfTide_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.DataPathOfTideText);
               Assert.IsNotNull(ModelsRes.DataPathOfTideWebTideDataSet);
        }
        [TestMethod]
        public void DataPathOfTide_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               dataPathOfTide.Text = val1;
               Assert.AreEqual(val1, dataPathOfTide.Text);
               WebTideDataSetEnum val2 = (WebTideDataSetEnum)3;
               dataPathOfTide.WebTideDataSet = val2;
               Assert.AreEqual(val2, dataPathOfTide.WebTideDataSet);
               IEnumerable<ValidationResult> val9 = new List<ValidationResult>().AsEnumerable();
               dataPathOfTide.ValidationResults = val9;
               Assert.AreEqual(val9, dataPathOfTide.ValidationResults);
        }
    }
}
