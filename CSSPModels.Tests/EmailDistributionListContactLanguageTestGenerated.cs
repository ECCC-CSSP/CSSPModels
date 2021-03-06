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
    public partial class EmailDistributionListContactLanguageTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private EmailDistributionListContactLanguage emailDistributionListContactLanguage { get; set; }
        private EmailDistributionListContactLanguageExtraA emailDistributionListContactLanguageExtraA { get; set; }
        private EmailDistributionListContactLanguageExtraB emailDistributionListContactLanguageExtraB { get; set; }
        #endregion Properties

        #region Constructors
        public EmailDistributionListContactLanguageTest()
        {
            emailDistributionListContactLanguage = new EmailDistributionListContactLanguage();
            emailDistributionListContactLanguageExtraA = new EmailDistributionListContactLanguageExtraA();
            emailDistributionListContactLanguageExtraB = new EmailDistributionListContactLanguageExtraB();
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
        public void EmailDistributionListContactLanguageExtraA_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactText", "LanguageText", "TranslationStatusText", "EmailDistributionListContactLanguageID", "EmailDistributionListContactID", "Language", "Agency", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguageExtraA).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguageExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void EmailDistributionListContactLanguageExtraB_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "EmailDistributionListContactLanguageReportTest", "LastUpdateContactText", "LanguageText", "TranslationStatusText", "EmailDistributionListContactLanguageID", "EmailDistributionListContactID", "Language", "Agency", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguageExtraB).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguageExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void EmailDistributionListContactLanguageExtraA_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguageExtraA).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguageExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void EmailDistributionListContactLanguageExtraB_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguageExtraB).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguageExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void EmailDistributionListContactLanguageExtraA_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(EmailDistributionListContactLanguageExtraA).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void EmailDistributionListContactLanguageExtraB_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(EmailDistributionListContactLanguageExtraB).GetProperties().Where(c => c.Name == "ValidationResults").Any());
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
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               emailDistributionListContactLanguage.ValidationResults = val27;
               Assert.AreEqual(val27, emailDistributionListContactLanguage.ValidationResults);
        }
        [TestMethod]
        public void EmailDistributionListContactLanguageExtraA_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               emailDistributionListContactLanguageExtraA.LastUpdateContactText = val1;
               Assert.AreEqual(val1, emailDistributionListContactLanguageExtraA.LastUpdateContactText);
               string val2 = "Some text";
               emailDistributionListContactLanguageExtraA.LanguageText = val2;
               Assert.AreEqual(val2, emailDistributionListContactLanguageExtraA.LanguageText);
               string val3 = "Some text";
               emailDistributionListContactLanguageExtraA.TranslationStatusText = val3;
               Assert.AreEqual(val3, emailDistributionListContactLanguageExtraA.TranslationStatusText);
               int val4 = 45;
               emailDistributionListContactLanguageExtraA.EmailDistributionListContactLanguageID = val4;
               Assert.AreEqual(val4, emailDistributionListContactLanguageExtraA.EmailDistributionListContactLanguageID);
               int val5 = 45;
               emailDistributionListContactLanguageExtraA.EmailDistributionListContactID = val5;
               Assert.AreEqual(val5, emailDistributionListContactLanguageExtraA.EmailDistributionListContactID);
               LanguageEnum val6 = (LanguageEnum)3;
               emailDistributionListContactLanguageExtraA.Language = val6;
               Assert.AreEqual(val6, emailDistributionListContactLanguageExtraA.Language);
               string val7 = "Some text";
               emailDistributionListContactLanguageExtraA.Agency = val7;
               Assert.AreEqual(val7, emailDistributionListContactLanguageExtraA.Agency);
               TranslationStatusEnum val8 = (TranslationStatusEnum)3;
               emailDistributionListContactLanguageExtraA.TranslationStatus = val8;
               Assert.AreEqual(val8, emailDistributionListContactLanguageExtraA.TranslationStatus);
               DateTime val9 = new DateTime(2010, 3, 4);
               emailDistributionListContactLanguageExtraA.LastUpdateDate_UTC = val9;
               Assert.AreEqual(val9, emailDistributionListContactLanguageExtraA.LastUpdateDate_UTC);
               int val10 = 45;
               emailDistributionListContactLanguageExtraA.LastUpdateContactTVItemID = val10;
               Assert.AreEqual(val10, emailDistributionListContactLanguageExtraA.LastUpdateContactTVItemID);
               bool val11 = true;
               emailDistributionListContactLanguageExtraA.HasErrors = val11;
               Assert.AreEqual(val11, emailDistributionListContactLanguageExtraA.HasErrors);
               IEnumerable<ValidationResult> val36 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               emailDistributionListContactLanguageExtraA.ValidationResults = val36;
               Assert.AreEqual(val36, emailDistributionListContactLanguageExtraA.ValidationResults);
        }
        [TestMethod]
        public void EmailDistributionListContactLanguageExtraB_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               emailDistributionListContactLanguageExtraB.EmailDistributionListContactLanguageReportTest = val1;
               Assert.AreEqual(val1, emailDistributionListContactLanguageExtraB.EmailDistributionListContactLanguageReportTest);
               string val2 = "Some text";
               emailDistributionListContactLanguageExtraB.LastUpdateContactText = val2;
               Assert.AreEqual(val2, emailDistributionListContactLanguageExtraB.LastUpdateContactText);
               string val3 = "Some text";
               emailDistributionListContactLanguageExtraB.LanguageText = val3;
               Assert.AreEqual(val3, emailDistributionListContactLanguageExtraB.LanguageText);
               string val4 = "Some text";
               emailDistributionListContactLanguageExtraB.TranslationStatusText = val4;
               Assert.AreEqual(val4, emailDistributionListContactLanguageExtraB.TranslationStatusText);
               int val5 = 45;
               emailDistributionListContactLanguageExtraB.EmailDistributionListContactLanguageID = val5;
               Assert.AreEqual(val5, emailDistributionListContactLanguageExtraB.EmailDistributionListContactLanguageID);
               int val6 = 45;
               emailDistributionListContactLanguageExtraB.EmailDistributionListContactID = val6;
               Assert.AreEqual(val6, emailDistributionListContactLanguageExtraB.EmailDistributionListContactID);
               LanguageEnum val7 = (LanguageEnum)3;
               emailDistributionListContactLanguageExtraB.Language = val7;
               Assert.AreEqual(val7, emailDistributionListContactLanguageExtraB.Language);
               string val8 = "Some text";
               emailDistributionListContactLanguageExtraB.Agency = val8;
               Assert.AreEqual(val8, emailDistributionListContactLanguageExtraB.Agency);
               TranslationStatusEnum val9 = (TranslationStatusEnum)3;
               emailDistributionListContactLanguageExtraB.TranslationStatus = val9;
               Assert.AreEqual(val9, emailDistributionListContactLanguageExtraB.TranslationStatus);
               DateTime val10 = new DateTime(2010, 3, 4);
               emailDistributionListContactLanguageExtraB.LastUpdateDate_UTC = val10;
               Assert.AreEqual(val10, emailDistributionListContactLanguageExtraB.LastUpdateDate_UTC);
               int val11 = 45;
               emailDistributionListContactLanguageExtraB.LastUpdateContactTVItemID = val11;
               Assert.AreEqual(val11, emailDistributionListContactLanguageExtraB.LastUpdateContactTVItemID);
               bool val12 = true;
               emailDistributionListContactLanguageExtraB.HasErrors = val12;
               Assert.AreEqual(val12, emailDistributionListContactLanguageExtraB.HasErrors);
               IEnumerable<ValidationResult> val39 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               emailDistributionListContactLanguageExtraB.ValidationResults = val39;
               Assert.AreEqual(val39, emailDistributionListContactLanguageExtraB.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
