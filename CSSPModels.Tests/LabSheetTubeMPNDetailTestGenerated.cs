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
        private LabSheetTubeMPNDetail_A labSheetTubeMPNDetail_A { get; set; }
        private LabSheetTubeMPNDetail_B labSheetTubeMPNDetail_B { get; set; }
        #endregion Properties

        #region Constructors
        public LabSheetTubeMPNDetailTest()
        {
            labSheetTubeMPNDetail = new LabSheetTubeMPNDetail();
            labSheetTubeMPNDetail_A = new LabSheetTubeMPNDetail_A();
            labSheetTubeMPNDetail_B = new LabSheetTubeMPNDetail_B();
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
        public void LabSheetTubeMPNDetail_A_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMSiteTVItemLanguage", "LastUpdateContactTVItemLanguage", "SampleTypeText", "LabSheetTubeMPNDetailID", "LabSheetDetailID", "Ordinal", "MWQMSiteTVItemID", "SampleDateTime", "MPN", "Tube10", "Tube1_0", "Tube0_1", "Salinity", "Temperature", "ProcessedBy", "SampleType", "SiteComment", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetail_A).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetail_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void LabSheetTubeMPNDetail_B_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LabSheetTubeMPNDetailReportTest", "MWQMSiteTVItemLanguage", "LastUpdateContactTVItemLanguage", "SampleTypeText", "LabSheetTubeMPNDetailID", "LabSheetDetailID", "Ordinal", "MWQMSiteTVItemID", "SampleDateTime", "MPN", "Tube10", "Tube1_0", "Tube0_1", "Salinity", "Temperature", "ProcessedBy", "SampleType", "SiteComment", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetail_B).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetail_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void LabSheetTubeMPNDetail_A_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetail_A).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetail_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void LabSheetTubeMPNDetail_B_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetail_B).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LabSheetTubeMPNDetail_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void LabSheetTubeMPNDetail_A_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(LabSheetTubeMPNDetail_A).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void LabSheetTubeMPNDetail_B_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(LabSheetTubeMPNDetail_B).GetProperties().Where(c => c.Name == "ValidationResults").Any());
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
        public void LabSheetTubeMPNDetail_A_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               labSheetTubeMPNDetail_A.MWQMSiteTVItemLanguage = val1;
               Assert.AreEqual(val1, labSheetTubeMPNDetail_A.MWQMSiteTVItemLanguage);
               TVItemLanguage val2 = new TVItemLanguage();
               labSheetTubeMPNDetail_A.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, labSheetTubeMPNDetail_A.LastUpdateContactTVItemLanguage);
               string val3 = "Some text";
               labSheetTubeMPNDetail_A.SampleTypeText = val3;
               Assert.AreEqual(val3, labSheetTubeMPNDetail_A.SampleTypeText);
               int val4 = 45;
               labSheetTubeMPNDetail_A.LabSheetTubeMPNDetailID = val4;
               Assert.AreEqual(val4, labSheetTubeMPNDetail_A.LabSheetTubeMPNDetailID);
               int val5 = 45;
               labSheetTubeMPNDetail_A.LabSheetDetailID = val5;
               Assert.AreEqual(val5, labSheetTubeMPNDetail_A.LabSheetDetailID);
               int val6 = 45;
               labSheetTubeMPNDetail_A.Ordinal = val6;
               Assert.AreEqual(val6, labSheetTubeMPNDetail_A.Ordinal);
               int val7 = 45;
               labSheetTubeMPNDetail_A.MWQMSiteTVItemID = val7;
               Assert.AreEqual(val7, labSheetTubeMPNDetail_A.MWQMSiteTVItemID);
               DateTime val8 = new DateTime(2010, 3, 4);
               labSheetTubeMPNDetail_A.SampleDateTime = val8;
               Assert.AreEqual(val8, labSheetTubeMPNDetail_A.SampleDateTime);
               int val9 = 45;
               labSheetTubeMPNDetail_A.MPN = val9;
               Assert.AreEqual(val9, labSheetTubeMPNDetail_A.MPN);
               int val10 = 45;
               labSheetTubeMPNDetail_A.Tube10 = val10;
               Assert.AreEqual(val10, labSheetTubeMPNDetail_A.Tube10);
               int val11 = 45;
               labSheetTubeMPNDetail_A.Tube1_0 = val11;
               Assert.AreEqual(val11, labSheetTubeMPNDetail_A.Tube1_0);
               int val12 = 45;
               labSheetTubeMPNDetail_A.Tube0_1 = val12;
               Assert.AreEqual(val12, labSheetTubeMPNDetail_A.Tube0_1);
               double val13 = 87.9D;
               labSheetTubeMPNDetail_A.Salinity = val13;
               Assert.AreEqual(val13, labSheetTubeMPNDetail_A.Salinity);
               double val14 = 87.9D;
               labSheetTubeMPNDetail_A.Temperature = val14;
               Assert.AreEqual(val14, labSheetTubeMPNDetail_A.Temperature);
               string val15 = "Some text";
               labSheetTubeMPNDetail_A.ProcessedBy = val15;
               Assert.AreEqual(val15, labSheetTubeMPNDetail_A.ProcessedBy);
               SampleTypeEnum val16 = (SampleTypeEnum)3;
               labSheetTubeMPNDetail_A.SampleType = val16;
               Assert.AreEqual(val16, labSheetTubeMPNDetail_A.SampleType);
               string val17 = "Some text";
               labSheetTubeMPNDetail_A.SiteComment = val17;
               Assert.AreEqual(val17, labSheetTubeMPNDetail_A.SiteComment);
               DateTime val18 = new DateTime(2010, 3, 4);
               labSheetTubeMPNDetail_A.LastUpdateDate_UTC = val18;
               Assert.AreEqual(val18, labSheetTubeMPNDetail_A.LastUpdateDate_UTC);
               int val19 = 45;
               labSheetTubeMPNDetail_A.LastUpdateContactTVItemID = val19;
               Assert.AreEqual(val19, labSheetTubeMPNDetail_A.LastUpdateContactTVItemID);
               bool val20 = true;
               labSheetTubeMPNDetail_A.HasErrors = val20;
               Assert.AreEqual(val20, labSheetTubeMPNDetail_A.HasErrors);
               IEnumerable<ValidationResult> val63 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               labSheetTubeMPNDetail_A.ValidationResults = val63;
               Assert.AreEqual(val63, labSheetTubeMPNDetail_A.ValidationResults);
        }
        [TestMethod]
        public void LabSheetTubeMPNDetail_B_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               labSheetTubeMPNDetail_B.LabSheetTubeMPNDetailReportTest = val1;
               Assert.AreEqual(val1, labSheetTubeMPNDetail_B.LabSheetTubeMPNDetailReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               labSheetTubeMPNDetail_B.MWQMSiteTVItemLanguage = val2;
               Assert.AreEqual(val2, labSheetTubeMPNDetail_B.MWQMSiteTVItemLanguage);
               TVItemLanguage val3 = new TVItemLanguage();
               labSheetTubeMPNDetail_B.LastUpdateContactTVItemLanguage = val3;
               Assert.AreEqual(val3, labSheetTubeMPNDetail_B.LastUpdateContactTVItemLanguage);
               string val4 = "Some text";
               labSheetTubeMPNDetail_B.SampleTypeText = val4;
               Assert.AreEqual(val4, labSheetTubeMPNDetail_B.SampleTypeText);
               int val5 = 45;
               labSheetTubeMPNDetail_B.LabSheetTubeMPNDetailID = val5;
               Assert.AreEqual(val5, labSheetTubeMPNDetail_B.LabSheetTubeMPNDetailID);
               int val6 = 45;
               labSheetTubeMPNDetail_B.LabSheetDetailID = val6;
               Assert.AreEqual(val6, labSheetTubeMPNDetail_B.LabSheetDetailID);
               int val7 = 45;
               labSheetTubeMPNDetail_B.Ordinal = val7;
               Assert.AreEqual(val7, labSheetTubeMPNDetail_B.Ordinal);
               int val8 = 45;
               labSheetTubeMPNDetail_B.MWQMSiteTVItemID = val8;
               Assert.AreEqual(val8, labSheetTubeMPNDetail_B.MWQMSiteTVItemID);
               DateTime val9 = new DateTime(2010, 3, 4);
               labSheetTubeMPNDetail_B.SampleDateTime = val9;
               Assert.AreEqual(val9, labSheetTubeMPNDetail_B.SampleDateTime);
               int val10 = 45;
               labSheetTubeMPNDetail_B.MPN = val10;
               Assert.AreEqual(val10, labSheetTubeMPNDetail_B.MPN);
               int val11 = 45;
               labSheetTubeMPNDetail_B.Tube10 = val11;
               Assert.AreEqual(val11, labSheetTubeMPNDetail_B.Tube10);
               int val12 = 45;
               labSheetTubeMPNDetail_B.Tube1_0 = val12;
               Assert.AreEqual(val12, labSheetTubeMPNDetail_B.Tube1_0);
               int val13 = 45;
               labSheetTubeMPNDetail_B.Tube0_1 = val13;
               Assert.AreEqual(val13, labSheetTubeMPNDetail_B.Tube0_1);
               double val14 = 87.9D;
               labSheetTubeMPNDetail_B.Salinity = val14;
               Assert.AreEqual(val14, labSheetTubeMPNDetail_B.Salinity);
               double val15 = 87.9D;
               labSheetTubeMPNDetail_B.Temperature = val15;
               Assert.AreEqual(val15, labSheetTubeMPNDetail_B.Temperature);
               string val16 = "Some text";
               labSheetTubeMPNDetail_B.ProcessedBy = val16;
               Assert.AreEqual(val16, labSheetTubeMPNDetail_B.ProcessedBy);
               SampleTypeEnum val17 = (SampleTypeEnum)3;
               labSheetTubeMPNDetail_B.SampleType = val17;
               Assert.AreEqual(val17, labSheetTubeMPNDetail_B.SampleType);
               string val18 = "Some text";
               labSheetTubeMPNDetail_B.SiteComment = val18;
               Assert.AreEqual(val18, labSheetTubeMPNDetail_B.SiteComment);
               DateTime val19 = new DateTime(2010, 3, 4);
               labSheetTubeMPNDetail_B.LastUpdateDate_UTC = val19;
               Assert.AreEqual(val19, labSheetTubeMPNDetail_B.LastUpdateDate_UTC);
               int val20 = 45;
               labSheetTubeMPNDetail_B.LastUpdateContactTVItemID = val20;
               Assert.AreEqual(val20, labSheetTubeMPNDetail_B.LastUpdateContactTVItemID);
               bool val21 = true;
               labSheetTubeMPNDetail_B.HasErrors = val21;
               Assert.AreEqual(val21, labSheetTubeMPNDetail_B.HasErrors);
               IEnumerable<ValidationResult> val66 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               labSheetTubeMPNDetail_B.ValidationResults = val66;
               Assert.AreEqual(val66, labSheetTubeMPNDetail_B.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
