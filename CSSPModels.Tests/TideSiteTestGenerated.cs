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
    public partial class TideSiteTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private TideSite tideSite { get; set; }
        private TideSite_A tideSite_A { get; set; }
        private TideSite_B tideSite_B { get; set; }
        #endregion Properties

        #region Constructors
        public TideSiteTest()
        {
            tideSite = new TideSite();
            tideSite_A = new TideSite_A();
            tideSite_B = new TideSite_B();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void TideSite_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TideSiteID", "TideSiteTVItemID", "WebTideModel", "WebTideDatum_m", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideSite).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TideSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TideSite_A_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TideSiteTVItemLanguage", "LastUpdateContactTVItemLanguage", "TideSiteID", "TideSiteTVItemID", "WebTideModel", "WebTideDatum_m", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideSite_A).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TideSite_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TideSite_B_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TideSiteReportTest", "TideSiteTVItemLanguage", "LastUpdateContactTVItemLanguage", "TideSiteID", "TideSiteTVItemID", "WebTideModel", "WebTideDatum_m", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideSite_B).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TideSite_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TideSite_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideSite).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TideSite_A_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideSite_A).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideSite_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TideSite_B_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideSite_B).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TideSite_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TideSite_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TideSite).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TideSite_A_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TideSite_A).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TideSite_B_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TideSite_B).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TideSite_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               tideSite.TideSiteID = val1;
               Assert.AreEqual(val1, tideSite.TideSiteID);
               int val2 = 45;
               tideSite.TideSiteTVItemID = val2;
               Assert.AreEqual(val2, tideSite.TideSiteTVItemID);
               string val3 = "Some text";
               tideSite.WebTideModel = val3;
               Assert.AreEqual(val3, tideSite.WebTideModel);
               double val4 = 87.9D;
               tideSite.WebTideDatum_m = val4;
               Assert.AreEqual(val4, tideSite.WebTideDatum_m);
               DateTime val5 = new DateTime(2010, 3, 4);
               tideSite.LastUpdateDate_UTC = val5;
               Assert.AreEqual(val5, tideSite.LastUpdateDate_UTC);
               int val6 = 45;
               tideSite.LastUpdateContactTVItemID = val6;
               Assert.AreEqual(val6, tideSite.LastUpdateContactTVItemID);
               bool val7 = true;
               tideSite.HasErrors = val7;
               Assert.AreEqual(val7, tideSite.HasErrors);
               IEnumerable<ValidationResult> val24 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               tideSite.ValidationResults = val24;
               Assert.AreEqual(val24, tideSite.ValidationResults);
        }
        [TestMethod]
        public void TideSite_A_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               tideSite_A.TideSiteTVItemLanguage = val1;
               Assert.AreEqual(val1, tideSite_A.TideSiteTVItemLanguage);
               TVItemLanguage val2 = new TVItemLanguage();
               tideSite_A.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, tideSite_A.LastUpdateContactTVItemLanguage);
               int val3 = 45;
               tideSite_A.TideSiteID = val3;
               Assert.AreEqual(val3, tideSite_A.TideSiteID);
               int val4 = 45;
               tideSite_A.TideSiteTVItemID = val4;
               Assert.AreEqual(val4, tideSite_A.TideSiteTVItemID);
               string val5 = "Some text";
               tideSite_A.WebTideModel = val5;
               Assert.AreEqual(val5, tideSite_A.WebTideModel);
               double val6 = 87.9D;
               tideSite_A.WebTideDatum_m = val6;
               Assert.AreEqual(val6, tideSite_A.WebTideDatum_m);
               DateTime val7 = new DateTime(2010, 3, 4);
               tideSite_A.LastUpdateDate_UTC = val7;
               Assert.AreEqual(val7, tideSite_A.LastUpdateDate_UTC);
               int val8 = 45;
               tideSite_A.LastUpdateContactTVItemID = val8;
               Assert.AreEqual(val8, tideSite_A.LastUpdateContactTVItemID);
               bool val9 = true;
               tideSite_A.HasErrors = val9;
               Assert.AreEqual(val9, tideSite_A.HasErrors);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               tideSite_A.ValidationResults = val30;
               Assert.AreEqual(val30, tideSite_A.ValidationResults);
        }
        [TestMethod]
        public void TideSite_B_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               tideSite_B.TideSiteReportTest = val1;
               Assert.AreEqual(val1, tideSite_B.TideSiteReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               tideSite_B.TideSiteTVItemLanguage = val2;
               Assert.AreEqual(val2, tideSite_B.TideSiteTVItemLanguage);
               TVItemLanguage val3 = new TVItemLanguage();
               tideSite_B.LastUpdateContactTVItemLanguage = val3;
               Assert.AreEqual(val3, tideSite_B.LastUpdateContactTVItemLanguage);
               int val4 = 45;
               tideSite_B.TideSiteID = val4;
               Assert.AreEqual(val4, tideSite_B.TideSiteID);
               int val5 = 45;
               tideSite_B.TideSiteTVItemID = val5;
               Assert.AreEqual(val5, tideSite_B.TideSiteTVItemID);
               string val6 = "Some text";
               tideSite_B.WebTideModel = val6;
               Assert.AreEqual(val6, tideSite_B.WebTideModel);
               double val7 = 87.9D;
               tideSite_B.WebTideDatum_m = val7;
               Assert.AreEqual(val7, tideSite_B.WebTideDatum_m);
               DateTime val8 = new DateTime(2010, 3, 4);
               tideSite_B.LastUpdateDate_UTC = val8;
               Assert.AreEqual(val8, tideSite_B.LastUpdateDate_UTC);
               int val9 = 45;
               tideSite_B.LastUpdateContactTVItemID = val9;
               Assert.AreEqual(val9, tideSite_B.LastUpdateContactTVItemID);
               bool val10 = true;
               tideSite_B.HasErrors = val10;
               Assert.AreEqual(val10, tideSite_B.HasErrors);
               IEnumerable<ValidationResult> val33 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               tideSite_B.ValidationResults = val33;
               Assert.AreEqual(val33, tideSite_B.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
