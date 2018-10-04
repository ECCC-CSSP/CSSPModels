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
    public partial class AppTaskLanguageTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private AppTaskLanguage appTaskLanguage { get; set; }
        private AppTaskLanguage_A appTaskLanguage_A { get; set; }
        private AppTaskLanguage_B appTaskLanguage_B { get; set; }
        #endregion Properties

        #region Constructors
        public AppTaskLanguageTest()
        {
            appTaskLanguage = new AppTaskLanguage();
            appTaskLanguage_A = new AppTaskLanguage_A();
            appTaskLanguage_B = new AppTaskLanguage_B();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void AppTaskLanguage_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "AppTaskLanguageID", "AppTaskID", "Language", "StatusText", "ErrorText", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AppTaskLanguage).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(AppTaskLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void AppTaskLanguage_A_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactTVItemLanguage", "LanguageText", "TranslationStatusText", "AppTaskLanguageID", "AppTaskID", "Language", "StatusText", "ErrorText", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AppTaskLanguage_A).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(AppTaskLanguage_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void AppTaskLanguage_B_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "AppTaskLanguageReportTest", "LastUpdateContactTVItemLanguage", "LanguageText", "TranslationStatusText", "AppTaskLanguageID", "AppTaskID", "Language", "StatusText", "ErrorText", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AppTaskLanguage_B).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(AppTaskLanguage_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void AppTaskLanguage_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AppTaskLanguage).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AppTaskLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void AppTaskLanguage_A_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AppTaskLanguage_A).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AppTaskLanguage_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void AppTaskLanguage_B_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AppTaskLanguage_B).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AppTaskLanguage_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void AppTaskLanguage_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(AppTaskLanguage).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void AppTaskLanguage_A_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(AppTaskLanguage_A).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void AppTaskLanguage_B_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(AppTaskLanguage_B).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void AppTaskLanguage_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               appTaskLanguage.AppTaskLanguageID = val1;
               Assert.AreEqual(val1, appTaskLanguage.AppTaskLanguageID);
               int val2 = 45;
               appTaskLanguage.AppTaskID = val2;
               Assert.AreEqual(val2, appTaskLanguage.AppTaskID);
               LanguageEnum val3 = (LanguageEnum)3;
               appTaskLanguage.Language = val3;
               Assert.AreEqual(val3, appTaskLanguage.Language);
               string val4 = "Some text";
               appTaskLanguage.StatusText = val4;
               Assert.AreEqual(val4, appTaskLanguage.StatusText);
               string val5 = "Some text";
               appTaskLanguage.ErrorText = val5;
               Assert.AreEqual(val5, appTaskLanguage.ErrorText);
               TranslationStatusEnum val6 = (TranslationStatusEnum)3;
               appTaskLanguage.TranslationStatus = val6;
               Assert.AreEqual(val6, appTaskLanguage.TranslationStatus);
               DateTime val7 = new DateTime(2010, 3, 4);
               appTaskLanguage.LastUpdateDate_UTC = val7;
               Assert.AreEqual(val7, appTaskLanguage.LastUpdateDate_UTC);
               int val8 = 45;
               appTaskLanguage.LastUpdateContactTVItemID = val8;
               Assert.AreEqual(val8, appTaskLanguage.LastUpdateContactTVItemID);
               bool val9 = true;
               appTaskLanguage.HasErrors = val9;
               Assert.AreEqual(val9, appTaskLanguage.HasErrors);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               appTaskLanguage.ValidationResults = val30;
               Assert.AreEqual(val30, appTaskLanguage.ValidationResults);
        }
        [TestMethod]
        public void AppTaskLanguage_A_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               appTaskLanguage_A.LastUpdateContactTVItemLanguage = val1;
               Assert.AreEqual(val1, appTaskLanguage_A.LastUpdateContactTVItemLanguage);
               string val2 = "Some text";
               appTaskLanguage_A.LanguageText = val2;
               Assert.AreEqual(val2, appTaskLanguage_A.LanguageText);
               string val3 = "Some text";
               appTaskLanguage_A.TranslationStatusText = val3;
               Assert.AreEqual(val3, appTaskLanguage_A.TranslationStatusText);
               int val4 = 45;
               appTaskLanguage_A.AppTaskLanguageID = val4;
               Assert.AreEqual(val4, appTaskLanguage_A.AppTaskLanguageID);
               int val5 = 45;
               appTaskLanguage_A.AppTaskID = val5;
               Assert.AreEqual(val5, appTaskLanguage_A.AppTaskID);
               LanguageEnum val6 = (LanguageEnum)3;
               appTaskLanguage_A.Language = val6;
               Assert.AreEqual(val6, appTaskLanguage_A.Language);
               string val7 = "Some text";
               appTaskLanguage_A.StatusText = val7;
               Assert.AreEqual(val7, appTaskLanguage_A.StatusText);
               string val8 = "Some text";
               appTaskLanguage_A.ErrorText = val8;
               Assert.AreEqual(val8, appTaskLanguage_A.ErrorText);
               TranslationStatusEnum val9 = (TranslationStatusEnum)3;
               appTaskLanguage_A.TranslationStatus = val9;
               Assert.AreEqual(val9, appTaskLanguage_A.TranslationStatus);
               DateTime val10 = new DateTime(2010, 3, 4);
               appTaskLanguage_A.LastUpdateDate_UTC = val10;
               Assert.AreEqual(val10, appTaskLanguage_A.LastUpdateDate_UTC);
               int val11 = 45;
               appTaskLanguage_A.LastUpdateContactTVItemID = val11;
               Assert.AreEqual(val11, appTaskLanguage_A.LastUpdateContactTVItemID);
               bool val12 = true;
               appTaskLanguage_A.HasErrors = val12;
               Assert.AreEqual(val12, appTaskLanguage_A.HasErrors);
               IEnumerable<ValidationResult> val39 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               appTaskLanguage_A.ValidationResults = val39;
               Assert.AreEqual(val39, appTaskLanguage_A.ValidationResults);
        }
        [TestMethod]
        public void AppTaskLanguage_B_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               appTaskLanguage_B.AppTaskLanguageReportTest = val1;
               Assert.AreEqual(val1, appTaskLanguage_B.AppTaskLanguageReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               appTaskLanguage_B.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, appTaskLanguage_B.LastUpdateContactTVItemLanguage);
               string val3 = "Some text";
               appTaskLanguage_B.LanguageText = val3;
               Assert.AreEqual(val3, appTaskLanguage_B.LanguageText);
               string val4 = "Some text";
               appTaskLanguage_B.TranslationStatusText = val4;
               Assert.AreEqual(val4, appTaskLanguage_B.TranslationStatusText);
               int val5 = 45;
               appTaskLanguage_B.AppTaskLanguageID = val5;
               Assert.AreEqual(val5, appTaskLanguage_B.AppTaskLanguageID);
               int val6 = 45;
               appTaskLanguage_B.AppTaskID = val6;
               Assert.AreEqual(val6, appTaskLanguage_B.AppTaskID);
               LanguageEnum val7 = (LanguageEnum)3;
               appTaskLanguage_B.Language = val7;
               Assert.AreEqual(val7, appTaskLanguage_B.Language);
               string val8 = "Some text";
               appTaskLanguage_B.StatusText = val8;
               Assert.AreEqual(val8, appTaskLanguage_B.StatusText);
               string val9 = "Some text";
               appTaskLanguage_B.ErrorText = val9;
               Assert.AreEqual(val9, appTaskLanguage_B.ErrorText);
               TranslationStatusEnum val10 = (TranslationStatusEnum)3;
               appTaskLanguage_B.TranslationStatus = val10;
               Assert.AreEqual(val10, appTaskLanguage_B.TranslationStatus);
               DateTime val11 = new DateTime(2010, 3, 4);
               appTaskLanguage_B.LastUpdateDate_UTC = val11;
               Assert.AreEqual(val11, appTaskLanguage_B.LastUpdateDate_UTC);
               int val12 = 45;
               appTaskLanguage_B.LastUpdateContactTVItemID = val12;
               Assert.AreEqual(val12, appTaskLanguage_B.LastUpdateContactTVItemID);
               bool val13 = true;
               appTaskLanguage_B.HasErrors = val13;
               Assert.AreEqual(val13, appTaskLanguage_B.HasErrors);
               IEnumerable<ValidationResult> val42 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               appTaskLanguage_B.ValidationResults = val42;
               Assert.AreEqual(val42, appTaskLanguage_B.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
