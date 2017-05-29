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
    public partial class AspNetUserTest
    {
        [TestMethod]
        public void AspNetUser_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "Id", "Email", "EmailConfirmed", "PasswordHash", "SecurityStamp", "PhoneNumber", "PhoneNumberConfirmed", "TwoFactorEnabled", "LockoutEndDateUtc", "LockoutEnabled", "AccessFailedCount", "UserName",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "Password",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (IProperty propertyType in entityType.GetProperties().OrderBy(c => c.Name))
            {
                Assert.AreEqual(propNameList[index], propertyType.Name);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AspNetUser).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void AspNetUser_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() { "AspNetUserClaims", "AspNetUserLogins", "AspNetUserRoles", "Contacts",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (string foreignName in (from c in entityType.GetForeignKeys() orderby c.DependentToPrincipal.Name select c.DependentToPrincipal.Name))
            {
                Assert.AreEqual(foreignNameList[index], foreignName);
                index += 1;
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(AspNetUser).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void AspNetUser_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(AspNetUser).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void AspNetUser_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.AspNetUserId);
               Assert.IsNotNull(ModelsRes.AspNetUserEmail);
               Assert.IsNotNull(ModelsRes.AspNetUserEmailConfirmed);
               Assert.IsNotNull(ModelsRes.AspNetUserPasswordHash);
               Assert.IsNotNull(ModelsRes.AspNetUserSecurityStamp);
               Assert.IsNotNull(ModelsRes.AspNetUserPhoneNumber);
               Assert.IsNotNull(ModelsRes.AspNetUserPhoneNumberConfirmed);
               Assert.IsNotNull(ModelsRes.AspNetUserTwoFactorEnabled);
               Assert.IsNotNull(ModelsRes.AspNetUserLockoutEndDateUtc);
               Assert.IsNotNull(ModelsRes.AspNetUserLockoutEnabled);
               Assert.IsNotNull(ModelsRes.AspNetUserAccessFailedCount);
               Assert.IsNotNull(ModelsRes.AspNetUserUserName);
               Assert.IsNotNull(ModelsRes.AspNetUserAspNetUserClaims);
               Assert.IsNotNull(ModelsRes.AspNetUserAspNetUserLogins);
               Assert.IsNotNull(ModelsRes.AspNetUserAspNetUserRoles);
               Assert.IsNotNull(ModelsRes.AspNetUserContacts);
               Assert.IsNotNull(ModelsRes.AspNetUserPassword);
        }
    }
}
