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
    public partial class AppTaskParameterTest : SetupData
    {
        [TestMethod]
        public void AppTaskParameter_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Name", "Value", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AppTaskParameter).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void AppTaskParameter_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(AppTaskParameter).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void AppTaskParameter_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.AppTaskParameterName);
               Assert.IsNotNull(ModelsRes.AppTaskParameterValue);
               Assert.IsNotNull(ModelsRes.AppTaskParameterHasErrors);
        }
        [TestMethod]
        public void AppTaskParameter_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               appTaskParameter.Name = val1;
               Assert.AreEqual(val1, appTaskParameter.Name);
               string val2 = "Some text";
               appTaskParameter.Value = val2;
               Assert.AreEqual(val2, appTaskParameter.Value);
               bool val3 = true;
               appTaskParameter.HasErrors = val3;
               Assert.AreEqual(val3, appTaskParameter.HasErrors);
               IEnumerable<ValidationResult> val12 = new List<ValidationResult>().AsEnumerable();
               appTaskParameter.ValidationResults = val12;
               Assert.AreEqual(val12, appTaskParameter.ValidationResults);
        }
    }
}
