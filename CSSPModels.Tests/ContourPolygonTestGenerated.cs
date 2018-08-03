/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by leblancc on WMON01DTCHLEBL2 machine
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
    public partial class ContourPolygonTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private ContourPolygon contourPolygon { get; set; }
        #endregion Properties

        #region Constructors
        public ContourPolygonTest()
        {
            contourPolygon = new ContourPolygon();
        }
        #endregion Constructors

        #region Tests Functions public
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
               List<Node> val4 = new List<Node>() { new Node(), new Node() };
               contourPolygon.ContourNodeList = val4;
               Assert.AreEqual(val4, contourPolygon.ContourNodeList);
               bool val5 = true;
               contourPolygon.HasErrors = val5;
               Assert.AreEqual(val5, contourPolygon.HasErrors);
               IEnumerable<ValidationResult> val18 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               contourPolygon.ValidationResults = val18;
               Assert.AreEqual(val18, contourPolygon.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
