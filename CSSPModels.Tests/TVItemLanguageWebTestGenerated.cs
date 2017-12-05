/*
 * Auto generated from the CSSPModelsGenerateCode.proj
 *
 * Do not edit this file.
 *
 * Last generated by Charles LeBlanc
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
    public partial class TVItemLanguageWebTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private TVItemLanguageWeb tVItemLanguageWeb { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemLanguageWebTest()
        {
            tVItemLanguageWeb = new TVItemLanguageWeb();
        }
        #endregion Constructors

        #region Tests
        [TestMethod]
        public void TVItemLanguageWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactTVText", "LanguageText", "TranslationStatusText",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemLanguageWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void TVItemLanguageWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVItemLanguageWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVItemLanguageWeb_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.TVItemLanguageWebLastUpdateContactTVText);
               Assert.IsNotNull(CSSPModelsRes.TVItemLanguageWebLanguageText);
               Assert.IsNotNull(CSSPModelsRes.TVItemLanguageWebTranslationStatusText);
        }
        [TestMethod]
        public void TVItemLanguageWeb_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               tVItemLanguageWeb.LastUpdateContactTVText = val1;
               Assert.AreEqual(val1, tVItemLanguageWeb.LastUpdateContactTVText);
               string val2 = "Some text";
               tVItemLanguageWeb.LanguageText = val2;
               Assert.AreEqual(val2, tVItemLanguageWeb.LanguageText);
               string val3 = "Some text";
               tVItemLanguageWeb.TranslationStatusText = val3;
               Assert.AreEqual(val3, tVItemLanguageWeb.TranslationStatusText);
        }
        #endregion Tests
    }
}