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
    public partial class PolyPointTest : SetupData
    {
        [TestMethod]
        public void PolyPoint_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "XCoord", "YCoord", "Z", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolyPoint).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void PolyPoint_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(PolyPoint).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void PolyPoint_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.PolyPointXCoord);
               Assert.IsNotNull(ModelsRes.PolyPointYCoord);
               Assert.IsNotNull(ModelsRes.PolyPointZ);
               Assert.IsNotNull(ModelsRes.PolyPointHasErrors);
        }
        [TestMethod]
        public void PolyPoint_Every_Property_Has_Get_Set_Test()
        {
               double val1 = 87.9D;
               polyPoint.XCoord = val1;
               Assert.AreEqual(val1, polyPoint.XCoord);
               double val2 = 87.9D;
               polyPoint.YCoord = val2;
               Assert.AreEqual(val2, polyPoint.YCoord);
               double val3 = 87.9D;
               polyPoint.Z = val3;
               Assert.AreEqual(val3, polyPoint.Z);
               bool val4 = true;
               polyPoint.HasErrors = val4;
               Assert.AreEqual(val4, polyPoint.HasErrors);
               IEnumerable<ValidationResult> val15 = new List<ValidationResult>().AsEnumerable();
               polyPoint.ValidationResults = val15;
               Assert.AreEqual(val15, polyPoint.ValidationResults);
        }
    }
}
