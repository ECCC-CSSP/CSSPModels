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
    public partial class InfrastructureLanguageTest : SetupData
    {
        [TestMethod]
        public void InfrastructureLanguage_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "InfrastructureLanguageID", "InfrastructureID", "Language", "Comment", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "LanguageText", "TranslationStatusText",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.InfrastructureLanguage).GetProperties().OrderBy(c => c.Name))
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
        public void InfrastructureLanguage_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(InfrastructureLanguage).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void InfrastructureLanguage_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.InfrastructureLanguageInfrastructureLanguageID);
               Assert.IsNotNull(ModelsRes.InfrastructureLanguageInfrastructureID);
               Assert.IsNotNull(ModelsRes.InfrastructureLanguageLanguage);
               Assert.IsNotNull(ModelsRes.InfrastructureLanguageComment);
               Assert.IsNotNull(ModelsRes.InfrastructureLanguageTranslationStatus);
               Assert.IsNotNull(ModelsRes.InfrastructureLanguageLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.InfrastructureLanguageLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.InfrastructureLanguageLanguageText);
               Assert.IsNotNull(ModelsRes.InfrastructureLanguageTranslationStatusText);
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
               string val8 = "Some text";
               infrastructureLanguage.LanguageText = val8;
               Assert.AreEqual(val8, infrastructureLanguage.LanguageText);
               string val9 = "Some text";
               infrastructureLanguage.TranslationStatusText = val9;
               Assert.AreEqual(val9, infrastructureLanguage.TranslationStatusText);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>().AsEnumerable();
               infrastructureLanguage.ValidationResults = val30;
               Assert.AreEqual(val30, infrastructureLanguage.ValidationResults);
        }
    }
}
