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
    public partial class TVItemLanguageTest : SetupData
    {
        [TestMethod]
        public void TVItemLanguage_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVItemLanguageID", "TVItemID", "Language", "TVText", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "LanguageText", "TranslationStatusText",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.TVItemLanguage).GetProperties().OrderBy(c => c.Name))
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
        public void TVItemLanguage_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVItemLanguage).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVItemLanguage_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.TVItemLanguageTVItemLanguageID);
               Assert.IsNotNull(ModelsRes.TVItemLanguageTVItemID);
               Assert.IsNotNull(ModelsRes.TVItemLanguageLanguage);
               Assert.IsNotNull(ModelsRes.TVItemLanguageTVText);
               Assert.IsNotNull(ModelsRes.TVItemLanguageTranslationStatus);
               Assert.IsNotNull(ModelsRes.TVItemLanguageLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.TVItemLanguageLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.TVItemLanguageLanguageText);
               Assert.IsNotNull(ModelsRes.TVItemLanguageTranslationStatusText);
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
               string val8 = "Some text";
               tVItemLanguage.LanguageText = val8;
               Assert.AreEqual(val8, tVItemLanguage.LanguageText);
               string val9 = "Some text";
               tVItemLanguage.TranslationStatusText = val9;
               Assert.AreEqual(val9, tVItemLanguage.TranslationStatusText);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>().AsEnumerable();
               tVItemLanguage.ValidationResults = val30;
               Assert.AreEqual(val30, tVItemLanguage.ValidationResults);
        }
    }
}
