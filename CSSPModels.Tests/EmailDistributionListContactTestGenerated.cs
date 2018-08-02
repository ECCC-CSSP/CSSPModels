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
        #endregion Properties

        #region Constructors
        public EmailDistributionListContactTest()
        {
            emailDistributionListContact = new EmailDistributionListContact();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void EmailDistributionListContact_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "EmailDistributionListContactID", "EmailDistributionListID", "IsCC", "Name", "Email", "CMPRainfallSeasonal", "CMPWastewater", "EmergencyWeather", "EmergencyWastewater", "ReopeningAllTypes", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "EmailDistributionListContactWeb", "EmailDistributionListContactReport", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.EmailDistributionListContact).GetProperties().OrderBy(c => c.Name))
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
        public void EmailDistributionListContact_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(EmailDistributionListContact).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void EmailDistributionListContact_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.EmailDistributionListContactEmailDistributionListContactID);
               Assert.IsNotNull(CSSPModelsRes.EmailDistributionListContactEmailDistributionListID);
               Assert.IsNotNull(CSSPModelsRes.EmailDistributionListContactIsCC);
               Assert.IsNotNull(CSSPModelsRes.EmailDistributionListContactName);
               Assert.IsNotNull(CSSPModelsRes.EmailDistributionListContactEmail);
               Assert.IsNotNull(CSSPModelsRes.EmailDistributionListContactCMPRainfallSeasonal);
               Assert.IsNotNull(CSSPModelsRes.EmailDistributionListContactCMPWastewater);
               Assert.IsNotNull(CSSPModelsRes.EmailDistributionListContactEmergencyWeather);
               Assert.IsNotNull(CSSPModelsRes.EmailDistributionListContactEmergencyWastewater);
               Assert.IsNotNull(CSSPModelsRes.EmailDistributionListContactReopeningAllTypes);
               Assert.IsNotNull(CSSPModelsRes.EmailDistributionListContactLastUpdateDate_UTC);
               Assert.IsNotNull(CSSPModelsRes.EmailDistributionListContactLastUpdateContactTVItemID);
               Assert.IsNotNull(CSSPModelsRes.EmailDistributionListContactHasErrors);
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
               IEnumerable<ValidationResult> val46 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               emailDistributionListContact.ValidationResults = val46;
               Assert.AreEqual(val46, emailDistributionListContact.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
