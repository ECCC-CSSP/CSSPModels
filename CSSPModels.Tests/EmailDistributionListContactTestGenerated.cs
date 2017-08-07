using System;
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
    public partial class EmailDistributionListContactTest : SetupData
    {
        [TestMethod]
        public void EmailDistributionListContact_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "EmailDistributionListContactID", "EmailDistributionListID", "IsCC", "Agency", "Name", "Email", "CMPRainfallSeasonal", "CMPWastewater", "EmergencyWeather", "EmergencyWastewater", "ReopeningAllTypes", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

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
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactEmailDistributionListContactID);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactEmailDistributionListID);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactIsCC);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactAgency);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactName);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactEmail);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactCMPRainfallSeasonal);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactCMPWastewater);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactEmergencyWeather);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactEmergencyWastewater);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactReopeningAllTypes);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactLastUpdateContactTVItemID);
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
               emailDistributionListContact.Agency = val4;
               Assert.AreEqual(val4, emailDistributionListContact.Agency);
               string val5 = "Some text";
               emailDistributionListContact.Name = val5;
               Assert.AreEqual(val5, emailDistributionListContact.Name);
               string val6 = "Some text";
               emailDistributionListContact.Email = val6;
               Assert.AreEqual(val6, emailDistributionListContact.Email);
               bool val7 = true;
               emailDistributionListContact.CMPRainfallSeasonal = val7;
               Assert.AreEqual(val7, emailDistributionListContact.CMPRainfallSeasonal);
               bool val8 = true;
               emailDistributionListContact.CMPWastewater = val8;
               Assert.AreEqual(val8, emailDistributionListContact.CMPWastewater);
               bool val9 = true;
               emailDistributionListContact.EmergencyWeather = val9;
               Assert.AreEqual(val9, emailDistributionListContact.EmergencyWeather);
               bool val10 = true;
               emailDistributionListContact.EmergencyWastewater = val10;
               Assert.AreEqual(val10, emailDistributionListContact.EmergencyWastewater);
               bool val11 = true;
               emailDistributionListContact.ReopeningAllTypes = val11;
               Assert.AreEqual(val11, emailDistributionListContact.ReopeningAllTypes);
               DateTime val12 = new DateTime(2010, 3, 4);
               emailDistributionListContact.LastUpdateDate_UTC = val12;
               Assert.AreEqual(val12, emailDistributionListContact.LastUpdateDate_UTC);
               int val13 = 45;
               emailDistributionListContact.LastUpdateContactTVItemID = val13;
               Assert.AreEqual(val13, emailDistributionListContact.LastUpdateContactTVItemID);
               IEnumerable<ValidationResult> val42 = new List<ValidationResult>().AsEnumerable();
               emailDistributionListContact.ValidationResults = val42;
               Assert.AreEqual(val42, emailDistributionListContact.ValidationResults);
        }
    }
}
