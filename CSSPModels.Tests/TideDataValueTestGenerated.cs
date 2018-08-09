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
    public partial class TideDataValueTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private TideDataValue tideDataValue { get; set; }
        private TideDataValue_A tideDataValue_A { get; set; }
        private TideDataValue_B tideDataValue_B { get; set; }
        #endregion Properties

        #region Constructors
        public TideDataValueTest()
        {
            tideDataValue = new TideDataValue();
            tideDataValue_A = new TideDataValue_A();
            tideDataValue_B = new TideDataValue_B();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void TideDataValue_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TideDataValueID", "TideSiteTVItemID", "DateTime_Local", "Keep", "TideDataType", "StorageDataType", "Depth_m", "UVelocity_m_s", "VVelocity_m_s", "TideStart", "TideEnd", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideDataValue).GetProperties().OrderBy(c => c.Name))
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
        public void TideDataValue_A_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TideSiteTVItemLanguage", "LastUpdateContactTVItemLanguage", "TideDataTypeText", "StorageDataTypeText", "TideStartText", "TideEndText", "TideDataValueID", "TideSiteTVItemID", "DateTime_Local", "Keep", "TideDataType", "StorageDataType", "Depth_m", "UVelocity_m_s", "VVelocity_m_s", "TideStart", "TideEnd", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideDataValue_A).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TideDataValue_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TideDataValue_B_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TideDataValueReportTest", "TideSiteTVItemLanguage", "LastUpdateContactTVItemLanguage", "TideDataTypeText", "StorageDataTypeText", "TideStartText", "TideEndText", "TideDataValueID", "TideSiteTVItemID", "DateTime_Local", "Keep", "TideDataType", "StorageDataType", "Depth_m", "UVelocity_m_s", "VVelocity_m_s", "TideStart", "TideEnd", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideDataValue_B).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TideDataValue_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TideDataValue_A_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideDataValue_A).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideDataValue_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TideDataValue_B_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideDataValue_B).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideDataValue_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TideDataValue_A_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TideDataValue_A).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TideDataValue_B_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TideDataValue_B).GetProperties().Where(c => c.Name == "ValidationResults").Any());
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
               bool val14 = true;
               tideDataValue.HasErrors = val14;
               Assert.AreEqual(val14, tideDataValue.HasErrors);
               IEnumerable<ValidationResult> val45 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               tideDataValue.ValidationResults = val45;
               Assert.AreEqual(val45, tideDataValue.ValidationResults);
        }
        [TestMethod]
        public void TideDataValue_A_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               tideDataValue_A.TideSiteTVItemLanguage = val1;
               Assert.AreEqual(val1, tideDataValue_A.TideSiteTVItemLanguage);
               TVItemLanguage val2 = new TVItemLanguage();
               tideDataValue_A.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, tideDataValue_A.LastUpdateContactTVItemLanguage);
               string val3 = "Some text";
               tideDataValue_A.TideDataTypeText = val3;
               Assert.AreEqual(val3, tideDataValue_A.TideDataTypeText);
               string val4 = "Some text";
               tideDataValue_A.StorageDataTypeText = val4;
               Assert.AreEqual(val4, tideDataValue_A.StorageDataTypeText);
               string val5 = "Some text";
               tideDataValue_A.TideStartText = val5;
               Assert.AreEqual(val5, tideDataValue_A.TideStartText);
               string val6 = "Some text";
               tideDataValue_A.TideEndText = val6;
               Assert.AreEqual(val6, tideDataValue_A.TideEndText);
               int val7 = 45;
               tideDataValue_A.TideDataValueID = val7;
               Assert.AreEqual(val7, tideDataValue_A.TideDataValueID);
               int val8 = 45;
               tideDataValue_A.TideSiteTVItemID = val8;
               Assert.AreEqual(val8, tideDataValue_A.TideSiteTVItemID);
               DateTime val9 = new DateTime(2010, 3, 4);
               tideDataValue_A.DateTime_Local = val9;
               Assert.AreEqual(val9, tideDataValue_A.DateTime_Local);
               bool val10 = true;
               tideDataValue_A.Keep = val10;
               Assert.AreEqual(val10, tideDataValue_A.Keep);
               TideDataTypeEnum val11 = (TideDataTypeEnum)3;
               tideDataValue_A.TideDataType = val11;
               Assert.AreEqual(val11, tideDataValue_A.TideDataType);
               StorageDataTypeEnum val12 = (StorageDataTypeEnum)3;
               tideDataValue_A.StorageDataType = val12;
               Assert.AreEqual(val12, tideDataValue_A.StorageDataType);
               double val13 = 87.9D;
               tideDataValue_A.Depth_m = val13;
               Assert.AreEqual(val13, tideDataValue_A.Depth_m);
               double val14 = 87.9D;
               tideDataValue_A.UVelocity_m_s = val14;
               Assert.AreEqual(val14, tideDataValue_A.UVelocity_m_s);
               double val15 = 87.9D;
               tideDataValue_A.VVelocity_m_s = val15;
               Assert.AreEqual(val15, tideDataValue_A.VVelocity_m_s);
               TideTextEnum val16 = (TideTextEnum)3;
               tideDataValue_A.TideStart = val16;
               Assert.AreEqual(val16, tideDataValue_A.TideStart);
               TideTextEnum val17 = (TideTextEnum)3;
               tideDataValue_A.TideEnd = val17;
               Assert.AreEqual(val17, tideDataValue_A.TideEnd);
               DateTime val18 = new DateTime(2010, 3, 4);
               tideDataValue_A.LastUpdateDate_UTC = val18;
               Assert.AreEqual(val18, tideDataValue_A.LastUpdateDate_UTC);
               int val19 = 45;
               tideDataValue_A.LastUpdateContactTVItemID = val19;
               Assert.AreEqual(val19, tideDataValue_A.LastUpdateContactTVItemID);
               bool val20 = true;
               tideDataValue_A.HasErrors = val20;
               Assert.AreEqual(val20, tideDataValue_A.HasErrors);
               IEnumerable<ValidationResult> val63 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               tideDataValue_A.ValidationResults = val63;
               Assert.AreEqual(val63, tideDataValue_A.ValidationResults);
        }
        [TestMethod]
        public void TideDataValue_B_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               tideDataValue_B.TideDataValueReportTest = val1;
               Assert.AreEqual(val1, tideDataValue_B.TideDataValueReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               tideDataValue_B.TideSiteTVItemLanguage = val2;
               Assert.AreEqual(val2, tideDataValue_B.TideSiteTVItemLanguage);
               TVItemLanguage val3 = new TVItemLanguage();
               tideDataValue_B.LastUpdateContactTVItemLanguage = val3;
               Assert.AreEqual(val3, tideDataValue_B.LastUpdateContactTVItemLanguage);
               string val4 = "Some text";
               tideDataValue_B.TideDataTypeText = val4;
               Assert.AreEqual(val4, tideDataValue_B.TideDataTypeText);
               string val5 = "Some text";
               tideDataValue_B.StorageDataTypeText = val5;
               Assert.AreEqual(val5, tideDataValue_B.StorageDataTypeText);
               string val6 = "Some text";
               tideDataValue_B.TideStartText = val6;
               Assert.AreEqual(val6, tideDataValue_B.TideStartText);
               string val7 = "Some text";
               tideDataValue_B.TideEndText = val7;
               Assert.AreEqual(val7, tideDataValue_B.TideEndText);
               int val8 = 45;
               tideDataValue_B.TideDataValueID = val8;
               Assert.AreEqual(val8, tideDataValue_B.TideDataValueID);
               int val9 = 45;
               tideDataValue_B.TideSiteTVItemID = val9;
               Assert.AreEqual(val9, tideDataValue_B.TideSiteTVItemID);
               DateTime val10 = new DateTime(2010, 3, 4);
               tideDataValue_B.DateTime_Local = val10;
               Assert.AreEqual(val10, tideDataValue_B.DateTime_Local);
               bool val11 = true;
               tideDataValue_B.Keep = val11;
               Assert.AreEqual(val11, tideDataValue_B.Keep);
               TideDataTypeEnum val12 = (TideDataTypeEnum)3;
               tideDataValue_B.TideDataType = val12;
               Assert.AreEqual(val12, tideDataValue_B.TideDataType);
               StorageDataTypeEnum val13 = (StorageDataTypeEnum)3;
               tideDataValue_B.StorageDataType = val13;
               Assert.AreEqual(val13, tideDataValue_B.StorageDataType);
               double val14 = 87.9D;
               tideDataValue_B.Depth_m = val14;
               Assert.AreEqual(val14, tideDataValue_B.Depth_m);
               double val15 = 87.9D;
               tideDataValue_B.UVelocity_m_s = val15;
               Assert.AreEqual(val15, tideDataValue_B.UVelocity_m_s);
               double val16 = 87.9D;
               tideDataValue_B.VVelocity_m_s = val16;
               Assert.AreEqual(val16, tideDataValue_B.VVelocity_m_s);
               TideTextEnum val17 = (TideTextEnum)3;
               tideDataValue_B.TideStart = val17;
               Assert.AreEqual(val17, tideDataValue_B.TideStart);
               TideTextEnum val18 = (TideTextEnum)3;
               tideDataValue_B.TideEnd = val18;
               Assert.AreEqual(val18, tideDataValue_B.TideEnd);
               DateTime val19 = new DateTime(2010, 3, 4);
               tideDataValue_B.LastUpdateDate_UTC = val19;
               Assert.AreEqual(val19, tideDataValue_B.LastUpdateDate_UTC);
               int val20 = 45;
               tideDataValue_B.LastUpdateContactTVItemID = val20;
               Assert.AreEqual(val20, tideDataValue_B.LastUpdateContactTVItemID);
               bool val21 = true;
               tideDataValue_B.HasErrors = val21;
               Assert.AreEqual(val21, tideDataValue_B.HasErrors);
               IEnumerable<ValidationResult> val66 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               tideDataValue_B.ValidationResults = val66;
               Assert.AreEqual(val66, tideDataValue_B.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
