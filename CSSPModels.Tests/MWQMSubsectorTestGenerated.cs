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
    public partial class MWQMSubsectorTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private MWQMSubsector mWQMSubsector { get; set; }
        private MWQMSubsectorExtraA mWQMSubsectorExtraA { get; set; }
        private MWQMSubsectorExtraB mWQMSubsectorExtraB { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSubsectorTest()
        {
            mWQMSubsector = new MWQMSubsector();
            mWQMSubsectorExtraA = new MWQMSubsectorExtraA();
            mWQMSubsectorExtraB = new MWQMSubsectorExtraB();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void MWQMSubsector_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMSubsectorID", "MWQMSubsectorTVItemID", "SubsectorHistoricKey", "TideLocationSIDText", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsector).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsector).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSubsectorExtraA_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "SubsectorTVItemLanguage", "LastUpdateContactTVItemLanguage", "MWQMSubsectorID", "MWQMSubsectorTVItemID", "SubsectorHistoricKey", "TideLocationSIDText", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorExtraA).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSubsectorExtraB_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMSubsectorReportTest", "SubsectorTVItemLanguage", "LastUpdateContactTVItemLanguage", "MWQMSubsectorID", "MWQMSubsectorTVItemID", "SubsectorHistoricKey", "TideLocationSIDText", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorExtraB).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSubsector_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsector).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsector).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSubsectorExtraA_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorExtraA).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSubsectorExtraB_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorExtraB).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSubsector_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSubsector).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSubsectorExtraA_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSubsectorExtraA).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSubsectorExtraB_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSubsectorExtraB).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSubsector_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mWQMSubsector.MWQMSubsectorID = val1;
               Assert.AreEqual(val1, mWQMSubsector.MWQMSubsectorID);
               int val2 = 45;
               mWQMSubsector.MWQMSubsectorTVItemID = val2;
               Assert.AreEqual(val2, mWQMSubsector.MWQMSubsectorTVItemID);
               string val3 = "Some text";
               mWQMSubsector.SubsectorHistoricKey = val3;
               Assert.AreEqual(val3, mWQMSubsector.SubsectorHistoricKey);
               string val4 = "Some text";
               mWQMSubsector.TideLocationSIDText = val4;
               Assert.AreEqual(val4, mWQMSubsector.TideLocationSIDText);
               DateTime val5 = new DateTime(2010, 3, 4);
               mWQMSubsector.LastUpdateDate_UTC = val5;
               Assert.AreEqual(val5, mWQMSubsector.LastUpdateDate_UTC);
               int val6 = 45;
               mWQMSubsector.LastUpdateContactTVItemID = val6;
               Assert.AreEqual(val6, mWQMSubsector.LastUpdateContactTVItemID);
               bool val7 = true;
               mWQMSubsector.HasErrors = val7;
               Assert.AreEqual(val7, mWQMSubsector.HasErrors);
               IEnumerable<ValidationResult> val24 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mWQMSubsector.ValidationResults = val24;
               Assert.AreEqual(val24, mWQMSubsector.ValidationResults);
        }
        [TestMethod]
        public void MWQMSubsectorExtraA_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               mWQMSubsectorExtraA.SubsectorTVItemLanguage = val1;
               Assert.AreEqual(val1, mWQMSubsectorExtraA.SubsectorTVItemLanguage);
               TVItemLanguage val2 = new TVItemLanguage();
               mWQMSubsectorExtraA.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, mWQMSubsectorExtraA.LastUpdateContactTVItemLanguage);
               int val3 = 45;
               mWQMSubsectorExtraA.MWQMSubsectorID = val3;
               Assert.AreEqual(val3, mWQMSubsectorExtraA.MWQMSubsectorID);
               int val4 = 45;
               mWQMSubsectorExtraA.MWQMSubsectorTVItemID = val4;
               Assert.AreEqual(val4, mWQMSubsectorExtraA.MWQMSubsectorTVItemID);
               string val5 = "Some text";
               mWQMSubsectorExtraA.SubsectorHistoricKey = val5;
               Assert.AreEqual(val5, mWQMSubsectorExtraA.SubsectorHistoricKey);
               string val6 = "Some text";
               mWQMSubsectorExtraA.TideLocationSIDText = val6;
               Assert.AreEqual(val6, mWQMSubsectorExtraA.TideLocationSIDText);
               DateTime val7 = new DateTime(2010, 3, 4);
               mWQMSubsectorExtraA.LastUpdateDate_UTC = val7;
               Assert.AreEqual(val7, mWQMSubsectorExtraA.LastUpdateDate_UTC);
               int val8 = 45;
               mWQMSubsectorExtraA.LastUpdateContactTVItemID = val8;
               Assert.AreEqual(val8, mWQMSubsectorExtraA.LastUpdateContactTVItemID);
               bool val9 = true;
               mWQMSubsectorExtraA.HasErrors = val9;
               Assert.AreEqual(val9, mWQMSubsectorExtraA.HasErrors);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mWQMSubsectorExtraA.ValidationResults = val30;
               Assert.AreEqual(val30, mWQMSubsectorExtraA.ValidationResults);
        }
        [TestMethod]
        public void MWQMSubsectorExtraB_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mWQMSubsectorExtraB.MWQMSubsectorReportTest = val1;
               Assert.AreEqual(val1, mWQMSubsectorExtraB.MWQMSubsectorReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               mWQMSubsectorExtraB.SubsectorTVItemLanguage = val2;
               Assert.AreEqual(val2, mWQMSubsectorExtraB.SubsectorTVItemLanguage);
               TVItemLanguage val3 = new TVItemLanguage();
               mWQMSubsectorExtraB.LastUpdateContactTVItemLanguage = val3;
               Assert.AreEqual(val3, mWQMSubsectorExtraB.LastUpdateContactTVItemLanguage);
               int val4 = 45;
               mWQMSubsectorExtraB.MWQMSubsectorID = val4;
               Assert.AreEqual(val4, mWQMSubsectorExtraB.MWQMSubsectorID);
               int val5 = 45;
               mWQMSubsectorExtraB.MWQMSubsectorTVItemID = val5;
               Assert.AreEqual(val5, mWQMSubsectorExtraB.MWQMSubsectorTVItemID);
               string val6 = "Some text";
               mWQMSubsectorExtraB.SubsectorHistoricKey = val6;
               Assert.AreEqual(val6, mWQMSubsectorExtraB.SubsectorHistoricKey);
               string val7 = "Some text";
               mWQMSubsectorExtraB.TideLocationSIDText = val7;
               Assert.AreEqual(val7, mWQMSubsectorExtraB.TideLocationSIDText);
               DateTime val8 = new DateTime(2010, 3, 4);
               mWQMSubsectorExtraB.LastUpdateDate_UTC = val8;
               Assert.AreEqual(val8, mWQMSubsectorExtraB.LastUpdateDate_UTC);
               int val9 = 45;
               mWQMSubsectorExtraB.LastUpdateContactTVItemID = val9;
               Assert.AreEqual(val9, mWQMSubsectorExtraB.LastUpdateContactTVItemID);
               bool val10 = true;
               mWQMSubsectorExtraB.HasErrors = val10;
               Assert.AreEqual(val10, mWQMSubsectorExtraB.HasErrors);
               IEnumerable<ValidationResult> val33 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mWQMSubsectorExtraB.ValidationResults = val33;
               Assert.AreEqual(val33, mWQMSubsectorExtraB.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
