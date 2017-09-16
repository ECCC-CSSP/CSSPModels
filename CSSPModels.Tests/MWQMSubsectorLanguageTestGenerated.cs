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
    public partial class MWQMSubsectorLanguageTest : SetupData
    {
        [TestMethod]
        public void MWQMSubsectorLanguage_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMSubsectorLanguageID", "MWQMSubsectorID", "Language", "SubsectorDesc", "TranslationStatusSubsectorDesc", "LogBook", "TranslationStatusLogBook", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "LastUpdateContactTVText", "LanguageText", "TranslationStatusSubsectorDescText", "TranslationStatusLogBookText", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.MWQMSubsectorLanguage).GetProperties().OrderBy(c => c.Name))
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
        public void MWQMSubsectorLanguage_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSubsectorLanguage).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSubsectorLanguage_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.MWQMSubsectorLanguageMWQMSubsectorLanguageID);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorLanguageMWQMSubsectorID);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorLanguageLanguage);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorLanguageSubsectorDesc);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorLanguageTranslationStatusSubsectorDesc);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorLanguageLogBook);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorLanguageTranslationStatusLogBook);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorLanguageLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorLanguageLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorLanguageLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorLanguageLanguageText);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorLanguageTranslationStatusSubsectorDescText);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorLanguageTranslationStatusLogBookText);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorLanguageHasErrors);
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
               string val10 = "Some text";
               mWQMSubsectorLanguage.LastUpdateContactTVText = val10;
               Assert.AreEqual(val10, mWQMSubsectorLanguage.LastUpdateContactTVText);
               string val11 = "Some text";
               mWQMSubsectorLanguage.LanguageText = val11;
               Assert.AreEqual(val11, mWQMSubsectorLanguage.LanguageText);
               string val12 = "Some text";
               mWQMSubsectorLanguage.TranslationStatusSubsectorDescText = val12;
               Assert.AreEqual(val12, mWQMSubsectorLanguage.TranslationStatusSubsectorDescText);
               string val13 = "Some text";
               mWQMSubsectorLanguage.TranslationStatusLogBookText = val13;
               Assert.AreEqual(val13, mWQMSubsectorLanguage.TranslationStatusLogBookText);
               bool val14 = true;
               mWQMSubsectorLanguage.HasErrors = val14;
               Assert.AreEqual(val14, mWQMSubsectorLanguage.HasErrors);
               IEnumerable<ValidationResult> val45 = new List<ValidationResult>().AsEnumerable();
               mWQMSubsectorLanguage.ValidationResults = val45;
               Assert.AreEqual(val45, mWQMSubsectorLanguage.ValidationResults);
        }
    }
}
