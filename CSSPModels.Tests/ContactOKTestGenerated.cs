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
    public partial class ContactOKTest : SetupData
    {
        [TestMethod]
        public void ContactOK_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Error", "ContactID", "ContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactOK).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void ContactOK_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ContactOK).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ContactOK_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.ContactOKError);
               Assert.IsNotNull(ModelsRes.ContactOKContactID);
               Assert.IsNotNull(ModelsRes.ContactOKContactTVItemID);
        }
        [TestMethod]
        public void ContactOK_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               contactOK.Error = val1;
               Assert.AreEqual(val1, contactOK.Error);
               int val2 = 45;
               contactOK.ContactID = val2;
               Assert.AreEqual(val2, contactOK.ContactID);
               int val3 = 45;
               contactOK.ContactTVItemID = val3;
               Assert.AreEqual(val3, contactOK.ContactTVItemID);
               IEnumerable<ValidationResult> val12 = new List<ValidationResult>().AsEnumerable();
               contactOK.ValidationResults = val12;
               Assert.AreEqual(val12, contactOK.ValidationResults);
        }
    }
}
