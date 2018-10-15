/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
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
    public partial class TVItemTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private TVItem tVItem { get; set; }
        private TVItemExtraA tVItemExtraA { get; set; }
        private TVItemExtraB tVItemExtraB { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemTest()
        {
            tVItem = new TVItem();
            tVItemExtraA = new TVItemExtraA();
            tVItemExtraB = new TVItemExtraB();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void TVItem_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVItemID", "TVLevel", "TVPath", "TVType", "ParentID", "IsActive", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItem).GetProperties().OrderBy(c => c.Name))
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
        public void TVItemExtraA_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVItemLanguage", "LastUpdateContactTVItemLanguage", "TVTypeText", "TVItemID", "TVLevel", "TVPath", "TVType", "ParentID", "IsActive", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemExtraA).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TVItemExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItemExtraB_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVItemReportTest", "TVItemLanguage", "LastUpdateContactTVItemLanguage", "TVTypeText", "TVItemID", "TVLevel", "TVPath", "TVType", "ParentID", "IsActive", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemExtraB).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TVItemExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItemExtraA_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemExtraA).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItemExtraB_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemExtraB).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItemExtraA_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVItemExtraA).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVItemExtraB_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVItemExtraB).GetProperties().Where(c => c.Name == "ValidationResults").Any());
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
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               tVItem.ValidationResults = val30;
               Assert.AreEqual(val30, tVItem.ValidationResults);
        }
        [TestMethod]
        public void TVItemExtraA_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               tVItemExtraA.TVItemLanguage = val1;
               Assert.AreEqual(val1, tVItemExtraA.TVItemLanguage);
               TVItemLanguage val2 = new TVItemLanguage();
               tVItemExtraA.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, tVItemExtraA.LastUpdateContactTVItemLanguage);
               string val3 = "Some text";
               tVItemExtraA.TVTypeText = val3;
               Assert.AreEqual(val3, tVItemExtraA.TVTypeText);
               int val4 = 45;
               tVItemExtraA.TVItemID = val4;
               Assert.AreEqual(val4, tVItemExtraA.TVItemID);
               int val5 = 45;
               tVItemExtraA.TVLevel = val5;
               Assert.AreEqual(val5, tVItemExtraA.TVLevel);
               string val6 = "Some text";
               tVItemExtraA.TVPath = val6;
               Assert.AreEqual(val6, tVItemExtraA.TVPath);
               TVTypeEnum val7 = (TVTypeEnum)3;
               tVItemExtraA.TVType = val7;
               Assert.AreEqual(val7, tVItemExtraA.TVType);
               int val8 = 45;
               tVItemExtraA.ParentID = val8;
               Assert.AreEqual(val8, tVItemExtraA.ParentID);
               bool val9 = true;
               tVItemExtraA.IsActive = val9;
               Assert.AreEqual(val9, tVItemExtraA.IsActive);
               DateTime val10 = new DateTime(2010, 3, 4);
               tVItemExtraA.LastUpdateDate_UTC = val10;
               Assert.AreEqual(val10, tVItemExtraA.LastUpdateDate_UTC);
               int val11 = 45;
               tVItemExtraA.LastUpdateContactTVItemID = val11;
               Assert.AreEqual(val11, tVItemExtraA.LastUpdateContactTVItemID);
               bool val12 = true;
               tVItemExtraA.HasErrors = val12;
               Assert.AreEqual(val12, tVItemExtraA.HasErrors);
               IEnumerable<ValidationResult> val39 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               tVItemExtraA.ValidationResults = val39;
               Assert.AreEqual(val39, tVItemExtraA.ValidationResults);
        }
        [TestMethod]
        public void TVItemExtraB_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               tVItemExtraB.TVItemReportTest = val1;
               Assert.AreEqual(val1, tVItemExtraB.TVItemReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               tVItemExtraB.TVItemLanguage = val2;
               Assert.AreEqual(val2, tVItemExtraB.TVItemLanguage);
               TVItemLanguage val3 = new TVItemLanguage();
               tVItemExtraB.LastUpdateContactTVItemLanguage = val3;
               Assert.AreEqual(val3, tVItemExtraB.LastUpdateContactTVItemLanguage);
               string val4 = "Some text";
               tVItemExtraB.TVTypeText = val4;
               Assert.AreEqual(val4, tVItemExtraB.TVTypeText);
               int val5 = 45;
               tVItemExtraB.TVItemID = val5;
               Assert.AreEqual(val5, tVItemExtraB.TVItemID);
               int val6 = 45;
               tVItemExtraB.TVLevel = val6;
               Assert.AreEqual(val6, tVItemExtraB.TVLevel);
               string val7 = "Some text";
               tVItemExtraB.TVPath = val7;
               Assert.AreEqual(val7, tVItemExtraB.TVPath);
               TVTypeEnum val8 = (TVTypeEnum)3;
               tVItemExtraB.TVType = val8;
               Assert.AreEqual(val8, tVItemExtraB.TVType);
               int val9 = 45;
               tVItemExtraB.ParentID = val9;
               Assert.AreEqual(val9, tVItemExtraB.ParentID);
               bool val10 = true;
               tVItemExtraB.IsActive = val10;
               Assert.AreEqual(val10, tVItemExtraB.IsActive);
               DateTime val11 = new DateTime(2010, 3, 4);
               tVItemExtraB.LastUpdateDate_UTC = val11;
               Assert.AreEqual(val11, tVItemExtraB.LastUpdateDate_UTC);
               int val12 = 45;
               tVItemExtraB.LastUpdateContactTVItemID = val12;
               Assert.AreEqual(val12, tVItemExtraB.LastUpdateContactTVItemID);
               bool val13 = true;
               tVItemExtraB.HasErrors = val13;
               Assert.AreEqual(val13, tVItemExtraB.HasErrors);
               IEnumerable<ValidationResult> val42 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               tVItemExtraB.ValidationResults = val42;
               Assert.AreEqual(val42, tVItemExtraB.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
