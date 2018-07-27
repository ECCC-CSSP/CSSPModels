/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 July 27 04:53
 * by leblancc on WMON01DTCHLEBL2 machine
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
    public partial class MapObjTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private MapObj mapObj { get; set; }
        #endregion Properties

        #region Constructors
        public MapObjTest()
        {
            mapObj = new MapObj();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void MapObj_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MapInfoID", "MapInfoDrawType", "MapInfoDrawTypeText", "CoordList", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapObj).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void MapObj_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MapObj).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MapObj_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.MapObjMapInfoID);
               Assert.IsNotNull(CSSPModelsRes.MapObjMapInfoDrawType);
               Assert.IsNotNull(CSSPModelsRes.MapObjMapInfoDrawTypeText);
               Assert.IsNotNull(CSSPModelsRes.MapObjCoordList);
               Assert.IsNotNull(CSSPModelsRes.MapObjHasErrors);
        }
        [TestMethod]
        public void MapObj_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mapObj.MapInfoID = val1;
               Assert.AreEqual(val1, mapObj.MapInfoID);
               MapInfoDrawTypeEnum val2 = (MapInfoDrawTypeEnum)3;
               mapObj.MapInfoDrawType = val2;
               Assert.AreEqual(val2, mapObj.MapInfoDrawType);
               string val3 = "Some text";
               mapObj.MapInfoDrawTypeText = val3;
               Assert.AreEqual(val3, mapObj.MapInfoDrawTypeText);
               bool val5 = true;
               mapObj.HasErrors = val5;
               Assert.AreEqual(val5, mapObj.HasErrors);
               List<Coord> val10 = new List<Coord>();
               mapObj.CoordList = val10;
               Assert.AreEqual(val10, mapObj.CoordList);
               IEnumerable<ValidationResult> val18 = new List<ValidationResult>().AsEnumerable();
               mapObj.ValidationResults = val18;
               Assert.AreEqual(val18, mapObj.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
