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
    public partial class MikeScenarioResultTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private MikeScenarioResult mikeScenarioResult { get; set; }
        private MikeScenarioResultExtraA mikeScenarioResultExtraA { get; set; }
        private MikeScenarioResultExtraB mikeScenarioResultExtraB { get; set; }
        #endregion Properties

        #region Constructors
        public MikeScenarioResultTest()
        {
            mikeScenarioResult = new MikeScenarioResult();
            mikeScenarioResultExtraA = new MikeScenarioResultExtraA();
            mikeScenarioResultExtraB = new MikeScenarioResultExtraB();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void MikeScenarioResult_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MikeScenarioResultID", "MikeScenarioTVItemID", "MikeResultsJSON", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeScenarioResult).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MikeScenarioResult).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeScenarioResultExtraA_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactText", "MikeScenarioResultID", "MikeScenarioTVItemID", "MikeResultsJSON", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeScenarioResultExtraA).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MikeScenarioResultExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeScenarioResultExtraB_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MikeScenarioReportTest", "LastUpdateContactText", "MikeScenarioResultID", "MikeScenarioTVItemID", "MikeResultsJSON", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeScenarioResultExtraB).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MikeScenarioResultExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeScenarioResult_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeScenarioResult).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeScenarioResult).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeScenarioResultExtraA_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeScenarioResultExtraA).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeScenarioResultExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeScenarioResultExtraB_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeScenarioResultExtraB).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeScenarioResultExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeScenarioResult_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MikeScenarioResult).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MikeScenarioResultExtraA_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MikeScenarioResultExtraA).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MikeScenarioResultExtraB_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MikeScenarioResultExtraB).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MikeScenarioResult_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mikeScenarioResult.MikeScenarioResultID = val1;
               Assert.AreEqual(val1, mikeScenarioResult.MikeScenarioResultID);
               int val2 = 45;
               mikeScenarioResult.MikeScenarioTVItemID = val2;
               Assert.AreEqual(val2, mikeScenarioResult.MikeScenarioTVItemID);
               string val3 = "Some text";
               mikeScenarioResult.MikeResultsJSON = val3;
               Assert.AreEqual(val3, mikeScenarioResult.MikeResultsJSON);
               DateTime val4 = new DateTime(2010, 3, 4);
               mikeScenarioResult.LastUpdateDate_UTC = val4;
               Assert.AreEqual(val4, mikeScenarioResult.LastUpdateDate_UTC);
               int val5 = 45;
               mikeScenarioResult.LastUpdateContactTVItemID = val5;
               Assert.AreEqual(val5, mikeScenarioResult.LastUpdateContactTVItemID);
               bool val6 = true;
               mikeScenarioResult.HasErrors = val6;
               Assert.AreEqual(val6, mikeScenarioResult.HasErrors);
               IEnumerable<ValidationResult> val21 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               mikeScenarioResult.ValidationResults = val21;
               Assert.AreEqual(val21, mikeScenarioResult.ValidationResults);
        }
        [TestMethod]
        public void MikeScenarioResultExtraA_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mikeScenarioResultExtraA.LastUpdateContactText = val1;
               Assert.AreEqual(val1, mikeScenarioResultExtraA.LastUpdateContactText);
               int val2 = 45;
               mikeScenarioResultExtraA.MikeScenarioResultID = val2;
               Assert.AreEqual(val2, mikeScenarioResultExtraA.MikeScenarioResultID);
               int val3 = 45;
               mikeScenarioResultExtraA.MikeScenarioTVItemID = val3;
               Assert.AreEqual(val3, mikeScenarioResultExtraA.MikeScenarioTVItemID);
               string val4 = "Some text";
               mikeScenarioResultExtraA.MikeResultsJSON = val4;
               Assert.AreEqual(val4, mikeScenarioResultExtraA.MikeResultsJSON);
               DateTime val5 = new DateTime(2010, 3, 4);
               mikeScenarioResultExtraA.LastUpdateDate_UTC = val5;
               Assert.AreEqual(val5, mikeScenarioResultExtraA.LastUpdateDate_UTC);
               int val6 = 45;
               mikeScenarioResultExtraA.LastUpdateContactTVItemID = val6;
               Assert.AreEqual(val6, mikeScenarioResultExtraA.LastUpdateContactTVItemID);
               bool val7 = true;
               mikeScenarioResultExtraA.HasErrors = val7;
               Assert.AreEqual(val7, mikeScenarioResultExtraA.HasErrors);
               IEnumerable<ValidationResult> val24 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               mikeScenarioResultExtraA.ValidationResults = val24;
               Assert.AreEqual(val24, mikeScenarioResultExtraA.ValidationResults);
        }
        [TestMethod]
        public void MikeScenarioResultExtraB_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mikeScenarioResultExtraB.MikeScenarioReportTest = val1;
               Assert.AreEqual(val1, mikeScenarioResultExtraB.MikeScenarioReportTest);
               string val2 = "Some text";
               mikeScenarioResultExtraB.LastUpdateContactText = val2;
               Assert.AreEqual(val2, mikeScenarioResultExtraB.LastUpdateContactText);
               int val3 = 45;
               mikeScenarioResultExtraB.MikeScenarioResultID = val3;
               Assert.AreEqual(val3, mikeScenarioResultExtraB.MikeScenarioResultID);
               int val4 = 45;
               mikeScenarioResultExtraB.MikeScenarioTVItemID = val4;
               Assert.AreEqual(val4, mikeScenarioResultExtraB.MikeScenarioTVItemID);
               string val5 = "Some text";
               mikeScenarioResultExtraB.MikeResultsJSON = val5;
               Assert.AreEqual(val5, mikeScenarioResultExtraB.MikeResultsJSON);
               DateTime val6 = new DateTime(2010, 3, 4);
               mikeScenarioResultExtraB.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, mikeScenarioResultExtraB.LastUpdateDate_UTC);
               int val7 = 45;
               mikeScenarioResultExtraB.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, mikeScenarioResultExtraB.LastUpdateContactTVItemID);
               bool val8 = true;
               mikeScenarioResultExtraB.HasErrors = val8;
               Assert.AreEqual(val8, mikeScenarioResultExtraB.HasErrors);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               mikeScenarioResultExtraB.ValidationResults = val27;
               Assert.AreEqual(val27, mikeScenarioResultExtraB.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
