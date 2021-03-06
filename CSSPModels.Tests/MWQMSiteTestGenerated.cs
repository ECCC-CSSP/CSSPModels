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
    public partial class MWQMSiteTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private MWQMSite mWQMSite { get; set; }
        private MWQMSiteExtraA mWQMSiteExtraA { get; set; }
        private MWQMSiteExtraB mWQMSiteExtraB { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSiteTest()
        {
            mWQMSite = new MWQMSite();
            mWQMSiteExtraA = new MWQMSiteExtraA();
            mWQMSiteExtraB = new MWQMSiteExtraB();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void MWQMSite_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMSiteID", "MWQMSiteTVItemID", "MWQMSiteNumber", "MWQMSiteDescription", "MWQMSiteLatestClassification", "Ordinal", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSite).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSiteExtraA_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMSiteText", "LastUpdateContactText", "MWQMSiteLatestClassificationText", "MWQMSiteID", "MWQMSiteTVItemID", "MWQMSiteNumber", "MWQMSiteDescription", "MWQMSiteLatestClassification", "Ordinal", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSiteExtraA).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMSiteExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSiteExtraB_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMSiteReportTest", "MWQMSiteText", "LastUpdateContactText", "MWQMSiteLatestClassificationText", "MWQMSiteID", "MWQMSiteTVItemID", "MWQMSiteNumber", "MWQMSiteDescription", "MWQMSiteLatestClassification", "Ordinal", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSiteExtraB).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMSiteExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSite_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSite).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSiteExtraA_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSiteExtraA).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSiteExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSiteExtraB_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSiteExtraB).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSiteExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSite_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSite).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSiteExtraA_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSiteExtraA).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSiteExtraB_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSiteExtraB).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSite_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mWQMSite.MWQMSiteID = val1;
               Assert.AreEqual(val1, mWQMSite.MWQMSiteID);
               int val2 = 45;
               mWQMSite.MWQMSiteTVItemID = val2;
               Assert.AreEqual(val2, mWQMSite.MWQMSiteTVItemID);
               string val3 = "Some text";
               mWQMSite.MWQMSiteNumber = val3;
               Assert.AreEqual(val3, mWQMSite.MWQMSiteNumber);
               string val4 = "Some text";
               mWQMSite.MWQMSiteDescription = val4;
               Assert.AreEqual(val4, mWQMSite.MWQMSiteDescription);
               MWQMSiteLatestClassificationEnum val5 = (MWQMSiteLatestClassificationEnum)3;
               mWQMSite.MWQMSiteLatestClassification = val5;
               Assert.AreEqual(val5, mWQMSite.MWQMSiteLatestClassification);
               int val6 = 45;
               mWQMSite.Ordinal = val6;
               Assert.AreEqual(val6, mWQMSite.Ordinal);
               DateTime val7 = new DateTime(2010, 3, 4);
               mWQMSite.LastUpdateDate_UTC = val7;
               Assert.AreEqual(val7, mWQMSite.LastUpdateDate_UTC);
               int val8 = 45;
               mWQMSite.LastUpdateContactTVItemID = val8;
               Assert.AreEqual(val8, mWQMSite.LastUpdateContactTVItemID);
               bool val9 = true;
               mWQMSite.HasErrors = val9;
               Assert.AreEqual(val9, mWQMSite.HasErrors);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               mWQMSite.ValidationResults = val30;
               Assert.AreEqual(val30, mWQMSite.ValidationResults);
        }
        [TestMethod]
        public void MWQMSiteExtraA_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mWQMSiteExtraA.MWQMSiteText = val1;
               Assert.AreEqual(val1, mWQMSiteExtraA.MWQMSiteText);
               string val2 = "Some text";
               mWQMSiteExtraA.LastUpdateContactText = val2;
               Assert.AreEqual(val2, mWQMSiteExtraA.LastUpdateContactText);
               string val3 = "Some text";
               mWQMSiteExtraA.MWQMSiteLatestClassificationText = val3;
               Assert.AreEqual(val3, mWQMSiteExtraA.MWQMSiteLatestClassificationText);
               int val4 = 45;
               mWQMSiteExtraA.MWQMSiteID = val4;
               Assert.AreEqual(val4, mWQMSiteExtraA.MWQMSiteID);
               int val5 = 45;
               mWQMSiteExtraA.MWQMSiteTVItemID = val5;
               Assert.AreEqual(val5, mWQMSiteExtraA.MWQMSiteTVItemID);
               string val6 = "Some text";
               mWQMSiteExtraA.MWQMSiteNumber = val6;
               Assert.AreEqual(val6, mWQMSiteExtraA.MWQMSiteNumber);
               string val7 = "Some text";
               mWQMSiteExtraA.MWQMSiteDescription = val7;
               Assert.AreEqual(val7, mWQMSiteExtraA.MWQMSiteDescription);
               MWQMSiteLatestClassificationEnum val8 = (MWQMSiteLatestClassificationEnum)3;
               mWQMSiteExtraA.MWQMSiteLatestClassification = val8;
               Assert.AreEqual(val8, mWQMSiteExtraA.MWQMSiteLatestClassification);
               int val9 = 45;
               mWQMSiteExtraA.Ordinal = val9;
               Assert.AreEqual(val9, mWQMSiteExtraA.Ordinal);
               DateTime val10 = new DateTime(2010, 3, 4);
               mWQMSiteExtraA.LastUpdateDate_UTC = val10;
               Assert.AreEqual(val10, mWQMSiteExtraA.LastUpdateDate_UTC);
               int val11 = 45;
               mWQMSiteExtraA.LastUpdateContactTVItemID = val11;
               Assert.AreEqual(val11, mWQMSiteExtraA.LastUpdateContactTVItemID);
               bool val12 = true;
               mWQMSiteExtraA.HasErrors = val12;
               Assert.AreEqual(val12, mWQMSiteExtraA.HasErrors);
               IEnumerable<ValidationResult> val39 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               mWQMSiteExtraA.ValidationResults = val39;
               Assert.AreEqual(val39, mWQMSiteExtraA.ValidationResults);
        }
        [TestMethod]
        public void MWQMSiteExtraB_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mWQMSiteExtraB.MWQMSiteReportTest = val1;
               Assert.AreEqual(val1, mWQMSiteExtraB.MWQMSiteReportTest);
               string val2 = "Some text";
               mWQMSiteExtraB.MWQMSiteText = val2;
               Assert.AreEqual(val2, mWQMSiteExtraB.MWQMSiteText);
               string val3 = "Some text";
               mWQMSiteExtraB.LastUpdateContactText = val3;
               Assert.AreEqual(val3, mWQMSiteExtraB.LastUpdateContactText);
               string val4 = "Some text";
               mWQMSiteExtraB.MWQMSiteLatestClassificationText = val4;
               Assert.AreEqual(val4, mWQMSiteExtraB.MWQMSiteLatestClassificationText);
               int val5 = 45;
               mWQMSiteExtraB.MWQMSiteID = val5;
               Assert.AreEqual(val5, mWQMSiteExtraB.MWQMSiteID);
               int val6 = 45;
               mWQMSiteExtraB.MWQMSiteTVItemID = val6;
               Assert.AreEqual(val6, mWQMSiteExtraB.MWQMSiteTVItemID);
               string val7 = "Some text";
               mWQMSiteExtraB.MWQMSiteNumber = val7;
               Assert.AreEqual(val7, mWQMSiteExtraB.MWQMSiteNumber);
               string val8 = "Some text";
               mWQMSiteExtraB.MWQMSiteDescription = val8;
               Assert.AreEqual(val8, mWQMSiteExtraB.MWQMSiteDescription);
               MWQMSiteLatestClassificationEnum val9 = (MWQMSiteLatestClassificationEnum)3;
               mWQMSiteExtraB.MWQMSiteLatestClassification = val9;
               Assert.AreEqual(val9, mWQMSiteExtraB.MWQMSiteLatestClassification);
               int val10 = 45;
               mWQMSiteExtraB.Ordinal = val10;
               Assert.AreEqual(val10, mWQMSiteExtraB.Ordinal);
               DateTime val11 = new DateTime(2010, 3, 4);
               mWQMSiteExtraB.LastUpdateDate_UTC = val11;
               Assert.AreEqual(val11, mWQMSiteExtraB.LastUpdateDate_UTC);
               int val12 = 45;
               mWQMSiteExtraB.LastUpdateContactTVItemID = val12;
               Assert.AreEqual(val12, mWQMSiteExtraB.LastUpdateContactTVItemID);
               bool val13 = true;
               mWQMSiteExtraB.HasErrors = val13;
               Assert.AreEqual(val13, mWQMSiteExtraB.HasErrors);
               IEnumerable<ValidationResult> val42 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               mWQMSiteExtraB.ValidationResults = val42;
               Assert.AreEqual(val42, mWQMSiteExtraB.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
