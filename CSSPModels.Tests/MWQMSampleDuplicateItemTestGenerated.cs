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
    public partial class MWQMSampleDuplicateItemTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private MWQMSampleDuplicateItem mWQMSampleDuplicateItem { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSampleDuplicateItemTest()
        {
            mWQMSampleDuplicateItem = new MWQMSampleDuplicateItem();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void MWQMSampleDuplicateItem_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ParentSite", "DuplicateSite", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSampleDuplicateItem).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void MWQMSampleDuplicateItem_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSampleDuplicateItem).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSampleDuplicateItem_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.MWQMSampleDuplicateItemParentSite);
               Assert.IsNotNull(CSSPModelsRes.MWQMSampleDuplicateItemDuplicateSite);
               Assert.IsNotNull(CSSPModelsRes.MWQMSampleDuplicateItemHasErrors);
        }
        [TestMethod]
        public void MWQMSampleDuplicateItem_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mWQMSampleDuplicateItem.ParentSite = val1;
               Assert.AreEqual(val1, mWQMSampleDuplicateItem.ParentSite);
               string val2 = "Some text";
               mWQMSampleDuplicateItem.DuplicateSite = val2;
               Assert.AreEqual(val2, mWQMSampleDuplicateItem.DuplicateSite);
               bool val3 = true;
               mWQMSampleDuplicateItem.HasErrors = val3;
               Assert.AreEqual(val3, mWQMSampleDuplicateItem.HasErrors);
               IEnumerable<ValidationResult> val12 = new List<ValidationResult>().AsEnumerable();
               mWQMSampleDuplicateItem.ValidationResults = val12;
               Assert.AreEqual(val12, mWQMSampleDuplicateItem.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
