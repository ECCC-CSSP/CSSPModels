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
    public partial class ContourPolygonTest
    {
        [TestMethod]
        public void ContourPolygon_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "ContourValue", "Layer", "Depth", "ContourNodeList",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContourPolygon).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void ContourPolygon_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(ContourPolygon).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ContourPolygon_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.ContourPolygonContourValue);
               Assert.IsNotNull(ModelsRes.ContourPolygonLayer);
               Assert.IsNotNull(ModelsRes.ContourPolygonDepth);
               Assert.IsNotNull(ModelsRes.ContourPolygonContourNodeList);
        }
    }
}
