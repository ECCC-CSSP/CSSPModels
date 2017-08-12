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
    public partial class MWQMRunLanguageTest : SetupData
    {
        [TestMethod]
        public void MWQMRunLanguage_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMRunLanguageID", "MWQMRunID", "Language", "RunComment", "TranslationStatusRunComment", "RunWeatherComment", "TranslationStatusRunWeatherComment", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "LastUpdateContactTVText", "LanguageText", "TranslationStatusRunCommentText", "TranslationStatusRunWeatherCommentText", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.MWQMRunLanguage).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMRunLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMRunLanguage_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMRunLanguage).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMRunLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMRunLanguage_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMRunLanguage).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMRunLanguage_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.MWQMRunLanguageMWQMRunLanguageID);
               Assert.IsNotNull(ModelsRes.MWQMRunLanguageMWQMRunID);
               Assert.IsNotNull(ModelsRes.MWQMRunLanguageLanguage);
               Assert.IsNotNull(ModelsRes.MWQMRunLanguageRunComment);
               Assert.IsNotNull(ModelsRes.MWQMRunLanguageTranslationStatusRunComment);
               Assert.IsNotNull(ModelsRes.MWQMRunLanguageRunWeatherComment);
               Assert.IsNotNull(ModelsRes.MWQMRunLanguageTranslationStatusRunWeatherComment);
               Assert.IsNotNull(ModelsRes.MWQMRunLanguageLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.MWQMRunLanguageLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.MWQMRunLanguageLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.MWQMRunLanguageLanguageText);
               Assert.IsNotNull(ModelsRes.MWQMRunLanguageTranslationStatusRunCommentText);
               Assert.IsNotNull(ModelsRes.MWQMRunLanguageTranslationStatusRunWeatherCommentText);
               Assert.IsNotNull(ModelsRes.MWQMRunLanguageHasErrors);
        }
        [TestMethod]
        public void MWQMRunLanguage_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mWQMRunLanguage.MWQMRunLanguageID = val1;
               Assert.AreEqual(val1, mWQMRunLanguage.MWQMRunLanguageID);
               int val2 = 45;
               mWQMRunLanguage.MWQMRunID = val2;
               Assert.AreEqual(val2, mWQMRunLanguage.MWQMRunID);
               LanguageEnum val3 = (LanguageEnum)3;
               mWQMRunLanguage.Language = val3;
               Assert.AreEqual(val3, mWQMRunLanguage.Language);
               string val4 = "Some text";
               mWQMRunLanguage.RunComment = val4;
               Assert.AreEqual(val4, mWQMRunLanguage.RunComment);
               TranslationStatusEnum val5 = (TranslationStatusEnum)3;
               mWQMRunLanguage.TranslationStatusRunComment = val5;
               Assert.AreEqual(val5, mWQMRunLanguage.TranslationStatusRunComment);
               string val6 = "Some text";
               mWQMRunLanguage.RunWeatherComment = val6;
               Assert.AreEqual(val6, mWQMRunLanguage.RunWeatherComment);
               TranslationStatusEnum val7 = (TranslationStatusEnum)3;
               mWQMRunLanguage.TranslationStatusRunWeatherComment = val7;
               Assert.AreEqual(val7, mWQMRunLanguage.TranslationStatusRunWeatherComment);
               DateTime val8 = new DateTime(2010, 3, 4);
               mWQMRunLanguage.LastUpdateDate_UTC = val8;
               Assert.AreEqual(val8, mWQMRunLanguage.LastUpdateDate_UTC);
               int val9 = 45;
               mWQMRunLanguage.LastUpdateContactTVItemID = val9;
               Assert.AreEqual(val9, mWQMRunLanguage.LastUpdateContactTVItemID);
               string val10 = "Some text";
               mWQMRunLanguage.LastUpdateContactTVText = val10;
               Assert.AreEqual(val10, mWQMRunLanguage.LastUpdateContactTVText);
               string val11 = "Some text";
               mWQMRunLanguage.LanguageText = val11;
               Assert.AreEqual(val11, mWQMRunLanguage.LanguageText);
               string val12 = "Some text";
               mWQMRunLanguage.TranslationStatusRunCommentText = val12;
               Assert.AreEqual(val12, mWQMRunLanguage.TranslationStatusRunCommentText);
               string val13 = "Some text";
               mWQMRunLanguage.TranslationStatusRunWeatherCommentText = val13;
               Assert.AreEqual(val13, mWQMRunLanguage.TranslationStatusRunWeatherCommentText);
               bool val14 = true;
               mWQMRunLanguage.HasErrors = val14;
               Assert.AreEqual(val14, mWQMRunLanguage.HasErrors);
               IEnumerable<ValidationResult> val45 = new List<ValidationResult>().AsEnumerable();
               mWQMRunLanguage.ValidationResults = val45;
               Assert.AreEqual(val45, mWQMRunLanguage.ValidationResults);
        }
    }
}
