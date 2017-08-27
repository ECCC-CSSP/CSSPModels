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
    public partial class EmailDistributionListLanguageTest : SetupData
    {
        [TestMethod]
        public void EmailDistributionListLanguage_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "EmailDistributionListLanguageID", "EmailDistributionListID", "Language", "RegionName", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "LastUpdateContactTVText", "LanguageText", "TranslationStatusText", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.EmailDistributionListLanguage).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void EmailDistributionListLanguage_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListLanguage).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void EmailDistributionListLanguage_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(EmailDistributionListLanguage).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void EmailDistributionListLanguage_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.EmailDistributionListLanguageEmailDistributionListLanguageID);
               Assert.IsNotNull(ModelsRes.EmailDistributionListLanguageEmailDistributionListID);
               Assert.IsNotNull(ModelsRes.EmailDistributionListLanguageLanguage);
               Assert.IsNotNull(ModelsRes.EmailDistributionListLanguageRegionName);
               Assert.IsNotNull(ModelsRes.EmailDistributionListLanguageTranslationStatus);
               Assert.IsNotNull(ModelsRes.EmailDistributionListLanguageLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.EmailDistributionListLanguageLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.EmailDistributionListLanguageLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.EmailDistributionListLanguageLanguageText);
               Assert.IsNotNull(ModelsRes.EmailDistributionListLanguageTranslationStatusText);
               Assert.IsNotNull(ModelsRes.EmailDistributionListLanguageHasErrors);
        }
        [TestMethod]
        public void EmailDistributionListLanguage_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               emailDistributionListLanguage.EmailDistributionListLanguageID = val1;
               Assert.AreEqual(val1, emailDistributionListLanguage.EmailDistributionListLanguageID);
               int val2 = 45;
               emailDistributionListLanguage.EmailDistributionListID = val2;
               Assert.AreEqual(val2, emailDistributionListLanguage.EmailDistributionListID);
               LanguageEnum val3 = (LanguageEnum)3;
               emailDistributionListLanguage.Language = val3;
               Assert.AreEqual(val3, emailDistributionListLanguage.Language);
               string val4 = "Some text";
               emailDistributionListLanguage.RegionName = val4;
               Assert.AreEqual(val4, emailDistributionListLanguage.RegionName);
               TranslationStatusEnum val5 = (TranslationStatusEnum)3;
               emailDistributionListLanguage.TranslationStatus = val5;
               Assert.AreEqual(val5, emailDistributionListLanguage.TranslationStatus);
               DateTime val6 = new DateTime(2010, 3, 4);
               emailDistributionListLanguage.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, emailDistributionListLanguage.LastUpdateDate_UTC);
               int val7 = 45;
               emailDistributionListLanguage.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, emailDistributionListLanguage.LastUpdateContactTVItemID);
               string val8 = "Some text";
               emailDistributionListLanguage.LastUpdateContactTVText = val8;
               Assert.AreEqual(val8, emailDistributionListLanguage.LastUpdateContactTVText);
               string val9 = "Some text";
               emailDistributionListLanguage.LanguageText = val9;
               Assert.AreEqual(val9, emailDistributionListLanguage.LanguageText);
               string val10 = "Some text";
               emailDistributionListLanguage.TranslationStatusText = val10;
               Assert.AreEqual(val10, emailDistributionListLanguage.TranslationStatusText);
               bool val11 = true;
               emailDistributionListLanguage.HasErrors = val11;
               Assert.AreEqual(val11, emailDistributionListLanguage.HasErrors);
               IEnumerable<ValidationResult> val36 = new List<ValidationResult>().AsEnumerable();
               emailDistributionListLanguage.ValidationResults = val36;
               Assert.AreEqual(val36, emailDistributionListLanguage.ValidationResults);
        }
    }
}
