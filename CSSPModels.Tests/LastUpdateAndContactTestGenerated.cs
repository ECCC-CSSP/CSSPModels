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
    public partial class LastUpdateAndContactTest : SetupData
    {
        [TestMethod]
        public void LastUpdateAndContact_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Error", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(LastUpdateAndContact).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void LastUpdateAndContact_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(LastUpdateAndContact).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void LastUpdateAndContact_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.LastUpdateAndContactError);
               Assert.IsNotNull(ModelsRes.LastUpdateAndContactLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.LastUpdateAndContactLastUpdateContactTVItemID);
        }
        [TestMethod]
        public void LastUpdateAndContact_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               lastUpdateAndContact.Error = val1;
               Assert.AreEqual(val1, lastUpdateAndContact.Error);
               DateTime val2 = new DateTime(2010, 3, 4);
               lastUpdateAndContact.LastUpdateDate_UTC = val2;
               Assert.AreEqual(val2, lastUpdateAndContact.LastUpdateDate_UTC);
               int val3 = 45;
               lastUpdateAndContact.LastUpdateContactTVItemID = val3;
               Assert.AreEqual(val3, lastUpdateAndContact.LastUpdateContactTVItemID);
               IEnumerable<ValidationResult> val12 = new List<ValidationResult>().AsEnumerable();
               lastUpdateAndContact.ValidationResults = val12;
               Assert.AreEqual(val12, lastUpdateAndContact.ValidationResults);
        }
    }
}
