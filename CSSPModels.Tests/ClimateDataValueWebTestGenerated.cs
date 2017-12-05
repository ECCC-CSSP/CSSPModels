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
    public partial class ClimateDataValueWebTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private ClimateDataValueWeb climateDataValueWeb { get; set; }
        #endregion Properties

        #region Constructors
        public ClimateDataValueWebTest()
        {
            climateDataValueWeb = new ClimateDataValueWeb();
        }
        #endregion Constructors

        #region Tests
        [TestMethod]
        public void ClimateDataValueWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactTVText", "StorageDataTypeEnumText",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateDataValueWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void ClimateDataValueWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ClimateDataValueWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ClimateDataValueWeb_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.ClimateDataValueWebLastUpdateContactTVText);
               Assert.IsNotNull(CSSPModelsRes.ClimateDataValueWebStorageDataTypeEnumText);
        }
        [TestMethod]
        public void ClimateDataValueWeb_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               climateDataValueWeb.LastUpdateContactTVText = val1;
               Assert.AreEqual(val1, climateDataValueWeb.LastUpdateContactTVText);
               string val2 = "Some text";
               climateDataValueWeb.StorageDataTypeEnumText = val2;
               Assert.AreEqual(val2, climateDataValueWeb.StorageDataTypeEnumText);
        }
        #endregion Tests
    }
}