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
    public partial class TVItemLanguageTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private TVItemLanguage tVItemLanguage { get; set; }
        private TVItemLanguageWeb tVItemLanguageWeb { get; set; }
        private TVItemLanguageReport tVItemLanguageReport { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemLanguageTest()
        {
            tVItemLanguage = new TVItemLanguage();
            tVItemLanguageWeb = new TVItemLanguageWeb();
            tVItemLanguageReport = new TVItemLanguageReport();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void TVItemLanguage_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVItemLanguageID", "TVItemID", "Language", "TVText", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemLanguage).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TVItemLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItemLanguageWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactTVItemLanguage", "LanguageText", "TranslationStatusText", "TVItemLanguageID", "TVItemID", "Language", "TVText", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemLanguageWeb).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TVItemLanguageWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItemLanguageReport_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVItemLanguageReportTest", "LastUpdateContactTVItemLanguage", "LanguageText", "TranslationStatusText", "TVItemLanguageID", "TVItemID", "Language", "TVText", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemLanguageReport).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TVItemLanguageReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItemLanguage_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemLanguage).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItemLanguageWeb_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemLanguageWeb).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemLanguageWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItemLanguageReport_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemLanguageReport).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemLanguageReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItemLanguage_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVItemLanguage).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVItemLanguageWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVItemLanguageWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVItemLanguageReport_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVItemLanguageReport).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVItemLanguage_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               tVItemLanguage.TVItemLanguageID = val1;
               Assert.AreEqual(val1, tVItemLanguage.TVItemLanguageID);
               int val2 = 45;
               tVItemLanguage.TVItemID = val2;
               Assert.AreEqual(val2, tVItemLanguage.TVItemID);
               LanguageEnum val3 = (LanguageEnum)3;
               tVItemLanguage.Language = val3;
               Assert.AreEqual(val3, tVItemLanguage.Language);
               string val4 = "Some text";
               tVItemLanguage.TVText = val4;
               Assert.AreEqual(val4, tVItemLanguage.TVText);
               TranslationStatusEnum val5 = (TranslationStatusEnum)3;
               tVItemLanguage.TranslationStatus = val5;
               Assert.AreEqual(val5, tVItemLanguage.TranslationStatus);
               DateTime val6 = new DateTime(2010, 3, 4);
               tVItemLanguage.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, tVItemLanguage.LastUpdateDate_UTC);
               int val7 = 45;
               tVItemLanguage.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, tVItemLanguage.LastUpdateContactTVItemID);
               bool val8 = true;
               tVItemLanguage.HasErrors = val8;
               Assert.AreEqual(val8, tVItemLanguage.HasErrors);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               tVItemLanguage.ValidationResults = val27;
               Assert.AreEqual(val27, tVItemLanguage.ValidationResults);
        }
        [TestMethod]
        public void TVItemLanguageWeb_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               tVItemLanguageWeb.LastUpdateContactTVItemLanguage = val1;
               Assert.AreEqual(val1, tVItemLanguageWeb.LastUpdateContactTVItemLanguage);
               string val2 = "Some text";
               tVItemLanguageWeb.LanguageText = val2;
               Assert.AreEqual(val2, tVItemLanguageWeb.LanguageText);
               string val3 = "Some text";
               tVItemLanguageWeb.TranslationStatusText = val3;
               Assert.AreEqual(val3, tVItemLanguageWeb.TranslationStatusText);
               int val4 = 45;
               tVItemLanguageWeb.TVItemLanguageID = val4;
               Assert.AreEqual(val4, tVItemLanguageWeb.TVItemLanguageID);
               int val5 = 45;
               tVItemLanguageWeb.TVItemID = val5;
               Assert.AreEqual(val5, tVItemLanguageWeb.TVItemID);
               LanguageEnum val6 = (LanguageEnum)3;
               tVItemLanguageWeb.Language = val6;
               Assert.AreEqual(val6, tVItemLanguageWeb.Language);
               string val7 = "Some text";
               tVItemLanguageWeb.TVText = val7;
               Assert.AreEqual(val7, tVItemLanguageWeb.TVText);
               TranslationStatusEnum val8 = (TranslationStatusEnum)3;
               tVItemLanguageWeb.TranslationStatus = val8;
               Assert.AreEqual(val8, tVItemLanguageWeb.TranslationStatus);
               DateTime val9 = new DateTime(2010, 3, 4);
               tVItemLanguageWeb.LastUpdateDate_UTC = val9;
               Assert.AreEqual(val9, tVItemLanguageWeb.LastUpdateDate_UTC);
               int val10 = 45;
               tVItemLanguageWeb.LastUpdateContactTVItemID = val10;
               Assert.AreEqual(val10, tVItemLanguageWeb.LastUpdateContactTVItemID);
               bool val11 = true;
               tVItemLanguageWeb.HasErrors = val11;
               Assert.AreEqual(val11, tVItemLanguageWeb.HasErrors);
               IEnumerable<ValidationResult> val36 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               tVItemLanguageWeb.ValidationResults = val36;
               Assert.AreEqual(val36, tVItemLanguageWeb.ValidationResults);
        }
        [TestMethod]
        public void TVItemLanguageReport_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               tVItemLanguageReport.TVItemLanguageReportTest = val1;
               Assert.AreEqual(val1, tVItemLanguageReport.TVItemLanguageReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               tVItemLanguageReport.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, tVItemLanguageReport.LastUpdateContactTVItemLanguage);
               string val3 = "Some text";
               tVItemLanguageReport.LanguageText = val3;
               Assert.AreEqual(val3, tVItemLanguageReport.LanguageText);
               string val4 = "Some text";
               tVItemLanguageReport.TranslationStatusText = val4;
               Assert.AreEqual(val4, tVItemLanguageReport.TranslationStatusText);
               int val5 = 45;
               tVItemLanguageReport.TVItemLanguageID = val5;
               Assert.AreEqual(val5, tVItemLanguageReport.TVItemLanguageID);
               int val6 = 45;
               tVItemLanguageReport.TVItemID = val6;
               Assert.AreEqual(val6, tVItemLanguageReport.TVItemID);
               LanguageEnum val7 = (LanguageEnum)3;
               tVItemLanguageReport.Language = val7;
               Assert.AreEqual(val7, tVItemLanguageReport.Language);
               string val8 = "Some text";
               tVItemLanguageReport.TVText = val8;
               Assert.AreEqual(val8, tVItemLanguageReport.TVText);
               TranslationStatusEnum val9 = (TranslationStatusEnum)3;
               tVItemLanguageReport.TranslationStatus = val9;
               Assert.AreEqual(val9, tVItemLanguageReport.TranslationStatus);
               DateTime val10 = new DateTime(2010, 3, 4);
               tVItemLanguageReport.LastUpdateDate_UTC = val10;
               Assert.AreEqual(val10, tVItemLanguageReport.LastUpdateDate_UTC);
               int val11 = 45;
               tVItemLanguageReport.LastUpdateContactTVItemID = val11;
               Assert.AreEqual(val11, tVItemLanguageReport.LastUpdateContactTVItemID);
               bool val12 = true;
               tVItemLanguageReport.HasErrors = val12;
               Assert.AreEqual(val12, tVItemLanguageReport.HasErrors);
               IEnumerable<ValidationResult> val39 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               tVItemLanguageReport.ValidationResults = val39;
               Assert.AreEqual(val39, tVItemLanguageReport.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
