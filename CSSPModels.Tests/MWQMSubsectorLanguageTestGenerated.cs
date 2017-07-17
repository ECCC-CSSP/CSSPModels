using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Globalization;
using System.Transactions;
using System.Collections.Generic;
using CSSPModels.Resources;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;

namespace CSSPModels.Tests
{
    public partial class MWQMSubsectorLanguageTest
    {
        [TestMethod]
        public void MWQMSubsectorLanguage_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "MWQMSubsectorLanguageID", "MWQMSubsectorID", "Language", "SubsectorDesc", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

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
        public void MWQMSubsectorLanguage_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "MWQMSubsector",  }.OrderBy(c => c).ToList();
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
        public void MWQMSubsectorLanguage_Has_ValidationResults_OK()
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
               Assert.IsNotNull(ModelsRes.MWQMSubsectorLanguageMWQMSubsector);
        }
    }
}
