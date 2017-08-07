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
    public partial class PolSourceObsInfoChildTest : SetupData
    {
        [TestMethod]
        public void PolSourceObsInfoChild_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "PolSourceObsInfo", "PolSourceObsInfoChildStart", "PolSourceObsInfoText", "PolSourceObsInfoChildStartText",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceObsInfoChild).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void PolSourceObsInfoChild_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(PolSourceObsInfoChild).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void PolSourceObsInfoChild_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.PolSourceObsInfoChildPolSourceObsInfo);
               Assert.IsNotNull(ModelsRes.PolSourceObsInfoChildPolSourceObsInfoChildStart);
               Assert.IsNotNull(ModelsRes.PolSourceObsInfoChildPolSourceObsInfoText);
               Assert.IsNotNull(ModelsRes.PolSourceObsInfoChildPolSourceObsInfoChildStartText);
        }
        [TestMethod]
        public void PolSourceObsInfoChild_Every_Property_Has_Get_Set_Test()
        {
               PolSourceObsInfoEnum val1 = (PolSourceObsInfoEnum)3;
               polSourceObsInfoChild.PolSourceObsInfo = val1;
               Assert.AreEqual(val1, polSourceObsInfoChild.PolSourceObsInfo);
               PolSourceObsInfoEnum val2 = (PolSourceObsInfoEnum)3;
               polSourceObsInfoChild.PolSourceObsInfoChildStart = val2;
               Assert.AreEqual(val2, polSourceObsInfoChild.PolSourceObsInfoChildStart);
               string val3 = "Some text";
               polSourceObsInfoChild.PolSourceObsInfoText = val3;
               Assert.AreEqual(val3, polSourceObsInfoChild.PolSourceObsInfoText);
               string val4 = "Some text";
               polSourceObsInfoChild.PolSourceObsInfoChildStartText = val4;
               Assert.AreEqual(val4, polSourceObsInfoChild.PolSourceObsInfoChildStartText);
               IEnumerable<ValidationResult> val15 = new List<ValidationResult>().AsEnumerable();
               polSourceObsInfoChild.ValidationResults = val15;
               Assert.AreEqual(val15, polSourceObsInfoChild.ValidationResults);
        }
    }
}
