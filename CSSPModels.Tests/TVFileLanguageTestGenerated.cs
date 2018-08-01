/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 August 01 05:00
 * by leblancc on WMON01DTCHLEBL2 machine
 *
 */ 
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
    [TestClass]
    public partial class TVFileLanguageTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private TVFileLanguage tVFileLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public TVFileLanguageTest()
        {
            tVFileLanguage = new TVFileLanguage();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void TVFileLanguage_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVFileLanguageID", "TVFileID", "Language", "FileDescription", "TranslationStatus", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "TVFileLanguageWeb", "TVFileLanguageReport", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.TVFileLanguage).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TVFileLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVFileLanguage_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVFileLanguage).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVFileLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVFileLanguage_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVFileLanguage).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVFileLanguage_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.TVFileLanguageTVFileLanguageID);
               Assert.IsNotNull(CSSPModelsRes.TVFileLanguageTVFileID);
               Assert.IsNotNull(CSSPModelsRes.TVFileLanguageLanguage);
               Assert.IsNotNull(CSSPModelsRes.TVFileLanguageFileDescription);
               Assert.IsNotNull(CSSPModelsRes.TVFileLanguageTranslationStatus);
               Assert.IsNotNull(CSSPModelsRes.TVFileLanguageLastUpdateDate_UTC);
               Assert.IsNotNull(CSSPModelsRes.TVFileLanguageLastUpdateContactTVItemID);
               Assert.IsNotNull(CSSPModelsRes.TVFileLanguageHasErrors);
        }
        [TestMethod]
        public void TVFileLanguage_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               tVFileLanguage.TVFileLanguageID = val1;
               Assert.AreEqual(val1, tVFileLanguage.TVFileLanguageID);
               int val2 = 45;
               tVFileLanguage.TVFileID = val2;
               Assert.AreEqual(val2, tVFileLanguage.TVFileID);
               LanguageEnum val3 = (LanguageEnum)3;
               tVFileLanguage.Language = val3;
               Assert.AreEqual(val3, tVFileLanguage.Language);
               string val4 = "Some text";
               tVFileLanguage.FileDescription = val4;
               Assert.AreEqual(val4, tVFileLanguage.FileDescription);
               TranslationStatusEnum val5 = (TranslationStatusEnum)3;
               tVFileLanguage.TranslationStatus = val5;
               Assert.AreEqual(val5, tVFileLanguage.TranslationStatus);
               DateTime val6 = new DateTime(2010, 3, 4);
               tVFileLanguage.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, tVFileLanguage.LastUpdateDate_UTC);
               int val7 = 45;
               tVFileLanguage.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, tVFileLanguage.LastUpdateContactTVItemID);
               bool val8 = true;
               tVFileLanguage.HasErrors = val8;
               Assert.AreEqual(val8, tVFileLanguage.HasErrors);
               IEnumerable<ValidationResult> val31 = new List<ValidationResult>().AsEnumerable();
               tVFileLanguage.ValidationResults = val31;
               Assert.AreEqual(val31, tVFileLanguage.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
