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
            List<string> propNameList = new List<string>() { "EmailDistributionListContactID", "EmailDistributionListID", "IsCC", "Name", "Email", "CMPRainfallSeasonal", "CMPWastewater", "EmergencyWeather", "EmergencyWastewater", "ReopeningAllTypes", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "LastUpdateContactTVText", "HasErrors",  }.OrderBy(c => c).ToList();

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
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactName);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactEmail);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactCMPRainfallSeasonal);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactCMPWastewater);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactEmergencyWeather);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactEmergencyWastewater);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactReopeningAllTypes);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.EmailDistributionListContactHasErrors);
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
               string val13 = "Some text";
               emailDistributionListContact.LastUpdateContactTVText = val13;
               Assert.AreEqual(val13, emailDistributionListContact.LastUpdateContactTVText);
               bool val14 = true;
               emailDistributionListContact.HasErrors = val14;
               Assert.AreEqual(val14, emailDistributionListContact.HasErrors);
               IEnumerable<ValidationResult> val45 = new List<ValidationResult>().AsEnumerable();
               emailDistributionListContact.ValidationResults = val45;
               Assert.AreEqual(val45, emailDistributionListContact.ValidationResults);
        }
    }
}
