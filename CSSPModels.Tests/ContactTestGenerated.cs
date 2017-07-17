using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Globalization;
using System.Transactions;
using System.Collections.Generic;
using CSSPModels.Resources;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;

namespace CSSPModels.Tests
{
    public partial class ContactTest
    {
        [TestMethod]
        public void Contact_Properties_OK()
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
        public void Contact_Navigation_OK()
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
        public void Contact_Has_ValidationResults_OK()
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
    }
}
