using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Globalization;
using System.Transactions;
using System.Collections.Generic;
using CSSPModels.Resources;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;

namespace CSSPModels.Tests
{
    public partial class PolyPointTest
    {
        [TestMethod]
        public void PolyPoint_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "XCoord", "YCoord", "Z",  }.OrderBy(c => c).ToList();
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
        public void PolyPoint_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(PolyPoint).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void PolyPoint_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.PolyPointXCoord);
               Assert.IsNotNull(ModelsRes.PolyPointYCoord);
               Assert.IsNotNull(ModelsRes.PolyPointZ);
        }
    }
}
