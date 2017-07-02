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
    public partial class RegisterTest
    {
        [TestMethod]
        public void Register_Properties_OK()
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
        public void Register_Has_ValidationResults_OK()
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
    }
}
