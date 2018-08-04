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
    public partial class ClimateDataValueTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private ClimateDataValue climateDataValue { get; set; }
        private ClimateDataValueWeb climateDataValueWeb { get; set; }
        private ClimateDataValueReport climateDataValueReport { get; set; }
        #endregion Properties

        #region Constructors
        public ClimateDataValueTest()
        {
            climateDataValue = new ClimateDataValue();
            climateDataValueWeb = new ClimateDataValueWeb();
            climateDataValueReport = new ClimateDataValueReport();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void ClimateDataValue_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ClimateDataValueID", "ClimateSiteID", "DateTime_Local", "Keep", "StorageDataType", "HasBeenRead", "Snow_cm", "Rainfall_mm", "RainfallEntered_mm", "TotalPrecip_mm_cm", "MaxTemp_C", "MinTemp_C", "HeatDegDays_C", "CoolDegDays_C", "SnowOnGround_cm", "DirMaxGust_0North", "SpdMaxGust_kmh", "HourlyValues", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateDataValue).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(ClimateDataValue).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ClimateDataValueWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactTVItemLanguage", "StorageDataTypeEnumText", "ClimateDataValueID", "ClimateSiteID", "DateTime_Local", "Keep", "StorageDataType", "HasBeenRead", "Snow_cm", "Rainfall_mm", "RainfallEntered_mm", "TotalPrecip_mm_cm", "MaxTemp_C", "MinTemp_C", "HeatDegDays_C", "CoolDegDays_C", "SnowOnGround_cm", "DirMaxGust_0North", "SpdMaxGust_kmh", "HourlyValues", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateDataValueWeb).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(ClimateDataValueWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ClimateDataValueReport_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ClimateDataValueReportTest", "LastUpdateContactTVItemLanguage", "StorageDataTypeEnumText", "ClimateDataValueID", "ClimateSiteID", "DateTime_Local", "Keep", "StorageDataType", "HasBeenRead", "Snow_cm", "Rainfall_mm", "RainfallEntered_mm", "TotalPrecip_mm_cm", "MaxTemp_C", "MinTemp_C", "HeatDegDays_C", "CoolDegDays_C", "SnowOnGround_cm", "DirMaxGust_0North", "SpdMaxGust_kmh", "HourlyValues", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateDataValueReport).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(ClimateDataValueReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ClimateDataValue_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateDataValue).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateDataValue).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ClimateDataValueWeb_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateDataValueWeb).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateDataValueWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ClimateDataValueReport_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateDataValueReport).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateDataValueReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ClimateDataValue_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ClimateDataValue).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ClimateDataValueWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ClimateDataValueWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ClimateDataValueReport_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ClimateDataValueReport).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ClimateDataValue_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               climateDataValue.ClimateDataValueID = val1;
               Assert.AreEqual(val1, climateDataValue.ClimateDataValueID);
               int val2 = 45;
               climateDataValue.ClimateSiteID = val2;
               Assert.AreEqual(val2, climateDataValue.ClimateSiteID);
               DateTime val3 = new DateTime(2010, 3, 4);
               climateDataValue.DateTime_Local = val3;
               Assert.AreEqual(val3, climateDataValue.DateTime_Local);
               bool val4 = true;
               climateDataValue.Keep = val4;
               Assert.AreEqual(val4, climateDataValue.Keep);
               StorageDataTypeEnum val5 = (StorageDataTypeEnum)3;
               climateDataValue.StorageDataType = val5;
               Assert.AreEqual(val5, climateDataValue.StorageDataType);
               bool val6 = true;
               climateDataValue.HasBeenRead = val6;
               Assert.AreEqual(val6, climateDataValue.HasBeenRead);
               double val7 = 87.9D;
               climateDataValue.Snow_cm = val7;
               Assert.AreEqual(val7, climateDataValue.Snow_cm);
               double val8 = 87.9D;
               climateDataValue.Rainfall_mm = val8;
               Assert.AreEqual(val8, climateDataValue.Rainfall_mm);
               double val9 = 87.9D;
               climateDataValue.RainfallEntered_mm = val9;
               Assert.AreEqual(val9, climateDataValue.RainfallEntered_mm);
               double val10 = 87.9D;
               climateDataValue.TotalPrecip_mm_cm = val10;
               Assert.AreEqual(val10, climateDataValue.TotalPrecip_mm_cm);
               double val11 = 87.9D;
               climateDataValue.MaxTemp_C = val11;
               Assert.AreEqual(val11, climateDataValue.MaxTemp_C);
               double val12 = 87.9D;
               climateDataValue.MinTemp_C = val12;
               Assert.AreEqual(val12, climateDataValue.MinTemp_C);
               double val13 = 87.9D;
               climateDataValue.HeatDegDays_C = val13;
               Assert.AreEqual(val13, climateDataValue.HeatDegDays_C);
               double val14 = 87.9D;
               climateDataValue.CoolDegDays_C = val14;
               Assert.AreEqual(val14, climateDataValue.CoolDegDays_C);
               double val15 = 87.9D;
               climateDataValue.SnowOnGround_cm = val15;
               Assert.AreEqual(val15, climateDataValue.SnowOnGround_cm);
               double val16 = 87.9D;
               climateDataValue.DirMaxGust_0North = val16;
               Assert.AreEqual(val16, climateDataValue.DirMaxGust_0North);
               double val17 = 87.9D;
               climateDataValue.SpdMaxGust_kmh = val17;
               Assert.AreEqual(val17, climateDataValue.SpdMaxGust_kmh);
               string val18 = "Some text";
               climateDataValue.HourlyValues = val18;
               Assert.AreEqual(val18, climateDataValue.HourlyValues);
               DateTime val19 = new DateTime(2010, 3, 4);
               climateDataValue.LastUpdateDate_UTC = val19;
               Assert.AreEqual(val19, climateDataValue.LastUpdateDate_UTC);
               int val20 = 45;
               climateDataValue.LastUpdateContactTVItemID = val20;
               Assert.AreEqual(val20, climateDataValue.LastUpdateContactTVItemID);
               bool val21 = true;
               climateDataValue.HasErrors = val21;
               Assert.AreEqual(val21, climateDataValue.HasErrors);
               IEnumerable<ValidationResult> val66 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               climateDataValue.ValidationResults = val66;
               Assert.AreEqual(val66, climateDataValue.ValidationResults);
        }
        [TestMethod]
        public void ClimateDataValueWeb_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               climateDataValueWeb.LastUpdateContactTVItemLanguage = val1;
               Assert.AreEqual(val1, climateDataValueWeb.LastUpdateContactTVItemLanguage);
               string val2 = "Some text";
               climateDataValueWeb.StorageDataTypeEnumText = val2;
               Assert.AreEqual(val2, climateDataValueWeb.StorageDataTypeEnumText);
               int val3 = 45;
               climateDataValueWeb.ClimateDataValueID = val3;
               Assert.AreEqual(val3, climateDataValueWeb.ClimateDataValueID);
               int val4 = 45;
               climateDataValueWeb.ClimateSiteID = val4;
               Assert.AreEqual(val4, climateDataValueWeb.ClimateSiteID);
               DateTime val5 = new DateTime(2010, 3, 4);
               climateDataValueWeb.DateTime_Local = val5;
               Assert.AreEqual(val5, climateDataValueWeb.DateTime_Local);
               bool val6 = true;
               climateDataValueWeb.Keep = val6;
               Assert.AreEqual(val6, climateDataValueWeb.Keep);
               StorageDataTypeEnum val7 = (StorageDataTypeEnum)3;
               climateDataValueWeb.StorageDataType = val7;
               Assert.AreEqual(val7, climateDataValueWeb.StorageDataType);
               bool val8 = true;
               climateDataValueWeb.HasBeenRead = val8;
               Assert.AreEqual(val8, climateDataValueWeb.HasBeenRead);
               double val9 = 87.9D;
               climateDataValueWeb.Snow_cm = val9;
               Assert.AreEqual(val9, climateDataValueWeb.Snow_cm);
               double val10 = 87.9D;
               climateDataValueWeb.Rainfall_mm = val10;
               Assert.AreEqual(val10, climateDataValueWeb.Rainfall_mm);
               double val11 = 87.9D;
               climateDataValueWeb.RainfallEntered_mm = val11;
               Assert.AreEqual(val11, climateDataValueWeb.RainfallEntered_mm);
               double val12 = 87.9D;
               climateDataValueWeb.TotalPrecip_mm_cm = val12;
               Assert.AreEqual(val12, climateDataValueWeb.TotalPrecip_mm_cm);
               double val13 = 87.9D;
               climateDataValueWeb.MaxTemp_C = val13;
               Assert.AreEqual(val13, climateDataValueWeb.MaxTemp_C);
               double val14 = 87.9D;
               climateDataValueWeb.MinTemp_C = val14;
               Assert.AreEqual(val14, climateDataValueWeb.MinTemp_C);
               double val15 = 87.9D;
               climateDataValueWeb.HeatDegDays_C = val15;
               Assert.AreEqual(val15, climateDataValueWeb.HeatDegDays_C);
               double val16 = 87.9D;
               climateDataValueWeb.CoolDegDays_C = val16;
               Assert.AreEqual(val16, climateDataValueWeb.CoolDegDays_C);
               double val17 = 87.9D;
               climateDataValueWeb.SnowOnGround_cm = val17;
               Assert.AreEqual(val17, climateDataValueWeb.SnowOnGround_cm);
               double val18 = 87.9D;
               climateDataValueWeb.DirMaxGust_0North = val18;
               Assert.AreEqual(val18, climateDataValueWeb.DirMaxGust_0North);
               double val19 = 87.9D;
               climateDataValueWeb.SpdMaxGust_kmh = val19;
               Assert.AreEqual(val19, climateDataValueWeb.SpdMaxGust_kmh);
               string val20 = "Some text";
               climateDataValueWeb.HourlyValues = val20;
               Assert.AreEqual(val20, climateDataValueWeb.HourlyValues);
               DateTime val21 = new DateTime(2010, 3, 4);
               climateDataValueWeb.LastUpdateDate_UTC = val21;
               Assert.AreEqual(val21, climateDataValueWeb.LastUpdateDate_UTC);
               int val22 = 45;
               climateDataValueWeb.LastUpdateContactTVItemID = val22;
               Assert.AreEqual(val22, climateDataValueWeb.LastUpdateContactTVItemID);
               bool val23 = true;
               climateDataValueWeb.HasErrors = val23;
               Assert.AreEqual(val23, climateDataValueWeb.HasErrors);
               IEnumerable<ValidationResult> val72 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               climateDataValueWeb.ValidationResults = val72;
               Assert.AreEqual(val72, climateDataValueWeb.ValidationResults);
        }
        [TestMethod]
        public void ClimateDataValueReport_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               climateDataValueReport.ClimateDataValueReportTest = val1;
               Assert.AreEqual(val1, climateDataValueReport.ClimateDataValueReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               climateDataValueReport.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, climateDataValueReport.LastUpdateContactTVItemLanguage);
               string val3 = "Some text";
               climateDataValueReport.StorageDataTypeEnumText = val3;
               Assert.AreEqual(val3, climateDataValueReport.StorageDataTypeEnumText);
               int val4 = 45;
               climateDataValueReport.ClimateDataValueID = val4;
               Assert.AreEqual(val4, climateDataValueReport.ClimateDataValueID);
               int val5 = 45;
               climateDataValueReport.ClimateSiteID = val5;
               Assert.AreEqual(val5, climateDataValueReport.ClimateSiteID);
               DateTime val6 = new DateTime(2010, 3, 4);
               climateDataValueReport.DateTime_Local = val6;
               Assert.AreEqual(val6, climateDataValueReport.DateTime_Local);
               bool val7 = true;
               climateDataValueReport.Keep = val7;
               Assert.AreEqual(val7, climateDataValueReport.Keep);
               StorageDataTypeEnum val8 = (StorageDataTypeEnum)3;
               climateDataValueReport.StorageDataType = val8;
               Assert.AreEqual(val8, climateDataValueReport.StorageDataType);
               bool val9 = true;
               climateDataValueReport.HasBeenRead = val9;
               Assert.AreEqual(val9, climateDataValueReport.HasBeenRead);
               double val10 = 87.9D;
               climateDataValueReport.Snow_cm = val10;
               Assert.AreEqual(val10, climateDataValueReport.Snow_cm);
               double val11 = 87.9D;
               climateDataValueReport.Rainfall_mm = val11;
               Assert.AreEqual(val11, climateDataValueReport.Rainfall_mm);
               double val12 = 87.9D;
               climateDataValueReport.RainfallEntered_mm = val12;
               Assert.AreEqual(val12, climateDataValueReport.RainfallEntered_mm);
               double val13 = 87.9D;
               climateDataValueReport.TotalPrecip_mm_cm = val13;
               Assert.AreEqual(val13, climateDataValueReport.TotalPrecip_mm_cm);
               double val14 = 87.9D;
               climateDataValueReport.MaxTemp_C = val14;
               Assert.AreEqual(val14, climateDataValueReport.MaxTemp_C);
               double val15 = 87.9D;
               climateDataValueReport.MinTemp_C = val15;
               Assert.AreEqual(val15, climateDataValueReport.MinTemp_C);
               double val16 = 87.9D;
               climateDataValueReport.HeatDegDays_C = val16;
               Assert.AreEqual(val16, climateDataValueReport.HeatDegDays_C);
               double val17 = 87.9D;
               climateDataValueReport.CoolDegDays_C = val17;
               Assert.AreEqual(val17, climateDataValueReport.CoolDegDays_C);
               double val18 = 87.9D;
               climateDataValueReport.SnowOnGround_cm = val18;
               Assert.AreEqual(val18, climateDataValueReport.SnowOnGround_cm);
               double val19 = 87.9D;
               climateDataValueReport.DirMaxGust_0North = val19;
               Assert.AreEqual(val19, climateDataValueReport.DirMaxGust_0North);
               double val20 = 87.9D;
               climateDataValueReport.SpdMaxGust_kmh = val20;
               Assert.AreEqual(val20, climateDataValueReport.SpdMaxGust_kmh);
               string val21 = "Some text";
               climateDataValueReport.HourlyValues = val21;
               Assert.AreEqual(val21, climateDataValueReport.HourlyValues);
               DateTime val22 = new DateTime(2010, 3, 4);
               climateDataValueReport.LastUpdateDate_UTC = val22;
               Assert.AreEqual(val22, climateDataValueReport.LastUpdateDate_UTC);
               int val23 = 45;
               climateDataValueReport.LastUpdateContactTVItemID = val23;
               Assert.AreEqual(val23, climateDataValueReport.LastUpdateContactTVItemID);
               bool val24 = true;
               climateDataValueReport.HasErrors = val24;
               Assert.AreEqual(val24, climateDataValueReport.HasErrors);
               IEnumerable<ValidationResult> val75 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               climateDataValueReport.ValidationResults = val75;
               Assert.AreEqual(val75, climateDataValueReport.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
