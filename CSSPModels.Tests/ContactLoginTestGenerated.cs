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
    public partial class ContactLoginTest : SetupData
    {
        [TestMethod]
        public void ContactLogin_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ContactLoginID", "ContactID", "LoginEmail", "PasswordHash", "PasswordSalt", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "LastUpdateContactTVText", "Password", "ConfirmPassword",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.ContactLogin).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(ContactLogin).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ContactLogin_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactLogin).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactLogin).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ContactLogin_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ContactLogin).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ContactLogin_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.ContactLoginContactLoginID);
               Assert.IsNotNull(ModelsRes.ContactLoginContactID);
               Assert.IsNotNull(ModelsRes.ContactLoginLoginEmail);
               Assert.IsNotNull(ModelsRes.ContactLoginPasswordHash);
               Assert.IsNotNull(ModelsRes.ContactLoginPasswordSalt);
               Assert.IsNotNull(ModelsRes.ContactLoginLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.ContactLoginLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.ContactLoginLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.ContactLoginPassword);
               Assert.IsNotNull(ModelsRes.ContactLoginConfirmPassword);
        }
        [TestMethod]
        public void ContactLogin_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               contactLogin.ContactLoginID = val1;
               Assert.AreEqual(val1, contactLogin.ContactLoginID);
               int val2 = 45;
               contactLogin.ContactID = val2;
               Assert.AreEqual(val2, contactLogin.ContactID);
               string val3 = "Some text";
               contactLogin.LoginEmail = val3;
               Assert.AreEqual(val3, contactLogin.LoginEmail);
               byte[] val4 = new byte[5];
               contactLogin.PasswordHash = val4;
               Assert.AreEqual(val4, contactLogin.PasswordHash);
               byte[] val5 = new byte[5];
               contactLogin.PasswordSalt = val5;
               Assert.AreEqual(val5, contactLogin.PasswordSalt);
               DateTime val6 = new DateTime(2010, 3, 4);
               contactLogin.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, contactLogin.LastUpdateDate_UTC);
               int val7 = 45;
               contactLogin.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, contactLogin.LastUpdateContactTVItemID);
               string val8 = "Some text";
               contactLogin.LastUpdateContactTVText = val8;
               Assert.AreEqual(val8, contactLogin.LastUpdateContactTVText);
               string val9 = "Some text";
               contactLogin.Password = val9;
               Assert.AreEqual(val9, contactLogin.Password);
               string val10 = "Some text";
               contactLogin.ConfirmPassword = val10;
               Assert.AreEqual(val10, contactLogin.ConfirmPassword);
               IEnumerable<ValidationResult> val33 = new List<ValidationResult>().AsEnumerable();
               contactLogin.ValidationResults = val33;
               Assert.AreEqual(val33, contactLogin.ValidationResults);
        }
    }
}
