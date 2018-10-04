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
    public partial class MWQMSitePolSourceSiteTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private MWQMSitePolSourceSite mWQMSitePolSourceSite { get; set; }
        private MWQMSitePolSourceSite_A mWQMSitePolSourceSite_A { get; set; }
        private MWQMSitePolSourceSite_B mWQMSitePolSourceSite_B { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSitePolSourceSiteTest()
        {
            mWQMSitePolSourceSite = new MWQMSitePolSourceSite();
            mWQMSitePolSourceSite_A = new MWQMSitePolSourceSite_A();
            mWQMSitePolSourceSite_B = new MWQMSitePolSourceSite_B();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void MWQMSitePolSourceSite_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMSitePolSourceSiteID", "MWQMSiteTVItemID", "PolSourceSiteTVItemID", "TVType", "LinkReasons", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSitePolSourceSite).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMSitePolSourceSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSitePolSourceSite_A_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMSiteTVItemLanguage", "PolSourceSiteTVItemLanguage", "LastUpdateContactTVItemLanguage", "TVTypeText", "MWQMSitePolSourceSiteID", "MWQMSiteTVItemID", "PolSourceSiteTVItemID", "TVType", "LinkReasons", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSitePolSourceSite_A).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMSitePolSourceSite_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSitePolSourceSite_B_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMSitePolSourceSiteReportTest", "MWQMSiteTVItemLanguage", "PolSourceSiteTVItemLanguage", "LastUpdateContactTVItemLanguage", "TVTypeText", "MWQMSitePolSourceSiteID", "MWQMSiteTVItemID", "PolSourceSiteTVItemID", "TVType", "LinkReasons", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSitePolSourceSite_B).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMSitePolSourceSite_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSitePolSourceSite_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSitePolSourceSite).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSitePolSourceSite).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSitePolSourceSite_A_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSitePolSourceSite_A).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSitePolSourceSite_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSitePolSourceSite_B_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSitePolSourceSite_B).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSitePolSourceSite_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSitePolSourceSite_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSitePolSourceSite).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSitePolSourceSite_A_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSitePolSourceSite_A).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSitePolSourceSite_B_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSitePolSourceSite_B).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSitePolSourceSite_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mWQMSitePolSourceSite.MWQMSitePolSourceSiteID = val1;
               Assert.AreEqual(val1, mWQMSitePolSourceSite.MWQMSitePolSourceSiteID);
               int val2 = 45;
               mWQMSitePolSourceSite.MWQMSiteTVItemID = val2;
               Assert.AreEqual(val2, mWQMSitePolSourceSite.MWQMSiteTVItemID);
               int val3 = 45;
               mWQMSitePolSourceSite.PolSourceSiteTVItemID = val3;
               Assert.AreEqual(val3, mWQMSitePolSourceSite.PolSourceSiteTVItemID);
               TVTypeEnum val4 = (TVTypeEnum)3;
               mWQMSitePolSourceSite.TVType = val4;
               Assert.AreEqual(val4, mWQMSitePolSourceSite.TVType);
               string val5 = "Some text";
               mWQMSitePolSourceSite.LinkReasons = val5;
               Assert.AreEqual(val5, mWQMSitePolSourceSite.LinkReasons);
               DateTime val6 = new DateTime(2010, 3, 4);
               mWQMSitePolSourceSite.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, mWQMSitePolSourceSite.LastUpdateDate_UTC);
               int val7 = 45;
               mWQMSitePolSourceSite.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, mWQMSitePolSourceSite.LastUpdateContactTVItemID);
               bool val8 = true;
               mWQMSitePolSourceSite.HasErrors = val8;
               Assert.AreEqual(val8, mWQMSitePolSourceSite.HasErrors);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mWQMSitePolSourceSite.ValidationResults = val27;
               Assert.AreEqual(val27, mWQMSitePolSourceSite.ValidationResults);
        }
        [TestMethod]
        public void MWQMSitePolSourceSite_A_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               mWQMSitePolSourceSite_A.MWQMSiteTVItemLanguage = val1;
               Assert.AreEqual(val1, mWQMSitePolSourceSite_A.MWQMSiteTVItemLanguage);
               TVItemLanguage val2 = new TVItemLanguage();
               mWQMSitePolSourceSite_A.PolSourceSiteTVItemLanguage = val2;
               Assert.AreEqual(val2, mWQMSitePolSourceSite_A.PolSourceSiteTVItemLanguage);
               TVItemLanguage val3 = new TVItemLanguage();
               mWQMSitePolSourceSite_A.LastUpdateContactTVItemLanguage = val3;
               Assert.AreEqual(val3, mWQMSitePolSourceSite_A.LastUpdateContactTVItemLanguage);
               string val4 = "Some text";
               mWQMSitePolSourceSite_A.TVTypeText = val4;
               Assert.AreEqual(val4, mWQMSitePolSourceSite_A.TVTypeText);
               int val5 = 45;
               mWQMSitePolSourceSite_A.MWQMSitePolSourceSiteID = val5;
               Assert.AreEqual(val5, mWQMSitePolSourceSite_A.MWQMSitePolSourceSiteID);
               int val6 = 45;
               mWQMSitePolSourceSite_A.MWQMSiteTVItemID = val6;
               Assert.AreEqual(val6, mWQMSitePolSourceSite_A.MWQMSiteTVItemID);
               int val7 = 45;
               mWQMSitePolSourceSite_A.PolSourceSiteTVItemID = val7;
               Assert.AreEqual(val7, mWQMSitePolSourceSite_A.PolSourceSiteTVItemID);
               TVTypeEnum val8 = (TVTypeEnum)3;
               mWQMSitePolSourceSite_A.TVType = val8;
               Assert.AreEqual(val8, mWQMSitePolSourceSite_A.TVType);
               string val9 = "Some text";
               mWQMSitePolSourceSite_A.LinkReasons = val9;
               Assert.AreEqual(val9, mWQMSitePolSourceSite_A.LinkReasons);
               DateTime val10 = new DateTime(2010, 3, 4);
               mWQMSitePolSourceSite_A.LastUpdateDate_UTC = val10;
               Assert.AreEqual(val10, mWQMSitePolSourceSite_A.LastUpdateDate_UTC);
               int val11 = 45;
               mWQMSitePolSourceSite_A.LastUpdateContactTVItemID = val11;
               Assert.AreEqual(val11, mWQMSitePolSourceSite_A.LastUpdateContactTVItemID);
               bool val12 = true;
               mWQMSitePolSourceSite_A.HasErrors = val12;
               Assert.AreEqual(val12, mWQMSitePolSourceSite_A.HasErrors);
               IEnumerable<ValidationResult> val39 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mWQMSitePolSourceSite_A.ValidationResults = val39;
               Assert.AreEqual(val39, mWQMSitePolSourceSite_A.ValidationResults);
        }
        [TestMethod]
        public void MWQMSitePolSourceSite_B_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mWQMSitePolSourceSite_B.MWQMSitePolSourceSiteReportTest = val1;
               Assert.AreEqual(val1, mWQMSitePolSourceSite_B.MWQMSitePolSourceSiteReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               mWQMSitePolSourceSite_B.MWQMSiteTVItemLanguage = val2;
               Assert.AreEqual(val2, mWQMSitePolSourceSite_B.MWQMSiteTVItemLanguage);
               TVItemLanguage val3 = new TVItemLanguage();
               mWQMSitePolSourceSite_B.PolSourceSiteTVItemLanguage = val3;
               Assert.AreEqual(val3, mWQMSitePolSourceSite_B.PolSourceSiteTVItemLanguage);
               TVItemLanguage val4 = new TVItemLanguage();
               mWQMSitePolSourceSite_B.LastUpdateContactTVItemLanguage = val4;
               Assert.AreEqual(val4, mWQMSitePolSourceSite_B.LastUpdateContactTVItemLanguage);
               string val5 = "Some text";
               mWQMSitePolSourceSite_B.TVTypeText = val5;
               Assert.AreEqual(val5, mWQMSitePolSourceSite_B.TVTypeText);
               int val6 = 45;
               mWQMSitePolSourceSite_B.MWQMSitePolSourceSiteID = val6;
               Assert.AreEqual(val6, mWQMSitePolSourceSite_B.MWQMSitePolSourceSiteID);
               int val7 = 45;
               mWQMSitePolSourceSite_B.MWQMSiteTVItemID = val7;
               Assert.AreEqual(val7, mWQMSitePolSourceSite_B.MWQMSiteTVItemID);
               int val8 = 45;
               mWQMSitePolSourceSite_B.PolSourceSiteTVItemID = val8;
               Assert.AreEqual(val8, mWQMSitePolSourceSite_B.PolSourceSiteTVItemID);
               TVTypeEnum val9 = (TVTypeEnum)3;
               mWQMSitePolSourceSite_B.TVType = val9;
               Assert.AreEqual(val9, mWQMSitePolSourceSite_B.TVType);
               string val10 = "Some text";
               mWQMSitePolSourceSite_B.LinkReasons = val10;
               Assert.AreEqual(val10, mWQMSitePolSourceSite_B.LinkReasons);
               DateTime val11 = new DateTime(2010, 3, 4);
               mWQMSitePolSourceSite_B.LastUpdateDate_UTC = val11;
               Assert.AreEqual(val11, mWQMSitePolSourceSite_B.LastUpdateDate_UTC);
               int val12 = 45;
               mWQMSitePolSourceSite_B.LastUpdateContactTVItemID = val12;
               Assert.AreEqual(val12, mWQMSitePolSourceSite_B.LastUpdateContactTVItemID);
               bool val13 = true;
               mWQMSitePolSourceSite_B.HasErrors = val13;
               Assert.AreEqual(val13, mWQMSitePolSourceSite_B.HasErrors);
               IEnumerable<ValidationResult> val42 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mWQMSitePolSourceSite_B.ValidationResults = val42;
               Assert.AreEqual(val42, mWQMSitePolSourceSite_B.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
