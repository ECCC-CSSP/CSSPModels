/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by leblancc on WMON01DTCHLEBL2 machine
 *
 */ 
using System;
using System.Text;
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
    public partial class TVItemInfrastructureTypeTVItemLinkTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private TVItemInfrastructureTypeTVItemLink tVItemInfrastructureTypeTVItemLink { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemInfrastructureTypeTVItemLinkTest()
        {
            tVItemInfrastructureTypeTVItemLink = new TVItemInfrastructureTypeTVItemLink();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void TVItemInfrastructureTypeTVItemLink_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "InfrastructureType", "SeeOtherTVItemID", "InfrastructureTypeText", "TVItem", "TVItemLinkList", "FlowTo", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemInfrastructureTypeTVItemLink).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void TVItemInfrastructureTypeTVItemLink_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVItemInfrastructureTypeTVItemLink).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVItemInfrastructureTypeTVItemLink_Every_Property_Has_Get_Set_Test()
        {
               InfrastructureTypeEnum val1 = (InfrastructureTypeEnum)3;
               tVItemInfrastructureTypeTVItemLink.InfrastructureType = val1;
               Assert.AreEqual(val1, tVItemInfrastructureTypeTVItemLink.InfrastructureType);
               int val2 = 45;
               tVItemInfrastructureTypeTVItemLink.SeeOtherTVItemID = val2;
               Assert.AreEqual(val2, tVItemInfrastructureTypeTVItemLink.SeeOtherTVItemID);
               string val3 = "Some text";
               tVItemInfrastructureTypeTVItemLink.InfrastructureTypeText = val3;
               Assert.AreEqual(val3, tVItemInfrastructureTypeTVItemLink.InfrastructureTypeText);
               TVItem val4 = new TVItem();
               tVItemInfrastructureTypeTVItemLink.TVItem = val4;
               Assert.AreEqual(val4, tVItemInfrastructureTypeTVItemLink.TVItem);
               List<TVItemLink> val5 = new List<TVItemLink>() { new TVItemLink(), new TVItemLink() };
               tVItemInfrastructureTypeTVItemLink.TVItemLinkList = val5;
               Assert.AreEqual(val5, tVItemInfrastructureTypeTVItemLink.TVItemLinkList);
               TVItemInfrastructureTypeTVItemLink val6 = new TVItemInfrastructureTypeTVItemLink();
               tVItemInfrastructureTypeTVItemLink.FlowTo = val6;
               Assert.AreEqual(val6, tVItemInfrastructureTypeTVItemLink.FlowTo);
               bool val7 = true;
               tVItemInfrastructureTypeTVItemLink.HasErrors = val7;
               Assert.AreEqual(val7, tVItemInfrastructureTypeTVItemLink.HasErrors);
               IEnumerable<ValidationResult> val24 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               tVItemInfrastructureTypeTVItemLink.ValidationResults = val24;
               Assert.AreEqual(val24, tVItemInfrastructureTypeTVItemLink.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
