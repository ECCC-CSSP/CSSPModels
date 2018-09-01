/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by Charles on CHARLES-PC machine
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
    public partial class MapInfoTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private MapInfo mapInfo { get; set; }
        private MapInfo_A mapInfo_A { get; set; }
        private MapInfo_B mapInfo_B { get; set; }
        #endregion Properties

        #region Constructors
        public MapInfoTest()
        {
            mapInfo = new MapInfo();
            mapInfo_A = new MapInfo_A();
            mapInfo_B = new MapInfo_B();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void MapInfo_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MapInfoID", "TVItemID", "TVType", "LatMin", "LatMax", "LngMin", "LngMax", "MapInfoDrawType", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapInfo).GetProperties().OrderBy(c => c.Name))
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
        public void MapInfo_A_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVItemLanguage", "LastUpdateContactTVItemLanguage", "TVTypeText", "MapInfoDrawTypeText", "MapInfoID", "TVItemID", "TVType", "LatMin", "LatMax", "LngMin", "LngMax", "MapInfoDrawType", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapInfo_A).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MapInfo_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MapInfo_B_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MapInfoReportTest", "TVItemLanguage", "LastUpdateContactTVItemLanguage", "TVTypeText", "MapInfoDrawTypeText", "MapInfoID", "TVItemID", "TVType", "LatMin", "LatMax", "LngMin", "LngMax", "MapInfoDrawType", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapInfo_B).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MapInfo_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MapInfo_A_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapInfo_A).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapInfo_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MapInfo_B_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapInfo_B).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapInfo_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MapInfo_A_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MapInfo_A).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MapInfo_B_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MapInfo_B).GetProperties().Where(c => c.Name == "ValidationResults").Any());
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
               bool val11 = true;
               mapInfo.HasErrors = val11;
               Assert.AreEqual(val11, mapInfo.HasErrors);
               IEnumerable<ValidationResult> val36 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mapInfo.ValidationResults = val36;
               Assert.AreEqual(val36, mapInfo.ValidationResults);
        }
        [TestMethod]
        public void MapInfo_A_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               mapInfo_A.TVItemLanguage = val1;
               Assert.AreEqual(val1, mapInfo_A.TVItemLanguage);
               TVItemLanguage val2 = new TVItemLanguage();
               mapInfo_A.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, mapInfo_A.LastUpdateContactTVItemLanguage);
               string val3 = "Some text";
               mapInfo_A.TVTypeText = val3;
               Assert.AreEqual(val3, mapInfo_A.TVTypeText);
               string val4 = "Some text";
               mapInfo_A.MapInfoDrawTypeText = val4;
               Assert.AreEqual(val4, mapInfo_A.MapInfoDrawTypeText);
               int val5 = 45;
               mapInfo_A.MapInfoID = val5;
               Assert.AreEqual(val5, mapInfo_A.MapInfoID);
               int val6 = 45;
               mapInfo_A.TVItemID = val6;
               Assert.AreEqual(val6, mapInfo_A.TVItemID);
               TVTypeEnum val7 = (TVTypeEnum)3;
               mapInfo_A.TVType = val7;
               Assert.AreEqual(val7, mapInfo_A.TVType);
               double val8 = 87.9D;
               mapInfo_A.LatMin = val8;
               Assert.AreEqual(val8, mapInfo_A.LatMin);
               double val9 = 87.9D;
               mapInfo_A.LatMax = val9;
               Assert.AreEqual(val9, mapInfo_A.LatMax);
               double val10 = 87.9D;
               mapInfo_A.LngMin = val10;
               Assert.AreEqual(val10, mapInfo_A.LngMin);
               double val11 = 87.9D;
               mapInfo_A.LngMax = val11;
               Assert.AreEqual(val11, mapInfo_A.LngMax);
               MapInfoDrawTypeEnum val12 = (MapInfoDrawTypeEnum)3;
               mapInfo_A.MapInfoDrawType = val12;
               Assert.AreEqual(val12, mapInfo_A.MapInfoDrawType);
               DateTime val13 = new DateTime(2010, 3, 4);
               mapInfo_A.LastUpdateDate_UTC = val13;
               Assert.AreEqual(val13, mapInfo_A.LastUpdateDate_UTC);
               int val14 = 45;
               mapInfo_A.LastUpdateContactTVItemID = val14;
               Assert.AreEqual(val14, mapInfo_A.LastUpdateContactTVItemID);
               bool val15 = true;
               mapInfo_A.HasErrors = val15;
               Assert.AreEqual(val15, mapInfo_A.HasErrors);
               IEnumerable<ValidationResult> val48 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mapInfo_A.ValidationResults = val48;
               Assert.AreEqual(val48, mapInfo_A.ValidationResults);
        }
        [TestMethod]
        public void MapInfo_B_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mapInfo_B.MapInfoReportTest = val1;
               Assert.AreEqual(val1, mapInfo_B.MapInfoReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               mapInfo_B.TVItemLanguage = val2;
               Assert.AreEqual(val2, mapInfo_B.TVItemLanguage);
               TVItemLanguage val3 = new TVItemLanguage();
               mapInfo_B.LastUpdateContactTVItemLanguage = val3;
               Assert.AreEqual(val3, mapInfo_B.LastUpdateContactTVItemLanguage);
               string val4 = "Some text";
               mapInfo_B.TVTypeText = val4;
               Assert.AreEqual(val4, mapInfo_B.TVTypeText);
               string val5 = "Some text";
               mapInfo_B.MapInfoDrawTypeText = val5;
               Assert.AreEqual(val5, mapInfo_B.MapInfoDrawTypeText);
               int val6 = 45;
               mapInfo_B.MapInfoID = val6;
               Assert.AreEqual(val6, mapInfo_B.MapInfoID);
               int val7 = 45;
               mapInfo_B.TVItemID = val7;
               Assert.AreEqual(val7, mapInfo_B.TVItemID);
               TVTypeEnum val8 = (TVTypeEnum)3;
               mapInfo_B.TVType = val8;
               Assert.AreEqual(val8, mapInfo_B.TVType);
               double val9 = 87.9D;
               mapInfo_B.LatMin = val9;
               Assert.AreEqual(val9, mapInfo_B.LatMin);
               double val10 = 87.9D;
               mapInfo_B.LatMax = val10;
               Assert.AreEqual(val10, mapInfo_B.LatMax);
               double val11 = 87.9D;
               mapInfo_B.LngMin = val11;
               Assert.AreEqual(val11, mapInfo_B.LngMin);
               double val12 = 87.9D;
               mapInfo_B.LngMax = val12;
               Assert.AreEqual(val12, mapInfo_B.LngMax);
               MapInfoDrawTypeEnum val13 = (MapInfoDrawTypeEnum)3;
               mapInfo_B.MapInfoDrawType = val13;
               Assert.AreEqual(val13, mapInfo_B.MapInfoDrawType);
               DateTime val14 = new DateTime(2010, 3, 4);
               mapInfo_B.LastUpdateDate_UTC = val14;
               Assert.AreEqual(val14, mapInfo_B.LastUpdateDate_UTC);
               int val15 = 45;
               mapInfo_B.LastUpdateContactTVItemID = val15;
               Assert.AreEqual(val15, mapInfo_B.LastUpdateContactTVItemID);
               bool val16 = true;
               mapInfo_B.HasErrors = val16;
               Assert.AreEqual(val16, mapInfo_B.HasErrors);
               IEnumerable<ValidationResult> val51 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mapInfo_B.ValidationResults = val51;
               Assert.AreEqual(val51, mapInfo_B.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
