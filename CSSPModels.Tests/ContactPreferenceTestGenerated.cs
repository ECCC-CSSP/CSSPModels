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
    public partial class ContactPreferenceTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private ContactPreference contactPreference { get; set; }
        private ContactPreferenceWeb contactPreferenceWeb { get; set; }
        private ContactPreferenceReport contactPreferenceReport { get; set; }
        #endregion Properties

        #region Constructors
        public ContactPreferenceTest()
        {
            contactPreference = new ContactPreference();
            contactPreferenceWeb = new ContactPreferenceWeb();
            contactPreferenceReport = new ContactPreferenceReport();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void ContactPreference_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ContactPreferenceID", "ContactID", "TVType", "MarkerSize", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactPreference).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(ContactPreference).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ContactPreferenceWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactTVItemLanguage", "TVTypeText", "ContactPreferenceID", "ContactID", "TVType", "MarkerSize", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactPreferenceWeb).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(ContactPreferenceWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ContactPreferenceReport_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ContactPreferenceReportTest", "LastUpdateContactTVItemLanguage", "TVTypeText", "ContactPreferenceID", "ContactID", "TVType", "MarkerSize", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactPreferenceReport).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(ContactPreferenceReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ContactPreference_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactPreference).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactPreference).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ContactPreferenceWeb_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactPreferenceWeb).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactPreferenceWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ContactPreferenceReport_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactPreferenceReport).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactPreferenceReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ContactPreference_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ContactPreference).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ContactPreferenceWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ContactPreferenceWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ContactPreferenceReport_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ContactPreferenceReport).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ContactPreference_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               contactPreference.ContactPreferenceID = val1;
               Assert.AreEqual(val1, contactPreference.ContactPreferenceID);
               int val2 = 45;
               contactPreference.ContactID = val2;
               Assert.AreEqual(val2, contactPreference.ContactID);
               TVTypeEnum val3 = (TVTypeEnum)3;
               contactPreference.TVType = val3;
               Assert.AreEqual(val3, contactPreference.TVType);
               int val4 = 45;
               contactPreference.MarkerSize = val4;
               Assert.AreEqual(val4, contactPreference.MarkerSize);
               DateTime val5 = new DateTime(2010, 3, 4);
               contactPreference.LastUpdateDate_UTC = val5;
               Assert.AreEqual(val5, contactPreference.LastUpdateDate_UTC);
               int val6 = 45;
               contactPreference.LastUpdateContactTVItemID = val6;
               Assert.AreEqual(val6, contactPreference.LastUpdateContactTVItemID);
               bool val7 = true;
               contactPreference.HasErrors = val7;
               Assert.AreEqual(val7, contactPreference.HasErrors);
               IEnumerable<ValidationResult> val24 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               contactPreference.ValidationResults = val24;
               Assert.AreEqual(val24, contactPreference.ValidationResults);
        }
        [TestMethod]
        public void ContactPreferenceWeb_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               contactPreferenceWeb.LastUpdateContactTVItemLanguage = val1;
               Assert.AreEqual(val1, contactPreferenceWeb.LastUpdateContactTVItemLanguage);
               string val2 = "Some text";
               contactPreferenceWeb.TVTypeText = val2;
               Assert.AreEqual(val2, contactPreferenceWeb.TVTypeText);
               int val3 = 45;
               contactPreferenceWeb.ContactPreferenceID = val3;
               Assert.AreEqual(val3, contactPreferenceWeb.ContactPreferenceID);
               int val4 = 45;
               contactPreferenceWeb.ContactID = val4;
               Assert.AreEqual(val4, contactPreferenceWeb.ContactID);
               TVTypeEnum val5 = (TVTypeEnum)3;
               contactPreferenceWeb.TVType = val5;
               Assert.AreEqual(val5, contactPreferenceWeb.TVType);
               int val6 = 45;
               contactPreferenceWeb.MarkerSize = val6;
               Assert.AreEqual(val6, contactPreferenceWeb.MarkerSize);
               DateTime val7 = new DateTime(2010, 3, 4);
               contactPreferenceWeb.LastUpdateDate_UTC = val7;
               Assert.AreEqual(val7, contactPreferenceWeb.LastUpdateDate_UTC);
               int val8 = 45;
               contactPreferenceWeb.LastUpdateContactTVItemID = val8;
               Assert.AreEqual(val8, contactPreferenceWeb.LastUpdateContactTVItemID);
               bool val9 = true;
               contactPreferenceWeb.HasErrors = val9;
               Assert.AreEqual(val9, contactPreferenceWeb.HasErrors);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               contactPreferenceWeb.ValidationResults = val30;
               Assert.AreEqual(val30, contactPreferenceWeb.ValidationResults);
        }
        [TestMethod]
        public void ContactPreferenceReport_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               contactPreferenceReport.ContactPreferenceReportTest = val1;
               Assert.AreEqual(val1, contactPreferenceReport.ContactPreferenceReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               contactPreferenceReport.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, contactPreferenceReport.LastUpdateContactTVItemLanguage);
               string val3 = "Some text";
               contactPreferenceReport.TVTypeText = val3;
               Assert.AreEqual(val3, contactPreferenceReport.TVTypeText);
               int val4 = 45;
               contactPreferenceReport.ContactPreferenceID = val4;
               Assert.AreEqual(val4, contactPreferenceReport.ContactPreferenceID);
               int val5 = 45;
               contactPreferenceReport.ContactID = val5;
               Assert.AreEqual(val5, contactPreferenceReport.ContactID);
               TVTypeEnum val6 = (TVTypeEnum)3;
               contactPreferenceReport.TVType = val6;
               Assert.AreEqual(val6, contactPreferenceReport.TVType);
               int val7 = 45;
               contactPreferenceReport.MarkerSize = val7;
               Assert.AreEqual(val7, contactPreferenceReport.MarkerSize);
               DateTime val8 = new DateTime(2010, 3, 4);
               contactPreferenceReport.LastUpdateDate_UTC = val8;
               Assert.AreEqual(val8, contactPreferenceReport.LastUpdateDate_UTC);
               int val9 = 45;
               contactPreferenceReport.LastUpdateContactTVItemID = val9;
               Assert.AreEqual(val9, contactPreferenceReport.LastUpdateContactTVItemID);
               bool val10 = true;
               contactPreferenceReport.HasErrors = val10;
               Assert.AreEqual(val10, contactPreferenceReport.HasErrors);
               IEnumerable<ValidationResult> val33 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               contactPreferenceReport.ValidationResults = val33;
               Assert.AreEqual(val33, contactPreferenceReport.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
