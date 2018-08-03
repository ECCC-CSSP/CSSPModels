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
    public partial class ReportTypeTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private ReportType reportType { get; set; }
        private ReportTypeWeb reportTypeWeb { get; set; }
        private ReportTypeReport reportTypeReport { get; set; }
        #endregion Properties

        #region Constructors
        public ReportTypeTest()
        {
            reportType = new ReportType();
            reportTypeWeb = new ReportTypeWeb();
            reportTypeReport = new ReportTypeReport();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void ReportType_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ReportTypeID", "TVType", "FileType", "UniqueCode", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ReportType).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(ReportType).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ReportTypeWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactTVItemLanguage", "ReportTypeID", "TVType", "FileType", "UniqueCode", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ReportTypeWeb).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(ReportTypeWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ReportTypeReport_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ReportTypeReportTest", "LastUpdateContactTVItemLanguage", "ReportTypeID", "TVType", "FileType", "UniqueCode", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ReportTypeReport).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(ReportTypeReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ReportType_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ReportType).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ReportType).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ReportTypeWeb_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ReportTypeWeb).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ReportTypeWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ReportTypeReport_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ReportTypeReport).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ReportTypeReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ReportType_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ReportType).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ReportTypeWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ReportTypeWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ReportTypeReport_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ReportTypeReport).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ReportType_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               reportType.ReportTypeID = val1;
               Assert.AreEqual(val1, reportType.ReportTypeID);
               TVTypeEnum val2 = (TVTypeEnum)3;
               reportType.TVType = val2;
               Assert.AreEqual(val2, reportType.TVType);
               FileTypeEnum val3 = (FileTypeEnum)3;
               reportType.FileType = val3;
               Assert.AreEqual(val3, reportType.FileType);
               string val4 = "Some text";
               reportType.UniqueCode = val4;
               Assert.AreEqual(val4, reportType.UniqueCode);
               DateTime val5 = new DateTime(2010, 3, 4);
               reportType.LastUpdateDate_UTC = val5;
               Assert.AreEqual(val5, reportType.LastUpdateDate_UTC);
               int val6 = 45;
               reportType.LastUpdateContactTVItemID = val6;
               Assert.AreEqual(val6, reportType.LastUpdateContactTVItemID);
               bool val7 = true;
               reportType.HasErrors = val7;
               Assert.AreEqual(val7, reportType.HasErrors);
               IEnumerable<ValidationResult> val24 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               reportType.ValidationResults = val24;
               Assert.AreEqual(val24, reportType.ValidationResults);
        }
        [TestMethod]
        public void ReportTypeWeb_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               reportTypeWeb.LastUpdateContactTVItemLanguage = val1;
               Assert.AreEqual(val1, reportTypeWeb.LastUpdateContactTVItemLanguage);
               int val2 = 45;
               reportTypeWeb.ReportTypeID = val2;
               Assert.AreEqual(val2, reportTypeWeb.ReportTypeID);
               TVTypeEnum val3 = (TVTypeEnum)3;
               reportTypeWeb.TVType = val3;
               Assert.AreEqual(val3, reportTypeWeb.TVType);
               FileTypeEnum val4 = (FileTypeEnum)3;
               reportTypeWeb.FileType = val4;
               Assert.AreEqual(val4, reportTypeWeb.FileType);
               string val5 = "Some text";
               reportTypeWeb.UniqueCode = val5;
               Assert.AreEqual(val5, reportTypeWeb.UniqueCode);
               DateTime val6 = new DateTime(2010, 3, 4);
               reportTypeWeb.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, reportTypeWeb.LastUpdateDate_UTC);
               int val7 = 45;
               reportTypeWeb.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, reportTypeWeb.LastUpdateContactTVItemID);
               bool val8 = true;
               reportTypeWeb.HasErrors = val8;
               Assert.AreEqual(val8, reportTypeWeb.HasErrors);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               reportTypeWeb.ValidationResults = val27;
               Assert.AreEqual(val27, reportTypeWeb.ValidationResults);
        }
        [TestMethod]
        public void ReportTypeReport_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               reportTypeReport.ReportTypeReportTest = val1;
               Assert.AreEqual(val1, reportTypeReport.ReportTypeReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               reportTypeReport.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, reportTypeReport.LastUpdateContactTVItemLanguage);
               int val3 = 45;
               reportTypeReport.ReportTypeID = val3;
               Assert.AreEqual(val3, reportTypeReport.ReportTypeID);
               TVTypeEnum val4 = (TVTypeEnum)3;
               reportTypeReport.TVType = val4;
               Assert.AreEqual(val4, reportTypeReport.TVType);
               FileTypeEnum val5 = (FileTypeEnum)3;
               reportTypeReport.FileType = val5;
               Assert.AreEqual(val5, reportTypeReport.FileType);
               string val6 = "Some text";
               reportTypeReport.UniqueCode = val6;
               Assert.AreEqual(val6, reportTypeReport.UniqueCode);
               DateTime val7 = new DateTime(2010, 3, 4);
               reportTypeReport.LastUpdateDate_UTC = val7;
               Assert.AreEqual(val7, reportTypeReport.LastUpdateDate_UTC);
               int val8 = 45;
               reportTypeReport.LastUpdateContactTVItemID = val8;
               Assert.AreEqual(val8, reportTypeReport.LastUpdateContactTVItemID);
               bool val9 = true;
               reportTypeReport.HasErrors = val9;
               Assert.AreEqual(val9, reportTypeReport.HasErrors);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               reportTypeReport.ValidationResults = val30;
               Assert.AreEqual(val30, reportTypeReport.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
