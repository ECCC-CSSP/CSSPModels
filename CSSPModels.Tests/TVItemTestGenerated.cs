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
    public partial class TVItemTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private TVItem tVItem { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemTest()
        {
            tVItem = new TVItem();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void TVItem_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVItemID", "TVLevel", "TVPath", "TVType", "ParentID", "IsActive", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "TVItemWeb", "TVItemReport", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.TVItem).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TVItem).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItem_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItem).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItem).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItem_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVItem).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVItem_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.TVItemTVItemID);
               Assert.IsNotNull(CSSPModelsRes.TVItemTVLevel);
               Assert.IsNotNull(CSSPModelsRes.TVItemTVPath);
               Assert.IsNotNull(CSSPModelsRes.TVItemTVType);
               Assert.IsNotNull(CSSPModelsRes.TVItemParentID);
               Assert.IsNotNull(CSSPModelsRes.TVItemIsActive);
               Assert.IsNotNull(CSSPModelsRes.TVItemLastUpdateDate_UTC);
               Assert.IsNotNull(CSSPModelsRes.TVItemLastUpdateContactTVItemID);
               Assert.IsNotNull(CSSPModelsRes.TVItemHasErrors);
        }
        [TestMethod]
        public void TVItem_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               tVItem.TVItemID = val1;
               Assert.AreEqual(val1, tVItem.TVItemID);
               int val2 = 45;
               tVItem.TVLevel = val2;
               Assert.AreEqual(val2, tVItem.TVLevel);
               string val3 = "Some text";
               tVItem.TVPath = val3;
               Assert.AreEqual(val3, tVItem.TVPath);
               TVTypeEnum val4 = (TVTypeEnum)3;
               tVItem.TVType = val4;
               Assert.AreEqual(val4, tVItem.TVType);
               int val5 = 45;
               tVItem.ParentID = val5;
               Assert.AreEqual(val5, tVItem.ParentID);
               bool val6 = true;
               tVItem.IsActive = val6;
               Assert.AreEqual(val6, tVItem.IsActive);
               DateTime val7 = new DateTime(2010, 3, 4);
               tVItem.LastUpdateDate_UTC = val7;
               Assert.AreEqual(val7, tVItem.LastUpdateDate_UTC);
               int val8 = 45;
               tVItem.LastUpdateContactTVItemID = val8;
               Assert.AreEqual(val8, tVItem.LastUpdateContactTVItemID);
               bool val9 = true;
               tVItem.HasErrors = val9;
               Assert.AreEqual(val9, tVItem.HasErrors);
               IEnumerable<ValidationResult> val34 = new List<ValidationResult>().AsEnumerable();
               tVItem.ValidationResults = val34;
               Assert.AreEqual(val34, tVItem.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
