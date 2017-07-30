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
    public partial class TVTextLanguageTest : SetupData
    {
        [TestMethod]
        public void TVTextLanguage_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVText", "Language",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVTextLanguage).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void TVTextLanguage_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVTextLanguage).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVTextLanguage_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.TVTextLanguageTVText);
               Assert.IsNotNull(ModelsRes.TVTextLanguageLanguage);
        }
        [TestMethod]
        public void TVTextLanguage_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               tVTextLanguage.TVText = val1;
               Assert.AreEqual(val1, tVTextLanguage.TVText);
               LanguageEnum val2 = (LanguageEnum)3;
               tVTextLanguage.Language = val2;
               Assert.AreEqual(val2, tVTextLanguage.Language);
               IEnumerable<ValidationResult> val9 = new List<ValidationResult>().AsEnumerable();
               tVTextLanguage.ValidationResults = val9;
               Assert.AreEqual(val9, tVTextLanguage.ValidationResults);
        }
    }
}
