/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by Charles on CHARLES-PC machine
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
        private MWQMSubsector_A mWQMSubsector_A { get; set; }
        private MWQMSubsector_B mWQMSubsector_B { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSubsectorTest()
        {
            mWQMSubsector = new MWQMSubsector();
            mWQMSubsector_A = new MWQMSubsector_A();
            mWQMSubsector_B = new MWQMSubsector_B();
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
        public void MWQMSubsector_A_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "SubsectorTVItemLanguage", "LastUpdateContactTVItemLanguage", "MWQMSubsectorID", "MWQMSubsectorTVItemID", "SubsectorHistoricKey", "TideLocationSIDText", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsector_A).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsector_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSubsector_B_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMSubsectorReportTest", "SubsectorTVItemLanguage", "LastUpdateContactTVItemLanguage", "MWQMSubsectorID", "MWQMSubsectorTVItemID", "SubsectorHistoricKey", "TideLocationSIDText", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsector_B).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsector_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSubsector_A_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsector_A).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsector_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSubsector_B_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsector_B).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsector_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSubsector_A_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSubsector_A).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSubsector_B_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSubsector_B).GetProperties().Where(c => c.Name == "ValidationResults").Any());
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
        public void MWQMSubsector_A_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               mWQMSubsector_A.SubsectorTVItemLanguage = val1;
               Assert.AreEqual(val1, mWQMSubsector_A.SubsectorTVItemLanguage);
               TVItemLanguage val2 = new TVItemLanguage();
               mWQMSubsector_A.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, mWQMSubsector_A.LastUpdateContactTVItemLanguage);
               int val3 = 45;
               mWQMSubsector_A.MWQMSubsectorID = val3;
               Assert.AreEqual(val3, mWQMSubsector_A.MWQMSubsectorID);
               int val4 = 45;
               mWQMSubsector_A.MWQMSubsectorTVItemID = val4;
               Assert.AreEqual(val4, mWQMSubsector_A.MWQMSubsectorTVItemID);
               string val5 = "Some text";
               mWQMSubsector_A.SubsectorHistoricKey = val5;
               Assert.AreEqual(val5, mWQMSubsector_A.SubsectorHistoricKey);
               string val6 = "Some text";
               mWQMSubsector_A.TideLocationSIDText = val6;
               Assert.AreEqual(val6, mWQMSubsector_A.TideLocationSIDText);
               DateTime val7 = new DateTime(2010, 3, 4);
               mWQMSubsector_A.LastUpdateDate_UTC = val7;
               Assert.AreEqual(val7, mWQMSubsector_A.LastUpdateDate_UTC);
               int val8 = 45;
               mWQMSubsector_A.LastUpdateContactTVItemID = val8;
               Assert.AreEqual(val8, mWQMSubsector_A.LastUpdateContactTVItemID);
               bool val9 = true;
               mWQMSubsector_A.HasErrors = val9;
               Assert.AreEqual(val9, mWQMSubsector_A.HasErrors);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mWQMSubsector_A.ValidationResults = val30;
               Assert.AreEqual(val30, mWQMSubsector_A.ValidationResults);
        }
        [TestMethod]
        public void MWQMSubsector_B_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mWQMSubsector_B.MWQMSubsectorReportTest = val1;
               Assert.AreEqual(val1, mWQMSubsector_B.MWQMSubsectorReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               mWQMSubsector_B.SubsectorTVItemLanguage = val2;
               Assert.AreEqual(val2, mWQMSubsector_B.SubsectorTVItemLanguage);
               TVItemLanguage val3 = new TVItemLanguage();
               mWQMSubsector_B.LastUpdateContactTVItemLanguage = val3;
               Assert.AreEqual(val3, mWQMSubsector_B.LastUpdateContactTVItemLanguage);
               int val4 = 45;
               mWQMSubsector_B.MWQMSubsectorID = val4;
               Assert.AreEqual(val4, mWQMSubsector_B.MWQMSubsectorID);
               int val5 = 45;
               mWQMSubsector_B.MWQMSubsectorTVItemID = val5;
               Assert.AreEqual(val5, mWQMSubsector_B.MWQMSubsectorTVItemID);
               string val6 = "Some text";
               mWQMSubsector_B.SubsectorHistoricKey = val6;
               Assert.AreEqual(val6, mWQMSubsector_B.SubsectorHistoricKey);
               string val7 = "Some text";
               mWQMSubsector_B.TideLocationSIDText = val7;
               Assert.AreEqual(val7, mWQMSubsector_B.TideLocationSIDText);
               DateTime val8 = new DateTime(2010, 3, 4);
               mWQMSubsector_B.LastUpdateDate_UTC = val8;
               Assert.AreEqual(val8, mWQMSubsector_B.LastUpdateDate_UTC);
               int val9 = 45;
               mWQMSubsector_B.LastUpdateContactTVItemID = val9;
               Assert.AreEqual(val9, mWQMSubsector_B.LastUpdateContactTVItemID);
               bool val10 = true;
               mWQMSubsector_B.HasErrors = val10;
               Assert.AreEqual(val10, mWQMSubsector_B.HasErrors);
               IEnumerable<ValidationResult> val33 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mWQMSubsector_B.ValidationResults = val33;
               Assert.AreEqual(val33, mWQMSubsector_B.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
