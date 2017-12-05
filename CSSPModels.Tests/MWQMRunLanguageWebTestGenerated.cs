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
    public partial class MWQMRunLanguageWebTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private MWQMRunLanguageWeb mWQMRunLanguageWeb { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMRunLanguageWebTest()
        {
            mWQMRunLanguageWeb = new MWQMRunLanguageWeb();
        }
        #endregion Constructors

        #region Tests
        [TestMethod]
        public void MWQMRunLanguageWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactTVText", "LanguageText", "TranslationStatusRunCommentText", "TranslationStatusRunWeatherCommentText",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMRunLanguageWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void MWQMRunLanguageWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMRunLanguageWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMRunLanguageWeb_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.MWQMRunLanguageWebLastUpdateContactTVText);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunLanguageWebLanguageText);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunLanguageWebTranslationStatusRunCommentText);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunLanguageWebTranslationStatusRunWeatherCommentText);
        }
        [TestMethod]
        public void MWQMRunLanguageWeb_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mWQMRunLanguageWeb.LastUpdateContactTVText = val1;
               Assert.AreEqual(val1, mWQMRunLanguageWeb.LastUpdateContactTVText);
               string val2 = "Some text";
               mWQMRunLanguageWeb.LanguageText = val2;
               Assert.AreEqual(val2, mWQMRunLanguageWeb.LanguageText);
               string val3 = "Some text";
               mWQMRunLanguageWeb.TranslationStatusRunCommentText = val3;
               Assert.AreEqual(val3, mWQMRunLanguageWeb.TranslationStatusRunCommentText);
               string val4 = "Some text";
               mWQMRunLanguageWeb.TranslationStatusRunWeatherCommentText = val4;
               Assert.AreEqual(val4, mWQMRunLanguageWeb.TranslationStatusRunWeatherCommentText);
        }
        #endregion Tests
    }
}
