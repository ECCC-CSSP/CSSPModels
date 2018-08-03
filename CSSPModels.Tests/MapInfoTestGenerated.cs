/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by leblancc on WMON01DTCHLEBL2 machine
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
        private MapInfoWeb mapInfoWeb { get; set; }
        private MapInfoReport mapInfoReport { get; set; }
        #endregion Properties

        #region Constructors
        public MapInfoTest()
        {
            mapInfo = new MapInfo();
            mapInfoWeb = new MapInfoWeb();
            mapInfoReport = new MapInfoReport();
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
        public void MapInfoWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVItemLanguage", "LastUpdateContactTVItemLanguage", "TVTypeText", "MapInfoDrawTypeText", "MapInfoID", "TVItemID", "TVType", "LatMin", "LatMax", "LngMin", "LngMax", "MapInfoDrawType", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapInfoWeb).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MapInfoWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MapInfoReport_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MapInfoReportTest", "TVItemLanguage", "LastUpdateContactTVItemLanguage", "TVTypeText", "MapInfoDrawTypeText", "MapInfoID", "TVItemID", "TVType", "LatMin", "LatMax", "LngMin", "LngMax", "MapInfoDrawType", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapInfoReport).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MapInfoReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MapInfoWeb_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapInfoWeb).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapInfoWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MapInfoReport_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapInfoReport).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapInfoReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MapInfoWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MapInfoWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MapInfoReport_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MapInfoReport).GetProperties().Where(c => c.Name == "ValidationResults").Any());
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
        public void MapInfoWeb_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               mapInfoWeb.TVItemLanguage = val1;
               Assert.AreEqual(val1, mapInfoWeb.TVItemLanguage);
               TVItemLanguage val2 = new TVItemLanguage();
               mapInfoWeb.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, mapInfoWeb.LastUpdateContactTVItemLanguage);
               string val3 = "Some text";
               mapInfoWeb.TVTypeText = val3;
               Assert.AreEqual(val3, mapInfoWeb.TVTypeText);
               string val4 = "Some text";
               mapInfoWeb.MapInfoDrawTypeText = val4;
               Assert.AreEqual(val4, mapInfoWeb.MapInfoDrawTypeText);
               int val5 = 45;
               mapInfoWeb.MapInfoID = val5;
               Assert.AreEqual(val5, mapInfoWeb.MapInfoID);
               int val6 = 45;
               mapInfoWeb.TVItemID = val6;
               Assert.AreEqual(val6, mapInfoWeb.TVItemID);
               TVTypeEnum val7 = (TVTypeEnum)3;
               mapInfoWeb.TVType = val7;
               Assert.AreEqual(val7, mapInfoWeb.TVType);
               double val8 = 87.9D;
               mapInfoWeb.LatMin = val8;
               Assert.AreEqual(val8, mapInfoWeb.LatMin);
               double val9 = 87.9D;
               mapInfoWeb.LatMax = val9;
               Assert.AreEqual(val9, mapInfoWeb.LatMax);
               double val10 = 87.9D;
               mapInfoWeb.LngMin = val10;
               Assert.AreEqual(val10, mapInfoWeb.LngMin);
               double val11 = 87.9D;
               mapInfoWeb.LngMax = val11;
               Assert.AreEqual(val11, mapInfoWeb.LngMax);
               MapInfoDrawTypeEnum val12 = (MapInfoDrawTypeEnum)3;
               mapInfoWeb.MapInfoDrawType = val12;
               Assert.AreEqual(val12, mapInfoWeb.MapInfoDrawType);
               DateTime val13 = new DateTime(2010, 3, 4);
               mapInfoWeb.LastUpdateDate_UTC = val13;
               Assert.AreEqual(val13, mapInfoWeb.LastUpdateDate_UTC);
               int val14 = 45;
               mapInfoWeb.LastUpdateContactTVItemID = val14;
               Assert.AreEqual(val14, mapInfoWeb.LastUpdateContactTVItemID);
               bool val15 = true;
               mapInfoWeb.HasErrors = val15;
               Assert.AreEqual(val15, mapInfoWeb.HasErrors);
               IEnumerable<ValidationResult> val48 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mapInfoWeb.ValidationResults = val48;
               Assert.AreEqual(val48, mapInfoWeb.ValidationResults);
        }
        [TestMethod]
        public void MapInfoReport_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mapInfoReport.MapInfoReportTest = val1;
               Assert.AreEqual(val1, mapInfoReport.MapInfoReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               mapInfoReport.TVItemLanguage = val2;
               Assert.AreEqual(val2, mapInfoReport.TVItemLanguage);
               TVItemLanguage val3 = new TVItemLanguage();
               mapInfoReport.LastUpdateContactTVItemLanguage = val3;
               Assert.AreEqual(val3, mapInfoReport.LastUpdateContactTVItemLanguage);
               string val4 = "Some text";
               mapInfoReport.TVTypeText = val4;
               Assert.AreEqual(val4, mapInfoReport.TVTypeText);
               string val5 = "Some text";
               mapInfoReport.MapInfoDrawTypeText = val5;
               Assert.AreEqual(val5, mapInfoReport.MapInfoDrawTypeText);
               int val6 = 45;
               mapInfoReport.MapInfoID = val6;
               Assert.AreEqual(val6, mapInfoReport.MapInfoID);
               int val7 = 45;
               mapInfoReport.TVItemID = val7;
               Assert.AreEqual(val7, mapInfoReport.TVItemID);
               TVTypeEnum val8 = (TVTypeEnum)3;
               mapInfoReport.TVType = val8;
               Assert.AreEqual(val8, mapInfoReport.TVType);
               double val9 = 87.9D;
               mapInfoReport.LatMin = val9;
               Assert.AreEqual(val9, mapInfoReport.LatMin);
               double val10 = 87.9D;
               mapInfoReport.LatMax = val10;
               Assert.AreEqual(val10, mapInfoReport.LatMax);
               double val11 = 87.9D;
               mapInfoReport.LngMin = val11;
               Assert.AreEqual(val11, mapInfoReport.LngMin);
               double val12 = 87.9D;
               mapInfoReport.LngMax = val12;
               Assert.AreEqual(val12, mapInfoReport.LngMax);
               MapInfoDrawTypeEnum val13 = (MapInfoDrawTypeEnum)3;
               mapInfoReport.MapInfoDrawType = val13;
               Assert.AreEqual(val13, mapInfoReport.MapInfoDrawType);
               DateTime val14 = new DateTime(2010, 3, 4);
               mapInfoReport.LastUpdateDate_UTC = val14;
               Assert.AreEqual(val14, mapInfoReport.LastUpdateDate_UTC);
               int val15 = 45;
               mapInfoReport.LastUpdateContactTVItemID = val15;
               Assert.AreEqual(val15, mapInfoReport.LastUpdateContactTVItemID);
               bool val16 = true;
               mapInfoReport.HasErrors = val16;
               Assert.AreEqual(val16, mapInfoReport.HasErrors);
               IEnumerable<ValidationResult> val51 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mapInfoReport.ValidationResults = val51;
               Assert.AreEqual(val51, mapInfoReport.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
