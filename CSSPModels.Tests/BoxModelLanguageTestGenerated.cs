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
    public partial class BoxModelLanguageTest : SetupData
    {
        [TestMethod]
        public void BoxModelLanguage_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "BoxModelLanguageID", "BoxModelID", "Language", "ScenarioName", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "LastUpdateContactTVText", "LanguageText", "TranslationStatusText",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.BoxModelLanguage).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(BoxModelLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void BoxModelLanguage_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(BoxModelLanguage).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(BoxModelLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void BoxModelLanguage_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(BoxModelLanguage).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void BoxModelLanguage_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.BoxModelLanguageBoxModelLanguageID);
               Assert.IsNotNull(ModelsRes.BoxModelLanguageBoxModelID);
               Assert.IsNotNull(ModelsRes.BoxModelLanguageLanguage);
               Assert.IsNotNull(ModelsRes.BoxModelLanguageScenarioName);
               Assert.IsNotNull(ModelsRes.BoxModelLanguageTranslationStatus);
               Assert.IsNotNull(ModelsRes.BoxModelLanguageLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.BoxModelLanguageLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.BoxModelLanguageLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.BoxModelLanguageLanguageText);
               Assert.IsNotNull(ModelsRes.BoxModelLanguageTranslationStatusText);
        }
        [TestMethod]
        public void BoxModelLanguage_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               boxModelLanguage.BoxModelLanguageID = val1;
               Assert.AreEqual(val1, boxModelLanguage.BoxModelLanguageID);
               int val2 = 45;
               boxModelLanguage.BoxModelID = val2;
               Assert.AreEqual(val2, boxModelLanguage.BoxModelID);
               LanguageEnum val3 = (LanguageEnum)3;
               boxModelLanguage.Language = val3;
               Assert.AreEqual(val3, boxModelLanguage.Language);
               string val4 = "Some text";
               boxModelLanguage.ScenarioName = val4;
               Assert.AreEqual(val4, boxModelLanguage.ScenarioName);
               TranslationStatusEnum val5 = (TranslationStatusEnum)3;
               boxModelLanguage.TranslationStatus = val5;
               Assert.AreEqual(val5, boxModelLanguage.TranslationStatus);
               DateTime val6 = new DateTime(2010, 3, 4);
               boxModelLanguage.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, boxModelLanguage.LastUpdateDate_UTC);
               int val7 = 45;
               boxModelLanguage.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, boxModelLanguage.LastUpdateContactTVItemID);
               string val8 = "Some text";
               boxModelLanguage.LastUpdateContactTVText = val8;
               Assert.AreEqual(val8, boxModelLanguage.LastUpdateContactTVText);
               string val9 = "Some text";
               boxModelLanguage.LanguageText = val9;
               Assert.AreEqual(val9, boxModelLanguage.LanguageText);
               string val10 = "Some text";
               boxModelLanguage.TranslationStatusText = val10;
               Assert.AreEqual(val10, boxModelLanguage.TranslationStatusText);
               IEnumerable<ValidationResult> val33 = new List<ValidationResult>().AsEnumerable();
               boxModelLanguage.ValidationResults = val33;
               Assert.AreEqual(val33, boxModelLanguage.ValidationResults);
        }
    }
}
