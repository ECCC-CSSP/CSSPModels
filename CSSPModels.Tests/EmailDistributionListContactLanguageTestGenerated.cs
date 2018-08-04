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
    public partial class EmailDistributionListContactLanguageTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private EmailDistributionListContactLanguage emailDistributionListContactLanguage { get; set; }
        private EmailDistributionListContactLanguageWeb emailDistributionListContactLanguageWeb { get; set; }
        private EmailDistributionListContactLanguageReport emailDistributionListContactLanguageReport { get; set; }
        #endregion Properties

        #region Constructors
        public EmailDistributionListContactLanguageTest()
        {
            emailDistributionListContactLanguage = new EmailDistributionListContactLanguage();
            emailDistributionListContactLanguageWeb = new EmailDistributionListContactLanguageWeb();
            emailDistributionListContactLanguageReport = new EmailDistributionListContactLanguageReport();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void EmailDistributionListContactLanguage_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "EmailDistributionListContactLanguageID", "EmailDistributionListContactID", "Language", "Agency", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguage).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void EmailDistributionListContactLanguageWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactTVItemLanguage", "LanguageText", "TranslationStatusText", "EmailDistributionListContactLanguageID", "EmailDistributionListContactID", "Language", "Agency", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguageWeb).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguageWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void EmailDistributionListContactLanguageReport_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "EmailDistributionListContactLanguageReportTest", "LastUpdateContactTVItemLanguage", "LanguageText", "TranslationStatusText", "EmailDistributionListContactLanguageID", "EmailDistributionListContactID", "Language", "Agency", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguageReport).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguageReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void EmailDistributionListContactLanguage_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguage).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void EmailDistributionListContactLanguageWeb_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguageWeb).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguageWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void EmailDistributionListContactLanguageReport_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguageReport).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguageReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void EmailDistributionListContactLanguage_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(EmailDistributionListContactLanguage).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void EmailDistributionListContactLanguageWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(EmailDistributionListContactLanguageWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void EmailDistributionListContactLanguageReport_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(EmailDistributionListContactLanguageReport).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void EmailDistributionListContactLanguage_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               emailDistributionListContactLanguage.EmailDistributionListContactLanguageID = val1;
               Assert.AreEqual(val1, emailDistributionListContactLanguage.EmailDistributionListContactLanguageID);
               int val2 = 45;
               emailDistributionListContactLanguage.EmailDistributionListContactID = val2;
               Assert.AreEqual(val2, emailDistributionListContactLanguage.EmailDistributionListContactID);
               LanguageEnum val3 = (LanguageEnum)3;
               emailDistributionListContactLanguage.Language = val3;
               Assert.AreEqual(val3, emailDistributionListContactLanguage.Language);
               string val4 = "Some text";
               emailDistributionListContactLanguage.Agency = val4;
               Assert.AreEqual(val4, emailDistributionListContactLanguage.Agency);
               TranslationStatusEnum val5 = (TranslationStatusEnum)3;
               emailDistributionListContactLanguage.TranslationStatus = val5;
               Assert.AreEqual(val5, emailDistributionListContactLanguage.TranslationStatus);
               DateTime val6 = new DateTime(2010, 3, 4);
               emailDistributionListContactLanguage.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, emailDistributionListContactLanguage.LastUpdateDate_UTC);
               int val7 = 45;
               emailDistributionListContactLanguage.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, emailDistributionListContactLanguage.LastUpdateContactTVItemID);
               bool val8 = true;
               emailDistributionListContactLanguage.HasErrors = val8;
               Assert.AreEqual(val8, emailDistributionListContactLanguage.HasErrors);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               emailDistributionListContactLanguage.ValidationResults = val27;
               Assert.AreEqual(val27, emailDistributionListContactLanguage.ValidationResults);
        }
        [TestMethod]
        public void EmailDistributionListContactLanguageWeb_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               emailDistributionListContactLanguageWeb.LastUpdateContactTVItemLanguage = val1;
               Assert.AreEqual(val1, emailDistributionListContactLanguageWeb.LastUpdateContactTVItemLanguage);
               string val2 = "Some text";
               emailDistributionListContactLanguageWeb.LanguageText = val2;
               Assert.AreEqual(val2, emailDistributionListContactLanguageWeb.LanguageText);
               string val3 = "Some text";
               emailDistributionListContactLanguageWeb.TranslationStatusText = val3;
               Assert.AreEqual(val3, emailDistributionListContactLanguageWeb.TranslationStatusText);
               int val4 = 45;
               emailDistributionListContactLanguageWeb.EmailDistributionListContactLanguageID = val4;
               Assert.AreEqual(val4, emailDistributionListContactLanguageWeb.EmailDistributionListContactLanguageID);
               int val5 = 45;
               emailDistributionListContactLanguageWeb.EmailDistributionListContactID = val5;
               Assert.AreEqual(val5, emailDistributionListContactLanguageWeb.EmailDistributionListContactID);
               LanguageEnum val6 = (LanguageEnum)3;
               emailDistributionListContactLanguageWeb.Language = val6;
               Assert.AreEqual(val6, emailDistributionListContactLanguageWeb.Language);
               string val7 = "Some text";
               emailDistributionListContactLanguageWeb.Agency = val7;
               Assert.AreEqual(val7, emailDistributionListContactLanguageWeb.Agency);
               TranslationStatusEnum val8 = (TranslationStatusEnum)3;
               emailDistributionListContactLanguageWeb.TranslationStatus = val8;
               Assert.AreEqual(val8, emailDistributionListContactLanguageWeb.TranslationStatus);
               DateTime val9 = new DateTime(2010, 3, 4);
               emailDistributionListContactLanguageWeb.LastUpdateDate_UTC = val9;
               Assert.AreEqual(val9, emailDistributionListContactLanguageWeb.LastUpdateDate_UTC);
               int val10 = 45;
               emailDistributionListContactLanguageWeb.LastUpdateContactTVItemID = val10;
               Assert.AreEqual(val10, emailDistributionListContactLanguageWeb.LastUpdateContactTVItemID);
               bool val11 = true;
               emailDistributionListContactLanguageWeb.HasErrors = val11;
               Assert.AreEqual(val11, emailDistributionListContactLanguageWeb.HasErrors);
               IEnumerable<ValidationResult> val36 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               emailDistributionListContactLanguageWeb.ValidationResults = val36;
               Assert.AreEqual(val36, emailDistributionListContactLanguageWeb.ValidationResults);
        }
        [TestMethod]
        public void EmailDistributionListContactLanguageReport_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               emailDistributionListContactLanguageReport.EmailDistributionListContactLanguageReportTest = val1;
               Assert.AreEqual(val1, emailDistributionListContactLanguageReport.EmailDistributionListContactLanguageReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               emailDistributionListContactLanguageReport.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, emailDistributionListContactLanguageReport.LastUpdateContactTVItemLanguage);
               string val3 = "Some text";
               emailDistributionListContactLanguageReport.LanguageText = val3;
               Assert.AreEqual(val3, emailDistributionListContactLanguageReport.LanguageText);
               string val4 = "Some text";
               emailDistributionListContactLanguageReport.TranslationStatusText = val4;
               Assert.AreEqual(val4, emailDistributionListContactLanguageReport.TranslationStatusText);
               int val5 = 45;
               emailDistributionListContactLanguageReport.EmailDistributionListContactLanguageID = val5;
               Assert.AreEqual(val5, emailDistributionListContactLanguageReport.EmailDistributionListContactLanguageID);
               int val6 = 45;
               emailDistributionListContactLanguageReport.EmailDistributionListContactID = val6;
               Assert.AreEqual(val6, emailDistributionListContactLanguageReport.EmailDistributionListContactID);
               LanguageEnum val7 = (LanguageEnum)3;
               emailDistributionListContactLanguageReport.Language = val7;
               Assert.AreEqual(val7, emailDistributionListContactLanguageReport.Language);
               string val8 = "Some text";
               emailDistributionListContactLanguageReport.Agency = val8;
               Assert.AreEqual(val8, emailDistributionListContactLanguageReport.Agency);
               TranslationStatusEnum val9 = (TranslationStatusEnum)3;
               emailDistributionListContactLanguageReport.TranslationStatus = val9;
               Assert.AreEqual(val9, emailDistributionListContactLanguageReport.TranslationStatus);
               DateTime val10 = new DateTime(2010, 3, 4);
               emailDistributionListContactLanguageReport.LastUpdateDate_UTC = val10;
               Assert.AreEqual(val10, emailDistributionListContactLanguageReport.LastUpdateDate_UTC);
               int val11 = 45;
               emailDistributionListContactLanguageReport.LastUpdateContactTVItemID = val11;
               Assert.AreEqual(val11, emailDistributionListContactLanguageReport.LastUpdateContactTVItemID);
               bool val12 = true;
               emailDistributionListContactLanguageReport.HasErrors = val12;
               Assert.AreEqual(val12, emailDistributionListContactLanguageReport.HasErrors);
               IEnumerable<ValidationResult> val39 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               emailDistributionListContactLanguageReport.ValidationResults = val39;
               Assert.AreEqual(val39, emailDistributionListContactLanguageReport.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
