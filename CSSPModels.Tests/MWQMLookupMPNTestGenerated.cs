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
    public partial class MWQMLookupMPNTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private MWQMLookupMPN mWQMLookupMPN { get; set; }
        private MWQMLookupMPNExtraA mWQMLookupMPNExtraA { get; set; }
        private MWQMLookupMPNExtraB mWQMLookupMPNExtraB { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMLookupMPNTest()
        {
            mWQMLookupMPN = new MWQMLookupMPN();
            mWQMLookupMPNExtraA = new MWQMLookupMPNExtraA();
            mWQMLookupMPNExtraB = new MWQMLookupMPNExtraB();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void MWQMLookupMPN_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMLookupMPNID", "Tubes10", "Tubes1", "Tubes01", "MPN_100ml", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMLookupMPN).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMLookupMPN).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMLookupMPNExtraA_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactText", "MWQMLookupMPNID", "Tubes10", "Tubes1", "Tubes01", "MPN_100ml", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMLookupMPNExtraA).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMLookupMPNExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMLookupMPNExtraB_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMLookupMPNReportTest", "LastUpdateContactText", "MWQMLookupMPNID", "Tubes10", "Tubes1", "Tubes01", "MPN_100ml", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMLookupMPNExtraB).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMLookupMPNExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMLookupMPN_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMLookupMPN).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMLookupMPN).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMLookupMPNExtraA_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMLookupMPNExtraA).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMLookupMPNExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMLookupMPNExtraB_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMLookupMPNExtraB).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMLookupMPNExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMLookupMPN_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMLookupMPN).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMLookupMPNExtraA_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMLookupMPNExtraA).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMLookupMPNExtraB_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMLookupMPNExtraB).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMLookupMPN_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mWQMLookupMPN.MWQMLookupMPNID = val1;
               Assert.AreEqual(val1, mWQMLookupMPN.MWQMLookupMPNID);
               int val2 = 45;
               mWQMLookupMPN.Tubes10 = val2;
               Assert.AreEqual(val2, mWQMLookupMPN.Tubes10);
               int val3 = 45;
               mWQMLookupMPN.Tubes1 = val3;
               Assert.AreEqual(val3, mWQMLookupMPN.Tubes1);
               int val4 = 45;
               mWQMLookupMPN.Tubes01 = val4;
               Assert.AreEqual(val4, mWQMLookupMPN.Tubes01);
               int val5 = 45;
               mWQMLookupMPN.MPN_100ml = val5;
               Assert.AreEqual(val5, mWQMLookupMPN.MPN_100ml);
               DateTime val6 = new DateTime(2010, 3, 4);
               mWQMLookupMPN.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, mWQMLookupMPN.LastUpdateDate_UTC);
               int val7 = 45;
               mWQMLookupMPN.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, mWQMLookupMPN.LastUpdateContactTVItemID);
               bool val8 = true;
               mWQMLookupMPN.HasErrors = val8;
               Assert.AreEqual(val8, mWQMLookupMPN.HasErrors);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               mWQMLookupMPN.ValidationResults = val27;
               Assert.AreEqual(val27, mWQMLookupMPN.ValidationResults);
        }
        [TestMethod]
        public void MWQMLookupMPNExtraA_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mWQMLookupMPNExtraA.LastUpdateContactText = val1;
               Assert.AreEqual(val1, mWQMLookupMPNExtraA.LastUpdateContactText);
               int val2 = 45;
               mWQMLookupMPNExtraA.MWQMLookupMPNID = val2;
               Assert.AreEqual(val2, mWQMLookupMPNExtraA.MWQMLookupMPNID);
               int val3 = 45;
               mWQMLookupMPNExtraA.Tubes10 = val3;
               Assert.AreEqual(val3, mWQMLookupMPNExtraA.Tubes10);
               int val4 = 45;
               mWQMLookupMPNExtraA.Tubes1 = val4;
               Assert.AreEqual(val4, mWQMLookupMPNExtraA.Tubes1);
               int val5 = 45;
               mWQMLookupMPNExtraA.Tubes01 = val5;
               Assert.AreEqual(val5, mWQMLookupMPNExtraA.Tubes01);
               int val6 = 45;
               mWQMLookupMPNExtraA.MPN_100ml = val6;
               Assert.AreEqual(val6, mWQMLookupMPNExtraA.MPN_100ml);
               DateTime val7 = new DateTime(2010, 3, 4);
               mWQMLookupMPNExtraA.LastUpdateDate_UTC = val7;
               Assert.AreEqual(val7, mWQMLookupMPNExtraA.LastUpdateDate_UTC);
               int val8 = 45;
               mWQMLookupMPNExtraA.LastUpdateContactTVItemID = val8;
               Assert.AreEqual(val8, mWQMLookupMPNExtraA.LastUpdateContactTVItemID);
               bool val9 = true;
               mWQMLookupMPNExtraA.HasErrors = val9;
               Assert.AreEqual(val9, mWQMLookupMPNExtraA.HasErrors);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               mWQMLookupMPNExtraA.ValidationResults = val30;
               Assert.AreEqual(val30, mWQMLookupMPNExtraA.ValidationResults);
        }
        [TestMethod]
        public void MWQMLookupMPNExtraB_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mWQMLookupMPNExtraB.MWQMLookupMPNReportTest = val1;
               Assert.AreEqual(val1, mWQMLookupMPNExtraB.MWQMLookupMPNReportTest);
               string val2 = "Some text";
               mWQMLookupMPNExtraB.LastUpdateContactText = val2;
               Assert.AreEqual(val2, mWQMLookupMPNExtraB.LastUpdateContactText);
               int val3 = 45;
               mWQMLookupMPNExtraB.MWQMLookupMPNID = val3;
               Assert.AreEqual(val3, mWQMLookupMPNExtraB.MWQMLookupMPNID);
               int val4 = 45;
               mWQMLookupMPNExtraB.Tubes10 = val4;
               Assert.AreEqual(val4, mWQMLookupMPNExtraB.Tubes10);
               int val5 = 45;
               mWQMLookupMPNExtraB.Tubes1 = val5;
               Assert.AreEqual(val5, mWQMLookupMPNExtraB.Tubes1);
               int val6 = 45;
               mWQMLookupMPNExtraB.Tubes01 = val6;
               Assert.AreEqual(val6, mWQMLookupMPNExtraB.Tubes01);
               int val7 = 45;
               mWQMLookupMPNExtraB.MPN_100ml = val7;
               Assert.AreEqual(val7, mWQMLookupMPNExtraB.MPN_100ml);
               DateTime val8 = new DateTime(2010, 3, 4);
               mWQMLookupMPNExtraB.LastUpdateDate_UTC = val8;
               Assert.AreEqual(val8, mWQMLookupMPNExtraB.LastUpdateDate_UTC);
               int val9 = 45;
               mWQMLookupMPNExtraB.LastUpdateContactTVItemID = val9;
               Assert.AreEqual(val9, mWQMLookupMPNExtraB.LastUpdateContactTVItemID);
               bool val10 = true;
               mWQMLookupMPNExtraB.HasErrors = val10;
               Assert.AreEqual(val10, mWQMLookupMPNExtraB.HasErrors);
               IEnumerable<ValidationResult> val33 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               mWQMLookupMPNExtraB.ValidationResults = val33;
               Assert.AreEqual(val33, mWQMLookupMPNExtraB.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
