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
    public partial class RegisterTest : SetupData
    {
        [TestMethod]
        public void Register_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LoginEmail", "FirstName", "Initial", "LastName", "WebName", "Password", "ConfirmPassword",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Register).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void Register_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(Register).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void Register_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.RegisterLoginEmail);
               Assert.IsNotNull(ModelsRes.RegisterFirstName);
               Assert.IsNotNull(ModelsRes.RegisterInitial);
               Assert.IsNotNull(ModelsRes.RegisterLastName);
               Assert.IsNotNull(ModelsRes.RegisterWebName);
               Assert.IsNotNull(ModelsRes.RegisterPassword);
               Assert.IsNotNull(ModelsRes.RegisterConfirmPassword);
        }
        [TestMethod]
        public void Register_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               register.LoginEmail = val1;
               Assert.AreEqual(val1, register.LoginEmail);
               string val2 = "Some text";
               register.FirstName = val2;
               Assert.AreEqual(val2, register.FirstName);
               string val3 = "Some text";
               register.Initial = val3;
               Assert.AreEqual(val3, register.Initial);
               string val4 = "Some text";
               register.LastName = val4;
               Assert.AreEqual(val4, register.LastName);
               string val5 = "Some text";
               register.WebName = val5;
               Assert.AreEqual(val5, register.WebName);
               string val6 = "Some text";
               register.Password = val6;
               Assert.AreEqual(val6, register.Password);
               string val7 = "Some text";
               register.ConfirmPassword = val7;
               Assert.AreEqual(val7, register.ConfirmPassword);
               IEnumerable<ValidationResult> val24 = new List<ValidationResult>().AsEnumerable();
               register.ValidationResults = val24;
               Assert.AreEqual(val24, register.ValidationResults);
        }
    }
}
