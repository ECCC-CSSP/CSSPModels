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
    public partial class LabSheetTubeMPNDetailTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private LabSheetTubeMPNDetail labSheetTubeMPNDetail { get; set; }
        private LabSheetTubeMPNDetailWeb labSheetTubeMPNDetailWeb { get; set; }
        private LabSheetTubeMPNDetailReport labSheetTubeMPNDetailReport { get; set; }
        #endregion Properties

        #region Constructors
        public LabSheetTubeMPNDetailTest()
        {
            labSheetTubeMPNDetail = new LabSheetTubeMPNDetail();
            labSheetTubeMPNDetailWeb = new LabSheetTubeMPNDetailWeb();
            labSheetTubeMPNDetailReport = new LabSheetTubeMPNDetailReport();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void LabSheetTubeMPNDetail_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LabSheetTubeMPNDetailID", "LabSheetDetailID", "Ordinal", "MWQMSiteTVItemID", "SampleDateTime", "MPN", "Tube10", "Tube1_0", "Tube0_1", "Salinity", "Temperature", "ProcessedBy", "SampleType", "SiteComment", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetail).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetail).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void LabSheetTubeMPNDetailWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMSiteTVItemLanguage", "LastUpdateContactTVItemLanguage", "SampleTypeText", "LabSheetTubeMPNDetailID", "LabSheetDetailID", "Ordinal", "MWQMSiteTVItemID", "SampleDateTime", "MPN", "Tube10", "Tube1_0", "Tube0_1", "Salinity", "Temperature", "ProcessedBy", "SampleType", "SiteComment", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetailWeb).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetailWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void LabSheetTubeMPNDetailReport_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LabSheetTubeMPNDetailReportTest", "MWQMSiteTVItemLanguage", "LastUpdateContactTVItemLanguage", "SampleTypeText", "LabSheetTubeMPNDetailID", "LabSheetDetailID", "Ordinal", "MWQMSiteTVItemID", "SampleDateTime", "MPN", "Tube10", "Tube1_0", "Tube0_1", "Salinity", "Temperature", "ProcessedBy", "SampleType", "SiteComment", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetailReport).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetailReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void LabSheetTubeMPNDetail_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetail).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetail).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void LabSheetTubeMPNDetailWeb_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetailWeb).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetailWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void LabSheetTubeMPNDetailReport_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetailReport).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetailReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void LabSheetTubeMPNDetail_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(LabSheetTubeMPNDetail).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void LabSheetTubeMPNDetailWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(LabSheetTubeMPNDetailWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void LabSheetTubeMPNDetailReport_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(LabSheetTubeMPNDetailReport).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void LabSheetTubeMPNDetail_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               labSheetTubeMPNDetail.LabSheetTubeMPNDetailID = val1;
               Assert.AreEqual(val1, labSheetTubeMPNDetail.LabSheetTubeMPNDetailID);
               int val2 = 45;
               labSheetTubeMPNDetail.LabSheetDetailID = val2;
               Assert.AreEqual(val2, labSheetTubeMPNDetail.LabSheetDetailID);
               int val3 = 45;
               labSheetTubeMPNDetail.Ordinal = val3;
               Assert.AreEqual(val3, labSheetTubeMPNDetail.Ordinal);
               int val4 = 45;
               labSheetTubeMPNDetail.MWQMSiteTVItemID = val4;
               Assert.AreEqual(val4, labSheetTubeMPNDetail.MWQMSiteTVItemID);
               DateTime val5 = new DateTime(2010, 3, 4);
               labSheetTubeMPNDetail.SampleDateTime = val5;
               Assert.AreEqual(val5, labSheetTubeMPNDetail.SampleDateTime);
               int val6 = 45;
               labSheetTubeMPNDetail.MPN = val6;
               Assert.AreEqual(val6, labSheetTubeMPNDetail.MPN);
               int val7 = 45;
               labSheetTubeMPNDetail.Tube10 = val7;
               Assert.AreEqual(val7, labSheetTubeMPNDetail.Tube10);
               int val8 = 45;
               labSheetTubeMPNDetail.Tube1_0 = val8;
               Assert.AreEqual(val8, labSheetTubeMPNDetail.Tube1_0);
               int val9 = 45;
               labSheetTubeMPNDetail.Tube0_1 = val9;
               Assert.AreEqual(val9, labSheetTubeMPNDetail.Tube0_1);
               double val10 = 87.9D;
               labSheetTubeMPNDetail.Salinity = val10;
               Assert.AreEqual(val10, labSheetTubeMPNDetail.Salinity);
               double val11 = 87.9D;
               labSheetTubeMPNDetail.Temperature = val11;
               Assert.AreEqual(val11, labSheetTubeMPNDetail.Temperature);
               string val12 = "Some text";
               labSheetTubeMPNDetail.ProcessedBy = val12;
               Assert.AreEqual(val12, labSheetTubeMPNDetail.ProcessedBy);
               SampleTypeEnum val13 = (SampleTypeEnum)3;
               labSheetTubeMPNDetail.SampleType = val13;
               Assert.AreEqual(val13, labSheetTubeMPNDetail.SampleType);
               string val14 = "Some text";
               labSheetTubeMPNDetail.SiteComment = val14;
               Assert.AreEqual(val14, labSheetTubeMPNDetail.SiteComment);
               DateTime val15 = new DateTime(2010, 3, 4);
               labSheetTubeMPNDetail.LastUpdateDate_UTC = val15;
               Assert.AreEqual(val15, labSheetTubeMPNDetail.LastUpdateDate_UTC);
               int val16 = 45;
               labSheetTubeMPNDetail.LastUpdateContactTVItemID = val16;
               Assert.AreEqual(val16, labSheetTubeMPNDetail.LastUpdateContactTVItemID);
               bool val17 = true;
               labSheetTubeMPNDetail.HasErrors = val17;
               Assert.AreEqual(val17, labSheetTubeMPNDetail.HasErrors);
               IEnumerable<ValidationResult> val54 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               labSheetTubeMPNDetail.ValidationResults = val54;
               Assert.AreEqual(val54, labSheetTubeMPNDetail.ValidationResults);
        }
        [TestMethod]
        public void LabSheetTubeMPNDetailWeb_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               labSheetTubeMPNDetailWeb.MWQMSiteTVItemLanguage = val1;
               Assert.AreEqual(val1, labSheetTubeMPNDetailWeb.MWQMSiteTVItemLanguage);
               TVItemLanguage val2 = new TVItemLanguage();
               labSheetTubeMPNDetailWeb.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, labSheetTubeMPNDetailWeb.LastUpdateContactTVItemLanguage);
               string val3 = "Some text";
               labSheetTubeMPNDetailWeb.SampleTypeText = val3;
               Assert.AreEqual(val3, labSheetTubeMPNDetailWeb.SampleTypeText);
               int val4 = 45;
               labSheetTubeMPNDetailWeb.LabSheetTubeMPNDetailID = val4;
               Assert.AreEqual(val4, labSheetTubeMPNDetailWeb.LabSheetTubeMPNDetailID);
               int val5 = 45;
               labSheetTubeMPNDetailWeb.LabSheetDetailID = val5;
               Assert.AreEqual(val5, labSheetTubeMPNDetailWeb.LabSheetDetailID);
               int val6 = 45;
               labSheetTubeMPNDetailWeb.Ordinal = val6;
               Assert.AreEqual(val6, labSheetTubeMPNDetailWeb.Ordinal);
               int val7 = 45;
               labSheetTubeMPNDetailWeb.MWQMSiteTVItemID = val7;
               Assert.AreEqual(val7, labSheetTubeMPNDetailWeb.MWQMSiteTVItemID);
               DateTime val8 = new DateTime(2010, 3, 4);
               labSheetTubeMPNDetailWeb.SampleDateTime = val8;
               Assert.AreEqual(val8, labSheetTubeMPNDetailWeb.SampleDateTime);
               int val9 = 45;
               labSheetTubeMPNDetailWeb.MPN = val9;
               Assert.AreEqual(val9, labSheetTubeMPNDetailWeb.MPN);
               int val10 = 45;
               labSheetTubeMPNDetailWeb.Tube10 = val10;
               Assert.AreEqual(val10, labSheetTubeMPNDetailWeb.Tube10);
               int val11 = 45;
               labSheetTubeMPNDetailWeb.Tube1_0 = val11;
               Assert.AreEqual(val11, labSheetTubeMPNDetailWeb.Tube1_0);
               int val12 = 45;
               labSheetTubeMPNDetailWeb.Tube0_1 = val12;
               Assert.AreEqual(val12, labSheetTubeMPNDetailWeb.Tube0_1);
               double val13 = 87.9D;
               labSheetTubeMPNDetailWeb.Salinity = val13;
               Assert.AreEqual(val13, labSheetTubeMPNDetailWeb.Salinity);
               double val14 = 87.9D;
               labSheetTubeMPNDetailWeb.Temperature = val14;
               Assert.AreEqual(val14, labSheetTubeMPNDetailWeb.Temperature);
               string val15 = "Some text";
               labSheetTubeMPNDetailWeb.ProcessedBy = val15;
               Assert.AreEqual(val15, labSheetTubeMPNDetailWeb.ProcessedBy);
               SampleTypeEnum val16 = (SampleTypeEnum)3;
               labSheetTubeMPNDetailWeb.SampleType = val16;
               Assert.AreEqual(val16, labSheetTubeMPNDetailWeb.SampleType);
               string val17 = "Some text";
               labSheetTubeMPNDetailWeb.SiteComment = val17;
               Assert.AreEqual(val17, labSheetTubeMPNDetailWeb.SiteComment);
               DateTime val18 = new DateTime(2010, 3, 4);
               labSheetTubeMPNDetailWeb.LastUpdateDate_UTC = val18;
               Assert.AreEqual(val18, labSheetTubeMPNDetailWeb.LastUpdateDate_UTC);
               int val19 = 45;
               labSheetTubeMPNDetailWeb.LastUpdateContactTVItemID = val19;
               Assert.AreEqual(val19, labSheetTubeMPNDetailWeb.LastUpdateContactTVItemID);
               bool val20 = true;
               labSheetTubeMPNDetailWeb.HasErrors = val20;
               Assert.AreEqual(val20, labSheetTubeMPNDetailWeb.HasErrors);
               IEnumerable<ValidationResult> val63 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               labSheetTubeMPNDetailWeb.ValidationResults = val63;
               Assert.AreEqual(val63, labSheetTubeMPNDetailWeb.ValidationResults);
        }
        [TestMethod]
        public void LabSheetTubeMPNDetailReport_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               labSheetTubeMPNDetailReport.LabSheetTubeMPNDetailReportTest = val1;
               Assert.AreEqual(val1, labSheetTubeMPNDetailReport.LabSheetTubeMPNDetailReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               labSheetTubeMPNDetailReport.MWQMSiteTVItemLanguage = val2;
               Assert.AreEqual(val2, labSheetTubeMPNDetailReport.MWQMSiteTVItemLanguage);
               TVItemLanguage val3 = new TVItemLanguage();
               labSheetTubeMPNDetailReport.LastUpdateContactTVItemLanguage = val3;
               Assert.AreEqual(val3, labSheetTubeMPNDetailReport.LastUpdateContactTVItemLanguage);
               string val4 = "Some text";
               labSheetTubeMPNDetailReport.SampleTypeText = val4;
               Assert.AreEqual(val4, labSheetTubeMPNDetailReport.SampleTypeText);
               int val5 = 45;
               labSheetTubeMPNDetailReport.LabSheetTubeMPNDetailID = val5;
               Assert.AreEqual(val5, labSheetTubeMPNDetailReport.LabSheetTubeMPNDetailID);
               int val6 = 45;
               labSheetTubeMPNDetailReport.LabSheetDetailID = val6;
               Assert.AreEqual(val6, labSheetTubeMPNDetailReport.LabSheetDetailID);
               int val7 = 45;
               labSheetTubeMPNDetailReport.Ordinal = val7;
               Assert.AreEqual(val7, labSheetTubeMPNDetailReport.Ordinal);
               int val8 = 45;
               labSheetTubeMPNDetailReport.MWQMSiteTVItemID = val8;
               Assert.AreEqual(val8, labSheetTubeMPNDetailReport.MWQMSiteTVItemID);
               DateTime val9 = new DateTime(2010, 3, 4);
               labSheetTubeMPNDetailReport.SampleDateTime = val9;
               Assert.AreEqual(val9, labSheetTubeMPNDetailReport.SampleDateTime);
               int val10 = 45;
               labSheetTubeMPNDetailReport.MPN = val10;
               Assert.AreEqual(val10, labSheetTubeMPNDetailReport.MPN);
               int val11 = 45;
               labSheetTubeMPNDetailReport.Tube10 = val11;
               Assert.AreEqual(val11, labSheetTubeMPNDetailReport.Tube10);
               int val12 = 45;
               labSheetTubeMPNDetailReport.Tube1_0 = val12;
               Assert.AreEqual(val12, labSheetTubeMPNDetailReport.Tube1_0);
               int val13 = 45;
               labSheetTubeMPNDetailReport.Tube0_1 = val13;
               Assert.AreEqual(val13, labSheetTubeMPNDetailReport.Tube0_1);
               double val14 = 87.9D;
               labSheetTubeMPNDetailReport.Salinity = val14;
               Assert.AreEqual(val14, labSheetTubeMPNDetailReport.Salinity);
               double val15 = 87.9D;
               labSheetTubeMPNDetailReport.Temperature = val15;
               Assert.AreEqual(val15, labSheetTubeMPNDetailReport.Temperature);
               string val16 = "Some text";
               labSheetTubeMPNDetailReport.ProcessedBy = val16;
               Assert.AreEqual(val16, labSheetTubeMPNDetailReport.ProcessedBy);
               SampleTypeEnum val17 = (SampleTypeEnum)3;
               labSheetTubeMPNDetailReport.SampleType = val17;
               Assert.AreEqual(val17, labSheetTubeMPNDetailReport.SampleType);
               string val18 = "Some text";
               labSheetTubeMPNDetailReport.SiteComment = val18;
               Assert.AreEqual(val18, labSheetTubeMPNDetailReport.SiteComment);
               DateTime val19 = new DateTime(2010, 3, 4);
               labSheetTubeMPNDetailReport.LastUpdateDate_UTC = val19;
               Assert.AreEqual(val19, labSheetTubeMPNDetailReport.LastUpdateDate_UTC);
               int val20 = 45;
               labSheetTubeMPNDetailReport.LastUpdateContactTVItemID = val20;
               Assert.AreEqual(val20, labSheetTubeMPNDetailReport.LastUpdateContactTVItemID);
               bool val21 = true;
               labSheetTubeMPNDetailReport.HasErrors = val21;
               Assert.AreEqual(val21, labSheetTubeMPNDetailReport.HasErrors);
               IEnumerable<ValidationResult> val66 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               labSheetTubeMPNDetailReport.ValidationResults = val66;
               Assert.AreEqual(val66, labSheetTubeMPNDetailReport.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
