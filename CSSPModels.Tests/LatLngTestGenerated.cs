/*
 * Auto generated from the CSSPModelsGenerateCode.proj
 *
 * Do not edit this file.
 *
 * Last generated by Charles LeBlanc
 *
 */ 
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
    [TestClass]
    public partial class LatLngTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private LatLng latLng { get; set; }
        #endregion Properties

        #region Constructors
        public LatLngTest()
        {
            latLng = new LatLng();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void LatLng_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Lat", "Lng", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LatLng).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void LatLng_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(LatLng).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void LatLng_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.LatLngLat);
               Assert.IsNotNull(CSSPModelsRes.LatLngLng);
               Assert.IsNotNull(CSSPModelsRes.LatLngHasErrors);
        }
        [TestMethod]
        public void LatLng_Every_Property_Has_Get_Set_Test()
        {
               double val1 = 87.9D;
               latLng.Lat = val1;
               Assert.AreEqual(val1, latLng.Lat);
               double val2 = 87.9D;
               latLng.Lng = val2;
               Assert.AreEqual(val2, latLng.Lng);
               bool val3 = true;
               latLng.HasErrors = val3;
               Assert.AreEqual(val3, latLng.HasErrors);
               IEnumerable<ValidationResult> val12 = new List<ValidationResult>().AsEnumerable();
               latLng.ValidationResults = val12;
               Assert.AreEqual(val12, latLng.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
