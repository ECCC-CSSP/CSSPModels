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
    public partial class SpillLanguageTest : SetupData
    {
        [TestMethod]
        public void SpillLanguage_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "SpillLanguageID", "SpillID", "Language", "SpillComment", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "LastUpdateContactTVText", "LanguageText", "TranslationStatusText",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.SpillLanguage).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(SpillLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void SpillLanguage_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SpillLanguage).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SpillLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void SpillLanguage_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(SpillLanguage).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void SpillLanguage_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.SpillLanguageSpillLanguageID);
               Assert.IsNotNull(ModelsRes.SpillLanguageSpillID);
               Assert.IsNotNull(ModelsRes.SpillLanguageLanguage);
               Assert.IsNotNull(ModelsRes.SpillLanguageSpillComment);
               Assert.IsNotNull(ModelsRes.SpillLanguageTranslationStatus);
               Assert.IsNotNull(ModelsRes.SpillLanguageLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.SpillLanguageLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.SpillLanguageLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.SpillLanguageLanguageText);
               Assert.IsNotNull(ModelsRes.SpillLanguageTranslationStatusText);
        }
        [TestMethod]
        public void SpillLanguage_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               spillLanguage.SpillLanguageID = val1;
               Assert.AreEqual(val1, spillLanguage.SpillLanguageID);
               int val2 = 45;
               spillLanguage.SpillID = val2;
               Assert.AreEqual(val2, spillLanguage.SpillID);
               LanguageEnum val3 = (LanguageEnum)3;
               spillLanguage.Language = val3;
               Assert.AreEqual(val3, spillLanguage.Language);
               string val4 = "Some text";
               spillLanguage.SpillComment = val4;
               Assert.AreEqual(val4, spillLanguage.SpillComment);
               TranslationStatusEnum val5 = (TranslationStatusEnum)3;
               spillLanguage.TranslationStatus = val5;
               Assert.AreEqual(val5, spillLanguage.TranslationStatus);
               DateTime val6 = new DateTime(2010, 3, 4);
               spillLanguage.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, spillLanguage.LastUpdateDate_UTC);
               int val7 = 45;
               spillLanguage.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, spillLanguage.LastUpdateContactTVItemID);
               string val8 = "Some text";
               spillLanguage.LastUpdateContactTVText = val8;
               Assert.AreEqual(val8, spillLanguage.LastUpdateContactTVText);
               string val9 = "Some text";
               spillLanguage.LanguageText = val9;
               Assert.AreEqual(val9, spillLanguage.LanguageText);
               string val10 = "Some text";
               spillLanguage.TranslationStatusText = val10;
               Assert.AreEqual(val10, spillLanguage.TranslationStatusText);
               IEnumerable<ValidationResult> val33 = new List<ValidationResult>().AsEnumerable();
               spillLanguage.ValidationResults = val33;
               Assert.AreEqual(val33, spillLanguage.ValidationResults);
        }
    }
}
