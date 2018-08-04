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
    public partial class TideSiteTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private TideSite tideSite { get; set; }
        private TideSiteWeb tideSiteWeb { get; set; }
        private TideSiteReport tideSiteReport { get; set; }
        #endregion Properties

        #region Constructors
        public TideSiteTest()
        {
            tideSite = new TideSite();
            tideSiteWeb = new TideSiteWeb();
            tideSiteReport = new TideSiteReport();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void TideSite_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TideSiteID", "TideSiteTVItemID", "WebTideModel", "WebTideDatum_m", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideSite).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TideSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TideSiteWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TideSiteTVItemLanguage", "LastUpdateContactTVItemLanguage", "TideSiteID", "TideSiteTVItemID", "WebTideModel", "WebTideDatum_m", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideSiteWeb).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TideSiteWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TideSiteReport_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TideSiteReportTest", "TideSiteTVItemLanguage", "LastUpdateContactTVItemLanguage", "TideSiteID", "TideSiteTVItemID", "WebTideModel", "WebTideDatum_m", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideSiteReport).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TideSiteReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TideSite_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideSite).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TideSiteWeb_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideSiteWeb).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideSiteWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TideSiteReport_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideSiteReport).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideSiteReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TideSite_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TideSite).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TideSiteWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TideSiteWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TideSiteReport_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TideSiteReport).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TideSite_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               tideSite.TideSiteID = val1;
               Assert.AreEqual(val1, tideSite.TideSiteID);
               int val2 = 45;
               tideSite.TideSiteTVItemID = val2;
               Assert.AreEqual(val2, tideSite.TideSiteTVItemID);
               string val3 = "Some text";
               tideSite.WebTideModel = val3;
               Assert.AreEqual(val3, tideSite.WebTideModel);
               double val4 = 87.9D;
               tideSite.WebTideDatum_m = val4;
               Assert.AreEqual(val4, tideSite.WebTideDatum_m);
               DateTime val5 = new DateTime(2010, 3, 4);
               tideSite.LastUpdateDate_UTC = val5;
               Assert.AreEqual(val5, tideSite.LastUpdateDate_UTC);
               int val6 = 45;
               tideSite.LastUpdateContactTVItemID = val6;
               Assert.AreEqual(val6, tideSite.LastUpdateContactTVItemID);
               bool val7 = true;
               tideSite.HasErrors = val7;
               Assert.AreEqual(val7, tideSite.HasErrors);
               IEnumerable<ValidationResult> val24 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               tideSite.ValidationResults = val24;
               Assert.AreEqual(val24, tideSite.ValidationResults);
        }
        [TestMethod]
        public void TideSiteWeb_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               tideSiteWeb.TideSiteTVItemLanguage = val1;
               Assert.AreEqual(val1, tideSiteWeb.TideSiteTVItemLanguage);
               TVItemLanguage val2 = new TVItemLanguage();
               tideSiteWeb.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, tideSiteWeb.LastUpdateContactTVItemLanguage);
               int val3 = 45;
               tideSiteWeb.TideSiteID = val3;
               Assert.AreEqual(val3, tideSiteWeb.TideSiteID);
               int val4 = 45;
               tideSiteWeb.TideSiteTVItemID = val4;
               Assert.AreEqual(val4, tideSiteWeb.TideSiteTVItemID);
               string val5 = "Some text";
               tideSiteWeb.WebTideModel = val5;
               Assert.AreEqual(val5, tideSiteWeb.WebTideModel);
               double val6 = 87.9D;
               tideSiteWeb.WebTideDatum_m = val6;
               Assert.AreEqual(val6, tideSiteWeb.WebTideDatum_m);
               DateTime val7 = new DateTime(2010, 3, 4);
               tideSiteWeb.LastUpdateDate_UTC = val7;
               Assert.AreEqual(val7, tideSiteWeb.LastUpdateDate_UTC);
               int val8 = 45;
               tideSiteWeb.LastUpdateContactTVItemID = val8;
               Assert.AreEqual(val8, tideSiteWeb.LastUpdateContactTVItemID);
               bool val9 = true;
               tideSiteWeb.HasErrors = val9;
               Assert.AreEqual(val9, tideSiteWeb.HasErrors);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               tideSiteWeb.ValidationResults = val30;
               Assert.AreEqual(val30, tideSiteWeb.ValidationResults);
        }
        [TestMethod]
        public void TideSiteReport_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               tideSiteReport.TideSiteReportTest = val1;
               Assert.AreEqual(val1, tideSiteReport.TideSiteReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               tideSiteReport.TideSiteTVItemLanguage = val2;
               Assert.AreEqual(val2, tideSiteReport.TideSiteTVItemLanguage);
               TVItemLanguage val3 = new TVItemLanguage();
               tideSiteReport.LastUpdateContactTVItemLanguage = val3;
               Assert.AreEqual(val3, tideSiteReport.LastUpdateContactTVItemLanguage);
               int val4 = 45;
               tideSiteReport.TideSiteID = val4;
               Assert.AreEqual(val4, tideSiteReport.TideSiteID);
               int val5 = 45;
               tideSiteReport.TideSiteTVItemID = val5;
               Assert.AreEqual(val5, tideSiteReport.TideSiteTVItemID);
               string val6 = "Some text";
               tideSiteReport.WebTideModel = val6;
               Assert.AreEqual(val6, tideSiteReport.WebTideModel);
               double val7 = 87.9D;
               tideSiteReport.WebTideDatum_m = val7;
               Assert.AreEqual(val7, tideSiteReport.WebTideDatum_m);
               DateTime val8 = new DateTime(2010, 3, 4);
               tideSiteReport.LastUpdateDate_UTC = val8;
               Assert.AreEqual(val8, tideSiteReport.LastUpdateDate_UTC);
               int val9 = 45;
               tideSiteReport.LastUpdateContactTVItemID = val9;
               Assert.AreEqual(val9, tideSiteReport.LastUpdateContactTVItemID);
               bool val10 = true;
               tideSiteReport.HasErrors = val10;
               Assert.AreEqual(val10, tideSiteReport.HasErrors);
               IEnumerable<ValidationResult> val33 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               tideSiteReport.ValidationResults = val33;
               Assert.AreEqual(val33, tideSiteReport.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
