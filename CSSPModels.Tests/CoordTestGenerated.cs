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
    public partial class CoordTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private Coord coord { get; set; }
        #endregion Properties

        #region Constructors
        public CoordTest()
        {
            coord = new Coord();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void Coord_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Lat", "Lng", "Ordinal", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Coord).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void Coord_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(Coord).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void Coord_Every_Property_Has_Get_Set_Test()
        {
               double val1 = 87.9D;
               coord.Lat = val1;
               Assert.AreEqual(val1, coord.Lat);
               double val2 = 87.9D;
               coord.Lng = val2;
               Assert.AreEqual(val2, coord.Lng);
               int val3 = 45;
               coord.Ordinal = val3;
               Assert.AreEqual(val3, coord.Ordinal);
               bool val4 = true;
               coord.HasErrors = val4;
               Assert.AreEqual(val4, coord.HasErrors);
               IEnumerable<ValidationResult> val15 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               coord.ValidationResults = val15;
               Assert.AreEqual(val15, coord.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
