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
    public partial class MWQMSubsectorTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private MWQMSubsector mWQMSubsector { get; set; }
        private MWQMSubsectorWeb mWQMSubsectorWeb { get; set; }
        private MWQMSubsectorReport mWQMSubsectorReport { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSubsectorTest()
        {
            mWQMSubsector = new MWQMSubsector();
            mWQMSubsectorWeb = new MWQMSubsectorWeb();
            mWQMSubsectorReport = new MWQMSubsectorReport();
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
        public void MWQMSubsectorWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "SubsectorTVItemLanguage", "LastUpdateContactTVItemLanguage", "MWQMSubsectorID", "MWQMSubsectorTVItemID", "SubsectorHistoricKey", "TideLocationSIDText", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorWeb).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSubsectorReport_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMSubsectorReportTest", "SubsectorTVItemLanguage", "LastUpdateContactTVItemLanguage", "MWQMSubsectorID", "MWQMSubsectorTVItemID", "SubsectorHistoricKey", "TideLocationSIDText", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorReport).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSubsectorWeb_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorWeb).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSubsectorReport_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorReport).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsectorReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSubsectorWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSubsectorWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSubsectorReport_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSubsectorReport).GetProperties().Where(c => c.Name == "ValidationResults").Any());
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
        public void MWQMSubsectorWeb_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               mWQMSubsectorWeb.SubsectorTVItemLanguage = val1;
               Assert.AreEqual(val1, mWQMSubsectorWeb.SubsectorTVItemLanguage);
               TVItemLanguage val2 = new TVItemLanguage();
               mWQMSubsectorWeb.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, mWQMSubsectorWeb.LastUpdateContactTVItemLanguage);
               int val3 = 45;
               mWQMSubsectorWeb.MWQMSubsectorID = val3;
               Assert.AreEqual(val3, mWQMSubsectorWeb.MWQMSubsectorID);
               int val4 = 45;
               mWQMSubsectorWeb.MWQMSubsectorTVItemID = val4;
               Assert.AreEqual(val4, mWQMSubsectorWeb.MWQMSubsectorTVItemID);
               string val5 = "Some text";
               mWQMSubsectorWeb.SubsectorHistoricKey = val5;
               Assert.AreEqual(val5, mWQMSubsectorWeb.SubsectorHistoricKey);
               string val6 = "Some text";
               mWQMSubsectorWeb.TideLocationSIDText = val6;
               Assert.AreEqual(val6, mWQMSubsectorWeb.TideLocationSIDText);
               DateTime val7 = new DateTime(2010, 3, 4);
               mWQMSubsectorWeb.LastUpdateDate_UTC = val7;
               Assert.AreEqual(val7, mWQMSubsectorWeb.LastUpdateDate_UTC);
               int val8 = 45;
               mWQMSubsectorWeb.LastUpdateContactTVItemID = val8;
               Assert.AreEqual(val8, mWQMSubsectorWeb.LastUpdateContactTVItemID);
               bool val9 = true;
               mWQMSubsectorWeb.HasErrors = val9;
               Assert.AreEqual(val9, mWQMSubsectorWeb.HasErrors);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mWQMSubsectorWeb.ValidationResults = val30;
               Assert.AreEqual(val30, mWQMSubsectorWeb.ValidationResults);
        }
        [TestMethod]
        public void MWQMSubsectorReport_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mWQMSubsectorReport.MWQMSubsectorReportTest = val1;
               Assert.AreEqual(val1, mWQMSubsectorReport.MWQMSubsectorReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               mWQMSubsectorReport.SubsectorTVItemLanguage = val2;
               Assert.AreEqual(val2, mWQMSubsectorReport.SubsectorTVItemLanguage);
               TVItemLanguage val3 = new TVItemLanguage();
               mWQMSubsectorReport.LastUpdateContactTVItemLanguage = val3;
               Assert.AreEqual(val3, mWQMSubsectorReport.LastUpdateContactTVItemLanguage);
               int val4 = 45;
               mWQMSubsectorReport.MWQMSubsectorID = val4;
               Assert.AreEqual(val4, mWQMSubsectorReport.MWQMSubsectorID);
               int val5 = 45;
               mWQMSubsectorReport.MWQMSubsectorTVItemID = val5;
               Assert.AreEqual(val5, mWQMSubsectorReport.MWQMSubsectorTVItemID);
               string val6 = "Some text";
               mWQMSubsectorReport.SubsectorHistoricKey = val6;
               Assert.AreEqual(val6, mWQMSubsectorReport.SubsectorHistoricKey);
               string val7 = "Some text";
               mWQMSubsectorReport.TideLocationSIDText = val7;
               Assert.AreEqual(val7, mWQMSubsectorReport.TideLocationSIDText);
               DateTime val8 = new DateTime(2010, 3, 4);
               mWQMSubsectorReport.LastUpdateDate_UTC = val8;
               Assert.AreEqual(val8, mWQMSubsectorReport.LastUpdateDate_UTC);
               int val9 = 45;
               mWQMSubsectorReport.LastUpdateContactTVItemID = val9;
               Assert.AreEqual(val9, mWQMSubsectorReport.LastUpdateContactTVItemID);
               bool val10 = true;
               mWQMSubsectorReport.HasErrors = val10;
               Assert.AreEqual(val10, mWQMSubsectorReport.HasErrors);
               IEnumerable<ValidationResult> val33 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mWQMSubsectorReport.ValidationResults = val33;
               Assert.AreEqual(val33, mWQMSubsectorReport.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
