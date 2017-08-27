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
    public partial class EmailDistributionListContactLanguageTest : SetupData
    {
        [TestMethod]
        public void EmailDistributionListContactLanguage_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "EmailDistributionListContactLanguageID", "EmailDistributionListContactID", "Language", "Agency", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "LastUpdateContactTVText", "LanguageText", "TranslationStatusText", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.EmailDistributionListContactLanguage).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void EmailDistributionListContactLanguage_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguage).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void EmailDistributionListContactLanguage_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(EmailDistributionListContactLanguage).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void EmailDistributionListContactLanguage_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactLanguageEmailDistributionListContactLanguageID);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactLanguageEmailDistributionListContactID);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactLanguageLanguage);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactLanguageAgency);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactLanguageTranslationStatus);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactLanguageLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactLanguageLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactLanguageLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactLanguageLanguageText);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactLanguageTranslationStatusText);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactLanguageHasErrors);
        }
        [TestMethod]
        public void EmailDistributionListContactLanguage_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               emailDistributionListContactLanguage.EmailDistributionListContactLanguageID = val1;
               Assert.AreEqual(val1, emailDistributionListContactLanguage.EmailDistributionListContactLanguageID);
               int val2 = 45;
               emailDistributionListContactLanguage.EmailDistributionListContactID = val2;
               Assert.AreEqual(val2, emailDistributionListContactLanguage.EmailDistributionListContactID);
               LanguageEnum val3 = (LanguageEnum)3;
               emailDistributionListContactLanguage.Language = val3;
               Assert.AreEqual(val3, emailDistributionListContactLanguage.Language);
               string val4 = "Some text";
               emailDistributionListContactLanguage.Agency = val4;
               Assert.AreEqual(val4, emailDistributionListContactLanguage.Agency);
               TranslationStatusEnum val5 = (TranslationStatusEnum)3;
               emailDistributionListContactLanguage.TranslationStatus = val5;
               Assert.AreEqual(val5, emailDistributionListContactLanguage.TranslationStatus);
               DateTime val6 = new DateTime(2010, 3, 4);
               emailDistributionListContactLanguage.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, emailDistributionListContactLanguage.LastUpdateDate_UTC);
               int val7 = 45;
               emailDistributionListContactLanguage.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, emailDistributionListContactLanguage.LastUpdateContactTVItemID);
               string val8 = "Some text";
               emailDistributionListContactLanguage.LastUpdateContactTVText = val8;
               Assert.AreEqual(val8, emailDistributionListContactLanguage.LastUpdateContactTVText);
               string val9 = "Some text";
               emailDistributionListContactLanguage.LanguageText = val9;
               Assert.AreEqual(val9, emailDistributionListContactLanguage.LanguageText);
               string val10 = "Some text";
               emailDistributionListContactLanguage.TranslationStatusText = val10;
               Assert.AreEqual(val10, emailDistributionListContactLanguage.TranslationStatusText);
               bool val11 = true;
               emailDistributionListContactLanguage.HasErrors = val11;
               Assert.AreEqual(val11, emailDistributionListContactLanguage.HasErrors);
               IEnumerable<ValidationResult> val36 = new List<ValidationResult>().AsEnumerable();
               emailDistributionListContactLanguage.ValidationResults = val36;
               Assert.AreEqual(val36, emailDistributionListContactLanguage.ValidationResults);
        }
    }
}
