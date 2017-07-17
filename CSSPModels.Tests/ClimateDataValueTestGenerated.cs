using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Globalization;
using System.Transactions;
using System.Collections.Generic;
using CSSPModels.Resources;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;

namespace CSSPModels.Tests
{
    public partial class ClimateDataValueTest
    {
        [TestMethod]
        public void ClimateDataValue_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "ClimateDataValueID", "ClimateSiteID", "DateTime_Local", "Keep", "StorageDataType", "Snow_cm", "Rainfall_mm", "RainfallEntered_mm", "TotalPrecip_mm_cm", "MaxTemp_C", "MinTemp_C", "HeatDegDays_C", "CoolDegDays_C", "SnowOnGround_cm", "DirMaxGust_0North", "SpdMaxGust_kmh", "HourlyValues", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

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
        public void ClimateDataValue_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "ClimateSite",  }.OrderBy(c => c).ToList();
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
        public void ClimateDataValue_Has_ValidationResults_OK()
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
               Assert.IsNotNull(ModelsRes.ClimateDataValueClimateSite);
        }
    }
}
