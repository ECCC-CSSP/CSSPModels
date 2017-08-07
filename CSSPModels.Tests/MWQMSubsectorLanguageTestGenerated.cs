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
            List<string> propNameList = new List<string>() { "MWQMSubsectorLanguageID", "MWQMSubsectorID", "Language", "SubsectorDesc", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "LanguageText", "TranslationStatusText",  }.OrderBy(c => c).ToList();

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
               Assert.IsNotNull(ModelsRes.MWQMSubsectorLanguageTranslationStatus);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorLanguageLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorLanguageLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorLanguageLanguageText);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorLanguageTranslationStatusText);
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
               mWQMSubsectorLanguage.TranslationStatus = val5;
               Assert.AreEqual(val5, mWQMSubsectorLanguage.TranslationStatus);
               DateTime val6 = new DateTime(2010, 3, 4);
               mWQMSubsectorLanguage.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, mWQMSubsectorLanguage.LastUpdateDate_UTC);
               int val7 = 45;
               mWQMSubsectorLanguage.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, mWQMSubsectorLanguage.LastUpdateContactTVItemID);
               string val8 = "Some text";
               mWQMSubsectorLanguage.LanguageText = val8;
               Assert.AreEqual(val8, mWQMSubsectorLanguage.LanguageText);
               string val9 = "Some text";
               mWQMSubsectorLanguage.TranslationStatusText = val9;
               Assert.AreEqual(val9, mWQMSubsectorLanguage.TranslationStatusText);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>().AsEnumerable();
               mWQMSubsectorLanguage.ValidationResults = val30;
               Assert.AreEqual(val30, mWQMSubsectorLanguage.ValidationResults);
        }
    }
}
