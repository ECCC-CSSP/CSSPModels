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
    public partial class TVTypeUserAuthorizationTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private TVTypeUserAuthorization tVTypeUserAuthorization { get; set; }
        private TVTypeUserAuthorizationExtraA tVTypeUserAuthorizationExtraA { get; set; }
        private TVTypeUserAuthorizationExtraB tVTypeUserAuthorizationExtraB { get; set; }
        #endregion Properties

        #region Constructors
        public TVTypeUserAuthorizationTest()
        {
            tVTypeUserAuthorization = new TVTypeUserAuthorization();
            tVTypeUserAuthorizationExtraA = new TVTypeUserAuthorizationExtraA();
            tVTypeUserAuthorizationExtraB = new TVTypeUserAuthorizationExtraB();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void TVTypeUserAuthorization_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVTypeUserAuthorizationID", "ContactTVItemID", "TVType", "TVAuth", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVTypeUserAuthorization).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TVTypeUserAuthorization).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVTypeUserAuthorizationExtraA_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ContactName", "LastUpdateContactText", "TVTypeText", "TVAuthText", "TVTypeUserAuthorizationID", "ContactTVItemID", "TVType", "TVAuth", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVTypeUserAuthorizationExtraA).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TVTypeUserAuthorizationExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVTypeUserAuthorizationExtraB_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVTypeUserAuthorizationReportTest", "ContactName", "LastUpdateContactText", "TVTypeText", "TVAuthText", "TVTypeUserAuthorizationID", "ContactTVItemID", "TVType", "TVAuth", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVTypeUserAuthorizationExtraB).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TVTypeUserAuthorizationExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVTypeUserAuthorization_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVTypeUserAuthorization).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVTypeUserAuthorization).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVTypeUserAuthorizationExtraA_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVTypeUserAuthorizationExtraA).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVTypeUserAuthorizationExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVTypeUserAuthorizationExtraB_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVTypeUserAuthorizationExtraB).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVTypeUserAuthorizationExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVTypeUserAuthorization_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVTypeUserAuthorization).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVTypeUserAuthorizationExtraA_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVTypeUserAuthorizationExtraA).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVTypeUserAuthorizationExtraB_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVTypeUserAuthorizationExtraB).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVTypeUserAuthorization_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               tVTypeUserAuthorization.TVTypeUserAuthorizationID = val1;
               Assert.AreEqual(val1, tVTypeUserAuthorization.TVTypeUserAuthorizationID);
               int val2 = 45;
               tVTypeUserAuthorization.ContactTVItemID = val2;
               Assert.AreEqual(val2, tVTypeUserAuthorization.ContactTVItemID);
               TVTypeEnum val3 = (TVTypeEnum)3;
               tVTypeUserAuthorization.TVType = val3;
               Assert.AreEqual(val3, tVTypeUserAuthorization.TVType);
               TVAuthEnum val4 = (TVAuthEnum)3;
               tVTypeUserAuthorization.TVAuth = val4;
               Assert.AreEqual(val4, tVTypeUserAuthorization.TVAuth);
               DateTime val5 = new DateTime(2010, 3, 4);
               tVTypeUserAuthorization.LastUpdateDate_UTC = val5;
               Assert.AreEqual(val5, tVTypeUserAuthorization.LastUpdateDate_UTC);
               int val6 = 45;
               tVTypeUserAuthorization.LastUpdateContactTVItemID = val6;
               Assert.AreEqual(val6, tVTypeUserAuthorization.LastUpdateContactTVItemID);
               bool val7 = true;
               tVTypeUserAuthorization.HasErrors = val7;
               Assert.AreEqual(val7, tVTypeUserAuthorization.HasErrors);
               IEnumerable<ValidationResult> val24 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               tVTypeUserAuthorization.ValidationResults = val24;
               Assert.AreEqual(val24, tVTypeUserAuthorization.ValidationResults);
        }
        [TestMethod]
        public void TVTypeUserAuthorizationExtraA_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               tVTypeUserAuthorizationExtraA.ContactName = val1;
               Assert.AreEqual(val1, tVTypeUserAuthorizationExtraA.ContactName);
               string val2 = "Some text";
               tVTypeUserAuthorizationExtraA.LastUpdateContactText = val2;
               Assert.AreEqual(val2, tVTypeUserAuthorizationExtraA.LastUpdateContactText);
               string val3 = "Some text";
               tVTypeUserAuthorizationExtraA.TVTypeText = val3;
               Assert.AreEqual(val3, tVTypeUserAuthorizationExtraA.TVTypeText);
               string val4 = "Some text";
               tVTypeUserAuthorizationExtraA.TVAuthText = val4;
               Assert.AreEqual(val4, tVTypeUserAuthorizationExtraA.TVAuthText);
               int val5 = 45;
               tVTypeUserAuthorizationExtraA.TVTypeUserAuthorizationID = val5;
               Assert.AreEqual(val5, tVTypeUserAuthorizationExtraA.TVTypeUserAuthorizationID);
               int val6 = 45;
               tVTypeUserAuthorizationExtraA.ContactTVItemID = val6;
               Assert.AreEqual(val6, tVTypeUserAuthorizationExtraA.ContactTVItemID);
               TVTypeEnum val7 = (TVTypeEnum)3;
               tVTypeUserAuthorizationExtraA.TVType = val7;
               Assert.AreEqual(val7, tVTypeUserAuthorizationExtraA.TVType);
               TVAuthEnum val8 = (TVAuthEnum)3;
               tVTypeUserAuthorizationExtraA.TVAuth = val8;
               Assert.AreEqual(val8, tVTypeUserAuthorizationExtraA.TVAuth);
               DateTime val9 = new DateTime(2010, 3, 4);
               tVTypeUserAuthorizationExtraA.LastUpdateDate_UTC = val9;
               Assert.AreEqual(val9, tVTypeUserAuthorizationExtraA.LastUpdateDate_UTC);
               int val10 = 45;
               tVTypeUserAuthorizationExtraA.LastUpdateContactTVItemID = val10;
               Assert.AreEqual(val10, tVTypeUserAuthorizationExtraA.LastUpdateContactTVItemID);
               bool val11 = true;
               tVTypeUserAuthorizationExtraA.HasErrors = val11;
               Assert.AreEqual(val11, tVTypeUserAuthorizationExtraA.HasErrors);
               IEnumerable<ValidationResult> val36 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               tVTypeUserAuthorizationExtraA.ValidationResults = val36;
               Assert.AreEqual(val36, tVTypeUserAuthorizationExtraA.ValidationResults);
        }
        [TestMethod]
        public void TVTypeUserAuthorizationExtraB_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               tVTypeUserAuthorizationExtraB.TVTypeUserAuthorizationReportTest = val1;
               Assert.AreEqual(val1, tVTypeUserAuthorizationExtraB.TVTypeUserAuthorizationReportTest);
               string val2 = "Some text";
               tVTypeUserAuthorizationExtraB.ContactName = val2;
               Assert.AreEqual(val2, tVTypeUserAuthorizationExtraB.ContactName);
               string val3 = "Some text";
               tVTypeUserAuthorizationExtraB.LastUpdateContactText = val3;
               Assert.AreEqual(val3, tVTypeUserAuthorizationExtraB.LastUpdateContactText);
               string val4 = "Some text";
               tVTypeUserAuthorizationExtraB.TVTypeText = val4;
               Assert.AreEqual(val4, tVTypeUserAuthorizationExtraB.TVTypeText);
               string val5 = "Some text";
               tVTypeUserAuthorizationExtraB.TVAuthText = val5;
               Assert.AreEqual(val5, tVTypeUserAuthorizationExtraB.TVAuthText);
               int val6 = 45;
               tVTypeUserAuthorizationExtraB.TVTypeUserAuthorizationID = val6;
               Assert.AreEqual(val6, tVTypeUserAuthorizationExtraB.TVTypeUserAuthorizationID);
               int val7 = 45;
               tVTypeUserAuthorizationExtraB.ContactTVItemID = val7;
               Assert.AreEqual(val7, tVTypeUserAuthorizationExtraB.ContactTVItemID);
               TVTypeEnum val8 = (TVTypeEnum)3;
               tVTypeUserAuthorizationExtraB.TVType = val8;
               Assert.AreEqual(val8, tVTypeUserAuthorizationExtraB.TVType);
               TVAuthEnum val9 = (TVAuthEnum)3;
               tVTypeUserAuthorizationExtraB.TVAuth = val9;
               Assert.AreEqual(val9, tVTypeUserAuthorizationExtraB.TVAuth);
               DateTime val10 = new DateTime(2010, 3, 4);
               tVTypeUserAuthorizationExtraB.LastUpdateDate_UTC = val10;
               Assert.AreEqual(val10, tVTypeUserAuthorizationExtraB.LastUpdateDate_UTC);
               int val11 = 45;
               tVTypeUserAuthorizationExtraB.LastUpdateContactTVItemID = val11;
               Assert.AreEqual(val11, tVTypeUserAuthorizationExtraB.LastUpdateContactTVItemID);
               bool val12 = true;
               tVTypeUserAuthorizationExtraB.HasErrors = val12;
               Assert.AreEqual(val12, tVTypeUserAuthorizationExtraB.HasErrors);
               IEnumerable<ValidationResult> val39 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               tVTypeUserAuthorizationExtraB.ValidationResults = val39;
               Assert.AreEqual(val39, tVTypeUserAuthorizationExtraB.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
