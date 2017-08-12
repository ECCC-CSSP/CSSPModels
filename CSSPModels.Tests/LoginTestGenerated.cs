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
    public partial class LoginTest : SetupData
    {
        [TestMethod]
        public void Login_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LoginEmail", "Password", "ConfirmPassword", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Login).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void Login_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(Login).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void Login_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.LoginLoginEmail);
               Assert.IsNotNull(ModelsRes.LoginPassword);
               Assert.IsNotNull(ModelsRes.LoginConfirmPassword);
               Assert.IsNotNull(ModelsRes.LoginHasErrors);
        }
        [TestMethod]
        public void Login_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               login.LoginEmail = val1;
               Assert.AreEqual(val1, login.LoginEmail);
               string val2 = "Some text";
               login.Password = val2;
               Assert.AreEqual(val2, login.Password);
               string val3 = "Some text";
               login.ConfirmPassword = val3;
               Assert.AreEqual(val3, login.ConfirmPassword);
               bool val4 = true;
               login.HasErrors = val4;
               Assert.AreEqual(val4, login.HasErrors);
               IEnumerable<ValidationResult> val15 = new List<ValidationResult>().AsEnumerable();
               login.ValidationResults = val15;
               Assert.AreEqual(val15, login.ValidationResults);
        }
    }
}
