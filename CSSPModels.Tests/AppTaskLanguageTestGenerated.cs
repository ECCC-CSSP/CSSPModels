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
    public partial class AppTaskLanguageTest : SetupData
    {
        [TestMethod]
        public void AppTaskLanguage_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "AppTaskLanguageID", "AppTaskID", "Language", "StatusText", "ErrorText", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.AppTaskLanguage).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(AppTaskLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void AppTaskLanguage_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() { "AppTask",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AppTaskLanguage).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AppTaskLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void AppTaskLanguage_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(AppTaskLanguage).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void AppTaskLanguage_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.AppTaskLanguageAppTaskLanguageID);
               Assert.IsNotNull(ModelsRes.AppTaskLanguageAppTaskID);
               Assert.IsNotNull(ModelsRes.AppTaskLanguageLanguage);
               Assert.IsNotNull(ModelsRes.AppTaskLanguageStatusText);
               Assert.IsNotNull(ModelsRes.AppTaskLanguageErrorText);
               Assert.IsNotNull(ModelsRes.AppTaskLanguageTranslationStatus);
               Assert.IsNotNull(ModelsRes.AppTaskLanguageLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.AppTaskLanguageLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.AppTaskLanguageAppTask);
        }
        [TestMethod]
        public void AppTaskLanguage_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               appTaskLanguage.AppTaskLanguageID = val1;
               Assert.AreEqual(val1, appTaskLanguage.AppTaskLanguageID);
               int val2 = 45;
               appTaskLanguage.AppTaskID = val2;
               Assert.AreEqual(val2, appTaskLanguage.AppTaskID);
               LanguageEnum val3 = (LanguageEnum)3;
               appTaskLanguage.Language = val3;
               Assert.AreEqual(val3, appTaskLanguage.Language);
               string val4 = "Some text";
               appTaskLanguage.StatusText = val4;
               Assert.AreEqual(val4, appTaskLanguage.StatusText);
               string val5 = "Some text";
               appTaskLanguage.ErrorText = val5;
               Assert.AreEqual(val5, appTaskLanguage.ErrorText);
               TranslationStatusEnum val6 = (TranslationStatusEnum)3;
               appTaskLanguage.TranslationStatus = val6;
               Assert.AreEqual(val6, appTaskLanguage.TranslationStatus);
               DateTime val7 = new DateTime(2010, 3, 4);
               appTaskLanguage.LastUpdateDate_UTC = val7;
               Assert.AreEqual(val7, appTaskLanguage.LastUpdateDate_UTC);
               int val8 = 45;
               appTaskLanguage.LastUpdateContactTVItemID = val8;
               Assert.AreEqual(val8, appTaskLanguage.LastUpdateContactTVItemID);
               AppTask val19 = new AppTask();
               appTaskLanguage.AppTask = val19;
               Assert.AreEqual(val19, appTaskLanguage.AppTask);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>().AsEnumerable();
               appTaskLanguage.ValidationResults = val30;
               Assert.AreEqual(val30, appTaskLanguage.ValidationResults);
        }
    }
}
