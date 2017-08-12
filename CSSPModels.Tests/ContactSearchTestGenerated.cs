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
    public partial class ContactSearchTest : SetupData
    {
        [TestMethod]
        public void ContactSearch_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ContactID", "ContactTVItemID", "FullName", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ContactSearch).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void ContactSearch_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ContactSearch).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ContactSearch_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.ContactSearchContactID);
               Assert.IsNotNull(ModelsRes.ContactSearchContactTVItemID);
               Assert.IsNotNull(ModelsRes.ContactSearchFullName);
               Assert.IsNotNull(ModelsRes.ContactSearchHasErrors);
        }
        [TestMethod]
        public void ContactSearch_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               contactSearch.ContactID = val1;
               Assert.AreEqual(val1, contactSearch.ContactID);
               int val2 = 45;
               contactSearch.ContactTVItemID = val2;
               Assert.AreEqual(val2, contactSearch.ContactTVItemID);
               string val3 = "Some text";
               contactSearch.FullName = val3;
               Assert.AreEqual(val3, contactSearch.FullName);
               bool val4 = true;
               contactSearch.HasErrors = val4;
               Assert.AreEqual(val4, contactSearch.HasErrors);
               IEnumerable<ValidationResult> val15 = new List<ValidationResult>().AsEnumerable();
               contactSearch.ValidationResults = val15;
               Assert.AreEqual(val15, contactSearch.ValidationResults);
        }
    }
}
