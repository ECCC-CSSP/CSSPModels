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
    public partial class SamplingPlanSubsectorSiteTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private SamplingPlanSubsectorSite samplingPlanSubsectorSite { get; set; }
        private SamplingPlanSubsectorSiteWeb samplingPlanSubsectorSiteWeb { get; set; }
        private SamplingPlanSubsectorSiteReport samplingPlanSubsectorSiteReport { get; set; }
        #endregion Properties

        #region Constructors
        public SamplingPlanSubsectorSiteTest()
        {
            samplingPlanSubsectorSite = new SamplingPlanSubsectorSite();
            samplingPlanSubsectorSiteWeb = new SamplingPlanSubsectorSiteWeb();
            samplingPlanSubsectorSiteReport = new SamplingPlanSubsectorSiteReport();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void SamplingPlanSubsectorSite_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "SamplingPlanSubsectorSiteID", "SamplingPlanSubsectorID", "MWQMSiteTVItemID", "IsDuplicate", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SamplingPlanSubsectorSite).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(SamplingPlanSubsectorSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void SamplingPlanSubsectorSiteWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMSiteTVItemLanguage", "LastUpdateContactTVItemLanguage", "SamplingPlanSubsectorSiteID", "SamplingPlanSubsectorID", "MWQMSiteTVItemID", "IsDuplicate", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SamplingPlanSubsectorSiteWeb).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(SamplingPlanSubsectorSiteWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void SamplingPlanSubsectorSiteReport_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "SamplingPlanSubsectorSiteReportTest", "MWQMSiteTVItemLanguage", "LastUpdateContactTVItemLanguage", "SamplingPlanSubsectorSiteID", "SamplingPlanSubsectorID", "MWQMSiteTVItemID", "IsDuplicate", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SamplingPlanSubsectorSiteReport).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(SamplingPlanSubsectorSiteReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void SamplingPlanSubsectorSite_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SamplingPlanSubsectorSite).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SamplingPlanSubsectorSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void SamplingPlanSubsectorSiteWeb_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SamplingPlanSubsectorSiteWeb).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SamplingPlanSubsectorSiteWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void SamplingPlanSubsectorSiteReport_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SamplingPlanSubsectorSiteReport).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SamplingPlanSubsectorSiteReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void SamplingPlanSubsectorSite_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(SamplingPlanSubsectorSite).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void SamplingPlanSubsectorSiteWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(SamplingPlanSubsectorSiteWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void SamplingPlanSubsectorSiteReport_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(SamplingPlanSubsectorSiteReport).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void SamplingPlanSubsectorSite_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               samplingPlanSubsectorSite.SamplingPlanSubsectorSiteID = val1;
               Assert.AreEqual(val1, samplingPlanSubsectorSite.SamplingPlanSubsectorSiteID);
               int val2 = 45;
               samplingPlanSubsectorSite.SamplingPlanSubsectorID = val2;
               Assert.AreEqual(val2, samplingPlanSubsectorSite.SamplingPlanSubsectorID);
               int val3 = 45;
               samplingPlanSubsectorSite.MWQMSiteTVItemID = val3;
               Assert.AreEqual(val3, samplingPlanSubsectorSite.MWQMSiteTVItemID);
               bool val4 = true;
               samplingPlanSubsectorSite.IsDuplicate = val4;
               Assert.AreEqual(val4, samplingPlanSubsectorSite.IsDuplicate);
               DateTime val5 = new DateTime(2010, 3, 4);
               samplingPlanSubsectorSite.LastUpdateDate_UTC = val5;
               Assert.AreEqual(val5, samplingPlanSubsectorSite.LastUpdateDate_UTC);
               int val6 = 45;
               samplingPlanSubsectorSite.LastUpdateContactTVItemID = val6;
               Assert.AreEqual(val6, samplingPlanSubsectorSite.LastUpdateContactTVItemID);
               bool val7 = true;
               samplingPlanSubsectorSite.HasErrors = val7;
               Assert.AreEqual(val7, samplingPlanSubsectorSite.HasErrors);
               IEnumerable<ValidationResult> val24 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               samplingPlanSubsectorSite.ValidationResults = val24;
               Assert.AreEqual(val24, samplingPlanSubsectorSite.ValidationResults);
        }
        [TestMethod]
        public void SamplingPlanSubsectorSiteWeb_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               samplingPlanSubsectorSiteWeb.MWQMSiteTVItemLanguage = val1;
               Assert.AreEqual(val1, samplingPlanSubsectorSiteWeb.MWQMSiteTVItemLanguage);
               TVItemLanguage val2 = new TVItemLanguage();
               samplingPlanSubsectorSiteWeb.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, samplingPlanSubsectorSiteWeb.LastUpdateContactTVItemLanguage);
               int val3 = 45;
               samplingPlanSubsectorSiteWeb.SamplingPlanSubsectorSiteID = val3;
               Assert.AreEqual(val3, samplingPlanSubsectorSiteWeb.SamplingPlanSubsectorSiteID);
               int val4 = 45;
               samplingPlanSubsectorSiteWeb.SamplingPlanSubsectorID = val4;
               Assert.AreEqual(val4, samplingPlanSubsectorSiteWeb.SamplingPlanSubsectorID);
               int val5 = 45;
               samplingPlanSubsectorSiteWeb.MWQMSiteTVItemID = val5;
               Assert.AreEqual(val5, samplingPlanSubsectorSiteWeb.MWQMSiteTVItemID);
               bool val6 = true;
               samplingPlanSubsectorSiteWeb.IsDuplicate = val6;
               Assert.AreEqual(val6, samplingPlanSubsectorSiteWeb.IsDuplicate);
               DateTime val7 = new DateTime(2010, 3, 4);
               samplingPlanSubsectorSiteWeb.LastUpdateDate_UTC = val7;
               Assert.AreEqual(val7, samplingPlanSubsectorSiteWeb.LastUpdateDate_UTC);
               int val8 = 45;
               samplingPlanSubsectorSiteWeb.LastUpdateContactTVItemID = val8;
               Assert.AreEqual(val8, samplingPlanSubsectorSiteWeb.LastUpdateContactTVItemID);
               bool val9 = true;
               samplingPlanSubsectorSiteWeb.HasErrors = val9;
               Assert.AreEqual(val9, samplingPlanSubsectorSiteWeb.HasErrors);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               samplingPlanSubsectorSiteWeb.ValidationResults = val30;
               Assert.AreEqual(val30, samplingPlanSubsectorSiteWeb.ValidationResults);
        }
        [TestMethod]
        public void SamplingPlanSubsectorSiteReport_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               samplingPlanSubsectorSiteReport.SamplingPlanSubsectorSiteReportTest = val1;
               Assert.AreEqual(val1, samplingPlanSubsectorSiteReport.SamplingPlanSubsectorSiteReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               samplingPlanSubsectorSiteReport.MWQMSiteTVItemLanguage = val2;
               Assert.AreEqual(val2, samplingPlanSubsectorSiteReport.MWQMSiteTVItemLanguage);
               TVItemLanguage val3 = new TVItemLanguage();
               samplingPlanSubsectorSiteReport.LastUpdateContactTVItemLanguage = val3;
               Assert.AreEqual(val3, samplingPlanSubsectorSiteReport.LastUpdateContactTVItemLanguage);
               int val4 = 45;
               samplingPlanSubsectorSiteReport.SamplingPlanSubsectorSiteID = val4;
               Assert.AreEqual(val4, samplingPlanSubsectorSiteReport.SamplingPlanSubsectorSiteID);
               int val5 = 45;
               samplingPlanSubsectorSiteReport.SamplingPlanSubsectorID = val5;
               Assert.AreEqual(val5, samplingPlanSubsectorSiteReport.SamplingPlanSubsectorID);
               int val6 = 45;
               samplingPlanSubsectorSiteReport.MWQMSiteTVItemID = val6;
               Assert.AreEqual(val6, samplingPlanSubsectorSiteReport.MWQMSiteTVItemID);
               bool val7 = true;
               samplingPlanSubsectorSiteReport.IsDuplicate = val7;
               Assert.AreEqual(val7, samplingPlanSubsectorSiteReport.IsDuplicate);
               DateTime val8 = new DateTime(2010, 3, 4);
               samplingPlanSubsectorSiteReport.LastUpdateDate_UTC = val8;
               Assert.AreEqual(val8, samplingPlanSubsectorSiteReport.LastUpdateDate_UTC);
               int val9 = 45;
               samplingPlanSubsectorSiteReport.LastUpdateContactTVItemID = val9;
               Assert.AreEqual(val9, samplingPlanSubsectorSiteReport.LastUpdateContactTVItemID);
               bool val10 = true;
               samplingPlanSubsectorSiteReport.HasErrors = val10;
               Assert.AreEqual(val10, samplingPlanSubsectorSiteReport.HasErrors);
               IEnumerable<ValidationResult> val33 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               samplingPlanSubsectorSiteReport.ValidationResults = val33;
               Assert.AreEqual(val33, samplingPlanSubsectorSiteReport.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
