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
    public partial class VectorTest : SetupData
    {
        [TestMethod]
        public void Vector_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "StartNode", "EndNode", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Vector).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void Vector_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(Vector).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void Vector_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.VectorStartNode);
               Assert.IsNotNull(ModelsRes.VectorEndNode);
               Assert.IsNotNull(ModelsRes.VectorHasErrors);
        }
        [TestMethod]
        public void Vector_Every_Property_Has_Get_Set_Test()
        {
               bool val3 = true;
               vector.HasErrors = val3;
               Assert.AreEqual(val3, vector.HasErrors);
               Node val5 = new Node();
               vector.StartNode = val5;
               Assert.AreEqual(val5, vector.StartNode);
               Node val6 = new Node();
               vector.EndNode = val6;
               Assert.AreEqual(val6, vector.EndNode);
               IEnumerable<ValidationResult> val12 = new List<ValidationResult>().AsEnumerable();
               vector.ValidationResults = val12;
               Assert.AreEqual(val12, vector.ValidationResults);
        }
    }
}
