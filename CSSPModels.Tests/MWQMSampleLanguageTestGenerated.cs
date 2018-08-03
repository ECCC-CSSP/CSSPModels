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
    public partial class MWQMSampleLanguageTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private MWQMSampleLanguage mWQMSampleLanguage { get; set; }
        private MWQMSampleLanguageWeb mWQMSampleLanguageWeb { get; set; }
        private MWQMSampleLanguageReport mWQMSampleLanguageReport { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSampleLanguageTest()
        {
            mWQMSampleLanguage = new MWQMSampleLanguage();
            mWQMSampleLanguageWeb = new MWQMSampleLanguageWeb();
            mWQMSampleLanguageReport = new MWQMSampleLanguageReport();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void MWQMSampleLanguage_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMSampleLanguageID", "MWQMSampleID", "Language", "MWQMSampleNote", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSampleLanguage).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMSampleLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSampleLanguageWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactTVItemLanguage", "LanguageText", "TranslationStatusText", "MWQMSampleLanguageID", "MWQMSampleID", "Language", "MWQMSampleNote", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSampleLanguageWeb).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMSampleLanguageWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSampleLanguageReport_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMSampleLanguageReportTest", "LastUpdateContactTVItemLanguage", "LanguageText", "TranslationStatusText", "MWQMSampleLanguageID", "MWQMSampleID", "Language", "MWQMSampleNote", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSampleLanguageReport).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMSampleLanguageReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSampleLanguage_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSampleLanguage).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSampleLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSampleLanguageWeb_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSampleLanguageWeb).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSampleLanguageWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSampleLanguageReport_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSampleLanguageReport).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSampleLanguageReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSampleLanguage_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSampleLanguage).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSampleLanguageWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSampleLanguageWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSampleLanguageReport_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSampleLanguageReport).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSampleLanguage_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mWQMSampleLanguage.MWQMSampleLanguageID = val1;
               Assert.AreEqual(val1, mWQMSampleLanguage.MWQMSampleLanguageID);
               int val2 = 45;
               mWQMSampleLanguage.MWQMSampleID = val2;
               Assert.AreEqual(val2, mWQMSampleLanguage.MWQMSampleID);
               LanguageEnum val3 = (LanguageEnum)3;
               mWQMSampleLanguage.Language = val3;
               Assert.AreEqual(val3, mWQMSampleLanguage.Language);
               string val4 = "Some text";
               mWQMSampleLanguage.MWQMSampleNote = val4;
               Assert.AreEqual(val4, mWQMSampleLanguage.MWQMSampleNote);
               TranslationStatusEnum val5 = (TranslationStatusEnum)3;
               mWQMSampleLanguage.TranslationStatus = val5;
               Assert.AreEqual(val5, mWQMSampleLanguage.TranslationStatus);
               DateTime val6 = new DateTime(2010, 3, 4);
               mWQMSampleLanguage.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, mWQMSampleLanguage.LastUpdateDate_UTC);
               int val7 = 45;
               mWQMSampleLanguage.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, mWQMSampleLanguage.LastUpdateContactTVItemID);
               bool val8 = true;
               mWQMSampleLanguage.HasErrors = val8;
               Assert.AreEqual(val8, mWQMSampleLanguage.HasErrors);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mWQMSampleLanguage.ValidationResults = val27;
               Assert.AreEqual(val27, mWQMSampleLanguage.ValidationResults);
        }
        [TestMethod]
        public void MWQMSampleLanguageWeb_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               mWQMSampleLanguageWeb.LastUpdateContactTVItemLanguage = val1;
               Assert.AreEqual(val1, mWQMSampleLanguageWeb.LastUpdateContactTVItemLanguage);
               string val2 = "Some text";
               mWQMSampleLanguageWeb.LanguageText = val2;
               Assert.AreEqual(val2, mWQMSampleLanguageWeb.LanguageText);
               string val3 = "Some text";
               mWQMSampleLanguageWeb.TranslationStatusText = val3;
               Assert.AreEqual(val3, mWQMSampleLanguageWeb.TranslationStatusText);
               int val4 = 45;
               mWQMSampleLanguageWeb.MWQMSampleLanguageID = val4;
               Assert.AreEqual(val4, mWQMSampleLanguageWeb.MWQMSampleLanguageID);
               int val5 = 45;
               mWQMSampleLanguageWeb.MWQMSampleID = val5;
               Assert.AreEqual(val5, mWQMSampleLanguageWeb.MWQMSampleID);
               LanguageEnum val6 = (LanguageEnum)3;
               mWQMSampleLanguageWeb.Language = val6;
               Assert.AreEqual(val6, mWQMSampleLanguageWeb.Language);
               string val7 = "Some text";
               mWQMSampleLanguageWeb.MWQMSampleNote = val7;
               Assert.AreEqual(val7, mWQMSampleLanguageWeb.MWQMSampleNote);
               TranslationStatusEnum val8 = (TranslationStatusEnum)3;
               mWQMSampleLanguageWeb.TranslationStatus = val8;
               Assert.AreEqual(val8, mWQMSampleLanguageWeb.TranslationStatus);
               DateTime val9 = new DateTime(2010, 3, 4);
               mWQMSampleLanguageWeb.LastUpdateDate_UTC = val9;
               Assert.AreEqual(val9, mWQMSampleLanguageWeb.LastUpdateDate_UTC);
               int val10 = 45;
               mWQMSampleLanguageWeb.LastUpdateContactTVItemID = val10;
               Assert.AreEqual(val10, mWQMSampleLanguageWeb.LastUpdateContactTVItemID);
               bool val11 = true;
               mWQMSampleLanguageWeb.HasErrors = val11;
               Assert.AreEqual(val11, mWQMSampleLanguageWeb.HasErrors);
               IEnumerable<ValidationResult> val36 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mWQMSampleLanguageWeb.ValidationResults = val36;
               Assert.AreEqual(val36, mWQMSampleLanguageWeb.ValidationResults);
        }
        [TestMethod]
        public void MWQMSampleLanguageReport_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mWQMSampleLanguageReport.MWQMSampleLanguageReportTest = val1;
               Assert.AreEqual(val1, mWQMSampleLanguageReport.MWQMSampleLanguageReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               mWQMSampleLanguageReport.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, mWQMSampleLanguageReport.LastUpdateContactTVItemLanguage);
               string val3 = "Some text";
               mWQMSampleLanguageReport.LanguageText = val3;
               Assert.AreEqual(val3, mWQMSampleLanguageReport.LanguageText);
               string val4 = "Some text";
               mWQMSampleLanguageReport.TranslationStatusText = val4;
               Assert.AreEqual(val4, mWQMSampleLanguageReport.TranslationStatusText);
               int val5 = 45;
               mWQMSampleLanguageReport.MWQMSampleLanguageID = val5;
               Assert.AreEqual(val5, mWQMSampleLanguageReport.MWQMSampleLanguageID);
               int val6 = 45;
               mWQMSampleLanguageReport.MWQMSampleID = val6;
               Assert.AreEqual(val6, mWQMSampleLanguageReport.MWQMSampleID);
               LanguageEnum val7 = (LanguageEnum)3;
               mWQMSampleLanguageReport.Language = val7;
               Assert.AreEqual(val7, mWQMSampleLanguageReport.Language);
               string val8 = "Some text";
               mWQMSampleLanguageReport.MWQMSampleNote = val8;
               Assert.AreEqual(val8, mWQMSampleLanguageReport.MWQMSampleNote);
               TranslationStatusEnum val9 = (TranslationStatusEnum)3;
               mWQMSampleLanguageReport.TranslationStatus = val9;
               Assert.AreEqual(val9, mWQMSampleLanguageReport.TranslationStatus);
               DateTime val10 = new DateTime(2010, 3, 4);
               mWQMSampleLanguageReport.LastUpdateDate_UTC = val10;
               Assert.AreEqual(val10, mWQMSampleLanguageReport.LastUpdateDate_UTC);
               int val11 = 45;
               mWQMSampleLanguageReport.LastUpdateContactTVItemID = val11;
               Assert.AreEqual(val11, mWQMSampleLanguageReport.LastUpdateContactTVItemID);
               bool val12 = true;
               mWQMSampleLanguageReport.HasErrors = val12;
               Assert.AreEqual(val12, mWQMSampleLanguageReport.HasErrors);
               IEnumerable<ValidationResult> val39 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mWQMSampleLanguageReport.ValidationResults = val39;
               Assert.AreEqual(val39, mWQMSampleLanguageReport.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
