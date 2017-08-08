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
    public partial class TVFileLanguageTest : SetupData
    {
        [TestMethod]
        public void TVFileLanguage_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVFileLanguageID", "TVFileID", "Language", "FileDescription", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "LastUpdateContactTVText", "LanguageText", "TranslationStatusText",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.TVFileLanguage).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TVFileLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVFileLanguage_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVFileLanguage).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVFileLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVFileLanguage_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVFileLanguage).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVFileLanguage_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.TVFileLanguageTVFileLanguageID);
               Assert.IsNotNull(ModelsRes.TVFileLanguageTVFileID);
               Assert.IsNotNull(ModelsRes.TVFileLanguageLanguage);
               Assert.IsNotNull(ModelsRes.TVFileLanguageFileDescription);
               Assert.IsNotNull(ModelsRes.TVFileLanguageTranslationStatus);
               Assert.IsNotNull(ModelsRes.TVFileLanguageLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.TVFileLanguageLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.TVFileLanguageLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.TVFileLanguageLanguageText);
               Assert.IsNotNull(ModelsRes.TVFileLanguageTranslationStatusText);
        }
        [TestMethod]
        public void TVFileLanguage_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               tVFileLanguage.TVFileLanguageID = val1;
               Assert.AreEqual(val1, tVFileLanguage.TVFileLanguageID);
               int val2 = 45;
               tVFileLanguage.TVFileID = val2;
               Assert.AreEqual(val2, tVFileLanguage.TVFileID);
               LanguageEnum val3 = (LanguageEnum)3;
               tVFileLanguage.Language = val3;
               Assert.AreEqual(val3, tVFileLanguage.Language);
               string val4 = "Some text";
               tVFileLanguage.FileDescription = val4;
               Assert.AreEqual(val4, tVFileLanguage.FileDescription);
               TranslationStatusEnum val5 = (TranslationStatusEnum)3;
               tVFileLanguage.TranslationStatus = val5;
               Assert.AreEqual(val5, tVFileLanguage.TranslationStatus);
               DateTime val6 = new DateTime(2010, 3, 4);
               tVFileLanguage.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, tVFileLanguage.LastUpdateDate_UTC);
               int val7 = 45;
               tVFileLanguage.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, tVFileLanguage.LastUpdateContactTVItemID);
               string val8 = "Some text";
               tVFileLanguage.LastUpdateContactTVText = val8;
               Assert.AreEqual(val8, tVFileLanguage.LastUpdateContactTVText);
               string val9 = "Some text";
               tVFileLanguage.LanguageText = val9;
               Assert.AreEqual(val9, tVFileLanguage.LanguageText);
               string val10 = "Some text";
               tVFileLanguage.TranslationStatusText = val10;
               Assert.AreEqual(val10, tVFileLanguage.TranslationStatusText);
               IEnumerable<ValidationResult> val33 = new List<ValidationResult>().AsEnumerable();
               tVFileLanguage.ValidationResults = val33;
               Assert.AreEqual(val33, tVFileLanguage.ValidationResults);
        }
    }
}
