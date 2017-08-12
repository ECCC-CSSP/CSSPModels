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
    public partial class ContourPolygonTest : SetupData
    {
        [TestMethod]
        public void ContourPolygon_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ContourValue", "Layer", "Depth", "ContourNodeList", "HasErrors",  }.OrderBy(c => c).ToList();
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
        public void ContourPolygon_Has_ValidationResults_Test()
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
               Assert.IsNotNull(ModelsRes.ContourPolygonHasErrors);
        }
        [TestMethod]
        public void ContourPolygon_Every_Property_Has_Get_Set_Test()
        {
               double val1 = 87.9D;
               contourPolygon.ContourValue = val1;
               Assert.AreEqual(val1, contourPolygon.ContourValue);
               int val2 = 45;
               contourPolygon.Layer = val2;
               Assert.AreEqual(val2, contourPolygon.Layer);
               double val3 = 87.9D;
               contourPolygon.Depth = val3;
               Assert.AreEqual(val3, contourPolygon.Depth);
               bool val5 = true;
               contourPolygon.HasErrors = val5;
               Assert.AreEqual(val5, contourPolygon.HasErrors);
               List<Node> val10 = new List<Node>();
               contourPolygon.ContourNodeList = val10;
               Assert.AreEqual(val10, contourPolygon.ContourNodeList);
               IEnumerable<ValidationResult> val18 = new List<ValidationResult>().AsEnumerable();
               contourPolygon.ValidationResults = val18;
               Assert.AreEqual(val18, contourPolygon.ValidationResults);
        }
    }
}
