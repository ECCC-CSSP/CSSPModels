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
    public partial class MapInfoTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private MapInfo mapInfo { get; set; }
        #endregion Properties

        #region Constructors
        public MapInfoTest()
        {
            mapInfo = new MapInfo();
        }
        #endregion Constructors

        #region Tests
        [TestMethod]
        public void MapInfo_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MapInfoID", "TVItemID", "TVType", "LatMin", "LatMax", "LngMin", "LngMax", "MapInfoDrawType", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "TVText", "LastUpdateContactTVText", "TVTypeText", "MapInfoDrawTypeText", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.MapInfo).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MapInfo).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MapInfo_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapInfo).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapInfo).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MapInfo_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MapInfo).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MapInfo_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.MapInfoMapInfoID);
               Assert.IsNotNull(CSSPModelsRes.MapInfoTVItemID);
               Assert.IsNotNull(CSSPModelsRes.MapInfoTVType);
               Assert.IsNotNull(CSSPModelsRes.MapInfoLatMin);
               Assert.IsNotNull(CSSPModelsRes.MapInfoLatMax);
               Assert.IsNotNull(CSSPModelsRes.MapInfoLngMin);
               Assert.IsNotNull(CSSPModelsRes.MapInfoLngMax);
               Assert.IsNotNull(CSSPModelsRes.MapInfoMapInfoDrawType);
               Assert.IsNotNull(CSSPModelsRes.MapInfoLastUpdateDate_UTC);
               Assert.IsNotNull(CSSPModelsRes.MapInfoLastUpdateContactTVItemID);
               Assert.IsNotNull(CSSPModelsRes.MapInfoTVText);
               Assert.IsNotNull(CSSPModelsRes.MapInfoLastUpdateContactTVText);
               Assert.IsNotNull(CSSPModelsRes.MapInfoTVTypeText);
               Assert.IsNotNull(CSSPModelsRes.MapInfoMapInfoDrawTypeText);
               Assert.IsNotNull(CSSPModelsRes.MapInfoHasErrors);
        }
        [TestMethod]
        public void MapInfo_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mapInfo.MapInfoID = val1;
               Assert.AreEqual(val1, mapInfo.MapInfoID);
               int val2 = 45;
               mapInfo.TVItemID = val2;
               Assert.AreEqual(val2, mapInfo.TVItemID);
               TVTypeEnum val3 = (TVTypeEnum)3;
               mapInfo.TVType = val3;
               Assert.AreEqual(val3, mapInfo.TVType);
               double val4 = 87.9D;
               mapInfo.LatMin = val4;
               Assert.AreEqual(val4, mapInfo.LatMin);
               double val5 = 87.9D;
               mapInfo.LatMax = val5;
               Assert.AreEqual(val5, mapInfo.LatMax);
               double val6 = 87.9D;
               mapInfo.LngMin = val6;
               Assert.AreEqual(val6, mapInfo.LngMin);
               double val7 = 87.9D;
               mapInfo.LngMax = val7;
               Assert.AreEqual(val7, mapInfo.LngMax);
               MapInfoDrawTypeEnum val8 = (MapInfoDrawTypeEnum)3;
               mapInfo.MapInfoDrawType = val8;
               Assert.AreEqual(val8, mapInfo.MapInfoDrawType);
               DateTime val9 = new DateTime(2010, 3, 4);
               mapInfo.LastUpdateDate_UTC = val9;
               Assert.AreEqual(val9, mapInfo.LastUpdateDate_UTC);
               int val10 = 45;
               mapInfo.LastUpdateContactTVItemID = val10;
               Assert.AreEqual(val10, mapInfo.LastUpdateContactTVItemID);
               string val11 = "Some text";
               mapInfo.TVText = val11;
               Assert.AreEqual(val11, mapInfo.TVText);
               string val12 = "Some text";
               mapInfo.LastUpdateContactTVText = val12;
               Assert.AreEqual(val12, mapInfo.LastUpdateContactTVText);
               string val13 = "Some text";
               mapInfo.TVTypeText = val13;
               Assert.AreEqual(val13, mapInfo.TVTypeText);
               string val14 = "Some text";
               mapInfo.MapInfoDrawTypeText = val14;
               Assert.AreEqual(val14, mapInfo.MapInfoDrawTypeText);
               bool val15 = true;
               mapInfo.HasErrors = val15;
               Assert.AreEqual(val15, mapInfo.HasErrors);
               IEnumerable<ValidationResult> val48 = new List<ValidationResult>().AsEnumerable();
               mapInfo.ValidationResults = val48;
               Assert.AreEqual(val48, mapInfo.ValidationResults);
        }
        #endregion Tests
    }
}
