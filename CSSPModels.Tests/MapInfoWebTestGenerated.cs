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
    public partial class MapInfoWebTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private MapInfoWeb mapInfoWeb { get; set; }
        #endregion Properties

        #region Constructors
        public MapInfoWebTest()
        {
            mapInfoWeb = new MapInfoWeb();
        }
        #endregion Constructors

        #region Tests
        [TestMethod]
        public void MapInfoWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVText", "LastUpdateContactTVText", "TVTypeText", "MapInfoDrawTypeText",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapInfoWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void MapInfoWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MapInfoWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MapInfoWeb_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.MapInfoWebTVText);
               Assert.IsNotNull(CSSPModelsRes.MapInfoWebLastUpdateContactTVText);
               Assert.IsNotNull(CSSPModelsRes.MapInfoWebTVTypeText);
               Assert.IsNotNull(CSSPModelsRes.MapInfoWebMapInfoDrawTypeText);
        }
        [TestMethod]
        public void MapInfoWeb_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mapInfoWeb.TVText = val1;
               Assert.AreEqual(val1, mapInfoWeb.TVText);
               string val2 = "Some text";
               mapInfoWeb.LastUpdateContactTVText = val2;
               Assert.AreEqual(val2, mapInfoWeb.LastUpdateContactTVText);
               string val3 = "Some text";
               mapInfoWeb.TVTypeText = val3;
               Assert.AreEqual(val3, mapInfoWeb.TVTypeText);
               string val4 = "Some text";
               mapInfoWeb.MapInfoDrawTypeText = val4;
               Assert.AreEqual(val4, mapInfoWeb.MapInfoDrawTypeText);
        }
        #endregion Tests
    }
}