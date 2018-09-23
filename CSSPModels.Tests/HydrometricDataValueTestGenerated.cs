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
    public partial class HydrometricDataValueTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private HydrometricDataValue hydrometricDataValue { get; set; }
        private HydrometricDataValue_A hydrometricDataValue_A { get; set; }
        private HydrometricDataValue_B hydrometricDataValue_B { get; set; }
        #endregion Properties

        #region Constructors
        public HydrometricDataValueTest()
        {
            hydrometricDataValue = new HydrometricDataValue();
            hydrometricDataValue_A = new HydrometricDataValue_A();
            hydrometricDataValue_B = new HydrometricDataValue_B();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void HydrometricDataValue_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "HydrometricDataValueID", "HydrometricSiteID", "DateTime_Local", "Keep", "StorageDataType", "HasBeenRead", "Discharge_m3_s", "DischargeEntered_m3_s", "Level_m", "HourlyValues", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(HydrometricDataValue).GetProperties().OrderBy(c => c.Name))
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
        public void HydrometricDataValue_A_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactTVItemLanguage", "StorageDataTypeText", "HydrometricDataValueID", "HydrometricSiteID", "DateTime_Local", "Keep", "StorageDataType", "HasBeenRead", "Discharge_m3_s", "DischargeEntered_m3_s", "Level_m", "HourlyValues", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(HydrometricDataValue_A).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(HydrometricDataValue_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void HydrometricDataValue_B_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "HydrometricDataValueReportTest", "LastUpdateContactTVItemLanguage", "StorageDataTypeText", "HydrometricDataValueID", "HydrometricSiteID", "DateTime_Local", "Keep", "StorageDataType", "HasBeenRead", "Discharge_m3_s", "DischargeEntered_m3_s", "Level_m", "HourlyValues", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(HydrometricDataValue_B).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(HydrometricDataValue_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void HydrometricDataValue_A_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(HydrometricDataValue_A).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(HydrometricDataValue_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void HydrometricDataValue_B_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(HydrometricDataValue_B).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(HydrometricDataValue_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void HydrometricDataValue_A_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(HydrometricDataValue_A).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void HydrometricDataValue_B_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(HydrometricDataValue_B).GetProperties().Where(c => c.Name == "ValidationResults").Any());
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
               bool val6 = true;
               hydrometricDataValue.HasBeenRead = val6;
               Assert.AreEqual(val6, hydrometricDataValue.HasBeenRead);
               double val7 = 87.9D;
               hydrometricDataValue.Discharge_m3_s = val7;
               Assert.AreEqual(val7, hydrometricDataValue.Discharge_m3_s);
               double val8 = 87.9D;
               hydrometricDataValue.DischargeEntered_m3_s = val8;
               Assert.AreEqual(val8, hydrometricDataValue.DischargeEntered_m3_s);
               double val9 = 87.9D;
               hydrometricDataValue.Level_m = val9;
               Assert.AreEqual(val9, hydrometricDataValue.Level_m);
               string val10 = "Some text";
               hydrometricDataValue.HourlyValues = val10;
               Assert.AreEqual(val10, hydrometricDataValue.HourlyValues);
               DateTime val11 = new DateTime(2010, 3, 4);
               hydrometricDataValue.LastUpdateDate_UTC = val11;
               Assert.AreEqual(val11, hydrometricDataValue.LastUpdateDate_UTC);
               int val12 = 45;
               hydrometricDataValue.LastUpdateContactTVItemID = val12;
               Assert.AreEqual(val12, hydrometricDataValue.LastUpdateContactTVItemID);
               bool val13 = true;
               hydrometricDataValue.HasErrors = val13;
               Assert.AreEqual(val13, hydrometricDataValue.HasErrors);
               IEnumerable<ValidationResult> val42 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               hydrometricDataValue.ValidationResults = val42;
               Assert.AreEqual(val42, hydrometricDataValue.ValidationResults);
        }
        [TestMethod]
        public void HydrometricDataValue_A_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               hydrometricDataValue_A.LastUpdateContactTVItemLanguage = val1;
               Assert.AreEqual(val1, hydrometricDataValue_A.LastUpdateContactTVItemLanguage);
               string val2 = "Some text";
               hydrometricDataValue_A.StorageDataTypeText = val2;
               Assert.AreEqual(val2, hydrometricDataValue_A.StorageDataTypeText);
               int val3 = 45;
               hydrometricDataValue_A.HydrometricDataValueID = val3;
               Assert.AreEqual(val3, hydrometricDataValue_A.HydrometricDataValueID);
               int val4 = 45;
               hydrometricDataValue_A.HydrometricSiteID = val4;
               Assert.AreEqual(val4, hydrometricDataValue_A.HydrometricSiteID);
               DateTime val5 = new DateTime(2010, 3, 4);
               hydrometricDataValue_A.DateTime_Local = val5;
               Assert.AreEqual(val5, hydrometricDataValue_A.DateTime_Local);
               bool val6 = true;
               hydrometricDataValue_A.Keep = val6;
               Assert.AreEqual(val6, hydrometricDataValue_A.Keep);
               StorageDataTypeEnum val7 = (StorageDataTypeEnum)3;
               hydrometricDataValue_A.StorageDataType = val7;
               Assert.AreEqual(val7, hydrometricDataValue_A.StorageDataType);
               bool val8 = true;
               hydrometricDataValue_A.HasBeenRead = val8;
               Assert.AreEqual(val8, hydrometricDataValue_A.HasBeenRead);
               double val9 = 87.9D;
               hydrometricDataValue_A.Discharge_m3_s = val9;
               Assert.AreEqual(val9, hydrometricDataValue_A.Discharge_m3_s);
               double val10 = 87.9D;
               hydrometricDataValue_A.DischargeEntered_m3_s = val10;
               Assert.AreEqual(val10, hydrometricDataValue_A.DischargeEntered_m3_s);
               double val11 = 87.9D;
               hydrometricDataValue_A.Level_m = val11;
               Assert.AreEqual(val11, hydrometricDataValue_A.Level_m);
               string val12 = "Some text";
               hydrometricDataValue_A.HourlyValues = val12;
               Assert.AreEqual(val12, hydrometricDataValue_A.HourlyValues);
               DateTime val13 = new DateTime(2010, 3, 4);
               hydrometricDataValue_A.LastUpdateDate_UTC = val13;
               Assert.AreEqual(val13, hydrometricDataValue_A.LastUpdateDate_UTC);
               int val14 = 45;
               hydrometricDataValue_A.LastUpdateContactTVItemID = val14;
               Assert.AreEqual(val14, hydrometricDataValue_A.LastUpdateContactTVItemID);
               bool val15 = true;
               hydrometricDataValue_A.HasErrors = val15;
               Assert.AreEqual(val15, hydrometricDataValue_A.HasErrors);
               IEnumerable<ValidationResult> val48 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               hydrometricDataValue_A.ValidationResults = val48;
               Assert.AreEqual(val48, hydrometricDataValue_A.ValidationResults);
        }
        [TestMethod]
        public void HydrometricDataValue_B_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               hydrometricDataValue_B.HydrometricDataValueReportTest = val1;
               Assert.AreEqual(val1, hydrometricDataValue_B.HydrometricDataValueReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               hydrometricDataValue_B.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, hydrometricDataValue_B.LastUpdateContactTVItemLanguage);
               string val3 = "Some text";
               hydrometricDataValue_B.StorageDataTypeText = val3;
               Assert.AreEqual(val3, hydrometricDataValue_B.StorageDataTypeText);
               int val4 = 45;
               hydrometricDataValue_B.HydrometricDataValueID = val4;
               Assert.AreEqual(val4, hydrometricDataValue_B.HydrometricDataValueID);
               int val5 = 45;
               hydrometricDataValue_B.HydrometricSiteID = val5;
               Assert.AreEqual(val5, hydrometricDataValue_B.HydrometricSiteID);
               DateTime val6 = new DateTime(2010, 3, 4);
               hydrometricDataValue_B.DateTime_Local = val6;
               Assert.AreEqual(val6, hydrometricDataValue_B.DateTime_Local);
               bool val7 = true;
               hydrometricDataValue_B.Keep = val7;
               Assert.AreEqual(val7, hydrometricDataValue_B.Keep);
               StorageDataTypeEnum val8 = (StorageDataTypeEnum)3;
               hydrometricDataValue_B.StorageDataType = val8;
               Assert.AreEqual(val8, hydrometricDataValue_B.StorageDataType);
               bool val9 = true;
               hydrometricDataValue_B.HasBeenRead = val9;
               Assert.AreEqual(val9, hydrometricDataValue_B.HasBeenRead);
               double val10 = 87.9D;
               hydrometricDataValue_B.Discharge_m3_s = val10;
               Assert.AreEqual(val10, hydrometricDataValue_B.Discharge_m3_s);
               double val11 = 87.9D;
               hydrometricDataValue_B.DischargeEntered_m3_s = val11;
               Assert.AreEqual(val11, hydrometricDataValue_B.DischargeEntered_m3_s);
               double val12 = 87.9D;
               hydrometricDataValue_B.Level_m = val12;
               Assert.AreEqual(val12, hydrometricDataValue_B.Level_m);
               string val13 = "Some text";
               hydrometricDataValue_B.HourlyValues = val13;
               Assert.AreEqual(val13, hydrometricDataValue_B.HourlyValues);
               DateTime val14 = new DateTime(2010, 3, 4);
               hydrometricDataValue_B.LastUpdateDate_UTC = val14;
               Assert.AreEqual(val14, hydrometricDataValue_B.LastUpdateDate_UTC);
               int val15 = 45;
               hydrometricDataValue_B.LastUpdateContactTVItemID = val15;
               Assert.AreEqual(val15, hydrometricDataValue_B.LastUpdateContactTVItemID);
               bool val16 = true;
               hydrometricDataValue_B.HasErrors = val16;
               Assert.AreEqual(val16, hydrometricDataValue_B.HasErrors);
               IEnumerable<ValidationResult> val51 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               hydrometricDataValue_B.ValidationResults = val51;
               Assert.AreEqual(val51, hydrometricDataValue_B.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
