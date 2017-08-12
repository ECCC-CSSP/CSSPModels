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
    public partial class HydrometricDataValueTest : SetupData
    {
        [TestMethod]
        public void HydrometricDataValue_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "HydrometricDataValueID", "HydrometricSiteID", "DateTime_Local", "Keep", "StorageDataType", "Flow_m3_s", "HourlyValues", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "LastUpdateContactTVText", "StorageDataTypeText", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.HydrometricDataValue).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(HydrometricDataValue).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void HydrometricDataValue_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(HydrometricDataValue).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(HydrometricDataValue).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void HydrometricDataValue_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(HydrometricDataValue).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void HydrometricDataValue_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.HydrometricDataValueHydrometricDataValueID);
               Assert.IsNotNull(ModelsRes.HydrometricDataValueHydrometricSiteID);
               Assert.IsNotNull(ModelsRes.HydrometricDataValueDateTime_Local);
               Assert.IsNotNull(ModelsRes.HydrometricDataValueKeep);
               Assert.IsNotNull(ModelsRes.HydrometricDataValueStorageDataType);
               Assert.IsNotNull(ModelsRes.HydrometricDataValueFlow_m3_s);
               Assert.IsNotNull(ModelsRes.HydrometricDataValueHourlyValues);
               Assert.IsNotNull(ModelsRes.HydrometricDataValueLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.HydrometricDataValueLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.HydrometricDataValueLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.HydrometricDataValueStorageDataTypeText);
               Assert.IsNotNull(ModelsRes.HydrometricDataValueHasErrors);
        }
        [TestMethod]
        public void HydrometricDataValue_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               hydrometricDataValue.HydrometricDataValueID = val1;
               Assert.AreEqual(val1, hydrometricDataValue.HydrometricDataValueID);
               int val2 = 45;
               hydrometricDataValue.HydrometricSiteID = val2;
               Assert.AreEqual(val2, hydrometricDataValue.HydrometricSiteID);
               DateTime val3 = new DateTime(2010, 3, 4);
               hydrometricDataValue.DateTime_Local = val3;
               Assert.AreEqual(val3, hydrometricDataValue.DateTime_Local);
               bool val4 = true;
               hydrometricDataValue.Keep = val4;
               Assert.AreEqual(val4, hydrometricDataValue.Keep);
               StorageDataTypeEnum val5 = (StorageDataTypeEnum)3;
               hydrometricDataValue.StorageDataType = val5;
               Assert.AreEqual(val5, hydrometricDataValue.StorageDataType);
               double val6 = 87.9D;
               hydrometricDataValue.Flow_m3_s = val6;
               Assert.AreEqual(val6, hydrometricDataValue.Flow_m3_s);
               string val7 = "Some text";
               hydrometricDataValue.HourlyValues = val7;
               Assert.AreEqual(val7, hydrometricDataValue.HourlyValues);
               DateTime val8 = new DateTime(2010, 3, 4);
               hydrometricDataValue.LastUpdateDate_UTC = val8;
               Assert.AreEqual(val8, hydrometricDataValue.LastUpdateDate_UTC);
               int val9 = 45;
               hydrometricDataValue.LastUpdateContactTVItemID = val9;
               Assert.AreEqual(val9, hydrometricDataValue.LastUpdateContactTVItemID);
               string val10 = "Some text";
               hydrometricDataValue.LastUpdateContactTVText = val10;
               Assert.AreEqual(val10, hydrometricDataValue.LastUpdateContactTVText);
               string val11 = "Some text";
               hydrometricDataValue.StorageDataTypeText = val11;
               Assert.AreEqual(val11, hydrometricDataValue.StorageDataTypeText);
               bool val12 = true;
               hydrometricDataValue.HasErrors = val12;
               Assert.AreEqual(val12, hydrometricDataValue.HasErrors);
               IEnumerable<ValidationResult> val39 = new List<ValidationResult>().AsEnumerable();
               hydrometricDataValue.ValidationResults = val39;
               Assert.AreEqual(val39, hydrometricDataValue.ValidationResults);
        }
    }
}
