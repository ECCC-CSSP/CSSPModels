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
    public partial class ElementLayerTest : SetupData
    {
        [TestMethod]
        public void ElementLayer_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Layer", "ZMin", "ZMax", "Element",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ElementLayer).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void ElementLayer_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ElementLayer).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ElementLayer_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.ElementLayerLayer);
               Assert.IsNotNull(ModelsRes.ElementLayerZMin);
               Assert.IsNotNull(ModelsRes.ElementLayerZMax);
               Assert.IsNotNull(ModelsRes.ElementLayerElement);
        }
        [TestMethod]
        public void ElementLayer_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               elementLayer.Layer = val1;
               Assert.AreEqual(val1, elementLayer.Layer);
               double val2 = 87.9D;
               elementLayer.ZMin = val2;
               Assert.AreEqual(val2, elementLayer.ZMin);
               double val3 = 87.9D;
               elementLayer.ZMax = val3;
               Assert.AreEqual(val3, elementLayer.ZMax);
               Element val9 = new Element();
               elementLayer.Element = val9;
               Assert.AreEqual(val9, elementLayer.Element);
               IEnumerable<ValidationResult> val15 = new List<ValidationResult>().AsEnumerable();
               elementLayer.ValidationResults = val15;
               Assert.AreEqual(val15, elementLayer.ValidationResults);
        }
    }
}
