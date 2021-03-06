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
    public partial class TVItemStatTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private TVItemStat tVItemStat { get; set; }
        private TVItemStatExtraA tVItemStatExtraA { get; set; }
        private TVItemStatExtraB tVItemStatExtraB { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemStatTest()
        {
            tVItemStat = new TVItemStat();
            tVItemStatExtraA = new TVItemStatExtraA();
            tVItemStatExtraB = new TVItemStatExtraB();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void TVItemStat_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVItemStatID", "TVItemID", "TVType", "ChildCount", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemStat).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TVItemStat).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItemStatExtraA_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVItemText", "LastUpdateContactText", "TVTypeText", "TVItemStatID", "TVItemID", "TVType", "ChildCount", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemStatExtraA).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TVItemStatExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItemStatExtraB_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVItemStatReportTest", "TVItemText", "LastUpdateContactText", "TVTypeText", "TVItemStatID", "TVItemID", "TVType", "ChildCount", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemStatExtraB).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TVItemStatExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItemStat_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemStat).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemStat).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItemStatExtraA_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemStatExtraA).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemStatExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItemStatExtraB_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemStatExtraB).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVItemStatExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVItemStat_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVItemStat).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVItemStatExtraA_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVItemStatExtraA).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVItemStatExtraB_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVItemStatExtraB).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVItemStat_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               tVItemStat.TVItemStatID = val1;
               Assert.AreEqual(val1, tVItemStat.TVItemStatID);
               int val2 = 45;
               tVItemStat.TVItemID = val2;
               Assert.AreEqual(val2, tVItemStat.TVItemID);
               TVTypeEnum val3 = (TVTypeEnum)3;
               tVItemStat.TVType = val3;
               Assert.AreEqual(val3, tVItemStat.TVType);
               int val4 = 45;
               tVItemStat.ChildCount = val4;
               Assert.AreEqual(val4, tVItemStat.ChildCount);
               DateTime val5 = new DateTime(2010, 3, 4);
               tVItemStat.LastUpdateDate_UTC = val5;
               Assert.AreEqual(val5, tVItemStat.LastUpdateDate_UTC);
               int val6 = 45;
               tVItemStat.LastUpdateContactTVItemID = val6;
               Assert.AreEqual(val6, tVItemStat.LastUpdateContactTVItemID);
               bool val7 = true;
               tVItemStat.HasErrors = val7;
               Assert.AreEqual(val7, tVItemStat.HasErrors);
               IEnumerable<ValidationResult> val24 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               tVItemStat.ValidationResults = val24;
               Assert.AreEqual(val24, tVItemStat.ValidationResults);
        }
        [TestMethod]
        public void TVItemStatExtraA_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               tVItemStatExtraA.TVItemText = val1;
               Assert.AreEqual(val1, tVItemStatExtraA.TVItemText);
               string val2 = "Some text";
               tVItemStatExtraA.LastUpdateContactText = val2;
               Assert.AreEqual(val2, tVItemStatExtraA.LastUpdateContactText);
               string val3 = "Some text";
               tVItemStatExtraA.TVTypeText = val3;
               Assert.AreEqual(val3, tVItemStatExtraA.TVTypeText);
               int val4 = 45;
               tVItemStatExtraA.TVItemStatID = val4;
               Assert.AreEqual(val4, tVItemStatExtraA.TVItemStatID);
               int val5 = 45;
               tVItemStatExtraA.TVItemID = val5;
               Assert.AreEqual(val5, tVItemStatExtraA.TVItemID);
               TVTypeEnum val6 = (TVTypeEnum)3;
               tVItemStatExtraA.TVType = val6;
               Assert.AreEqual(val6, tVItemStatExtraA.TVType);
               int val7 = 45;
               tVItemStatExtraA.ChildCount = val7;
               Assert.AreEqual(val7, tVItemStatExtraA.ChildCount);
               DateTime val8 = new DateTime(2010, 3, 4);
               tVItemStatExtraA.LastUpdateDate_UTC = val8;
               Assert.AreEqual(val8, tVItemStatExtraA.LastUpdateDate_UTC);
               int val9 = 45;
               tVItemStatExtraA.LastUpdateContactTVItemID = val9;
               Assert.AreEqual(val9, tVItemStatExtraA.LastUpdateContactTVItemID);
               bool val10 = true;
               tVItemStatExtraA.HasErrors = val10;
               Assert.AreEqual(val10, tVItemStatExtraA.HasErrors);
               IEnumerable<ValidationResult> val33 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               tVItemStatExtraA.ValidationResults = val33;
               Assert.AreEqual(val33, tVItemStatExtraA.ValidationResults);
        }
        [TestMethod]
        public void TVItemStatExtraB_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               tVItemStatExtraB.TVItemStatReportTest = val1;
               Assert.AreEqual(val1, tVItemStatExtraB.TVItemStatReportTest);
               string val2 = "Some text";
               tVItemStatExtraB.TVItemText = val2;
               Assert.AreEqual(val2, tVItemStatExtraB.TVItemText);
               string val3 = "Some text";
               tVItemStatExtraB.LastUpdateContactText = val3;
               Assert.AreEqual(val3, tVItemStatExtraB.LastUpdateContactText);
               string val4 = "Some text";
               tVItemStatExtraB.TVTypeText = val4;
               Assert.AreEqual(val4, tVItemStatExtraB.TVTypeText);
               int val5 = 45;
               tVItemStatExtraB.TVItemStatID = val5;
               Assert.AreEqual(val5, tVItemStatExtraB.TVItemStatID);
               int val6 = 45;
               tVItemStatExtraB.TVItemID = val6;
               Assert.AreEqual(val6, tVItemStatExtraB.TVItemID);
               TVTypeEnum val7 = (TVTypeEnum)3;
               tVItemStatExtraB.TVType = val7;
               Assert.AreEqual(val7, tVItemStatExtraB.TVType);
               int val8 = 45;
               tVItemStatExtraB.ChildCount = val8;
               Assert.AreEqual(val8, tVItemStatExtraB.ChildCount);
               DateTime val9 = new DateTime(2010, 3, 4);
               tVItemStatExtraB.LastUpdateDate_UTC = val9;
               Assert.AreEqual(val9, tVItemStatExtraB.LastUpdateDate_UTC);
               int val10 = 45;
               tVItemStatExtraB.LastUpdateContactTVItemID = val10;
               Assert.AreEqual(val10, tVItemStatExtraB.LastUpdateContactTVItemID);
               bool val11 = true;
               tVItemStatExtraB.HasErrors = val11;
               Assert.AreEqual(val11, tVItemStatExtraB.HasErrors);
               IEnumerable<ValidationResult> val36 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               tVItemStatExtraB.ValidationResults = val36;
               Assert.AreEqual(val36, tVItemStatExtraB.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
