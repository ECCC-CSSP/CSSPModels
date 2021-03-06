/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
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
        private LabSheetTubeMPNDetailExtraA labSheetTubeMPNDetailExtraA { get; set; }
        private LabSheetTubeMPNDetailExtraB labSheetTubeMPNDetailExtraB { get; set; }
        #endregion Properties

        #region Constructors
        public LabSheetTubeMPNDetailTest()
        {
            labSheetTubeMPNDetail = new LabSheetTubeMPNDetail();
            labSheetTubeMPNDetailExtraA = new LabSheetTubeMPNDetailExtraA();
            labSheetTubeMPNDetailExtraB = new LabSheetTubeMPNDetailExtraB();
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
        public void LabSheetTubeMPNDetailExtraA_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMSiteText", "LastUpdateContactText", "SampleTypeText", "LabSheetTubeMPNDetailID", "LabSheetDetailID", "Ordinal", "MWQMSiteTVItemID", "SampleDateTime", "MPN", "Tube10", "Tube1_0", "Tube0_1", "Salinity", "Temperature", "ProcessedBy", "SampleType", "SiteComment", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetailExtraA).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetailExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void LabSheetTubeMPNDetailExtraB_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LabSheetTubeMPNDetailReportTest", "MWQMSiteText", "LastUpdateContactText", "SampleTypeText", "LabSheetTubeMPNDetailID", "LabSheetDetailID", "Ordinal", "MWQMSiteTVItemID", "SampleDateTime", "MPN", "Tube10", "Tube1_0", "Tube0_1", "Salinity", "Temperature", "ProcessedBy", "SampleType", "SiteComment", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetailExtraB).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetailExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void LabSheetTubeMPNDetailExtraA_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetailExtraA).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetailExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void LabSheetTubeMPNDetailExtraB_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetailExtraB).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetailExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void LabSheetTubeMPNDetailExtraA_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(LabSheetTubeMPNDetailExtraA).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void LabSheetTubeMPNDetailExtraB_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(LabSheetTubeMPNDetailExtraB).GetProperties().Where(c => c.Name == "ValidationResults").Any());
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
               IEnumerable<ValidationResult> val54 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               labSheetTubeMPNDetail.ValidationResults = val54;
               Assert.AreEqual(val54, labSheetTubeMPNDetail.ValidationResults);
        }
        [TestMethod]
        public void LabSheetTubeMPNDetailExtraA_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               labSheetTubeMPNDetailExtraA.MWQMSiteText = val1;
               Assert.AreEqual(val1, labSheetTubeMPNDetailExtraA.MWQMSiteText);
               string val2 = "Some text";
               labSheetTubeMPNDetailExtraA.LastUpdateContactText = val2;
               Assert.AreEqual(val2, labSheetTubeMPNDetailExtraA.LastUpdateContactText);
               string val3 = "Some text";
               labSheetTubeMPNDetailExtraA.SampleTypeText = val3;
               Assert.AreEqual(val3, labSheetTubeMPNDetailExtraA.SampleTypeText);
               int val4 = 45;
               labSheetTubeMPNDetailExtraA.LabSheetTubeMPNDetailID = val4;
               Assert.AreEqual(val4, labSheetTubeMPNDetailExtraA.LabSheetTubeMPNDetailID);
               int val5 = 45;
               labSheetTubeMPNDetailExtraA.LabSheetDetailID = val5;
               Assert.AreEqual(val5, labSheetTubeMPNDetailExtraA.LabSheetDetailID);
               int val6 = 45;
               labSheetTubeMPNDetailExtraA.Ordinal = val6;
               Assert.AreEqual(val6, labSheetTubeMPNDetailExtraA.Ordinal);
               int val7 = 45;
               labSheetTubeMPNDetailExtraA.MWQMSiteTVItemID = val7;
               Assert.AreEqual(val7, labSheetTubeMPNDetailExtraA.MWQMSiteTVItemID);
               DateTime val8 = new DateTime(2010, 3, 4);
               labSheetTubeMPNDetailExtraA.SampleDateTime = val8;
               Assert.AreEqual(val8, labSheetTubeMPNDetailExtraA.SampleDateTime);
               int val9 = 45;
               labSheetTubeMPNDetailExtraA.MPN = val9;
               Assert.AreEqual(val9, labSheetTubeMPNDetailExtraA.MPN);
               int val10 = 45;
               labSheetTubeMPNDetailExtraA.Tube10 = val10;
               Assert.AreEqual(val10, labSheetTubeMPNDetailExtraA.Tube10);
               int val11 = 45;
               labSheetTubeMPNDetailExtraA.Tube1_0 = val11;
               Assert.AreEqual(val11, labSheetTubeMPNDetailExtraA.Tube1_0);
               int val12 = 45;
               labSheetTubeMPNDetailExtraA.Tube0_1 = val12;
               Assert.AreEqual(val12, labSheetTubeMPNDetailExtraA.Tube0_1);
               double val13 = 87.9D;
               labSheetTubeMPNDetailExtraA.Salinity = val13;
               Assert.AreEqual(val13, labSheetTubeMPNDetailExtraA.Salinity);
               double val14 = 87.9D;
               labSheetTubeMPNDetailExtraA.Temperature = val14;
               Assert.AreEqual(val14, labSheetTubeMPNDetailExtraA.Temperature);
               string val15 = "Some text";
               labSheetTubeMPNDetailExtraA.ProcessedBy = val15;
               Assert.AreEqual(val15, labSheetTubeMPNDetailExtraA.ProcessedBy);
               SampleTypeEnum val16 = (SampleTypeEnum)3;
               labSheetTubeMPNDetailExtraA.SampleType = val16;
               Assert.AreEqual(val16, labSheetTubeMPNDetailExtraA.SampleType);
               string val17 = "Some text";
               labSheetTubeMPNDetailExtraA.SiteComment = val17;
               Assert.AreEqual(val17, labSheetTubeMPNDetailExtraA.SiteComment);
               DateTime val18 = new DateTime(2010, 3, 4);
               labSheetTubeMPNDetailExtraA.LastUpdateDate_UTC = val18;
               Assert.AreEqual(val18, labSheetTubeMPNDetailExtraA.LastUpdateDate_UTC);
               int val19 = 45;
               labSheetTubeMPNDetailExtraA.LastUpdateContactTVItemID = val19;
               Assert.AreEqual(val19, labSheetTubeMPNDetailExtraA.LastUpdateContactTVItemID);
               bool val20 = true;
               labSheetTubeMPNDetailExtraA.HasErrors = val20;
               Assert.AreEqual(val20, labSheetTubeMPNDetailExtraA.HasErrors);
               IEnumerable<ValidationResult> val63 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               labSheetTubeMPNDetailExtraA.ValidationResults = val63;
               Assert.AreEqual(val63, labSheetTubeMPNDetailExtraA.ValidationResults);
        }
        [TestMethod]
        public void LabSheetTubeMPNDetailExtraB_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               labSheetTubeMPNDetailExtraB.LabSheetTubeMPNDetailReportTest = val1;
               Assert.AreEqual(val1, labSheetTubeMPNDetailExtraB.LabSheetTubeMPNDetailReportTest);
               string val2 = "Some text";
               labSheetTubeMPNDetailExtraB.MWQMSiteText = val2;
               Assert.AreEqual(val2, labSheetTubeMPNDetailExtraB.MWQMSiteText);
               string val3 = "Some text";
               labSheetTubeMPNDetailExtraB.LastUpdateContactText = val3;
               Assert.AreEqual(val3, labSheetTubeMPNDetailExtraB.LastUpdateContactText);
               string val4 = "Some text";
               labSheetTubeMPNDetailExtraB.SampleTypeText = val4;
               Assert.AreEqual(val4, labSheetTubeMPNDetailExtraB.SampleTypeText);
               int val5 = 45;
               labSheetTubeMPNDetailExtraB.LabSheetTubeMPNDetailID = val5;
               Assert.AreEqual(val5, labSheetTubeMPNDetailExtraB.LabSheetTubeMPNDetailID);
               int val6 = 45;
               labSheetTubeMPNDetailExtraB.LabSheetDetailID = val6;
               Assert.AreEqual(val6, labSheetTubeMPNDetailExtraB.LabSheetDetailID);
               int val7 = 45;
               labSheetTubeMPNDetailExtraB.Ordinal = val7;
               Assert.AreEqual(val7, labSheetTubeMPNDetailExtraB.Ordinal);
               int val8 = 45;
               labSheetTubeMPNDetailExtraB.MWQMSiteTVItemID = val8;
               Assert.AreEqual(val8, labSheetTubeMPNDetailExtraB.MWQMSiteTVItemID);
               DateTime val9 = new DateTime(2010, 3, 4);
               labSheetTubeMPNDetailExtraB.SampleDateTime = val9;
               Assert.AreEqual(val9, labSheetTubeMPNDetailExtraB.SampleDateTime);
               int val10 = 45;
               labSheetTubeMPNDetailExtraB.MPN = val10;
               Assert.AreEqual(val10, labSheetTubeMPNDetailExtraB.MPN);
               int val11 = 45;
               labSheetTubeMPNDetailExtraB.Tube10 = val11;
               Assert.AreEqual(val11, labSheetTubeMPNDetailExtraB.Tube10);
               int val12 = 45;
               labSheetTubeMPNDetailExtraB.Tube1_0 = val12;
               Assert.AreEqual(val12, labSheetTubeMPNDetailExtraB.Tube1_0);
               int val13 = 45;
               labSheetTubeMPNDetailExtraB.Tube0_1 = val13;
               Assert.AreEqual(val13, labSheetTubeMPNDetailExtraB.Tube0_1);
               double val14 = 87.9D;
               labSheetTubeMPNDetailExtraB.Salinity = val14;
               Assert.AreEqual(val14, labSheetTubeMPNDetailExtraB.Salinity);
               double val15 = 87.9D;
               labSheetTubeMPNDetailExtraB.Temperature = val15;
               Assert.AreEqual(val15, labSheetTubeMPNDetailExtraB.Temperature);
               string val16 = "Some text";
               labSheetTubeMPNDetailExtraB.ProcessedBy = val16;
               Assert.AreEqual(val16, labSheetTubeMPNDetailExtraB.ProcessedBy);
               SampleTypeEnum val17 = (SampleTypeEnum)3;
               labSheetTubeMPNDetailExtraB.SampleType = val17;
               Assert.AreEqual(val17, labSheetTubeMPNDetailExtraB.SampleType);
               string val18 = "Some text";
               labSheetTubeMPNDetailExtraB.SiteComment = val18;
               Assert.AreEqual(val18, labSheetTubeMPNDetailExtraB.SiteComment);
               DateTime val19 = new DateTime(2010, 3, 4);
               labSheetTubeMPNDetailExtraB.LastUpdateDate_UTC = val19;
               Assert.AreEqual(val19, labSheetTubeMPNDetailExtraB.LastUpdateDate_UTC);
               int val20 = 45;
               labSheetTubeMPNDetailExtraB.LastUpdateContactTVItemID = val20;
               Assert.AreEqual(val20, labSheetTubeMPNDetailExtraB.LastUpdateContactTVItemID);
               bool val21 = true;
               labSheetTubeMPNDetailExtraB.HasErrors = val21;
               Assert.AreEqual(val21, labSheetTubeMPNDetailExtraB.HasErrors);
               IEnumerable<ValidationResult> val66 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               labSheetTubeMPNDetailExtraB.ValidationResults = val66;
               Assert.AreEqual(val66, labSheetTubeMPNDetailExtraB.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
