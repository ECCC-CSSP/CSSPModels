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
    public partial class EmailDistributionListContactTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private EmailDistributionListContact emailDistributionListContact { get; set; }
        private EmailDistributionListContactWeb emailDistributionListContactWeb { get; set; }
        private EmailDistributionListContactReport emailDistributionListContactReport { get; set; }
        #endregion Properties

        #region Constructors
        public EmailDistributionListContactTest()
        {
            emailDistributionListContact = new EmailDistributionListContact();
            emailDistributionListContactWeb = new EmailDistributionListContactWeb();
            emailDistributionListContactReport = new EmailDistributionListContactReport();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void EmailDistributionListContact_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "EmailDistributionListContactID", "EmailDistributionListID", "IsCC", "Name", "Email", "CMPRainfallSeasonal", "CMPWastewater", "EmergencyWeather", "EmergencyWastewater", "ReopeningAllTypes", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContact).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContact).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void EmailDistributionListContactWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactTVItemLanguage", "EmailDistributionListContactID", "EmailDistributionListID", "IsCC", "Name", "Email", "CMPRainfallSeasonal", "CMPWastewater", "EmergencyWeather", "EmergencyWastewater", "ReopeningAllTypes", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactWeb).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void EmailDistributionListContactReport_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "EmailDistributionListContactReportTest", "LastUpdateContactTVItemLanguage", "EmailDistributionListContactID", "EmailDistributionListID", "IsCC", "Name", "Email", "CMPRainfallSeasonal", "CMPWastewater", "EmergencyWeather", "EmergencyWastewater", "ReopeningAllTypes", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactReport).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void EmailDistributionListContact_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContact).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContact).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void EmailDistributionListContactWeb_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactWeb).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void EmailDistributionListContactReport_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactReport).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(EmailDistributionListContactReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void EmailDistributionListContact_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(EmailDistributionListContact).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void EmailDistributionListContactWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(EmailDistributionListContactWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void EmailDistributionListContactReport_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(EmailDistributionListContactReport).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void EmailDistributionListContact_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               emailDistributionListContact.EmailDistributionListContactID = val1;
               Assert.AreEqual(val1, emailDistributionListContact.EmailDistributionListContactID);
               int val2 = 45;
               emailDistributionListContact.EmailDistributionListID = val2;
               Assert.AreEqual(val2, emailDistributionListContact.EmailDistributionListID);
               bool val3 = true;
               emailDistributionListContact.IsCC = val3;
               Assert.AreEqual(val3, emailDistributionListContact.IsCC);
               string val4 = "Some text";
               emailDistributionListContact.Name = val4;
               Assert.AreEqual(val4, emailDistributionListContact.Name);
               string val5 = "Some text";
               emailDistributionListContact.Email = val5;
               Assert.AreEqual(val5, emailDistributionListContact.Email);
               bool val6 = true;
               emailDistributionListContact.CMPRainfallSeasonal = val6;
               Assert.AreEqual(val6, emailDistributionListContact.CMPRainfallSeasonal);
               bool val7 = true;
               emailDistributionListContact.CMPWastewater = val7;
               Assert.AreEqual(val7, emailDistributionListContact.CMPWastewater);
               bool val8 = true;
               emailDistributionListContact.EmergencyWeather = val8;
               Assert.AreEqual(val8, emailDistributionListContact.EmergencyWeather);
               bool val9 = true;
               emailDistributionListContact.EmergencyWastewater = val9;
               Assert.AreEqual(val9, emailDistributionListContact.EmergencyWastewater);
               bool val10 = true;
               emailDistributionListContact.ReopeningAllTypes = val10;
               Assert.AreEqual(val10, emailDistributionListContact.ReopeningAllTypes);
               DateTime val11 = new DateTime(2010, 3, 4);
               emailDistributionListContact.LastUpdateDate_UTC = val11;
               Assert.AreEqual(val11, emailDistributionListContact.LastUpdateDate_UTC);
               int val12 = 45;
               emailDistributionListContact.LastUpdateContactTVItemID = val12;
               Assert.AreEqual(val12, emailDistributionListContact.LastUpdateContactTVItemID);
               bool val13 = true;
               emailDistributionListContact.HasErrors = val13;
               Assert.AreEqual(val13, emailDistributionListContact.HasErrors);
               IEnumerable<ValidationResult> val42 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               emailDistributionListContact.ValidationResults = val42;
               Assert.AreEqual(val42, emailDistributionListContact.ValidationResults);
        }
        [TestMethod]
        public void EmailDistributionListContactWeb_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               emailDistributionListContactWeb.LastUpdateContactTVItemLanguage = val1;
               Assert.AreEqual(val1, emailDistributionListContactWeb.LastUpdateContactTVItemLanguage);
               int val2 = 45;
               emailDistributionListContactWeb.EmailDistributionListContactID = val2;
               Assert.AreEqual(val2, emailDistributionListContactWeb.EmailDistributionListContactID);
               int val3 = 45;
               emailDistributionListContactWeb.EmailDistributionListID = val3;
               Assert.AreEqual(val3, emailDistributionListContactWeb.EmailDistributionListID);
               bool val4 = true;
               emailDistributionListContactWeb.IsCC = val4;
               Assert.AreEqual(val4, emailDistributionListContactWeb.IsCC);
               string val5 = "Some text";
               emailDistributionListContactWeb.Name = val5;
               Assert.AreEqual(val5, emailDistributionListContactWeb.Name);
               string val6 = "Some text";
               emailDistributionListContactWeb.Email = val6;
               Assert.AreEqual(val6, emailDistributionListContactWeb.Email);
               bool val7 = true;
               emailDistributionListContactWeb.CMPRainfallSeasonal = val7;
               Assert.AreEqual(val7, emailDistributionListContactWeb.CMPRainfallSeasonal);
               bool val8 = true;
               emailDistributionListContactWeb.CMPWastewater = val8;
               Assert.AreEqual(val8, emailDistributionListContactWeb.CMPWastewater);
               bool val9 = true;
               emailDistributionListContactWeb.EmergencyWeather = val9;
               Assert.AreEqual(val9, emailDistributionListContactWeb.EmergencyWeather);
               bool val10 = true;
               emailDistributionListContactWeb.EmergencyWastewater = val10;
               Assert.AreEqual(val10, emailDistributionListContactWeb.EmergencyWastewater);
               bool val11 = true;
               emailDistributionListContactWeb.ReopeningAllTypes = val11;
               Assert.AreEqual(val11, emailDistributionListContactWeb.ReopeningAllTypes);
               DateTime val12 = new DateTime(2010, 3, 4);
               emailDistributionListContactWeb.LastUpdateDate_UTC = val12;
               Assert.AreEqual(val12, emailDistributionListContactWeb.LastUpdateDate_UTC);
               int val13 = 45;
               emailDistributionListContactWeb.LastUpdateContactTVItemID = val13;
               Assert.AreEqual(val13, emailDistributionListContactWeb.LastUpdateContactTVItemID);
               bool val14 = true;
               emailDistributionListContactWeb.HasErrors = val14;
               Assert.AreEqual(val14, emailDistributionListContactWeb.HasErrors);
               IEnumerable<ValidationResult> val45 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               emailDistributionListContactWeb.ValidationResults = val45;
               Assert.AreEqual(val45, emailDistributionListContactWeb.ValidationResults);
        }
        [TestMethod]
        public void EmailDistributionListContactReport_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               emailDistributionListContactReport.EmailDistributionListContactReportTest = val1;
               Assert.AreEqual(val1, emailDistributionListContactReport.EmailDistributionListContactReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               emailDistributionListContactReport.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, emailDistributionListContactReport.LastUpdateContactTVItemLanguage);
               int val3 = 45;
               emailDistributionListContactReport.EmailDistributionListContactID = val3;
               Assert.AreEqual(val3, emailDistributionListContactReport.EmailDistributionListContactID);
               int val4 = 45;
               emailDistributionListContactReport.EmailDistributionListID = val4;
               Assert.AreEqual(val4, emailDistributionListContactReport.EmailDistributionListID);
               bool val5 = true;
               emailDistributionListContactReport.IsCC = val5;
               Assert.AreEqual(val5, emailDistributionListContactReport.IsCC);
               string val6 = "Some text";
               emailDistributionListContactReport.Name = val6;
               Assert.AreEqual(val6, emailDistributionListContactReport.Name);
               string val7 = "Some text";
               emailDistributionListContactReport.Email = val7;
               Assert.AreEqual(val7, emailDistributionListContactReport.Email);
               bool val8 = true;
               emailDistributionListContactReport.CMPRainfallSeasonal = val8;
               Assert.AreEqual(val8, emailDistributionListContactReport.CMPRainfallSeasonal);
               bool val9 = true;
               emailDistributionListContactReport.CMPWastewater = val9;
               Assert.AreEqual(val9, emailDistributionListContactReport.CMPWastewater);
               bool val10 = true;
               emailDistributionListContactReport.EmergencyWeather = val10;
               Assert.AreEqual(val10, emailDistributionListContactReport.EmergencyWeather);
               bool val11 = true;
               emailDistributionListContactReport.EmergencyWastewater = val11;
               Assert.AreEqual(val11, emailDistributionListContactReport.EmergencyWastewater);
               bool val12 = true;
               emailDistributionListContactReport.ReopeningAllTypes = val12;
               Assert.AreEqual(val12, emailDistributionListContactReport.ReopeningAllTypes);
               DateTime val13 = new DateTime(2010, 3, 4);
               emailDistributionListContactReport.LastUpdateDate_UTC = val13;
               Assert.AreEqual(val13, emailDistributionListContactReport.LastUpdateDate_UTC);
               int val14 = 45;
               emailDistributionListContactReport.LastUpdateContactTVItemID = val14;
               Assert.AreEqual(val14, emailDistributionListContactReport.LastUpdateContactTVItemID);
               bool val15 = true;
               emailDistributionListContactReport.HasErrors = val15;
               Assert.AreEqual(val15, emailDistributionListContactReport.HasErrors);
               IEnumerable<ValidationResult> val48 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               emailDistributionListContactReport.ValidationResults = val48;
               Assert.AreEqual(val48, emailDistributionListContactReport.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
