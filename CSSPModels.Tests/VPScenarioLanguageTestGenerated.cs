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
    public partial class VPScenarioLanguageTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private VPScenarioLanguage vPScenarioLanguage { get; set; }
        private VPScenarioLanguageExtraA vPScenarioLanguageExtraA { get; set; }
        private VPScenarioLanguageExtraB vPScenarioLanguageExtraB { get; set; }
        #endregion Properties

        #region Constructors
        public VPScenarioLanguageTest()
        {
            vPScenarioLanguage = new VPScenarioLanguage();
            vPScenarioLanguageExtraA = new VPScenarioLanguageExtraA();
            vPScenarioLanguageExtraB = new VPScenarioLanguageExtraB();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void VPScenarioLanguage_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "VPScenarioLanguageID", "VPScenarioID", "Language", "VPScenarioName", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPScenarioLanguage).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(VPScenarioLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void VPScenarioLanguageExtraA_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactText", "LanguageText", "TranslationStatusText", "VPScenarioLanguageID", "VPScenarioID", "Language", "VPScenarioName", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPScenarioLanguageExtraA).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(VPScenarioLanguageExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void VPScenarioLanguageExtraB_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "VPScenarioLanguageReportTest", "LastUpdateContactText", "LanguageText", "TranslationStatusText", "VPScenarioLanguageID", "VPScenarioID", "Language", "VPScenarioName", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPScenarioLanguageExtraB).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(VPScenarioLanguageExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void VPScenarioLanguage_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPScenarioLanguage).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPScenarioLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void VPScenarioLanguageExtraA_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPScenarioLanguageExtraA).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPScenarioLanguageExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void VPScenarioLanguageExtraB_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPScenarioLanguageExtraB).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPScenarioLanguageExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void VPScenarioLanguage_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(VPScenarioLanguage).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void VPScenarioLanguageExtraA_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(VPScenarioLanguageExtraA).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void VPScenarioLanguageExtraB_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(VPScenarioLanguageExtraB).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void VPScenarioLanguage_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               vPScenarioLanguage.VPScenarioLanguageID = val1;
               Assert.AreEqual(val1, vPScenarioLanguage.VPScenarioLanguageID);
               int val2 = 45;
               vPScenarioLanguage.VPScenarioID = val2;
               Assert.AreEqual(val2, vPScenarioLanguage.VPScenarioID);
               LanguageEnum val3 = (LanguageEnum)3;
               vPScenarioLanguage.Language = val3;
               Assert.AreEqual(val3, vPScenarioLanguage.Language);
               string val4 = "Some text";
               vPScenarioLanguage.VPScenarioName = val4;
               Assert.AreEqual(val4, vPScenarioLanguage.VPScenarioName);
               TranslationStatusEnum val5 = (TranslationStatusEnum)3;
               vPScenarioLanguage.TranslationStatus = val5;
               Assert.AreEqual(val5, vPScenarioLanguage.TranslationStatus);
               DateTime val6 = new DateTime(2010, 3, 4);
               vPScenarioLanguage.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, vPScenarioLanguage.LastUpdateDate_UTC);
               int val7 = 45;
               vPScenarioLanguage.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, vPScenarioLanguage.LastUpdateContactTVItemID);
               bool val8 = true;
               vPScenarioLanguage.HasErrors = val8;
               Assert.AreEqual(val8, vPScenarioLanguage.HasErrors);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               vPScenarioLanguage.ValidationResults = val27;
               Assert.AreEqual(val27, vPScenarioLanguage.ValidationResults);
        }
        [TestMethod]
        public void VPScenarioLanguageExtraA_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               vPScenarioLanguageExtraA.LastUpdateContactText = val1;
               Assert.AreEqual(val1, vPScenarioLanguageExtraA.LastUpdateContactText);
               string val2 = "Some text";
               vPScenarioLanguageExtraA.LanguageText = val2;
               Assert.AreEqual(val2, vPScenarioLanguageExtraA.LanguageText);
               string val3 = "Some text";
               vPScenarioLanguageExtraA.TranslationStatusText = val3;
               Assert.AreEqual(val3, vPScenarioLanguageExtraA.TranslationStatusText);
               int val4 = 45;
               vPScenarioLanguageExtraA.VPScenarioLanguageID = val4;
               Assert.AreEqual(val4, vPScenarioLanguageExtraA.VPScenarioLanguageID);
               int val5 = 45;
               vPScenarioLanguageExtraA.VPScenarioID = val5;
               Assert.AreEqual(val5, vPScenarioLanguageExtraA.VPScenarioID);
               LanguageEnum val6 = (LanguageEnum)3;
               vPScenarioLanguageExtraA.Language = val6;
               Assert.AreEqual(val6, vPScenarioLanguageExtraA.Language);
               string val7 = "Some text";
               vPScenarioLanguageExtraA.VPScenarioName = val7;
               Assert.AreEqual(val7, vPScenarioLanguageExtraA.VPScenarioName);
               TranslationStatusEnum val8 = (TranslationStatusEnum)3;
               vPScenarioLanguageExtraA.TranslationStatus = val8;
               Assert.AreEqual(val8, vPScenarioLanguageExtraA.TranslationStatus);
               DateTime val9 = new DateTime(2010, 3, 4);
               vPScenarioLanguageExtraA.LastUpdateDate_UTC = val9;
               Assert.AreEqual(val9, vPScenarioLanguageExtraA.LastUpdateDate_UTC);
               int val10 = 45;
               vPScenarioLanguageExtraA.LastUpdateContactTVItemID = val10;
               Assert.AreEqual(val10, vPScenarioLanguageExtraA.LastUpdateContactTVItemID);
               bool val11 = true;
               vPScenarioLanguageExtraA.HasErrors = val11;
               Assert.AreEqual(val11, vPScenarioLanguageExtraA.HasErrors);
               IEnumerable<ValidationResult> val36 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               vPScenarioLanguageExtraA.ValidationResults = val36;
               Assert.AreEqual(val36, vPScenarioLanguageExtraA.ValidationResults);
        }
        [TestMethod]
        public void VPScenarioLanguageExtraB_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               vPScenarioLanguageExtraB.VPScenarioLanguageReportTest = val1;
               Assert.AreEqual(val1, vPScenarioLanguageExtraB.VPScenarioLanguageReportTest);
               string val2 = "Some text";
               vPScenarioLanguageExtraB.LastUpdateContactText = val2;
               Assert.AreEqual(val2, vPScenarioLanguageExtraB.LastUpdateContactText);
               string val3 = "Some text";
               vPScenarioLanguageExtraB.LanguageText = val3;
               Assert.AreEqual(val3, vPScenarioLanguageExtraB.LanguageText);
               string val4 = "Some text";
               vPScenarioLanguageExtraB.TranslationStatusText = val4;
               Assert.AreEqual(val4, vPScenarioLanguageExtraB.TranslationStatusText);
               int val5 = 45;
               vPScenarioLanguageExtraB.VPScenarioLanguageID = val5;
               Assert.AreEqual(val5, vPScenarioLanguageExtraB.VPScenarioLanguageID);
               int val6 = 45;
               vPScenarioLanguageExtraB.VPScenarioID = val6;
               Assert.AreEqual(val6, vPScenarioLanguageExtraB.VPScenarioID);
               LanguageEnum val7 = (LanguageEnum)3;
               vPScenarioLanguageExtraB.Language = val7;
               Assert.AreEqual(val7, vPScenarioLanguageExtraB.Language);
               string val8 = "Some text";
               vPScenarioLanguageExtraB.VPScenarioName = val8;
               Assert.AreEqual(val8, vPScenarioLanguageExtraB.VPScenarioName);
               TranslationStatusEnum val9 = (TranslationStatusEnum)3;
               vPScenarioLanguageExtraB.TranslationStatus = val9;
               Assert.AreEqual(val9, vPScenarioLanguageExtraB.TranslationStatus);
               DateTime val10 = new DateTime(2010, 3, 4);
               vPScenarioLanguageExtraB.LastUpdateDate_UTC = val10;
               Assert.AreEqual(val10, vPScenarioLanguageExtraB.LastUpdateDate_UTC);
               int val11 = 45;
               vPScenarioLanguageExtraB.LastUpdateContactTVItemID = val11;
               Assert.AreEqual(val11, vPScenarioLanguageExtraB.LastUpdateContactTVItemID);
               bool val12 = true;
               vPScenarioLanguageExtraB.HasErrors = val12;
               Assert.AreEqual(val12, vPScenarioLanguageExtraB.HasErrors);
               IEnumerable<ValidationResult> val39 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               vPScenarioLanguageExtraB.ValidationResults = val39;
               Assert.AreEqual(val39, vPScenarioLanguageExtraB.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
