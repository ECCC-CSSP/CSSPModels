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
    public partial class SpillWebTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private SpillWeb spillWeb { get; set; }
        #endregion Properties

        #region Constructors
        public SpillWebTest()
        {
            spillWeb = new SpillWeb();
        }
        #endregion Constructors

        #region Tests
        [TestMethod]
        public void SpillWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MunicipalityTVText", "InfrastructureTVText", "LastUpdateContactTVText",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(SpillWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void SpillWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(SpillWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void SpillWeb_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.SpillWebMunicipalityTVText);
               Assert.IsNotNull(CSSPModelsRes.SpillWebInfrastructureTVText);
               Assert.IsNotNull(CSSPModelsRes.SpillWebLastUpdateContactTVText);
        }
        [TestMethod]
        public void SpillWeb_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               spillWeb.MunicipalityTVText = val1;
               Assert.AreEqual(val1, spillWeb.MunicipalityTVText);
               string val2 = "Some text";
               spillWeb.InfrastructureTVText = val2;
               Assert.AreEqual(val2, spillWeb.InfrastructureTVText);
               string val3 = "Some text";
               spillWeb.LastUpdateContactTVText = val3;
               Assert.AreEqual(val3, spillWeb.LastUpdateContactTVText);
        }
        #endregion Tests
    }
}