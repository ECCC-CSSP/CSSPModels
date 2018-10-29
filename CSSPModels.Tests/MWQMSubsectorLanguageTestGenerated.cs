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
    public partial class MWQMSubsectorLanguageTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private MWQMSubsectorLanguage mWQMSubsectorLanguage { get; set; }
        private MWQMSubsectorLanguageExtraA mWQMSubsectorLanguageExtraA { get; set; }
        private MWQMSubsectorLanguageExtraB mWQMSubsectorLanguageExtraB { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSubsectorLanguageTest()
        {
            mWQMSubsectorLanguage = new MWQMSubsectorLanguage();
            mWQMSubsectorLanguageExtraA = new MWQMSubsectorLanguageExtraA();
            mWQMSubsectorLanguageExtraB = new MWQMSubsectorLanguageExtraB();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void MWQMSubsectorLanguage_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMSubsectorLanguageID", "MWQMSubsectorID", "Language", "SubsectorDesc", "TranslationStatusSubsectorDesc", "LogBook", "TranslationStatusLogBook", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorLanguage).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSubsectorLanguageExtraA_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactText", "LanguageText", "TranslationStatusSubsectorDescText", "TranslationStatusLogBookText", "MWQMSubsectorLanguageID", "MWQMSubsectorID", "Language", "SubsectorDesc", "TranslationStatusSubsectorDesc", "LogBook", "TranslationStatusLogBook", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorLanguageExtraA).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorLanguageExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSubsectorLanguageExtraB_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMSubsectorLanguageReportTest", "LastUpdateContactText", "LanguageText", "TranslationStatusSubsectorDescText", "TranslationStatusLogBookText", "MWQMSubsectorLanguageID", "MWQMSubsectorID", "Language", "SubsectorDesc", "TranslationStatusSubsectorDesc", "LogBook", "TranslationStatusLogBook", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorLanguageExtraB).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorLanguageExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSubsectorLanguage_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorLanguage).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSubsectorLanguageExtraA_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorLanguageExtraA).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorLanguageExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSubsectorLanguageExtraB_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorLanguageExtraB).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorLanguageExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSubsectorLanguage_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSubsectorLanguage).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSubsectorLanguageExtraA_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSubsectorLanguageExtraA).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSubsectorLanguageExtraB_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSubsectorLanguageExtraB).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSubsectorLanguage_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mWQMSubsectorLanguage.MWQMSubsectorLanguageID = val1;
               Assert.AreEqual(val1, mWQMSubsectorLanguage.MWQMSubsectorLanguageID);
               int val2 = 45;
               mWQMSubsectorLanguage.MWQMSubsectorID = val2;
               Assert.AreEqual(val2, mWQMSubsectorLanguage.MWQMSubsectorID);
               LanguageEnum val3 = (LanguageEnum)3;
               mWQMSubsectorLanguage.Language = val3;
               Assert.AreEqual(val3, mWQMSubsectorLanguage.Language);
               string val4 = "Some text";
               mWQMSubsectorLanguage.SubsectorDesc = val4;
               Assert.AreEqual(val4, mWQMSubsectorLanguage.SubsectorDesc);
               TranslationStatusEnum val5 = (TranslationStatusEnum)3;
               mWQMSubsectorLanguage.TranslationStatusSubsectorDesc = val5;
               Assert.AreEqual(val5, mWQMSubsectorLanguage.TranslationStatusSubsectorDesc);
               string val6 = "Some text";
               mWQMSubsectorLanguage.LogBook = val6;
               Assert.AreEqual(val6, mWQMSubsectorLanguage.LogBook);
               TranslationStatusEnum val7 = (TranslationStatusEnum)3;
               mWQMSubsectorLanguage.TranslationStatusLogBook = val7;
               Assert.AreEqual(val7, mWQMSubsectorLanguage.TranslationStatusLogBook);
               DateTime val8 = new DateTime(2010, 3, 4);
               mWQMSubsectorLanguage.LastUpdateDate_UTC = val8;
               Assert.AreEqual(val8, mWQMSubsectorLanguage.LastUpdateDate_UTC);
               int val9 = 45;
               mWQMSubsectorLanguage.LastUpdateContactTVItemID = val9;
               Assert.AreEqual(val9, mWQMSubsectorLanguage.LastUpdateContactTVItemID);
               bool val10 = true;
               mWQMSubsectorLanguage.HasErrors = val10;
               Assert.AreEqual(val10, mWQMSubsectorLanguage.HasErrors);
               IEnumerable<ValidationResult> val33 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               mWQMSubsectorLanguage.ValidationResults = val33;
               Assert.AreEqual(val33, mWQMSubsectorLanguage.ValidationResults);
        }
        [TestMethod]
        public void MWQMSubsectorLanguageExtraA_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mWQMSubsectorLanguageExtraA.LastUpdateContactText = val1;
               Assert.AreEqual(val1, mWQMSubsectorLanguageExtraA.LastUpdateContactText);
               string val2 = "Some text";
               mWQMSubsectorLanguageExtraA.LanguageText = val2;
               Assert.AreEqual(val2, mWQMSubsectorLanguageExtraA.LanguageText);
               string val3 = "Some text";
               mWQMSubsectorLanguageExtraA.TranslationStatusSubsectorDescText = val3;
               Assert.AreEqual(val3, mWQMSubsectorLanguageExtraA.TranslationStatusSubsectorDescText);
               string val4 = "Some text";
               mWQMSubsectorLanguageExtraA.TranslationStatusLogBookText = val4;
               Assert.AreEqual(val4, mWQMSubsectorLanguageExtraA.TranslationStatusLogBookText);
               int val5 = 45;
               mWQMSubsectorLanguageExtraA.MWQMSubsectorLanguageID = val5;
               Assert.AreEqual(val5, mWQMSubsectorLanguageExtraA.MWQMSubsectorLanguageID);
               int val6 = 45;
               mWQMSubsectorLanguageExtraA.MWQMSubsectorID = val6;
               Assert.AreEqual(val6, mWQMSubsectorLanguageExtraA.MWQMSubsectorID);
               LanguageEnum val7 = (LanguageEnum)3;
               mWQMSubsectorLanguageExtraA.Language = val7;
               Assert.AreEqual(val7, mWQMSubsectorLanguageExtraA.Language);
               string val8 = "Some text";
               mWQMSubsectorLanguageExtraA.SubsectorDesc = val8;
               Assert.AreEqual(val8, mWQMSubsectorLanguageExtraA.SubsectorDesc);
               TranslationStatusEnum val9 = (TranslationStatusEnum)3;
               mWQMSubsectorLanguageExtraA.TranslationStatusSubsectorDesc = val9;
               Assert.AreEqual(val9, mWQMSubsectorLanguageExtraA.TranslationStatusSubsectorDesc);
               string val10 = "Some text";
               mWQMSubsectorLanguageExtraA.LogBook = val10;
               Assert.AreEqual(val10, mWQMSubsectorLanguageExtraA.LogBook);
               TranslationStatusEnum val11 = (TranslationStatusEnum)3;
               mWQMSubsectorLanguageExtraA.TranslationStatusLogBook = val11;
               Assert.AreEqual(val11, mWQMSubsectorLanguageExtraA.TranslationStatusLogBook);
               DateTime val12 = new DateTime(2010, 3, 4);
               mWQMSubsectorLanguageExtraA.LastUpdateDate_UTC = val12;
               Assert.AreEqual(val12, mWQMSubsectorLanguageExtraA.LastUpdateDate_UTC);
               int val13 = 45;
               mWQMSubsectorLanguageExtraA.LastUpdateContactTVItemID = val13;
               Assert.AreEqual(val13, mWQMSubsectorLanguageExtraA.LastUpdateContactTVItemID);
               bool val14 = true;
               mWQMSubsectorLanguageExtraA.HasErrors = val14;
               Assert.AreEqual(val14, mWQMSubsectorLanguageExtraA.HasErrors);
               IEnumerable<ValidationResult> val45 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               mWQMSubsectorLanguageExtraA.ValidationResults = val45;
               Assert.AreEqual(val45, mWQMSubsectorLanguageExtraA.ValidationResults);
        }
        [TestMethod]
        public void MWQMSubsectorLanguageExtraB_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mWQMSubsectorLanguageExtraB.MWQMSubsectorLanguageReportTest = val1;
               Assert.AreEqual(val1, mWQMSubsectorLanguageExtraB.MWQMSubsectorLanguageReportTest);
               string val2 = "Some text";
               mWQMSubsectorLanguageExtraB.LastUpdateContactText = val2;
               Assert.AreEqual(val2, mWQMSubsectorLanguageExtraB.LastUpdateContactText);
               string val3 = "Some text";
               mWQMSubsectorLanguageExtraB.LanguageText = val3;
               Assert.AreEqual(val3, mWQMSubsectorLanguageExtraB.LanguageText);
               string val4 = "Some text";
               mWQMSubsectorLanguageExtraB.TranslationStatusSubsectorDescText = val4;
               Assert.AreEqual(val4, mWQMSubsectorLanguageExtraB.TranslationStatusSubsectorDescText);
               string val5 = "Some text";
               mWQMSubsectorLanguageExtraB.TranslationStatusLogBookText = val5;
               Assert.AreEqual(val5, mWQMSubsectorLanguageExtraB.TranslationStatusLogBookText);
               int val6 = 45;
               mWQMSubsectorLanguageExtraB.MWQMSubsectorLanguageID = val6;
               Assert.AreEqual(val6, mWQMSubsectorLanguageExtraB.MWQMSubsectorLanguageID);
               int val7 = 45;
               mWQMSubsectorLanguageExtraB.MWQMSubsectorID = val7;
               Assert.AreEqual(val7, mWQMSubsectorLanguageExtraB.MWQMSubsectorID);
               LanguageEnum val8 = (LanguageEnum)3;
               mWQMSubsectorLanguageExtraB.Language = val8;
               Assert.AreEqual(val8, mWQMSubsectorLanguageExtraB.Language);
               string val9 = "Some text";
               mWQMSubsectorLanguageExtraB.SubsectorDesc = val9;
               Assert.AreEqual(val9, mWQMSubsectorLanguageExtraB.SubsectorDesc);
               TranslationStatusEnum val10 = (TranslationStatusEnum)3;
               mWQMSubsectorLanguageExtraB.TranslationStatusSubsectorDesc = val10;
               Assert.AreEqual(val10, mWQMSubsectorLanguageExtraB.TranslationStatusSubsectorDesc);
               string val11 = "Some text";
               mWQMSubsectorLanguageExtraB.LogBook = val11;
               Assert.AreEqual(val11, mWQMSubsectorLanguageExtraB.LogBook);
               TranslationStatusEnum val12 = (TranslationStatusEnum)3;
               mWQMSubsectorLanguageExtraB.TranslationStatusLogBook = val12;
               Assert.AreEqual(val12, mWQMSubsectorLanguageExtraB.TranslationStatusLogBook);
               DateTime val13 = new DateTime(2010, 3, 4);
               mWQMSubsectorLanguageExtraB.LastUpdateDate_UTC = val13;
               Assert.AreEqual(val13, mWQMSubsectorLanguageExtraB.LastUpdateDate_UTC);
               int val14 = 45;
               mWQMSubsectorLanguageExtraB.LastUpdateContactTVItemID = val14;
               Assert.AreEqual(val14, mWQMSubsectorLanguageExtraB.LastUpdateContactTVItemID);
               bool val15 = true;
               mWQMSubsectorLanguageExtraB.HasErrors = val15;
               Assert.AreEqual(val15, mWQMSubsectorLanguageExtraB.HasErrors);
               IEnumerable<ValidationResult> val48 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               mWQMSubsectorLanguageExtraB.ValidationResults = val48;
               Assert.AreEqual(val48, mWQMSubsectorLanguageExtraB.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
