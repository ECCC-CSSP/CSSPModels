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
    public partial class VPScenarioLanguageTest : SetupData
    {
        [TestMethod]
        public void VPScenarioLanguage_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "VPScenarioLanguageID", "VPScenarioID", "Language", "VPScenarioName", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.VPScenarioLanguage).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(VPScenarioLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void VPScenarioLanguage_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() { "VPScenario",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPScenarioLanguage).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(VPScenarioLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void VPScenarioLanguage_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(VPScenarioLanguage).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void VPScenarioLanguage_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.VPScenarioLanguageVPScenarioLanguageID);
               Assert.IsNotNull(ModelsRes.VPScenarioLanguageVPScenarioID);
               Assert.IsNotNull(ModelsRes.VPScenarioLanguageLanguage);
               Assert.IsNotNull(ModelsRes.VPScenarioLanguageVPScenarioName);
               Assert.IsNotNull(ModelsRes.VPScenarioLanguageTranslationStatus);
               Assert.IsNotNull(ModelsRes.VPScenarioLanguageLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.VPScenarioLanguageLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.VPScenarioLanguageVPScenario);
        }
        [TestMethod]
        public void VPScenarioLanguage_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               vPScenarioLanguage.VPScenarioLanguageID = val1;
               Assert.AreEqual(val1, vPScenarioLanguage.VPScenarioLanguageID);
               int val2 = 45;
               vPScenarioLanguage.VPScenarioID = val2;
               Assert.AreEqual(val2, vPScenarioLanguage.VPScenarioID);
               LanguageEnum val3 = (LanguageEnum)3;
               vPScenarioLanguage.Language = val3;
               Assert.AreEqual(val3, vPScenarioLanguage.Language);
               string val4 = "Some text";
               vPScenarioLanguage.VPScenarioName = val4;
               Assert.AreEqual(val4, vPScenarioLanguage.VPScenarioName);
               TranslationStatusEnum val5 = (TranslationStatusEnum)3;
               vPScenarioLanguage.TranslationStatus = val5;
               Assert.AreEqual(val5, vPScenarioLanguage.TranslationStatus);
               DateTime val6 = new DateTime(2010, 3, 4);
               vPScenarioLanguage.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, vPScenarioLanguage.LastUpdateDate_UTC);
               int val7 = 45;
               vPScenarioLanguage.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, vPScenarioLanguage.LastUpdateContactTVItemID);
               VPScenario val17 = new VPScenario();
               vPScenarioLanguage.VPScenario = val17;
               Assert.AreEqual(val17, vPScenarioLanguage.VPScenario);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>().AsEnumerable();
               vPScenarioLanguage.ValidationResults = val27;
               Assert.AreEqual(val27, vPScenarioLanguage.ValidationResults);
        }
    }
}
