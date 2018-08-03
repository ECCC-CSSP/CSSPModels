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
    public partial class AppErrLogTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private AppErrLog appErrLog { get; set; }
        private AppErrLogWeb appErrLogWeb { get; set; }
        private AppErrLogReport appErrLogReport { get; set; }
        #endregion Properties

        #region Constructors
        public AppErrLogTest()
        {
            appErrLog = new AppErrLog();
            appErrLogWeb = new AppErrLogWeb();
            appErrLogReport = new AppErrLogReport();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void AppErrLog_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "AppErrLogID", "Tag", "LineNumber", "Source", "Message", "DateTime_UTC", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AppErrLog).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(AppErrLog).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void AppErrLogWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactTVItemLanguage", "AppErrLogID", "Tag", "LineNumber", "Source", "Message", "DateTime_UTC", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AppErrLogWeb).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(AppErrLogWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void AppErrLogReport_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "AppErrLogReportTest", "LastUpdateContactTVItemLanguage", "AppErrLogID", "Tag", "LineNumber", "Source", "Message", "DateTime_UTC", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AppErrLogReport).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(AppErrLogReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void AppErrLog_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AppErrLog).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AppErrLog).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void AppErrLogWeb_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AppErrLogWeb).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AppErrLogWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void AppErrLogReport_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AppErrLogReport).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AppErrLogReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void AppErrLog_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(AppErrLog).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void AppErrLogWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(AppErrLogWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void AppErrLogReport_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(AppErrLogReport).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void AppErrLog_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               appErrLog.AppErrLogID = val1;
               Assert.AreEqual(val1, appErrLog.AppErrLogID);
               string val2 = "Some text";
               appErrLog.Tag = val2;
               Assert.AreEqual(val2, appErrLog.Tag);
               int val3 = 45;
               appErrLog.LineNumber = val3;
               Assert.AreEqual(val3, appErrLog.LineNumber);
               string val4 = "Some text";
               appErrLog.Source = val4;
               Assert.AreEqual(val4, appErrLog.Source);
               string val5 = "Some text";
               appErrLog.Message = val5;
               Assert.AreEqual(val5, appErrLog.Message);
               DateTime val6 = new DateTime(2010, 3, 4);
               appErrLog.DateTime_UTC = val6;
               Assert.AreEqual(val6, appErrLog.DateTime_UTC);
               DateTime val7 = new DateTime(2010, 3, 4);
               appErrLog.LastUpdateDate_UTC = val7;
               Assert.AreEqual(val7, appErrLog.LastUpdateDate_UTC);
               int val8 = 45;
               appErrLog.LastUpdateContactTVItemID = val8;
               Assert.AreEqual(val8, appErrLog.LastUpdateContactTVItemID);
               bool val9 = true;
               appErrLog.HasErrors = val9;
               Assert.AreEqual(val9, appErrLog.HasErrors);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               appErrLog.ValidationResults = val30;
               Assert.AreEqual(val30, appErrLog.ValidationResults);
        }
        [TestMethod]
        public void AppErrLogWeb_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               appErrLogWeb.LastUpdateContactTVItemLanguage = val1;
               Assert.AreEqual(val1, appErrLogWeb.LastUpdateContactTVItemLanguage);
               int val2 = 45;
               appErrLogWeb.AppErrLogID = val2;
               Assert.AreEqual(val2, appErrLogWeb.AppErrLogID);
               string val3 = "Some text";
               appErrLogWeb.Tag = val3;
               Assert.AreEqual(val3, appErrLogWeb.Tag);
               int val4 = 45;
               appErrLogWeb.LineNumber = val4;
               Assert.AreEqual(val4, appErrLogWeb.LineNumber);
               string val5 = "Some text";
               appErrLogWeb.Source = val5;
               Assert.AreEqual(val5, appErrLogWeb.Source);
               string val6 = "Some text";
               appErrLogWeb.Message = val6;
               Assert.AreEqual(val6, appErrLogWeb.Message);
               DateTime val7 = new DateTime(2010, 3, 4);
               appErrLogWeb.DateTime_UTC = val7;
               Assert.AreEqual(val7, appErrLogWeb.DateTime_UTC);
               DateTime val8 = new DateTime(2010, 3, 4);
               appErrLogWeb.LastUpdateDate_UTC = val8;
               Assert.AreEqual(val8, appErrLogWeb.LastUpdateDate_UTC);
               int val9 = 45;
               appErrLogWeb.LastUpdateContactTVItemID = val9;
               Assert.AreEqual(val9, appErrLogWeb.LastUpdateContactTVItemID);
               bool val10 = true;
               appErrLogWeb.HasErrors = val10;
               Assert.AreEqual(val10, appErrLogWeb.HasErrors);
               IEnumerable<ValidationResult> val33 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               appErrLogWeb.ValidationResults = val33;
               Assert.AreEqual(val33, appErrLogWeb.ValidationResults);
        }
        [TestMethod]
        public void AppErrLogReport_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               appErrLogReport.AppErrLogReportTest = val1;
               Assert.AreEqual(val1, appErrLogReport.AppErrLogReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               appErrLogReport.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, appErrLogReport.LastUpdateContactTVItemLanguage);
               int val3 = 45;
               appErrLogReport.AppErrLogID = val3;
               Assert.AreEqual(val3, appErrLogReport.AppErrLogID);
               string val4 = "Some text";
               appErrLogReport.Tag = val4;
               Assert.AreEqual(val4, appErrLogReport.Tag);
               int val5 = 45;
               appErrLogReport.LineNumber = val5;
               Assert.AreEqual(val5, appErrLogReport.LineNumber);
               string val6 = "Some text";
               appErrLogReport.Source = val6;
               Assert.AreEqual(val6, appErrLogReport.Source);
               string val7 = "Some text";
               appErrLogReport.Message = val7;
               Assert.AreEqual(val7, appErrLogReport.Message);
               DateTime val8 = new DateTime(2010, 3, 4);
               appErrLogReport.DateTime_UTC = val8;
               Assert.AreEqual(val8, appErrLogReport.DateTime_UTC);
               DateTime val9 = new DateTime(2010, 3, 4);
               appErrLogReport.LastUpdateDate_UTC = val9;
               Assert.AreEqual(val9, appErrLogReport.LastUpdateDate_UTC);
               int val10 = 45;
               appErrLogReport.LastUpdateContactTVItemID = val10;
               Assert.AreEqual(val10, appErrLogReport.LastUpdateContactTVItemID);
               bool val11 = true;
               appErrLogReport.HasErrors = val11;
               Assert.AreEqual(val11, appErrLogReport.HasErrors);
               IEnumerable<ValidationResult> val36 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               appErrLogReport.ValidationResults = val36;
               Assert.AreEqual(val36, appErrLogReport.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
