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
    public partial class TideDataValueTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private TideDataValue tideDataValue { get; set; }
        private TideDataValueWeb tideDataValueWeb { get; set; }
        private TideDataValueReport tideDataValueReport { get; set; }
        #endregion Properties

        #region Constructors
        public TideDataValueTest()
        {
            tideDataValue = new TideDataValue();
            tideDataValueWeb = new TideDataValueWeb();
            tideDataValueReport = new TideDataValueReport();
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
        public void TideDataValueWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TideSiteTVItemLanguage", "LastUpdateContactTVItemLanguage", "TideDataTypeText", "StorageDataTypeText", "TideStartText", "TideEndText", "TideDataValueID", "TideSiteTVItemID", "DateTime_Local", "Keep", "TideDataType", "StorageDataType", "Depth_m", "UVelocity_m_s", "VVelocity_m_s", "TideStart", "TideEnd", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideDataValueWeb).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TideDataValueWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TideDataValueReport_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TideDataValueReportTest", "TideSiteTVItemLanguage", "LastUpdateContactTVItemLanguage", "TideDataTypeText", "StorageDataTypeText", "TideStartText", "TideEndText", "TideDataValueID", "TideSiteTVItemID", "DateTime_Local", "Keep", "TideDataType", "StorageDataType", "Depth_m", "UVelocity_m_s", "VVelocity_m_s", "TideStart", "TideEnd", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideDataValueReport).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TideDataValueReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TideDataValueWeb_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideDataValueWeb).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideDataValueWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TideDataValueReport_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideDataValueReport).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideDataValueReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TideDataValueWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TideDataValueWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TideDataValueReport_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TideDataValueReport).GetProperties().Where(c => c.Name == "ValidationResults").Any());
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
        public void TideDataValueWeb_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               tideDataValueWeb.TideSiteTVItemLanguage = val1;
               Assert.AreEqual(val1, tideDataValueWeb.TideSiteTVItemLanguage);
               TVItemLanguage val2 = new TVItemLanguage();
               tideDataValueWeb.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, tideDataValueWeb.LastUpdateContactTVItemLanguage);
               string val3 = "Some text";
               tideDataValueWeb.TideDataTypeText = val3;
               Assert.AreEqual(val3, tideDataValueWeb.TideDataTypeText);
               string val4 = "Some text";
               tideDataValueWeb.StorageDataTypeText = val4;
               Assert.AreEqual(val4, tideDataValueWeb.StorageDataTypeText);
               string val5 = "Some text";
               tideDataValueWeb.TideStartText = val5;
               Assert.AreEqual(val5, tideDataValueWeb.TideStartText);
               string val6 = "Some text";
               tideDataValueWeb.TideEndText = val6;
               Assert.AreEqual(val6, tideDataValueWeb.TideEndText);
               int val7 = 45;
               tideDataValueWeb.TideDataValueID = val7;
               Assert.AreEqual(val7, tideDataValueWeb.TideDataValueID);
               int val8 = 45;
               tideDataValueWeb.TideSiteTVItemID = val8;
               Assert.AreEqual(val8, tideDataValueWeb.TideSiteTVItemID);
               DateTime val9 = new DateTime(2010, 3, 4);
               tideDataValueWeb.DateTime_Local = val9;
               Assert.AreEqual(val9, tideDataValueWeb.DateTime_Local);
               bool val10 = true;
               tideDataValueWeb.Keep = val10;
               Assert.AreEqual(val10, tideDataValueWeb.Keep);
               TideDataTypeEnum val11 = (TideDataTypeEnum)3;
               tideDataValueWeb.TideDataType = val11;
               Assert.AreEqual(val11, tideDataValueWeb.TideDataType);
               StorageDataTypeEnum val12 = (StorageDataTypeEnum)3;
               tideDataValueWeb.StorageDataType = val12;
               Assert.AreEqual(val12, tideDataValueWeb.StorageDataType);
               double val13 = 87.9D;
               tideDataValueWeb.Depth_m = val13;
               Assert.AreEqual(val13, tideDataValueWeb.Depth_m);
               double val14 = 87.9D;
               tideDataValueWeb.UVelocity_m_s = val14;
               Assert.AreEqual(val14, tideDataValueWeb.UVelocity_m_s);
               double val15 = 87.9D;
               tideDataValueWeb.VVelocity_m_s = val15;
               Assert.AreEqual(val15, tideDataValueWeb.VVelocity_m_s);
               TideTextEnum val16 = (TideTextEnum)3;
               tideDataValueWeb.TideStart = val16;
               Assert.AreEqual(val16, tideDataValueWeb.TideStart);
               TideTextEnum val17 = (TideTextEnum)3;
               tideDataValueWeb.TideEnd = val17;
               Assert.AreEqual(val17, tideDataValueWeb.TideEnd);
               DateTime val18 = new DateTime(2010, 3, 4);
               tideDataValueWeb.LastUpdateDate_UTC = val18;
               Assert.AreEqual(val18, tideDataValueWeb.LastUpdateDate_UTC);
               int val19 = 45;
               tideDataValueWeb.LastUpdateContactTVItemID = val19;
               Assert.AreEqual(val19, tideDataValueWeb.LastUpdateContactTVItemID);
               bool val20 = true;
               tideDataValueWeb.HasErrors = val20;
               Assert.AreEqual(val20, tideDataValueWeb.HasErrors);
               IEnumerable<ValidationResult> val63 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               tideDataValueWeb.ValidationResults = val63;
               Assert.AreEqual(val63, tideDataValueWeb.ValidationResults);
        }
        [TestMethod]
        public void TideDataValueReport_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               tideDataValueReport.TideDataValueReportTest = val1;
               Assert.AreEqual(val1, tideDataValueReport.TideDataValueReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               tideDataValueReport.TideSiteTVItemLanguage = val2;
               Assert.AreEqual(val2, tideDataValueReport.TideSiteTVItemLanguage);
               TVItemLanguage val3 = new TVItemLanguage();
               tideDataValueReport.LastUpdateContactTVItemLanguage = val3;
               Assert.AreEqual(val3, tideDataValueReport.LastUpdateContactTVItemLanguage);
               string val4 = "Some text";
               tideDataValueReport.TideDataTypeText = val4;
               Assert.AreEqual(val4, tideDataValueReport.TideDataTypeText);
               string val5 = "Some text";
               tideDataValueReport.StorageDataTypeText = val5;
               Assert.AreEqual(val5, tideDataValueReport.StorageDataTypeText);
               string val6 = "Some text";
               tideDataValueReport.TideStartText = val6;
               Assert.AreEqual(val6, tideDataValueReport.TideStartText);
               string val7 = "Some text";
               tideDataValueReport.TideEndText = val7;
               Assert.AreEqual(val7, tideDataValueReport.TideEndText);
               int val8 = 45;
               tideDataValueReport.TideDataValueID = val8;
               Assert.AreEqual(val8, tideDataValueReport.TideDataValueID);
               int val9 = 45;
               tideDataValueReport.TideSiteTVItemID = val9;
               Assert.AreEqual(val9, tideDataValueReport.TideSiteTVItemID);
               DateTime val10 = new DateTime(2010, 3, 4);
               tideDataValueReport.DateTime_Local = val10;
               Assert.AreEqual(val10, tideDataValueReport.DateTime_Local);
               bool val11 = true;
               tideDataValueReport.Keep = val11;
               Assert.AreEqual(val11, tideDataValueReport.Keep);
               TideDataTypeEnum val12 = (TideDataTypeEnum)3;
               tideDataValueReport.TideDataType = val12;
               Assert.AreEqual(val12, tideDataValueReport.TideDataType);
               StorageDataTypeEnum val13 = (StorageDataTypeEnum)3;
               tideDataValueReport.StorageDataType = val13;
               Assert.AreEqual(val13, tideDataValueReport.StorageDataType);
               double val14 = 87.9D;
               tideDataValueReport.Depth_m = val14;
               Assert.AreEqual(val14, tideDataValueReport.Depth_m);
               double val15 = 87.9D;
               tideDataValueReport.UVelocity_m_s = val15;
               Assert.AreEqual(val15, tideDataValueReport.UVelocity_m_s);
               double val16 = 87.9D;
               tideDataValueReport.VVelocity_m_s = val16;
               Assert.AreEqual(val16, tideDataValueReport.VVelocity_m_s);
               TideTextEnum val17 = (TideTextEnum)3;
               tideDataValueReport.TideStart = val17;
               Assert.AreEqual(val17, tideDataValueReport.TideStart);
               TideTextEnum val18 = (TideTextEnum)3;
               tideDataValueReport.TideEnd = val18;
               Assert.AreEqual(val18, tideDataValueReport.TideEnd);
               DateTime val19 = new DateTime(2010, 3, 4);
               tideDataValueReport.LastUpdateDate_UTC = val19;
               Assert.AreEqual(val19, tideDataValueReport.LastUpdateDate_UTC);
               int val20 = 45;
               tideDataValueReport.LastUpdateContactTVItemID = val20;
               Assert.AreEqual(val20, tideDataValueReport.LastUpdateContactTVItemID);
               bool val21 = true;
               tideDataValueReport.HasErrors = val21;
               Assert.AreEqual(val21, tideDataValueReport.HasErrors);
               IEnumerable<ValidationResult> val66 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               tideDataValueReport.ValidationResults = val66;
               Assert.AreEqual(val66, tideDataValueReport.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
