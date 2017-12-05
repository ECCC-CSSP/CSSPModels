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
    public partial class TVTypeUserAuthorizationWebTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private TVTypeUserAuthorizationWeb tVTypeUserAuthorizationWeb { get; set; }
        #endregion Properties

        #region Constructors
        public TVTypeUserAuthorizationWebTest()
        {
            tVTypeUserAuthorizationWeb = new TVTypeUserAuthorizationWeb();
        }
        #endregion Constructors

        #region Tests
        [TestMethod]
        public void TVTypeUserAuthorizationWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ContactTVText", "LastUpdateContactTVText", "TVTypeText", "TVAuthText",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVTypeUserAuthorizationWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void TVTypeUserAuthorizationWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVTypeUserAuthorizationWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVTypeUserAuthorizationWeb_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.TVTypeUserAuthorizationWebContactTVText);
               Assert.IsNotNull(CSSPModelsRes.TVTypeUserAuthorizationWebLastUpdateContactTVText);
               Assert.IsNotNull(CSSPModelsRes.TVTypeUserAuthorizationWebTVTypeText);
               Assert.IsNotNull(CSSPModelsRes.TVTypeUserAuthorizationWebTVAuthText);
        }
        [TestMethod]
        public void TVTypeUserAuthorizationWeb_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               tVTypeUserAuthorizationWeb.ContactTVText = val1;
               Assert.AreEqual(val1, tVTypeUserAuthorizationWeb.ContactTVText);
               string val2 = "Some text";
               tVTypeUserAuthorizationWeb.LastUpdateContactTVText = val2;
               Assert.AreEqual(val2, tVTypeUserAuthorizationWeb.LastUpdateContactTVText);
               string val3 = "Some text";
               tVTypeUserAuthorizationWeb.TVTypeText = val3;
               Assert.AreEqual(val3, tVTypeUserAuthorizationWeb.TVTypeText);
               string val4 = "Some text";
               tVTypeUserAuthorizationWeb.TVAuthText = val4;
               Assert.AreEqual(val4, tVTypeUserAuthorizationWeb.TVAuthText);
        }
        #endregion Tests
    }
}