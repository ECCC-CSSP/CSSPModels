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
    public partial class ContactTest : SetupData
    {
        [TestMethod]
        public void Contact_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ContactID", "Id", "ContactTVItemID", "LoginEmail", "FirstName", "LastName", "Initial", "WebName", "ContactTitle", "IsAdmin", "EmailValidated", "Disabled", "IsNew", "SamplingPlanner_ProvincesTVItemID", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "ParentTVItemID",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.Contact).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(Contact).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Contact_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() { "ContactTVItem",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() { "ContactLogins", "ContactPreferences", "ContactShortcuts",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Contact).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Contact).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void Contact_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(Contact).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void Contact_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.ContactContactID);
               Assert.IsNotNull(ModelsRes.ContactId);
               Assert.IsNotNull(ModelsRes.ContactContactTVItemID);
               Assert.IsNotNull(ModelsRes.ContactLoginEmail);
               Assert.IsNotNull(ModelsRes.ContactFirstName);
               Assert.IsNotNull(ModelsRes.ContactLastName);
               Assert.IsNotNull(ModelsRes.ContactInitial);
               Assert.IsNotNull(ModelsRes.ContactWebName);
               Assert.IsNotNull(ModelsRes.ContactContactTitle);
               Assert.IsNotNull(ModelsRes.ContactIsAdmin);
               Assert.IsNotNull(ModelsRes.ContactEmailValidated);
               Assert.IsNotNull(ModelsRes.ContactDisabled);
               Assert.IsNotNull(ModelsRes.ContactIsNew);
               Assert.IsNotNull(ModelsRes.ContactSamplingPlanner_ProvincesTVItemID);
               Assert.IsNotNull(ModelsRes.ContactLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.ContactLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.ContactContactLogins);
               Assert.IsNotNull(ModelsRes.ContactContactPreferences);
               Assert.IsNotNull(ModelsRes.ContactContactShortcuts);
               Assert.IsNotNull(ModelsRes.ContactContactTVItem);
               Assert.IsNotNull(ModelsRes.ContactParentTVItemID);
        }
        [TestMethod]
        public void Contact_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               contact.ContactID = val1;
               Assert.AreEqual(val1, contact.ContactID);
               string val2 = "Some text";
               contact.Id = val2;
               Assert.AreEqual(val2, contact.Id);
               int val3 = 45;
               contact.ContactTVItemID = val3;
               Assert.AreEqual(val3, contact.ContactTVItemID);
               string val4 = "Some text";
               contact.LoginEmail = val4;
               Assert.AreEqual(val4, contact.LoginEmail);
               string val5 = "Some text";
               contact.FirstName = val5;
               Assert.AreEqual(val5, contact.FirstName);
               string val6 = "Some text";
               contact.LastName = val6;
               Assert.AreEqual(val6, contact.LastName);
               string val7 = "Some text";
               contact.Initial = val7;
               Assert.AreEqual(val7, contact.Initial);
               string val8 = "Some text";
               contact.WebName = val8;
               Assert.AreEqual(val8, contact.WebName);
               ContactTitleEnum val9 = (ContactTitleEnum)3;
               contact.ContactTitle = val9;
               Assert.AreEqual(val9, contact.ContactTitle);
               bool val10 = true;
               contact.IsAdmin = val10;
               Assert.AreEqual(val10, contact.IsAdmin);
               bool val11 = true;
               contact.EmailValidated = val11;
               Assert.AreEqual(val11, contact.EmailValidated);
               bool val12 = true;
               contact.Disabled = val12;
               Assert.AreEqual(val12, contact.Disabled);
               bool val13 = true;
               contact.IsNew = val13;
               Assert.AreEqual(val13, contact.IsNew);
               string val14 = "Some text";
               contact.SamplingPlanner_ProvincesTVItemID = val14;
               Assert.AreEqual(val14, contact.SamplingPlanner_ProvincesTVItemID);
               DateTime val15 = new DateTime(2010, 3, 4);
               contact.LastUpdateDate_UTC = val15;
               Assert.AreEqual(val15, contact.LastUpdateDate_UTC);
               int val16 = 45;
               contact.LastUpdateContactTVItemID = val16;
               Assert.AreEqual(val16, contact.LastUpdateContactTVItemID);
               int val21 = 45;
               contact.ParentTVItemID = val21;
               Assert.AreEqual(val21, contact.ParentTVItemID);
               ICollection<ContactLogin> val39 = new List<ContactLogin>();
               contact.ContactLogins = val39;
               Assert.AreEqual(val39, contact.ContactLogins);
               ICollection<ContactPreference> val40 = new List<ContactPreference>();
               contact.ContactPreferences = val40;
               Assert.AreEqual(val40, contact.ContactPreferences);
               ICollection<ContactShortcut> val41 = new List<ContactShortcut>();
               contact.ContactShortcuts = val41;
               Assert.AreEqual(val41, contact.ContactShortcuts);
               TVItem val42 = new TVItem();
               contact.ContactTVItem = val42;
               Assert.AreEqual(val42, contact.ContactTVItem);
               IEnumerable<ValidationResult> val66 = new List<ValidationResult>().AsEnumerable();
               contact.ValidationResults = val66;
               Assert.AreEqual(val66, contact.ValidationResults);
        }
    }
}
