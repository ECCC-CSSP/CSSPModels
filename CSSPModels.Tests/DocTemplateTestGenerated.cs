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
    public partial class DocTemplateTest : SetupData
    {
        [TestMethod]
        public void DocTemplate_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "DocTemplateID", "Language", "TVType", "TVFileTVItemID", "FileName", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.DocTemplate).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(DocTemplate).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void DocTemplate_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() { "TVFileTVItem",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(DocTemplate).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(DocTemplate).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void DocTemplate_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(DocTemplate).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void DocTemplate_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.DocTemplateDocTemplateID);
               Assert.IsNotNull(ModelsRes.DocTemplateLanguage);
               Assert.IsNotNull(ModelsRes.DocTemplateTVType);
               Assert.IsNotNull(ModelsRes.DocTemplateTVFileTVItemID);
               Assert.IsNotNull(ModelsRes.DocTemplateFileName);
               Assert.IsNotNull(ModelsRes.DocTemplateLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.DocTemplateLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.DocTemplateTVFileTVItem);
        }
        [TestMethod]
        public void DocTemplate_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               docTemplate.DocTemplateID = val1;
               Assert.AreEqual(val1, docTemplate.DocTemplateID);
               LanguageEnum val2 = (LanguageEnum)3;
               docTemplate.Language = val2;
               Assert.AreEqual(val2, docTemplate.Language);
               TVTypeEnum val3 = (TVTypeEnum)3;
               docTemplate.TVType = val3;
               Assert.AreEqual(val3, docTemplate.TVType);
               int val4 = 45;
               docTemplate.TVFileTVItemID = val4;
               Assert.AreEqual(val4, docTemplate.TVFileTVItemID);
               string val5 = "Some text";
               docTemplate.FileName = val5;
               Assert.AreEqual(val5, docTemplate.FileName);
               DateTime val6 = new DateTime(2010, 3, 4);
               docTemplate.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, docTemplate.LastUpdateDate_UTC);
               int val7 = 45;
               docTemplate.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, docTemplate.LastUpdateContactTVItemID);
               TVItem val17 = new TVItem();
               docTemplate.TVFileTVItem = val17;
               Assert.AreEqual(val17, docTemplate.TVFileTVItem);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>().AsEnumerable();
               docTemplate.ValidationResults = val27;
               Assert.AreEqual(val27, docTemplate.ValidationResults);
        }
    }
}
