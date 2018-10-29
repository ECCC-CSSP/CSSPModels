/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 */ 
using System;
using System.Text;
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
    [TestClass]
    public partial class ElementLayerTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private ElementLayer elementLayer { get; set; }
        #endregion Properties

        #region Constructors
        public ElementLayerTest()
        {
            elementLayer = new ElementLayer();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void ElementLayer_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Layer", "ZMin", "ZMax", "Element", "HasErrors",  }.OrderBy(c => c).ToList();
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
               Element val4 = new Element();
               elementLayer.Element = val4;
               Assert.AreEqual(val4, elementLayer.Element);
               bool val5 = true;
               elementLayer.HasErrors = val5;
               Assert.AreEqual(val5, elementLayer.HasErrors);
               IEnumerable<ValidationResult> val18 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               elementLayer.ValidationResults = val18;
               Assert.AreEqual(val18, elementLayer.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
