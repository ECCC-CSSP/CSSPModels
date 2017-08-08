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
    public partial class ClimateDataValueTest : SetupData
    {
        [TestMethod]
        public void ClimateDataValue_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ClimateDataValueID", "ClimateSiteID", "DateTime_Local", "Keep", "StorageDataType", "Snow_cm", "Rainfall_mm", "RainfallEntered_mm", "TotalPrecip_mm_cm", "MaxTemp_C", "MinTemp_C", "HeatDegDays_C", "CoolDegDays_C", "SnowOnGround_cm", "DirMaxGust_0North", "SpdMaxGust_kmh", "HourlyValues", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "LastUpdateContactTVText", "StorageDataTypeEnumText",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.ClimateDataValue).GetProperties().OrderBy(c => c.Name))
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
        public void ClimateDataValue_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ClimateDataValue).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ClimateDataValue_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.ClimateDataValueClimateDataValueID);
               Assert.IsNotNull(ModelsRes.ClimateDataValueClimateSiteID);
               Assert.IsNotNull(ModelsRes.ClimateDataValueDateTime_Local);
               Assert.IsNotNull(ModelsRes.ClimateDataValueKeep);
               Assert.IsNotNull(ModelsRes.ClimateDataValueStorageDataType);
               Assert.IsNotNull(ModelsRes.ClimateDataValueSnow_cm);
               Assert.IsNotNull(ModelsRes.ClimateDataValueRainfall_mm);
               Assert.IsNotNull(ModelsRes.ClimateDataValueRainfallEntered_mm);
               Assert.IsNotNull(ModelsRes.ClimateDataValueTotalPrecip_mm_cm);
               Assert.IsNotNull(ModelsRes.ClimateDataValueMaxTemp_C);
               Assert.IsNotNull(ModelsRes.ClimateDataValueMinTemp_C);
               Assert.IsNotNull(ModelsRes.ClimateDataValueHeatDegDays_C);
               Assert.IsNotNull(ModelsRes.ClimateDataValueCoolDegDays_C);
               Assert.IsNotNull(ModelsRes.ClimateDataValueSnowOnGround_cm);
               Assert.IsNotNull(ModelsRes.ClimateDataValueDirMaxGust_0North);
               Assert.IsNotNull(ModelsRes.ClimateDataValueSpdMaxGust_kmh);
               Assert.IsNotNull(ModelsRes.ClimateDataValueHourlyValues);
               Assert.IsNotNull(ModelsRes.ClimateDataValueLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.ClimateDataValueLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.ClimateDataValueLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.ClimateDataValueStorageDataTypeEnumText);
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
               double val6 = 87.9D;
               climateDataValue.Snow_cm = val6;
               Assert.AreEqual(val6, climateDataValue.Snow_cm);
               double val7 = 87.9D;
               climateDataValue.Rainfall_mm = val7;
               Assert.AreEqual(val7, climateDataValue.Rainfall_mm);
               double val8 = 87.9D;
               climateDataValue.RainfallEntered_mm = val8;
               Assert.AreEqual(val8, climateDataValue.RainfallEntered_mm);
               double val9 = 87.9D;
               climateDataValue.TotalPrecip_mm_cm = val9;
               Assert.AreEqual(val9, climateDataValue.TotalPrecip_mm_cm);
               double val10 = 87.9D;
               climateDataValue.MaxTemp_C = val10;
               Assert.AreEqual(val10, climateDataValue.MaxTemp_C);
               double val11 = 87.9D;
               climateDataValue.MinTemp_C = val11;
               Assert.AreEqual(val11, climateDataValue.MinTemp_C);
               double val12 = 87.9D;
               climateDataValue.HeatDegDays_C = val12;
               Assert.AreEqual(val12, climateDataValue.HeatDegDays_C);
               double val13 = 87.9D;
               climateDataValue.CoolDegDays_C = val13;
               Assert.AreEqual(val13, climateDataValue.CoolDegDays_C);
               double val14 = 87.9D;
               climateDataValue.SnowOnGround_cm = val14;
               Assert.AreEqual(val14, climateDataValue.SnowOnGround_cm);
               double val15 = 87.9D;
               climateDataValue.DirMaxGust_0North = val15;
               Assert.AreEqual(val15, climateDataValue.DirMaxGust_0North);
               double val16 = 87.9D;
               climateDataValue.SpdMaxGust_kmh = val16;
               Assert.AreEqual(val16, climateDataValue.SpdMaxGust_kmh);
               string val17 = "Some text";
               climateDataValue.HourlyValues = val17;
               Assert.AreEqual(val17, climateDataValue.HourlyValues);
               DateTime val18 = new DateTime(2010, 3, 4);
               climateDataValue.LastUpdateDate_UTC = val18;
               Assert.AreEqual(val18, climateDataValue.LastUpdateDate_UTC);
               int val19 = 45;
               climateDataValue.LastUpdateContactTVItemID = val19;
               Assert.AreEqual(val19, climateDataValue.LastUpdateContactTVItemID);
               string val20 = "Some text";
               climateDataValue.LastUpdateContactTVText = val20;
               Assert.AreEqual(val20, climateDataValue.LastUpdateContactTVText);
               string val21 = "Some text";
               climateDataValue.StorageDataTypeEnumText = val21;
               Assert.AreEqual(val21, climateDataValue.StorageDataTypeEnumText);
               IEnumerable<ValidationResult> val66 = new List<ValidationResult>().AsEnumerable();
               climateDataValue.ValidationResults = val66;
               Assert.AreEqual(val66, climateDataValue.ValidationResults);
        }
    }
}
