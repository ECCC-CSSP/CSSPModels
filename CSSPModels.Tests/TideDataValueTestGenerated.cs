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
    public partial class TideDataValueTest : SetupData
    {
        [TestMethod]
        public void TideDataValue_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TideDataValueID", "TideSiteTVItemID", "DateTime_Local", "Keep", "TideDataType", "StorageDataType", "Depth_m", "UVelocity_m_s", "VVelocity_m_s", "TideStart", "TideEnd", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "TideSiteTVText", "LastUpdateContactTVText", "TideDataTypeText", "StorageDataTypeText", "TideStartText", "TideEndText",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.TideDataValue).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TideDataValue).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TideDataValue_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideDataValue).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideDataValue).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TideDataValue_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TideDataValue).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TideDataValue_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.TideDataValueTideDataValueID);
               Assert.IsNotNull(ModelsRes.TideDataValueTideSiteTVItemID);
               Assert.IsNotNull(ModelsRes.TideDataValueDateTime_Local);
               Assert.IsNotNull(ModelsRes.TideDataValueKeep);
               Assert.IsNotNull(ModelsRes.TideDataValueTideDataType);
               Assert.IsNotNull(ModelsRes.TideDataValueStorageDataType);
               Assert.IsNotNull(ModelsRes.TideDataValueDepth_m);
               Assert.IsNotNull(ModelsRes.TideDataValueUVelocity_m_s);
               Assert.IsNotNull(ModelsRes.TideDataValueVVelocity_m_s);
               Assert.IsNotNull(ModelsRes.TideDataValueTideStart);
               Assert.IsNotNull(ModelsRes.TideDataValueTideEnd);
               Assert.IsNotNull(ModelsRes.TideDataValueLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.TideDataValueLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.TideDataValueTideSiteTVText);
               Assert.IsNotNull(ModelsRes.TideDataValueLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.TideDataValueTideDataTypeText);
               Assert.IsNotNull(ModelsRes.TideDataValueStorageDataTypeText);
               Assert.IsNotNull(ModelsRes.TideDataValueTideStartText);
               Assert.IsNotNull(ModelsRes.TideDataValueTideEndText);
        }
        [TestMethod]
        public void TideDataValue_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               tideDataValue.TideDataValueID = val1;
               Assert.AreEqual(val1, tideDataValue.TideDataValueID);
               int val2 = 45;
               tideDataValue.TideSiteTVItemID = val2;
               Assert.AreEqual(val2, tideDataValue.TideSiteTVItemID);
               DateTime val3 = new DateTime(2010, 3, 4);
               tideDataValue.DateTime_Local = val3;
               Assert.AreEqual(val3, tideDataValue.DateTime_Local);
               bool val4 = true;
               tideDataValue.Keep = val4;
               Assert.AreEqual(val4, tideDataValue.Keep);
               TideDataTypeEnum val5 = (TideDataTypeEnum)3;
               tideDataValue.TideDataType = val5;
               Assert.AreEqual(val5, tideDataValue.TideDataType);
               StorageDataTypeEnum val6 = (StorageDataTypeEnum)3;
               tideDataValue.StorageDataType = val6;
               Assert.AreEqual(val6, tideDataValue.StorageDataType);
               double val7 = 87.9D;
               tideDataValue.Depth_m = val7;
               Assert.AreEqual(val7, tideDataValue.Depth_m);
               double val8 = 87.9D;
               tideDataValue.UVelocity_m_s = val8;
               Assert.AreEqual(val8, tideDataValue.UVelocity_m_s);
               double val9 = 87.9D;
               tideDataValue.VVelocity_m_s = val9;
               Assert.AreEqual(val9, tideDataValue.VVelocity_m_s);
               TideTextEnum val10 = (TideTextEnum)3;
               tideDataValue.TideStart = val10;
               Assert.AreEqual(val10, tideDataValue.TideStart);
               TideTextEnum val11 = (TideTextEnum)3;
               tideDataValue.TideEnd = val11;
               Assert.AreEqual(val11, tideDataValue.TideEnd);
               DateTime val12 = new DateTime(2010, 3, 4);
               tideDataValue.LastUpdateDate_UTC = val12;
               Assert.AreEqual(val12, tideDataValue.LastUpdateDate_UTC);
               int val13 = 45;
               tideDataValue.LastUpdateContactTVItemID = val13;
               Assert.AreEqual(val13, tideDataValue.LastUpdateContactTVItemID);
               string val14 = "Some text";
               tideDataValue.TideSiteTVText = val14;
               Assert.AreEqual(val14, tideDataValue.TideSiteTVText);
               string val15 = "Some text";
               tideDataValue.LastUpdateContactTVText = val15;
               Assert.AreEqual(val15, tideDataValue.LastUpdateContactTVText);
               string val16 = "Some text";
               tideDataValue.TideDataTypeText = val16;
               Assert.AreEqual(val16, tideDataValue.TideDataTypeText);
               string val17 = "Some text";
               tideDataValue.StorageDataTypeText = val17;
               Assert.AreEqual(val17, tideDataValue.StorageDataTypeText);
               string val18 = "Some text";
               tideDataValue.TideStartText = val18;
               Assert.AreEqual(val18, tideDataValue.TideStartText);
               string val19 = "Some text";
               tideDataValue.TideEndText = val19;
               Assert.AreEqual(val19, tideDataValue.TideEndText);
               IEnumerable<ValidationResult> val60 = new List<ValidationResult>().AsEnumerable();
               tideDataValue.ValidationResults = val60;
               Assert.AreEqual(val60, tideDataValue.ValidationResults);
        }
    }
}
