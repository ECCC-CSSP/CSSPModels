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
    public partial class TideDataValueWebTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private TideDataValueWeb tideDataValueWeb { get; set; }
        #endregion Properties

        #region Constructors
        public TideDataValueWebTest()
        {
            tideDataValueWeb = new TideDataValueWeb();
        }
        #endregion Constructors

        #region Tests
        [TestMethod]
        public void TideDataValueWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TideSiteTVText", "LastUpdateContactTVText", "TideDataTypeText", "StorageDataTypeText", "TideStartText", "TideEndText",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideDataValueWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void TideDataValueWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TideDataValueWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TideDataValueWeb_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.TideDataValueWebTideSiteTVText);
               Assert.IsNotNull(CSSPModelsRes.TideDataValueWebLastUpdateContactTVText);
               Assert.IsNotNull(CSSPModelsRes.TideDataValueWebTideDataTypeText);
               Assert.IsNotNull(CSSPModelsRes.TideDataValueWebStorageDataTypeText);
               Assert.IsNotNull(CSSPModelsRes.TideDataValueWebTideStartText);
               Assert.IsNotNull(CSSPModelsRes.TideDataValueWebTideEndText);
        }
        [TestMethod]
        public void TideDataValueWeb_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               tideDataValueWeb.TideSiteTVText = val1;
               Assert.AreEqual(val1, tideDataValueWeb.TideSiteTVText);
               string val2 = "Some text";
               tideDataValueWeb.LastUpdateContactTVText = val2;
               Assert.AreEqual(val2, tideDataValueWeb.LastUpdateContactTVText);
               string val3 = "Some text";
               tideDataValueWeb.TideDataTypeText = val3;
               Assert.AreEqual(val3, tideDataValueWeb.TideDataTypeText);
               string val4 = "Some text";
               tideDataValueWeb.StorageDataTypeText = val4;
               Assert.AreEqual(val4, tideDataValueWeb.StorageDataTypeText);
               string val5 = "Some text";
               tideDataValueWeb.TideStartText = val5;
               Assert.AreEqual(val5, tideDataValueWeb.TideStartText);
               string val6 = "Some text";
               tideDataValueWeb.TideEndText = val6;
               Assert.AreEqual(val6, tideDataValueWeb.TideEndText);
        }
        #endregion Tests
    }
}
