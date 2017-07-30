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
    public partial class MapObjTest : SetupData
    {
        [TestMethod]
        public void MapObj_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MapInfoID", "MapInfoDrawType", "CoordList",  }.OrderBy(c => c).ToList();
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
               Assert.IsNotNull(ModelsRes.MapObjMapInfoID);
               Assert.IsNotNull(ModelsRes.MapObjMapInfoDrawType);
               Assert.IsNotNull(ModelsRes.MapObjCoordList);
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
               List<Coord> val7 = new List<Coord>();
               mapObj.CoordList = val7;
               Assert.AreEqual(val7, mapObj.CoordList);
               IEnumerable<ValidationResult> val12 = new List<ValidationResult>().AsEnumerable();
               mapObj.ValidationResults = val12;
               Assert.AreEqual(val12, mapObj.ValidationResults);
        }
    }
}
