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
    public partial class TVItemLinkWebTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private TVItemLinkWeb tVItemLinkWeb { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemLinkWebTest()
        {
            tVItemLinkWeb = new TVItemLinkWeb();
        }
        #endregion Constructors

        #region Tests
        [TestMethod]
        public void TVItemLinkWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "FromTVText", "ToTVText", "LastUpdateContactTVText", "FromTVTypeText", "ToTVTypeText",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemLinkWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void TVItemLinkWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVItemLinkWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVItemLinkWeb_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.TVItemLinkWebFromTVText);
               Assert.IsNotNull(CSSPModelsRes.TVItemLinkWebToTVText);
               Assert.IsNotNull(CSSPModelsRes.TVItemLinkWebLastUpdateContactTVText);
               Assert.IsNotNull(CSSPModelsRes.TVItemLinkWebFromTVTypeText);
               Assert.IsNotNull(CSSPModelsRes.TVItemLinkWebToTVTypeText);
        }
        [TestMethod]
        public void TVItemLinkWeb_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               tVItemLinkWeb.FromTVText = val1;
               Assert.AreEqual(val1, tVItemLinkWeb.FromTVText);
               string val2 = "Some text";
               tVItemLinkWeb.ToTVText = val2;
               Assert.AreEqual(val2, tVItemLinkWeb.ToTVText);
               string val3 = "Some text";
               tVItemLinkWeb.LastUpdateContactTVText = val3;
               Assert.AreEqual(val3, tVItemLinkWeb.LastUpdateContactTVText);
               string val4 = "Some text";
               tVItemLinkWeb.FromTVTypeText = val4;
               Assert.AreEqual(val4, tVItemLinkWeb.FromTVTypeText);
               string val5 = "Some text";
               tVItemLinkWeb.ToTVTypeText = val5;
               Assert.AreEqual(val5, tVItemLinkWeb.ToTVTypeText);
        }
        #endregion Tests
    }
}
