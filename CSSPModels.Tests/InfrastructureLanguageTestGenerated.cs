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
    public partial class InfrastructureLanguageTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private InfrastructureLanguage infrastructureLanguage { get; set; }
        private InfrastructureLanguageExtraA infrastructureLanguageExtraA { get; set; }
        private InfrastructureLanguageExtraB infrastructureLanguageExtraB { get; set; }
        #endregion Properties

        #region Constructors
        public InfrastructureLanguageTest()
        {
            infrastructureLanguage = new InfrastructureLanguage();
            infrastructureLanguageExtraA = new InfrastructureLanguageExtraA();
            infrastructureLanguageExtraB = new InfrastructureLanguageExtraB();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void InfrastructureLanguage_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "InfrastructureLanguageID", "InfrastructureID", "Language", "Comment", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(InfrastructureLanguage).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(InfrastructureLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void InfrastructureLanguageExtraA_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactText", "LanguageText", "TranslationStatusText", "InfrastructureLanguageID", "InfrastructureID", "Language", "Comment", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(InfrastructureLanguageExtraA).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(InfrastructureLanguageExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void InfrastructureLanguageExtraB_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "InfrastructureLanguageReportTest", "LastUpdateContactText", "LanguageText", "TranslationStatusText", "InfrastructureLanguageID", "InfrastructureID", "Language", "Comment", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(InfrastructureLanguageExtraB).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(InfrastructureLanguageExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void InfrastructureLanguage_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(InfrastructureLanguage).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(InfrastructureLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void InfrastructureLanguageExtraA_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(InfrastructureLanguageExtraA).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(InfrastructureLanguageExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void InfrastructureLanguageExtraB_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(InfrastructureLanguageExtraB).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(InfrastructureLanguageExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void InfrastructureLanguage_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(InfrastructureLanguage).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void InfrastructureLanguageExtraA_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(InfrastructureLanguageExtraA).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void InfrastructureLanguageExtraB_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(InfrastructureLanguageExtraB).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void InfrastructureLanguage_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               infrastructureLanguage.InfrastructureLanguageID = val1;
               Assert.AreEqual(val1, infrastructureLanguage.InfrastructureLanguageID);
               int val2 = 45;
               infrastructureLanguage.InfrastructureID = val2;
               Assert.AreEqual(val2, infrastructureLanguage.InfrastructureID);
               LanguageEnum val3 = (LanguageEnum)3;
               infrastructureLanguage.Language = val3;
               Assert.AreEqual(val3, infrastructureLanguage.Language);
               string val4 = "Some text";
               infrastructureLanguage.Comment = val4;
               Assert.AreEqual(val4, infrastructureLanguage.Comment);
               TranslationStatusEnum val5 = (TranslationStatusEnum)3;
               infrastructureLanguage.TranslationStatus = val5;
               Assert.AreEqual(val5, infrastructureLanguage.TranslationStatus);
               DateTime val6 = new DateTime(2010, 3, 4);
               infrastructureLanguage.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, infrastructureLanguage.LastUpdateDate_UTC);
               int val7 = 45;
               infrastructureLanguage.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, infrastructureLanguage.LastUpdateContactTVItemID);
               bool val8 = true;
               infrastructureLanguage.HasErrors = val8;
               Assert.AreEqual(val8, infrastructureLanguage.HasErrors);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               infrastructureLanguage.ValidationResults = val27;
               Assert.AreEqual(val27, infrastructureLanguage.ValidationResults);
        }
        [TestMethod]
        public void InfrastructureLanguageExtraA_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               infrastructureLanguageExtraA.LastUpdateContactText = val1;
               Assert.AreEqual(val1, infrastructureLanguageExtraA.LastUpdateContactText);
               string val2 = "Some text";
               infrastructureLanguageExtraA.LanguageText = val2;
               Assert.AreEqual(val2, infrastructureLanguageExtraA.LanguageText);
               string val3 = "Some text";
               infrastructureLanguageExtraA.TranslationStatusText = val3;
               Assert.AreEqual(val3, infrastructureLanguageExtraA.TranslationStatusText);
               int val4 = 45;
               infrastructureLanguageExtraA.InfrastructureLanguageID = val4;
               Assert.AreEqual(val4, infrastructureLanguageExtraA.InfrastructureLanguageID);
               int val5 = 45;
               infrastructureLanguageExtraA.InfrastructureID = val5;
               Assert.AreEqual(val5, infrastructureLanguageExtraA.InfrastructureID);
               LanguageEnum val6 = (LanguageEnum)3;
               infrastructureLanguageExtraA.Language = val6;
               Assert.AreEqual(val6, infrastructureLanguageExtraA.Language);
               string val7 = "Some text";
               infrastructureLanguageExtraA.Comment = val7;
               Assert.AreEqual(val7, infrastructureLanguageExtraA.Comment);
               TranslationStatusEnum val8 = (TranslationStatusEnum)3;
               infrastructureLanguageExtraA.TranslationStatus = val8;
               Assert.AreEqual(val8, infrastructureLanguageExtraA.TranslationStatus);
               DateTime val9 = new DateTime(2010, 3, 4);
               infrastructureLanguageExtraA.LastUpdateDate_UTC = val9;
               Assert.AreEqual(val9, infrastructureLanguageExtraA.LastUpdateDate_UTC);
               int val10 = 45;
               infrastructureLanguageExtraA.LastUpdateContactTVItemID = val10;
               Assert.AreEqual(val10, infrastructureLanguageExtraA.LastUpdateContactTVItemID);
               bool val11 = true;
               infrastructureLanguageExtraA.HasErrors = val11;
               Assert.AreEqual(val11, infrastructureLanguageExtraA.HasErrors);
               IEnumerable<ValidationResult> val36 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               infrastructureLanguageExtraA.ValidationResults = val36;
               Assert.AreEqual(val36, infrastructureLanguageExtraA.ValidationResults);
        }
        [TestMethod]
        public void InfrastructureLanguageExtraB_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               infrastructureLanguageExtraB.InfrastructureLanguageReportTest = val1;
               Assert.AreEqual(val1, infrastructureLanguageExtraB.InfrastructureLanguageReportTest);
               string val2 = "Some text";
               infrastructureLanguageExtraB.LastUpdateContactText = val2;
               Assert.AreEqual(val2, infrastructureLanguageExtraB.LastUpdateContactText);
               string val3 = "Some text";
               infrastructureLanguageExtraB.LanguageText = val3;
               Assert.AreEqual(val3, infrastructureLanguageExtraB.LanguageText);
               string val4 = "Some text";
               infrastructureLanguageExtraB.TranslationStatusText = val4;
               Assert.AreEqual(val4, infrastructureLanguageExtraB.TranslationStatusText);
               int val5 = 45;
               infrastructureLanguageExtraB.InfrastructureLanguageID = val5;
               Assert.AreEqual(val5, infrastructureLanguageExtraB.InfrastructureLanguageID);
               int val6 = 45;
               infrastructureLanguageExtraB.InfrastructureID = val6;
               Assert.AreEqual(val6, infrastructureLanguageExtraB.InfrastructureID);
               LanguageEnum val7 = (LanguageEnum)3;
               infrastructureLanguageExtraB.Language = val7;
               Assert.AreEqual(val7, infrastructureLanguageExtraB.Language);
               string val8 = "Some text";
               infrastructureLanguageExtraB.Comment = val8;
               Assert.AreEqual(val8, infrastructureLanguageExtraB.Comment);
               TranslationStatusEnum val9 = (TranslationStatusEnum)3;
               infrastructureLanguageExtraB.TranslationStatus = val9;
               Assert.AreEqual(val9, infrastructureLanguageExtraB.TranslationStatus);
               DateTime val10 = new DateTime(2010, 3, 4);
               infrastructureLanguageExtraB.LastUpdateDate_UTC = val10;
               Assert.AreEqual(val10, infrastructureLanguageExtraB.LastUpdateDate_UTC);
               int val11 = 45;
               infrastructureLanguageExtraB.LastUpdateContactTVItemID = val11;
               Assert.AreEqual(val11, infrastructureLanguageExtraB.LastUpdateContactTVItemID);
               bool val12 = true;
               infrastructureLanguageExtraB.HasErrors = val12;
               Assert.AreEqual(val12, infrastructureLanguageExtraB.HasErrors);
               IEnumerable<ValidationResult> val39 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               infrastructureLanguageExtraB.ValidationResults = val39;
               Assert.AreEqual(val39, infrastructureLanguageExtraB.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
