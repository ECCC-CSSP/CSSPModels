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
    public partial class ReportSectionTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private ReportSection reportSection { get; set; }
        private ReportSectionExtraA reportSectionExtraA { get; set; }
        private ReportSectionExtraB reportSectionExtraB { get; set; }
        #endregion Properties

        #region Constructors
        public ReportSectionTest()
        {
            reportSection = new ReportSection();
            reportSectionExtraA = new ReportSectionExtraA();
            reportSectionExtraB = new ReportSectionExtraB();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void ReportSection_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ReportSectionID", "ReportTypeID", "TVItemID", "Ordinal", "IsStatic", "ParentReportSectionID", "Year", "Locked", "TemplateReportSectionID", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ReportSection).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(ReportSection).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ReportSectionExtraA_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactText", "ReportSectionName", "ReportSectionText", "ReportSectionID", "ReportTypeID", "TVItemID", "Ordinal", "IsStatic", "ParentReportSectionID", "Year", "Locked", "TemplateReportSectionID", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ReportSectionExtraA).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(ReportSectionExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ReportSectionExtraB_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ReportSectionReportTest", "LastUpdateContactText", "ReportSectionName", "ReportSectionText", "ReportSectionID", "ReportTypeID", "TVItemID", "Ordinal", "IsStatic", "ParentReportSectionID", "Year", "Locked", "TemplateReportSectionID", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ReportSectionExtraB).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(ReportSectionExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ReportSection_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ReportSection).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ReportSection).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ReportSectionExtraA_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ReportSectionExtraA).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ReportSectionExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ReportSectionExtraB_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ReportSectionExtraB).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ReportSectionExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ReportSection_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ReportSection).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ReportSectionExtraA_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ReportSectionExtraA).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ReportSectionExtraB_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ReportSectionExtraB).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ReportSection_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               reportSection.ReportSectionID = val1;
               Assert.AreEqual(val1, reportSection.ReportSectionID);
               int val2 = 45;
               reportSection.ReportTypeID = val2;
               Assert.AreEqual(val2, reportSection.ReportTypeID);
               int val3 = 45;
               reportSection.TVItemID = val3;
               Assert.AreEqual(val3, reportSection.TVItemID);
               int val4 = 45;
               reportSection.Ordinal = val4;
               Assert.AreEqual(val4, reportSection.Ordinal);
               bool val5 = true;
               reportSection.IsStatic = val5;
               Assert.AreEqual(val5, reportSection.IsStatic);
               int val6 = 45;
               reportSection.ParentReportSectionID = val6;
               Assert.AreEqual(val6, reportSection.ParentReportSectionID);
               int val7 = 45;
               reportSection.Year = val7;
               Assert.AreEqual(val7, reportSection.Year);
               bool val8 = true;
               reportSection.Locked = val8;
               Assert.AreEqual(val8, reportSection.Locked);
               int val9 = 45;
               reportSection.TemplateReportSectionID = val9;
               Assert.AreEqual(val9, reportSection.TemplateReportSectionID);
               DateTime val10 = new DateTime(2010, 3, 4);
               reportSection.LastUpdateDate_UTC = val10;
               Assert.AreEqual(val10, reportSection.LastUpdateDate_UTC);
               int val11 = 45;
               reportSection.LastUpdateContactTVItemID = val11;
               Assert.AreEqual(val11, reportSection.LastUpdateContactTVItemID);
               bool val12 = true;
               reportSection.HasErrors = val12;
               Assert.AreEqual(val12, reportSection.HasErrors);
               IEnumerable<ValidationResult> val39 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               reportSection.ValidationResults = val39;
               Assert.AreEqual(val39, reportSection.ValidationResults);
        }
        [TestMethod]
        public void ReportSectionExtraA_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               reportSectionExtraA.LastUpdateContactText = val1;
               Assert.AreEqual(val1, reportSectionExtraA.LastUpdateContactText);
               string val2 = "Some text";
               reportSectionExtraA.ReportSectionName = val2;
               Assert.AreEqual(val2, reportSectionExtraA.ReportSectionName);
               string val3 = "Some text";
               reportSectionExtraA.ReportSectionText = val3;
               Assert.AreEqual(val3, reportSectionExtraA.ReportSectionText);
               int val4 = 45;
               reportSectionExtraA.ReportSectionID = val4;
               Assert.AreEqual(val4, reportSectionExtraA.ReportSectionID);
               int val5 = 45;
               reportSectionExtraA.ReportTypeID = val5;
               Assert.AreEqual(val5, reportSectionExtraA.ReportTypeID);
               int val6 = 45;
               reportSectionExtraA.TVItemID = val6;
               Assert.AreEqual(val6, reportSectionExtraA.TVItemID);
               int val7 = 45;
               reportSectionExtraA.Ordinal = val7;
               Assert.AreEqual(val7, reportSectionExtraA.Ordinal);
               bool val8 = true;
               reportSectionExtraA.IsStatic = val8;
               Assert.AreEqual(val8, reportSectionExtraA.IsStatic);
               int val9 = 45;
               reportSectionExtraA.ParentReportSectionID = val9;
               Assert.AreEqual(val9, reportSectionExtraA.ParentReportSectionID);
               int val10 = 45;
               reportSectionExtraA.Year = val10;
               Assert.AreEqual(val10, reportSectionExtraA.Year);
               bool val11 = true;
               reportSectionExtraA.Locked = val11;
               Assert.AreEqual(val11, reportSectionExtraA.Locked);
               int val12 = 45;
               reportSectionExtraA.TemplateReportSectionID = val12;
               Assert.AreEqual(val12, reportSectionExtraA.TemplateReportSectionID);
               DateTime val13 = new DateTime(2010, 3, 4);
               reportSectionExtraA.LastUpdateDate_UTC = val13;
               Assert.AreEqual(val13, reportSectionExtraA.LastUpdateDate_UTC);
               int val14 = 45;
               reportSectionExtraA.LastUpdateContactTVItemID = val14;
               Assert.AreEqual(val14, reportSectionExtraA.LastUpdateContactTVItemID);
               bool val15 = true;
               reportSectionExtraA.HasErrors = val15;
               Assert.AreEqual(val15, reportSectionExtraA.HasErrors);
               IEnumerable<ValidationResult> val48 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               reportSectionExtraA.ValidationResults = val48;
               Assert.AreEqual(val48, reportSectionExtraA.ValidationResults);
        }
        [TestMethod]
        public void ReportSectionExtraB_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               reportSectionExtraB.ReportSectionReportTest = val1;
               Assert.AreEqual(val1, reportSectionExtraB.ReportSectionReportTest);
               string val2 = "Some text";
               reportSectionExtraB.LastUpdateContactText = val2;
               Assert.AreEqual(val2, reportSectionExtraB.LastUpdateContactText);
               string val3 = "Some text";
               reportSectionExtraB.ReportSectionName = val3;
               Assert.AreEqual(val3, reportSectionExtraB.ReportSectionName);
               string val4 = "Some text";
               reportSectionExtraB.ReportSectionText = val4;
               Assert.AreEqual(val4, reportSectionExtraB.ReportSectionText);
               int val5 = 45;
               reportSectionExtraB.ReportSectionID = val5;
               Assert.AreEqual(val5, reportSectionExtraB.ReportSectionID);
               int val6 = 45;
               reportSectionExtraB.ReportTypeID = val6;
               Assert.AreEqual(val6, reportSectionExtraB.ReportTypeID);
               int val7 = 45;
               reportSectionExtraB.TVItemID = val7;
               Assert.AreEqual(val7, reportSectionExtraB.TVItemID);
               int val8 = 45;
               reportSectionExtraB.Ordinal = val8;
               Assert.AreEqual(val8, reportSectionExtraB.Ordinal);
               bool val9 = true;
               reportSectionExtraB.IsStatic = val9;
               Assert.AreEqual(val9, reportSectionExtraB.IsStatic);
               int val10 = 45;
               reportSectionExtraB.ParentReportSectionID = val10;
               Assert.AreEqual(val10, reportSectionExtraB.ParentReportSectionID);
               int val11 = 45;
               reportSectionExtraB.Year = val11;
               Assert.AreEqual(val11, reportSectionExtraB.Year);
               bool val12 = true;
               reportSectionExtraB.Locked = val12;
               Assert.AreEqual(val12, reportSectionExtraB.Locked);
               int val13 = 45;
               reportSectionExtraB.TemplateReportSectionID = val13;
               Assert.AreEqual(val13, reportSectionExtraB.TemplateReportSectionID);
               DateTime val14 = new DateTime(2010, 3, 4);
               reportSectionExtraB.LastUpdateDate_UTC = val14;
               Assert.AreEqual(val14, reportSectionExtraB.LastUpdateDate_UTC);
               int val15 = 45;
               reportSectionExtraB.LastUpdateContactTVItemID = val15;
               Assert.AreEqual(val15, reportSectionExtraB.LastUpdateContactTVItemID);
               bool val16 = true;
               reportSectionExtraB.HasErrors = val16;
               Assert.AreEqual(val16, reportSectionExtraB.HasErrors);
               IEnumerable<ValidationResult> val51 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               reportSectionExtraB.ValidationResults = val51;
               Assert.AreEqual(val51, reportSectionExtraB.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
