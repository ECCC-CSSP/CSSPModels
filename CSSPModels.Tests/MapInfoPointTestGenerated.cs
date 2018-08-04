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
    public partial class MapInfoPointTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private MapInfoPoint mapInfoPoint { get; set; }
        private MapInfoPointWeb mapInfoPointWeb { get; set; }
        private MapInfoPointReport mapInfoPointReport { get; set; }
        #endregion Properties

        #region Constructors
        public MapInfoPointTest()
        {
            mapInfoPoint = new MapInfoPoint();
            mapInfoPointWeb = new MapInfoPointWeb();
            mapInfoPointReport = new MapInfoPointReport();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void MapInfoPoint_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MapInfoPointID", "MapInfoID", "Ordinal", "Lat", "Lng", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapInfoPoint).GetProperties().OrderBy(c => c.Name))
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
        public void MapInfoPointWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactTVItemLanguage", "MapInfoPointID", "MapInfoID", "Ordinal", "Lat", "Lng", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapInfoPointWeb).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MapInfoPointWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MapInfoPointReport_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MapInfoPointReportTest", "LastUpdateContactTVItemLanguage", "MapInfoPointID", "MapInfoID", "Ordinal", "Lat", "Lng", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapInfoPointReport).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MapInfoPointReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
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
        public void MapInfoPointWeb_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapInfoPointWeb).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapInfoPointWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MapInfoPointReport_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapInfoPointReport).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MapInfoPointReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MapInfoPointWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MapInfoPointWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MapInfoPointReport_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MapInfoPointReport).GetProperties().Where(c => c.Name == "ValidationResults").Any());
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
               bool val8 = true;
               mapInfoPoint.HasErrors = val8;
               Assert.AreEqual(val8, mapInfoPoint.HasErrors);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mapInfoPoint.ValidationResults = val27;
               Assert.AreEqual(val27, mapInfoPoint.ValidationResults);
        }
        [TestMethod]
        public void MapInfoPointWeb_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               mapInfoPointWeb.LastUpdateContactTVItemLanguage = val1;
               Assert.AreEqual(val1, mapInfoPointWeb.LastUpdateContactTVItemLanguage);
               int val2 = 45;
               mapInfoPointWeb.MapInfoPointID = val2;
               Assert.AreEqual(val2, mapInfoPointWeb.MapInfoPointID);
               int val3 = 45;
               mapInfoPointWeb.MapInfoID = val3;
               Assert.AreEqual(val3, mapInfoPointWeb.MapInfoID);
               int val4 = 45;
               mapInfoPointWeb.Ordinal = val4;
               Assert.AreEqual(val4, mapInfoPointWeb.Ordinal);
               double val5 = 87.9D;
               mapInfoPointWeb.Lat = val5;
               Assert.AreEqual(val5, mapInfoPointWeb.Lat);
               double val6 = 87.9D;
               mapInfoPointWeb.Lng = val6;
               Assert.AreEqual(val6, mapInfoPointWeb.Lng);
               DateTime val7 = new DateTime(2010, 3, 4);
               mapInfoPointWeb.LastUpdateDate_UTC = val7;
               Assert.AreEqual(val7, mapInfoPointWeb.LastUpdateDate_UTC);
               int val8 = 45;
               mapInfoPointWeb.LastUpdateContactTVItemID = val8;
               Assert.AreEqual(val8, mapInfoPointWeb.LastUpdateContactTVItemID);
               bool val9 = true;
               mapInfoPointWeb.HasErrors = val9;
               Assert.AreEqual(val9, mapInfoPointWeb.HasErrors);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mapInfoPointWeb.ValidationResults = val30;
               Assert.AreEqual(val30, mapInfoPointWeb.ValidationResults);
        }
        [TestMethod]
        public void MapInfoPointReport_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mapInfoPointReport.MapInfoPointReportTest = val1;
               Assert.AreEqual(val1, mapInfoPointReport.MapInfoPointReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               mapInfoPointReport.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, mapInfoPointReport.LastUpdateContactTVItemLanguage);
               int val3 = 45;
               mapInfoPointReport.MapInfoPointID = val3;
               Assert.AreEqual(val3, mapInfoPointReport.MapInfoPointID);
               int val4 = 45;
               mapInfoPointReport.MapInfoID = val4;
               Assert.AreEqual(val4, mapInfoPointReport.MapInfoID);
               int val5 = 45;
               mapInfoPointReport.Ordinal = val5;
               Assert.AreEqual(val5, mapInfoPointReport.Ordinal);
               double val6 = 87.9D;
               mapInfoPointReport.Lat = val6;
               Assert.AreEqual(val6, mapInfoPointReport.Lat);
               double val7 = 87.9D;
               mapInfoPointReport.Lng = val7;
               Assert.AreEqual(val7, mapInfoPointReport.Lng);
               DateTime val8 = new DateTime(2010, 3, 4);
               mapInfoPointReport.LastUpdateDate_UTC = val8;
               Assert.AreEqual(val8, mapInfoPointReport.LastUpdateDate_UTC);
               int val9 = 45;
               mapInfoPointReport.LastUpdateContactTVItemID = val9;
               Assert.AreEqual(val9, mapInfoPointReport.LastUpdateContactTVItemID);
               bool val10 = true;
               mapInfoPointReport.HasErrors = val10;
               Assert.AreEqual(val10, mapInfoPointReport.HasErrors);
               IEnumerable<ValidationResult> val33 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mapInfoPointReport.ValidationResults = val33;
               Assert.AreEqual(val33, mapInfoPointReport.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
