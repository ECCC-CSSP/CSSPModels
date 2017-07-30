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
    public partial class MapInfoPointTest : SetupData
    {
        [TestMethod]
        public void MapInfoPoint_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MapInfoPointID", "MapInfoID", "Ordinal", "Lat", "Lng", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.MapInfoPoint).GetProperties().OrderBy(c => c.Name))
            {
                if (!propertyInfo.GetGetMethod().IsVirtual
                    && propertyInfo.Name != "ValidationResults"
                    && !propertyInfo.CustomAttributes.Where(c => c.AttributeType.Name.Contains("NotMappedAttribute")).Any())
                {
                    Assert.AreEqual(propNameList[index], propertyInfo.Name);
                    index += 1;
                }
            }

            Assert.AreEqual(propNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapInfoPoint).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                foreach (CustomAttributeData customAttributeData in propertyInfo.CustomAttributes)
                {
                    if (customAttributeData.AttributeType.Name == "NotMappedAttribute")
                    {
                        Assert.AreEqual(propertyInfo.Name, propNameNotMappedList[index]);
                        index += 1;
                    }
                }
            }

            Assert.AreEqual(propNameNotMappedList.Count, index);

        }
        [TestMethod]
        public void MapInfoPoint_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() { "MapInfo",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapInfoPoint).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapInfoPoint).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                if (propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameCollectionList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameCollectionList.Count, index);

        }
        [TestMethod]
        public void MapInfoPoint_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MapInfoPoint).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MapInfoPoint_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.MapInfoPointMapInfoPointID);
               Assert.IsNotNull(ModelsRes.MapInfoPointMapInfoID);
               Assert.IsNotNull(ModelsRes.MapInfoPointOrdinal);
               Assert.IsNotNull(ModelsRes.MapInfoPointLat);
               Assert.IsNotNull(ModelsRes.MapInfoPointLng);
               Assert.IsNotNull(ModelsRes.MapInfoPointLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.MapInfoPointLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.MapInfoPointMapInfo);
        }
        [TestMethod]
        public void MapInfoPoint_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mapInfoPoint.MapInfoPointID = val1;
               Assert.AreEqual(val1, mapInfoPoint.MapInfoPointID);
               int val2 = 45;
               mapInfoPoint.MapInfoID = val2;
               Assert.AreEqual(val2, mapInfoPoint.MapInfoID);
               int val3 = 45;
               mapInfoPoint.Ordinal = val3;
               Assert.AreEqual(val3, mapInfoPoint.Ordinal);
               double val4 = 87.9D;
               mapInfoPoint.Lat = val4;
               Assert.AreEqual(val4, mapInfoPoint.Lat);
               double val5 = 87.9D;
               mapInfoPoint.Lng = val5;
               Assert.AreEqual(val5, mapInfoPoint.Lng);
               DateTime val6 = new DateTime(2010, 3, 4);
               mapInfoPoint.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, mapInfoPoint.LastUpdateDate_UTC);
               int val7 = 45;
               mapInfoPoint.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, mapInfoPoint.LastUpdateContactTVItemID);
               MapInfo val17 = new MapInfo();
               mapInfoPoint.MapInfo = val17;
               Assert.AreEqual(val17, mapInfoPoint.MapInfo);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>().AsEnumerable();
               mapInfoPoint.ValidationResults = val27;
               Assert.AreEqual(val27, mapInfoPoint.ValidationResults);
        }
    }
}
