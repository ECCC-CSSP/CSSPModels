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
    public partial class NewContactTest : SetupData
    {
        [TestMethod]
        public void NewContact_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LoginEmail", "FirstName", "LastName", "Initial", "ContactTitle",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(NewContact).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void NewContact_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(NewContact).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void NewContact_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.NewContactLoginEmail);
               Assert.IsNotNull(ModelsRes.NewContactFirstName);
               Assert.IsNotNull(ModelsRes.NewContactLastName);
               Assert.IsNotNull(ModelsRes.NewContactInitial);
               Assert.IsNotNull(ModelsRes.NewContactContactTitle);
        }
        [TestMethod]
        public void NewContact_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               newContact.LoginEmail = val1;
               Assert.AreEqual(val1, newContact.LoginEmail);
               string val2 = "Some text";
               newContact.FirstName = val2;
               Assert.AreEqual(val2, newContact.FirstName);
               string val3 = "Some text";
               newContact.LastName = val3;
               Assert.AreEqual(val3, newContact.LastName);
               string val4 = "Some text";
               newContact.Initial = val4;
               Assert.AreEqual(val4, newContact.Initial);
               ContactTitleEnum val5 = (ContactTitleEnum)3;
               newContact.ContactTitle = val5;
               Assert.AreEqual(val5, newContact.ContactTitle);
               IEnumerable<ValidationResult> val18 = new List<ValidationResult>().AsEnumerable();
               newContact.ValidationResults = val18;
               Assert.AreEqual(val18, newContact.ValidationResults);
        }
    }
}
