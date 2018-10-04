/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
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
        private ClimateDataValue_A climateDataValue_A { get; set; }
        private ClimateDataValue_B climateDataValue_B { get; set; }
        #endregion Properties

        #region Constructors
        public ClimateDataValueTest()
        {
            climateDataValue = new ClimateDataValue();
            climateDataValue_A = new ClimateDataValue_A();
            climateDataValue_B = new ClimateDataValue_B();
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
        public void ClimateDataValue_A_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactTVItemLanguage", "StorageDataTypeEnumText", "ClimateDataValueID", "ClimateSiteID", "DateTime_Local", "Keep", "StorageDataType", "HasBeenRead", "Snow_cm", "Rainfall_mm", "RainfallEntered_mm", "TotalPrecip_mm_cm", "MaxTemp_C", "MinTemp_C", "HeatDegDays_C", "CoolDegDays_C", "SnowOnGround_cm", "DirMaxGust_0North", "SpdMaxGust_kmh", "HourlyValues", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateDataValue_A).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(ClimateDataValue_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ClimateDataValue_B_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ClimateDataValueReportTest", "LastUpdateContactTVItemLanguage", "StorageDataTypeEnumText", "ClimateDataValueID", "ClimateSiteID", "DateTime_Local", "Keep", "StorageDataType", "HasBeenRead", "Snow_cm", "Rainfall_mm", "RainfallEntered_mm", "TotalPrecip_mm_cm", "MaxTemp_C", "MinTemp_C", "HeatDegDays_C", "CoolDegDays_C", "SnowOnGround_cm", "DirMaxGust_0North", "SpdMaxGust_kmh", "HourlyValues", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateDataValue_B).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(ClimateDataValue_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ClimateDataValue_A_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateDataValue_A).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateDataValue_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ClimateDataValue_B_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateDataValue_B).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ClimateDataValue_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ClimateDataValue_A_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ClimateDataValue_A).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ClimateDataValue_B_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ClimateDataValue_B).GetProperties().Where(c => c.Name == "ValidationResults").Any());
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
        public void ClimateDataValue_A_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               climateDataValue_A.LastUpdateContactTVItemLanguage = val1;
               Assert.AreEqual(val1, climateDataValue_A.LastUpdateContactTVItemLanguage);
               string val2 = "Some text";
               climateDataValue_A.StorageDataTypeEnumText = val2;
               Assert.AreEqual(val2, climateDataValue_A.StorageDataTypeEnumText);
               int val3 = 45;
               climateDataValue_A.ClimateDataValueID = val3;
               Assert.AreEqual(val3, climateDataValue_A.ClimateDataValueID);
               int val4 = 45;
               climateDataValue_A.ClimateSiteID = val4;
               Assert.AreEqual(val4, climateDataValue_A.ClimateSiteID);
               DateTime val5 = new DateTime(2010, 3, 4);
               climateDataValue_A.DateTime_Local = val5;
               Assert.AreEqual(val5, climateDataValue_A.DateTime_Local);
               bool val6 = true;
               climateDataValue_A.Keep = val6;
               Assert.AreEqual(val6, climateDataValue_A.Keep);
               StorageDataTypeEnum val7 = (StorageDataTypeEnum)3;
               climateDataValue_A.StorageDataType = val7;
               Assert.AreEqual(val7, climateDataValue_A.StorageDataType);
               bool val8 = true;
               climateDataValue_A.HasBeenRead = val8;
               Assert.AreEqual(val8, climateDataValue_A.HasBeenRead);
               double val9 = 87.9D;
               climateDataValue_A.Snow_cm = val9;
               Assert.AreEqual(val9, climateDataValue_A.Snow_cm);
               double val10 = 87.9D;
               climateDataValue_A.Rainfall_mm = val10;
               Assert.AreEqual(val10, climateDataValue_A.Rainfall_mm);
               double val11 = 87.9D;
               climateDataValue_A.RainfallEntered_mm = val11;
               Assert.AreEqual(val11, climateDataValue_A.RainfallEntered_mm);
               double val12 = 87.9D;
               climateDataValue_A.TotalPrecip_mm_cm = val12;
               Assert.AreEqual(val12, climateDataValue_A.TotalPrecip_mm_cm);
               double val13 = 87.9D;
               climateDataValue_A.MaxTemp_C = val13;
               Assert.AreEqual(val13, climateDataValue_A.MaxTemp_C);
               double val14 = 87.9D;
               climateDataValue_A.MinTemp_C = val14;
               Assert.AreEqual(val14, climateDataValue_A.MinTemp_C);
               double val15 = 87.9D;
               climateDataValue_A.HeatDegDays_C = val15;
               Assert.AreEqual(val15, climateDataValue_A.HeatDegDays_C);
               double val16 = 87.9D;
               climateDataValue_A.CoolDegDays_C = val16;
               Assert.AreEqual(val16, climateDataValue_A.CoolDegDays_C);
               double val17 = 87.9D;
               climateDataValue_A.SnowOnGround_cm = val17;
               Assert.AreEqual(val17, climateDataValue_A.SnowOnGround_cm);
               double val18 = 87.9D;
               climateDataValue_A.DirMaxGust_0North = val18;
               Assert.AreEqual(val18, climateDataValue_A.DirMaxGust_0North);
               double val19 = 87.9D;
               climateDataValue_A.SpdMaxGust_kmh = val19;
               Assert.AreEqual(val19, climateDataValue_A.SpdMaxGust_kmh);
               string val20 = "Some text";
               climateDataValue_A.HourlyValues = val20;
               Assert.AreEqual(val20, climateDataValue_A.HourlyValues);
               DateTime val21 = new DateTime(2010, 3, 4);
               climateDataValue_A.LastUpdateDate_UTC = val21;
               Assert.AreEqual(val21, climateDataValue_A.LastUpdateDate_UTC);
               int val22 = 45;
               climateDataValue_A.LastUpdateContactTVItemID = val22;
               Assert.AreEqual(val22, climateDataValue_A.LastUpdateContactTVItemID);
               bool val23 = true;
               climateDataValue_A.HasErrors = val23;
               Assert.AreEqual(val23, climateDataValue_A.HasErrors);
               IEnumerable<ValidationResult> val72 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               climateDataValue_A.ValidationResults = val72;
               Assert.AreEqual(val72, climateDataValue_A.ValidationResults);
        }
        [TestMethod]
        public void ClimateDataValue_B_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               climateDataValue_B.ClimateDataValueReportTest = val1;
               Assert.AreEqual(val1, climateDataValue_B.ClimateDataValueReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               climateDataValue_B.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, climateDataValue_B.LastUpdateContactTVItemLanguage);
               string val3 = "Some text";
               climateDataValue_B.StorageDataTypeEnumText = val3;
               Assert.AreEqual(val3, climateDataValue_B.StorageDataTypeEnumText);
               int val4 = 45;
               climateDataValue_B.ClimateDataValueID = val4;
               Assert.AreEqual(val4, climateDataValue_B.ClimateDataValueID);
               int val5 = 45;
               climateDataValue_B.ClimateSiteID = val5;
               Assert.AreEqual(val5, climateDataValue_B.ClimateSiteID);
               DateTime val6 = new DateTime(2010, 3, 4);
               climateDataValue_B.DateTime_Local = val6;
               Assert.AreEqual(val6, climateDataValue_B.DateTime_Local);
               bool val7 = true;
               climateDataValue_B.Keep = val7;
               Assert.AreEqual(val7, climateDataValue_B.Keep);
               StorageDataTypeEnum val8 = (StorageDataTypeEnum)3;
               climateDataValue_B.StorageDataType = val8;
               Assert.AreEqual(val8, climateDataValue_B.StorageDataType);
               bool val9 = true;
               climateDataValue_B.HasBeenRead = val9;
               Assert.AreEqual(val9, climateDataValue_B.HasBeenRead);
               double val10 = 87.9D;
               climateDataValue_B.Snow_cm = val10;
               Assert.AreEqual(val10, climateDataValue_B.Snow_cm);
               double val11 = 87.9D;
               climateDataValue_B.Rainfall_mm = val11;
               Assert.AreEqual(val11, climateDataValue_B.Rainfall_mm);
               double val12 = 87.9D;
               climateDataValue_B.RainfallEntered_mm = val12;
               Assert.AreEqual(val12, climateDataValue_B.RainfallEntered_mm);
               double val13 = 87.9D;
               climateDataValue_B.TotalPrecip_mm_cm = val13;
               Assert.AreEqual(val13, climateDataValue_B.TotalPrecip_mm_cm);
               double val14 = 87.9D;
               climateDataValue_B.MaxTemp_C = val14;
               Assert.AreEqual(val14, climateDataValue_B.MaxTemp_C);
               double val15 = 87.9D;
               climateDataValue_B.MinTemp_C = val15;
               Assert.AreEqual(val15, climateDataValue_B.MinTemp_C);
               double val16 = 87.9D;
               climateDataValue_B.HeatDegDays_C = val16;
               Assert.AreEqual(val16, climateDataValue_B.HeatDegDays_C);
               double val17 = 87.9D;
               climateDataValue_B.CoolDegDays_C = val17;
               Assert.AreEqual(val17, climateDataValue_B.CoolDegDays_C);
               double val18 = 87.9D;
               climateDataValue_B.SnowOnGround_cm = val18;
               Assert.AreEqual(val18, climateDataValue_B.SnowOnGround_cm);
               double val19 = 87.9D;
               climateDataValue_B.DirMaxGust_0North = val19;
               Assert.AreEqual(val19, climateDataValue_B.DirMaxGust_0North);
               double val20 = 87.9D;
               climateDataValue_B.SpdMaxGust_kmh = val20;
               Assert.AreEqual(val20, climateDataValue_B.SpdMaxGust_kmh);
               string val21 = "Some text";
               climateDataValue_B.HourlyValues = val21;
               Assert.AreEqual(val21, climateDataValue_B.HourlyValues);
               DateTime val22 = new DateTime(2010, 3, 4);
               climateDataValue_B.LastUpdateDate_UTC = val22;
               Assert.AreEqual(val22, climateDataValue_B.LastUpdateDate_UTC);
               int val23 = 45;
               climateDataValue_B.LastUpdateContactTVItemID = val23;
               Assert.AreEqual(val23, climateDataValue_B.LastUpdateContactTVItemID);
               bool val24 = true;
               climateDataValue_B.HasErrors = val24;
               Assert.AreEqual(val24, climateDataValue_B.HasErrors);
               IEnumerable<ValidationResult> val75 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               climateDataValue_B.ValidationResults = val75;
               Assert.AreEqual(val75, climateDataValue_B.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
