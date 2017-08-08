using System;
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
    public partial class MWQMSampleLanguageTest : SetupData
    {
        [TestMethod]
        public void MWQMSampleLanguage_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMSampleLanguageID", "MWQMSampleID", "Language", "MWQMSampleNote", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "LastUpdateContactTVText", "LanguageText", "TranslationStatusText",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.MWQMSampleLanguage).GetProperties().OrderBy(c => c.Name))
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
        public void MWQMSampleLanguage_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSampleLanguage).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSampleLanguage_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.MWQMSampleLanguageMWQMSampleLanguageID);
               Assert.IsNotNull(ModelsRes.MWQMSampleLanguageMWQMSampleID);
               Assert.IsNotNull(ModelsRes.MWQMSampleLanguageLanguage);
               Assert.IsNotNull(ModelsRes.MWQMSampleLanguageMWQMSampleNote);
               Assert.IsNotNull(ModelsRes.MWQMSampleLanguageTranslationStatus);
               Assert.IsNotNull(ModelsRes.MWQMSampleLanguageLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.MWQMSampleLanguageLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.MWQMSampleLanguageLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.MWQMSampleLanguageLanguageText);
               Assert.IsNotNull(ModelsRes.MWQMSampleLanguageTranslationStatusText);
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
               string val8 = "Some text";
               mWQMSampleLanguage.LastUpdateContactTVText = val8;
               Assert.AreEqual(val8, mWQMSampleLanguage.LastUpdateContactTVText);
               string val9 = "Some text";
               mWQMSampleLanguage.LanguageText = val9;
               Assert.AreEqual(val9, mWQMSampleLanguage.LanguageText);
               string val10 = "Some text";
               mWQMSampleLanguage.TranslationStatusText = val10;
               Assert.AreEqual(val10, mWQMSampleLanguage.TranslationStatusText);
               IEnumerable<ValidationResult> val33 = new List<ValidationResult>().AsEnumerable();
               mWQMSampleLanguage.ValidationResults = val33;
               Assert.AreEqual(val33, mWQMSampleLanguage.ValidationResults);
        }
    }
}
